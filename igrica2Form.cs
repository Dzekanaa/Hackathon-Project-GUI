using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hackathon_Project_GUI
{
    public partial class igrica2Form : Form
    {
        public igrica2Form()
        {
            InitializeComponent();
        }

        private void igrica2Form_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox20_MouseEnter(object sender, EventArgs e)
        {
            MessageBox.Show("Dodirnuli ste zid! Pokusajte ponovo!");
        }

        private void pictureBox62_MouseEnter(object sender, EventArgs e)
        {
            MessageBox.Show("Pobedili ste! Cestitam!");
        }

        private void pictureBox60_MouseEnter(object sender, EventArgs e)
        {
            MessageBox.Show("Dodirnuli ste zid! Pokusajte ponovo!");
        }
    }
}
