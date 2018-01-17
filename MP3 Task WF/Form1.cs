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
        static int[] freqA = { 44100, 48000, 32000, 00001 };//The last frequency is reserved
        static int[] bitrateA = {0,32000,40000,48000,56000,64000,80000,96000,
                                 112000,128000,160000,192000,224000,256000,320000,0};
        static int frequency = 0; // Also known as sample rate


        private void read_button_Click(object sender, EventArgs e)
        {
            string path = textBox1.Text;
            // Get mp3 file as an array of bytes
            byte[] mp3File = File.ReadAllBytes(path);
            int numberofFrames = 0;
            double averageBitrate;

            for (int i = 0; i < mp3File.Length - 1; i++)
            {
                // Locates Header using fram synchroniser plus next few bits
                if (mp3File[i] == 255 && (mp3File[i + 1] == 251 || mp3File[i + 1] == 250))
                {
                    // Third byte of the header contains the data we are after
                    int headerByte3 = mp3File[i + 2];
                    numberofFrames++;
                    // 240 in binary is 0b11110000 use AND operator to ensure only leftmost 4 bits can have a value of 1.
                    // See http://wiki.hydrogenaud.io/images/e/ee/Mp3filestructure.jpg (We want header bits 17-20)
                    // Bitshift right 4 bits to get the index of the bitrate
                    int bitrate = bitrateA[(headerByte3 & 240) >> 4];
                    totalBitRate += bitrate;
                    bitRateCount++;
                    // 12 in binary is 00001100. Use AND operator to ensure only frequency bits can have a value of 1.
                    // Bitshift right 2 bits to get the value of the frequency
                    frequency = freqA[(headerByte3 & 12) >> 2];
                    // 2 in binary is 00000010. Use AND operator to ensure only padding bit can have a value of 1.
                    // Bitshift right 2 bits to get the value of the padding.
                    int padding = (headerByte3 & 2) >> 1;
                    // Formula sourced from http://www.multiweb.cz/twoinches/mp3inside.htm
                    int frameLengthInBytes = (144 * bitrate / frequency) + padding;
                    // Skip to next frame
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
