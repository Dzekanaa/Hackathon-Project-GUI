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
    public partial class igriceMeniForm : Form
    {
        public igriceMeniForm()
        {
            InitializeComponent();
        }

        private void igrica1Button_Click(object sender, EventArgs e)
        {
            this.Hide(); // sakriva ovu formu ( igrice Meni)
            igrica1Form igrica1 = new igrica1Form(); // kreira novu formu u kojoj je igrica1
            igrica1.Show(); // pokazuje formu - igrica1
        }

        private void igrica2Button_Click(object sender, EventArgs e)
        {
            this.Hide(); // sakriva ovu formu ( igrice Meni)
            igrica2Form igrica2 = new igrica2Form(); // kreira novu formu u kojoj je igrica2
            igrica2.Show(); // pokazuje formu - igrica2
        }

        private void igrica3Button_Click(object sender, EventArgs e)
        {
            this.Hide(); // sakriva ovu formu ( igrice Meni)
            igrica3Form igrica3 = new igrica3Form(); // kreira novu formu u kojoj je igrica3
            igrica3.Show(); // pokazuje formu - igrica3
        }

        private void nazadButton_Click(object sender, EventArgs e)
        {
            this.Hide(); 
            PocetniMeniForm pocetniMeni = new PocetniMeniForm();
            pocetniMeni.Show();
        }
    }
}
