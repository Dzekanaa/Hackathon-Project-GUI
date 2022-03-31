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
            if(objekat.Top>=356 && objekat.Left <= 181)
            {
                tacno++;
            }
            if (objekat2.Top >= 356 && objekat2.Left <= 181)
            {
                tacno++;
            }
            if (objekat3.Top >= 356 && objekat.Left <= 181)
            {
                tacno++;
            }
            if (objekat4.Top >= 356 && objekat.Left <= 181)
            {
                tacno++;
            }
            if (objekat5.Top >= 356 && objekat5.Left > 181 && objekat5.Left <=513)
            {
                tacno++;
            }
            if (objekat6.Top >= 356 && objekat6.Left > 181 && objekat6.Left <= 513)
            {
                tacno++;
            }
            if (objekat7.Top >= 356 && objekat7.Left > 181 && objekat7.Left <= 513)
            {
                tacno++;
            }
            if (objekat8.Top >= 356 && objekat8.Left > 181 && objekat8.Left <= 513)
            {
                tacno++;
            }
            if (objekat9.Top >= 356 && objekat9.Left > 513 && objekat9.Left <= 915)
            {
                tacno++;
            }
            if (objekat10.Top >= 356 && objekat10.Left > 513 && objekat10.Left <= 915)
            {
                tacno++;
            }
            if (objekat11.Top >= 356 && objekat11.Left > 513 && objekat11.Left <= 915)
            {
                tacno++;
            }
            if (objekat12.Top >= 356 && objekat12.Left > 513 && objekat12.Left <= 915)
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

        private void objekat10_Click(object sender, EventArgs e)
        {

        }
    }
}
