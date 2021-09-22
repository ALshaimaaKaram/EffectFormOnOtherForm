using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EffectFormOnOtherForm
{
    public partial class EditFormat : Form
    {
        private Color color;
        private string fontFamily;
        public string FontFamily
        {
            get { return fontFamily; }
            //set { cmboxFont.SelectedItem = value; }
        }
        public int FontSize
        {
            get { return (int)numUpDSize.Value; }
            //set { numUpDSize.Value = value; }
        }


        public Color Color
        {
            get 
            {   
                return color; 
            }
            set
            {
                color = value;
            }
        }
        

        public bool Bold 
        { 
            get { return ckbBold.Checked; }
            //set { }
        }

        public bool Italic
        {
            get { return ckboxItalic.Checked; }
            //set { }
        }

        public bool UnderLine
        {
            get { return ckboxUnderLine.Checked; }
            //set { }
        }

        public Button Button
        {
            get { return btnApply; }
            //set { }
        }

        public EditFormat()
        {
            InitializeComponent();

            cmboxFont.DisplayMember = "Name";
            cmboxFont.DataSource = System.Drawing.FontFamily.Families.ToList();
        }

        private void rdoCustom_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoCustom.Checked)
            {
                ColorDialog dlg = new ColorDialog();

                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    Color = dlg.Color;
                }
            }
            if (rdoBlue.Checked)
                Color = Color.Blue;
            if (rdoRed.Checked)
                Color = Color.Red;

        }

        private void cmboxFont_SelectedIndexChanged(object sender, EventArgs e)
        {
            fontFamily = cmboxFont.Text;
        }
    }
}
