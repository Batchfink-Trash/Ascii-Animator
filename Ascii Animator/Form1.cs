using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Ascii_Animator
{
    public partial class Form1 : Form
    {
        String[] frames = new String[10];
        int playCount = 0;
        bool playing = false;
        string script;

        public Form1()
        {
            InitializeComponent();
            frameSelector.SelectedIndex = 0;
            FpsBox.SelectedIndex = 0;
        }

        //FUNCTIONALITY/FORM METHODS
        private void frameSelector_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                frameEditor.Text = frames[frameSelector.SelectedIndex];
            }
            catch (IndexOutOfRangeException)
            {
                frameSelector.SelectedIndex = 0;
            }
        }

        private void playButton_Click(object sender, EventArgs e)
        {
            if (playing == false)
            {
                Animation animation = new Animation();
                animation.InitAnimation(Convert.ToInt32(FpsBox.SelectedItem), frames);
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
                playing = true;
                playButton.Text = "Stop";
                fpsClock.Start();
            }
            catch (DivideByZeroException)
            {
                MessageBox.Show("Enter an FPS value!", "Error!");
            }
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
            if (currentFrame <= 8)
            {
                frames[currentFrame] = frameEditor.Text;
                frameSelector.SelectedIndex++;
            }
        }

        private void frameBck_Click(object sender, EventArgs e)
        {
            int currentFrame = Convert.ToInt32(frameSelector.SelectedItem) - 1;
            frames[currentFrame] = frameEditor.Text;
            frameSelector.SelectedIndex--;
        }

        //EDIT MENU METHODS
        private void clearFrameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int currentFrame = Convert.ToInt32(frameSelector.SelectedItem) - 1;
            frames[currentFrame] = "";
            frameEditor.Text = frames[currentFrame];
        }//Clear ONE frame

        private void clearAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int currentFrame = Convert.ToInt32(frameSelector.SelectedItem) - 1;
            for (int i = 0; i < 9; i++)
            {
                frames[i] = "";
                frameEditor.Text = frames[i];
            }
            frameEditor.Text = frames[currentFrame];
        }//Clear ALL frames

        //FILE MENU METHODS

        private void exportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog.ShowDialog();
        }//Export menu

        private void saveFileDialog_FileOk(object sender, CancelEventArgs e)
        {
            Animation animation = new Animation();
            animation.InitAnimation(Convert.ToInt32(FpsBox.SelectedItem), frames);
            if (saveFileDialog.FileName != "")
            {
                switch (saveFileDialog.FilterIndex)
                {
                    case 1:
                        script = ExportFile.constructBat(animation);
                        break;
                    case 2:
                        script = ExportFile.constructPy(animation);
                        break;
                }
                string name = saveFileDialog.FileName;
                File.WriteAllText(name, script);
                this.Text = "Ascii Animator - " + name;
            }
        }//construct and export .bat/.py

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveDialog.ShowDialog();
        }//Save menu

        private void saveXmlDialog_FileOk(object sender, CancelEventArgs e)
        {
            Animation animation = new Animation();
            animation.InitAnimation(Convert.ToInt32(FpsBox.SelectedItem), frames);
            if (saveDialog.FileName != "")
            {
                string name = saveDialog.FileName;
                string xmlObject = ExportFile.save(animation);
                File.WriteAllText(name, xmlObject);
                this.Text = "Ascii Animator - " + name;
            }
        }//Serialize and export xml file

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openDialog.ShowDialog();
        }//Open menu

        private void openDialog_FileOk(object sender, CancelEventArgs e)
        {
            int currentFrame = Convert.ToInt32(frameSelector.SelectedItem) - 1;
            if (openDialog.FileName != "")
            {
                string name = openDialog.FileName;
                Animation a = ExportFile.open(name);
                frames = a.frames;
                frameEditor.Text = frames[currentFrame];
                this.Text = "Ascii Animator - " + name;
            }
        }//Deserialize and open

        //ABOUT METHODS
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var aboutBox = new AboutBox();
            aboutBox.Show();
        }

        private void openHelpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var help = new Help();
            help.Show();
        }

    }
}
