using System;
using System.Media;
using System.Windows.Forms;

namespace MyMessageBox
{
    public partial class Messagebox : Form
    {
        public enum MyIcons
        {
            Error, Warning, Question, Informtion, Ok, EmojiOk
        }
        public enum MyButton
        {
            OK, OKCANCEL, YESNO
        }
        public enum MyDialogResult
        {
            OK, CANCEL, YES, NO
        }
        public static MyDialogResult Show(string msg, string title = "", MyButton button = MyButton.OK, MyIcons icon = MyIcons.Ok)
        {
            Messagebox omsg = new Messagebox(msg, title, button, icon);
            omsg.ShowDialog();
            return dialog;
        }
        static MyDialogResult dialog;
        public Messagebox()
        {
            InitializeComponent();
            btncancel.Visible = btnno.Visible = btnok.Visible = btnyes.Visible = false;
        }
        public Messagebox(string msg, string title = "", MyButton button = MyButton.OK, MyIcons icon = MyIcons.Ok) : this()
        {
            lblmsg.Text = msg;
            lbltitle.Text = title;
            SetMode(icon);
            SetButton(button);

        }
        void SetIcons(MyIcons icon)
        {
            switch (icon)
            {
                case MyIcons.Error:
                    picicon.Image = Properties.Resources.Error;
                    break;
                case MyIcons.Warning:
                    picicon.Image = Properties.Resources.Warning;
                    break;
                case MyIcons.Question:
                    picicon.Image = Properties.Resources.Question;
                    break;
                case MyIcons.Informtion:
                    picicon.Image = Properties.Resources.Info;
                    break;
                case MyIcons.Ok:
                    picicon.Image = Properties.Resources.OK;
                    break;
                case MyIcons.EmojiOk:
                    picicon.Image = Properties.Resources.EmojeOK;
                    break;

            }
        }
        void SetMode(MyIcons icon) { SetIcons(icon); PlayerSound(icon); }
        void PlayerSound(MyIcons icon)
        {
            SoundPlayer oplay;
            switch (icon)
            {
                case MyIcons.Error:
                    oplay = new SoundPlayer(Properties.Resources.sound_Error);
                    break;
                case MyIcons.Warning:
                    oplay = new SoundPlayer(Properties.Resources.sound_warning);
                    break;
                case MyIcons.Question:
                    oplay = new SoundPlayer(Properties.Resources.sound_question);
                    break;
                case MyIcons.Informtion:
                    oplay = new SoundPlayer(Properties.Resources.sound_information);
                    break;
                case MyIcons.Ok:
                    oplay = new SoundPlayer(Properties.Resources.sound_information);
                    break;
                case MyIcons.EmojiOk:
                    oplay = new SoundPlayer(Properties.Resources.sound_information);
                    break;
                default:
                    oplay = new SoundPlayer();

                    break;
            }
            oplay.Play();
        }
        void SetButton(MyButton button)
        {
            switch (button)
            {
                case MyButton.OK:
                    btnok.Visible = true;
                    break;
                case MyButton.OKCANCEL:
                    btncancel.Visible = btnok.Visible = true;
                    break;
                case MyButton.YESNO:
                    btnyes.Visible = btnno.Visible = true;
                    break;

            }
        }

        private void btnok_Click(object sender, EventArgs e)
        {
            dialog = MyDialogResult.OK;
            this.Close();
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            dialog = MyDialogResult.CANCEL;
            this.Close();
        }

        private void btnyes_Click(object sender, EventArgs e)
        {
            dialog = MyDialogResult.YES;
            this.Close();
        }

        private void btnno_Click(object sender, EventArgs e)
        {
            dialog = MyDialogResult.NO;
            this.Close();
        }

        private void exitbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
