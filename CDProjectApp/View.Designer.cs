
namespace CDProjectApp
{
    partial class View
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
            this.viewLabel = new System.Windows.Forms.Label();
            this.cdListView = new System.Windows.Forms.ListView();
            this.selected = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.genre = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.artist = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.album = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.releaseYear = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.runTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tracks = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.location = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.deleteButton = new System.Windows.Forms.Button();
            this.viewMainLabel = new System.Windows.Forms.Label();
            this.editButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // viewLabel
            // 
            this.viewLabel.AutoSize = true;
            this.viewLabel.Font = new System.Drawing.Font("Lucida Console", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewLabel.Location = new System.Drawing.Point(215, 30);
            this.viewLabel.Name = "viewLabel";
            this.viewLabel.Size = new System.Drawing.Size(318, 27);
            this.viewLabel.TabIndex = 0;
            this.viewLabel.Text = "View My CD Library";
            this.viewLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cdListView
            // 
            this.cdListView.CheckBoxes = true;
            this.cdListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.selected,
            this.genre,
            this.artist,
            this.album,
            this.releaseYear,
            this.runTime,
            this.tracks,
            this.location});
            this.cdListView.HideSelection = false;
            this.cdListView.Location = new System.Drawing.Point(12, 102);
            this.cdListView.MultiSelect = false;
            this.cdListView.Name = "cdListView";
            this.cdListView.Size = new System.Drawing.Size(724, 325);
            this.cdListView.TabIndex = 0;
            this.cdListView.UseCompatibleStateImageBehavior = false;
            this.cdListView.View = System.Windows.Forms.View.Details;
            this.cdListView.ItemChecked += new System.Windows.Forms.ItemCheckedEventHandler(this.CDListView_ItemChecked);
            // 
            // selected
            // 
            this.selected.Text = "";
            this.selected.Width = 23;
            // 
            // genre
            // 
            this.genre.Text = "Genre";
            this.genre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.genre.Width = 100;
            // 
            // artist
            // 
            this.artist.Text = "Artist";
            this.artist.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.artist.Width = 100;
            // 
            // album
            // 
            this.album.Text = "Album";
            this.album.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.album.Width = 100;
            // 
            // releaseYear
            // 
            this.releaseYear.Text = "Released";
            this.releaseYear.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.releaseYear.Width = 100;
            // 
            // runTime
            // 
            this.runTime.Text = "Run Time";
            this.runTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.runTime.Width = 100;
            // 
            // tracks
            // 
            this.tracks.Text = "Number of Tracks";
            this.tracks.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tracks.Width = 100;
            // 
            // location
            // 
            this.location.Text = "Location";
            this.location.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.location.Width = 100;
            // 
            // deleteButton
            // 
            this.deleteButton.BackColor = System.Drawing.Color.LightCoral;
            this.deleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteButton.Font = new System.Drawing.Font("Bahnschrift Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteButton.Location = new System.Drawing.Point(433, 439);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(100, 60);
            this.deleteButton.TabIndex = 0;
            this.deleteButton.TabStop = false;
            this.deleteButton.Text = "Delete CDs";
            this.deleteButton.UseVisualStyleBackColor = false;
            this.deleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // viewMainLabel
            // 
            this.viewMainLabel.AutoSize = true;
            this.viewMainLabel.Location = new System.Drawing.Point(39, 67);
            this.viewMainLabel.Name = "viewMainLabel";
            this.viewMainLabel.Size = new System.Drawing.Size(671, 13);
            this.viewMainLabel.TabIndex = 2;
            this.viewMainLabel.Text = "Here you can view all the CDs you have saved. Sort, search them using the control" +
    "s below or use the buttons to edit or delete selected ones.";
            // 
            // editButton
            // 
            this.editButton.BackColor = System.Drawing.Color.Khaki;
            this.editButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editButton.Font = new System.Drawing.Font("Bahnschrift Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editButton.Location = new System.Drawing.Point(220, 439);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(100, 60);
            this.editButton.TabIndex = 0;
            this.editButton.TabStop = false;
            this.editButton.Text = "Edit a CD";
            this.editButton.UseVisualStyleBackColor = false;
            // 
            // View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 511);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.viewMainLabel);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.cdListView);
            this.Controls.Add(this.viewLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "View";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "View My CDs";
            this.Shown += new System.EventHandler(this.View_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label viewLabel;
        private System.Windows.Forms.ListView cdListView;
        private System.Windows.Forms.ColumnHeader genre;
        private System.Windows.Forms.ColumnHeader artist;
        private System.Windows.Forms.ColumnHeader album;
        private System.Windows.Forms.ColumnHeader releaseYear;
        private System.Windows.Forms.ColumnHeader runTime;
        private System.Windows.Forms.ColumnHeader tracks;
        private System.Windows.Forms.ColumnHeader location;
        private System.Windows.Forms.ColumnHeader selected;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Label viewMainLabel;
        private System.Windows.Forms.Button editButton;
    }
}