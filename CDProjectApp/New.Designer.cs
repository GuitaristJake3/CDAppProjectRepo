
namespace CDProjectApp
{
    partial class New
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
            this.newMenuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.addDataButtonError = new System.Windows.Forms.ErrorProvider(this.components);
            this.clearButton = new System.Windows.Forms.Button();
            this.newLabel = new System.Windows.Forms.Label();
            this.newMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tracksUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addDataButtonError)).BeginInit();
            this.SuspendLayout();
            // 
            // newMenuStrip
            // 
            this.newMenuStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.newMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.newMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.newMenuStrip.Name = "newMenuStrip";
            this.newMenuStrip.Padding = new System.Windows.Forms.Padding(4, 1, 0, 1);
            this.newMenuStrip.Size = new System.Drawing.Size(422, 24);
            this.newMenuStrip.TabIndex = 0;
            this.newMenuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.deleteToolStripMenuItem,
            this.closeToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 22);
            this.fileToolStripMenuItem.Text = "File";
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
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.SaveToolStripMenuItem_Click);
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
            this.genreLabel.Location = new System.Drawing.Point(21, 78);
            this.genreLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.genreLabel.Name = "genreLabel";
            this.genreLabel.Size = new System.Drawing.Size(39, 13);
            this.genreLabel.TabIndex = 1;
            this.genreLabel.Text = "Genre:";
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
            this.genreComboBox.Location = new System.Drawing.Point(120, 75);
            this.genreComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.genreComboBox.Name = "genreComboBox";
            this.genreComboBox.Size = new System.Drawing.Size(100, 21);
            this.genreComboBox.TabIndex = 2;
            this.genreComboBox.Leave += new System.EventHandler(this.GenreComboBox_Leave);
            // 
            // addDataToListButton
            // 
            this.addDataToListButton.Enabled = false;
            this.addDataToListButton.Location = new System.Drawing.Point(292, 181);
            this.addDataToListButton.Name = "addDataToListButton";
            this.addDataToListButton.Size = new System.Drawing.Size(75, 23);
            this.addDataToListButton.TabIndex = 3;
            this.addDataToListButton.Text = "Add Data";
            this.addDataToListButton.UseVisualStyleBackColor = true;
            this.addDataToListButton.Click += new System.EventHandler(this.AddDataToListButton_Click);
            // 
            // artistLabel
            // 
            this.artistLabel.AutoSize = true;
            this.artistLabel.Location = new System.Drawing.Point(21, 114);
            this.artistLabel.Name = "artistLabel";
            this.artistLabel.Size = new System.Drawing.Size(65, 13);
            this.artistLabel.TabIndex = 4;
            this.artistLabel.Text = "Album Artist:";
            // 
            // albumLabel
            // 
            this.albumLabel.AutoSize = true;
            this.albumLabel.Location = new System.Drawing.Point(21, 150);
            this.albumLabel.Name = "albumLabel";
            this.albumLabel.Size = new System.Drawing.Size(62, 13);
            this.albumLabel.TabIndex = 5;
            this.albumLabel.Text = "Album Title:";
            // 
            // releaseLabel
            // 
            this.releaseLabel.AutoSize = true;
            this.releaseLabel.Location = new System.Drawing.Point(21, 186);
            this.releaseLabel.Name = "releaseLabel";
            this.releaseLabel.Size = new System.Drawing.Size(74, 13);
            this.releaseLabel.TabIndex = 6;
            this.releaseLabel.Text = "Release Year:";
            // 
            // artistTextBox
            // 
            this.artistTextBox.Location = new System.Drawing.Point(120, 111);
            this.artistTextBox.MaxLength = 100;
            this.artistTextBox.Name = "artistTextBox";
            this.artistTextBox.Size = new System.Drawing.Size(100, 20);
            this.artistTextBox.TabIndex = 7;
            this.artistTextBox.Leave += new System.EventHandler(this.ArtistTextBox_Leave);
            // 
            // albumTextBox
            // 
            this.albumTextBox.Location = new System.Drawing.Point(120, 147);
            this.albumTextBox.MaxLength = 100;
            this.albumTextBox.Name = "albumTextBox";
            this.albumTextBox.Size = new System.Drawing.Size(100, 20);
            this.albumTextBox.TabIndex = 8;
            this.albumTextBox.Leave += new System.EventHandler(this.AlbumTextBox_Leave);
            // 
            // releaseMaskedTextBox
            // 
            this.releaseMaskedTextBox.Location = new System.Drawing.Point(119, 183);
            this.releaseMaskedTextBox.Mask = "0000";
            this.releaseMaskedTextBox.Name = "releaseMaskedTextBox";
            this.releaseMaskedTextBox.Size = new System.Drawing.Size(101, 20);
            this.releaseMaskedTextBox.TabIndex = 9;
            this.releaseMaskedTextBox.ValidatingType = typeof(System.DateTime);
            this.releaseMaskedTextBox.Leave += new System.EventHandler(this.ReleaseMaskedTextBox_Leave);
            // 
            // locationLabel
            // 
            this.locationLabel.AutoSize = true;
            this.locationLabel.Location = new System.Drawing.Point(21, 294);
            this.locationLabel.Name = "locationLabel";
            this.locationLabel.Size = new System.Drawing.Size(51, 13);
            this.locationLabel.TabIndex = 10;
            this.locationLabel.Text = "Location:";
            // 
            // locationTextBox
            // 
            this.locationTextBox.Location = new System.Drawing.Point(119, 291);
            this.locationTextBox.MaxLength = 100;
            this.locationTextBox.Name = "locationTextBox";
            this.locationTextBox.Size = new System.Drawing.Size(101, 20);
            this.locationTextBox.TabIndex = 11;
            this.locationTextBox.Leave += new System.EventHandler(this.LocationTextBox_Leave);
            // 
            // tracksLabel
            // 
            this.tracksLabel.AutoSize = true;
            this.tracksLabel.Location = new System.Drawing.Point(21, 258);
            this.tracksLabel.Name = "tracksLabel";
            this.tracksLabel.Size = new System.Drawing.Size(95, 13);
            this.tracksLabel.TabIndex = 12;
            this.tracksLabel.Text = "Number of Tracks:";
            // 
            // runTimeLabel
            // 
            this.runTimeLabel.AutoSize = true;
            this.runTimeLabel.Location = new System.Drawing.Point(21, 222);
            this.runTimeLabel.Name = "runTimeLabel";
            this.runTimeLabel.Size = new System.Drawing.Size(56, 13);
            this.runTimeLabel.TabIndex = 13;
            this.runTimeLabel.Text = "Run Time:";
            // 
            // tracksUpDown
            // 
            this.tracksUpDown.Location = new System.Drawing.Point(119, 255);
            this.tracksUpDown.Name = "tracksUpDown";
            this.tracksUpDown.Size = new System.Drawing.Size(101, 20);
            this.tracksUpDown.TabIndex = 14;
            this.tracksUpDown.Leave += new System.EventHandler(this.TracksUpDown_Leave);
            // 
            // runTimeMaskedTextBox
            // 
            this.runTimeMaskedTextBox.Location = new System.Drawing.Point(120, 219);
            this.runTimeMaskedTextBox.Mask = "00:00";
            this.runTimeMaskedTextBox.Name = "runTimeMaskedTextBox";
            this.runTimeMaskedTextBox.Size = new System.Drawing.Size(100, 20);
            this.runTimeMaskedTextBox.TabIndex = 15;
            this.runTimeMaskedTextBox.ValidatingType = typeof(int);
            this.runTimeMaskedTextBox.Leave += new System.EventHandler(this.RunTimeMaskedTextBox_Leave);
            // 
            // saveCDList
            // 
            this.saveCDList.CreatePrompt = true;
            this.saveCDList.DefaultExt = "csv";
            this.saveCDList.FileName = "CD Library";
            this.saveCDList.Filter = "CSV files (*.csv)|*.csv";
            // 
            // addDataButtonError
            // 
            this.addDataButtonError.ContainerControl = this;
            this.addDataButtonError.Tag = "";
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(292, 235);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 23);
            this.clearButton.TabIndex = 16;
            this.clearButton.Text = "Clear All";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // newLabel
            // 
            this.newLabel.AutoSize = true;
            this.newLabel.Font = new System.Drawing.Font("Lucida Console", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newLabel.Location = new System.Drawing.Point(125, 24);
            this.newLabel.Name = "newLabel";
            this.newLabel.Size = new System.Drawing.Size(182, 27);
            this.newLabel.TabIndex = 17;
            this.newLabel.Text = "Add New CD";
            // 
            // New
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 320);
            this.Controls.Add(this.newLabel);
            this.Controls.Add(this.clearButton);
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
            this.Controls.Add(this.newMenuStrip);
            this.MainMenuStrip = this.newMenuStrip;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "New";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CD Library";
            this.newMenuStrip.ResumeLayout(false);
            this.newMenuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tracksUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addDataButtonError)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip newMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
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
        private System.Windows.Forms.ErrorProvider addDataButtonError;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Label newLabel;
    }
}

