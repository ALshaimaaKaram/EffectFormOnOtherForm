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
    public partial class Format : Form
    {
        public Format()
        {
            InitializeComponent();
        }

        //public TextBox Name
        //{
        //    get
        //    {
        //        return txtFormat;
        //    }

        //    set
        //    {
        //        txtFormat = value;
        //    }
        //}

        EditFormat editFormat;
        private void btnFormat_Click(object sender, EventArgs e)
        {
            editFormat = new EditFormat();
            
            //editFormat.Name = txtFormat.Text;

            editFormat.Button.Click += btnApply_Click;
            editFormat.Show();

        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            //editFormat.cmboxFont.SelectedItem;
            //EditFormat editFormat = ((EditFormat)sender);
            //mybox.Font = new Font("Chiller", 12);
            System.Drawing.FontStyle newFontStyle = FontStyle.Regular;
           string fontFamily = editFormat.FontFamily;

            if (editFormat.Bold)
            {
                newFontStyle |= FontStyle.Bold;
            }

            if (editFormat.Italic)
            {
                newFontStyle |= FontStyle.Italic;
            }

            if (editFormat.UnderLine)
            {
                newFontStyle |= FontStyle.Underline;
            }

            txtFormat.Font = new Font(fontFamily, editFormat.FontSize, newFontStyle);
            txtFormat.ForeColor = editFormat.Color;
            //editFormat.Close();
        }
    }
}
