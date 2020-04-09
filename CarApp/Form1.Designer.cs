namespace CarApp
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.txtRegNr = new System.Windows.Forms.TextBox();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.cbxForSale = new System.Windows.Forms.CheckBox();
            this.txtMake = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lsvCars = new System.Windows.Forms.ListView();
            this.regnr = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.make = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.model = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.year = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.forsale = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnClear = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(this.txtYear);
            this.groupBox1.Controls.Add(this.txtRegNr);
            this.groupBox1.Controls.Add(this.txtModel);
            this.groupBox1.Controls.Add(this.cbxForSale);
            this.groupBox1.Controls.Add(this.txtMake);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(696, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(6, 71);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(190, 23);
            this.btnSearch.TabIndex = 7;
            this.btnSearch.Text = "Sök efter bilregistering";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtYear
            // 
            this.txtYear.Location = new System.Drawing.Point(336, 36);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(158, 20);
            this.txtYear.TabIndex = 3;
            // 
            // txtRegNr
            // 
            this.txtRegNr.Location = new System.Drawing.Point(47, 16);
            this.txtRegNr.Name = "txtRegNr";
            this.txtRegNr.Size = new System.Drawing.Size(149, 20);
            this.txtRegNr.TabIndex = 4;
            // 
            // txtModel
            // 
            this.txtModel.Location = new System.Drawing.Point(336, 13);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(158, 20);
            this.txtModel.TabIndex = 2;
            // 
            // cbxForSale
            // 
            this.cbxForSale.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxForSale.AutoSize = true;
            this.cbxForSale.Location = new System.Drawing.Point(590, 12);
            this.cbxForSale.Name = "cbxForSale";
            this.cbxForSale.Size = new System.Drawing.Size(63, 17);
            this.cbxForSale.TabIndex = 6;
            this.cbxForSale.Text = "Till Salu";
            this.cbxForSale.UseVisualStyleBackColor = true;
            // 
            // txtMake
            // 
            this.txtMake.Location = new System.Drawing.Point(47, 39);
            this.txtMake.Name = "txtMake";
            this.txtMake.Size = new System.Drawing.Size(149, 20);
            this.txtMake.TabIndex = 1;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(590, 51);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "Lägg Till";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(295, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "År";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(295, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Model";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Reg Nr";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Märke";
            // 
            // lsvCars
            // 
            this.lsvCars.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lsvCars.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.regnr,
            this.make,
            this.model,
            this.year,
            this.forsale});
            this.lsvCars.HideSelection = false;
            this.lsvCars.Location = new System.Drawing.Point(12, 118);
            this.lsvCars.Name = "lsvCars";
            this.lsvCars.Size = new System.Drawing.Size(696, 201);
            this.lsvCars.TabIndex = 0;
            this.lsvCars.UseCompatibleStateImageBehavior = false;
            this.lsvCars.View = System.Windows.Forms.View.Details;
            this.lsvCars.SelectedIndexChanged += new System.EventHandler(this.lsvCars_SelectedIndexChanged);
            // 
            // regnr
            // 
            this.regnr.Text = "Reg Nr";
            // 
            // make
            // 
            this.make.Text = "Märke";
            // 
            // model
            // 
            this.model.Text = "Model";
            // 
            // year
            // 
            this.year.Text = "År";
            // 
            // forsale
            // 
            this.forsale.Text = "Till Salu";
            // 
            // btnClear
            // 
            this.btnClear.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnClear.Location = new System.Drawing.Point(12, 325);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(109, 23);
            this.btnClear.TabIndex = 7;
            this.btnClear.Text = "Rensa bort all data";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnRemove.Location = new System.Drawing.Point(602, 325);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(106, 23);
            this.btnRemove.TabIndex = 8;
            this.btnRemove.Text = "Ta bort markerad";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 364);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.lsvCars);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.TextBox txtRegNr;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.CheckBox cbxForSale;
        private System.Windows.Forms.TextBox txtMake;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView lsvCars;
        private System.Windows.Forms.ColumnHeader regnr;
        private System.Windows.Forms.ColumnHeader model;
        private System.Windows.Forms.ColumnHeader forsale;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.ColumnHeader make;
        private System.Windows.Forms.ColumnHeader year;
        private System.Windows.Forms.Button btnSearch;
    }
}

