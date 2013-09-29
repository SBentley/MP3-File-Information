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

namespace MP3_Task_WF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void browse_button_Click(object sender, EventArgs e)
        {
            OpenFileDialog fd = new OpenFileDialog();
            fd.Filter = "MP3 Files | *.mp3;";
            fd.ShowDialog();
            textBox1.Text = fd.FileName;
        }
        
        static long bitRateCount = 0, totalBitRate = 0;
        static int[] freqA = { 44100, 48000, 32000, 00001 };
        static int[] bitrateA = {0,32000,40000,48000,56000,64000,80000,96000,
                                 112000,128000,160000,192000,224000,256000,320000,0};
        static int frequency = 0;

        private void read_button_Click(object sender, EventArgs e)
        {
            string path = textBox1.Text;
            byte[] mp3File = File.ReadAllBytes(path);
            int numberofFrames = 0;
            double averageBitrate;
            for (int i = 0; i < mp3File.Length - 1; i++)
            {
                if (mp3File[i] == 255 && (mp3File[i + 1] == 251 || mp3File[i + 1] == 250))//Locates Header
                {
                    int headerByte2 = mp3File[i + 2];
                    numberofFrames++;
                    int bitrate = bitrateA[(headerByte2 & 240) >> 4];
                    totalBitRate += bitrate;
                    bitRateCount++;
                    frequency = freqA[(headerByte2 & 12) >> 2];
                    int padding = (headerByte2 & 2) >> 1;
                    int frameLengthInBytes = (144 * bitrate / frequency) + padding;
                    i += frameLengthInBytes - 1;
                }
            }
            frames_label.Text = "Frames: " + numberofFrames;
            frequency_label.Text = "Frequency: " + frequency;
            averageBitrate = totalBitRate / bitRateCount;
            bitrate_label.Text = "Bitrate: " + averageBitrate;
            bitRateCount = 0;
            totalBitRate = 0;
        }

    }
}
