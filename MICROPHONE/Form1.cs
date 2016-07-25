using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;

namespace MICROPHONE
{
    public partial class Form1 : Form
    {
        WindowsMediaPlayer axWindowsMediaPlayer1;
        private List<sound> sounds = new List<sound>();
        private System.Windows.Forms.Timer timer;
        bool shuffle = false;
        bool repeat = false;
        bool pause = false;
        int currentVol = 0;
        bool mute = false;
        public Form1()
        {
             axWindowsMediaPlayer1= new WMPLib.WindowsMediaPlayer();

            InitializeComponent();
           
            timer = new System.Windows.Forms.Timer();
            timer.Interval = 1000;
            timer.Tick += timer_Tick;
            timer.Start();
            
            


        }



        void timer_Tick(object sender, EventArgs e)
        {
            if (PlayListView.Items.Count != 0 && axWindowsMediaPlayer1.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                string name = axWindowsMediaPlayer1.currentMedia.name;

                for (int i = 0; i < PlayListView.Items.Count; i++)
                {
                    if (name == PlayListView.Items[i].Text)
                    {
                        PlayListView.Items[i].Selected = true;
                        PlayListView.Items[i].Focused = true;
                        PlayListView.Select();

                       
                    }



                }
                if ((axWindowsMediaPlayer1.URL != null))
                    {
                        SeekingBar1.Minimum = 0;
                        SeekingBar1.Maximum = (int)axWindowsMediaPlayer1.currentMedia.duration+1;
                        SeekingBar1.Value = (int)axWindowsMediaPlayer1.controls.currentPosition;

                    }
                    LblCurrentPos.Text = axWindowsMediaPlayer1.controls.currentPositionString;
                    LblDuration.Text = axWindowsMediaPlayer1.currentMedia.durationString;
                


                }

            }
        

        

        

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() != DialogResult.Cancel)
            {
                foreach (String Path in openFileDialog1.FileNames)
                {
                    this.sounds.Add(new sound(Path, System.IO.Path.GetFileNameWithoutExtension(Path)));
                    PlayListView.Items.Add(System.IO.Path.GetFileNameWithoutExtension(Path));
                }

                this.BtnNext.Enabled = true;
                this.BtnPlay.Enabled = true;
                this.BtnPrev.Enabled = true;
                this.BtnShuffle.Enabled = true;
                this.BtnRepeat.Enabled = true;
                this.BtnStop.Enabled = true;

            }
        }

        private void BtnPlay_Click(object sender, EventArgs e)
        {

            if (axWindowsMediaPlayer1.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                axWindowsMediaPlayer1.controls.pause();
                pause = true;
                this.BtnPlay.Image = Properties.Resources.play;
                this.toolTip1.SetToolTip(this.BtnPlay, "Play");
            }
            else
            {
                if (pause == true)
                {
                    axWindowsMediaPlayer1.controls.play();
                    pause = false;
                    this.BtnPlay.Image = Properties.Resources.pause;
                    this.toolTip1.SetToolTip(this.BtnPlay, "Pause");
                }
                else
                {

                    WMPLib.IWMPPlaylist playlist = axWindowsMediaPlayer1.playlistCollection.newPlaylist("PlayList");
                    WMPLib.IWMPMedia media;

                    for (int i = 0; i < PlayListView.Items.Count; i++)
                    {
                        media = axWindowsMediaPlayer1.newMedia(getPath(PlayListView.Items[i].Text));
                        playlist.appendItem(media);

                        axWindowsMediaPlayer1.currentPlaylist = playlist;
                        axWindowsMediaPlayer1.controls.play();
                        pause = false;

                    }
                    this.BtnPlay.Image = Properties.Resources.pause;
                    this.toolTip1.SetToolTip(this.BtnPlay, "Pause");

                }
            }
        }
        public string getPath(string name)
        {
            foreach(sound s in sounds)
            {
                if (name == s.Name)
                {
                    return s.Path;
                }
            }
            return null;
        }
        public string getName(string Path)
        {
            foreach (sound s in sounds)
            {
                if (Path == s.Path)
                {
                    return s.Name;
                }
            }
            return null;
        }

        private void PlayListView_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            axWindowsMediaPlayer1.URL = getPath(PlayListView.FocusedItem.Text);
            this.BtnPlay.Image = Properties.Resources.pause;
            this.toolTip1.SetToolTip(this.BtnPlay, "Pause");

        }

        private void BtnStop_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.controls.stop();
            this.SeekingBar1.Value = 0;
            LblCurrentPos.Text="";
            LblDuration.Text = "";
            this.BtnPlay.Image = Properties.Resources.play;
            this.toolTip1.SetToolTip(this.BtnPlay, "Play");
            

        }

        
        private void BtnNext_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.controls.next();
        }

        private void BtnPrev_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.controls.previous() ;
        }

        private void BtnRepeat_Click(object sender, EventArgs e)
        {
            if (repeat == false)
            {
                axWindowsMediaPlayer1.settings.setMode("loop", true);
                repeat = true;
                this.BtnRepeat.Image = Properties.Resources.repeate_on;
                this.toolTip1.SetToolTip(this.BtnRepeat, "Stop Repeat");
            }
            else
            {
                axWindowsMediaPlayer1.settings.setMode("loop", false);
                repeat = false;
                this.BtnRepeat.Image = Properties.Resources.repeate;
                this.toolTip1.SetToolTip(this.BtnRepeat, "Repeat");
                
            }
        }

        private void BtnShuffle_Click(object sender, EventArgs e)
        {
            if (shuffle == false)
            {
                axWindowsMediaPlayer1.settings.setMode("shuffle", true);
                shuffle = true;
                this.BtnShuffle.Image = Properties.Resources.shuffle_on;
                this.toolTip1.SetToolTip(this.BtnShuffle, "Stop Shuffle");

            }
            else
            {
                axWindowsMediaPlayer1.settings.setMode("shuffle", false);
                shuffle = false;
                this.BtnShuffle.Image = Properties.Resources.shuffle;
                this.toolTip1.SetToolTip(this.BtnShuffle, "Shuffle");
            }
        }

        private void VoulumeBar_Scroll(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.settings.volume = volumeBar.Value;
        }

        

       

        private void SeekingBar1_Scroll(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.controls.currentPosition = (double)SeekingBar1.Value;
        }

        private void PlayListView_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete && axWindowsMediaPlayer1.playState == WMPLib.WMPPlayState.wmppsStopped)
            {
                PlayListView.SelectedItems[0].Remove();
            }
            else if (e.KeyCode == Keys.Delete && axWindowsMediaPlayer1.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                MessageBox.Show("Cannot delete when playlist is playing");
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() != DialogResult.Cancel)
            {
                foreach (String file in openFileDialog1.FileNames)
                {
                    this.sounds.Add(new sound(file, System.IO.Path.GetFileNameWithoutExtension(file)));
                    PlayListView.Items.Add(System.IO.Path.GetFileNameWithoutExtension(file));
                }

            }
        }


        private void BtnMute_Click(object sender, EventArgs e)
        {
            if (mute == false)
            {
                currentVol = volumeBar.Value;
                axWindowsMediaPlayer1.settings.volume = 0;
                volumeBar.Value = 0;
                mute = true;
                this.BtnMute.Image = Properties.Resources.mute_on;
                this.toolTip1.SetToolTip(this.BtnMute, "UnMute");
            }
            else
            {
                axWindowsMediaPlayer1.settings.volume = currentVol;
                volumeBar.Value = currentVol;
                mute = false;
                this.BtnMute.Image = Properties.Resources.mute;
                this.toolTip1.SetToolTip(this.BtnMute, "Mute");
            }
        }

        

        


        
    }
}
    

