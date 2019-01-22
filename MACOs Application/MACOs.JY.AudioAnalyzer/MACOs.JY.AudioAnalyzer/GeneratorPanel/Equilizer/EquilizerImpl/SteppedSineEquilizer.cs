using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MACOs.JY.AudioAnalyzer.GeneratorPanel.GeneratorImpl;
using SeeSharpTools.JY.Audio.Equilizer;
using SeeSharpTools.JY.GUI;

namespace MACOs.JY.AudioAnalyzer.GeneratorPanel.Equilizer.EquilizerImpl
{
    public partial class SteppedSineEquilizer : Form, IEquilizer
    {
        private SteppedSineWave waveform;
        private List<Slide> _equalizers = new List<Slide>();

        public SteppedSineEquilizer(SteppedSineWave steppedSineWave, uint steps, double amplitude, 
            SteppedSineEqualizer lastEqualizer)
        {
            InitializeComponent();
            numericUpDown_targetAmplitude.Value = (decimal) amplitude;
            this.waveform = steppedSineWave;
            CreateEqualizerSlides(steps, amplitude);
            InitControls(lastEqualizer, steps, amplitude);
        }
        
        private void CreateEqualizerSlides(uint steps, double amplitude)
        {
            const int slideWidth = 50;
            if (steps > 4)
            {
                this.Width += (int)(steps - 4) * slideWidth;
                groupBox_equalizer.Width += (int)(steps - 4) * slideWidth;
            }
            for (int i = 0; i < steps; i++)
            {
                CreateSingleEqualizerSlide(i, amplitude, slideWidth);
            }
        }

        private void CreateSingleEqualizerSlide(int index, double amplitude, int slideWidth)
        {
            Slide slide = new Slide();
            slide.BackColor = System.Drawing.Color.Transparent;
            slide.Fill = false;
            slide.FillColor = System.Drawing.Color.Blue;
            slide.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            slide.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (123)))), ((int) (((byte) (125)))),
                ((int) (((byte) (123)))));
            slide.LineColor = System.Drawing.Color.FromArgb(((int) (((byte) (90)))), ((int) (((byte) (93)))),
                ((int) (((byte) (90)))));
            slide.LineWidth = 3;
            slide.Location = new System.Drawing.Point(10 + index * slideWidth, 20);
            slide.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            slide.Max = amplitude;
            slide.Min = amplitude/10;
//            this.slide1.Name = "slide1";
            slide.NumberOfDivisions = 9;
            slide.Orientation = System.Windows.Forms.Orientation.Vertical;
            slide.Size = new System.Drawing.Size(51, 140);
            slide.TabIndex = 0;
            slide.TextDecimals = 3;
            slide.TickStyle = TickStyle.None;
            slide.TrackerColor = System.Drawing.Color.DimGray;
            slide.TrackerSize = new System.Drawing.Size(5, 15);
            slide.Value = 0D;
            slide.Valuedecimals = 3;
            slide.Value = amplitude;
            this.groupBox_equalizer.Controls.Add(slide);
            _equalizers.Add(slide);
        }

        private void InitControls(SteppedSineEqualizer lastEqualizer, uint steps, double amplitude)
        {
            if (null == lastEqualizer || lastEqualizer.GetPointsOfEQ() != steps || 
                amplitude < lastEqualizer.TargetAmplitude || lastEqualizer.TargetAmplitude < amplitude / 10)
            {
                return;
            }
            for (ushort i = 0; i < steps; i++)
            {
                if (Math.Abs(lastEqualizer.GetEQ(i)) > 0.00001)
                {
                    // TODO equalizer value is the 1/value, to Confirm
                    _equalizers[i].Value = 1 / lastEqualizer.GetEQ(i);
                }
            }
        }

        public EqualizerBase GetEqualizer()
        {
            double[] equalizer = new double[_equalizers.Count];
            for (int i = 0; i < equalizer.Length; i++)
            {
                equalizer[i] = _equalizers[i].Value;
            }
            double amplitude = (double) numericUpDown_targetAmplitude.Value;
            return new SteppedSineEqualizer(equalizer, amplitude);
        }

        public double GetTargetAmplitude()
        {
            throw new NotImplementedException();
        }

        private void button_confirm_Click(object sender, EventArgs e)
        {
            waveform.SetEqualizerValue(GetEqualizer());
            this.Dispose();
        }

        private void button_cancel_Click(object sender, EventArgs e)
        {
            waveform.SetEqualizerValue(null);
            ResetAllSlides();
        }

        private void numericUpDown_targetAmplitude_ValueChanged(object sender, EventArgs e)
        {
            ResetAllSlides();
        }

        private void ResetAllSlides()
        {
            double amplitude = (double) numericUpDown_targetAmplitude.Value;
            foreach (Slide slide in _equalizers)
            {
                slide.Max = amplitude;
                slide.Min = amplitude/10;
                slide.Value = amplitude;
            }
        }
    }
}
