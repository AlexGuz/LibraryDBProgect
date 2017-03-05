namespace ClientSide
{
    partial class SearchForm
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
            this.lbGenre = new System.Windows.Forms.Label();
            this.lbAuthor = new System.Windows.Forms.Label();
            this.lbTitle = new System.Windows.Forms.Label();
            this.tbAuthor = new System.Windows.Forms.TextBox();
            this.tbTitle = new System.Windows.Forms.TextBox();
            this.btnBookSearchCancel = new System.Windows.Forms.Button();
            this.btnBookSearch = new System.Windows.Forms.Button();
            this.clbGenre = new System.Windows.Forms.CheckedListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbPublishing = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbSurname = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbGenre
            // 
            this.lbGenre.AutoSize = true;
            this.lbGenre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbGenre.Location = new System.Drawing.Point(35, 134);
            this.lbGenre.Name = "lbGenre";
            this.lbGenre.Size = new System.Drawing.Size(48, 17);
            this.lbGenre.TabIndex = 29;
            this.lbGenre.Text = "Genre";
            // 
            // lbAuthor
            // 
            this.lbAuthor.AutoSize = true;
            this.lbAuthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbAuthor.Location = new System.Drawing.Point(35, 52);
            this.lbAuthor.Name = "lbAuthor";
            this.lbAuthor.Size = new System.Drawing.Size(91, 17);
            this.lbAuthor.TabIndex = 28;
            this.lbAuthor.Text = "Author Name";
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbTitle.Location = new System.Drawing.Point(35, 18);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(35, 17);
            this.lbTitle.TabIndex = 27;
            this.lbTitle.Text = "Title";
            // 
            // tbAuthor
            // 
            this.tbAuthor.Location = new System.Drawing.Point(154, 49);
            this.tbAuthor.Name = "tbAuthor";
            this.tbAuthor.Size = new System.Drawing.Size(172, 20);
            this.tbAuthor.TabIndex = 26;
            // 
            // tbTitle
            // 
            this.tbTitle.Location = new System.Drawing.Point(154, 15);
            this.tbTitle.Name = "tbTitle";
            this.tbTitle.Size = new System.Drawing.Size(172, 20);
            this.tbTitle.TabIndex = 25;
            // 
            // btnBookSearchCancel
            // 
            this.btnBookSearchCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnBookSearchCancel.Location = new System.Drawing.Point(251, 290);
            this.btnBookSearchCancel.Name = "btnBookSearchCancel";
            this.btnBookSearchCancel.Size = new System.Drawing.Size(75, 23);
            this.btnBookSearchCancel.TabIndex = 23;
            this.btnBookSearchCancel.Text = "Cancel";
            this.btnBookSearchCancel.UseVisualStyleBackColor = true;
            // 
            // btnBookSearch
            // 
            this.btnBookSearch.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnBookSearch.Location = new System.Drawing.Point(154, 290);
            this.btnBookSearch.Name = "btnBookSearch";
            this.btnBookSearch.Size = new System.Drawing.Size(75, 23);
            this.btnBookSearch.TabIndex = 22;
            this.btnBookSearch.Text = "Search";
            this.btnBookSearch.UseVisualStyleBackColor = true;
            // 
            // clbGenre
            // 
            this.clbGenre.FormattingEnabled = true;
            this.clbGenre.Location = new System.Drawing.Point(154, 134);
            this.clbGenre.Name = "clbGenre";
            this.clbGenre.Size = new System.Drawing.Size(178, 94);
            this.clbGenre.TabIndex = 32;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(37, 250);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 17);
            this.label1.TabIndex = 30;
            this.label1.Text = "Release Date";
            // 
            // tbPublishing
            // 
            this.tbPublishing.Location = new System.Drawing.Point(154, 250);
            this.tbPublishing.Name = "tbPublishing";
            this.tbPublishing.Size = new System.Drawing.Size(172, 20);
            this.tbPublishing.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(35, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 17);
            this.label2.TabIndex = 34;
            this.label2.Text = "Author Surname";
            // 
            // tbSurname
            // 
            this.tbSurname.Location = new System.Drawing.Point(154, 83);
            this.tbSurname.Name = "tbSurname";
            this.tbSurname.Size = new System.Drawing.Size(172, 20);
            this.tbSurname.TabIndex = 33;
            // 
            // SearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 360);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbSurname);
            this.Controls.Add(this.clbGenre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbGenre);
            this.Controls.Add(this.lbAuthor);
            this.Controls.Add(this.lbTitle);
            this.Controls.Add(this.tbAuthor);
            this.Controls.Add(this.tbTitle);
            this.Controls.Add(this.tbPublishing);
            this.Controls.Add(this.btnBookSearchCancel);
            this.Controls.Add(this.btnBookSearch);
            this.Name = "SearchForm";
            this.Text = "SearchForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbGenre;
        private System.Windows.Forms.Label lbAuthor;
        private System.Windows.Forms.Label lbTitle;
        protected internal System.Windows.Forms.TextBox tbAuthor;
        protected internal System.Windows.Forms.TextBox tbTitle;
        protected internal System.Windows.Forms.Button btnBookSearchCancel;
        protected internal System.Windows.Forms.Button btnBookSearch;
        private System.Windows.Forms.Label label1;
        protected internal System.Windows.Forms.TextBox tbPublishing;
        private System.Windows.Forms.Label label2;
        protected internal System.Windows.Forms.TextBox tbSurname;
        public System.Windows.Forms.CheckedListBox clbGenre;
    }
}