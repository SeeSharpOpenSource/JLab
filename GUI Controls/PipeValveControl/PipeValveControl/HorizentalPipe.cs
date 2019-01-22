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
    public partial class HorizentalPipe : PipeControlBase
    {
        public HorizentalPipe()
        {
            InitializeComponent();
            this.Images = imageList;
            HasUpNode = false;
            HasDownNode = false;
            HasLeftNode = true;
            HasRightNode = true;
        }

        protected override void ResizeFunction(object sender, EventArgs e)
        {
            if (IsInternalResize)
            {
                return;
            }
            if (null != Images)
            {
                this.InnerPipeWidth = (int)Math.Round(MaxPipeWidth*(double)this.Height / Images.ImageSize.Height);
            }
        }
    }
}
