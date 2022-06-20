namespace Client
{
    partial class ChatForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.userList = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.userMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.nameData = new System.Windows.Forms.Label();
            this.chatBox = new System.Windows.Forms.RichTextBox();
            this.nicknameData = new Guna.UI2.WinForms.Guna2TextBox();
            this.enterChat = new Guna.UI2.WinForms.Guna2Button();
            this.messageData = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.guna2AnimateWindow1 = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(291, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Для подключении к чату введите свой ник: ";
            // 
            // userList
            // 
            this.userList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.userList.Enabled = false;
            this.userList.FormattingEnabled = true;
            this.userList.ItemHeight = 16;
            this.userList.Location = new System.Drawing.Point(519, 65);
            this.userList.Margin = new System.Windows.Forms.Padding(4);
            this.userList.Name = "userList";
            this.userList.Size = new System.Drawing.Size(207, 388);
            this.userList.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 46);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Чат: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(523, 46);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(165, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Список пользователей: ";
            // 
            // userMenu
            // 
            this.userMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.userMenu.Name = "userMenu";
            this.userMenu.Size = new System.Drawing.Size(61, 4);
            // 
            // nameData
            // 
            this.nameData.AutoSize = true;
            this.nameData.Location = new System.Drawing.Point(59, 31);
            this.nameData.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.nameData.Name = "nameData";
            this.nameData.Size = new System.Drawing.Size(0, 16);
            this.nameData.TabIndex = 9;
            // 
            // chatBox
            // 
            this.chatBox.Enabled = false;
            this.chatBox.Location = new System.Drawing.Point(9, 65);
            this.chatBox.Margin = new System.Windows.Forms.Padding(4);
            this.chatBox.Name = "chatBox";
            this.chatBox.ReadOnly = true;
            this.chatBox.Size = new System.Drawing.Size(500, 357);
            this.chatBox.TabIndex = 3;
            this.chatBox.Text = "";
            // 
            // nicknameData
            // 
            this.nicknameData.BorderRadius = 25;
            this.nicknameData.BorderThickness = 2;
            this.nicknameData.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nicknameData.DefaultText = "";
            this.nicknameData.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.nicknameData.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.nicknameData.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.nicknameData.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.nicknameData.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.nicknameData.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.nicknameData.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.nicknameData.Location = new System.Drawing.Point(311, 10);
            this.nicknameData.Name = "nicknameData";
            this.nicknameData.PasswordChar = '\0';
            this.nicknameData.PlaceholderText = "";
            this.nicknameData.SelectedText = "";
            this.nicknameData.Size = new System.Drawing.Size(267, 31);
            this.nicknameData.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.nicknameData.TabIndex = 10;
            // 
            // enterChat
            // 
            this.enterChat.Animated = true;
            this.enterChat.BorderRadius = 15;
            this.enterChat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.enterChat.DefaultAutoSize = true;
            this.enterChat.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.enterChat.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.enterChat.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.enterChat.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.enterChat.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.enterChat.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.enterChat.ForeColor = System.Drawing.Color.White;
            this.enterChat.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.enterChat.Location = new System.Drawing.Point(583, 10);
            this.enterChat.Name = "enterChat";
            this.enterChat.ShadowDecoration.BorderRadius = 15;
            this.enterChat.Size = new System.Drawing.Size(126, 31);
            this.enterChat.TabIndex = 11;
            this.enterChat.Text = "Подключится";
            this.enterChat.Click += new System.EventHandler(this.enterChat_Click);
            // 
            // messageData
            // 
            this.messageData.BackColor = System.Drawing.Color.Transparent;
            this.messageData.BorderRadius = 50;
            this.messageData.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.messageData.DefaultText = "";
            this.messageData.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.messageData.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.messageData.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.messageData.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.messageData.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.messageData.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.messageData.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.messageData.Location = new System.Drawing.Point(15, 429);
            this.messageData.Name = "messageData";
            this.messageData.PasswordChar = '\0';
            this.messageData.PlaceholderText = "";
            this.messageData.SelectedText = "";
            this.messageData.ShadowDecoration.BorderRadius = 5;
            this.messageData.ShadowDecoration.Color = System.Drawing.Color.Silver;
            this.messageData.ShadowDecoration.Depth = 20;
            this.messageData.ShadowDecoration.Enabled = true;
            this.messageData.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(10);
            this.messageData.Size = new System.Drawing.Size(487, 31);
            this.messageData.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.messageData.TabIndex = 12;
            this.messageData.KeyUp += new System.Windows.Forms.KeyEventHandler(this.messageData_KeyUp);
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.AnimateWindow = true;
            this.guna2BorderlessForm1.AnimationType = Guna.UI2.WinForms.Guna2BorderlessForm.AnimateWindowType.AW_HOR_NEGATIVE;
            this.guna2BorderlessForm1.BorderRadius = 30;
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // guna2AnimateWindow1
            // 
            this.guna2AnimateWindow1.AnimationType = Guna.UI2.WinForms.Guna2AnimateWindow.AnimateWindowType.AW_HOR_POSITIVE;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.BalloonTipClicked += new System.EventHandler(this.notifyIcon1_BalloonTipClicked);
            // 
            // ChatForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ClientSize = new System.Drawing.Size(748, 505);
            this.Controls.Add(this.messageData);
            this.Controls.Add(this.enterChat);
            this.Controls.Add(this.nicknameData);
            this.Controls.Add(this.nameData);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.userList);
            this.Controls.Add(this.chatBox);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.HelpButton = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ChatForm";
            this.Text = "Chat";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ChatForm_FormClosing);
            this.Load += new System.EventHandler(this.ChatForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox userList;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ContextMenuStrip userMenu;
        private System.Windows.Forms.Label nameData;
        private System.Windows.Forms.RichTextBox chatBox;
        private Guna.UI2.WinForms.Guna2TextBox nicknameData;
        private Guna.UI2.WinForms.Guna2Button enterChat;
        private Guna.UI2.WinForms.Guna2TextBox messageData;
        private Guna.UI2.WinForms.Guna2AnimateWindow guna2AnimateWindow1;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
    }
}

