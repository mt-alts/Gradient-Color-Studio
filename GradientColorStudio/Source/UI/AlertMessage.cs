using System;
using System.Drawing;
using System.Windows.Forms;

namespace GradientColorStudio
{
    public partial class AlertMessage : UserControl
    {
        private MainForm formReference;
        private AlertMessage alertMessageReference;

        public AlertMessage()
        {
            InitializeComponent();
        }

        public static void Show(MainForm sender, string text, int timeInterval)
        {
            AlertMessage alertMessage = new AlertMessage();
            alertMessage.lblText.Text = text;
            alertMessage.timer1.Interval = timeInterval;
            alertMessage.Size = new Size(alertMessage.lblText.Size.Width + 6, alertMessage.lblText.Size.Height + 6);
            if (alertMessage.Width > sender.Width || alertMessage.Height > sender.Height)
            {
                text = "An error occurred while receiving the message. The message size is too large.";
                alertMessage.lblText.Text = text;
                alertMessage.Size = new Size(alertMessage.lblText.Size.Width + 6, alertMessage.lblText.Size.Height + 6);
            }
            alertMessage.lblText.Location = new Point(3, 3);
            alertMessage.Location = new Point((sender.Width / 2) - (alertMessage.Width / 2), (sender.Height * 85) / 100);
            alertMessage.formReference = sender;
            alertMessage.alertMessageReference = alertMessage;
            sender.Controls.Add(alertMessage);
            alertMessage.BringToFront();
            alertMessage.timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            formReference.Controls.Remove(alertMessageReference);
        }
    }
}
