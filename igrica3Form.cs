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
    public partial class igrica3Form : Form
    {
        bool jel_moze_da_klikne = false; // ne moze da se klikce
        PictureBox prvi_pogodak; // inicijalizacija
        Random r = new Random();
        Timer klik_vreme = new Timer();
        int vreme = 60; // 60 sekundi
        Timer tajmer = new Timer { Interval = 1000 }; // vreme (1000 milisekundi tj 1 sekunda)
        public igrica3Form()
        {
            InitializeComponent();
        }

        private PictureBox[] pictureBoxes //pravi niz od pictureboxova
        {
            get { return Controls.OfType<PictureBox>().ToArray(); }
        }

        private static IEnumerable<Image> Images // UBACIVANJE SLIKE U FORM
        {
            get
            {
                return new Image[]
                {
                    // nixa ce da napravi 8 slika i onda ce da ih imenuje img1, img2, img3 ...
                   
                    Properties.Resources.img1,
                    Properties.Resources.img2,
                    Properties.Resources.img3,
                    Properties.Resources.img4,
                    Properties.Resources.img5,
                    Properties.Resources.img6,
                    Properties.Resources.img7,
                    Properties.Resources.img8
                };
            }
        }
        private void PocniVreme()
        {
            tajmer.Start();
            tajmer.Tick += delegate // kada tikne desava se ovo pod zagradama, smanji se vreme za jednu sekundu...
            {
                vreme--;
                if (vreme < 0) // kad je vreme ispod nula tj kad je gotovo
                {
                    tajmer.Stop();
                    MessageBox.Show("Kraj vremena!");
                    ResetujSlike();
                }
                // ispisivanje vremena
                var sekund_Vreme = TimeSpan.FromSeconds(vreme);
                vremeLabel.Text = "00: " + vreme.ToString();
            };
        }
        private void ResetujSlike() // resetuje slike
        {
            foreach (var slika in pictureBoxes)
            {
                slika.Tag = null;
                slika.Visible = true;
            }
            SakrijSlike();
            PostaviRandomSlike();
            vreme = 60;
            tajmer.Start();
        }
        private void SakrijSlike() // nixa mora da napravi sliku i nazove je znak_pitanja
        {
            foreach (var slika in pictureBoxes)
            {
                slika.Image = Properties.Resources.znak_pitanja; //postavlja sliku na znak pitanja
            }
        }
        private PictureBox SlobodnoMesto()
        {
            int broj;

            do
            {
                broj = r.Next(0, pictureBoxes.Count());
            }
            while (pictureBoxes[broj].Tag != null);
            return pictureBoxes[broj];
        }

        private void PostaviRandomSlike()
        {
            foreach (var slika in Images)
            {
                SlobodnoMesto().Tag = slika;
                SlobodnoMesto().Tag = slika;
            }
        }

        private void CLICKTIMER_TICK(object sender, EventArgs e)
        {
            SakrijSlike();

            jel_moze_da_klikne = true;
            klik_vreme.Stop();
        }
        private void klikneSliku(object sender, EventArgs e)
        {
            if (!jel_moze_da_klikne) return;

            var slika = (PictureBox)sender;

            if (prvi_pogodak == null)
            {
                prvi_pogodak = slika;
                slika.Image = (Image)slika.Tag;
                return;
            }
            slika.Image = (Image)slika.Tag;

            if (slika.Image == prvi_pogodak.Image && slika != prvi_pogodak)
            {
                slika.Visible = prvi_pogodak.Visible = false;
                {
                    prvi_pogodak = slika;
                }
                SakrijSlike();
            }
            else
            {
                jel_moze_da_klikne = false;
                klik_vreme.Start();
            }
            prvi_pogodak = null;
            if (pictureBoxes.Any(p => p.Visible)) return;
            MessageBox.Show(" Pobedio si \n Probaj ponovo");
            ResetujSlike();

        }
        private void zapocniIgru(object sender, EventArgs e)
        {
            jel_moze_da_klikne = true;
            PostaviRandomSlike();
            SakrijSlike();
            PocniVreme();
            klik_vreme.Interval = 1000;
            klik_vreme.Tick += CLICKTIMER_TICK;
            pocniButton.Enabled = false;
        }

        private void igrica3Form_Load(object sender, EventArgs e)
        {

        }

        private void pocniButton_Click(object sender, EventArgs e)
        {
            jel_moze_da_klikne = true;
            PostaviRandomSlike();
            SakrijSlike();
            PocniVreme();
            klik_vreme.Interval = 1000;
            klik_vreme.Tick += CLICKTIMER_TICK;
            pocniButton.Enabled = false;
        }

        private void nazadButton_Click(object sender, EventArgs e)
        {
            this.Close();
            PocetniMeniForm pocetniMeni = new PocetniMeniForm();
            pocetniMeni.Show();
        }
    }
}
