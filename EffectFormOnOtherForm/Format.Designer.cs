
namespace EffectFormOnOtherForm
{
    partial class Format
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtFormat = new System.Windows.Forms.TextBox();
            this.btnFormat = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtFormat
            // 
            this.txtFormat.Location = new System.Drawing.Point(106, 61);
            this.txtFormat.Name = "txtFormat";
            this.txtFormat.Size = new System.Drawing.Size(158, 23);
            this.txtFormat.TabIndex = 0;
            // 
            // btnFormat
            // 
            this.btnFormat.Location = new System.Drawing.Point(296, 54);
            this.btnFormat.Name = "btnFormat";
            this.btnFormat.Size = new System.Drawing.Size(88, 35);
            this.btnFormat.TabIndex = 1;
            this.btnFormat.Text = "Format";
            this.btnFormat.UseVisualStyleBackColor = true;
            this.btnFormat.Click += new System.EventHandler(this.btnFormat_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblName.Location = new System.Drawing.Point(21, 59);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(62, 25);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "Name";
            // 
            // Format
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 158);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.btnFormat);
            this.Controls.Add(this.txtFormat);
            this.Text = "Format";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFormat;
        private System.Windows.Forms.Button btnFormat;
        private System.Windows.Forms.Label lblName;
    }
}

