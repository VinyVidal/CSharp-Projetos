using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgramarDesligamento
{
    public partial class TimeUpDown : NumericUpDown
    {
        public TimeUpDown()
        {
            InitializeComponent();
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
            //ControlPaint.DrawBorder(pe.Graphics, this.ClientRectangle, Color.Aqua, ButtonBorderStyle.Solid);
        }

        protected override void UpdateEditText()
        {
            this.Text = Value.ToString("00");
            //base.UpdateEditText();
        }
    }
}
