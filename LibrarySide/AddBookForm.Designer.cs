using LibraryDBProgect;

namespace LibrarySide
{
    partial class AddBookForm
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
            this.labelBookGenre = new System.Windows.Forms.Label();
            this.cbGenre = new System.Windows.Forms.ComboBox();
            this.tbReleaseDate = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.labelTeam = new System.Windows.Forms.Label();
            this.lbTitle = new System.Windows.Forms.Label();
            this.lbAutor = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.tbTitle = new System.Windows.Forms.TextBox();
            this.cbAutor = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // labelBookGenre
            // 
            this.labelBookGenre.AutoSize = true;
            this.labelBookGenre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelBookGenre.Location = new System.Drawing.Point(12, 112);
            this.labelBookGenre.Name = "labelBookGenre";
            this.labelBookGenre.Size = new System.Drawing.Size(48, 17);
            this.labelBookGenre.TabIndex = 20;
            this.labelBookGenre.Text = "Genre";
            // 
            // cbGenre
            // 
            this.cbGenre.FormattingEnabled = true;
            this.cbGenre.Location = new System.Drawing.Point(118, 109);
            this.cbGenre.Name = "cbGenre";
            this.cbGenre.Size = new System.Drawing.Size(172, 21);
            this.cbGenre.TabIndex = 21;
            // 
            // tbReleaseDate
            // 
            this.tbReleaseDate.Location = new System.Drawing.Point(118, 159);
            this.tbReleaseDate.Name = "tbReleaseDate";
            this.tbReleaseDate.Size = new System.Drawing.Size(172, 20);
            this.tbReleaseDate.TabIndex = 19;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(215, 218);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 17;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // labelTeam
            // 
            this.labelTeam.AutoSize = true;
            this.labelTeam.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelTeam.Location = new System.Drawing.Point(12, 160);
            this.labelTeam.Name = "labelTeam";
            this.labelTeam.Size = new System.Drawing.Size(94, 17);
            this.labelTeam.TabIndex = 18;
            this.labelTeam.Text = "Release Date";
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbTitle.Location = new System.Drawing.Point(12, 22);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(35, 17);
            this.lbTitle.TabIndex = 12;
            this.lbTitle.Text = "Title";
            // 
            // lbAutor
            // 
            this.lbAutor.AutoSize = true;
            this.lbAutor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbAutor.Location = new System.Drawing.Point(12, 69);
            this.lbAutor.Name = "lbAutor";
            this.lbAutor.Size = new System.Drawing.Size(42, 17);
            this.lbAutor.TabIndex = 13;
            this.lbAutor.Text = "Autor";
            // 
            // btnOK
            // 
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Location = new System.Drawing.Point(118, 218);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 16;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // tbTitle
            // 
            this.tbTitle.Location = new System.Drawing.Point(118, 21);
            this.tbTitle.Name = "tbTitle";
            this.tbTitle.Size = new System.Drawing.Size(172, 20);
            this.tbTitle.TabIndex = 14;
            // 
            // cbAutor
            // 
            this.cbAutor.FormattingEnabled = true;
            this.cbAutor.Location = new System.Drawing.Point(118, 66);
            this.cbAutor.Name = "cbAutor";
            this.cbAutor.Size = new System.Drawing.Size(172, 21);
            this.cbAutor.TabIndex = 15;
            // 
            // AddBookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(343, 262);
            this.Controls.Add(this.labelBookGenre);
            this.Controls.Add(this.cbGenre);
            this.Controls.Add(this.tbReleaseDate);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.labelTeam);
            this.Controls.Add(this.lbTitle);
            this.Controls.Add(this.lbAutor);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.tbTitle);
            this.Controls.Add(this.cbAutor);
            this.Name = "AddBookForm";
            this.Text = "AddBookForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelBookGenre;
        protected internal System.Windows.Forms.ComboBox cbGenre;
        protected internal System.Windows.Forms.TextBox tbReleaseDate;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label labelTeam;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Label lbAutor;
        private System.Windows.Forms.Button btnOK;
        protected internal System.Windows.Forms.TextBox tbTitle;
        protected internal System.Windows.Forms.ComboBox cbAutor;
    }
}