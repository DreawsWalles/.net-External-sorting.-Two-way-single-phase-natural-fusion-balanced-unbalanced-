using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace project
{
    static class Designer
    {
        static FrmLoadOrCreateFile frmFile;
       
        static Designer()
        {
            
        }

        private static PictureBox copyPicture(PictureBox picture)
        {
            PictureBox pic = new PictureBox
            {
                Image = picture.Image,
                Width = picture.Width,
                Height = picture.Height,
                Region = picture.Region,
                Tag = picture.Tag
            };

            return pic;
        }

        private static Region cutRegion(Bitmap picture)
        {
            GraphicsPath graphics = new GraphicsPath();
            Color whiteCol = picture.GetPixel(0, 0);
            for (int x = 0; x < picture.Width; x++)
            {
                for (int y = 0; y < picture.Height; y++)
                {
                    if (!picture.GetPixel(x, y).Equals(whiteCol))
                    {
                        graphics.AddRectangle(new Rectangle(x, y, 1, 1));
                    }
                }
            }
            return new Region(graphics);
        }

        public static void DesignerFrmLoadOrCreateFile(FrmLoadOrCreateFile form, int design)
        {
            frmFile = form;
            switch (design)
            {
                case 0:
                    form.listBox.DrawItem += new DrawItemEventHandler(listBox_DrawItem_1);

                    form.SelectedTypeColor = Color.Gainsboro;
                    form.UnSelectedTypeColor = Color.Transparent;

                    form.BackColor = Color.White;
                    form.listBox.BackColor = Color.White;
                    form.TextBox.BackColor = Color.White;
                    form.TextBox.BorderStyle = BorderStyle.FixedSingle;

                    form.BtnChar.ForeColor = Color.Black;
                    form.BtnDouble.ForeColor = Color.Black;
                    form.BtnString.ForeColor = Color.Black;
                    form.BtnInt.ForeColor = Color.Black;
                    form.BtnMyType.ForeColor = Color.Black;
                    form.BtnFloat.ForeColor = Color.Black;

                    form.BtnChar.BackColor = Color.White;
                    form.BtnDouble.BackColor = Color.White;
                    form.BtnString.BackColor = Color.White;
                    form.BtnInt.BackColor = Color.White;
                    form.BtnMyType.BackColor = Color.White;
                    form.BtnFloat.BackColor = Color.White;

                    form.EnterUnSelectItem = Color.Gainsboro;
                    form.EnterSelectItem = Color.LightGray;
                    form.LeaveSeletcItem = Color.Gainsboro;
                    form.LeaveUnSelectItem = Color.White;

                    form.LblTitle.ForeColor = Color.Black;

                    form.ColorTextInputWait = Color.Gray;
                    form.ColorTextInput = Color.Black;
                    break;
                case 1:
                    form.LblTitle.ForeColor = Color.White;

                    form.BackColor = Color.FromArgb(45, 45, 48);
                    form.TextBox.BackColor = Color.FromArgb(28, 28, 28);
                    form.TextBox.BorderStyle = BorderStyle.None;

                    form.BtnChar.ForeColor = Color.White;
                    form.BtnDouble.ForeColor = Color.White;
                    form.BtnString.ForeColor = Color.White;
                    form.BtnInt.ForeColor = Color.White;
                    form.BtnMyType.ForeColor = Color.White;
                    form.BtnFloat.ForeColor = Color.White;

                    form.BtnChar.BackColor = Color.FromArgb(45, 45, 48);
                    form.BtnDouble.BackColor = Color.FromArgb(45, 45, 48);
                    form.BtnString.BackColor = Color.FromArgb(45, 45, 48);
                    form.BtnInt.BackColor = Color.FromArgb(45, 45, 48);
                    form.BtnMyType.BackColor = Color.FromArgb(45, 45, 48);
                    form.BtnFloat.BackColor = Color.FromArgb(45, 45, 48);

                    form.UnSelectedTypeColor = Color.FromArgb(45, 45, 48);
                    form.SelectedTypeColor = Color.BlueViolet;

                    form.EnterUnSelectItem = Color.BlueViolet;
                    form.EnterSelectItem = Color.Indigo;
                    form.LeaveSeletcItem = Color.BlueViolet;
                    form.LeaveUnSelectItem = Color.FromArgb(45, 45, 48);

                    form.ColorTextInput = Color.White;
                    form.ColorTextInputWait = Color.Gray;
                    break;
                case 2:
                    break;
            }
        }
        private static void listBox_DrawItem_1(object sender, DrawItemEventArgs e)
        {
            try
            {
                int index = e.Index;
                Graphics g = e.Graphics;
                foreach (int selectedIndex in frmFile.listBox.SelectedIndices)
                {
                    if (index == selectedIndex)
                    {
                        // Draw the new background colour
                        e.DrawBackground();
                        g.FillRectangle(new SolidBrush(Color.Gainsboro), e.Bounds);
                    }
                }

                // Get the item details
                Font font = frmFile.listBox.Font;
                Color colour = frmFile.listBox.ForeColor;
                string text = frmFile.listBox.Items[index].ToString();

                // Print the text
                g.DrawString(text, font, new SolidBrush(Color.Black), (float)e.Bounds.X, (float)e.Bounds.Y);
                e.DrawFocusRectangle();
            }
            catch { }
        }
    }
}
