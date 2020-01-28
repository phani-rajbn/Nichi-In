namespace SampleConApp
{
    partial class BookStore
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lstBooks = new System.Windows.Forms.ListBox();
            this.pnUpdation = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.txtAuthor = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.pnAddition = new System.Windows.Forms.Panel();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtNewAuthor = new System.Windows.Forms.TextBox();
            this.txtNewTitle = new System.Windows.Forms.TextBox();
            this.txtNewId = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.pnUpdation.SuspendLayout();
            this.pnAddition.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Inconsolata", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(611, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(513, 78);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sapna Book House";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(212, 39);
            this.label2.TabIndex = 1;
            this.label2.Text = "List of Books";
            // 
            // lstBooks
            // 
            this.lstBooks.FormattingEnabled = true;
            this.lstBooks.ItemHeight = 39;
            this.lstBooks.Location = new System.Drawing.Point(12, 176);
            this.lstBooks.Name = "lstBooks";
            this.lstBooks.Size = new System.Drawing.Size(288, 511);
            this.lstBooks.TabIndex = 2;
            this.lstBooks.SelectedIndexChanged += new System.EventHandler(this.LstBooks_SelectedIndexChanged);
            // 
            // pnUpdation
            // 
            this.pnUpdation.Controls.Add(this.btnUpdate);
            this.pnUpdation.Controls.Add(this.txtAuthor);
            this.pnUpdation.Controls.Add(this.txtTitle);
            this.pnUpdation.Controls.Add(this.txtId);
            this.pnUpdation.Controls.Add(this.label6);
            this.pnUpdation.Controls.Add(this.label5);
            this.pnUpdation.Controls.Add(this.label4);
            this.pnUpdation.Controls.Add(this.label3);
            this.pnUpdation.Location = new System.Drawing.Point(530, 164);
            this.pnUpdation.Name = "pnUpdation";
            this.pnUpdation.Size = new System.Drawing.Size(1086, 274);
            this.pnUpdation.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(400, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(317, 39);
            this.label3.TabIndex = 0;
            this.label3.Text = "Details of the Book:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(102, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 39);
            this.label4.TabIndex = 1;
            this.label4.Text = "Book ID:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(57, 144);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(182, 39);
            this.label5.TabIndex = 2;
            this.label5.Text = "Book Title:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(42, 207);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(197, 39);
            this.label6.TabIndex = 3;
            this.label6.Text = "Book Author:";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(235, 81);
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(431, 39);
            this.txtId.TabIndex = 4;
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(235, 144);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(431, 39);
            this.txtTitle.TabIndex = 5;
            // 
            // txtAuthor
            // 
            this.txtAuthor.Location = new System.Drawing.Point(235, 207);
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.Size = new System.Drawing.Size(431, 39);
            this.txtAuthor.TabIndex = 6;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(753, 136);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(226, 61);
            this.btnUpdate.TabIndex = 7;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // pnAddition
            // 
            this.pnAddition.Controls.Add(this.btnSave);
            this.pnAddition.Controls.Add(this.txtNewAuthor);
            this.pnAddition.Controls.Add(this.txtNewTitle);
            this.pnAddition.Controls.Add(this.txtNewId);
            this.pnAddition.Controls.Add(this.label7);
            this.pnAddition.Controls.Add(this.label8);
            this.pnAddition.Controls.Add(this.label9);
            this.pnAddition.Controls.Add(this.label10);
            this.pnAddition.Location = new System.Drawing.Point(530, 458);
            this.pnAddition.Name = "pnAddition";
            this.pnAddition.Size = new System.Drawing.Size(1086, 274);
            this.pnAddition.TabIndex = 4;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(753, 136);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(226, 61);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // txtNewAuthor
            // 
            this.txtNewAuthor.Location = new System.Drawing.Point(235, 207);
            this.txtNewAuthor.Name = "txtNewAuthor";
            this.txtNewAuthor.Size = new System.Drawing.Size(431, 39);
            this.txtNewAuthor.TabIndex = 6;
            // 
            // txtNewTitle
            // 
            this.txtNewTitle.Location = new System.Drawing.Point(235, 144);
            this.txtNewTitle.Name = "txtNewTitle";
            this.txtNewTitle.Size = new System.Drawing.Size(431, 39);
            this.txtNewTitle.TabIndex = 5;
            // 
            // txtNewId
            // 
            this.txtNewId.Location = new System.Drawing.Point(235, 81);
            this.txtNewId.Name = "txtNewId";
            this.txtNewId.Size = new System.Drawing.Size(431, 39);
            this.txtNewId.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(42, 207);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(197, 39);
            this.label7.TabIndex = 3;
            this.label7.Text = "Book Author:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(57, 144);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(182, 39);
            this.label8.TabIndex = 2;
            this.label8.Text = "Book Title:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(102, 81);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(137, 39);
            this.label9.TabIndex = 1;
            this.label9.Text = "Book ID:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(319, 19);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(347, 39);
            this.label10.TabIndex = 0;
            this.label10.Text = "New Book Registration:";
            // 
            // btnAdd
            // 
            this.btnAdd.AutoSize = true;
            this.btnAdd.Location = new System.Drawing.Point(306, 176);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(54, 55);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "+";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(317, 623);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(151, 64);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // BookStore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 39F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1746, 779);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.pnAddition);
            this.Controls.Add(this.pnUpdation);
            this.Controls.Add(this.lstBooks);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Inconsolata", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BookStore";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BookStore";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.BookStore_Load);
            this.pnUpdation.ResumeLayout(false);
            this.pnUpdation.PerformLayout();
            this.pnAddition.ResumeLayout(false);
            this.pnAddition.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lstBooks;
        private System.Windows.Forms.Panel pnUpdation;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox txtAuthor;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel pnAddition;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtNewAuthor;
        private System.Windows.Forms.TextBox txtNewTitle;
        private System.Windows.Forms.TextBox txtNewId;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
    }
}