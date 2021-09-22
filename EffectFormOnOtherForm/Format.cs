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
            //EditFormat editFormat = ((EditFormat)sender);

            if (editFormat.Bold)
            {
                txtFormat.Font = new Font(editFormat.FontFamily, editFormat.FontSize, FontStyle.Bold);
            }

            if (editFormat.Italic)
            {
                txtFormat.Font = new Font(editFormat.FontFamily, editFormat.FontSize, FontStyle.Italic);
            }

            if (editFormat.UnderLine)
            {
                txtFormat.Font = new Font(editFormat.FontFamily, editFormat.FontSize, FontStyle.Underline);
            }

            txtFormat.ForeColor = editFormat.Color;
            //editFormat.Close();
        }
    }
}
