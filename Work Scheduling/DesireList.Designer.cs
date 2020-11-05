namespace Work_Scheduling
{
    partial class DesireList
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
            this.lbxEmployees = new System.Windows.Forms.ListBox();
            this.tbxDesiredDays = new System.Windows.Forms.TextBox();
            this.btnEdit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbxEmployees
            // 
            this.lbxEmployees.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbxEmployees.FormattingEnabled = true;
            this.lbxEmployees.ItemHeight = 20;
            this.lbxEmployees.Location = new System.Drawing.Point(13, 13);
            this.lbxEmployees.Name = "lbxEmployees";
            this.lbxEmployees.Size = new System.Drawing.Size(118, 224);
            this.lbxEmployees.TabIndex = 0;
            // 
            // tbxDesiredDays
            // 
            this.tbxDesiredDays.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxDesiredDays.Location = new System.Drawing.Point(138, 13);
            this.tbxDesiredDays.Name = "tbxDesiredDays";
            this.tbxDesiredDays.Size = new System.Drawing.Size(45, 29);
            this.tbxDesiredDays.TabIndex = 1;
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(137, 48);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(46, 24);
            this.btnEdit.TabIndex = 2;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // DesireList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(195, 245);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.tbxDesiredDays);
            this.Controls.Add(this.lbxEmployees);
            this.Name = "DesireList";
            this.Text = "DesireList";
            this.Load += new System.EventHandler(this.DesireList_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbxEmployees;
        private System.Windows.Forms.TextBox tbxDesiredDays;
        private System.Windows.Forms.Button btnEdit;
    }
}