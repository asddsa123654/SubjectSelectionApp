namespace SubjectSelectionApp
{
    partial class Form1
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
            this.checkedListBoxSubjects = new System.Windows.Forms.CheckedListBox();
            this.listBoxSelectedSubjects = new System.Windows.Forms.ListBox();
            this.btnShowSelectedSubjects = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // checkedListBoxSubjects
            // 
            this.checkedListBoxSubjects.FormattingEnabled = true;
            this.checkedListBoxSubjects.Location = new System.Drawing.Point(401, 1);
            this.checkedListBoxSubjects.Name = "checkedListBoxSubjects";
            this.checkedListBoxSubjects.Size = new System.Drawing.Size(120, 89);
            this.checkedListBoxSubjects.TabIndex = 0;
            this.checkedListBoxSubjects.SelectedIndexChanged += new System.EventHandler(this.checkedListBoxSubjects_SelectedIndexChanged);
            // 
            // listBoxSelectedSubjects
            // 
            this.listBoxSelectedSubjects.FormattingEnabled = true;
            this.listBoxSelectedSubjects.ItemHeight = 16;
            this.listBoxSelectedSubjects.Location = new System.Drawing.Point(275, 1);
            this.listBoxSelectedSubjects.Name = "listBoxSelectedSubjects";
            this.listBoxSelectedSubjects.Size = new System.Drawing.Size(120, 84);
            this.listBoxSelectedSubjects.TabIndex = 1;
            this.listBoxSelectedSubjects.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // btnShowSelectedSubjects
            // 
            this.btnShowSelectedSubjects.Location = new System.Drawing.Point(194, 1);
            this.btnShowSelectedSubjects.Name = "btnShowSelectedSubjects";
            this.btnShowSelectedSubjects.Size = new System.Drawing.Size(75, 23);
            this.btnShowSelectedSubjects.TabIndex = 2;
            this.btnShowSelectedSubjects.Text = "Показати вибрані дисципліни";
            this.btnShowSelectedSubjects.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnShowSelectedSubjects);
            this.Controls.Add(this.listBoxSelectedSubjects);
            this.Controls.Add(this.checkedListBoxSubjects);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckedListBox checkedListBoxSubjects;
        private System.Windows.Forms.ListBox listBoxSelectedSubjects;
        private System.Windows.Forms.Button btnShowSelectedSubjects;
    }
}

