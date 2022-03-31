using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows;


namespace Hackathon_Project_GUI
{
    public partial class settingsForm : Form
    {
        System.Media.SoundPlayer sp = new System.Media.SoundPlayer();

        
        
        public settingsForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sp.Stop();
            if (ugasiMuzikuButton.Text == "Ugasi muziku")
            {
                ugasiMuzikuButton.Text = "Upali muziku";
                ugasiMuzikuButton.BackColor = Color.LawnGreen;
            }
            else
            {
                ugasiMuzikuButton.Text = "Ugasi muziku";
                ugasiMuzikuButton.BackColor = Color.Salmon;
            }

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide(); // sakriva ovu formu
            PocetniMeniForm pocetniMeni = new PocetniMeniForm(); // kreira novu formu sa meni igricama
            pocetniMeni.Show(); // pokazuje formu - igriceMeniForma
            sp.Stop();
        }

        private void menjanjeVrednostiTrackBaraZaPojacavanje()
        {

        }

        private void pojacavanjeTrackBar_Scroll(object sender, EventArgs e)
        {

        }
    }
}
