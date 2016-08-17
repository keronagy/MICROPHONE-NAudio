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
using NAudio;
using NAudio.Wave;
using System.Media;

using System.Diagnostics;

using System.Threading;


using NAudio.Dsp;
using NAudio.Wave.SampleProviders;


namespace MICROPHONE
{
    public partial class Form1 : Form
    {
        
        private AudioFileReader reader;
        private IWavePlayer player;
        private Equali equalizer;
        private string selectedFile;
        EqualizerHandler equalizerHandler;
        ISampleProvider sampleProvider;
        private List<sound> sounds = new List<sound>();
        private System.Windows.Forms.Timer timer;
        bool shuffle = false;
        bool repeat = false;
        bool pause = false;
        int currentVol = 0;
        bool mute = false;
        bool stopped = false;
        bool last = false;
        Random rand;
        int i = 0;
        public Form1()
        {
             

            InitializeComponent();
            player = new WaveOutEvent();
            equalizerHandler = new EqualizerHandler();
            rand = new Random();
            timer = new System.Windows.Forms.Timer();
            timer.Interval = 1000;
            timer.Tick += timer_Tick;
            timer.Start();

          


        }



        void timer_Tick(object sender, EventArgs e)
        {
            //when playing
            if (PlayListView.Items.Count != 0 && player.PlaybackState == PlaybackState.Playing)
            {   //play next song when the seeking bar finished
                if (reader.CurrentTime.TotalSeconds >= reader.TotalTime.TotalSeconds-1 )
                {
                    //stop after the last song in the list finished playing when repeat and shuffle is false 
                    if (last == true && (repeat == false && shuffle == false))
                    {   //returning every thing to its normal value to start from the beginning
                        this.SeekingBar1.Value = 0;
                        i = 0;
                        stopped = true;
                        player.Stop();
                        waveformPainter1.Controls.Clear();
                        waveformPainter2.Controls.Clear();
                        LblCurrentPos.Text = "";
                        LblDuration.Text = "";
                        this.BtnPlay.Image = Properties.Resources.play;
                        this.toolTip1.SetToolTip(this.BtnPlay, "Play");
                        last = false;
                        timer.Stop();

                        return;
                    }

                    
                    PlaySong();
                }
                //get the name of the current song playing
                string name = getName(selectedFile);

                //select the song playing in the list
                for (int i = 0; i < PlayListView.Items.Count; i++)
                {
                    if (name == PlayListView.Items[i].Text)
                    {
                        PlayListView.Items[i].Selected = true;
                        PlayListView.Items[i].Focused = true;
                        PlayListView.Select();


                    }



                }
                //seekingBar values and strings of possisions
                if ((reader != null))
                {
                    SeekingBar1.Minimum = 0;
                    SeekingBar1.Maximum = (int)reader.TotalTime.TotalSeconds + 1;
                    SeekingBar1.Value = (int)reader.CurrentTime.TotalSeconds;


                    LblCurrentPos.Text = String.Format("{0:00}:{1:00}", (int)reader.CurrentTime.TotalMinutes,
                    (int)reader.CurrentTime.Seconds);
                    LblDuration.Text = String.Format("{0:00}:{1:00}", (int)reader.TotalTime.TotalMinutes,
                (int)reader.TotalTime.Seconds);

                }

            }
        }

    
        

        

        

        private void BtnAdd_Click(object sender, EventArgs e)
        {   
            if (openFileDialog1.ShowDialog() != DialogResult.Cancel)
            {   //Adding all the selected pathes to the playlist and listView
                foreach (String Path in openFileDialog1.FileNames)
                {   //creats new instance of sound and add it to the PlayList
                    this.sounds.Add(new sound(Path, System.IO.Path.GetFileNameWithoutExtension(Path)));
                    //Add only the name of the selected files to the ListView
                    PlayListView.Items.Add(System.IO.Path.GetFileNameWithoutExtension(Path));

                }
                //Enable the buttons
                this.BtnNext.Enabled = true;
                this.BtnPlay.Enabled = true;
                this.BtnPrev.Enabled = true;
                this.BtnShuffle.Enabled = true;
                this.BtnRepeat.Enabled = true;
                this.BtnStop.Enabled = true;

            }
        }

        private void BtnPlay_Click(object sender, EventArgs e)
        {   //start the timer
            timer.Start();

            //Pause if playing
            if (player.PlaybackState == PlaybackState.Playing)
            {
                player.Pause();
                pause = true;
                this.BtnPlay.Image = Properties.Resources.play;
                this.toolTip1.SetToolTip(this.BtnPlay, "Play");
            }
            else
            {   //Play if Paused
                if (pause == true)
                {
                    player.Play();
                    pause = false;
                    this.BtnPlay.Image = Properties.Resources.pause;
                    this.toolTip1.SetToolTip(this.BtnPlay, "Pause");
                }
                //Start the list if not playing and not paused
                else
                {
                    pause = false;
                    PlaySong();
                    
                    this.BtnPlay.Image = Properties.Resources.pause;
                    this.toolTip1.SetToolTip(this.BtnPlay, "Pause");

                }
            }
        }
        public void PlaySong()

