using System;
using System.Drawing;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.Structure;

namespace VideoCapture
{
    public partial class Form1 : Form
    {
        private Emgu.CV.VideoCapture capture;

        public Form1()
        {
            InitializeComponent();
        }

        private void StartCaptureButton(object sender, EventArgs e)
        {
            start_capture.Enabled = false;
            stop_capture.Enabled = true;
            if (capture == null)
            {
                capture = new Emgu.CV.VideoCapture(0);
            }
            capture.ImageGrabbed += ImageReceived;
            capture.Start();
        }

        private void ImageReceived(object sender, EventArgs e)
        {
            try
            {
                Mat frame = new Mat();      //Matrix to save the picture
                capture.Retrieve(frame, 0); //retrieve the picture to the matrinx
                Image<Bgr, byte> image = frame.ToImage<Bgr, byte>();
                var imgBytes = image.ToJpegData();
                var img = (Bitmap)((new ImageConverter().ConvertFrom(imgBytes)));
                pictureBox1.Image = img;
 
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void StopCaptureButton(object sender, EventArgs e)
        {
            capture.ImageGrabbed -= ImageReceived;
            if(capture != null)
            {
                capture.Stop();
            }
            stop_capture.Enabled = false;
            start_capture.Enabled = true;
        }

        private void capture_frame_Click(object sender, EventArgs e)
        {
            capturedFrame.Image = pictureBox1.Image;
        }
    }
}
