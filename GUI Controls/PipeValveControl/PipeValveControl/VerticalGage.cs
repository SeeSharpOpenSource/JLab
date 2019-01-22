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
    public partial class VerticalGage : PipeControlBase
    {
        public VerticalGage()
        {
            InitializeComponent();
            this.Images = imageList;
            HasUpNode = true;
            HasDownNode = true;
            HasLeftNode = false;
            HasRightNode = false;
        }
    }
}
