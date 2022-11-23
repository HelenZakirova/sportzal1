using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sportzal1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            abonementi Win = new abonementi();
            Win.Owner = this;
            this.Hide();
            Win.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            uchet Win = new uchet();
            Win.Owner = this;
            this.Hide();
            Win.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            klients Win = new klients();
            Win.Owner = this;
            this.Hide();
            Win.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            treners Win = new treners();
            Win.Owner = this;
            this.Hide();
            Win.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            zali Win = new zali();
            Win.Owner = this;
            this.Hide();
            Win.Show();
        }
    }
}
