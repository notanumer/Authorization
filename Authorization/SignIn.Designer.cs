namespace Authorization
{
    partial class SignIn
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
            this.signUpBtn = new System.Windows.Forms.Button();
            this.loginTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pswTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.signInLbl = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // signUpBtn
            // 
            this.signUpBtn.Location = new System.Drawing.Point(293, 270);
            this.signUpBtn.Name = "signUpBtn";
            this.signUpBtn.Size = new System.Drawing.Size(185, 58);
            this.signUpBtn.TabIndex = 9;
            this.signUpBtn.Text = "Войти";
            this.signUpBtn.UseVisualStyleBackColor = true;
            this.signUpBtn.Click += new System.EventHandler(this.SignUpBtn_Click);
            // 
            // loginTextBox
            // 
            this.loginTextBox.Location = new System.Drawing.Point(262, 122);
            this.loginTextBox.Name = "loginTextBox";
            this.loginTextBox.Size = new System.Drawing.Size(258, 27);
            this.loginTextBox.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(262, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(242, 35);
            this.label2.TabIndex = 7;
            this.label2.Text = "Введите логин";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pswTextBox
            // 
            this.pswTextBox.Location = new System.Drawing.Point(262, 215);
            this.pswTextBox.Name = "pswTextBox";
            this.pswTextBox.Size = new System.Drawing.Size(258, 27);
            this.pswTextBox.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(262, 167);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(242, 35);
            this.label1.TabIndex = 5;
            this.label1.Text = "Введите пароль";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // signInLbl
            // 
            this.signInLbl.Location = new System.Drawing.Point(302, 349);
            this.signInLbl.Name = "signInLbl";
            this.signInLbl.Size = new System.Drawing.Size(163, 49);
            this.signInLbl.TabIndex = 10;
            this.signInLbl.TabStop = true;
            this.signInLbl.Text = "Еще нет аккаунта? Зарегестрироваться";
            this.signInLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.signInLbl.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.SignInLbl_LinkClicked);
            // 
            // SignIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 453);
            this.Controls.Add(this.signInLbl);
            this.Controls.Add(this.signUpBtn);
            this.Controls.Add(this.loginTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pswTextBox);
            this.Controls.Add(this.label1);
            this.Name = "SignIn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "My company";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button signUpBtn;
        private TextBox loginTextBox;
        private Label label2;
        private TextBox pswTextBox;
        private Label label1;
        private LinkLabel signInLbl;
    }
}