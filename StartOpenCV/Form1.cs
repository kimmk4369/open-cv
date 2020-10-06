using OpenCvSharp;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using OpenCvSharp.Extensions;
using OpenCvSharp.CPlusPlus;

namespace StartOpenCV
{
    public partial class Form1 : Form
    {
        IplImage src, src2, result;
        CvCapture cap;


        public Form1()
        {
            InitializeComponent();

            //src2 = new IplImage(@"F:\workspace\C#\StartOpenCV_200810\SampleData\a.jpg", LoadMode.AnyColor);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            // ? 리소스 해제
            if (src != null) Cv.ReleaseImage(src);
            if (result != null) Cv.ReleaseImage(result);
            if (timer1.Enabled) timer1.Enabled = false;
            if (cap != null) cap.Dispose();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            src = cap.QueryFrame();
            pictureBoxIpl1.ImageIpl = src;

            if (src == null)
            {
                timer1.Stop();
            }
            else
            {
                // ? 결과에는 그레이 처리
                //using (Gray g = new Gray())
                //{
                //    pictureBoxIpl2.ImageIpl = g.GrayProcess(src);
                //}

                Mat img = new Mat(src);
                Mat img2 = new Mat(src2);

                Mat converted = new Mat();
                Cv2.CvtColor(img, converted, ColorConversion.BgrToHsv);
                Mat green = converted.Clone();

                Cv2.InRange(converted, new Scalar(70 - 10, 30, 30), new Scalar(70 + 10, 255, 255), green); //잘되는거
                //Cv2.InRange(converted, new Scalar(70 - 10, 3, 3), new Scalar(70 + 10, 255, 255), green);

                Mat dst = new Mat();
                Mat dst1 = new Mat();
                Mat inverted = new Mat();

                Cv2.BitwiseNot(green, inverted);
                Cv2.BitwiseAnd(img, img, dst, inverted);
                Cv2.BitwiseOr(dst, img2, dst1, green);
                Cv2.BitwiseOr(dst, dst1, dst1);

                //pictureBoxIpl2.ImageIpl = dst1.ToIplImage();
                pictureBoxIpl2.ImageIpl = dst1.ToIplImage();
            }
        }

        #region # PictureBox 클릭

        private void pictureBoxIpl1_Click(object sender, EventArgs e)
        {
            // ? 원본그림 클릭 시, 새창을 띄워 큰 그림으로 보여줌
            if (pictureBoxIpl1.ImageIpl == null) return;

            using (CvWindow w = new CvWindow("원본그림"))
            {
                w.Image = src;
                Cv.WaitKey(0);
            }
        }

        private void pictureBoxIpl2_Click(object sender, EventArgs e)
        {
            // ? 결과그림 클릭 시, 새창을 띄워 큰 그림으로 보여줌
            if (pictureBoxIpl2.ImageIpl == null) return;

            using (CvWindow w = new CvWindow("결과그림"))
            {
                w.Image = result;
                Cv.WaitKey(0);
            }
        }

        #endregion

        #region # 파일 메뉴 하위
        private void 그림읽기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                LoadImage(openFileDialog1.FileName);
            }
        }

        void LoadImage(string fileName)
        {
            src = new IplImage(fileName, LoadMode.AnyColor);
            src2 = new IplImage(fileName, LoadMode.AnyColor);
            pictureBoxIpl1.ImageIpl = src;
            pictureBoxIpl2.ImageIpl = null;
        }

        #endregion

        #region # 필터 메뉴 하위
        private void 그레이ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (Gray g = new Gray())
            using (IplImage temp = g.GrayProcess(src))
            {
                result = temp.Clone();
            }

            pictureBoxIpl2.ImageIpl = result;
        }

        private void 이진화ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (Gray g = new Gray())
            using (IplImage temp = g.ThresholdProcess(src))
            {
                result = temp.Clone();
            }

            pictureBoxIpl2.ImageIpl = result;
        }

        private void 캐니엣지ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (Gray g = new Gray())
            using (IplImage temp = g.BuildCanny(src))
            {
                result = temp.Clone();
            }

            pictureBoxIpl2.ImageIpl = result;
        }

        private void 소벨엣지ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (Gray g = new Gray())
            using (IplImage temp = g.BuildSobel(src))
            {
                result = temp.Clone();
            }

            pictureBoxIpl2.ImageIpl = result;
        }

        private void 라플레스엣지ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (Gray g = new Gray())
            using (IplImage temp = g.BuildLaplace(src))
            {
                result = temp.Clone();
            }

            pictureBoxIpl2.ImageIpl = result;
        }
        #endregion

        private void btn동영상PLAY_Click(object sender, EventArgs e)
        {
            if (src2 == null)
            {
                MessageBox.Show("배경이 될 그림을 먼저 선택하세요.");
                return;
            }

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                cap = CvCapture.FromFile(openFileDialog1.FileName);
                timer1.Interval = (int)(1000 / cap.Fps);
                timer1.Enabled = true;
            }
        }

        private void btn동영상STOP_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            if (cap != null) cap.Dispose();
        }

        private void btn웹캠시작_Click(object sender, EventArgs e)
        {
            cap = CvCapture.FromCamera(CaptureDevice.DShow, 0); // ? 첫번째 입력장치에서 읽어오기
            timer1.Interval = 33; // ? 초당 30프레임?
            timer1.Enabled = true;
        }

        private void btn웹캠정지_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            if (cap != null) cap.Dispose();
        }

        private void btn배경제거_Click(object sender, EventArgs e)
        {
            pictureBoxIpl2.Image = RemoveBackground(src.ToBitmap());
        }

        Bitmap RemoveBackground(Bitmap input)
        {
            Bitmap clone = new Bitmap(input.Width, input.Height, System.Drawing.Imaging.PixelFormat.Format32bppArgb);
            {
                using (input)
                using (Graphics gr = Graphics.FromImage(clone))
                {
                    gr.DrawImage(input, new Rectangle(0, 0, clone.Width, clone.Height));
                }

                var data = clone.LockBits(new Rectangle(0, 0, clone.Width, clone.Height), System.Drawing.Imaging.ImageLockMode.ReadWrite, clone.PixelFormat);

                var bytes = Math.Abs(data.Stride) * clone.Height;
                byte[] rgba = new byte[bytes];
                System.Runtime.InteropServices.Marshal.Copy(data.Scan0, rgba, 0, bytes);

                var pixels = Enumerable.Range(0, rgba.Length / 4).Select(x => new
                {
                    B = rgba[x * 4],
                    G = rgba[(x * 4) + 1],
                    R = rgba[(x * 4) + 2],
                    A = rgba[(x * 4) + 3],
                    MakeTransparent = new Action(() => rgba[(x * 4) + 3] = 0)
                });

                pixels.AsParallel().ForAll(p =>
               {
                   byte max = Math.Max(Math.Max(p.R, p.G), p.B);
                   byte min = Math.Min(Math.Min(p.R, p.G), p.B);

                   if (p.G != min && (p.G == max || max - p.G < 7) && (max - min) > 20)
                   {
                       p.MakeTransparent();
                   }
               });

                System.Runtime.InteropServices.Marshal.Copy(rgba, 0, data.Scan0, bytes);
                clone.UnlockBits(data);
                
            }

            return clone;
        }
    }
}
