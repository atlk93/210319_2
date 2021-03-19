using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsGraph
{
    public partial class FormOption : Form
    {
        public FormOption(int x, int y, int t)
        {
            X = x;
            Y = y;
            Thick = t;

            InitializeComponent();
        }

        public int X, Y;
        public int Thick;

        private void FormOption_Load(object sender, EventArgs e)
        {
            tbXaxis.Text = $"{X}";
            tbYaxis.Text = $"{Y}";
            tbThick.Text = $"{Thick}";
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            X = int.Parse(tbXaxis.Text);
            Y = int.Parse(tbYaxis.Text);
            Thick = int.Parse(tbThick.Text);
        }
    }
}
