using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;

namespace CoordinateApp
{
    public partial class Form1 : Form
    {
        private List<PointF> coordinates = new List<PointF>();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                // Parse X and Y using InvariantCulture to handle decimal points properly
                if (float.TryParse(txtX.Text, NumberStyles.Float, CultureInfo.InvariantCulture, out float x) &&
                    float.TryParse(txtY.Text, NumberStyles.Float, CultureInfo.InvariantCulture, out float y))
                {
                    // Add coordinate to list
                    PointF point = new PointF(x, y);
                    coordinates.Add(point);

                    // Add to ListBox with formatted string
                    lstCoordinates.Items.Add($"{x}, {y}");

                    // Clear input fields
                    txtX.Clear();
                    txtY.Clear();

                    // Focus back to txtX
                    txtX.Focus();

                    // Refresh drawing
                    pictureBox.Invalidate();
                }
                else
                {
                    MessageBox.Show("กรุณาใส่ตัวเลขสำหรับ X และ Y", "ข้อผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"เกิดข้อผิดพลาด: {ex.Message}", "ข้อผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            try
            {
                if (lstCoordinates.SelectedIndex >= 0)
                {
                    int index = lstCoordinates.SelectedIndex;
                    
                    // Remove from coordinates list
                    coordinates.RemoveAt(index);
                    
                    // Remove from ListBox
                    lstCoordinates.Items.RemoveAt(index);

                    // Refresh drawing
                    pictureBox.Invalidate();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"เกิดข้อผิดพลาด: {ex.Message}", "ข้อผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pictureBox_Paint(object sender, PaintEventArgs e)
        {
            try
            {
                Graphics g = e.Graphics;
                g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

                // Draw coordinate axes
                Pen axisPen = new Pen(Color.Gray, 1);
                g.DrawLine(axisPen, 0, pictureBox.Height / 2, pictureBox.Width, pictureBox.Height / 2); // X-axis
                g.DrawLine(axisPen, pictureBox.Width / 2, 0, pictureBox.Width / 2, pictureBox.Height); // Y-axis

                // Calculate scale to fit points in the picture box
                float scale = 10f; // 10 pixels per unit
                float centerX = pictureBox.Width / 2;
                float centerY = pictureBox.Height / 2;

                // Draw all coordinates
                foreach (PointF point in coordinates)
                {
                    // Transform coordinates to screen space
                    float screenX = centerX + (point.X * scale);
                    float screenY = centerY - (point.Y * scale); // Subtract because Y increases downward on screen

                    // Draw a circle at the point
                    float radius = 5f;
                    g.FillEllipse(Brushes.Red, screenX - radius, screenY - radius, radius * 2, radius * 2);
                    
                    // Draw crosshair
                    Pen crossPen = new Pen(Color.Blue, 2);
                    g.DrawLine(crossPen, screenX - 8, screenY, screenX + 8, screenY);
                    g.DrawLine(crossPen, screenX, screenY - 8, screenX, screenY + 8);

                    // Draw coordinate label
                    string label = $"({point.X}, {point.Y})";
                    Font font = new Font("Arial", 8);
                    g.DrawString(label, font, Brushes.Black, screenX + 10, screenY - 10);
                }
            }
            catch (Exception ex)
            {
                // Silently handle drawing errors to prevent crashes
                System.Diagnostics.Debug.WriteLine($"Drawing error: {ex.Message}");
            }
        }

        private void txtY_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Trigger Add when Enter is pressed in txtY
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true; // Prevent the beep sound
                btnAdd_Click(sender, e);
            }
        }
    }
}
