using System;
using System.Windows.Forms;

namespace passmng
{
    public class NoBalloonPasswordTextBox : TextBox
    {
        private System.Windows.Forms.Timer capsLockTimer;

        
        public event Action CapsLockChanged;

        protected override void WndProc(ref Message m)
        {
            const int EM_SHOWBALLOONTIP = 0x1503;
            if (m.Msg == EM_SHOWBALLOONTIP)
                return; 
            base.WndProc(ref m);
        }

        protected override void OnEnter(EventArgs e)
        {
            base.OnEnter(e);
            StartCapsLockTimer();
        }

        protected override void OnLeave(EventArgs e)
        {
            base.OnLeave(e);
            StopCapsLockTimer();
        }

        private void StartCapsLockTimer()
        {
            if (capsLockTimer == null)
            {
                capsLockTimer = new System.Windows.Forms.Timer();
                capsLockTimer.Interval = 5;
                capsLockTimer.Tick += (s, ev) =>
                {
                    CapsLockChanged?.Invoke(); 
                };
            }
            capsLockTimer.Start();
        }

        private void StopCapsLockTimer()
        {
            capsLockTimer?.Stop();
        }
    }
}