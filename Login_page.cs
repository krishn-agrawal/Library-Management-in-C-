using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library
{
    public partial class Login_page : Form
    {
        public Login_page()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void Login_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You are successfully login");
            this.Hide();
            Dashboard dsb = new Dashboard();
            dsb.Show();


        }

        /// <summary>
        /// 
        /// </summary>
        /// <param/ name="/sender"></param>
        /// <param /name="e"></param>
        /// 


        
        
        
        
        
        private void pictureBox1_Click(object sender, EventArgs e)
          {

          }

          private void pictureBox2_Click(object sender, EventArgs e)
          {

          }

          private void label1_Click(object sender, EventArgs e)
          {

          }

          private void panel4_Paint(object sender, PaintEventArgs e)
          {

          }

       

       
    }
}
