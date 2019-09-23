using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
namespace SpritzByMe //ЗАДЕЛАТЬ ИНФО БОРД!! Central letter 
{
    enum State {ON,OFF,PAUSED}

    public partial class Spritz : Form
    {
        WordsPerMinute WPM = new WordsPerMinute();
        State state = State.OFF;
        static int wpmCount = 100;
        static int wordsread;
        static int FS = 10;
        public Spritz()
        {
            InitializeComponent();
            WordsLeftL.Text = InfoBoard.WordCounter(UserText.Text);
            progress.Maximum = Convert.ToInt32(WordsLeftL.Text)+1;
        }
        private void UserText_TextChanged(object sender, EventArgs e)
        {
            WordsLeftL.Text = InfoBoard.WordCounter(UserText.Text);
            progress.Maximum = Convert.ToInt32(WordsLeftL.Text)+1;
        }

        public async void Start_Click(object sender, EventArgs e)
        {
            wordsread = -1; progress.Value = 0;
            state = State.ON; 
            Start.Visible = false;
            Pause.Visible = true;          
            string[] Texted = StringManipulator.TrimSpaces(UserText.Text);
            foreach(string word in Texted)
            {
                progress.Value++;
                await Task.Delay(WPM.currentDelay.Value);
                Spri.Text = word;
                //StringManipulator.AdditionalAwait(word); //Fix
                wordsread++; WordsReadL.Text = Convert.ToString(wordsread);
                if (state == State.OFF) { Spri.Text = ""; wordsread = 0; WordsReadL.Text = ""; progress.Value = 0; break; }
                else if (state == State.PAUSED) while (state == State.PAUSED) await Task.Delay(1000);
            }
            state = State.OFF; 
            Start.Visible = true;
            Pause.Visible = false;
        }

        private void RightB_Click(object sender, EventArgs e)
        {
                if (WPM.currentDelay.Value > 50)
                {
                    WPM.currentDelay = WPM.currentDelay.Next;
                    wpmCount += 50;
                    WPML.Text = Convert.ToString(wpmCount);
                }
        }

        private void LeftB_Click(object sender, EventArgs e)
        {
                if (WPM.currentDelay.Value < 600)
                {
                    WPM.currentDelay = WPM.currentDelay.Previous; 
                    wpmCount -= 50;
                    WPML.Text = Convert.ToString(wpmCount);
                }
        }

        private void Pause_Click(object sender, EventArgs e)
        {
            state = State.PAUSED;
            Pause.Visible = false;
            Continue.Visible = true;
            Stop.Visible = true;
        }

        private void Continue_Click(object sender, EventArgs e)
        {
            state = State.ON;
            Continue.Visible = false;
            Stop.Visible = false;
            Pause.Visible = true; 
        }

        private void Stop_Click(object sender, EventArgs e)
        {
            state = State.OFF; 
            Continue.Visible = false;
            Stop.Visible = false;
            Start.Visible = true;
        }

        private void FontUp_Click(object sender, EventArgs e)
        {
            if (FS<64)
            UserText.Font = new Font("TimesNewRoman", FS++, FontStyle.Regular);
        }

        private void FontDown_Click(object sender, EventArgs e)
        {
            if(FS>1)
            UserText.Font = new Font("TimesNewRoman", FS--, FontStyle.Regular);
        }


        DateTime date1 = new DateTime(0, 0);
        private void timer1_Tick(object sender, EventArgs e)
        {
            date1 = date1.AddSeconds(1);
            TimeReadingL.Text = date1.ToString("mm:ss");
        }
    }
    
}
