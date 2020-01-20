using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace my_setup
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.label1.Text = label1.Text;

            if (dataGridView1.SelectedCells.Count > 0)
            {
                f.textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                f.textBox2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                f.ShowDialog();

                
            }






        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            dabaDataContext db = new dabaDataContext();

            var f = db.nbChauffeur();

            label1.DataBindings.Add("text",f, "nb");

            var k = from a in db.Chauffeur select new { a.cinChauffeur, a.nomChauffeur };
            dataGridView1.DataSource = k;
           

            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.ShowDialog();
        }
    }
}
