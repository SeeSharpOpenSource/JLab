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
    public partial class DownsideTPipe : PipeControlBase
    {
        public DownsideTPipe()
        {
            InitializeComponent();
            this.Images = imageList;

            HasUpNode = false;
            HasDownNode = true;
            HasLeftNode = true;
            HasRightNode = true;
        }
    }
}
