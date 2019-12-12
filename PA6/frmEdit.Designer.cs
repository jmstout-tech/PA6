namespace PA6
{
    partial class frmEdit
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
            this.txtLengthData = new System.Windows.Forms.TextBox();
            this.Length = new System.Windows.Forms.Label();
            this.txtISBNData = new System.Windows.Forms.TextBox();
            this.ISBN = new System.Windows.Forms.Label();
            this.txtCopiesData = new System.Windows.Forms.TextBox();
            this.CopiesAvailable = new System.Windows.Forms.Label();
            this.txtGenreData = new System.Windows.Forms.TextBox();
            this.Genre = new System.Windows.Forms.Label();
            this.txtAuthorData = new System.Windows.Forms.TextBox();
            this.Author = new System.Windows.Forms.Label();
            this.txtTitleData = new System.Windows.Forms.TextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtCoverData = new System.Windows.Forms.TextBox();
            this.lblCover = new System.Windows.Forms.Label();
            this.pbCover = new System.Windows.Forms.PictureBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbCover)).BeginInit();
            this.SuspendLayout();
            // 
            // txtLengthData
            // 
            this.txtLengthData.Location = new System.Drawing.Point(30, 546);
            this.txtLengthData.Name = "txtLengthData";
            this.txtLengthData.Size = new System.Drawing.Size(198, 34);
            this.txtLengthData.TabIndex = 23;
            // 
            // Length
            // 
            this.Length.AutoSize = true;
            this.Length.Location = new System.Drawing.Point(25, 514);
            this.Length.Name = "Length";
            this.Length.Size = new System.Drawing.Size(86, 29);
            this.Length.TabIndex = 22;
            this.Length.Text = "Length";
            // 
            // txtISBNData
            // 
            this.txtISBNData.Location = new System.Drawing.Point(30, 445);
            this.txtISBNData.Name = "txtISBNData";
            this.txtISBNData.Size = new System.Drawing.Size(198, 34);
            this.txtISBNData.TabIndex = 21;
            // 
            // ISBN
            // 
            this.ISBN.AutoSize = true;
            this.ISBN.Location = new System.Drawing.Point(25, 413);
            this.ISBN.Name = "ISBN";
            this.ISBN.Size = new System.Drawing.Size(69, 29);
            this.ISBN.TabIndex = 20;
            this.ISBN.Text = "ISBN";
            // 
            // txtCopiesData
            // 
            this.txtCopiesData.Location = new System.Drawing.Point(30, 336);
            this.txtCopiesData.Name = "txtCopiesData";
            this.txtCopiesData.Size = new System.Drawing.Size(198, 34);
            this.txtCopiesData.TabIndex = 19;
            // 
            // CopiesAvailable
            // 
            this.CopiesAvailable.AutoSize = true;
            this.CopiesAvailable.Location = new System.Drawing.Point(25, 304);
            this.CopiesAvailable.Name = "CopiesAvailable";
            this.CopiesAvailable.Size = new System.Drawing.Size(188, 29);
            this.CopiesAvailable.TabIndex = 18;
            this.CopiesAvailable.Text = "CopiesAvailable";
            // 
            // txtGenreData
            // 
            this.txtGenreData.Location = new System.Drawing.Point(30, 243);
            this.txtGenreData.Name = "txtGenreData";
            this.txtGenreData.Size = new System.Drawing.Size(198, 34);
            this.txtGenreData.TabIndex = 17;
            // 
            // Genre
            // 
            this.Genre.AutoSize = true;
            this.Genre.Location = new System.Drawing.Point(25, 211);
            this.Genre.Name = "Genre";
            this.Genre.Size = new System.Drawing.Size(80, 29);
            this.Genre.TabIndex = 16;
            this.Genre.Text = "Genre";
            // 
            // txtAuthorData
            // 
            this.txtAuthorData.Location = new System.Drawing.Point(30, 151);
            this.txtAuthorData.Name = "txtAuthorData";
            this.txtAuthorData.Size = new System.Drawing.Size(198, 34);
            this.txtAuthorData.TabIndex = 15;
            // 
            // Author
            // 
            this.Author.AutoSize = true;
            this.Author.Location = new System.Drawing.Point(25, 119);
            this.Author.Name = "Author";
            this.Author.Size = new System.Drawing.Size(82, 29);
            this.Author.TabIndex = 14;
            this.Author.Text = "Author";
            // 
            // txtTitleData
            // 
            this.txtTitleData.Location = new System.Drawing.Point(30, 56);
            this.txtTitleData.Name = "txtTitleData";
            this.txtTitleData.Size = new System.Drawing.Size(198, 34);
            this.txtTitleData.TabIndex = 13;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(25, 24);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(61, 29);
            this.lblTitle.TabIndex = 12;
            this.lblTitle.Text = "Title";
            // 
            // txtCoverData
            // 
            this.txtCoverData.Location = new System.Drawing.Point(30, 633);
            this.txtCoverData.Name = "txtCoverData";
            this.txtCoverData.Size = new System.Drawing.Size(198, 34);
            this.txtCoverData.TabIndex = 25;
            this.txtCoverData.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lblCover
            // 
            this.lblCover.AutoSize = true;
            this.lblCover.Location = new System.Drawing.Point(25, 601);
            this.lblCover.Name = "lblCover";
            this.lblCover.Size = new System.Drawing.Size(124, 29);
            this.lblCover.TabIndex = 24;
            this.lblCover.Text = "CoverURL";
            this.lblCover.Click += new System.EventHandler(this.label1_Click);
            // 
            // pbCover
            // 
            this.pbCover.Location = new System.Drawing.Point(487, 37);
            this.pbCover.Name = "pbCover";
            this.pbCover.Size = new System.Drawing.Size(317, 423);
            this.pbCover.TabIndex = 26;
            this.pbCover.TabStop = false;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(487, 501);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(154, 96);
            this.btnSave.TabIndex = 27;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(680, 501);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(154, 96);
            this.btnClose.TabIndex = 28;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(873, 691);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.pbCover);
            this.Controls.Add(this.txtCoverData);
            this.Controls.Add(this.lblCover);
            this.Controls.Add(this.txtLengthData);
            this.Controls.Add(this.Length);
            this.Controls.Add(this.txtISBNData);
            this.Controls.Add(this.ISBN);
            this.Controls.Add(this.txtCopiesData);
            this.Controls.Add(this.CopiesAvailable);
            this.Controls.Add(this.txtGenreData);
            this.Controls.Add(this.Genre);
            this.Controls.Add(this.txtAuthorData);
            this.Controls.Add(this.Author);
            this.Controls.Add(this.txtTitleData);
            this.Controls.Add(this.lblTitle);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "frmEdit";
            this.Text = "frmEdit";
            this.Load += new System.EventHandler(this.frmEdit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbCover)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtLengthData;
        private System.Windows.Forms.Label Length;
        private System.Windows.Forms.TextBox txtISBNData;
        private System.Windows.Forms.Label ISBN;
        private System.Windows.Forms.TextBox txtCopiesData;
        private System.Windows.Forms.Label CopiesAvailable;
        private System.Windows.Forms.TextBox txtGenreData;
        private System.Windows.Forms.Label Genre;
        private System.Windows.Forms.TextBox txtAuthorData;
        private System.Windows.Forms.Label Author;
        private System.Windows.Forms.TextBox txtTitleData;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtCoverData;
        private System.Windows.Forms.Label lblCover;
        private System.Windows.Forms.PictureBox pbCover;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClose;
    }
}