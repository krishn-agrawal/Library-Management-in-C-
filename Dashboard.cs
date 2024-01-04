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
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }


        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to quit ?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void addNewBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddNewBook abs = new AddNewBook();
            abs.Show();
        }

        private void studentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            studentToolStripMenuItem.Enabled = true;

        }

        private void addNewStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Add_Student student = new Add_Student();
            student.Show();
        }

        private void issueBookToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Issue_Book newBook = new Issue_Book();
            newBook.Show();
        }

        private void returnBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Return_Book booking = new Return_Book();
            booking.Show();
        }

        private void staffToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Staff_record record = new Staff_record();
            record.Show();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param /name="/sender"></param>
        /// <param /name="e"></param>

        private void issueBookToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Dashboard_Load(object sender, EventArgs e)
        {

        }

        private void sToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void staffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        
    }
}
