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
            { return color; }
            //set
            //{
            //    color = value;
            //}
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

        //public bool Red
        //{
        //    get { return rdoRed.Checked; }
        //    //set { }
        //}

        //public bool Blue
        //{
        //    get { return rdoBlue.Checked; }
        //    //set { }
        //}

        //public bool Custom
        //{
        //    get { return rdoCustom.Checked; }
        //    //set { }
        //}

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

            ColorDialog dlg = new ColorDialog();

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                color = dlg.Color;
            }
        }

            //if (rdoBlue.Checked)
            //    color = Color.Blue;
            //if (rdoRed.Checked)
            //    color = Color.Red;

        

        private void cmboxFont_SelectedIndexChanged(object sender, EventArgs e)
        {
            fontFamily = cmboxFont.Text;
        }

        private void rdoRed_CheckedChanged(object sender, EventArgs e)
        {
            color = Color.Red;
        }

        private void rdoBlue_CheckedChanged(object sender, EventArgs e)
        {
            color = Color.Blue;
        }
    }
}
