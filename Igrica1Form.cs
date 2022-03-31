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
            KRETANJE2();
            KRETANJE3();
            KRETANJE4();
            KRETANJE5();
            KRETANJE6();
            KRETANJE7();
            KRETANJE8();
            KRETANJE9();
            KRETANJE10();
            KRETANJE11();
            KRETANJE12();

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
        public void KRETANJE2()
        {
            objekat2.MouseDown += (ss, ee) => {
                if (ee.Button == System.Windows.Forms.MouseButtons.Left)
                { firstPoint = Control.MousePosition; }
            };
            objekat2.MouseMove += (ss, ee) => {
                if (ee.Button == System.Windows.Forms.MouseButtons.Left)
                {
                    Point temp = Control.MousePosition;
                    Point res = new Point(firstPoint.X - temp.X, firstPoint.Y - temp.Y);

                    objekat2.Location = new Point(objekat2.Location.X - res.X, objekat2.Location.Y - res.Y);
                    firstPoint = temp;
                }
            };
        }
        public void KRETANJE3()
        {
            objekat3.MouseDown += (ss, ee) => {
                if (ee.Button == System.Windows.Forms.MouseButtons.Left)
                { firstPoint = Control.MousePosition; }
            };
            objekat3.MouseMove += (ss, ee) => {
                if (ee.Button == System.Windows.Forms.MouseButtons.Left)
                {
                    Point temp = Control.MousePosition;
                    Point res = new Point(firstPoint.X - temp.X, firstPoint.Y - temp.Y);

                    objekat3.Location = new Point(objekat3.Location.X - res.X, objekat3.Location.Y - res.Y);
                    firstPoint = temp;
                }
            };
        }
        public void KRETANJE4()
        {
            objekat4.MouseDown += (ss, ee) => {
                if (ee.Button == System.Windows.Forms.MouseButtons.Left)
                { firstPoint = Control.MousePosition; }
            };
            objekat4.MouseMove += (ss, ee) => {
                if (ee.Button == System.Windows.Forms.MouseButtons.Left)
                {
                    Point temp = Control.MousePosition;
                    Point res = new Point(firstPoint.X - temp.X, firstPoint.Y - temp.Y);

                    objekat4.Location = new Point(objekat4.Location.X - res.X, objekat4.Location.Y - res.Y);
                    firstPoint = temp;
                }
            };
        }
        public void KRETANJE5()
        {
            objekat5.MouseDown += (ss, ee) => {
                if (ee.Button == System.Windows.Forms.MouseButtons.Left)
                { firstPoint = Control.MousePosition; }
            };
            objekat5.MouseMove += (ss, ee) => {
                if (ee.Button == System.Windows.Forms.MouseButtons.Left)
                {
                    Point temp = Control.MousePosition;
                    Point res = new Point(firstPoint.X - temp.X, firstPoint.Y - temp.Y);

                    objekat5.Location = new Point(objekat5.Location.X - res.X, objekat5.Location.Y - res.Y);
                    firstPoint = temp;
                }
            };
        }
        public void KRETANJE6()
        {
            objekat6.MouseDown += (ss, ee) => {
                if (ee.Button == System.Windows.Forms.MouseButtons.Left)
                { firstPoint = Control.MousePosition; }
            };
            objekat6.MouseMove += (ss, ee) => {
                if (ee.Button == System.Windows.Forms.MouseButtons.Left)
                {
                    Point temp = Control.MousePosition;
                    Point res = new Point(firstPoint.X - temp.X, firstPoint.Y - temp.Y);

                    objekat6.Location = new Point(objekat6.Location.X - res.X, objekat6.Location.Y - res.Y);
                    firstPoint = temp;
                }
            };
        }
        public void KRETANJE7()
        {
            objekat7.MouseDown += (ss, ee) => {
                if (ee.Button == System.Windows.Forms.MouseButtons.Left)
                { firstPoint = Control.MousePosition; }
            };
            objekat7.MouseMove += (ss, ee) => {
                if (ee.Button == System.Windows.Forms.MouseButtons.Left)
                {
                    Point temp = Control.MousePosition;
                    Point res = new Point(firstPoint.X - temp.X, firstPoint.Y - temp.Y);

                    objekat7.Location = new Point(objekat7.Location.X - res.X, objekat7.Location.Y - res.Y);
                    firstPoint = temp;
                }
            };
        }
        public void KRETANJE8()
        {
            objekat8.MouseDown += (ss, ee) => {
                if (ee.Button == System.Windows.Forms.MouseButtons.Left)
                { firstPoint = Control.MousePosition; }
            };
            objekat8.MouseMove += (ss, ee) => {
                if (ee.Button == System.Windows.Forms.MouseButtons.Left)
                {
                    Point temp = Control.MousePosition;
                    Point res = new Point(firstPoint.X - temp.X, firstPoint.Y - temp.Y);

                    objekat8.Location = new Point(objekat8.Location.X - res.X, objekat8.Location.Y - res.Y);
                    firstPoint = temp;
                }
            };
        }
        public void KRETANJE9()
        {
            objekat9.MouseDown += (ss, ee) => {
                if (ee.Button == System.Windows.Forms.MouseButtons.Left)
                { firstPoint = Control.MousePosition; }
            };
            objekat9.MouseMove += (ss, ee) => {
                if (ee.Button == System.Windows.Forms.MouseButtons.Left)
                {
                    Point temp = Control.MousePosition;
                    Point res = new Point(firstPoint.X - temp.X, firstPoint.Y - temp.Y);

                    objekat9.Location = new Point(objekat9.Location.X - res.X, objekat9.Location.Y - res.Y);
                    firstPoint = temp;
                }
            };
        }
        public void KRETANJE10()
        {
            objekat10.MouseDown += (ss, ee) => {
                if (ee.Button == System.Windows.Forms.MouseButtons.Left)
                { firstPoint = Control.MousePosition; }
            };
            objekat10.MouseMove += (ss, ee) => {
                if (ee.Button == System.Windows.Forms.MouseButtons.Left)
                {
                    Point temp = Control.MousePosition;
                    Point res = new Point(firstPoint.X - temp.X, firstPoint.Y - temp.Y);

                    objekat10.Location = new Point(objekat10.Location.X - res.X, objekat10.Location.Y - res.Y);
                    firstPoint = temp;
                }
            };
        }
        public void KRETANJE11()
        {
            objekat11.MouseDown += (ss, ee) => {
                if (ee.Button == System.Windows.Forms.MouseButtons.Left)
                { firstPoint = Control.MousePosition; }
            };
            objekat11.MouseMove += (ss, ee) => {
                if (ee.Button == System.Windows.Forms.MouseButtons.Left)
                {
                    Point temp = Control.MousePosition;
                    Point res = new Point(firstPoint.X - temp.X, firstPoint.Y - temp.Y);

                    objekat11.Location = new Point(objekat11.Location.X - res.X, objekat11.Location.Y - res.Y);
                    firstPoint = temp;
                }
            };
        }
        public void KRETANJE12()
        {
            objekat12.MouseDown += (ss, ee) => {
                if (ee.Button == System.Windows.Forms.MouseButtons.Left)
                { firstPoint = Control.MousePosition; }
            };
            objekat12.MouseMove += (ss, ee) => {
                if (ee.Button == System.Windows.Forms.MouseButtons.Left)
                {
                    Point temp = Control.MousePosition;
                    Point res = new Point(firstPoint.X - temp.X, firstPoint.Y - temp.Y);

                    objekat12.Location = new Point(objekat12.Location.X - res.X, objekat12.Location.Y - res.Y);
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
            if(objekat.Top>=pictureBox2.Top && objekat.Left >= pictureBox2.Left && objekat.Left < pictureBox3.Left)
            {
                tacno++;
            }
            if (objekat2.Top >= pictureBox2.Top && objekat2.Left >= pictureBox2.Left && objekat2.Left < pictureBox3.Left)
            {
                tacno++;
            }
            if (objekat3.Top >= pictureBox2.Top && objekat3.Left >= pictureBox2.Left && objekat3.Left < pictureBox3.Left)
            {
                tacno++;
            }
            if (objekat4.Top >= pictureBox2.Top && objekat4.Left >= pictureBox2.Left && objekat4.Left < pictureBox3.Left)
            {
                tacno++;
            }
            if (objekat5.Top >= pictureBox2.Top && objekat5.Left >= pictureBox3.Left && objekat5.Left < pictureBox4.Left)
            {
                tacno++;
            }
            if (objekat6.Top >= pictureBox2.Top && objekat6.Left >= pictureBox3.Left && objekat6.Left < pictureBox4.Left)
            {
                tacno++;
            }
            if (objekat7.Top >= pictureBox2.Top && objekat7.Left >= pictureBox3.Left && objekat7.Left < pictureBox4.Left)
            {
                tacno++;
            }
            if (objekat8.Top >= pictureBox2.Top && objekat8.Left >= pictureBox3.Left && objekat8.Left < pictureBox4.Left)
            {
                tacno++;
            }
            if (objekat9.Top >= pictureBox2.Top && objekat9.Left >= pictureBox4.Left && objekat9.Left <= 1000)
            {
                tacno++;
            }
            if (objekat10.Top >= pictureBox2.Top && objekat10.Left >= pictureBox4.Left && objekat10.Left <= 1000)
            {
                tacno++;
            }
            if (objekat11.Top >= pictureBox2.Top && objekat11.Left >= pictureBox4.Left && objekat11.Left <= 1000)
            {
                tacno++;
            }
            if (objekat12.Top >= pictureBox2.Top && objekat12.Left >= pictureBox4.Left && objekat12.Left <= 1000)
            {
                tacno++;
            }

            if (tacno == 12)
            {
                MessageBox.Show("Pogodili ste sve! Kraj igre!");
            }
            else
            {
                MessageBox.Show("Pogodili ste " + tacno + " od 12. Pokušajte ponovo!");
                this.Hide();
                igrica1Form igrica = new igrica1Form();
                igrica.Show();
            }
        }
        
        //nebitno
        private void progres1(object sender, EventArgs e)
        {

        }
        private void progres2(object sender, EventArgs e)
        {
        }
        private void progres3(object sender, EventArgs e)
        {

        }
        //nebitno
        private void objekat1(object sender, EventArgs e)
        {

        }
        private void objekat_Click(object sender, EventArgs e)
        {

        }

        private void KRETANJE(object sender, MouseEventArgs e)
        {

        }

        private void progres3(object sender, DragEventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide(); // sakriva ovu formu
            igriceMeniForm igriceMeni = new igriceMeniForm(); // kreira novu formu sa meni igricama
            igriceMeni.Show(); // pokazuje formu - igriceMeniForma
        }

        private void igrica1Form_Load(object sender, EventArgs e)
        {

        }
    }
}
