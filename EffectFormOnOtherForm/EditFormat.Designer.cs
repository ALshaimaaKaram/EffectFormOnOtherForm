
namespace EffectFormOnOtherForm
{
    partial class EditFormat
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.grpboxFontFormat = new System.Windows.Forms.GroupBox();
            this.cmboxFont = new System.Windows.Forms.ComboBox();
            this.ckboxItalic = new System.Windows.Forms.CheckBox();
            this.ckboxUnderLine = new System.Windows.Forms.CheckBox();
            this.ckbBold = new System.Windows.Forms.CheckBox();
            this.numUpDSize = new System.Windows.Forms.NumericUpDown();
            this.lblSize = new System.Windows.Forms.Label();
            this.lblFont = new System.Windows.Forms.Label();
            this.grpboxColorFormat = new System.Windows.Forms.GroupBox();
            this.rdoRed = new System.Windows.Forms.RadioButton();
            this.rdoCustom = new System.Windows.Forms.RadioButton();
            this.rdoBlue = new System.Windows.Forms.RadioButton();
            this.btnApply = new System.Windows.Forms.Button();
            this.grpboxFontFormat.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDSize)).BeginInit();
            this.grpboxColorFormat.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpboxFontFormat
            // 
            this.grpboxFontFormat.Controls.Add(this.cmboxFont);
            this.grpboxFontFormat.Controls.Add(this.ckboxItalic);
            this.grpboxFontFormat.Controls.Add(this.ckboxUnderLine);
            this.grpboxFontFormat.Controls.Add(this.ckbBold);
            this.grpboxFontFormat.Controls.Add(this.numUpDSize);
            this.grpboxFontFormat.Controls.Add(this.lblSize);
            this.grpboxFontFormat.Controls.Add(this.lblFont);
            this.grpboxFontFormat.Location = new System.Drawing.Point(34, 31);
            this.grpboxFontFormat.Name = "grpboxFontFormat";
            this.grpboxFontFormat.Size = new System.Drawing.Size(235, 189);
            this.grpboxFontFormat.TabIndex = 0;
            this.grpboxFontFormat.TabStop = false;
            this.grpboxFontFormat.Text = "FontFormat";
            // 
            // cmboxFont
            // 
            this.cmboxFont.FormattingEnabled = true;
            this.cmboxFont.Location = new System.Drawing.Point(102, 36);
            this.cmboxFont.Name = "cmboxFont";
            this.cmboxFont.Size = new System.Drawing.Size(121, 23);
            this.cmboxFont.TabIndex = 5;
            this.cmboxFont.SelectedIndexChanged += new System.EventHandler(this.cmboxFont_SelectedIndexChanged);
            // 
            // ckboxItalic
            // 
            this.ckboxItalic.AutoSize = true;
            this.ckboxItalic.Font = new System.Drawing.Font("Segoe UI", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.ckboxItalic.Location = new System.Drawing.Point(100, 132);
            this.ckboxItalic.Name = "ckboxItalic";
            this.ckboxItalic.Size = new System.Drawing.Size(32, 23);
            this.ckboxItalic.TabIndex = 4;
            this.ckboxItalic.Text = "I";
            this.ckboxItalic.UseVisualStyleBackColor = true;
            // 
            // ckboxUnderLine
            // 
            this.ckboxUnderLine.AutoSize = true;
            this.ckboxUnderLine.Font = new System.Drawing.Font("Segoe UI", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.ckboxUnderLine.Location = new System.Drawing.Point(159, 132);
            this.ckboxUnderLine.Name = "ckboxUnderLine";
            this.ckboxUnderLine.Size = new System.Drawing.Size(38, 23);
            this.ckboxUnderLine.TabIndex = 4;
            this.ckboxUnderLine.Text = "U";
            this.ckboxUnderLine.UseVisualStyleBackColor = true;
            // 
            // ckbBold
            // 
            this.ckbBold.AutoSize = true;
            this.ckbBold.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ckbBold.Location = new System.Drawing.Point(36, 132);
            this.ckbBold.Name = "ckbBold";
            this.ckbBold.Size = new System.Drawing.Size(37, 23);
            this.ckbBold.TabIndex = 4;
            this.ckbBold.Text = "B";
            this.ckbBold.UseVisualStyleBackColor = true;
            // 
            // numUpDSize
            // 
            this.numUpDSize.Location = new System.Drawing.Point(102, 77);
            this.numUpDSize.Name = "numUpDSize";
            this.numUpDSize.Size = new System.Drawing.Size(120, 23);
            this.numUpDSize.TabIndex = 3;
            this.numUpDSize.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // lblSize
            // 
            this.lblSize.AutoSize = true;
            this.lblSize.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSize.Location = new System.Drawing.Point(13, 77);
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(80, 19);
            this.lblSize.TabIndex = 0;
            this.lblSize.Text = "Size Name";
            // 
            // lblFont
            // 
            this.lblFont.AutoSize = true;
            this.lblFont.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblFont.Location = new System.Drawing.Point(13, 36);
            this.lblFont.Name = "lblFont";
            this.lblFont.Size = new System.Drawing.Size(82, 19);
            this.lblFont.TabIndex = 0;
            this.lblFont.Text = "Font Name";
            // 
            // grpboxColorFormat
            // 
            this.grpboxColorFormat.Controls.Add(this.rdoRed);
            this.grpboxColorFormat.Controls.Add(this.rdoCustom);
            this.grpboxColorFormat.Controls.Add(this.rdoBlue);
            this.grpboxColorFormat.Location = new System.Drawing.Point(342, 31);
            this.grpboxColorFormat.Name = "grpboxColorFormat";
            this.grpboxColorFormat.Size = new System.Drawing.Size(235, 189);
            this.grpboxColorFormat.TabIndex = 0;
            this.grpboxColorFormat.TabStop = false;
            this.grpboxColorFormat.Text = "ColorFormat";
            // 
            // rdoRed
            // 
            this.rdoRed.AutoSize = true;
            this.rdoRed.Location = new System.Drawing.Point(30, 35);
            this.rdoRed.Name = "rdoRed";
            this.rdoRed.Size = new System.Drawing.Size(45, 19);
            this.rdoRed.TabIndex = 1;
            this.rdoRed.TabStop = true;
            this.rdoRed.Text = "Red";
            this.rdoRed.UseVisualStyleBackColor = true;
            // 
            // rdoCustom
            // 
            this.rdoCustom.AutoSize = true;
            this.rdoCustom.Location = new System.Drawing.Point(30, 134);
            this.rdoCustom.Name = "rdoCustom";
            this.rdoCustom.Size = new System.Drawing.Size(67, 19);
            this.rdoCustom.TabIndex = 0;
            this.rdoCustom.Text = "Custom";
            this.rdoCustom.UseVisualStyleBackColor = true;
            this.rdoCustom.CheckedChanged += new System.EventHandler(this.rdoCustom_CheckedChanged);
            // 
            // rdoBlue
            // 
            this.rdoBlue.AutoSize = true;
            this.rdoBlue.Location = new System.Drawing.Point(30, 84);
            this.rdoBlue.Name = "rdoBlue";
            this.rdoBlue.Size = new System.Drawing.Size(48, 19);
            this.rdoBlue.TabIndex = 0;
            this.rdoBlue.Text = "Blue";
            this.rdoBlue.UseVisualStyleBackColor = true;
            // 
            // btnApply
            // 
            this.btnApply.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnApply.Location = new System.Drawing.Point(261, 255);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(111, 59);
            this.btnApply.TabIndex = 2;
            this.btnApply.Text = "Apply";
            this.btnApply.UseVisualStyleBackColor = true;
            // 
            // EditFormat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 326);
            this.Controls.Add(this.btnApply);
            this.Controls.Add(this.grpboxColorFormat);
            this.Controls.Add(this.grpboxFontFormat);
            this.Name = "EditFormat";
            this.Text = "EditFormat";
            this.grpboxFontFormat.ResumeLayout(false);
            this.grpboxFontFormat.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDSize)).EndInit();
            this.grpboxColorFormat.ResumeLayout(false);
            this.grpboxColorFormat.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpboxFontFormat;
        private System.Windows.Forms.GroupBox grpboxColorFormat;
        private System.Windows.Forms.Label lblFont;
        private System.Windows.Forms.Label lblSize;
        private System.Windows.Forms.CheckBox ckboxUnderLine;
        private System.Windows.Forms.CheckBox ckbBold;
        private System.Windows.Forms.NumericUpDown numUpDSize;
        private System.Windows.Forms.CheckBox ckboxItalic;
        private System.Windows.Forms.RadioButton rdoCustom;
        private System.Windows.Forms.RadioButton rdoBlue;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.ComboBox cmboxFont;
        private System.Windows.Forms.RadioButton rdoRed;
    }
}