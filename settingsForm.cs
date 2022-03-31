using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Reflection;
using System.Resources;
using System.Media;
using System.Diagnostics;


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
                sp.Stop();
            }
            else
            {
                ugasiMuzikuButton.Text = "Ugasi muziku";
                ugasiMuzikuButton.BackColor = Color.Salmon;
                Assembly assembly;
                Stream soundStream;
                SoundPlayer sp;
                assembly = Assembly.GetExecutingAssembly();
                sp = new SoundPlayer(assembly.GetManifestResourceStream
                    ("Hackathon_Project_GUI.muzikaZaHackathon.wav")); // uzima muziku iz resorsa iz adrese
                sp.Play();

                sp.PlayLooping();
            }

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (ugasiMuzikuButton.Text == "Ugasi muziku") 
            {
                this.Hide(); // sakriva ovu formu
                PocetniMeniForm pocetniMeni = new PocetniMeniForm(); // kreira novu formu sa meni igricama
                pocetniMeni.Show(); // pokazuje formu - igriceMeniForma
            }
            else
            {
                this.Hide(); // sakriva ovu formu
                PocetniMeniForm pocetniMeni = new PocetniMeniForm(); // kreira novu formu sa meni igricama
                pocetniMeni.Show(); // pokazuje formu - igriceMeniForma
                sp.Stop();
            }
        }

        private void menjanjeVrednostiTrackBaraZaPojacavanje()
        {

        }

        private void pojacavanjeTrackBar_Scroll(object sender, EventArgs e)
        {

        }
    }
}
