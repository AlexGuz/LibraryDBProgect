using LibraryDBProgect;

namespace ClientSide
{
    partial class RegisterForm
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
            this.tbSurname = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.lbSurname = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.tbComfirmPassword = new System.Windows.Forms.TextBox();
            this.labelRegConfPaswd = new System.Windows.Forms.Label();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonOk = new System.Windows.Forms.Button();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.tbLogin = new System.Windows.Forms.TextBox();
            this.labelRegPassord = new System.Windows.Forms.Label();
            this.labelRegLogin = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbSurname
            // 
            this.tbSurname.Location = new System.Drawing.Point(151, 68);
            this.tbSurname.Name = "tbSurname";
            this.tbSurname.Size = new System.Drawing.Size(178, 20);
            this.tbSurname.TabIndex = 23;
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(151, 31);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(178, 20);
            this.tbName.TabIndex = 22;
            // 
            // lbSurname
            // 
            this.lbSurname.AutoSize = true;
            this.lbSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbSurname.Location = new System.Drawing.Point(12, 68);
            this.lbSurname.Name = "lbSurname";
            this.lbSurname.Size = new System.Drawing.Size(65, 17);
            this.lbSurname.TabIndex = 21;
            this.lbSurname.Text = "Surname";
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbName.Location = new System.Drawing.Point(12, 31);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(45, 17);
            this.lbName.TabIndex = 20;
            this.lbName.Text = "Name";
            // 
            // tbComfirmPassword
            // 
            this.tbComfirmPassword.Location = new System.Drawing.Point(151, 176);
            this.tbComfirmPassword.Name = "tbComfirmPassword";
            this.tbComfirmPassword.Size = new System.Drawing.Size(178, 20);
            this.tbComfirmPassword.TabIndex = 19;
            // 
            // labelRegConfPaswd
            // 
            this.labelRegConfPaswd.AutoSize = true;
            this.labelRegConfPaswd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelRegConfPaswd.Location = new System.Drawing.Point(12, 179);
            this.labelRegConfPaswd.Name = "labelRegConfPaswd";
            this.labelRegConfPaswd.Size = new System.Drawing.Size(120, 17);
            this.labelRegConfPaswd.TabIndex = 18;
            this.labelRegConfPaswd.Text = "Confirm password";
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(212, 224);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 17;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonOk
            // 
            this.buttonOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonOk.Location = new System.Drawing.Point(57, 224);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(75, 23);
            this.buttonOk.TabIndex = 16;
            this.buttonOk.Text = "OK";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(151, 141);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(178, 20);
            this.tbPassword.TabIndex = 15;
            // 
            // tbLogin
            // 
            this.tbLogin.Location = new System.Drawing.Point(151, 104);
            this.tbLogin.Name = "tbLogin";
            this.tbLogin.Size = new System.Drawing.Size(178, 20);
            this.tbLogin.TabIndex = 14;
            // 
            // labelRegPassord
            // 
            this.labelRegPassord.AutoSize = true;
            this.labelRegPassord.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelRegPassord.Location = new System.Drawing.Point(12, 141);
            this.labelRegPassord.Name = "labelRegPassord";
            this.labelRegPassord.Size = new System.Drawing.Size(69, 17);
            this.labelRegPassord.TabIndex = 13;
            this.labelRegPassord.Text = "Password";
            // 
            // labelRegLogin
            // 
            this.labelRegLogin.AutoSize = true;
            this.labelRegLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelRegLogin.Location = new System.Drawing.Point(12, 104);
            this.labelRegLogin.Name = "labelRegLogin";
            this.labelRegLogin.Size = new System.Drawing.Size(43, 17);
            this.labelRegLogin.TabIndex = 12;
            this.labelRegLogin.Text = "Login";
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(338, 260);
            this.Controls.Add(this.tbSurname);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.lbSurname);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.tbComfirmPassword);
            this.Controls.Add(this.labelRegConfPaswd);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.tbLogin);
            this.Controls.Add(this.labelRegPassord);
            this.Controls.Add(this.labelRegLogin);
            this.Name = "RegisterForm";
            this.Text = "RegisterForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected internal System.Windows.Forms.TextBox tbSurname;
        protected internal System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label lbSurname;
        private System.Windows.Forms.Label lbName;
        protected internal System.Windows.Forms.TextBox tbComfirmPassword;
        private System.Windows.Forms.Label labelRegConfPaswd;
        private System.Windows.Forms.Button buttonCancel;
        protected internal System.Windows.Forms.Button buttonOk;
        protected internal System.Windows.Forms.TextBox tbPassword;
        protected internal System.Windows.Forms.TextBox tbLogin;
        private System.Windows.Forms.Label labelRegPassord;
        private System.Windows.Forms.Label labelRegLogin;
        private LibraryContext db;

        public RegisterForm(LibraryContext db)
        {
            this.db = db;
            InitializeComponent();
        }
    }
}