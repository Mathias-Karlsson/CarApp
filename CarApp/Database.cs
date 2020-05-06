using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarApp
{
    class Database
    {
        public SQLiteConnection dbConn;
        private string databaseFilename = "./car.db.db"; // Punkt är rotten till filen.

        

        public Database()
        {
            //Skapa databasen
            if (!File.Exists(databaseFilename))
            {
                File.Create(databaseFilename);
            }

            //Skapa dbConr, det objekt som håller förbindelsen med databasen
            dbConn = new SQLiteConnection("Data Source=" + databaseFilename);
        }

        public List<Car> GetAllRowsFromCar()
        {
            string qSelect = "SELECT * FROM car;";
            List<Car> listofCars = new List<Car>();


            SQLiteCommand dbCommand = new SQLiteCommand(qSelect, dbConn);
            OpenConnection();

            SQLiteDataReader res = dbCommand.ExecuteReader();

            if (res.HasRows)
            {
                while(res.Read())
                {
                    Car car = new Car(Convert.ToString(res["regNr"]),
                        Convert.ToString(res["make"]),
                        Convert.ToString(res["model"]),
                        Convert.ToInt32(res["year"]),
                        Convert.ToBoolean(res["forSale"])
                        );
                    listofCars.Add(car);
                }
            }
            CloseConnection();

            return listofCars;
        }

        /// <summary>
        /// Öppnar kopplingen till databasen
        /// Om dbConn inte är öppen så öppnar dbConn
        /// </summary>
        public void OpenConnection()
        {
            if (dbConn.State != System.Data.ConnectionState.Open)
            {
                dbConn.Open();
            }
        }

        public int RemoveCarRowByRegNr(string regNr)
        {
            string qDelete = "DELETE FROM car WHERE regNr = @regNr;";

            SQLiteCommand dbCommand = new SQLiteCommand(qDelete, dbConn);
            OpenConnection();

            dbCommand.Parameters.AddWithValue("@regNr", regNr);


            int result = dbCommand.ExecuteNonQuery();
            CloseConnection();
            return result;


        }

        

        /// <summary>
        /// Stänger kopplingen till databasen
        /// Om dbConn inte är stängt så stängs dbConn
        /// </summary>
        public void CloseConnection() 
        {
            if (dbConn.State != System.Data.ConnectionState.Closed)
            {
                dbConn.Close();
            }
        }

        public int AddCarRow(Car car)
        {
            string qInsert = "INSERT INTO car ('regNr', 'make', 'model', 'year', 'forSale') VALUES (@regNr, @make, @model, @year, @forSale); ";

            SQLiteCommand dbCommand = new SQLiteCommand(qInsert, dbConn);
            OpenConnection();

            dbCommand.Parameters.AddWithValue("@regNr", car.GetRegNr());
            dbCommand.Parameters.AddWithValue("@make", car.GetMake());
            dbCommand.Parameters.AddWithValue("@model", car.GetModel());
            dbCommand.Parameters.AddWithValue("@year", car.GetYear());

            if (car.GetForSale())
            {
                dbCommand.Parameters.AddWithValue("@forSale", 1);
            }
            else
            {
                dbCommand.Parameters.AddWithValue("@forSale", 0);
            }

            int result = dbCommand.ExecuteNonQuery();
            CloseConnection();
            return result;

        }

        public int RemoveAllCars()
        {
            string qAllDelete = "DELETE FROM car";

            SQLiteCommand dbCommand = new SQLiteCommand(qAllDelete, dbConn);
            OpenConnection();

            int result = dbCommand.ExecuteNonQuery();

            CloseConnection();
            return result;
        }
    }
}
