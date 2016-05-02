using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication1.Classes;
using WindowsFormsApplication1.Classes.Interfaces;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form {
        private List<PointF> _listPoints;
        private Bitmap _buffer;
        private Graphics graphics;
        private IGeometryPath _path;
        public Form1()
        {
            InitializeComponent();
            this._listPoints = new List<PointF>();
            this._buffer = new Bitmap(this._pictureBoxFrame.Width,this._pictureBoxFrame.Height);
            this.graphics = Graphics.FromImage(this._buffer);
            this.graphics.Clear(Color.White);
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (this._radioButtonCurve.Checked) {
                this._path = new Curve(this._listPoints);
            }
        }

        private void _pictureBoxFrame_MouseClick(object sender, MouseEventArgs e)
        {
            this._listPoints.Add(e.Location);
            this.UpdateFrame();
            this._radioButtonBezierCurve.Checked = false;
            this._radioButtonCurve.Checked = false;
            this._radioButtonPolygone.Checked = false;
        }

        private void UpdateFrame() {

            foreach (var point in this._listPoints) {
                this.graphics.FillEllipse(Brushes.Blue,point.X-4,point.Y-4,8,8);
            }
            this._pictureBoxFrame.CreateGraphics().DrawImage(this._buffer,0,0);
            this.graphics.Clear(Color.White);
        }

        private void _buttonCreate_Click(object sender, EventArgs e) {
            try {
                this._path.Draw(this.graphics);
            }
            catch (ArgumentException) {
                MessageBox.Show("Построить кривую Безье по такому набору точек невозможно");
            }
            catch (Exception) {

                MessageBox.Show("Пожалуйста, выберите что Вы хотите нарисовать");
            }


            this.UpdateFrame();
        }

        private void _radioButtonBezierCurve_CheckedChanged(object sender, EventArgs e)
        {
            if (this._radioButtonBezierCurve.Checked) {
                this._path = new BezierCurve(this._listPoints);
            }
        }

        private void _radioButtonPolygone_CheckedChanged(object sender, EventArgs e)
        {
            if (this._radioButtonPolygone.Checked)
            {
                this._path = new Polygon(this._listPoints);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this._listPoints.Clear();
            this._path = null;
            this.UpdateFrame();
        }
    }
}
