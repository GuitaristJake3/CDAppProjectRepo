
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
            this.loadCDsButton = new System.Windows.Forms.Button();
            this.madeByLabel = new System.Windows.Forms.Label();
            this.openCDList = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // newCDButton
            // 
            this.newCDButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newCDButton.Location = new System.Drawing.Point(55, 140);
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
            this.viewCDsButton.Location = new System.Drawing.Point(336, 140);
            this.viewCDsButton.Name = "viewCDsButton";
            this.viewCDsButton.Size = new System.Drawing.Size(100, 50);
            this.viewCDsButton.TabIndex = 2;
            this.viewCDsButton.Text = "View My CDs";
            this.viewCDsButton.UseVisualStyleBackColor = true;
            this.viewCDsButton.Click += new System.EventHandler(this.viewCDsButton_Click);
            // 
            // welcomeLabel
            // 
            this.welcomeLabel.AutoSize = true;
            this.welcomeLabel.Font = new System.Drawing.Font("Lucida Console", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomeLabel.Location = new System.Drawing.Point(140, 61);
            this.welcomeLabel.Name = "welcomeLabel";
            this.welcomeLabel.Size = new System.Drawing.Size(233, 27);
            this.welcomeLabel.TabIndex = 2;
            this.welcomeLabel.Text = "My CD Library";
            this.welcomeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // loadCDsButton
            // 
            this.loadCDsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadCDsButton.Location = new System.Drawing.Point(197, 140);
            this.loadCDsButton.Name = "loadCDsButton";
            this.loadCDsButton.Size = new System.Drawing.Size(100, 50);
            this.loadCDsButton.TabIndex = 1;
            this.loadCDsButton.Text = "Load CD Library";
            this.loadCDsButton.UseVisualStyleBackColor = true;
            this.loadCDsButton.Click += new System.EventHandler(this.loadCDsButton_Click);
            // 
            // madeByLabel
            // 
            this.madeByLabel.AutoSize = true;
            this.madeByLabel.Location = new System.Drawing.Point(374, 240);
            this.madeByLabel.Name = "madeByLabel";
            this.madeByLabel.Size = new System.Drawing.Size(137, 13);
            this.madeByLabel.TabIndex = 4;
            this.madeByLabel.Text = "Made by Jake Davies 2021";
            // 
            // openCDList
            // 
            this.openCDList.DefaultExt = "csv";
            this.openCDList.FileName = "CD Library";
            this.openCDList.Filter = "CSV files (*.csv)|*.csv";
            // 
            // Start
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 259);
            this.Controls.Add(this.madeByLabel);
            this.Controls.Add(this.loadCDsButton);
            this.Controls.Add(this.welcomeLabel);
            this.Controls.Add(this.viewCDsButton);
            this.Controls.Add(this.newCDButton);
            this.Name = "Start";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button newCDButton;
        private System.Windows.Forms.Button viewCDsButton;
        private System.Windows.Forms.Label welcomeLabel;
        private System.Windows.Forms.Button loadCDsButton;
        private System.Windows.Forms.Label madeByLabel;
        private System.Windows.Forms.OpenFileDialog openCDList;
    }
}