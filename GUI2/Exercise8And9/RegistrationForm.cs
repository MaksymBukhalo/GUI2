﻿using System;
using System.Drawing;
using System.Windows.Forms;

namespace Lab3.Exercise8And9
{
    public partial class RegistrationForm : Form
    {
        public RegistrationForm()
        {
            InitializeComponent();
        }

        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                var lb1 = new Label();
                lb1.Location = new Point(6, 74);
                lb1.Size = new Size(32, 23);
                lb1.Name = "labelll";
                lb1.TabIndex = 2;
                lb1.Text = "PIN2";
                
                groupBox1.Controls.Add(lb1);
                var txt = new TextBox();
                txt.Location = new Point(64, 74);
                txt.Size = new Size(140, 22);
                txt.Name = "textboxx";
                txt.TabIndex = 1;
                txt.Text = "";

                txt.KeyPress += TextBox2_KeyPress;
                groupBox1.Controls.Add(txt);
            }
            else
            {
                int lcv = groupBox1.Controls.Count;
                while (lcv > 4)
                {
                    groupBox1.Controls.RemoveAt(lcv - 1);
                    lcv--;
                }
            }
        }

        private void TextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Поле Name не може містити цифри");
                errorProvider1.SetError(textBox1, "Must be letter");
            }
        }

        private void TextBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Поле PIN може містити лише цифри");
                errorProvider1.SetError(textBox2, "Must be digit");
            }
        }

        private void TextBox2_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(textBox2.Text))
            {
                e.Cancel = false;
            }
            else
            {
                try
                {
                    double.Parse(textBox2.Text);
                    e.Cancel = false;
                }
                catch
                {
                    e.Cancel = true;
                    MessageBox.Show("Поле PIN не може містити букви");
                }
            }
        }

		private void button1_Click(object sender, EventArgs e)
		{
            MessageBox.Show("Ви за реєструвалися");
            this.Close();
        }
	}
}
