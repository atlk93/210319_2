# 210319_2
C# 그림판 만들기

```
Form1.cs
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
    public partial class Form1 : Form
    {
        Graphics GDC;
        public Form1()
        {
            InitializeComponent();

            GDC = CanvasDraw.CreateGraphics();
        }

        
        private void mnuDraw_Click(object sender, EventArgs e)
        {
           
        }

        private void canvasDraw_Paint(object sender, PaintEventArgs e)
        {
      
        }
   
        private void CanvasDraw_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Pen pp = new Pen(Color.Red, Thickness);
                GDC.DrawEllipse(pp, e.X - cirX/2, e.Y - cirY/2, cirX, cirY);
            }
        }

        private void CanvasDraw_Resize(object sender, EventArgs e)
        {
            GDC = CanvasDraw.CreateGraphics();
        }

        int cirX = 10;
        int cirY = 10;
        int Thickness = 2;
        private void mnuOption_Click(object sender, EventArgs e)
        {
            FormOption dlg = new FormOption(cirX,cirY,Thickness);
            //dlg.X = cirX;  dlg.Y=cirY;    dlg.Thick=Thickness;
            DialogResult ret = dlg.ShowDialog();   
            if(ret==DialogResult.OK)
            {
                cirX = dlg.X;
                cirY = dlg.Y;
                Thickness = dlg.Thick;
            }
        }
        
        private void mnuErase_Click(object sender, EventArgs e)
        {
            GDC.Clear(DefaultBackColor);
        }
    }
}

```

```
FormOption.cs
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
 ```
