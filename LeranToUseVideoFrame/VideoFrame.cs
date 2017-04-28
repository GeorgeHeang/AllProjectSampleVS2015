using OpenCvSharp;

namespace LeranToUseVideoFrame
{
    public class VideoFrame
    {
        public VideoFrameMetadata Metadata { get; }
        public Mat Image { get; }
        public object UserData { get; set; } = null;

        public VideoFrame(Mat image, VideoFrameMetadata metadata)
        {
            Image = image;
            Metadata = metadata;
        }
    }
}
