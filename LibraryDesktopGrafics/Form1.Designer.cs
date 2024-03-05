namespace LibraryDesktopGrafics
{
    partial class Form_book
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
            this.listBox_book = new System.Windows.Forms.ListBox();
            this.button_new = new System.Windows.Forms.Button();
            this.button_edit = new System.Windows.Forms.Button();
            this.button_delet = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox_book
            // 
            this.listBox_book.Dock = System.Windows.Forms.DockStyle.Left;
            this.listBox_book.FormattingEnabled = true;
            this.listBox_book.Location = new System.Drawing.Point(0, 0);
            this.listBox_book.Name = "listBox_book";
            this.listBox_book.Size = new System.Drawing.Size(549, 345);
            this.listBox_book.TabIndex = 0;
            this.listBox_book.SelectedIndexChanged += new System.EventHandler(this.listBox_book_SelectedIndexChanged);
            // 
            // button_new
            // 
            this.button_new.Location = new System.Drawing.Point(616, 76);
            this.button_new.Name = "button_new";
            this.button_new.Size = new System.Drawing.Size(144, 36);
            this.button_new.TabIndex = 1;
            this.button_new.Text = "New";
            this.button_new.UseVisualStyleBackColor = true;
            this.button_new.Click += new System.EventHandler(this.button1_Click);
            // 
            // button_edit
            // 
            this.button_edit.Location = new System.Drawing.Point(616, 148);
            this.button_edit.Name = "button_edit";
            this.button_edit.Size = new System.Drawing.Size(144, 36);
            this.button_edit.TabIndex = 1;
            this.button_edit.Text = "Edit";
            this.button_edit.UseVisualStyleBackColor = true;
            // 
            // button_delet
            // 
            this.button_delet.Location = new System.Drawing.Point(616, 222);
            this.button_delet.Name = "button_delet";
            this.button_delet.Size = new System.Drawing.Size(144, 36);
            this.button_delet.TabIndex = 1;
            this.button_delet.Text = "Delet";
            this.button_delet.UseVisualStyleBackColor = true;
            // 
            // Form_book
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 345);
            this.Controls.Add(this.button_delet);
            this.Controls.Add(this.button_edit);
            this.Controls.Add(this.button_new);
            this.Controls.Add(this.listBox_book);
            this.Name = "Form_book";
            this.Text = "Book";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox_book;
        private System.Windows.Forms.Button button_new;
        private System.Windows.Forms.Button button_edit;
        private System.Windows.Forms.Button button_delet;
    }
}

