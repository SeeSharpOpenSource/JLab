using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace CustomControls
{
    public partial class NumericBox : UserControl
    {
        private bool _innerOperation;
        private const int _heightOffset = 2;
        private const int _widthOffset = 1;

        private SolidBrush _buttonBrush;
        private Point[] _trianglePoints = new Point[3];

        public NumericBox()
        {
            _innerOperation = true;
            InitializeComponent();
            _innerOperation = false;
            this._innerOperation = false;
            this._buttonBrush = new SolidBrush(Color.DimGray);
            for (int i = 0; i < _trianglePoints.Length; i++)
            {
                _trianglePoints[i] = new Point();
            }
            this._value = 0;
            this._decimalPlace = 2;
            this._minimum = 0;
            this._maximum = 1000;
            this._textFormat = "F2";
            this.Increment = 1;
            ShowValue();
        }

        public Font TextFont
        {
            get { return textBox_value.Font; }
            set { textBox_value.Font = value; }
        }

        public Color TriangleColor
        {
            get { return _buttonBrush.Color; }
            set
            {
                if (value == _buttonBrush.Color)
                {
                    return;
                }
                _buttonBrush.Color = value;
                button_up.Invalidate();
                button_down.Invalidate();
            }
        }

        public Color ButtonBorderColor
        {
            get { return button_up.FlatAppearance.BorderColor; }
            set
            {
                button_up.FlatAppearance.BorderColor = value; 
                button_down.FlatAppearance.BorderColor = value; 
            }
        }

        private double _value;
        public double Value
        {
            get { return _value; }
            set
            {
                if (value < _minimum || value > _maximum)
                {
                    return;
                }
                this._value = value;
                ShowValue();
            }
        }

        private double _maximum;

        public double Maximum
        {
            get { return _maximum; }
            set
            {
                if (value <= _minimum)
                {
                    return;
                }
                this._maximum = value;
                if (Value > _maximum)
                {
                    this.Value = _maximum;
                }
            }
        }

        private double _minimum;

        public double Minimum
        {
            get { return _minimum; }
            set
            {
                if (value >= Maximum)
                {
                    return;
                }
                this._minimum = value;
                if (Value < _minimum)
                {
                    this.Value = _minimum;
                }
            }
        }

        public double Increment { get; set; }

        private string _textFormat;
        private int _decimalPlace;
        public int DecimalPlace
        {
            get { return _decimalPlace; }
            set
            {
                if (value == _decimalPlace)
                {
                    return;
                }
                this._decimalPlace = value;
                _textFormat = $"F{_decimalPlace}";
            }
        }

        public HorizontalAlignment TextAlign
        {
            get { return textBox_value.TextAlign; }
            set { textBox_value.TextAlign = value; }
        }
        
        private void NumericBox_ForeColorChanged(object sender, EventArgs e)
        {
            this.textBox_value.ForeColor = this.ForeColor;
        }

        private void NumericBox_SizeChanged(object sender, EventArgs e)
        {
            RefreshControlSize();
        }

        private void textBox_value_SizeChanged(object sender, EventArgs e)
        {
            RefreshControlSize();
        }

        private void RefreshControlSize()
        {
            if (_innerOperation)
            {
                return;
            }
            if (this.Height != textBox_value.Height + _heightOffset)
            {
                _innerOperation = true;
                this.Height = textBox_value.Height + _heightOffset;
                _innerOperation = false;
            }

            int extraSpace = (1 == this.Height%2) ? 3 : 2;
            int buttonHeight = (this.Height - extraSpace) /2;
            int buttonWidth = buttonHeight*2;
            int buttonLocationX = this.Width - _widthOffset - buttonWidth;
            int buttonDownY = (1 == (this.Height - _heightOffset)%2)
                ? 2 + buttonHeight
                : 1 + buttonHeight;

            _innerOperation = true;

            textBox_value.Width = this.Width - 3*_widthOffset - buttonWidth;
            button_up.Location = new Point(buttonLocationX, 1);
            button_down.Location = new Point(buttonLocationX, buttonDownY);
            button_up.Width = buttonWidth;
            button_up.Height = buttonHeight;
            button_down.Width = buttonWidth;
            button_down.Height = buttonHeight;

            _innerOperation = false;
        }

        private void button_up_Paint(object sender, PaintEventArgs e)
        {
            const int yOffset = 3;
            int startY = yOffset - 1;
            int endY = button_up.Height - yOffset;

            int xOffset = endY - startY;

            int middleX = button_up.Width / 2;
            int startX = middleX - xOffset;
            int endX = middleX + xOffset;

            _trianglePoints[0].X = middleX;
            _trianglePoints[0].Y = startY;

            _trianglePoints[1].X = startX;
            _trianglePoints[1].Y = endY;

            _trianglePoints[2].X = endX;
            _trianglePoints[2].Y = endY;

            PlotTriangle(e.Graphics);
        }

        private void button_down_Paint(object sender, PaintEventArgs e)
        {
            const int yOffset = 3;
            int startY = yOffset;
            int endY = button_up.Height - yOffset;

            int xOffset = endY - startY;

            int middleX = button_down.Width / 2;
            int startX = middleX - xOffset;
            int endX = middleX + xOffset;

            _trianglePoints[0].X = startX;
            _trianglePoints[0].Y = startY;

            _trianglePoints[1].X = endX;
            _trianglePoints[1].Y = startY;

            _trianglePoints[2].X = middleX;
            _trianglePoints[2].Y = endY;

            PlotTriangle(e.Graphics);
        }

        private void PlotTriangle(Graphics graphics)
        {
            graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
            graphics.FillPolygon(_buttonBrush, _trianglePoints, FillMode.Winding);
        }

        private void NumericBox_BackColorChanged(object sender, EventArgs e)
        {
            this.textBox_value.BackColor = this.BackColor;
            this.button_up.BackColor = this.BackColor;
            this.button_down.BackColor = this.BackColor;
        }

        private void button_up_Click(object sender, EventArgs e)
        {
            this.Value += Increment;
        }

        private void button_down_Click(object sender, EventArgs e)
        {
            this.Value -= Increment;
        }

        private void textBox_value_TextChanged(object sender, EventArgs e)
        {
            if (_innerOperation)
            {
                return;
            }
            double value;
            if (double.TryParse(textBox_value.Text, out value))
            {
                this._value = value;
            }
            ShowValue();
        }

        private void ShowValue()
        {
            _innerOperation = true;
            this.textBox_value.Text = _value.ToString(_textFormat);
            _value = double.Parse(this.textBox_value.Text);
            _innerOperation = false;
        }
    }
}
