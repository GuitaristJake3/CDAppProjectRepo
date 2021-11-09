
namespace CDProjectApp
{
    partial class Start
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
            this.newCDButton = new System.Windows.Forms.Button();
            this.viewCDsButton = new System.Windows.Forms.Button();
            this.welcomeLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // newCDButton
            // 
            this.newCDButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newCDButton.Location = new System.Drawing.Point(97, 140);
            this.newCDButton.Name = "newCDButton";
            this.newCDButton.Size = new System.Drawing.Size(100, 50);
            this.newCDButton.TabIndex = 0;
            this.newCDButton.Text = "Add New\r\nCD";
            this.newCDButton.UseVisualStyleBackColor = true;
            this.newCDButton.Click += new System.EventHandler(this.newCDButton_Click);
            // 
            // viewCDsButton
            // 
            this.viewCDsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewCDsButton.Location = new System.Drawing.Point(276, 140);
            this.viewCDsButton.Name = "viewCDsButton";
            this.viewCDsButton.Size = new System.Drawing.Size(100, 50);
            this.viewCDsButton.TabIndex = 1;
            this.viewCDsButton.Text = "View My CDs";
            this.viewCDsButton.UseVisualStyleBackColor = true;
            // 
            // welcomeLabel
            // 
            this.welcomeLabel.AutoSize = true;
            this.welcomeLabel.Font = new System.Drawing.Font("Lucida Console", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomeLabel.Location = new System.Drawing.Point(145, 56);
            this.welcomeLabel.Name = "welcomeLabel";
            this.welcomeLabel.Size = new System.Drawing.Size(205, 24);
            this.welcomeLabel.TabIndex = 2;
            this.welcomeLabel.Text = "My CD Library";
            this.welcomeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Start
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 259);
            this.Controls.Add(this.welcomeLabel);
            this.Controls.Add(this.viewCDsButton);
            this.Controls.Add(this.newCDButton);
            this.Name = "Start";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Start";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button newCDButton;
        private System.Windows.Forms.Button viewCDsButton;
        private System.Windows.Forms.Label welcomeLabel;
    }
}