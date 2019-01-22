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
    public partial class VerticalPipe : PipeControlBase
    {
        public VerticalPipe()
        {
            InitializeComponent();
            this.Images = imageList;

            HasUpNode = true;
            HasDownNode = true;
            HasLeftNode = false;
            HasRightNode = false;
        }

        protected override void ResizeFunction(object sender, EventArgs e)
        {
            if (IsInternalResize)
            {
                return;
            }
            if (null != Images)
            {
                this.InnerPipeWidth = (int)Math.Round(MaxPipeWidth*(double)this.Width / Images.ImageSize.Width);
            }
        }
    }
}