        {
            //stopping the player and clear the reader
            if (player != null)
            {
                player.Dispose();
                player = null;
            }
            if (sampleProvider!= null)
            {
                sampleProvider = null;
                reader.Dispose();
            }
            //Dont play  if there is no songs in the PlayList
            if (sounds.Count < 1)
            {
                return;
            }
            //Stop the player if playing to play another song
            if (player != null && player.PlaybackState != PlaybackState.Stopped)
            {
                player.Stop();
            }

            

          
            
            
            //Normal Next
            if (shuffle == false && repeat ==false)
            {   
                //Play The current i (index) of the list then increment the index until reach the end and make the bool last song is true to stop after finishing
                selectedFile = sounds[i].Path;
                if (i < sounds.Count - 1 && i > -1)
                { i++;
                last = false; 
                }
                else
                {
                    last = true;
                }
                
            }
            //repeat and shuffle
            else if (repeat == true && shuffle == true || shuffle == true && repeat == false)
            {
                // make random i and play the random index
                i = rand.Next(sounds.Count);
                selectedFile = sounds[i].Path;
                
            }
            // repeat
            else if(repeat == true&&shuffle == false)
            {
                //same as normal way but when reach the last index make it start from the beginning by making the next index = 0
                selectedFile = sounds[i].Path;
                if (i < sounds.Count - 1 && i > -1)
                { i++; }
                else
                {
                    i = 0;
                }
            }
            

            SeekingBar1.Minimum = 0;
            player = new WaveOutEvent();
            //for visualization and play the sound
            sampleProvider =  CreateInputStream(selectedFile);
            //create the equalizer with the sampleProvider and bands (the scroll bars)
            equalizer = new Equali(sampleProvider, equalizerHandler.Bands);
            //make the equalizer in EqualizerHandler class equal to the equalizer in the form
            equalizerHandler.SongEqualizer = equalizer;
            //initialize the iWavePlayer with the equalizer
            player.Init(equalizer);
            //play
            player.Play();
            stopped = false;


           
        }
        private ISampleProvider CreateInputStream(string fileName)
        {
            reader = new AudioFileReader(fileName);

            //true >> force the sound to be 2 channels if it is only one 
            var sampleChannel = new SampleChannel(reader,true);
            //painting the visualization
            sampleChannel.PreVolumeMeter += OnPreVolumeMeter;
            // make a sampleProvider and return it 
            var postVolumeMeter = new MeteringSampleProvider(sampleChannel);
            

            return postVolumeMeter;
        }
        void OnPreVolumeMeter(object sender, StreamVolumeEventArgs e)
        {
            //waveFormPainter for every channel paints the max values in the array to form the visualization
            waveformPainter1.AddMax(e.MaxSampleValues[0]);
            waveformPainter2.AddMax(e.MaxSampleValues[1]);

        }
        

        // get the path of the current name of playing song
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
        //get the name of the path of playing song
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
        {//play exact song in the listView and continue the list from it
            //stopping the player and clear the reader
            if (player != null)
            {
                player.Dispose();
                player = null;
            }
            if (sampleProvider != null)
            {
                sampleProvider = null;
                reader.Dispose();
            }
            //Dont play  if there is no songs in the PlayList
            if (sounds.Count < 1)
            {
                return;
            }
            //Stop the player if playing to play another song
            if (player != null && player.PlaybackState != PlaybackState.Stopped)
            {
                player.Stop();
            }
            //get the path of the name of the song selected in the listView
            selectedFile= getPath(PlayListView.FocusedItem.Text);
            player = new WaveOutEvent();
            sampleProvider = CreateInputStream(selectedFile);
            
            SeekingBar1.Maximum = (int)reader.TotalTime.TotalSeconds;
            equalizer = new Equali(sampleProvider, equalizerHandler.Bands);
            equalizerHandler.SongEqualizer = equalizer;
            player.Init(equalizer);
            i = PlayListView.SelectedIndices[0]+1;
            


            player.Play();
            this.BtnPlay.Image = Properties.Resources.pause;
            this.toolTip1.SetToolTip(this.BtnPlay, "Pause");

        }

        private void BtnStop_Click(object sender, EventArgs e)
        {
            //returns every thing to normal to start from the beginning
            waveformPainter1.Controls.Clear();
            waveformPainter2.Controls.Clear();
            i = 0;
            stopped = true;
            player.Stop();
            last = false;
            this.SeekingBar1.Value = 0;
            LblCurrentPos.Text="";
            LblDuration.Text = "";
            this.BtnPlay.Image = Properties.Resources.play;
            this.toolTip1.SetToolTip(this.BtnPlay, "Play");
            timer.Stop();

        }

        
        private void BtnNext_Click(object sender, EventArgs e)
        {//play the next song
            
          
            if(last == true&&(repeat == false &&shuffle ==false))
            {   //if it is the last song and it is normal playing show massege and return
                MessageBox.Show("this is the last item in the list");
                
                i = sounds.Count-1;
                
                return;
            }
            //else play the next song

            PlaySong();
        }

