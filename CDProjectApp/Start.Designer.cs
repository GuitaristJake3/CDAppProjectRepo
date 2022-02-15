
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
            this.components = new System.ComponentModel.Container();
            this.newCDButton = new System.Windows.Forms.Button();
            this.viewCDsButton = new System.Windows.Forms.Button();
            this.welcomeLabel = new System.Windows.Forms.Label();
            this.loadCDsButton = new System.Windows.Forms.Button();
            this.madeByLabel = new System.Windows.Forms.Label();
            this.openCDList = new System.Windows.Forms.OpenFileDialog();
            this.loadCDButtonError = new System.Windows.Forms.ErrorProvider(this.components);
            this.loadLabel = new System.Windows.Forms.Label();
            this.startMainLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.loadCDButtonError)).BeginInit();
            this.SuspendLayout();
            // 
            // newCDButton
            // 
            this.newCDButton.BackColor = System.Drawing.Color.LightGreen;
            this.newCDButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.newCDButton.Font = new System.Drawing.Font("Bahnschrift Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newCDButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.newCDButton.Location = new System.Drawing.Point(12, 150);
            this.newCDButton.Name = "newCDButton";
            this.newCDButton.Size = new System.Drawing.Size(100, 60);
            this.newCDButton.TabIndex = 0;
            this.newCDButton.TabStop = false;
            this.newCDButton.Text = "Add New\r\nCD";
            this.newCDButton.UseVisualStyleBackColor = false;
            this.newCDButton.Click += new System.EventHandler(this.NewCDButton_Click);
            // 
            // viewCDsButton
            // 
            this.viewCDsButton.BackColor = System.Drawing.Color.Khaki;
            this.viewCDsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.viewCDsButton.Font = new System.Drawing.Font("Bahnschrift Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewCDsButton.Location = new System.Drawing.Point(372, 150);
            this.viewCDsButton.Name = "viewCDsButton";
            this.viewCDsButton.Size = new System.Drawing.Size(100, 60);
            this.viewCDsButton.TabIndex = 0;
            this.viewCDsButton.TabStop = false;
            this.viewCDsButton.Text = "View My CDs";
            this.viewCDsButton.UseVisualStyleBackColor = false;
            this.viewCDsButton.Click += new System.EventHandler(this.ViewCDsButton_Click);
            // 
            // welcomeLabel
            // 
            this.welcomeLabel.AutoSize = true;
            this.welcomeLabel.Font = new System.Drawing.Font("Lucida Console", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomeLabel.Location = new System.Drawing.Point(32, 30);
            this.welcomeLabel.Name = "welcomeLabel";
            this.welcomeLabel.Size = new System.Drawing.Size(420, 27);
            this.welcomeLabel.TabIndex = 2;
            this.welcomeLabel.Text = "Welcome To My CD Library";
            this.welcomeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // loadCDsButton
            // 
            this.loadCDsButton.BackColor = System.Drawing.Color.PowderBlue;
            this.loadCDsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loadCDsButton.Font = new System.Drawing.Font("Bahnschrift Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadCDsButton.Location = new System.Drawing.Point(192, 150);
            this.loadCDsButton.Name = "loadCDsButton";
            this.loadCDsButton.Size = new System.Drawing.Size(100, 60);
            this.loadCDsButton.TabIndex = 0;
            this.loadCDsButton.TabStop = false;
            this.loadCDsButton.Text = "Load CD Library";
            this.loadCDsButton.UseVisualStyleBackColor = false;
            this.loadCDsButton.Click += new System.EventHandler(this.LoadCDsButton_Click);
            // 
            // madeByLabel
            // 
            this.madeByLabel.AutoSize = true;
            this.madeByLabel.Location = new System.Drawing.Point(335, 239);
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
            // loadCDButtonError
            // 
            this.loadCDButtonError.ContainerControl = this;
            // 
            // loadLabel
            // 
            this.loadLabel.AutoSize = true;
            this.loadLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadLabel.ForeColor = System.Drawing.Color.Green;
            this.loadLabel.Location = new System.Drawing.Point(157, 210);
            this.loadLabel.Name = "loadLabel";
            this.loadLabel.Size = new System.Drawing.Size(170, 16);
            this.loadLabel.TabIndex = 5;
            this.loadLabel.Text = "Library loaded successfully";
            this.loadLabel.Visible = false;
            // 
            // startMainLabel
            // 
            this.startMainLabel.AutoSize = true;
            this.startMainLabel.Location = new System.Drawing.Point(39, 67);
            this.startMainLabel.Name = "startMainLabel";
            this.startMainLabel.Size = new System.Drawing.Size(407, 26);
            this.startMainLabel.TabIndex = 6;
            this.startMainLabel.Text = "This program allows you to save and view information about a physical CD collecti" +
    "on.\r\nStart by adding some CDs or load a file you\'ve saved by using the buttons b" +
    "elow.";
            // 
            // Start
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 261);
            this.Controls.Add(this.startMainLabel);
            this.Controls.Add(this.loadLabel);
            this.Controls.Add(this.madeByLabel);
            this.Controls.Add(this.loadCDsButton);
            this.Controls.Add(this.welcomeLabel);
            this.Controls.Add(this.viewCDsButton);
            this.Controls.Add(this.newCDButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Start";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            ((System.ComponentModel.ISupportInitialize)(this.loadCDButtonError)).EndInit();
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
        private System.Windows.Forms.ErrorProvider loadCDButtonError;
        private System.Windows.Forms.Label loadLabel;
        private System.Windows.Forms.Label startMainLabel;
    }
}