using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using SharpGL;
using static Project.Types._GlobalData;
using System.Diagnostics;
using ZedGraph;
using Emgu.CV.Structure;
using Emgu.CV;
using Project.Processing;

namespace OpenGL_lesson_CSharp
{
    public partial class SharpGLForm : Form
    {
        float AngleX = 0, AngleY = 0;
        double POSX = 2, POSY = 0, POSZ = 0;
        const float Rad = 3.14f / 180f;
        int lX = -1, lY = -1;

        bool b = false;
        OpenGL gl;
        OpenFileDialog dlg;

        public SharpGLForm()
        {
            InitializeComponent();

        }


        private void openGLControl_OpenGLDraw(object sender, RenderEventArgs e)
        {
            //  Возьмём OpenGL объект
            gl = openGLControl.OpenGL;

            //  Очищаем буфер цвета и глубины
            gl.Clear(OpenGL.GL_COLOR_BUFFER_BIT | OpenGL.GL_DEPTH_BUFFER_BIT);
            
            //  Загружаем единичную матрицу
            gl.LoadIdentity();

            // Сдвигаем перо вправо от центра и вглубь экрана, но уже дальше
            gl.Translate(0.0f, 0.0f, 0.0f);

            foreach (var pix in Pixel)
            {
                if (pix != null)
                {
                    Cub(
                        new float[] { pix.X * (float)numericUpDownSume.Value, pix.Y * (float)numericUpDownSume.Value, pix.Z * (float)numericUpDownSume.Value },
                        pix.Size * (float)numericUpDownPix.Value,
                        new float[] { pix.packet.R / 255.0f, pix.packet.G / 255.0f, pix.packet.B / 255.0f }
                        );
                }

            }

            // Контроль полной отрисовки следующего изображения
            gl.Flush();

            void Cub(float[] coordinates, float size, float[] color)
            {
                // рисуем куб
                //gl.Begin(OpenGL.GL_TRIANGLES);
                gl.Begin(OpenGL.GL_QUADS);

                // Top
                gl.Color(color[0], color[1], color[2]);
                gl.Vertex(size + coordinates[0], size + coordinates[1], -size + coordinates[2]);
                gl.Vertex(-size + coordinates[0], size + coordinates[1], -size + coordinates[2]);
                gl.Vertex(-size + coordinates[0], size + coordinates[1], size + coordinates[2]);
                gl.Vertex(size + coordinates[0], size + coordinates[1], size + coordinates[2]);
                // Bottom
                gl.Color(color[0], color[1], color[2]);
                gl.Vertex(size + coordinates[0], -size + coordinates[1], size + coordinates[2]);
                gl.Vertex(-size + coordinates[0], -size + coordinates[1], size + coordinates[2]);
                gl.Vertex(-size + coordinates[0], -size + coordinates[1], -size + coordinates[2]);
                gl.Vertex(size + coordinates[0], -size + coordinates[1], -size + coordinates[2]);
                // Front
                gl.Color(color[0], color[1], color[2]);
                gl.Vertex(size + coordinates[0], size + coordinates[1], size + coordinates[2]);
                gl.Vertex(-size + coordinates[0], size + coordinates[1], size + coordinates[2]);
                gl.Vertex(-size + coordinates[0], -size + coordinates[1], size + coordinates[2]);
                gl.Vertex(size + coordinates[0], -size + coordinates[1], size + coordinates[2]);
                // Back
                gl.Color(color[0], color[1], color[2]);
                gl.Vertex(size + coordinates[0], -size + coordinates[1], -size + coordinates[2]);
                gl.Vertex(-size + coordinates[0], -size + coordinates[1], -size + coordinates[2]);
                gl.Vertex(-size + coordinates[0], size + coordinates[1], -size + coordinates[2]);
                gl.Vertex(size + coordinates[0], size + coordinates[1], -size + coordinates[2]);
                // Left
                gl.Color(color[0], color[1], color[2]);
                gl.Vertex(-size + coordinates[0], size + coordinates[1], size + coordinates[2]);
                gl.Vertex(-size + coordinates[0], size + coordinates[1], -size + coordinates[2]);
                gl.Vertex(-size + coordinates[0], -size + coordinates[1], -size + coordinates[2]);
                gl.Vertex(-size + coordinates[0], -size + coordinates[1], size + coordinates[2]);
                // Right
                gl.Color(color[0], color[1], color[2]);
                gl.Vertex(size + coordinates[0], size + coordinates[1], -size + coordinates[2]);
                gl.Vertex(size + coordinates[0], size + coordinates[1], size + coordinates[2]);
                gl.Vertex(size + coordinates[0], -size + coordinates[1], size + coordinates[2]);
                gl.Vertex(size + coordinates[0], -size + coordinates[1], -size + coordinates[2]);

                gl.End();
            }
        }

        







