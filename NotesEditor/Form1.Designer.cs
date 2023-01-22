namespace NotesEditor
{
    partial class NotesEditor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NotesEditor));
            this.createBtn = new System.Windows.Forms.Button();
            this.titleLable = new System.Windows.Forms.Label();
            this.createTxtbox = new System.Windows.Forms.TextBox();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.gitLink = new System.Windows.Forms.LinkLabel();
            this.saveBtn = new System.Windows.Forms.Button();
            this.txtEditor = new System.Windows.Forms.TextBox();
            this.readBtn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // createBtn
            // 
            this.createBtn.Location = new System.Drawing.Point(418, 28);
            this.createBtn.Name = "createBtn";
            this.createBtn.Size = new System.Drawing.Size(76, 27);
            this.createBtn.TabIndex = 1;
            this.createBtn.Text = "Create Note";
            this.createBtn.UseVisualStyleBackColor = true;
            this.createBtn.Click += new System.EventHandler(this.createBtn_Click);
            // 
            // titleLable
            // 
            this.titleLable.AutoSize = true;
            this.titleLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLable.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.titleLable.Location = new System.Drawing.Point(12, 31);
            this.titleLable.Name = "titleLable";
            this.titleLable.Size = new System.Drawing.Size(50, 24);
            this.titleLable.TabIndex = 2;
            this.titleLable.Text = "Title";
            // 
            // createTxtbox
            // 
            this.createTxtbox.Location = new System.Drawing.Point(14, 70);
            this.createTxtbox.MaxLength = 70;
            this.createTxtbox.Name = "createTxtbox";
            this.createTxtbox.Size = new System.Drawing.Size(382, 20);
            this.createTxtbox.TabIndex = 3;
            this.createTxtbox.Text = "<NewNote>";
            // 
            // deleteBtn
            // 
            this.deleteBtn.BackColor = System.Drawing.Color.Maroon;
            this.deleteBtn.ForeColor = System.Drawing.Color.White;
            this.deleteBtn.Location = new System.Drawing.Point(500, 128);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(92, 23);
            this.deleteBtn.TabIndex = 4;
            this.deleteBtn.Text = "Delete Note";
            this.deleteBtn.UseVisualStyleBackColor = false;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // gitLink
            // 
            this.gitLink.AutoSize = true;
            this.gitLink.LinkColor = System.Drawing.Color.White;
            this.gitLink.Location = new System.Drawing.Point(13, 549);
            this.gitLink.Name = "gitLink";
            this.gitLink.Size = new System.Drawing.Size(82, 13);
            this.gitLink.TabIndex = 6;
            this.gitLink.TabStop = true;
            this.gitLink.Text = "LVNDev Github";
            this.gitLink.VisitedLinkColor = System.Drawing.Color.White;
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(418, 67);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(76, 23);
            this.saveBtn.TabIndex = 7;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // txtEditor
            // 
            this.txtEditor.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.txtEditor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEditor.Location = new System.Drawing.Point(598, 52);
            this.txtEditor.Multiline = true;
            this.txtEditor.Name = "txtEditor";
            this.txtEditor.Size = new System.Drawing.Size(479, 485);
            this.txtEditor.TabIndex = 8;
            // 
            // readBtn
            // 
            this.readBtn.Location = new System.Drawing.Point(515, 65);
            this.readBtn.Name = "readBtn";
            this.readBtn.Size = new System.Drawing.Size(60, 26);
            this.readBtn.TabIndex = 9;
            this.readBtn.Text = "Read";
            this.readBtn.UseVisualStyleBackColor = true;
            this.readBtn.Click += new System.EventHandler(this.readBtn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(16, 128);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(478, 409);
            this.dataGridView1.TabIndex = 10;
            // 
            // NotesEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1091, 571);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.readBtn);
            this.Controls.Add(this.txtEditor);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.gitLink);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.createTxtbox);
            this.Controls.Add(this.titleLable);
            this.Controls.Add(this.createBtn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "NotesEditor";
            this.Text = "NotesEditor";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button createBtn;
        private System.Windows.Forms.Label titleLable;
        private System.Windows.Forms.TextBox createTxtbox;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.LinkLabel gitLink;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.TextBox txtEditor;
        private System.Windows.Forms.Button readBtn;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

