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
    public partial class LeftPipeCap : PipeControlBase
    {
        public LeftPipeCap()
        {
            InitializeComponent();
            this.Images = imageList;
            HasUpNode = true;
            HasDownNode = true;
            HasLeftNode = true;
            HasRightNode = true;
        }
    }
}
