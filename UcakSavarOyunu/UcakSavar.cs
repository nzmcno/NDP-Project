using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UcakSavarOyunu
{
   
    public partial class UcakSavar : Form
    { int movePlane = 10;
       

        public UcakSavar()
        {
            InitializeComponent();
            
        }

        private void timerMoveDef_Tick(object sender, EventArgs e)
        {

            
            
            Invalidate();

        }

        private void UcakSavar_KeyDown(object sender, KeyEventArgs e)
        {
           

            if (e.KeyCode == Keys.Right)
            {
                if (defansUcagi.Location.X < this.Width - 90)
                {
                    defansUcagi.SetBounds(defansUcagi.Location.X + movePlane, defansUcagi.Location.Y, defansUcagi.Width, defansUcagi.Height);
                }
            }
            
            if (e.KeyCode == Keys.Left)
            {
                    if (defansUcagi.Location.X >0)
                    {
                        defansUcagi.SetBounds(defansUcagi.Location.X - movePlane, defansUcagi.Location.Y, defansUcagi.Width, defansUcagi.Height);
                    }
            }
            
        }
    }
}
