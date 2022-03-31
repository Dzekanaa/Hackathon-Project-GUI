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
    public partial class settingsForm : Form
    {
        System.Media.SoundPlayer sp = new System.Media.SoundPlayer(@"D:\doc\Downloads\Frankie_MP3_320K_.wav");
        public settingsForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sp.Stop();
        }
    }
}
