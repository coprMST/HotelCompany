﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HiltonCompany
{
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
        }

        private void Settings_Load(object sender, EventArgs e)
        {
            initialCatalog.Text = MainForm.InitialCatalog;
            dataSource.Text = MainForm.DataSource;
        }

        private void goToSave_Click(object sender, EventArgs e)
        {
            MainForm.InitialCatalog = initialCatalog.Text.Trim();
            MainForm.DataSource = dataSource.Text.Trim();
        }

        private void goToStandartSettings_Click(object sender, EventArgs e)
        {
            initialCatalog.Text = "HiltonCompany";
            dataSource.Text = "localhost";
            MainForm.InitialCatalog = initialCatalog.Text.Trim();
            MainForm.DataSource = dataSource.Text.Trim();
        }
    }
}
