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
    public partial class PocetniMeniForm : Form
    {
        
        public PocetniMeniForm()
        {
            /*string filePath = @"D:\Programiranje\C#\Hackathon Project GUI\Resources\Frankie_MP3_320K_.wav";
            System.Media.SoundPlayer player = new System.Media.SoundPlayer();
            player.Stream = Properties.;
            player.Play();*/

            InitializeComponent();

            Assembly assembly;
            Stream soundStream;
            SoundPlayer sp;
            assembly = Assembly.GetExecutingAssembly();
            sp = new SoundPlayer(assembly.GetManifestResourceStream
                ("Hackathon_Project_GUI.muzikaZaHackathon.wav")); // uzima muziku iz resorsa iz adrese
            sp.Play();

            sp.PlayLooping();
        }

        private void igriceButton_Click(object sender, EventArgs e)
        {
            this.Hide(); // sakriva ovu formu
            igriceMeniForm igriceMeniForma = new igriceMeniForm(); // kreira novu formu sa meni igricama
            igriceMeniForma.Show(); // pokazuje formu - igriceMeniForma
        }

        private void settingsButton_Click(object sender, EventArgs e)
        {
            this.Hide(); 
            settingsForm podesavanja = new settingsForm(); 
            podesavanja.Show(); 
            
        }

        private void lokacijeButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            MapaForm mapForm = new MapaForm();
            mapForm.Show();
        }
    }
}