        private void buttonFile_Click(object sender, EventArgs e)
        {
            dlg = new OpenFileDialog();
            dlg.Title = "Open Image";
            dlg.Filter = "Image files (*.bmp , *.jpg , *.png, *.gif )|*.bmp;*.jpg;*.png;*.gif";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                pictureBoxStart.Image = Image.FromFile(dlg.FileName);
                buttonSize.Visible = true;

                numericUpDownX1.Value = 0;
                numericUpDownY1.Value = 0;
                numericUpDownX2.Value = pictureBoxStart.Image.Width;
                numericUpDownY2.Value = pictureBoxStart.Image.Height;

            }
        }
        private void buttonSize_Click(object sender, EventArgs e)
        {
            Image<Bgr, byte> sourceBitmap = new Bitmap(dlg.FileName).ToImage<Bgr, byte>();

            int x1 = GetIntValue(numericUpDownX1);
            int y1 = GetIntValue(numericUpDownY1);
            int x2 = GetIntValue(numericUpDownX2);
            int y2 = GetIntValue(numericUpDownY2);

            int GetIntValue(NumericUpDown numericUpDown)
            {
                return decimal.TryParse(numericUpDown.Text, out decimal numericValue) ? Convert.ToInt32(numericValue) : 0;
            }
            // Отображаем исходное изображение в pictureBoxStart
            pictureBoxStart.Image = sourceBitmap.ToBitmap();

            // Рисуем контур прямоугольника на изображении
            using (Graphics g = Graphics.FromImage(pictureBoxStart.Image))
            {
                // Задаем цвет и толщину контура
                Pen pen = new Pen(Color.Red, decimal.TryParse(numericUpDownLine.Text, out decimal numericValueX1) ? Convert.ToInt32(numericValueX1) : 0);

                // Рисуем контур прямоугольника
                g.DrawRectangle(pen, x1, y1, x2 - x1, y2 - y1);
            }


            // Отображаем обрезанный фрагмент в pictureBoxStop

            //pictureBoxStop.Image = CalibrationHelper.UndistortImage(croppedBitmap);
            pictureBoxStop.Image = sourceBitmap.ToBitmap();

        }

        private void button3D_Click(object sender, EventArgs e)
        {
            Pixel.Clear();
            Image<Bgr, byte> bitmap = new Bitmap(dlg.FileName).ToImage<Bgr, byte>();

            GraphPane pane1 = zedGraphControl1.GraphPane;

            pane1.GraphObjList.Clear();
            pane1.CurveList.Clear();
            pane1.YAxis.Scale.FontSpec.Size = 10;
            
            var sw = new Stopwatch();
            sw.Start();


            for (int i = 0; i < 0; i++)
            {
                double xend = 0;
                double yend = 0;

                double xstart = xend;
                double ystart = yend - 1;

                ArrowObj arrow = new ArrowObj(xstart, ystart, xend, yend);
                arrow.Line.Color = Color.Red;
                pane1.GraphObjList.Add(arrow);
                TextObj text = new TextObj("", xstart, ystart);
                text.FontSpec.Border.IsVisible = false;
                pane1.GraphObjList.Add(text);
            }

           

            sw.Stop();
            sw.Elapsed.ToString();



            zedGraphControl1.AxisChange();
            zedGraphControl1.Invalidate();


        }



        // Эту функцию используем для задания некоторых значений по умолчанию
        private void openGLControl_OpenGLInitialized(object sender, EventArgs e)
        {
            //  Возьмём OpenGL объект
            OpenGL gl = openGLControl.OpenGL;

            //  Фоновый цвет по умолчанию (в данном случае цвет голубой)
            gl.ClearColor(0.25f, 0.12f, 0.25f, 0);
        }

        // Данная функция используется для преобразования изображения 
        // в объёмный вид с перспективой
        private void openGLControl_Resized(object sender, EventArgs e)
        {
            //  Возьмём OpenGL объект
            OpenGL gl = openGLControl.OpenGL;

            //  Зададим матрицу проекции
            gl.MatrixMode(OpenGL.GL_PROJECTION);

            //  Единичная матрица для последующих преобразований
            gl.LoadIdentity();

            //  Преобразование
            gl.Perspective(60.0f, (double)Width / (double)Height, 0.01, 100.0);
            //gl.Frustum(-1, 1, -1, 1, 0.01, Double.MaxValue);

            //  Данная функция позволяет установить камеру и её положение
            var dX = Math.Sin(AngleX * Rad) * Math.Cos(AngleY * Rad);
            var dY = Math.Sin(AngleY * Rad);
            var dZ = Math.Cos(AngleX * Rad) * Math.Cos(AngleY * Rad);

            gl.LookAt(POSX, POSY, POSZ,    // Позиция самой камеры
                      POSX + dX,
                      POSY + dY,
                      POSZ + dZ,     // Направление, куда мы смотрим
                       0, 1, 0);    // Верх камеры

            //  Зададим модель отображения
            gl.MatrixMode(OpenGL.GL_MODELVIEW);
        }
 
