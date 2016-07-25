namespace MICROPHONE
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.LblPlayList = new System.Windows.Forms.Label();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.BtnPlay = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.PlayListView = new System.Windows.Forms.ListView();
            this.BtnStop = new System.Windows.Forms.Button();
            this.BtnPrev = new System.Windows.Forms.Button();
            this.BtnNext = new System.Windows.Forms.Button();
            this.BtnShuffle = new System.Windows.Forms.Button();
            this.BtnRepeat = new System.Windows.Forms.Button();
            this.LblDuration = new System.Windows.Forms.Label();
            this.LblCurrentPos = new System.Windows.Forms.Label();
            this.volumeBar = new System.Windows.Forms.TrackBar();
            this.SeekingBar1 = new System.Windows.Forms.TrackBar();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BtnMute = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.volumeBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SeekingBar1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LblPlayList
            // 
            this.LblPlayList.BackColor = System.Drawing.Color.Transparent;
            this.LblPlayList.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPlayList.ForeColor = System.Drawing.Color.Gray;
            this.LblPlayList.Location = new System.Drawing.Point(688, 0);
            this.LblPlayList.Name = "LblPlayList";
            this.LblPlayList.Size = new System.Drawing.Size(178, 29);
            this.LblPlayList.TabIndex = 12;
            this.LblPlayList.Text = "PlayList";
            this.LblPlayList.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BtnAdd
            // 
            this.BtnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(46)))), ((int)(((byte)(13)))));
            this.BtnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAdd.Image = ((System.Drawing.Image)(resources.GetObject("BtnAdd.Image")));
            this.BtnAdd.Location = new System.Drawing.Point(642, 502);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(40, 33);
            this.BtnAdd.TabIndex = 13;
            this.toolTip1.SetToolTip(this.BtnAdd, "Add");
            this.BtnAdd.UseVisualStyleBackColor = false;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // BtnPlay
            // 
            this.BtnPlay.Enabled = false;
            this.BtnPlay.Image = ((System.Drawing.Image)(resources.GetObject("BtnPlay.Image")));
            this.BtnPlay.Location = new System.Drawing.Point(121, 437);
            this.BtnPlay.Name = "BtnPlay";
            this.BtnPlay.Size = new System.Drawing.Size(29, 29);
            this.BtnPlay.TabIndex = 14;
            this.toolTip1.SetToolTip(this.BtnPlay, "Play");
            this.BtnPlay.Click += new System.EventHandler(this.BtnPlay_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog";
            this.openFileDialog1.Multiselect = true;
            // 
            // PlayListView
            // 
            this.PlayListView.ForeColor = System.Drawing.Color.Gray;
            this.PlayListView.Location = new System.Drawing.Point(688, 37);
            this.PlayListView.MultiSelect = false;
            this.PlayListView.Name = "PlayListView";
            this.PlayListView.Size = new System.Drawing.Size(178, 498);
            this.PlayListView.TabIndex = 15;
            this.PlayListView.UseCompatibleStateImageBehavior = false;
            this.PlayListView.View = System.Windows.Forms.View.List;
            this.PlayListView.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PlayListView_KeyDown);
            this.PlayListView.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.PlayListView_MouseDoubleClick);
            // 
            // BtnStop
            // 
            this.BtnStop.Enabled = false;
            this.BtnStop.Image = ((System.Drawing.Image)(resources.GetObject("BtnStop.Image")));
            this.BtnStop.Location = new System.Drawing.Point(206, 440);
            this.BtnStop.Name = "BtnStop";
            this.BtnStop.Size = new System.Drawing.Size(27, 27);
            this.BtnStop.TabIndex = 17;
            this.toolTip1.SetToolTip(this.BtnStop, "Stop");
            this.BtnStop.UseVisualStyleBackColor = true;
            this.BtnStop.Click += new System.EventHandler(this.BtnStop_Click);
            // 
            // BtnPrev
            // 
            this.BtnPrev.Enabled = false;
            this.BtnPrev.Image = ((System.Drawing.Image)(resources.GetObject("BtnPrev.Image")));
            this.BtnPrev.Location = new System.Drawing.Point(71, 440);
            this.BtnPrev.Name = "BtnPrev";
            this.BtnPrev.Size = new System.Drawing.Size(44, 26);
            this.BtnPrev.TabIndex = 18;
            this.toolTip1.SetToolTip(this.BtnPrev, "Previous");
            this.BtnPrev.UseVisualStyleBackColor = true;
            this.BtnPrev.Click += new System.EventHandler(this.BtnPrev_Click);
            // 
            // BtnNext
            // 
            this.BtnNext.Enabled = false;
            this.BtnNext.Image = ((System.Drawing.Image)(resources.GetObject("BtnNext.Image")));
            this.BtnNext.Location = new System.Drawing.Point(156, 440);
            this.BtnNext.Name = "BtnNext";
            this.BtnNext.Size = new System.Drawing.Size(44, 27);
            this.BtnNext.TabIndex = 19;
            this.BtnNext.Tag = "";
            this.toolTip1.SetToolTip(this.BtnNext, "Next");
            this.BtnNext.UseVisualStyleBackColor = true;
            this.BtnNext.Click += new System.EventHandler(this.BtnNext_Click);
            // 
            // BtnShuffle
            // 
            this.BtnShuffle.Enabled = false;
            this.BtnShuffle.Image = ((System.Drawing.Image)(resources.GetObject("BtnShuffle.Image")));
            this.BtnShuffle.Location = new System.Drawing.Point(37, 440);
            this.BtnShuffle.Name = "BtnShuffle";
            this.BtnShuffle.Size = new System.Drawing.Size(28, 26);
            this.BtnShuffle.TabIndex = 20;
            this.BtnShuffle.Text = "\r\n";
            this.toolTip1.SetToolTip(this.BtnShuffle, "Shuffle");
            this.BtnShuffle.UseVisualStyleBackColor = true;
            this.BtnShuffle.Click += new System.EventHandler(this.BtnShuffle_Click);
            // 
            // BtnRepeat
            // 
            this.BtnRepeat.AccessibleDescription = "";
            this.BtnRepeat.AccessibleName = "";
            this.BtnRepeat.Enabled = false;
            this.BtnRepeat.Image = ((System.Drawing.Image)(resources.GetObject("BtnRepeat.Image")));
            this.BtnRepeat.Location = new System.Drawing.Point(239, 440);
            this.BtnRepeat.Name = "BtnRepeat";
            this.BtnRepeat.Size = new System.Drawing.Size(34, 26);
            this.BtnRepeat.TabIndex = 21;
            this.BtnRepeat.Tag = "";
            this.toolTip1.SetToolTip(this.BtnRepeat, "Repeat");
            this.BtnRepeat.UseVisualStyleBackColor = true;
            this.BtnRepeat.Click += new System.EventHandler(this.BtnRepeat_Click);
            // 
            // LblDuration
            // 
            this.LblDuration.AutoSize = true;
            this.LblDuration.Location = new System.Drawing.Point(442, 486);
            this.LblDuration.Name = "LblDuration";
            this.LblDuration.Size = new System.Drawing.Size(0, 13);
            this.LblDuration.TabIndex = 24;
            // 
            // LblCurrentPos
            // 
            this.LblCurrentPos.AutoSize = true;
            this.LblCurrentPos.Location = new System.Drawing.Point(25, 486);
            this.LblCurrentPos.Name = "LblCurrentPos";
            this.LblCurrentPos.Size = new System.Drawing.Size(0, 13);
            this.LblCurrentPos.TabIndex = 25;
            // 
            // volumeBar
            // 
            this.volumeBar.BackColor = System.Drawing.Color.White;
            this.volumeBar.Location = new System.Drawing.Point(532, 502);
            this.volumeBar.Maximum = 100;
            this.volumeBar.Name = "volumeBar";
            this.volumeBar.Size = new System.Drawing.Size(104, 45);
            this.volumeBar.TabIndex = 26;
            this.volumeBar.Value = 50;
            this.volumeBar.Scroll += new System.EventHandler(this.VoulumeBar_Scroll);
            // 
            // SeekingBar1
            // 
            this.SeekingBar1.BackColor = System.Drawing.Color.White;
            this.SeekingBar1.Location = new System.Drawing.Point(-2, 502);
            this.SeekingBar1.Name = "SeekingBar1";
            this.SeekingBar1.Size = new System.Drawing.Size(495, 45);
            this.SeekingBar1.TabIndex = 27;
            this.SeekingBar1.TickStyle = System.Windows.Forms.TickStyle.None;
            this.SeekingBar1.Scroll += new System.EventHandler(this.SeekingBar1_Scroll);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(866, 24);
            this.menuStrip1.TabIndex = 28;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.closeToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.closeToolStripMenuItem.Text = "Close";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // BtnMute
            // 
            this.BtnMute.Image = global::MICROPHONE.Properties.Resources.mute;
            this.BtnMute.Location = new System.Drawing.Point(499, 502);
            this.BtnMute.Name = "BtnMute";
            this.BtnMute.Size = new System.Drawing.Size(33, 33);
            this.BtnMute.TabIndex = 29;
            this.toolTip1.SetToolTip(this.BtnMute, "Mute");
            this.BtnMute.UseVisualStyleBackColor = true;
            this.BtnMute.Click += new System.EventHandler(this.BtnMute_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(866, 559);
            this.Controls.Add(this.BtnMute);
            this.Controls.Add(this.SeekingBar1);
            this.Controls.Add(this.volumeBar);
            this.Controls.Add(this.LblCurrentPos);
            this.Controls.Add(this.LblDuration);
            this.Controls.Add(this.BtnRepeat);
            this.Controls.Add(this.BtnShuffle);
            this.Controls.Add(this.BtnNext);
            this.Controls.Add(this.BtnPrev);
            this.Controls.Add(this.BtnStop);
            this.Controls.Add(this.PlayListView);
            this.Controls.Add(this.BtnPlay);
            this.Controls.Add(this.BtnAdd);
            this.Controls.Add(this.LblPlayList);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "MICROPHONE";
            ((System.ComponentModel.ISupportInitialize)(this.volumeBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SeekingBar1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblPlayList;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.Button BtnPlay;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ListView PlayListView;
        private System.Windows.Forms.Button BtnStop;
        private System.Windows.Forms.Button BtnPrev;
        private System.Windows.Forms.Button BtnNext;
        private System.Windows.Forms.Button BtnShuffle;
        private System.Windows.Forms.Button BtnRepeat;
        private System.Windows.Forms.Label LblDuration;
        private System.Windows.Forms.Label LblCurrentPos;
        private System.Windows.Forms.TrackBar volumeBar;
        private System.Windows.Forms.TrackBar SeekingBar1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Button BtnMute;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

