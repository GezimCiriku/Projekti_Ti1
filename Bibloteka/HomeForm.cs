﻿using Bibloteka.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bibloteka
{
    public partial class HomeForm : Form
    {
        public HomeForm()
        {
            InitializeComponent();
        }

        private void HomeForm_Load(object sender, EventArgs e)
        {
            
        }

        private void HomeForm_Activated(object sender, EventArgs e)
        {
            lblTotalBooks.Text = LibriBLL.CountBooks().ToString();
            lblIssuedBooks.Text = LibriBLL.CountHuazimet().ToString();
            lblReturnedBooks.Text = LibriBLL.CountKthimet().ToString();

            lblTotalMembers1.Text = PjesemarresiBLL.CountMembers().ToString();
            lblReaders.Text = PjesemarresiBLL.CountReaders().ToString();
        }
    }
}
