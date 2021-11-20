
namespace CSC240_08_03_ManyButtons_bpc
{
    partial class Form1
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
            this.UxRedButton = new System.Windows.Forms.Button();
            this.UxWhiteButton = new System.Windows.Forms.Button();
            this.UxBlueButton = new System.Windows.Forms.Button();
            this.UxFavColorButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // UxRedButton
            // 
            this.UxRedButton.Location = new System.Drawing.Point(152, 115);
            this.UxRedButton.Name = "UxRedButton";
            this.UxRedButton.Size = new System.Drawing.Size(150, 46);
            this.UxRedButton.TabIndex = 0;
            this.UxRedButton.Text = "Red";
            this.UxRedButton.UseVisualStyleBackColor = true;
            this.UxRedButton.Click += new System.EventHandler(this.UxRedButton_Click);
            // 
            // UxWhiteButton
            // 
            this.UxWhiteButton.Location = new System.Drawing.Point(393, 115);
            this.UxWhiteButton.Name = "UxWhiteButton";
            this.UxWhiteButton.Size = new System.Drawing.Size(150, 46);
            this.UxWhiteButton.TabIndex = 1;
            this.UxWhiteButton.Text = "White";
            this.UxWhiteButton.UseVisualStyleBackColor = true;
            this.UxWhiteButton.Click += new System.EventHandler(this.UxWhiteButton_Click);
            // 
            // UxBlueButton
            // 
            this.UxBlueButton.Location = new System.Drawing.Point(640, 115);
            this.UxBlueButton.Name = "UxBlueButton";
            this.UxBlueButton.Size = new System.Drawing.Size(150, 46);
            this.UxBlueButton.TabIndex = 2;
            this.UxBlueButton.Text = "Blue";
            this.UxBlueButton.UseVisualStyleBackColor = true;
            this.UxBlueButton.Click += new System.EventHandler(this.UxBlueButton_Click);
            // 
            // UxFavColorButton
            // 
            this.UxFavColorButton.Location = new System.Drawing.Point(888, 115);
            this.UxFavColorButton.Name = "UxFavColorButton";
            this.UxFavColorButton.Size = new System.Drawing.Size(236, 46);
            this.UxFavColorButton.TabIndex = 3;
            this.UxFavColorButton.Text = "My favorite color";
            this.UxFavColorButton.UseVisualStyleBackColor = true;
            this.UxFavColorButton.Click += new System.EventHandler(this.UxBlueButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1361, 363);
            this.Controls.Add(this.UxFavColorButton);
            this.Controls.Add(this.UxBlueButton);
            this.Controls.Add(this.UxWhiteButton);
            this.Controls.Add(this.UxRedButton);
            this.Name = "Form1";
            this.Text = "Many Buttons";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button UxRedButton;
        private System.Windows.Forms.Button UxWhiteButton;
        private System.Windows.Forms.Button UxBlueButton;
        private System.Windows.Forms.Button UxFavColorButton;
    }
}

