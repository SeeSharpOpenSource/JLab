using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PipeValveControl
{
    public partial class PipeControlBase : UserControl
    {
        public PipeControlBase()
        {
            InitializeComponent();
            InnerPipeWidth = MaxPipeWidth;
            _status = false;
            _alert = false;
        }

        private double _widthToHeightRatio = 1;

        private ImageList _images;
        protected ImageList Images
        {
            get { return _images; }
            set
            {
                _images = value;
                this.Height = _images.ImageSize.Height;
                this.Width = _images.ImageSize.Width;
                _widthToHeightRatio = (double) this.Width/this.Height;
                this.Resize += ResizeFunction;
                RefreshPipeImage();
            }
        }

        public double UpNodePosition { get; protected set; }
        public double DownNodePosition { get; protected set; }
        public double LeftNodePosition { get; protected set; }
        public double RightNodePosition { get; protected set; }

        public bool HasUpNode { get; protected set; }
        public bool HasDownNode { get; protected set; }
        public bool HasLeftNode { get; protected set; }
        public bool HasRightNode { get; protected set; }

        public PipeControlBase UpNode { get; set; }
        public PipeControlBase DownNode { get; set; }
        public PipeControlBase LeftNode { get; set; }
        public PipeControlBase RightNode { get; set; }

        protected const int MaxPipeWidth = 10;
        protected int InnerPipeWidth;
        protected bool IsInternalResize = false;
        public int PipeWidth
        {
            get { return InnerPipeWidth; }
            set
            {
                if (value == InnerPipeWidth || value > MaxPipeWidth || value < 1)
                {
                    return;
                }
                InnerPipeWidth = value;
                if (null != Images)
                {
                    int width = (int) Math.Round((double)InnerPipeWidth*Images.ImageSize.Width/MaxPipeWidth);
                    int height = (int) Math.Round((double)InnerPipeWidth *Images.ImageSize.Height/MaxPipeWidth);
                    IsInternalResize = true;
                    this.Width = width;
                    this.Height = height;
                    IsInternalResize = false;
                }
            }
        }

        private bool _status;
        public bool Status
        {
            get { return _status; }
            set
            {
                if (_status == value)
                {
                    return;
                }
                _status = value;
                RefreshPipeImage();
            }
        }

        private bool _alert;
        public bool Alert
        {
            get { return _alert; }
            set
            {
                if (value == _alert)
                {
                    return;
                }
                _alert = value;
                RefreshPipeImage();
            }
        }

        private void RefreshPipeImage()
        {
            const int offImageIndex = 0;
            const int onImageIndex = 1;
            const int alertImageIndex = 2;
            if (null == _images)
            {
                return;
            }
            if (_alert)
            {
                pictureBox_pipeView.Image = _images.Images[alertImageIndex];
            }
            else
            {
                pictureBox_pipeView.Image = _images.Images[_status ? onImageIndex : offImageIndex];
            }
        }

        protected virtual void ResizeFunction(object sender, EventArgs eventArgs)
        {

            if (IsInternalResize)
            {
                return;
            }
            int size = Math.Max((int) (this.Size.Height*_widthToHeightRatio), this.Size.Width);
            IsInternalResize = true;
            this.Height = (int)(size / _widthToHeightRatio);
            this.Width = size;
            IsInternalResize = false;
            this.InnerPipeWidth = (int) Math.Round(MaxPipeWidth*(double)this.Width / Images.ImageSize.Width);
        }

        #region 自动停靠功能

        // TODO 暂时关闭自动停靠功能
        private void PipeControlBase_Move(object sender, EventArgs e)
        {

            return;
            PipeControlBase controlBase = sender as PipeControlBase;
            ControlCollection controls = this.Parent.Controls;
            bool alreadyAttached = false;
            foreach (Control control in controls)
            {
                if (!(control is PipeControlBase))
                {
                    continue;
                }


            }
            if (!alreadyAttached)
            {
                return;
            }
            ReconnectNearPipeControl();
        }

        public bool AttachToNearPipeControl(PipeControlBase pipeControl)
        {
            throw new NotImplementedException();
        }

        public void ReconnectNearPipeControl()
        {

        }


        const int NearPipePixel = 5;

        public bool IsControlInUpNearPixel(PipeControlBase pipeControl, int nearPixel)
        {
            if (Math.Abs(this.PipeWidth - pipeControl.PipeWidth) > 1E-100) return false;

            int yOffset = pipeControl.Location.Y + pipeControl.Height - this.Location.Y;
            if (Math.Abs(yOffset) > nearPixel)
            {
                return false;
            }
            int xOffset = (int) (pipeControl.Location.X + pipeControl.UpNodePosition*pipeControl.Size.Width -
                                 (UpNodePosition*this.Size.Width + this.Location.X));
            return Math.Abs(xOffset) <= nearPixel;
        }

        #endregion

    }
}
