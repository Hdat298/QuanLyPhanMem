﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyPhanMem
{
    public partial class Register2 : Form
    {
        public Register2()
        {
            InitializeComponent();
            // This line of code is generated by Data Source Configuration Wizard
            nhanVienTableAdapter1.Fill(qldaDataSet1.NhanVien);
        }

        private void Register2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLDADataSet.NhanVien' table. You can move, or remove it, as needed.
            this.nhanVienTableAdapter.Fill(this.qLDADataSet.NhanVien);

        }
    }
}
