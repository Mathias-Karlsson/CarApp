using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.IO;
using Newtonsoft.Json.Linq;

namespace CarApp
{
    public partial class Form1 : Form
    {
        Database dbObject = new Database();
        public Form1()
        {
            InitializeComponent();
            txtRegNr.Focus();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Kontrollera att alla fält är ifyllda
            if (string.IsNullOrEmpty(txtRegNr.Text) || string.IsNullOrEmpty(txtMake.Text))
            {
                MessageBox.Show("Du måste fylla i alla rutor", "Felaktig inmatning");
            }
            else
            // Om alla fält är ifyllda så lägg till i listvyn
            {
                Car car = new Car(txtRegNr.Text, txtMake.Text, txtModel.Text, Convert.ToInt32(txtYear.Text), cbxForSale.Checked);

                // Lägg till bilen i databasen
                int result = dbObject.AddCarRow(car);
                MessageBox.Show("Du har lagt till " + Convert.ToString(result) + " antal bilar");

                ListViewItem item = CreateListViewItem(txtRegNr.Text, txtMake.Text, txtModel.Text, txtYear.Text, cbxForSale.Checked);
                lsvCars.Items.Add(item);
                ClearTextBoxes();
                btnClear.Enabled = true;
            }
        }


        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (lsvCars.SelectedItems.Count > 0)
            {
                var item = lsvCars.SelectedItems[0];
                lsvCars.Items.Remove(item);
                MessageBox.Show("Bilen med registreringsnummer " + item.Text + " är borttagen", "Borttag av bil");
            }
            else
            {
                MessageBox.Show("Ingen bil var markerad att tas bort", "Borttag av bil");
            }
            btnClear.Enabled = (lsvCars.Items.Count > 0);
        }

        private void lsvCars_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnRemove.Enabled = (lsvCars.SelectedItems.Count > 0);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lsvCars.Items.Clear();
            txtRegNr.Focus();
        }

        /// <summary>
        /// Hjälpfunktion till btnAdd_Click
        /// </summary>
        /// <param name="regNr">Text i textbox för Reg Nr</param>
        /// <param name="make">Text i textbox för Märke</param>
        /// <param name="forSale">Text i textbox för till salu, falsk annars</param>
        /// <return></return>
        private ListViewItem CreateListViewItem(string regNr, string make, string model, string year, bool forSale)
        {
            ListViewItem item = new ListViewItem(regNr);
            item.SubItems.Add(make);
            item.SubItems.Add(model);
            item.SubItems.Add(year);
            item.SubItems.Add(forSale ? "Yes" : "No");
            return item;
        }

        /// <summary>
        /// Rensar alla textfält och sätter regnummer till att vara i fokus
        /// </summary>
        private void ClearTextBoxes()
        {
            txtRegNr.Clear();
            txtMake.Clear();
            txtModel.Clear();
            txtYear.Clear();
            cbxForSale.Checked = false;
            txtRegNr.Focus();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtRegNr.Text))
            {
                string regNr = txtRegNr.Text.ToUpper();

                PrintData(regNr);
            }
            else
            {
                MessageBox.Show("Du måste ange ett registeringsnummer", "Inmatning saknas", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
     
        }
        ///<summary>
        ///
        ///</summary>
        ///
        private void PrintData(string regNr)
        {
            /// Exempel https://api.biluppgifter.se/api/v1/vehicle/regno/XNF905?api_token=DtIAxcVeOZhJzLnC6LYN3BjwasJw2FIA5hdvgP00lNKw1cM53ddy1iWpll54

            string token = "DtIAxcVeOZhJzLnC6LYN3BjwasJw2FIA5hdvgP00lNKw1cM53ddy1iWpll54";
            string call = String.Format($"https://api.biluppgifter.se/api/v1/vehicle/regno/{regNr}?api_token={token}");

            try
            {
                WebRequest request = HttpWebRequest.Create(call);

                WebResponse response = request.GetResponse();

                StreamReader reader = new StreamReader(response.GetResponseStream());

                string carJSON = reader.ReadToEnd();

                JObject jsonCar = JObject.Parse(carJSON);

                txtMake.Text = jsonCar["data"]["basic"]["data"]["make"].ToString();
                txtModel.Text = jsonCar["data"]["basic"]["data"]["model"].ToString();
                txtYear.Text = jsonCar["data"]["basic"]["data"]["model_year"].ToString();
            }
            catch (Exception e)
            {
                MessageBox.Show($"Bil med registreringsnummer {regNr} kunde inte hittas \n\nMeddelande: {e.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
