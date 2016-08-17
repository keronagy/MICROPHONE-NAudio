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
            this.volumeBar = new System.Windows.Forms.TrackBar();
            this.SeekingBar1 = new System.Windows.Forms.TrackBar();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BtnMute = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.waveformPainter1 = new NAudio.Gui.WaveformPainter();
            this.waveformPainter2 = new NAudio.Gui.WaveformPainter();
            this.trackBar8 = new System.Windows.Forms.TrackBar();
            this.trackBar7 = new System.Windows.Forms.TrackBar();
            this.trackBar6 = new System.Windows.Forms.TrackBar();
            this.trackBar5 = new System.Windows.Forms.TrackBar();
            this.trackBar4 = new System.Windows.Forms.TrackBar();
            this.trackBar3 = new System.Windows.Forms.TrackBar();
            this.trackBar2 = new System.Windows.Forms.TrackBar();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.LblCurrentPos = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.volumeBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SeekingBar1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // LblPlayList
            // 
            this.LblPlayList.BackColor = System.Drawing.Color.Transparent;
            this.LblPlayList.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPlayList.ForeColor = System.Drawing.Color.White;
            this.LblPlayList.Location = new System.Drawing.Point(444, 16);
            this.LblPlayList.Name = "LblPlayList";
            this.LblPlayList.Size = new System.Drawing.Size(178, 29);
            this.LblPlayList.TabIndex = 12;
            this.LblPlayList.Text = "PlayList";
            this.LblPlayList.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BtnAdd
            // 
            this.BtnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(46)))), ((int)(((byte)(13)))));
            this.BtnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAdd.Image = ((System.Drawing.Image)(resources.GetObject("BtnAdd.Image")));
            this.BtnAdd.Location = new System.Drawing.Point(373, 321);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(30, 30);
            this.BtnAdd.TabIndex = 13;
            this.toolTip1.SetToolTip(this.BtnAdd, "Add");
            this.BtnAdd.UseVisualStyleBackColor = false;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // BtnPlay
            // 
            this.BtnPlay.Enabled = false;
            this.BtnPlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPlay.Image = ((System.Drawing.Image)(resources.GetObject("BtnPlay.Image")));
            this.BtnPlay.Location = new System.Drawing.Point(134, 321);
            this.BtnPlay.Name = "BtnPlay";
            this.BtnPlay.Size = new System.Drawing.Size(30, 30);
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
            this.PlayListView.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PlayListView.BackgroundImage")));
            this.PlayListView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PlayListView.ForeColor = System.Drawing.Color.Gray;
            this.PlayListView.Location = new System.Drawing.Point(421, 52);
            this.PlayListView.MultiSelect = false;
            this.PlayListView.Name = "PlayListView";
            this.PlayListView.Size = new System.Drawing.Size(212, 299);
            this.PlayListView.TabIndex = 15;
            this.PlayListView.UseCompatibleStateImageBehavior = false;
            this.PlayListView.View = System.Windows.Forms.View.List;
            this.PlayListView.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PlayListView_KeyDown);
            this.PlayListView.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.PlayListView_MouseDoubleClick);
            // 
            // BtnStop
            // 
            this.BtnStop.Enabled = false;
            this.BtnStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnStop.Image = ((System.Drawing.Image)(resources.GetObject("BtnStop.Image")));
            this.BtnStop.Location = new System.Drawing.Point(101, 321);
            this.BtnStop.Name = "BtnStop";
            this.BtnStop.Size = new System.Drawing.Size(30, 30);
            this.BtnStop.TabIndex = 17;
            this.toolTip1.SetToolTip(this.BtnStop, "Stop");
            this.BtnStop.UseVisualStyleBackColor = true;
            this.BtnStop.Click += new System.EventHandler(this.BtnStop_Click);
            // 
            // BtnPrev
            // 
            this.BtnPrev.Enabled = false;
            this.BtnPrev.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPrev.Image = ((System.Drawing.Image)(resources.GetObject("BtnPrev.Image")));
            this.BtnPrev.Location = new System.Drawing.Point(68, 321);
            this.BtnPrev.Name = "BtnPrev";
            this.BtnPrev.Size = new System.Drawing.Size(30, 30);
            this.BtnPrev.TabIndex = 18;
            this.toolTip1.SetToolTip(this.BtnPrev, "Previous");
            this.BtnPrev.UseVisualStyleBackColor = true;
            this.BtnPrev.Click += new System.EventHandler(this.BtnPrev_Click);
            // 
            // BtnNext
            // 
            this.BtnNext.Enabled = false;
            this.BtnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnNext.Image = ((System.Drawing.Image)(resources.GetObject("BtnNext.Image")));
            this.BtnNext.Location = new System.Drawing.Point(167, 321);
            this.BtnNext.Name = "BtnNext";
            this.BtnNext.Size = new System.Drawing.Size(30, 30);
            this.BtnNext.TabIndex = 19;
            this.BtnNext.Tag = "";
            this.toolTip1.SetToolTip(this.BtnNext, "Next");
            this.BtnNext.UseVisualStyleBackColor = true;
            this.BtnNext.Click += new System.EventHandler(this.BtnNext_Click);
            // 
            // BtnShuffle
            // 
            this.BtnShuffle.Enabled = false;
            this.BtnShuffle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnShuffle.Image = ((System.Drawing.Image)(resources.GetObject("BtnShuffle.Image")));
            this.BtnShuffle.Location = new System.Drawing.Point(35, 321);
            this.BtnShuffle.Name = "BtnShuffle";
            this.BtnShuffle.Size = new System.Drawing.Size(30, 30);
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
            this.BtnRepeat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRepeat.Image = ((System.Drawing.Image)(resources.GetObject("BtnRepeat.Image")));
            this.BtnRepeat.Location = new System.Drawing.Point(200, 321);
            this.BtnRepeat.Name = "BtnRepeat";
            this.BtnRepeat.Size = new System.Drawing.Size(30, 30);
            this.BtnRepeat.TabIndex = 21;
            this.BtnRepeat.Tag = "";
            this.toolTip1.SetToolTip(this.BtnRepeat, "Repeat");
            this.BtnRepeat.UseVisualStyleBackColor = true;
            this.BtnRepeat.Click += new System.EventHandler(this.BtnRepeat_Click);
            // 
            // LblDuration
            // 
            this.LblDuration.AutoSize = true;
            this.LblDuration.Location = new System.Drawing.Point(355, 295);
            this.LblDuration.Name = "LblDuration";
            this.LblDuration.Size = new System.Drawing.Size(0, 13);
            this.LblDuration.TabIndex = 24;
            // 
            // volumeBar
            // 
            this.volumeBar.BackColor = System.Drawing.Color.Black;
            this.volumeBar.Location = new System.Drawing.Point(266, 321);
            this.volumeBar.Maximum = 50;
            this.volumeBar.MaximumSize = new System.Drawing.Size(104, 30);
            this.volumeBar.Name = "volumeBar";
            this.volumeBar.Size = new System.Drawing.Size(104, 45);
            this.volumeBar.TabIndex = 26;
            this.volumeBar.Value = 25;
            this.volumeBar.Scroll += new System.EventHandler(this.VoulumeBar_Scroll);
            // 
            // SeekingBar1
            // 
            this.SeekingBar1.BackColor = System.Drawing.Color.Black;
            this.SeekingBar1.Location = new System.Drawing.Point(11, 270);
            this.SeekingBar1.Name = "SeekingBar1";
            this.SeekingBar1.Size = new System.Drawing.Size(403, 45);
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
            this.menuStrip1.Size = new System.Drawing.Size(642, 24);
            this.menuStrip1.TabIndex = 28;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
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
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // BtnMute
            // 
            this.BtnMute.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMute.Image = global::MICROPHONE.Properties.Resources.mute;
            this.BtnMute.Location = new System.Drawing.Point(233, 321);
            this.BtnMute.Name = "BtnMute";
            this.BtnMute.Size = new System.Drawing.Size(30, 30);
            this.BtnMute.TabIndex = 29;
            this.toolTip1.SetToolTip(this.BtnMute, "Mute");
            this.BtnMute.UseVisualStyleBackColor = true;
            this.BtnMute.Click += new System.EventHandler(this.BtnMute_Click);
            // 
            // waveformPainter1
            // 
            this.waveformPainter1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("waveformPainter1.BackgroundImage")));
            this.waveformPainter1.ForeColor = System.Drawing.Color.White;
            this.waveformPainter1.Location = new System.Drawing.Point(12, 52);
            this.waveformPainter1.Name = "waveformPainter1";
            this.waveformPainter1.Size = new System.Drawing.Size(402, 44);
            this.waveformPainter1.TabIndex = 31;
            this.waveformPainter1.Text = "waveformPainter1";
            // 
            // waveformPainter2
            // 
            this.waveformPainter2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("waveformPainter2.BackgroundImage")));
            this.waveformPainter2.ForeColor = System.Drawing.Color.White;
            this.waveformPainter2.Location = new System.Drawing.Point(12, 102);
            this.waveformPainter2.Name = "waveformPainter2";
            this.waveformPainter2.Size = new System.Drawing.Size(402, 44);
            this.waveformPainter2.TabIndex = 32;
            this.waveformPainter2.Text = "waveformPainter2";
            // 
            // trackBar8
            // 
            this.trackBar8.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.trackBar8.Location = new System.Drawing.Point(12, 157);
            this.trackBar8.Maximum = 30;
            this.trackBar8.Minimum = -30;
            this.trackBar8.Name = "trackBar8";
            this.trackBar8.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBar8.Size = new System.Drawing.Size(45, 108);
            this.trackBar8.TabIndex = 40;
            this.trackBar8.Scroll += new System.EventHandler(this.trackBar8_Scroll);
            // 
            // trackBar7
            // 
            this.trackBar7.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.trackBar7.Location = new System.Drawing.Point(63, 157);
            this.trackBar7.Maximum = 30;
            this.trackBar7.Minimum = -30;
            this.trackBar7.Name = "trackBar7";
            this.trackBar7.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBar7.Size = new System.Drawing.Size(45, 108);
            this.trackBar7.TabIndex = 39;
            this.trackBar7.Scroll += new System.EventHandler(this.trackBar7_Scroll);
            // 
            // trackBar6
            // 
            this.trackBar6.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.trackBar6.Location = new System.Drawing.Point(114, 157);
            this.trackBar6.Maximum = 30;
            this.trackBar6.Minimum = -30;
            this.trackBar6.Name = "trackBar6";
            this.trackBar6.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBar6.Size = new System.Drawing.Size(45, 108);
            this.trackBar6.TabIndex = 38;
            this.trackBar6.Scroll += new System.EventHandler(this.trackBar6_Scroll);
            // 
            // trackBar5
            // 
            this.trackBar5.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.trackBar5.Location = new System.Drawing.Point(165, 157);
            this.trackBar5.Maximum = 30;
            this.trackBar5.Minimum = -30;
            this.trackBar5.Name = "trackBar5";
            this.trackBar5.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBar5.Size = new System.Drawing.Size(45, 108);
            this.trackBar5.TabIndex = 37;
            this.trackBar5.Scroll += new System.EventHandler(this.trackBar5_Scroll);
            // 
            // trackBar4
            // 
            this.trackBar4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.trackBar4.Location = new System.Drawing.Point(216, 157);
            this.trackBar4.Maximum = 30;
            this.trackBar4.Minimum = -30;
            this.trackBar4.Name = "trackBar4";
            this.trackBar4.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBar4.Size = new System.Drawing.Size(45, 108);
            this.trackBar4.TabIndex = 36;
            this.trackBar4.Scroll += new System.EventHandler(this.trackBar4_Scroll);
            // 
            // trackBar3
            // 
            this.trackBar3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.trackBar3.Location = new System.Drawing.Point(267, 157);
            this.trackBar3.Maximum = 30;
            this.trackBar3.Minimum = -30;
            this.trackBar3.Name = "trackBar3";
            this.trackBar3.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBar3.Size = new System.Drawing.Size(45, 108);
            this.trackBar3.TabIndex = 35;
            this.trackBar3.Scroll += new System.EventHandler(this.trackBar3_Scroll);
            // 
            // trackBar2
            // 
            this.trackBar2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.trackBar2.Location = new System.Drawing.Point(318, 157);
            this.trackBar2.Maximum = 30;
            this.trackBar2.Minimum = -30;
            this.trackBar2.Name = "trackBar2";
            this.trackBar2.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBar2.Size = new System.Drawing.Size(45, 108);
            this.trackBar2.TabIndex = 34;
            this.trackBar2.Scroll += new System.EventHandler(this.trackBar2_Scroll);
            // 
            // trackBar1
            // 
            this.trackBar1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.trackBar1.Location = new System.Drawing.Point(369, 157);
            this.trackBar1.Maximum = 30;
            this.trackBar1.Minimum = -30;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBar1.Size = new System.Drawing.Size(45, 108);
            this.trackBar1.TabIndex = 33;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // LblCurrentPos
            // 
            this.LblCurrentPos.AutoSize = true;
            this.LblCurrentPos.Location = new System.Drawing.Point(32, 295);
            this.LblCurrentPos.Name = "LblCurrentPos";
            this.LblCurrentPos.Size = new System.Drawing.Size(0, 13);
            this.LblCurrentPos.TabIndex = 25;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(642, 386);
            this.Controls.Add(this.trackBar8);
            this.Controls.Add(this.trackBar7);
            this.Controls.Add(this.trackBar6);
            this.Controls.Add(this.trackBar5);
            this.Controls.Add(this.trackBar4);
            this.Controls.Add(this.trackBar3);
            this.Controls.Add(this.trackBar2);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.waveformPainter2);
            this.Controls.Add(this.waveformPainter1);
            this.Controls.Add(this.BtnMute);
            this.Controls.Add(this.volumeBar);
            this.Controls.Add(this.LblCurrentPos);
            this.Controls.Add(this.LblDuration);
            this.Controls.Add(this.SeekingBar1);
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
            ((System.ComponentModel.ISupportInitialize)(this.trackBar8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
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
        private System.Windows.Forms.TrackBar SeekingBar1;
        private System.Windows.Forms.Label LblDuration;
        private System.Windows.Forms.TrackBar volumeBar;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Button BtnMute;
        private System.Windows.Forms.ToolTip toolTip1;
        private NAudio.Gui.WaveformPainter waveformPainter1;
        private NAudio.Gui.WaveformPainter waveformPainter2;
        private System.Windows.Forms.TrackBar trackBar8;
        private System.Windows.Forms.TrackBar trackBar7;
        private System.Windows.Forms.TrackBar trackBar6;
        private System.Windows.Forms.TrackBar trackBar5;
        private System.Windows.Forms.TrackBar trackBar4;
        private System.Windows.Forms.TrackBar trackBar3;
        private System.Windows.Forms.TrackBar trackBar2;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label LblCurrentPos;
    }
}

