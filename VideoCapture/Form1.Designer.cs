
namespace VideoCapture
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.start_capture = new System.Windows.Forms.Button();
            this.stop_capture = new System.Windows.Forms.Button();
            this.capture_frame = new System.Windows.Forms.Button();
            this.capturedFrame = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.capturedFrame)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 78);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(387, 412);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // start_capture
            // 
            this.start_capture.Location = new System.Drawing.Point(12, 20);
            this.start_capture.Name = "start_capture";
            this.start_capture.Size = new System.Drawing.Size(116, 23);
            this.start_capture.TabIndex = 1;
            this.start_capture.Text = "Start Capture";
            this.start_capture.UseVisualStyleBackColor = true;
            this.start_capture.Click += new System.EventHandler(this.StartCaptureButton);
            // 
            // stop_capture
            // 
            this.stop_capture.Location = new System.Drawing.Point(12, 49);
            this.stop_capture.Name = "stop_capture";
            this.stop_capture.Size = new System.Drawing.Size(116, 23);
            this.stop_capture.TabIndex = 2;
            this.stop_capture.Text = "Stop Capture";
            this.stop_capture.UseVisualStyleBackColor = true;
            this.stop_capture.Click += new System.EventHandler(this.StopCaptureButton);
            // 
            // capture_frame
            // 
            this.capture_frame.Location = new System.Drawing.Point(134, 20);
            this.capture_frame.Name = "capture_frame";
            this.capture_frame.Size = new System.Drawing.Size(116, 23);
            this.capture_frame.TabIndex = 3;
            this.capture_frame.Text = "Capture Frame";
            this.capture_frame.UseVisualStyleBackColor = true;
            this.capture_frame.Click += new System.EventHandler(this.capture_frame_Click);
            // 
            // capturedFrame
            // 
            this.capturedFrame.Location = new System.Drawing.Point(435, 78);
            this.capturedFrame.Name = "capturedFrame";
            this.capturedFrame.Size = new System.Drawing.Size(408, 412);
            this.capturedFrame.TabIndex = 4;
            this.capturedFrame.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(855, 514);
            this.Controls.Add(this.capturedFrame);
            this.Controls.Add(this.capture_frame);
            this.Controls.Add(this.stop_capture);
            this.Controls.Add(this.start_capture);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.capturedFrame)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button start_capture;
        private System.Windows.Forms.Button stop_capture;
        private System.Windows.Forms.Button capture_frame;
        private System.Windows.Forms.PictureBox capturedFrame;
    }
}

