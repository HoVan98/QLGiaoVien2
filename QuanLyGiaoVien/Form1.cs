﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BUS;
namespace QuanLyGiaoVien
{
    public partial class Form1 : Form
    {
        Bus_DangNhap dangNhap = new Bus_DangNhap();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dangNhap.DangNhap(txtTaiKhoan.Text, txtMatKhau.Text))
            {
                FormMain f = new FormMain();
                this.Hide();
                f.ShowDialog();
                this.Close();
                List<string> l = dangNhap.layTenND();
            }
            else
            {
                MessageBox.Show("Tên tài khoản hoặc mật khẩu không đúng");
            }

        }
    }
}
