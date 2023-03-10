using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace Pt2pt
{
    public partial class MyForm : Form
    {
        static Figure f;
        Point ptX, ptY, mouse;
        Bitmap bmpX, bmpY;
        Graphics gX, gY;
        bool IsMouseDownX = false;
        bool IsMouseDownY = false;
        Canvas canvas;
        float deltaX = 0;
        float deltaY = 1;
        Scene scene;
        bool isMouseDown = false;

        const int WM_KEYUP = 0x0101;
        const int WM_KEYDOWN = 0x0100;

        private DateTime start;

        public MyForm()
        {
            InitializeComponent();
            Init();
            IsMouseDownX = false;
        }

        private void Init()
        {   
            //Barras Laterales
            bmpX = new Bitmap(PCT_SLIDEER_X.Width, PCT_SLIDEER_X.Height);
            bmpY = new Bitmap(PCT_SLIDEER_Y.Width, PCT_SLIDEER_Y.Height);

            gX = Graphics.FromImage(bmpX);
            gY = Graphics.FromImage(bmpY);

            PCT_SLIDEER_X.Image = bmpX;
            PCT_SLIDEER_Y.Image = bmpY;

            gX.DrawLine(Pens.DimGray, 0, bmpX.Height / 2, bmpX.Width, bmpX.Height / 2);
            gX.FillEllipse(Brushes.Green, bmpX.Width / 2, bmpX.Height / 4, bmpX.Height / 2, bmpX.Height / 2);

            gY.DrawLine(Pens.DimGray, bmpY.Width / 2, 0,  bmpY.Width / 2, bmpY.Height);
            gY.FillEllipse(Brushes.Red, bmpY.Width / 4, bmpY.Height / 2, bmpX.Height / 2, bmpX.Height / 2);

            //Scene
            scene = new Scene();
            Figure fig = new Figure();
            fig.Add(new PointF(100, 120));
            fig.Add(new PointF(1400, 120));
            scene.Figures.Add(fig);

            TIMER2.Stop();
            
        }
        private void PCT_SLIDEER_Y_MouseUp(object sender, MouseEventArgs e)
        {
            IsMouseDownY = false;
            gY.Clear(Color.Transparent);
            gY.DrawLine(Pens.DimGray, bmpY.Width / 2, 0, bmpY.Width / 2, bmpY.Height);
            gY.FillEllipse(Brushes.Aquamarine, bmpY.Width / 4, bmpY.Height / 2, bmpX.Height / 2, bmpX.Height / 2);

            PCT_SLIDEER_Y.Invalidate();
        }

        private void PCT_SLIDEER_Y_MouseMove(object sender, MouseEventArgs e)
        {
            if (IsMouseDownY)
            {
                gY.Clear(Color.Transparent);
                gY.DrawLine(Pens.DimGray, bmpY.Width / 2, 0, bmpY.Width / 2, bmpY.Height);
                gY.FillEllipse(Brushes.Aquamarine, bmpY.Width / 4, e.Y, bmpX.Height / 2, bmpX.Height / 2);

                PCT_SLIDEER_Y.Invalidate();
                deltaY += (float)(ptY.Y - e.Location.Y) / 500;
                ptY.Y = e.Location.Y;
            }
        }

        private void PCT_SLIDEER_Y_MouseDown(object sender, MouseEventArgs e)
        {
            ptY = e.Location;
            IsMouseDownY = true;
        }

        private void PCT_SLIDEER_X_MouseDown(object sender, MouseEventArgs e)
        {
            ptX = e.Location;
            IsMouseDownX = true;
        }

        private void PCT_SLIDEER_X_MouseMove(object sender, MouseEventArgs e)
        {
            if (IsMouseDownX)
            {
                gX.Clear(Color.Transparent);
                gX.DrawLine(Pens.DimGray, 0, PCT_SLIDEER_X.Height / 2, PCT_SLIDEER_X.Width, PCT_SLIDEER_X.Height / 2);
                gX.FillEllipse(Brushes.Aquamarine, e.X, PCT_SLIDEER_X.Height / 4, PCT_SLIDEER_X.Height / 2, PCT_SLIDEER_X.Height / 2);

                PCT_SLIDEER_X.Invalidate();
                deltaX += (float)(e.Location.X - ptX.X) / 3;
                ptX.X = e.Location.X;
            }
        }

        private void PCT_SLIDEER_X_MouseUp(object sender, MouseEventArgs e)
        {
            IsMouseDownX = false;
            gX.Clear(Color.Transparent);
            gX.DrawLine(Pens.DimGray, 0, PCT_SLIDEER_X.Height / 2, PCT_SLIDEER_X.Width, PCT_SLIDEER_X.Height / 2);
            gX.FillEllipse(Brushes.Aquamarine, PCT_SLIDEER_X.Width / 2, PCT_SLIDEER_X.Height / 4, PCT_SLIDEER_X.Height / 2, PCT_SLIDEER_X.Height / 2);

            PCT_SLIDEER_X.Invalidate();
        }

        private void MyForm_Resize(object sender, EventArgs e)
        {
            canvas = new Canvas(PCT_CANVAS);
        }

        private void TIMER_Tick(object sender, EventArgs e)
        {
            if (f != null && (IsMouseDownX|| IsMouseDownY))
            {
                f.TranslateToOrigin();
                f.Scale(deltaY);
                f.Rotate(deltaX);                
                f.TranslatePoints(f.Centroid);             
            }
            deltaX = 0;
            deltaY = 1;
            canvas.Render(scene);
        }

        private void PCT_CANVAS_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
                f.UpdateAttributes();
        }

        //Botón agregar al dar click
        private void BTN_EXE_Click(object sender, EventArgs e)
        {
            f = new Figure();
            scene.Figures.Add(f);
            TreeNode node = new TreeNode("Fig" + (TREE.Nodes.Count + 1));
            node.Tag = f;
            TREE.Nodes.Add(node);
        }   

        private void TREE_AfterSelect(object sender, TreeViewEventArgs e)
        {
            f = (Figure)TREE.SelectedNode.Tag;
            BTN_EXE.Select();
        }
        
        //Ctrl no presionado permite mover las teclas
        public static bool IsControlDown()
        {
            return (Control.ModifierKeys & Keys.Control) == Keys.Control;
        }

        //Teclas para mover
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (f == null)
                return false;
            
            switch (keyData)
            {
                case Keys.Left:
                    f.Centroid.X -= 3;                  
                    break;
                case Keys.Right:
                    f.Centroid.X += 3;
                    break;
                case Keys.Up:
                    f.Centroid.Y += -3;
                    break;
                case Keys.Down:
                    f.Centroid.Y += 3;
                    break;
                case Keys.Space:
                    break;
            }
            PCT_CANVAS.Select();
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void PCT_CANVAS_MouseDown(object sender, MouseEventArgs e)
        {
            mouse = e.Location;
            isMouseDown = true;
        }

        private void PCT_CANVAS_MouseUp(object sender, MouseEventArgs e)
        {
            isMouseDown = false;
            PCT_CANVAS.Select();
        }

        private void START_Click(object sender, EventArgs e)
        {
            start = DateTime.Now;
            TIMER2.Start();
            
        }

        private void isTime()
        {
            if ((DateTime.Now - start).TotalSeconds >= 3)
            {
                TIMER2.Stop();
                textBox1.Text  = "Time to stop";
            }
        }

        private void REPRODUCE_Click(object sender, EventArgs e)
        {
            canvas.Render2(scene);
        }

        private void NORMAL_Click(object sender, EventArgs e)
        {
      
        }

        private void TIMER2_Tick(object sender, EventArgs e)
        {
            isTime();
            Figure f2 = new Figure();
            f2 = f;
            scene.RFigures.Add(f2);
        }

        private void TIMER3_Tick(object sender, EventArgs e)
        {

        }

        private void PCT_CANVAS_MouseMove(object sender, MouseEventArgs e)
        {
            if (isMouseDown)
            {
                mouse.X -= e.X;
                mouse.Y -= e.Y;
                f.TranslatePoints(new Point(-mouse.X,-mouse.Y));
                mouse = e.Location;
            }            
        }

        private void PCT_CANVAS_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (f != null)
            {
                canvas.DrawPixel(e.X, e.Y, Color.White);
                f.Add(new PointF(e.X, e.Y));
            }
        }

        private void TREE_KeyPress(object sender, KeyPressEventArgs e)
        {
            return;
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            LBL_STATUS.Text = " ::: " + (float)trackBar1.Value / 100;            
            f.Follow(scene.Figures[0].Pts[0], scene.Figures[0].Pts[1], (float)trackBar1.Value / 100);
        }

     }
}
