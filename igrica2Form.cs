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
            movetostart();
        }

        private void igrica2Form_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox20_MouseEnter(object sender, EventArgs e)
        {
            MessageBox.Show("Dodirnuli ste zid! Pokusajte ponovo!");
            movetostart();
        }

        private void pictureBox62_MouseEnter(object sender, EventArgs e)
        {
            MessageBox.Show("Pobedili ste! Cestitam!");
            this.Hide();
            igriceMeniForm igricemeni = new igriceMeniForm(); // kreira novu formu sa meni igricama
            igricemeni.Show(); // pokazuje formu - igriceMeniForma
        }

        private void pictureBox60_MouseEnter(object sender, EventArgs e)
        {
            MessageBox.Show("Dodirnuli ste zid! Pokusajte ponovo!");
            movetostart();
        }

        private void movetostart()
        {
            Point startingpoint = pictureBox61.Location;
            startingpoint.Offset(10, 15);
            Cursor.Position = PointToScreen(startingpoint);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide(); // sakriva ovu formu
            igriceMeniForm igricemeni = new igriceMeniForm(); // kreira novu formu sa meni igricama
            igricemeni.Show(); // pokazuje formu - igriceMeniForma
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("U igri lavirint cilj je da pomerate kursor od jednog do drugog kvadrata, tako da ne dodirnete ivice lavirinta");
        }

        private void pictureBox61_Click(object sender, EventArgs e)
        {
            MouseEventArgs me = (MouseEventArgs)e;
            Point coordinates = me.Location;
        }
    }
}
