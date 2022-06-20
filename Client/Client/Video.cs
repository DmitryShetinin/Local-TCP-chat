using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using AForge.Video;
using AForge.Video.DirectShow;

namespace Client
{
    public partial class Video : Form
    {
   
        Socket _server;
        VideoCaptureDevice videoSource;
        string _nameSelectedUser;
        public Video(string name,ref Socket _server)
        {     
            InitializeComponent();
            _nameSelectedUser = name;
            this._server = _server; 
        }
        [DllImport("kernel32.dll")]

        static extern IntPtr GetConsoleWindow();

        [DllImport("user32.dll")]
        static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);
        //Принимает


        public async void GetData()
        {
            while (true)
            {
                
                byte[] data = new byte[9999];
                _server.Receive(data); 
                using (var ms = new MemoryStream(data))
                {
                    pictureBox1.Image = new Bitmap(ms);
                }
           
            }
        }
        
        //Отправляет 
        public void Send_to()
        {
 
            FilterInfoCollection videoDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            videoSource = new VideoCaptureDevice(videoDevices[0].MonikerString);

            videoSource.NewFrame += VideoSource_NewFrame;
            _server.Send(Encoding.Unicode.GetBytes($"#video|{_nameSelectedUser}"));
            videoSource.Start();    
        }

        private async void VideoSource_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            var bmp = new Bitmap(eventArgs.Frame, 800, 1000);
            while (true)
            {
                try
                {
                    using (var ms = new MemoryStream())
                    {
                        bmp.Save(ms, ImageFormat.Jpeg);
                        var bytes = ms.ToArray();
                        // updClient.Send(bytes, bytes.Length, consumerEndPoint);
                        ChatForm._serverSocket.Send(bytes);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
          
        }

        private async void button1_Click(object sender, EventArgs e)
        {
      
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Video_FormClosing(object sender, FormClosingEventArgs e)
        {
            videoSource.Stop();
        }

        private void Video_Load(object sender, EventArgs e)
        {

        }
    }
}
