using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OS_Project
{
    public partial class OS : Form
    {
        private readonly Thread clockThread;
        private readonly Thread OpenTxtFileThread;
        private readonly Thread OpenMusicFileThread;
        private Thread lengthConverterThread;
        private Thread massConverterThread;

        private SoundPlayer soundPlayer;

        private volatile bool isRunning = true;
        private string selectedFileName;
        public OS()
        {
            InitializeComponent();

            OpenTxtFileThread = new Thread(new ThreadStart(OpenTxtFileDialog));
            OpenTxtFileThread.SetApartmentState(ApartmentState.STA);

            OpenMusicFileThread = new Thread(new ThreadStart(OpenMusicFileDialog));
            OpenMusicFileThread.SetApartmentState(ApartmentState.STA);



            clockThread = new Thread(UpdateClock){IsBackground = true};
            clockThread.Start();
        }

        #region clock
        private void UpdateClock()
        {
            while (isRunning)
            {
                string formattedTime = GetCurrentTime();
                UpdateTime(formattedTime);
                Thread.Sleep(100);
            }
        }
        private string GetCurrentTime()
        {
            return DateTime.Now.ToString("HH:mm:ss:f");
        }
        private void UpdateTime(string time)
        {
            if (time_txtbox.InvokeRequired)
            {
                time_txtbox.BeginInvoke((MethodInvoker)delegate { time_txtbox.Text = time; });
            }
            else
            {
                time_txtbox.Text = time;
            }
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            StopClockThread();
        }
        private void StopClockThread()
        {
            isRunning = false;
            clockThread.Join(); // Wait for the thread to finish before closing the form
        }
        #endregion

        #region music
        private void test_Click_1(object sender, EventArgs e)
        {
            OpenMusicFileThread.Start();
        }
        private void OpenMusicFileDialog()
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.Filter = "wav files (*.wav)|*.wav|All files (*.*)|*.*";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                selectedFileName = openFileDialog1.FileName;

                // Update UI on the main thread using Invoke
                this.Invoke((MethodInvoker)delegate
                {
                    mp3Name.Text = selectedFileName;
                });
            }
        }
        private async void Play_btn_Click(object sender, EventArgs e)
        {
            if (selectedFileName != null)
            {
                soundPlayer = new SoundPlayer(selectedFileName);
                await Task.Run(() =>
                {
                    soundPlayer.Play();
                });
            }
        }
        #endregion

        #region txt File
        private void OpenTxtFileDialog()
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                // Update UI on the main thread using Invoke
                this.Invoke((MethodInvoker)async delegate
                {
                    string selectedFilePath = openFileDialog1.FileName;
                    //string[] lines = File.ReadAllLines(selectedFilePath);
                    string[] lines = await Task.Run(() => File.ReadAllLines(selectedFilePath));
                    string fileContents = string.Join(Environment.NewLine, lines);
                    textBox1.Text = fileContents;
                });
            }
        }
        private void fileBtn_Click(object sender, EventArgs e)
        {
            OpenTxtFileThread.Start();
        }

        #endregion

        #region Length convertor
        private void ConvertorFormBtn_Click(object sender, EventArgs e)
        {
            lengthConverterThread = new Thread(OpenLengthConverterForm);
            lengthConverterThread.SetApartmentState(ApartmentState.STA);
            lengthConverterThread.Start();
        }
        private void OpenLengthConverterForm()
        {
            Application.Run(new LengthConverterForm());
        }
        #endregion

        #region mass convertor
        private void OpenMassConverterForm()
        {
            Application.Run(new MassConverterForm());
        }

        private void massConvertorFormBtn_Click(object sender, EventArgs e)
        {
            massConverterThread = new Thread(OpenMassConverterForm);
            massConverterThread.SetApartmentState(ApartmentState.STA);
            massConverterThread.Start();
        }
        #endregion
    }
}