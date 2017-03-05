namespace LibrarySide
{
    partial class MainForm
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
            this.dgvBooks = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.releaseDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.autorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnBookDelete = new System.Windows.Forms.Button();
            this.btnShowAllBooks = new System.Windows.Forms.Button();
            this.btnBookAdd = new System.Windows.Forms.Button();
            this.btnFindBook = new System.Windows.Forms.Button();
            this.btnBookChange = new System.Windows.Forms.Button();
            this.btnShowAllAutors = new System.Windows.Forms.Button();
            this.dgvAutors = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.surnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.autorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnAuthorAdd = new System.Windows.Forms.Button();
            this.btnAuthorSearch = new System.Windows.Forms.Button();
            this.btnAuthorChange = new System.Windows.Forms.Button();
            this.btnAuthorDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBooks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAutors)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.autorBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvBooks
            // 
            this.dgvBooks.AllowUserToAddRows = false;
            this.dgvBooks.AllowUserToDeleteRows = false;
            this.dgvBooks.AutoGenerateColumns = false;
            this.dgvBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBooks.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.titleDataGridViewTextBoxColumn,
            this.releaseDateDataGridViewTextBoxColumn,
            this.genreDataGridViewTextBoxColumn,
            this.autorDataGridViewTextBoxColumn,
            this.clientDataGridViewTextBoxColumn});
            this.dgvBooks.DataSource = this.bookBindingSource;
            this.dgvBooks.Location = new System.Drawing.Point(12, 12);
            this.dgvBooks.Name = "dgvBooks";
            this.dgvBooks.ReadOnly = true;
            this.dgvBooks.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBooks.Size = new System.Drawing.Size(655, 223);
            this.dgvBooks.TabIndex = 13;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // titleDataGridViewTextBoxColumn
            // 
            this.titleDataGridViewTextBoxColumn.DataPropertyName = "Title";
            this.titleDataGridViewTextBoxColumn.HeaderText = "Title";
            this.titleDataGridViewTextBoxColumn.Name = "titleDataGridViewTextBoxColumn";
            this.titleDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // releaseDateDataGridViewTextBoxColumn
            // 
            this.releaseDateDataGridViewTextBoxColumn.DataPropertyName = "ReleaseDate";
            this.releaseDateDataGridViewTextBoxColumn.HeaderText = "ReleaseDate";
            this.releaseDateDataGridViewTextBoxColumn.Name = "releaseDateDataGridViewTextBoxColumn";
            this.releaseDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // genreDataGridViewTextBoxColumn
            // 
            this.genreDataGridViewTextBoxColumn.DataPropertyName = "Genre";
            this.genreDataGridViewTextBoxColumn.HeaderText = "Genre";
            this.genreDataGridViewTextBoxColumn.Name = "genreDataGridViewTextBoxColumn";
            this.genreDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // autorDataGridViewTextBoxColumn
            // 
            this.autorDataGridViewTextBoxColumn.DataPropertyName = "Autor";
            this.autorDataGridViewTextBoxColumn.HeaderText = "Autor";
            this.autorDataGridViewTextBoxColumn.Name = "autorDataGridViewTextBoxColumn";
            this.autorDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // clientDataGridViewTextBoxColumn
            // 
            this.clientDataGridViewTextBoxColumn.DataPropertyName = "Client";
            this.clientDataGridViewTextBoxColumn.HeaderText = "Client";
            this.clientDataGridViewTextBoxColumn.Name = "clientDataGridViewTextBoxColumn";
            this.clientDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bookBindingSource
            // 
            this.bookBindingSource.DataSource = typeof(LibraryDBProgect.Book);
            // 
            // btnBookDelete
            // 
            this.btnBookDelete.Location = new System.Drawing.Point(694, 137);
            this.btnBookDelete.Name = "btnBookDelete";
            this.btnBookDelete.Size = new System.Drawing.Size(95, 23);
            this.btnBookDelete.TabIndex = 16;
            this.btnBookDelete.Text = "Delete";
            this.btnBookDelete.UseVisualStyleBackColor = true;
            this.btnBookDelete.Click += new System.EventHandler(this.btnBookDelete_Click);
            // 
            // btnShowAllBooks
            // 
            this.btnShowAllBooks.Location = new System.Drawing.Point(694, 12);
            this.btnShowAllBooks.Name = "btnShowAllBooks";
            this.btnShowAllBooks.Size = new System.Drawing.Size(95, 23);
            this.btnShowAllBooks.TabIndex = 18;
            this.btnShowAllBooks.Text = "Show all books";
            this.btnShowAllBooks.UseVisualStyleBackColor = true;
            this.btnShowAllBooks.Click += new System.EventHandler(this.btnShowAllBooks_Click);
            // 
            // btnBookAdd
            // 
            this.btnBookAdd.Location = new System.Drawing.Point(694, 52);
            this.btnBookAdd.Name = "btnBookAdd";
            this.btnBookAdd.Size = new System.Drawing.Size(95, 23);
            this.btnBookAdd.TabIndex = 14;
            this.btnBookAdd.Text = "Add ";
            this.btnBookAdd.UseVisualStyleBackColor = true;
            this.btnBookAdd.Click += new System.EventHandler(this.btnBookAdd_Click);
            // 
            // btnFindBook
            // 
            this.btnFindBook.Location = new System.Drawing.Point(694, 181);
            this.btnFindBook.Name = "btnFindBook";
            this.btnFindBook.Size = new System.Drawing.Size(95, 23);
            this.btnFindBook.TabIndex = 17;
            this.btnFindBook.Text = "Find book";
            this.btnFindBook.UseVisualStyleBackColor = true;
            this.btnFindBook.Click += new System.EventHandler(this.btnFindBook_Click);
            // 
            // btnBookChange
            // 
            this.btnBookChange.Location = new System.Drawing.Point(694, 94);
            this.btnBookChange.Name = "btnBookChange";
            this.btnBookChange.Size = new System.Drawing.Size(95, 23);
            this.btnBookChange.TabIndex = 15;
            this.btnBookChange.Text = "Change";
            this.btnBookChange.UseVisualStyleBackColor = true;
            this.btnBookChange.Click += new System.EventHandler(this.btnBookChange_Click);
            // 
            // btnShowAllAutors
            // 
            this.btnShowAllAutors.Location = new System.Drawing.Point(694, 262);
            this.btnShowAllAutors.Name = "btnShowAllAutors";
            this.btnShowAllAutors.Size = new System.Drawing.Size(95, 23);
            this.btnShowAllAutors.TabIndex = 24;
            this.btnShowAllAutors.Text = "Show all Autors";
            this.btnShowAllAutors.UseVisualStyleBackColor = true;
            this.btnShowAllAutors.Click += new System.EventHandler(this.btnShowAllAutors_Click);
            // 
            // dgvAutors
            // 
            this.dgvAutors.AllowUserToAddRows = false;
            this.dgvAutors.AllowUserToDeleteRows = false;
            this.dgvAutors.AutoGenerateColumns = false;
            this.dgvAutors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAutors.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn1,
            this.nameDataGridViewTextBoxColumn,
            this.surnameDataGridViewTextBoxColumn});
            this.dgvAutors.DataSource = this.autorBindingSource;
            this.dgvAutors.Location = new System.Drawing.Point(12, 262);
            this.dgvAutors.Name = "dgvAutors";
            this.dgvAutors.RowHeadersWidth = 20;
            this.dgvAutors.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAutors.Size = new System.Drawing.Size(655, 220);
            this.dgvAutors.TabIndex = 19;
            // 
            // idDataGridViewTextBoxColumn1
            // 
            this.idDataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn1.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn1.Name = "idDataGridViewTextBoxColumn1";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // surnameDataGridViewTextBoxColumn
            // 
            this.surnameDataGridViewTextBoxColumn.DataPropertyName = "Surname";
            this.surnameDataGridViewTextBoxColumn.HeaderText = "Surname";
            this.surnameDataGridViewTextBoxColumn.Name = "surnameDataGridViewTextBoxColumn";
            // 
            // autorBindingSource
            // 
            this.autorBindingSource.DataSource = typeof(LibraryDBProgect.Autor);
            // 
            // btnAuthorAdd
            // 
            this.btnAuthorAdd.Location = new System.Drawing.Point(694, 306);
            this.btnAuthorAdd.Name = "btnAuthorAdd";
            this.btnAuthorAdd.Size = new System.Drawing.Size(95, 23);
            this.btnAuthorAdd.TabIndex = 20;
            this.btnAuthorAdd.Text = "Add ";
            this.btnAuthorAdd.UseVisualStyleBackColor = true;
            this.btnAuthorAdd.Click += new System.EventHandler(this.btnAuthorAdd_Click);
            // 
            // btnAuthorSearch
            // 
            this.btnAuthorSearch.Location = new System.Drawing.Point(694, 435);
            this.btnAuthorSearch.Name = "btnAuthorSearch";
            this.btnAuthorSearch.Size = new System.Drawing.Size(95, 23);
            this.btnAuthorSearch.TabIndex = 23;
            this.btnAuthorSearch.Text = "Find Autor";
            this.btnAuthorSearch.UseVisualStyleBackColor = true;
            this.btnAuthorSearch.Click += new System.EventHandler(this.btnAuthorSearch_Click);
            // 
            // btnAuthorChange
            // 
            this.btnAuthorChange.Location = new System.Drawing.Point(694, 348);
            this.btnAuthorChange.Name = "btnAuthorChange";
            this.btnAuthorChange.Size = new System.Drawing.Size(95, 23);
            this.btnAuthorChange.TabIndex = 21;
            this.btnAuthorChange.Text = "Change";
            this.btnAuthorChange.UseVisualStyleBackColor = true;
            this.btnAuthorChange.Click += new System.EventHandler(this.btnAuthorChange_Click);
            // 
            // btnAuthorDelete
            // 
            this.btnAuthorDelete.Location = new System.Drawing.Point(694, 391);
            this.btnAuthorDelete.Name = "btnAuthorDelete";
            this.btnAuthorDelete.Size = new System.Drawing.Size(95, 23);
            this.btnAuthorDelete.TabIndex = 22;
            this.btnAuthorDelete.Text = "Delete";
            this.btnAuthorDelete.UseVisualStyleBackColor = true;
            this.btnAuthorDelete.Click += new System.EventHandler(this.btnAuthorDelete_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 516);
            this.Controls.Add(this.btnShowAllAutors);
            this.Controls.Add(this.dgvAutors);
            this.Controls.Add(this.btnAuthorAdd);
            this.Controls.Add(this.btnAuthorSearch);
            this.Controls.Add(this.btnAuthorChange);
            this.Controls.Add(this.btnAuthorDelete);
            this.Controls.Add(this.btnBookDelete);
            this.Controls.Add(this.btnShowAllBooks);
            this.Controls.Add(this.btnBookAdd);
            this.Controls.Add(this.btnFindBook);
            this.Controls.Add(this.btnBookChange);
            this.Controls.Add(this.dgvBooks);
            this.Name = "MainForm";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvBooks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAutors)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.autorBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        protected internal System.Windows.Forms.DataGridView dgvBooks;
        private System.Windows.Forms.Button btnBookDelete;
        private System.Windows.Forms.Button btnShowAllBooks;
        private System.Windows.Forms.Button btnBookAdd;
        private System.Windows.Forms.Button btnFindBook;
        private System.Windows.Forms.Button btnBookChange;
        private System.Windows.Forms.Button btnShowAllAutors;
        protected internal System.Windows.Forms.DataGridView dgvAutors;
        private System.Windows.Forms.Button btnAuthorAdd;
        private System.Windows.Forms.Button btnAuthorSearch;
        private System.Windows.Forms.Button btnAuthorChange;
        private System.Windows.Forms.Button btnAuthorDelete;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn releaseDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn autorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource bookBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn surnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource autorBindingSource;
    }
}

