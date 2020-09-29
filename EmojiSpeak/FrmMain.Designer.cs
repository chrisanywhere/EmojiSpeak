namespace EmojiSpeak
{
    partial class FrmMain
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
            this.lblTextToEmoji = new System.Windows.Forms.Label();
            this.txtTextInput = new System.Windows.Forms.TextBox();
            this.btnErmodgerise = new System.Windows.Forms.Button();
            this.txtTextOutput = new System.Windows.Forms.TextBox();
            this.txtHello = new System.Windows.Forms.Button();
            this.btnHiDen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTextToEmoji
            // 
            this.lblTextToEmoji.AutoSize = true;
            this.lblTextToEmoji.Location = new System.Drawing.Point(13, 13);
            this.lblTextToEmoji.Name = "lblTextToEmoji";
            this.lblTextToEmoji.Size = new System.Drawing.Size(78, 15);
            this.lblTextToEmoji.TabIndex = 0;
            this.lblTextToEmoji.Text = "Text to Emoji:";
            // 
            // txtTextInput
            // 
            this.txtTextInput.HideSelection = false;
            this.txtTextInput.Location = new System.Drawing.Point(13, 31);
            this.txtTextInput.MaxLength = 512;
            this.txtTextInput.Multiline = true;
            this.txtTextInput.Name = "txtTextInput";
            this.txtTextInput.Size = new System.Drawing.Size(662, 321);
            this.txtTextInput.TabIndex = 1;
            // 
            // btnErmodgerise
            // 
            this.btnErmodgerise.Location = new System.Drawing.Point(681, 174);
            this.btnErmodgerise.Name = "btnErmodgerise";
            this.btnErmodgerise.Size = new System.Drawing.Size(91, 23);
            this.btnErmodgerise.TabIndex = 2;
            this.btnErmodgerise.Text = "Emodgerise";
            this.btnErmodgerise.UseVisualStyleBackColor = true;
            this.btnErmodgerise.Click += new System.EventHandler(this.btnErmodgerise_Click);
            // 
            // txtTextOutput
            // 
            this.txtTextOutput.Location = new System.Drawing.Point(778, 31);
            this.txtTextOutput.Multiline = true;
            this.txtTextOutput.Name = "txtTextOutput";
            this.txtTextOutput.ReadOnly = true;
            this.txtTextOutput.Size = new System.Drawing.Size(662, 321);
            this.txtTextOutput.TabIndex = 1;
            // 
            // txtHello
            // 
            this.txtHello.Location = new System.Drawing.Point(13, 369);
            this.txtHello.Name = "txtHello";
            this.txtHello.Size = new System.Drawing.Size(75, 23);
            this.txtHello.TabIndex = 3;
            this.txtHello.Text = "Hello";
            this.txtHello.UseVisualStyleBackColor = true;
            this.txtHello.Click += new System.EventHandler(this.txtHello_Click);
            // 
            // btnHiDen
            // 
            this.btnHiDen.Location = new System.Drawing.Point(94, 369);
            this.btnHiDen.Name = "btnHiDen";
            this.btnHiDen.Size = new System.Drawing.Size(75, 23);
            this.btnHiDen.TabIndex = 3;
            this.btnHiDen.Text = "Hi Den";
            this.btnHiDen.UseVisualStyleBackColor = true;
            this.btnHiDen.Click += new System.EventHandler(this.btnHiDen_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1464, 406);
            this.Controls.Add(this.btnHiDen);
            this.Controls.Add(this.txtHello);
            this.Controls.Add(this.txtTextOutput);
            this.Controls.Add(this.btnErmodgerise);
            this.Controls.Add(this.txtTextInput);
            this.Controls.Add(this.lblTextToEmoji);
            this.Name = "FrmMain";
            this.Text = "Emoji Speak v1.0";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTextToEmoji;
        private System.Windows.Forms.TextBox txtTextInput;
        private System.Windows.Forms.Button btnErmodgerise;
        private System.Windows.Forms.TextBox txtTextOutput;
        private System.Windows.Forms.Button txtHello;
        private System.Windows.Forms.Button btnHiDen;
    }
}

