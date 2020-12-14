
namespace TranslationDemo.Forms
{
    partial class DemoWin
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
   System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DemoWin));
   this.sampleTxtBox = new System.Windows.Forms.RichTextBox();
   this.idTxtBox = new System.Windows.Forms.TextBox();
   this.keyTxtBox = new System.Windows.Forms.TextBox();
   this.submitBtn = new System.Windows.Forms.Button();
   this.langTxtBox = new System.Windows.Forms.TextBox();
   this.idLbl = new System.Windows.Forms.Label();
   this.keyLbl = new System.Windows.Forms.Label();
   this.langLbl = new System.Windows.Forms.Label();
   this.SuspendLayout();
   // 
   // sampleTxtBox
   // 
   this.sampleTxtBox.Location = new System.Drawing.Point(12, 12);
   this.sampleTxtBox.Name = "sampleTxtBox";
   this.sampleTxtBox.ReadOnly = true;
   this.sampleTxtBox.Size = new System.Drawing.Size(424, 160);
   this.sampleTxtBox.TabIndex = 1;
   this.sampleTxtBox.Text = "";
   // 
   // idTxtBox
   // 
   this.idTxtBox.Location = new System.Drawing.Point(12, 206);
   this.idTxtBox.Name = "idTxtBox";
   this.idTxtBox.Size = new System.Drawing.Size(92, 27);
   this.idTxtBox.TabIndex = 2;
   this.idTxtBox.Text = "128";
   // 
   // keyTxtBox
   // 
   this.keyTxtBox.Location = new System.Drawing.Point(110, 206);
   this.keyTxtBox.Name = "keyTxtBox";
   this.keyTxtBox.Size = new System.Drawing.Size(91, 27);
   this.keyTxtBox.TabIndex = 3;
   this.keyTxtBox.Text = "1";
   // 
   // submitBtn
   // 
   this.submitBtn.Location = new System.Drawing.Point(313, 206);
   this.submitBtn.Name = "submitBtn";
   this.submitBtn.Size = new System.Drawing.Size(94, 29);
   this.submitBtn.TabIndex = 4;
   this.submitBtn.Text = "Submit";
   this.submitBtn.UseVisualStyleBackColor = true;
   this.submitBtn.Click += new System.EventHandler(this.submitBtn_Click);
   // 
   // langTxtBox
   // 
   this.langTxtBox.Location = new System.Drawing.Point(207, 206);
   this.langTxtBox.Name = "langTxtBox";
   this.langTxtBox.Size = new System.Drawing.Size(100, 27);
   this.langTxtBox.TabIndex = 5;
   this.langTxtBox.Text = "Norwegian";
   // 
   // idLbl
   // 
   this.idLbl.AutoSize = true;
   this.idLbl.Location = new System.Drawing.Point(12, 183);
   this.idLbl.Name = "idLbl";
   this.idLbl.Size = new System.Drawing.Size(22, 20);
   this.idLbl.TabIndex = 6;
   this.idLbl.Text = "Id";
   // 
   // keyLbl
   // 
   this.keyLbl.AutoSize = true;
   this.keyLbl.Location = new System.Drawing.Point(110, 183);
   this.keyLbl.Name = "keyLbl";
   this.keyLbl.Size = new System.Drawing.Size(33, 20);
   this.keyLbl.TabIndex = 7;
   this.keyLbl.Text = "Key";
   // 
   // langLbl
   // 
   this.langLbl.AutoSize = true;
   this.langLbl.Location = new System.Drawing.Point(207, 183);
   this.langLbl.Name = "langLbl";
   this.langLbl.Size = new System.Drawing.Size(74, 20);
   this.langLbl.TabIndex = 8;
   this.langLbl.Text = "Language";
   // 
   // DemoWin
   // 
   this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
   this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
   this.ClientSize = new System.Drawing.Size(447, 245);
   this.Controls.Add(this.langLbl);
   this.Controls.Add(this.keyLbl);
   this.Controls.Add(this.idLbl);
   this.Controls.Add(this.langTxtBox);
   this.Controls.Add(this.submitBtn);
   this.Controls.Add(this.keyTxtBox);
   this.Controls.Add(this.idTxtBox);
   this.Controls.Add(this.sampleTxtBox);
   this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
   this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
   this.MaximizeBox = false;
   this.Name = "DemoWin";
   this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
   this.Text = "Translation Demo";
   this.ResumeLayout(false);
   this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RichTextBox sampleTxtBox;
        private System.Windows.Forms.TextBox idTxtBox;
        private System.Windows.Forms.TextBox keyTxtBox;
        private System.Windows.Forms.Button submitBtn;
        private System.Windows.Forms.TextBox langTxtBox;
        private System.Windows.Forms.Label idLbl;
        private System.Windows.Forms.Label keyLbl;
        private System.Windows.Forms.Label langLbl;
    }
}
