namespace DAMau_Presentation.views
{
    partial class LoginView
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
            label1=new Label();
            txtBox_username=new TextBox();
            txtBox_password=new TextBox();
            label2=new Label();
            label3=new Label();
            checkBox_remember=new CheckBox();
            linkLabel_ForgotPass=new LinkLabel();
            btn_Login=new Button();
            linkLabel_Exit=new LinkLabel();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize=true;
            label1.Font=new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location=new Point(59, 23);
            label1.Name="label1";
            label1.Size=new Size(167, 21);
            label1.TabIndex=0;
            label1.Text="Đăng nhập hệ thống";
            // 
            // txtBox_username
            // 
            txtBox_username.Location=new Point(29, 76);
            txtBox_username.Name="txtBox_username";
            txtBox_username.Size=new Size(233, 23);
            txtBox_username.TabIndex=1;
            // 
            // txtBox_password
            // 
            txtBox_password.Location=new Point(29, 137);
            txtBox_password.Name="txtBox_password";
            txtBox_password.Size=new Size(233, 23);
            txtBox_password.TabIndex=2;
            // 
            // label2
            // 
            label2.AutoSize=true;
            label2.Location=new Point(29, 58);
            label2.Name="label2";
            label2.Size=new Size(36, 15);
            label2.TabIndex=3;
            label2.Text="Email";
            // 
            // label3
            // 
            label3.AutoSize=true;
            label3.Location=new Point(29, 119);
            label3.Name="label3";
            label3.Size=new Size(57, 15);
            label3.TabIndex=4;
            label3.Text="Mật khẩu";
            // 
            // checkBox_remember
            // 
            checkBox_remember.AutoSize=true;
            checkBox_remember.Location=new Point(29, 178);
            checkBox_remember.Name="checkBox_remember";
            checkBox_remember.Size=new Size(121, 19);
            checkBox_remember.TabIndex=5;
            checkBox_remember.Text="Ghi nhớ mật khẩu";
            checkBox_remember.UseVisualStyleBackColor=true;
            // 
            // linkLabel_ForgotPass
            // 
            linkLabel_ForgotPass.AutoSize=true;
            linkLabel_ForgotPass.Location=new Point(168, 179);
            linkLabel_ForgotPass.Name="linkLabel_ForgotPass";
            linkLabel_ForgotPass.Size=new Size(94, 15);
            linkLabel_ForgotPass.TabIndex=6;
            linkLabel_ForgotPass.TabStop=true;
            linkLabel_ForgotPass.Text="Quên mật khẩu?";
            // 
            // btn_Login
            // 
            btn_Login.Location=new Point(70, 212);
            btn_Login.Name="btn_Login";
            btn_Login.Size=new Size(156, 23);
            btn_Login.TabIndex=7;
            btn_Login.Text="Đăng nhập";
            btn_Login.UseVisualStyleBackColor=true;
            // 
            // linkLabel_Exit
            // 
            linkLabel_Exit.AutoSize=true;
            linkLabel_Exit.Location=new Point(127, 244);
            linkLabel_Exit.Name="linkLabel_Exit";
            linkLabel_Exit.Size=new Size(37, 15);
            linkLabel_Exit.TabIndex=8;
            linkLabel_Exit.TabStop=true;
            linkLabel_Exit.Text="Thoát";
            // 
            // LoginView
            // 
            AutoScaleDimensions=new SizeF(7F, 15F);
            AutoScaleMode=AutoScaleMode.Font;
            ClientSize=new Size(304, 268);
            Controls.Add(linkLabel_Exit);
            Controls.Add(btn_Login);
            Controls.Add(linkLabel_ForgotPass);
            Controls.Add(checkBox_remember);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtBox_password);
            Controls.Add(txtBox_username);
            Controls.Add(label1);
            Name="LoginView";
            StartPosition=FormStartPosition.CenterScreen;
            Text="Đăng nhập";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtBox_username;
        private TextBox txtBox_password;
        private Label label2;
        private Label label3;
        private CheckBox checkBox_remember;
        private LinkLabel linkLabel_ForgotPass;
        private Button btn_Login;
        private LinkLabel linkLabel_Exit;
    }
}