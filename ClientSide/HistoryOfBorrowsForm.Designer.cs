namespace ClientSide
{
    partial class HistoryOfBorrowsForm
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
            this.dgvBorrowsBooks = new System.Windows.Forms.DataGridView();
            this.btnClose = new System.Windows.Forms.Button();
            this.borrowBookBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.BookId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Book = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AutorName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Borrowed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IsReturned = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBorrowsBooks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.borrowBookBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvBorrowsBooks
            // 
            this.dgvBorrowsBooks.AutoGenerateColumns = false;
            this.dgvBorrowsBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBorrowsBooks.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BookId,
            this.Book,
            this.AutorName,
            this.Borrowed,
            this.IsReturned});
            this.dgvBorrowsBooks.DataSource = this.borrowBookBindingSource;
            this.dgvBorrowsBooks.Location = new System.Drawing.Point(12, 12);
            this.dgvBorrowsBooks.Name = "dgvBorrowsBooks";
            this.dgvBorrowsBooks.Size = new System.Drawing.Size(561, 232);
            this.dgvBorrowsBooks.TabIndex = 7;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(253, 269);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 15;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // borrowBookBindingSource
            // 
            this.borrowBookBindingSource.DataSource = typeof(LibraryDBProgect.BorrowBook);
            // 
            // BookId
            // 
            this.BookId.DataPropertyName = "BookId";
            this.BookId.HeaderText = "BookId";
            this.BookId.Name = "BookId";
            // 
            // Book
            // 
            this.Book.DataPropertyName = "Book";
            this.Book.HeaderText = "Book";
            this.Book.Name = "Book";
            // 
            // AutorName
            // 
            this.AutorName.DataPropertyName = "AutorName";
            this.AutorName.HeaderText = "AutorName";
            this.AutorName.Name = "AutorName";
            // 
            // Borrowed
            // 
            this.Borrowed.DataPropertyName = "Borrowed";
            this.Borrowed.HeaderText = "Borrowed";
            this.Borrowed.Name = "Borrowed";
            // 
            // IsReturned
            // 
            this.IsReturned.DataPropertyName = "IsReturned";
            this.IsReturned.HeaderText = "Returned";
            this.IsReturned.Name = "IsReturned";
            // 
            // HistoryOfBorrowsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 304);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.dgvBorrowsBooks);
            this.Name = "HistoryOfBorrowsForm";
            this.Text = "HistoryOfBorrowsForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvBorrowsBooks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.borrowBookBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource borrowBookBindingSource;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Book;
        private System.Windows.Forms.DataGridViewTextBoxColumn AutorName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Borrowed;
        private System.Windows.Forms.DataGridViewCheckBoxColumn IsReturned;
        public System.Windows.Forms.DataGridView dgvBorrowsBooks;
    }
}