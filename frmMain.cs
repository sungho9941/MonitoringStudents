using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenCvSharp;
using System.Net;
using System.Net.Mail;

namespace MonitoringStudents
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        CvCapture _capture;
        IplImage _src;
        private string _baseDir = AppDomain.CurrentDomain.BaseDirectory;
        private RawData _rawData = new RawData();
        private bool _bDetect = false;
        private int _frameInterval = 5, _frameCount = 0;

        private int _countFrameStudy = 0, _countFrame = 0;
        private float _timerStudy = 0, _preLongestStudyTime = 0, _totalStudyTime = 0;

        private DateTime _reportingTime;

        private void frmMain_Load(object sender, EventArgs e)
        {
            try
            {
                _capture = CvCapture.FromCamera(CaptureDevice.DShow, 0);
                _capture.SetCaptureProperty(CaptureProperty.FrameWidth, 640);
                _capture.SetCaptureProperty(CaptureProperty.FrameHeight, 480);

                timCapture.Enabled = true;
            }
            catch
            {
                timCapture.Enabled = false;
            }
        }

        private void timCapture_Tick(object sender, EventArgs e)
        {
            _src = _capture.QueryFrame();
            picFrame.ImageIpl = _src;

            if(_bDetect && _frameCount++ >= _frameInterval)
            {
                int headY = _rawData.DetectHeadTop(_src);
                picGrayscale.Image = _rawData.Grayscale(_src, Convert.ToInt32(txtHuddle.Text), headY);

                //laMessage.Text = headY.ToString();
                Console.WriteLine(headY + ", " + Convert.ToInt32(txtHuddle.Text));
                _frameCount = 0;

                if(txtHuddle.Text.Length > 0 && headY > Convert.ToInt32(txtHuddle.Text))
                {
                    _countFrame++;

                    laMessage.Text = "경고";
                    //doQuery();
                }
                else
                {
                    _countFrame = 0;
                    _countFrameStudy++;

                    laMessage.Text = "";
                    //doQuery();
                }

                WriteReport();

                SendEmail(_reportingTime);
            }
        }

        private void SendEmail(DateTime reportingTime)
        {
            DateTime now = DateTime.Now;

            if(now.Year == reportingTime.Year && now.Month == reportingTime.Month && now.Day == reportingTime.Day
                && now.Hour == reportingTime.Hour && now.Minute == reportingTime.Minute)
            {
                _reportingTime = new DateTime(DateTime.Today.AddDays(1).Year, DateTime.Today.AddDays(1).Month, DateTime.Today.AddDays(1).Day
                    , _reportingTime.Hour, _reportingTime.Minute, 0);

                Console.WriteLine("리포트가 전송되었습니다. " + _reportingTime + "에 다시 전송됩니다.");

                SmtpClient client = new SmtpClient("smtp.gmail.com", 587);
                client.UseDefaultCredentials = false; // 시스템에 설정된 인증 정보를 사용하지 않는다.
                client.EnableSsl = true;  // SSL을 사용한다.
                client.DeliveryMethod = SmtpDeliveryMethod.Network; // 이걸 하지 않으면 Gmail에 인증을 받지 못한다.
                client.Credentials = new System.Net.NetworkCredential("han460732", "1q2w3e!@");

                MailAddress from = new MailAddress("han460732@gmail.com", "User", System.Text.Encoding.UTF8);
                MailAddress to = new MailAddress("swordlevross@nate.com");

                MailMessage message = new MailMessage(from, to);

                message.Body = "총 공부시간: " + ((float)(_totalStudyTime) / 60).ToString() + "분\n";
                message.Body += "가장 오래 집중한 시간: " + ((float)(_preLongestStudyTime) / 60).ToString() + "분" ;
                message.BodyEncoding = System.Text.Encoding.UTF8;
                message.Subject = this.Text;
                message.SubjectEncoding = System.Text.Encoding.UTF8;

                //try
                {
                    // 동기로 메일을 보낸다.
                    client.Send(message);
                }
                //catch { }

                _totalStudyTime = 0;
                _preLongestStudyTime = 0;
                _timerStudy = 0;
                _countFrameStudy = 0;
                _countFrame = 0;
            }
        }

        private void WriteReport()
        {
            if(_countFrameStudy > 12) // 120 = 1분(60초)
            {
                _timerStudy = (float)((100 * _frameInterval) * _countFrameStudy) / 1000;
                _totalStudyTime += (float)(100 * _frameInterval) / 1000;
            }
            
            if(_countFrame > 12) // 120 = 1분(60초)
            {
                _countFrameStudy = 0;
            }

            _preLongestStudyTime = _preLongestStudyTime < _timerStudy ? _timerStudy : _preLongestStudyTime;

            Console.WriteLine("_timerStudy: " + _timerStudy + "초");
        }

        private void doQuery()
        {
            //  이 곳에 쿼리문을 넣습니다.
        }

        private void btnDetect_Click(object sender, EventArgs e)
        {
            btnDetect.Text = _bDetect ? "Start" : "Stop";
            this.Text = _bDetect ? "Monitoring Students(■)" : "Monitoring Students(▶)";

            int hour = Convert.ToInt32(txtHour.Text);
            int min = Convert.ToInt32(txtMinute.Text);

            _reportingTime = new DateTime(DateTime.Today.Year, DateTime.Today.Month, DateTime.Today.Day, hour, min, 0);

            txtHour.Enabled = false;
            txtMinute.Enabled = false;

            _bDetect = !_bDetect;
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            
        }
    }
}
