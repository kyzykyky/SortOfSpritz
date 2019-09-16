using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
namespace SpritzByMe //ЗАДЕЛАТЬ ИНФО БОРД СРОЧНА!! Central letter по желанию
{
    enum State {ON,OFF,PAUSED}

    public partial class Spritz : Form
    {
        WordsPerMinute WPM = new WordsPerMinute();
        
        public Spritz()
        {
            InitializeComponent();
            WordsLeftL.Text = InfoBoard.WordCounter(UserText.Text);
        }
        State state = State.OFF;
        static int wpmCount = 100;
        static int wordsread = 0;
        private void UserText_TextChanged(object sender, EventArgs e)
        {
            WordsLeftL.Text = InfoBoard.WordCounter(UserText.Text);
        }

        public async void Start_Click(object sender, EventArgs e)
        {
            
            state = State.ON;
            Start.Visible = false;
            Pause.Visible = true;          
            string[] Texted = StringInfo.TrimSpaces(UserText.Text);
            foreach(string word in Texted)
            {
                await Task.Delay(WPM.currentDelay.Value);
                Spri.Text = word;
                WPML.Text = Convert.ToString(wpmCount);
                wordsread++; WordsReadL.Text = Convert.ToString(wordsread);
                if (state == State.OFF) { Spri.Text = ""; wordsread = 0; WordsReadL.Text = ""; break; }
                else if (state == State.PAUSED) while (state == State.PAUSED) await Task.Delay(1000);
            }
            state = State.OFF;
            Start.Visible = true;
            Pause.Visible = false;
        }

        private void RightB_Click(object sender, EventArgs e)
        {
            if (state == State.ON)
            {
                if (WPM.currentDelay.Value > 50)
                {
                    WPM.currentDelay = WPM.currentDelay.Next;
                    wpmCount += 50;
                }
            }
            else { } //todo
        }

        private void LeftB_Click(object sender, EventArgs e)
        {
            if (state == State.ON)
            {
                if (WPM.currentDelay.Value < 600)
                {
                    WPM.currentDelay = WPM.currentDelay.Previous; 
                    wpmCount -= 50;
                }
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

        
    }
    
}
