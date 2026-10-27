using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge.Video;
using AForge.Video.DirectShow;
using ZXing;

namespace Home_Appliance
{
    public partial class ScannerForm : Form
    {
        public ScannerForm()
        {
            InitializeComponent();
        }
        FilterInfoCollection filter;
        VideoCaptureDevice captureDevice;
        private void ScannerForm_Load(object sender, EventArgs e)
        {
            filter = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach(FilterInfo filterInfo in filter)
                comboBox_camera.Items.Add(filterInfo.Name);
            comboBox_camera.SelectedIndex = 0;
            
        }

        private void Button_scan_Click(object sender, EventArgs e)
        {
            captureDevice = new VideoCaptureDevice(filter[comboBox_camera.SelectedIndex].MonikerString);
            captureDevice.NewFrame += CaptureDevice_NewFrame;
            captureDevice.Start();
            timer1.Start();
        }
        private void CaptureDevice_NewFrame(object sender,NewFrameEventArgs eventArgs)
        {
            PictureBox.Image=(Bitmap)eventArgs.Frame.Clone();
        }

        private void ScannerForm_FormClosing(object sender, FormClosingEventArgs e)
        {

            if (captureDevice.IsRunning)
                captureDevice.Stop();
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (PictureBox.Image != null)
            {
                BarcodeReader barcode = new BarcodeReader();
                Result result = barcode.Decode((Bitmap)PictureBox.Image);
                if (result != null)
                {
                    TextBox_display.Text = result.ToString();
                    timer1.Stop();
                    if (captureDevice.IsRunning)
                        captureDevice.Stop();
                }
            }
        }

        private void Button_go_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("www.google.com");
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            SellingForm selling=new SellingForm();
            selling.Show();
            this.Hide();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
           
                captureDevice.Stop();
                timer1.Stop();
                PictureBox.Image = null;
            
        }

        private void Button_copy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(TextBox_display.Text);
            MessageBox.Show("Copy successful", "Copy Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        
    }
}
