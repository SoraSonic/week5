using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace buoi_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


/////////////////////////
        private void label1_Click(object sender, EventArgs e)
        {

        }
        private bool CheckName()
        {
            bool status = true;
            if (textBox1.Text == "")
            {
                errorProvider1.SetError(textBox1, "Please Enter Your Name");
                status = false;
            }
            else
            {
                errorProvider1.SetError(textBox1, "");
            }
            return status;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void Form1_FormClosing_1(object sender, FormClosingEventArgs e)
        {
            DialogResult r;
            r = MessageBox.Show("Do you want to exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (r == DialogResult.No)
                e.Cancel = true;
        }

        //your name not null
        private void textBox1_Leave(object sender, EventArgs e)
        {
            Control ctr = (Control)sender;
            if (ctr.Text.Trim().Length == 0)
                this.errorProvider1.SetError(ctr, "You must enter your name");
            else
                this.errorProvider1.Clear();
        }

        //show button
        private void button1_Click(object sender, EventArgs e)
        {
            int age;
            string s;
            s = "Your name is: " + textBox1.Text + "\n";
            age = DateTime.Now.Year - Convert.ToInt32(textBox2.Text);
            s = s + "Age: " + age.ToString();
            MessageBox.Show(s);
        }

        //year of birth is digit
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            Control ctr = (Control)sender;
            if (ctr.Text.Length > 0 && !Char.IsDigit(ctr.Text[ctr.Text.Length - 1]))
                this.errorProvider1.SetError(ctr, "This is not a valid number");
            else
                this.errorProvider1.Clear();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox1.Focus();
            
        }

        
    }
}
