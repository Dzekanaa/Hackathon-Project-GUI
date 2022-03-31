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
    public partial class igrica1Form : Form
    {
        public igrica1Form()
        {
            InitializeComponent();
            KRETANJE();
            
        }
        //kretanje objekata
        private Point firstPoint = new Point();
        public void KRETANJE()
        {
            objekat.MouseDown += (ss, ee) => { 
                if (ee.Button == System.Windows.Forms.MouseButtons.Left) 
                { firstPoint = Control.MousePosition; } };
            objekat.MouseMove += (ss, ee) => { 
                if(ee.Button == System.Windows.Forms.MouseButtons.Left)
                {
                    Point temp = Control.MousePosition;
                    Point res = new Point(firstPoint.X - temp.X, firstPoint.Y - temp.Y);

                    objekat.Location = new Point(objekat.Location.X - res.X, objekat.Location.Y - res.Y);
                    firstPoint = temp;
                }
            };
        }

        

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        //proverava broj poena
        private void button1_Click(object sender, EventArgs e)
        {
            //broji broj tacnih
            int tacno = 0;
            if(objekat.Top>=356 && objekat.Left <= 181)
            {
                tacno++;
            }
            //ispisuje koliko tacnih
            MessageBox.Show("Pogodili ste "+tacno+" od 15.");
        }

        //kad god se stavi u neku oblast, progres se povecava
        private void progres1(object sender, EventArgs e)
        {
            progres.Value += 10;
        }

        private void progres2(object sender, EventArgs e)
        {
            progres.Value += 10;
        }

        private void progres3(object sender, EventArgs e)
        {
            progres.Value += 10;
        }
        //pokazivac radi neponavljanja
        int br = 0;
        private void objekat1(object sender, EventArgs e)
        {
            if (br == 0) { progres.Value += 10; };
            br++;
        }
        //nebitno
        private void objekat_Click(object sender, EventArgs e)
        {

        }
    }
}
