using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace manolike
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            aim1.Show();
            vision1.Hide();
            config1.Hide();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            aim1.Hide();
            vision1.Show();
            config1.Hide();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            aim1.Hide();
            vision1.Hide();
            config1.Show();
        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