        private void BtnPrev_Click(object sender, EventArgs e)
        {
           //play the previous song by decreminting by 2 because i (index) is already incremented by 1 in the playsong function            
            i-=2;
            if (i < 0  && shuffle == false)
            {   // < 0 because it might be the first song so i will be -ve
                MessageBox.Show("this is the first item in the list");
                // return i = 1 because in play song we increment i and play the last incremented i 
                i = 1;

                return;
            }
            else if (i <= -1 &&  shuffle == true)
             {// if shuffle = true thats mean we didn't want to stop at the first song we want to move to random song
                 i=1;
             }
            if(last == true)
            { i++; }
            

            PlaySong();
        }

        private void BtnRepeat_Click(object sender, EventArgs e)
        {
            // makes repeat is true when disabled and viseversa
            if (repeat == false)
            {
                
                repeat = true;
                this.BtnRepeat.Image = Properties.Resources.repeate_on;
                this.toolTip1.SetToolTip(this.BtnRepeat, "Stop Repeat");
            }
            else
            {
                
                repeat = false;
                this.BtnRepeat.Image = Properties.Resources.repeate;
                this.toolTip1.SetToolTip(this.BtnRepeat, "Repeat");
                
            }
        }

        private void BtnShuffle_Click(object sender, EventArgs e)
        {
            // makes shuffle is true when disabled and viseversa
            if (shuffle == false)
            {
                
                shuffle = true;
                this.BtnShuffle.Image = Properties.Resources.shuffle_on;
                this.toolTip1.SetToolTip(this.BtnShuffle, "Stop Shuffle");

            }
            else
            {
                
                shuffle = false;
                this.BtnShuffle.Image = Properties.Resources.shuffle;
                this.toolTip1.SetToolTip(this.BtnShuffle, "Shuffle");
            }
        }

        private void VoulumeBar_Scroll(object sender, EventArgs e)
        {
            //change the current volume to the volume scrollBar value
            if (reader != null)
            {
                reader.Volume = volumeBar.Value;
            }
        }

        

       

        private void SeekingBar1_Scroll(object sender, EventArgs e)
        {
            //make the current possition of playing song = the current possition of the seekingBar
            if (reader != null)
            {
                reader.CurrentTime = TimeSpan.FromSeconds(SeekingBar1.Value);
            }
        }

        private void PlayListView_KeyDown(object sender, KeyEventArgs e)
        {
            //delete the selected index from the listView and the PlayList only when the playerr is stopped
            if (e.KeyCode == Keys.Delete && player.PlaybackState == PlaybackState.Stopped)
            {
                
               
                    sounds.RemoveAt(PlayListView.SelectedIndices[0]);
                    PlayListView.SelectedItems[0].Remove();
                
               
            }
            else if (e.KeyCode == Keys.Delete && player.PlaybackState == PlaybackState.Playing)
            {
                MessageBox.Show("Cannot delete when playlist is playing");
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Menu Exit
            Application.Exit();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Menu Add
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


        private void BtnMute_Click(object sender, EventArgs e)
        {
            
            if (mute == false)
            {   //keep the setting of the last volume and make volume scroll bar = 0 and volume of sound = 0
                currentVol = volumeBar.Value;
                reader.Volume = 0;
                volumeBar.Value = 0;
                mute = true;
                this.BtnMute.Image = Properties.Resources.mute_on;
                this.toolTip1.SetToolTip(this.BtnMute, "UnMute");
            }
            else
            {   // return the value we kept to the volume of the sound and volume scrollBar
                reader.Volume = currentVol;
                volumeBar.Value = currentVol;
                mute = false;
                this.BtnMute.Image = Properties.Resources.mute;
                this.toolTip1.SetToolTip(this.BtnMute, "Mute");
            }
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            //change the gain property in the bands to call the equalizer update to change the sound
            equalizerHandler.Band1 = (float)trackBar1.Value;


        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            equalizerHandler.Band2 = (float)trackBar2.Value;


        }

        private void trackBar3_Scroll(object sender, EventArgs e)
        {
            equalizerHandler.Band3 = (float)trackBar3.Value;

        }

        private void trackBar4_Scroll(object sender, EventArgs e)
        {
            equalizerHandler.Band4 = (float)trackBar4.Value;

        }

        private void trackBar5_Scroll(object sender, EventArgs e)
        {
            equalizerHandler.Band5 = (float)trackBar5.Value;

        }

        private void trackBar6_Scroll(object sender, EventArgs e)
        {
            equalizerHandler.Band6 = (float)trackBar6.Value;

        }

        private void trackBar7_Scroll(object sender, EventArgs e)
        {
            equalizerHandler.Band7 = (float)trackBar7.Value;

        }

        private void trackBar8_Scroll(object sender, EventArgs e)
        {
            equalizerHandler.Band8 = (float)trackBar8.Value;

        }

        

       

        
        

        

        


        
    }
}
    

