﻿using System;
using System.Windows.Forms;

namespace Lab3
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void Exercise1Btn_Click(object sender, EventArgs e)
        {
            new Exercise1.WіnQuestіonForm().ShowDialog();
        }

        private void Exercise2Btn_Click(object sender, EventArgs e)
        {
            new Exercise2.TestListForm().ShowDialog();
        }

        private void Exercise3And4Btn_Click(object sender, EventArgs e)
        {
            new Exercise3And4.MdiApplication().ShowDialog();
        }
        private void Exercise5Btn_Click(object sender, EventArgs e)
        {
            new Exercise5.WinContainer().ShowDialog();
        }

        private void Exercise6And7Btn_Click(object sender, EventArgs e)
        {
            new Exercise6And7.WinLinkLabel().ShowDialog();
        }

        private void Exercise8And9Btn_Click(object sender, EventArgs e)
        {
            new Exercise8And9.RegistrationForm().ShowDialog();
        }
    }
}