        private void buttonX_Click(object sender, EventArgs e)
        {
            numericUpDownX1.Value += numericUpDownSdvig.Value;
            numericUpDownX2.Value += numericUpDownSdvig.Value;

            buttonSize_Click(sender, e);
        }
        private void buttonYp_Click(object sender, EventArgs e)
        {
            numericUpDownY1.Value += numericUpDownSdvig.Value;
            numericUpDownY2.Value += numericUpDownSdvig.Value;

            buttonSize_Click(sender, e);
        }
        private void buttonXm_Click(object sender, EventArgs e)
        {
            numericUpDownX1.Value -= numericUpDownSdvig.Value;
            numericUpDownX2.Value -= numericUpDownSdvig.Value;

            buttonSize_Click(sender, e);
        }
        private void buttonYm_Click(object sender, EventArgs e)
        {
            numericUpDownY1.Value -= numericUpDownSdvig.Value;
            numericUpDownY2.Value -= numericUpDownSdvig.Value;

            buttonSize_Click(sender, e);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            float x = 0; float y = 0; float z = 0;

            foreach (var item in Pixel)
            {
                x += item.X;
                y += item.Y;
                z += item.Z;
            }
            POSX = (x / Pixel.Count) * (float)numericUpDownSume.Value; POSY = (y / Pixel.Count) * (float)numericUpDownSume.Value; POSZ = (z / Pixel.Count) * (float)numericUpDownSume.Value;
        }


        private void openGLControl_MouseDown(object sender, MouseEventArgs e) => b = true;
        private void openGLControl_MouseUp(object sender, MouseEventArgs e) => b = false;
        private void SharpGLForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (b)
            {
                if (lX != -1)
                {
                    AngleX += (lX - e.X) / 5f;
                }
                if (lY != -1) AngleY += (lY - e.Y) / 5f;
                //Console.WriteLine($"mouse {lX} {lY}");
                openGLControl_Resized(sender, e);
            }
            lX = e.X;
            lY = e.Y;
        }
        private void openGLControl_KeyDown(object sender, KeyEventArgs e)
        {
            double dX, dY, dZ;
            switch (e.KeyCode)
            {
                case Keys.W:
                    dX = Math.Sin(AngleX * Rad) * Math.Cos(AngleY * Rad);
                    dY = Math.Sin(AngleY * Rad);
                    dZ = Math.Cos(AngleX * Rad) * Math.Cos(AngleY * Rad);
                    POSX += dX;
                    POSY += dY;
                    POSZ += dZ;
                    break;
                case Keys.S:
                    dX = Math.Sin(AngleX * Rad) * Math.Cos(AngleY * Rad);
                    dY = Math.Sin(AngleY * Rad);
                    dZ = Math.Cos(AngleX * Rad) * Math.Cos(AngleY * Rad);
                    POSX -= dX;
                    POSY -= dY;
                    POSZ -= dZ;
                    break;

                case Keys.A:
                    dX = Math.Sin((AngleX + 90) * Rad) * Math.Cos(AngleY * Rad);
                    dZ = Math.Cos((AngleX + 90) * Rad) * Math.Cos(AngleY * Rad);
                    POSX += dX;
                    POSZ += dZ;
                    break;
                case Keys.D:
                    dX = Math.Sin((AngleX - 90) * Rad) * Math.Cos(AngleY * Rad);
                    dZ = Math.Cos((AngleX - 90) * Rad) * Math.Cos(AngleY * Rad);
                    POSX += dX;
                    POSZ += dZ;
                    break;
                case Keys.Space:
                    dX = Math.Sin(AngleX * Rad) * Math.Cos((AngleY - 90) * Rad);
                    dY = Math.Sin((AngleY - 90) * Rad);
                    dZ = Math.Cos(AngleX * Rad) * Math.Cos((AngleY - 90) * Rad);
                    POSX += dX;
                    POSY += dY;
                    POSZ += dZ;
                    break;
                case Keys.Shift:
                    dX = Math.Sin(AngleX * Rad) * Math.Cos((AngleY + 90) * Rad);
                    dY = Math.Sin((AngleY + 90) * Rad);
                    dZ = Math.Cos(AngleX * Rad) * Math.Cos((AngleY + 90) * Rad);
                    POSX += dX;
                    POSY += dY;
                    POSZ += dZ;
                    break;
            }
            //openGLControl.Invalidate();
            openGLControl_Resized(sender, e);
        }
    }
}