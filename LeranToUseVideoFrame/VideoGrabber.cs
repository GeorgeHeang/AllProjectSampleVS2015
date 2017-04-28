using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using OpenCvSharp;

namespace LeranToUseVideoFrame
{
    public class VideoGrabber<AnalysisResultType>
    {
        //Fields
        protected BlockingCollection<Task<NewResultEventArgs>> _analysisTaskQueue = null;
        protected double _framRate = 0;
        protected Timer _timer = null;
        protected Predicate<VideoFrame> _analysisPredicate = null;
        protected VideoCapture _videoCapture = null;
        protected AutoResetEvent _resetEvent = new AutoResetEvent(false);
        protected bool _stopping = false;
        protected Task _producerTask = null;
        protected Task _consumerTask = null;
        protected bool _resetTrigger = true;
        protected int _numCamera = -1;
        protected int _currentCameraIndex = -1;
        protected SemaphoreSlim _timerMutex = new SemaphoreSlim(1);


        //Types
        public class NewFrameEventArgs : EventArgs
        {
            public VideoFrame Frame
            {
                get;
            }
            public NewFrameEventArgs(VideoFrame frame)
            {
                Frame = frame;
            }
        }

        public class NewResultEventArgs : EventArgs
        {
            public VideoFrame Frame
            {
                get;
            }
            public AnalysisResultType Analysis { get; set; } = default(AnalysisResultType);
            public bool TimeOut { get; set; } = false;
            public Exception Exception { get; set; } = null;
            public NewResultEventArgs(VideoFrame frame)
            {
                Frame = frame;
            }
        }

        //Properties
        public Func<VideoFrame, Task<AnalysisResultType>> AnalysisFunction { get; set; } = null;
        public TimeSpan AnalysisTimeOut { get; set; } = TimeSpan.FromMilliseconds(5000);
        public bool IsRunning
        {
            get
            {
                return _analysisTaskQueue != null;
            }
        }
        public double FrameRate
        {
            get
            {
                return _framRate;
            }
            set
            {
                _framRate = value;
                if ( _timer != null )
                {
                    _timer.Change(TimeSpan.Zero, TimeSpan.FromSeconds(1.0 / _framRate));
                }
            }
        }
        public int Width { get; protected set; }
        public int Height { get; protected set; }

        //Events
        public event EventHandler ProcessingStarting;
        public event EventHandler ProcessingStarted;
        public event EventHandler ProcessingStopping;
        public event EventHandler ProcessingStopped;
        public event EventHandler<NewFrameEventArgs> NewFrameProvided;
        public event EventHandler<NewResultEventArgs> NewResultAvailable;

        //Methods

        public VideoGrabber()
        {

        }
        //Methods to raise event
        protected void OnProcessingStarting()
        {
            ProcessingStarting?.Invoke(this, null);
        }
        protected void OnProcessingStarted()
        {
            ProcessingStarted?.Invoke(this, null);
        }
        protected void OnProcessingStopping()
        {
            ProcessingStopping?.Invoke(this, null);
        }
        protected void OnProccessingStopped()
        {
            ProcessingStopped?.Invoke(this, null);
        }
        protected void OnNewFrameProvided(VideoFrame frame)
        {
            NewFrameProvided?.Invoke(this, new NewFrameEventArgs(frame));
        }
        protected void OnNewResultAvailable(NewResultEventArgs args)
        {
            NewResultAvailable?.Invoke(this, args);
        }

        //Class methods 

        protected void LogMessage(string format, params object[] args)
        {
            ConcurrentLogger.WriteLine(String.Format(format, args));
        }
    }
}
