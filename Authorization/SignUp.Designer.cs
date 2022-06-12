namespace Authorization
{
    partial class SignUp
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.paswordTxt = new System.Windows.Forms.TextBox();
            this.loginTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.signUpBtn = new System.Windows.Forms.Button();
            this.signInLbl = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(269, 176);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(242, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "Введите пароль";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // paswordTxt
            // 
            this.paswordTxt.Location = new System.Drawing.Point(269, 224);
            this.paswordTxt.Name = "paswordTxt";
            this.paswordTxt.Size = new System.Drawing.Size(258, 27);
            this.paswordTxt.TabIndex = 1;
            // 
            // loginTxt
            // 
            this.loginTxt.Location = new System.Drawing.Point(269, 131);
            this.loginTxt.Name = "loginTxt";
            this.loginTxt.Size = new System.Drawing.Size(258, 27);
            this.loginTxt.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(269, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(242, 35);
            this.label2.TabIndex = 2;
            this.label2.Text = "Введите логин";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // signUpBtn
            // 
            this.signUpBtn.Location = new System.Drawing.Point(300, 279);
            this.signUpBtn.Name = "signUpBtn";
            this.signUpBtn.Size = new System.Drawing.Size(185, 58);
            this.signUpBtn.TabIndex = 4;
            this.signUpBtn.Text = "Зарегестрироваться";
            this.signUpBtn.UseVisualStyleBackColor = true;
            this.signUpBtn.Click += new System.EventHandler(this.SignUpBtn_Click);
            // 
            // signInLbl
            // 
            this.signInLbl.Location = new System.Drawing.Point(318, 360);
            this.signInLbl.Name = "signInLbl";
            this.signInLbl.Size = new System.Drawing.Size(148, 49);
            this.signInLbl.TabIndex = 5;
            this.signInLbl.TabStop = true;
            this.signInLbl.Text = "Уже есть аккаунт? Войти";
            this.signInLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.signInLbl.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabel1_LinkClicked);
            // 
            // SignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 453);
            this.Controls.Add(this.signInLbl);
            this.Controls.Add(this.signUpBtn);
            this.Controls.Add(this.loginTxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.paswordTxt);
            this.Controls.Add(this.label1);
            this.Name = "SignUp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MyCompany";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox paswordTxt;
        private TextBox loginTxt;
        private Label label2;
        private Button signUpBtn;
        private LinkLabel signInLbl;
    }
}