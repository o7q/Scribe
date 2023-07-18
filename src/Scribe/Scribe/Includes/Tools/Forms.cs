using System;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Drawing;

namespace Scribe.Tools
{
    public static class Forms
    {
        // constants for mouse window events
        public const int HT_CAPTION = 0x2;
        public const int WM_NCLBUTTONDOWN = 0xA1;

        // import the SendMessage and ReleaseCapture functions from user32.dll
        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        // method to move the form when the mouse is clicked and dragged
        public static void MoveForm(IntPtr handle, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        public static void DrawListBox(ListBox listbox, DrawItemEventArgs e, Color color)
        {
            // code forked from: https://stackoverflow.com/a/3709452
            // custom drawing for queue list box items
            e.DrawBackground();
            bool selected = (e.State & DrawItemState.Selected) == DrawItemState.Selected;

            int index = e.Index;
            if (index >= 0 && index < listbox.Items.Count)
            {
                Graphics g = e.Graphics;

                SolidBrush backgroundBrush;
                if (selected)
                    backgroundBrush = new SolidBrush(color);
                else if ((index % 2) == 0)
                    backgroundBrush = new SolidBrush(Color.FromArgb(255, 10, 10, 12));
                else
                    backgroundBrush = new SolidBrush(Color.FromArgb(255, 20, 20, 22));
                g.FillRectangle(backgroundBrush, e.Bounds);

                string text = listbox.Items[index].ToString();
                g.DrawString(text, e.Font, new SolidBrush(Color.FromArgb(255, 255, 255, 255)), listbox.GetItemRectangle(index).Location);
            }
            //
        }

        public static int HighlightPhrase(RichTextBox richTextBox, string phrase, Color color, bool caseSensitive)
        {
            string text = richTextBox.Text;
            int index;
            int searchIndex = 0;

            int count = 0;

            while (searchIndex < text.Length)
            {
                index = text.IndexOf(phrase, searchIndex, caseSensitive ? StringComparison.Ordinal : StringComparison.OrdinalIgnoreCase);
                if (index >= 0)
                {
                    richTextBox.Select(index, phrase.Length);
                    richTextBox.SelectionColor = color;
                    richTextBox.SelectionBackColor = Color.FromArgb(255, color.R / 8, color.G / 8, color.B / 8);
                    searchIndex = index + phrase.Length;

                    count++;
                }
                else
                    break;
            }

            return count;
        }

        public class CustomRenderer : ToolStripProfessionalRenderer
        {
            protected override void OnRenderItemText(ToolStripItemTextRenderEventArgs e)
            {
                // change the text color
                e.TextColor = Color.FromArgb(255, 220, 220, 220);
                base.OnRenderItemText(e);
            }

            protected override void OnRenderMenuItemBackground(ToolStripItemRenderEventArgs e)
            {
                // change the background color
                if (e.Item.Selected)
                {
                    using (SolidBrush brush = new SolidBrush(Color.FromArgb(255, 20, 20, 20)))
                        e.Graphics.FillRectangle(brush, e.Item.ContentRectangle);
                }
                else
                    base.OnRenderMenuItemBackground(e);
            }
        }
    }
}