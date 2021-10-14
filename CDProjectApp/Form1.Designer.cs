
namespace CDProjectApp
{
    partial class Form1
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
            this.menuStrip1.SuspendLayout();
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
            this.menuStrip1.Size = new System.Drawing.Size(533, 24);
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
            this.genreLabel.Location = new System.Drawing.Point(64, 69);
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
            this.genreComboBox.Location = new System.Drawing.Point(162, 66);
            this.genreComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.genreComboBox.Name = "genreComboBox";
            this.genreComboBox.Size = new System.Drawing.Size(82, 21);
            this.genreComboBox.TabIndex = 2;
            this.genreComboBox.Visible = false;
            this.genreComboBox.SelectedIndexChanged += new System.EventHandler(this.genreComboBox_SelectedIndexChanged);
            // 
            // addDataToListButton
            // 
            this.addDataToListButton.Enabled = false;
            this.addDataToListButton.Location = new System.Drawing.Point(366, 68);
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
            this.artistLabel.Location = new System.Drawing.Point(64, 103);
            this.artistLabel.Name = "artistLabel";
            this.artistLabel.Size = new System.Drawing.Size(65, 13);
            this.artistLabel.TabIndex = 4;
            this.artistLabel.Text = "Album Artist:";
            this.artistLabel.Visible = false;
            // 
            // albumLabel
            // 
            this.albumLabel.AutoSize = true;
            this.albumLabel.Location = new System.Drawing.Point(64, 139);
            this.albumLabel.Name = "albumLabel";
            this.albumLabel.Size = new System.Drawing.Size(62, 13);
            this.albumLabel.TabIndex = 5;
            this.albumLabel.Text = "Album Title:";
            this.albumLabel.Visible = false;
            // 
            // releaseLabel
            // 
            this.releaseLabel.AutoSize = true;
            this.releaseLabel.Location = new System.Drawing.Point(64, 174);
            this.releaseLabel.Name = "releaseLabel";
            this.releaseLabel.Size = new System.Drawing.Size(74, 13);
            this.releaseLabel.TabIndex = 6;
            this.releaseLabel.Text = "Release Year:";
            this.releaseLabel.Visible = false;
            // 
            // artistTextBox
            // 
            this.artistTextBox.Location = new System.Drawing.Point(162, 103);
            this.artistTextBox.Name = "artistTextBox";
            this.artistTextBox.Size = new System.Drawing.Size(100, 20);
            this.artistTextBox.TabIndex = 7;
            this.artistTextBox.Visible = false;
            // 
            // albumTextBox
            // 
            this.albumTextBox.Location = new System.Drawing.Point(162, 136);
            this.albumTextBox.Name = "albumTextBox";
            this.albumTextBox.Size = new System.Drawing.Size(100, 20);
            this.albumTextBox.TabIndex = 8;
            this.albumTextBox.Visible = false;
            // 
            // releaseMaskedTextBox
            // 
            this.releaseMaskedTextBox.Location = new System.Drawing.Point(162, 167);
            this.releaseMaskedTextBox.Mask = "0000";
            this.releaseMaskedTextBox.Name = "releaseMaskedTextBox";
            this.releaseMaskedTextBox.Size = new System.Drawing.Size(100, 20);
            this.releaseMaskedTextBox.TabIndex = 9;
            this.releaseMaskedTextBox.ValidatingType = typeof(System.DateTime);
            this.releaseMaskedTextBox.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 292);
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
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
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
    }
}

