using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Cember
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
         
                int p1X = (int)nud_p1x.Value;
                int p1Y =(int)nud_p1y.Value;
                int p2X =(int)nud_p2x.Value;
                int p2Y = (int)nud_p2y.Value;
                int p3X = (int)nud_p3x.Value;
                int p3Y = (int)nud_p3y.Value;
                if (p1X <= 300 && p2X <= 300 && p3X <= 300 && p1Y <= 400 && p2Y <= 400 && p3Y <= 400)
                {
                    try
                    {
                        float x1 = (p2X + p1X) / 2;
                        float y1 = (p2Y + p1Y) / 2;
                        float dy1 = p2X - p1X;
                        float dx1 = -(p2Y - p1Y);

                        float x2 = (p3X + p2X) / 2;
                        float y2 = (p3Y + p2Y) / 2;
                        float dy2 = p3X - p2X;
                        float dx2 = -(p3Y - p2Y);

                        float cx = (y1 * dx1 * dx2 + x2 * dx1 * dy2 - x1 * dy1 * dx2 - y2 * dx1 * dx2) / (dx1 * dy2 - dy1 * dx2);
                        float cy = (cx - x1) * dy1 / dx1 + y1;

                        float dx = cx - p1X;
                        float dy = cy - p1Y;

                        Point merkez = new Point((int)cx, (int)cy);
                        float yaricap = (float)Math.Sqrt(dx * dx + dy * dy);

                        lb_yaricap.Text = "R = " + ((int)yaricap).ToString();
                        lb_merkez.Text = "C = " + ((int)cx).ToString() + "x" + ((int)cy).ToString();
                        lb_alan.Text = "A = " + ((int)(yaricap * yaricap)*3).ToString();
                        lb_cevre.Text = "P = " + ((int)(yaricap * 3)*2).ToString();

                        Bitmap sekil = new Bitmap(300, 400);
                        using (Graphics grafik = Graphics.FromImage(sekil))
                        {
                            Font font = new Font("tahoma", 10);
                            SolidBrush firca = new SolidBrush(Color.Yellow);
                            grafik.Clear(Color.Black);
                            Pen sari = new Pen(Color.Yellow, 2);
                            Pen mavi = new Pen(Color.Aqua, 2);
                            Pen turuncu = new Pen(Color.Orange, 2);
                            Pen mor = new Pen(Color.Magenta, 2);
                            Pen yesil = new Pen(Color.LimeGreen, 2);
                            Pen kirmizi = new Pen(Color.Red, 1);
                            grafik.DrawEllipse(mavi, p1X, p1Y, 2, 2);
                            grafik.DrawString("P₁", font, firca, p1X - 2, p1Y - 16);
                            grafik.DrawEllipse(mor, p2X, p2Y, 2, 2);
                            grafik.DrawString("P₂", font, firca, p2X - 2, p2Y - 16);
                            grafik.DrawEllipse(turuncu, p3X, p3Y, 2, 2);
                            grafik.DrawString("P₃", font, firca, p3X - 2, p3Y - 16);
                            grafik.DrawEllipse(yesil, (int)cx, (int)cy, 2, 2);
                            grafik.DrawString("C", font, firca, (int)cx - 4, (int)cy - 16);
                            grafik.DrawString("r = " + ((int)yaricap).ToString(), font, firca, 0, 0);
                            grafik.DrawEllipse(Pens.Red, (int)(merkez.X - yaricap), (int)(merkez.Y - yaricap), (int)yaricap * 2, (int)yaricap * 2);


                        }
                        pb_circle.Image = sekil;
                    }
                    catch (Exception hata)
                    {
                        MessageBox.Show(hata.Message.ToString(), "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                    MessageBox.Show("Girilen değerler geçerli değil !", "Uyari", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
