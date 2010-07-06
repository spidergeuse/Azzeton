using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Globalization;
using System.IO;

using Azzeton.Shared;

namespace Azzeton.Components
{

    internal partial class AzzetonMessageBox : Form
    {
        public AzzetonMessageBox()
        {
            InitializeComponent();
        }
        private bool DontCloseOnClick { get; set; }
        private void _btn_yes_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Yes;
            if(!this.DontCloseOnClick)this.Close();
        }
        private void _btn_no_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.No;
            if (!this.DontCloseOnClick) this.Close();
        }
        private void _btn_cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            if (!this.DontCloseOnClick) this.Close();
        }
        private void _btn_ok_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
        public bool DontShowAgain
        {
            get { return _chk_dont_show.Checked; }
        }

        private void SetupMessage(string message, string title, MessageButtonType responsetype, bool showdontshow)
        {
            this._chk_dont_show.Visible = showdontshow;
            this._lbl_message.Text = message;
            this._hdp_header.Title = ProductSettings.ProductName; //title;
            this._hdp_header.SubTitle = title;
            this.Text = ProductSettings.ProductName;
            switch (responsetype)
            {
                case MessageButtonType.OK:
                    _pan_ok.BringToFront();
                    this.AcceptButton = _btn_ok;
                    break;
                case MessageButtonType.YesNo:
                    _pan_yes_no.BringToFront();
                    this.AcceptButton = _btn_no;
                    break;
                case MessageButtonType.YesNoCancel:
                    _pan_yes_no_cancel.BringToFront();
                    this.AcceptButton = _btn_cancel;
                    //this.CancelButton = _btn_cancel;
                    break;
            }
        }
        private void SetButtonText(string yestext, string notext, string canceltext, string oktext)
        {
            this._btn_cancel.Text = canceltext;
            this._btn_no.Text = notext;
            this._btn_no_.Text = notext;
            this._btn_ok.Text = oktext;
            this._btn_yes.Text = yestext;
            this._btn_yes_.Text = yestext;
        }
        public DialogResult ShowMessage(string message,string title,MessageButtonType responsetype, ref bool showdontshow)
        {
            SetupMessage(message, title, responsetype, showdontshow);
            this.ShowDialog();
            showdontshow = this._chk_dont_show.Checked;
            return this.DialogResult;
        }
        public DialogResult ShowMessage(string message, string title, MessageButtonType responsetype, ref bool showdontshow, string yestext, string notext, string canceltext, string oktext)
        {
            SetButtonText(yestext, notext, canceltext, oktext);
            return ShowMessage(message,title, responsetype, ref showdontshow);
        }
        public DialogResult ShowMessage(Message message, MessageButtonType responsetype, ref bool showdontshow, string yestext, string notext, string canceltext, string oktext)
        {
            SetButtonText(yestext, notext, canceltext, oktext);
            return ShowMessage(message.Info, message.Title, responsetype, ref showdontshow);
        }
        public void RunTips(List<Message> messages,ref bool showdontshow)
        {
            string _folder = Path.Combine(Application.StartupPath,"Help");
            if(!Directory.Exists(_folder))
                Directory.CreateDirectory(_folder);

            SetButtonText("Next Tip", "Close", "", "");
            this.FormBorderStyle = FormBorderStyle.Sizable;
            this.Size = new Size(450, 450);
            this.Text = ProductSettings.ProductName + " - Tips";
            this.ControlBox = false;
            this.DontCloseOnClick = true;
            this._web_browser.ScrollBarsEnabled = true;
            this._web_browser.Dock = DockStyle.Fill;
            this._web_browser.Visible = true;
            this._web_browser.BringToFront();
            this._chk_dont_show.Visible = showdontshow;
            this._pan_yes_no.BringToFront();
            this._hdp_header.Title = ProductSettings.ProductName; //title;
            int i = 0;
            while (this.DialogResult != DialogResult.No)
            {
                this._hdp_header.SubTitle = messages[i].Title;
                string _file = "";
                if(!HelpGenerator.HelpFileExist(messages[i],out _file))
                {
                    _file = HelpGenerator.GenerateHTML(messages[i]);
                }
                this._web_browser.Url = new Uri(_file, UriKind.Absolute);
                this.ShowDialog();
                showdontshow = this._chk_dont_show.Checked;
                i += 1;
                if (i >= messages.Count) i = 0;
            }
            this.Close();
        }
        private void AzzetonMessageBox_Load(object sender, EventArgs e)
        {
           
        }


    }
    public static class AzzetonMessage
    {
        public static DialogResult ShowMessage(string message, string msgcode, string title, MessageButtonType responsetype,bool showdontshow)
        {
            DialogResult _result = new AzzetonMessageBox().ShowMessage(message, title, responsetype,ref showdontshow);
            //if(showdontshow)
            AddUserConfiguration<bool>(msgcode, !showdontshow);
            return _result;       
        }
        public static DialogResult ShowMessage(string message, string msgcode, string title, MessageButtonType responsetype,bool showdontshow, string yestext, string notext, string canceltext, string oktext)
        {
            DialogResult _result = new AzzetonMessageBox().ShowMessage(message, title, responsetype,ref showdontshow, yestext, notext, canceltext, oktext);
            //if (showdontshow)
            AddUserConfiguration<bool>(msgcode, !showdontshow);
            return _result;     
        }
        public static IUser CurrentUser { get; set; }
       // public static IUserSettingManager UserSettingManager { get; set; }
        public static void AddUserConfiguration<T>(string title, object value)
        {
            try
            {
               //// IUserSettingManager _manager = UserSettingManager;
               // IUserSetting _config;
               // //T _obj = Activator.CreateInstance<T>();
               // T _obj = (T)value;
               // //_config = _manager.CreateSetting();
               // _config.UserID = CurrentUser.Id;
               // _config.Setting = UserSettingTitle.DontShowMessageBox +  title;
               // _config.Value = Serializer.Serialize<T>(_obj);
               // //_manager.Add(_config);
            }
            catch (Exception ex)
            {
                FileSystemLogger.WriteLog(System.Reflection.MethodBase.GetCurrentMethod(), ex, DateTime.Now);
            }
        }
        public static void ShowTips(List<Message> tips,bool showdontshow)
        {
            new AzzetonMessageBox().RunTips(tips,ref showdontshow);
            AddUserConfiguration<bool>("TIP001", !showdontshow);
        }
    }
}