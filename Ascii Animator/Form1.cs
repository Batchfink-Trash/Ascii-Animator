using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ascii_Animator
{
    public partial class Form1 : Form
    {
        String[] frames = new String[10];
        int playCount = 0;
        bool playing = false;

        public Form1()
        {
            InitializeComponent();
            frameSelector.SelectedIndex = 0;
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("A program for making ascii animations, made by Batchfink. © 2015", "About");
        }

        private void frameSelector_SelectedIndexChanged(object sender, EventArgs e)
        {
            frameEditor.Text = "";
        }

        private void playButton_Click(object sender, EventArgs e)
        {
            if (playing == false)
            {
                Animation animation = new Animation(Convert.ToInt32(FpsBox.SelectedItem), frames);
                play(animation);
            }
            else
            {
                fpsClock.Stop();
                playCount = 0;
                playLbl.Text = "";
                playButton.Text = "Play";
                playing = false;
            }
        }

        private void frameSelector_MouseClick(object sender, MouseEventArgs e)
        {
            int currentFrame = Convert.ToInt32(frameSelector.SelectedItem) - 1;
            frames[currentFrame] = frameEditor.Text;
        }

        private void play(Animation animation)
        {
            try
            {
                fpsClock.Interval = 1000 / animation.fps;
            }
            catch (DivideByZeroException)
            {
                MessageBox.Show("Enter an FPS value!", "Error!");
            }
            playing = true;
            playButton.Text = "Stop";
            fpsClock.Start();
        }

        private void fpsClock_Tick(object sender, EventArgs e)
        {
            playLbl.Text = "";
            playLbl.Text = frames[playCount];
            if (playCount == 9)
            {
                playCount = 0;
            }
            else
            {
                playCount++;
            }
        }

        private void frameFwd_Click(object sender, EventArgs e)
        {

            int currentFrame = Convert.ToInt32(frameSelector.SelectedItem) - 1;
            frames[currentFrame] = frameEditor.Text;
            frameSelector.SelectedIndex++;
        }

        private void frameBck_Click(object sender, EventArgs e)
        {
            int currentFrame = Convert.ToInt32(frameSelector.SelectedItem) - 1;
            frames[currentFrame] = frameEditor.Text;
            frameSelector.SelectedIndex--;
        }
    }
}
