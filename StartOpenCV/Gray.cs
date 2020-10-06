using OpenCvSharp;
using System;
using System.Drawing;

namespace StartOpenCV
{
    class Gray : IDisposable
    {
        IplImage subGray;

        #region # IDisposable 구현
        public void Dispose()
        {
            if (subGray != null) Cv.ReleaseImage(subGray);
        }

        #endregion

        public IplImage GrayProcess(IplImage src)
        {
            subGray = new IplImage(src.Size, BitDepth.U8, 1); // ? 채널 1개짜리 메모리 확보
            Cv.CvtColor(src, subGray, ColorConversion.BgrToGray); // ? Color를 Gray로 변환

            return subGray;
        }

        public IplImage ThresholdProcess(IplImage src)
        {
            subGray = new IplImage(src.Size, BitDepth.U8, 1);
            Cv.CvtColor(src, subGray, ColorConversion.BgrToGray);
            Cv.Smooth(subGray, subGray, SmoothType.Gaussian, 5); // ? 가우시안 스무스 주기
            Cv.Threshold(subGray, subGray, 120, 255, ThresholdType.Binary); // ? 120은 기준이 될 임계치

            return subGray;
        }

        public IplImage BuildCanny(IplImage src)
        {
            subGray = new IplImage(src.Size, BitDepth.U8, 1);
            Cv.CvtColor(src, subGray, ColorConversion.BgrToGray);
            Cv.Canny(subGray, subGray, 80, 255);
            return subGray;
        }

        public IplImage BuildSobel(IplImage src)
        {
            subGray = new IplImage(src.Size, BitDepth.U8, 1);
            Cv.CvtColor(src, subGray, ColorConversion.BgrToGray);
            Cv.Sobel(subGray, subGray, 1, 0, ApertureSize.Size3);
            return subGray;
        }

        public IplImage BuildLaplace(IplImage src)
        {
            subGray = new IplImage(src.Size, BitDepth.U8, 1);
            
            using (IplImage temp = new IplImage(src.Size, BitDepth.U8, 1))
            using (IplImage gTemp = new IplImage(src.Size, BitDepth.U8, 1))
            {
                Cv.CvtColor(src, gTemp, ColorConversion.BgrToGray);
                Cv.Laplace(gTemp, temp);
                Cv.ConvertScaleAbs(temp, subGray);
                return subGray;
            }
        }

    }
}
