using System.Globalization;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace application
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private const int WM_NCHITTEST = 0x84;
        private const int HTCLIENT = 0x1;
        private const int HTCAPTION = 0x2;

        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);
            // click and drag form

            if (m.Msg == WM_NCHITTEST && (int)m.Result == HTCLIENT)
            {
                m.Result = (IntPtr)HTCAPTION;
            }

            // resize form with mouse
            if (m.Msg == 0x84) // WM_NCHITTEST
            {
                Point cursorPos = PointToClient(Cursor.Position);
                int borderSize = 10; // Adjust sensitivity

                if (cursorPos.X < borderSize && cursorPos.Y < borderSize)
                    m.Result = (IntPtr)16; // HTTOPLEFT
                else if (cursorPos.X > Width - borderSize && cursorPos.Y < borderSize)
                    m.Result = (IntPtr)17; // HTTOPRIGHT
                else if (cursorPos.X < borderSize && cursorPos.Y > Height - borderSize)
                    m.Result = (IntPtr)15; // HTBOTTOMLEFT
                else if (cursorPos.X > Width - borderSize && cursorPos.Y > Height - borderSize)
                    m.Result = (IntPtr)13; // HTBOTTOMRIGHT
                else if (cursorPos.X < borderSize)
                    m.Result = (IntPtr)10; // HTLEFT
                else if (cursorPos.X > Width - borderSize)
                    m.Result = (IntPtr)11; // HTRIGHT
                else if (cursorPos.Y < borderSize)
                    m.Result = (IntPtr)12; // HTTOP
                else if (cursorPos.Y > Height - borderSize)
                    m.Result = (IntPtr)14; // HTBOTTOM
            }
        }
        private void output(string text)
        {
            outputRichtextbox.Invoke(new Action(() =>
            {
                outputRichtextbox.AppendText(text);
                outputRichtextbox.SelectionStart = outputRichtextbox.TextLength;
                outputRichtextbox.ScrollToCaret();
                this.Refresh();
            }));
        }

        private void debug(string text, [CallerMemberName] string caller = "", [CallerLineNumber] int line = 0)
        {
            DateTime now = DateTime.Now;
            output(now.ToString("yyyy-MM-ddTHH:mm:ss.fff K", CultureInfo.InvariantCulture) + $" | {caller}:{line} | " + text + Environment.NewLine);
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            debug("Form loaded");
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void maxButton_Click(object sender, EventArgs e)
        {
            if (maxButton.Text == "⧠")
            {
                debug("Maximize form");
                this.WindowState = FormWindowState.Maximized;
                maxButton.Text = "⧉";
                return;
            }

            if (maxButton.Text == "⧉")
            {
                debug("Restore form");
                this.WindowState = FormWindowState.Normal;
                maxButton.Text = "⧠";
                return;
            }
        }
        private void Form1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            maxButton_Click(sender, e);
        }

        private void richTextBox1_LinkClicked(object sender, LinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
            {
                FileName = e.LinkText,
                UseShellExecute = true
            });
        }

        private void minButton_Click(object sender, EventArgs e)
        {
            debug("Minimize form");
            this.WindowState = FormWindowState.Minimized;
        }

    }
}
