
namespace CDProjectApp
{
    partial class CDLibrary
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.shareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.genreLabel = new System.Windows.Forms.Label();
            this.genreComboBox = new System.Windows.Forms.ComboBox();
            this.addDataToListButton = new System.Windows.Forms.Button();
            this.artistLabel = new System.Windows.Forms.Label();
            this.albumLabel = new System.Windows.Forms.Label();
            this.releaseLabel = new System.Windows.Forms.Label();
            this.artistTextBox = new System.Windows.Forms.TextBox();
            this.albumTextBox = new System.Windows.Forms.TextBox();
            this.releaseMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.locationLabel = new System.Windows.Forms.Label();
            this.locationTextBox = new System.Windows.Forms.TextBox();
            this.tracksLabel = new System.Windows.Forms.Label();
            this.runTimeLabel = new System.Windows.Forms.Label();
            this.tracksUpDown = new System.Windows.Forms.NumericUpDown();
            this.runTimeMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.saveCDList = new System.Windows.Forms.SaveFileDialog();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tracksUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 1, 0, 1);
            this.menuStrip1.Size = new System.Drawing.Size(422, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.shareToolStripMenuItem,
            this.deleteToolStripMenuItem,
            this.closeToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 22);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.newToolStripMenuItem.Text = "New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.openToolStripMenuItem.Text = "Open";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Enabled = false;
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // shareToolStripMenuItem
            // 
            this.shareToolStripMenuItem.Name = "shareToolStripMenuItem";
            this.shareToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.shareToolStripMenuItem.Text = "Share";
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.closeToolStripMenuItem.Text = "Close";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // genreLabel
            // 
            this.genreLabel.AutoSize = true;
            this.genreLabel.Location = new System.Drawing.Point(21, 52);
            this.genreLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.genreLabel.Name = "genreLabel";
            this.genreLabel.Size = new System.Drawing.Size(39, 13);
            this.genreLabel.TabIndex = 1;
            this.genreLabel.Text = "Genre:";
            this.genreLabel.Visible = false;
            // 
            // genreComboBox
            // 
            this.genreComboBox.FormattingEnabled = true;
            this.genreComboBox.Items.AddRange(new object[] {
            "Acoustic",
            "Blues",
            "Classical",
            "Country",
            "Electronic",
            "Jazz",
            "Metal",
            "Pop",
            "Punk",
            "Rap",
            "Rock",
            "World",
            "Other"});
            this.genreComboBox.Location = new System.Drawing.Point(120, 49);
            this.genreComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.genreComboBox.Name = "genreComboBox";
            this.genreComboBox.Size = new System.Drawing.Size(100, 21);
            this.genreComboBox.TabIndex = 2;
            this.genreComboBox.Visible = false;
            this.genreComboBox.Leave += new System.EventHandler(this.genreComboBox_Leave);
            // 
            // addDataToListButton
            // 
            this.addDataToListButton.Location = new System.Drawing.Point(317, 144);
            this.addDataToListButton.Name = "addDataToListButton";
            this.addDataToListButton.Size = new System.Drawing.Size(75, 23);
            this.addDataToListButton.TabIndex = 3;
            this.addDataToListButton.Text = "Add Data";
            this.addDataToListButton.UseVisualStyleBackColor = true;
            this.addDataToListButton.Visible = false;
            this.addDataToListButton.Click += new System.EventHandler(this.addDataToListButton_Click);
            // 
            // artistLabel
            // 
            this.artistLabel.AutoSize = true;
            this.artistLabel.Location = new System.Drawing.Point(21, 88);
            this.artistLabel.Name = "artistLabel";
            this.artistLabel.Size = new System.Drawing.Size(65, 13);
            this.artistLabel.TabIndex = 4;
            this.artistLabel.Text = "Album Artist:";
            this.artistLabel.Visible = false;
            // 
            // albumLabel
            // 
            this.albumLabel.AutoSize = true;
            this.albumLabel.Location = new System.Drawing.Point(21, 124);
            this.albumLabel.Name = "albumLabel";
            this.albumLabel.Size = new System.Drawing.Size(62, 13);
            this.albumLabel.TabIndex = 5;
            this.albumLabel.Text = "Album Title:";
            this.albumLabel.Visible = false;
            // 
            // releaseLabel
            // 
            this.releaseLabel.AutoSize = true;
            this.releaseLabel.Location = new System.Drawing.Point(21, 160);
            this.releaseLabel.Name = "releaseLabel";
            this.releaseLabel.Size = new System.Drawing.Size(74, 13);
            this.releaseLabel.TabIndex = 6;
            this.releaseLabel.Text = "Release Year:";
            this.releaseLabel.Visible = false;
            // 
            // artistTextBox
            // 
            this.artistTextBox.Location = new System.Drawing.Point(120, 85);
            this.artistTextBox.MaxLength = 100;
            this.artistTextBox.Name = "artistTextBox";
            this.artistTextBox.Size = new System.Drawing.Size(100, 20);
            this.artistTextBox.TabIndex = 7;
            this.artistTextBox.Visible = false;
            this.artistTextBox.Leave += new System.EventHandler(this.artistTextBox_Leave);
            // 
            // albumTextBox
            // 
            this.albumTextBox.Location = new System.Drawing.Point(120, 121);
            this.albumTextBox.MaxLength = 100;
            this.albumTextBox.Name = "albumTextBox";
            this.albumTextBox.Size = new System.Drawing.Size(100, 20);
            this.albumTextBox.TabIndex = 8;
            this.albumTextBox.Visible = false;
            this.albumTextBox.Leave += new System.EventHandler(this.albumTextBox_Leave);
            // 
            // releaseMaskedTextBox
            // 
            this.releaseMaskedTextBox.Location = new System.Drawing.Point(119, 157);
            this.releaseMaskedTextBox.Mask = "0000";
            this.releaseMaskedTextBox.Name = "releaseMaskedTextBox";
            this.releaseMaskedTextBox.Size = new System.Drawing.Size(101, 20);
            this.releaseMaskedTextBox.TabIndex = 9;
            this.releaseMaskedTextBox.ValidatingType = typeof(System.DateTime);
            this.releaseMaskedTextBox.Visible = false;
            this.releaseMaskedTextBox.Leave += new System.EventHandler(this.releaseMaskedTextBox_Leave);
            // 
            // locationLabel
            // 
            this.locationLabel.AutoSize = true;
            this.locationLabel.Location = new System.Drawing.Point(21, 268);
            this.locationLabel.Name = "locationLabel";
            this.locationLabel.Size = new System.Drawing.Size(51, 13);
            this.locationLabel.TabIndex = 10;
            this.locationLabel.Text = "Location:";
            this.locationLabel.Visible = false;
            // 
            // locationTextBox
            // 
            this.locationTextBox.Location = new System.Drawing.Point(119, 265);
            this.locationTextBox.MaxLength = 100;
            this.locationTextBox.Name = "locationTextBox";
            this.locationTextBox.Size = new System.Drawing.Size(101, 20);
            this.locationTextBox.TabIndex = 11;
            this.locationTextBox.Visible = false;
            this.locationTextBox.Leave += new System.EventHandler(this.locationTextBox_Leave);
            // 
            // tracksLabel
            // 
            this.tracksLabel.AutoSize = true;
            this.tracksLabel.Location = new System.Drawing.Point(21, 232);
            this.tracksLabel.Name = "tracksLabel";
            this.tracksLabel.Size = new System.Drawing.Size(91, 13);
            this.tracksLabel.TabIndex = 12;
            this.tracksLabel.Text = "Number of tracks:";
            this.tracksLabel.Visible = false;
            // 
            // runTimeLabel
            // 
            this.runTimeLabel.AutoSize = true;
            this.runTimeLabel.Location = new System.Drawing.Point(21, 196);
            this.runTimeLabel.Name = "runTimeLabel";
            this.runTimeLabel.Size = new System.Drawing.Size(52, 13);
            this.runTimeLabel.TabIndex = 13;
            this.runTimeLabel.Text = "Run time:";
            this.runTimeLabel.Visible = false;
            // 
            // tracksUpDown
            // 
            this.tracksUpDown.Location = new System.Drawing.Point(119, 229);
            this.tracksUpDown.Name = "tracksUpDown";
            this.tracksUpDown.Size = new System.Drawing.Size(101, 20);
            this.tracksUpDown.TabIndex = 14;
            this.tracksUpDown.Visible = false;
            this.tracksUpDown.Leave += new System.EventHandler(this.tracksUpDown_Leave);
            // 
            // runTimeMaskedTextBox
            // 
            this.runTimeMaskedTextBox.Location = new System.Drawing.Point(120, 193);
            this.runTimeMaskedTextBox.Mask = "00:00";
            this.runTimeMaskedTextBox.Name = "runTimeMaskedTextBox";
            this.runTimeMaskedTextBox.Size = new System.Drawing.Size(100, 20);
            this.runTimeMaskedTextBox.TabIndex = 15;
            this.runTimeMaskedTextBox.ValidatingType = typeof(int);
            this.runTimeMaskedTextBox.Visible = false;
            this.runTimeMaskedTextBox.Leave += new System.EventHandler(this.runTimeMaskedTextBox_Leave);
            // 
            // saveCDList
            // 
            this.saveCDList.CreatePrompt = true;
            this.saveCDList.DefaultExt = "csv";
            this.saveCDList.FileName = "CD Library";
            this.saveCDList.Filter = "CSV files (*.csv)|*.csv";
            // 
            // CDLibrary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 320);
            this.Controls.Add(this.runTimeMaskedTextBox);
            this.Controls.Add(this.tracksUpDown);
            this.Controls.Add(this.runTimeLabel);
            this.Controls.Add(this.tracksLabel);
            this.Controls.Add(this.locationTextBox);
            this.Controls.Add(this.locationLabel);
            this.Controls.Add(this.releaseMaskedTextBox);
            this.Controls.Add(this.albumTextBox);
            this.Controls.Add(this.artistTextBox);
            this.Controls.Add(this.releaseLabel);
            this.Controls.Add(this.albumLabel);
            this.Controls.Add(this.artistLabel);
            this.Controls.Add(this.addDataToListButton);
            this.Controls.Add(this.genreComboBox);
            this.Controls.Add(this.genreLabel);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "CDLibrary";
            this.Text = "CD Library";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tracksUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem shareToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Label genreLabel;
        private System.Windows.Forms.ComboBox genreComboBox;
        private System.Windows.Forms.Button addDataToListButton;
        private System.Windows.Forms.Label artistLabel;
        private System.Windows.Forms.Label albumLabel;
        private System.Windows.Forms.Label releaseLabel;
        private System.Windows.Forms.TextBox artistTextBox;
        private System.Windows.Forms.TextBox albumTextBox;
        private System.Windows.Forms.MaskedTextBox releaseMaskedTextBox;
        private System.Windows.Forms.Label locationLabel;
        private System.Windows.Forms.TextBox locationTextBox;
        private System.Windows.Forms.Label tracksLabel;
        private System.Windows.Forms.Label runTimeLabel;
        private System.Windows.Forms.NumericUpDown tracksUpDown;
        private System.Windows.Forms.MaskedTextBox runTimeMaskedTextBox;
        private System.Windows.Forms.SaveFileDialog saveCDList;
    }
}

