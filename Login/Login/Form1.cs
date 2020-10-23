using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        
        
        public void CapsLock()
        {

            if (Control.IsKeyLocked(Keys.CapsLock))
            {
                label4.Text = "Caps Lock on";
                label4.ForeColor = Color.Teal;


            }

            else
            {
                label4.Text = "Caps Lock off";
                label4.ForeColor = Color.DimGray;
            }
        }



        private void button1_Click(object sender, EventArgs e)
        {

           



            if (textBox2.Text == "Key" || textBox2.Text == "key")
            {
                if (textBox1.Text == "admin")
                {
                    MessageBox.Show("Accepted! You are now going to Dashboard..");



                    Form1 frm2 = new Form1();
                    Form2 frm = new Form2();
                    frm.Show();
                    this.Hide();


                }

                else
                {
                    MessageBox.Show("Wrong username or Password..", "Try again");
                }




            }

            else
            {
                MessageBox.Show("Wrong username or Password..", "Try again");
            }


        }

        private void Form1_Load(object sender, EventArgs e)
        {


        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {

            if (Control.IsKeyLocked(Keys.CapsLock))
            {
                label4.Text = "Caps Lock on";
                label4.ForeColor = Color.Teal;


            }

            else
            {
                label4.Text = "Caps Lock off";
                label4.ForeColor = Color.DimGray;
            }
        }
    }
}
