namespace TakeHomeWeek3
{
    partial class MainWindowForm
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
            this.btn_NextForm = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBox_Name = new System.Windows.Forms.TextBox();
            this.txtBox_Artist = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.checkBox_Content = new System.Windows.Forms.CheckBox();
            this.btn_Submit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_NextForm
            // 
            this.btn_NextForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_NextForm.Location = new System.Drawing.Point(247, 513);
            this.btn_NextForm.Name = "btn_NextForm";
            this.btn_NextForm.Size = new System.Drawing.Size(345, 63);
            this.btn_NextForm.TabIndex = 0;
            this.btn_NextForm.Text = "Open Next Form";
            this.btn_NextForm.UseVisualStyleBackColor = true;
            this.btn_NextForm.Click += new System.EventHandler(this.btn_NextForm_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(57, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 40);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name: ";
            // 
            // txtBox_Name
            // 
            this.txtBox_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBox_Name.Location = new System.Drawing.Point(445, 80);
            this.txtBox_Name.Name = "txtBox_Name";
            this.txtBox_Name.Size = new System.Drawing.Size(303, 48);
            this.txtBox_Name.TabIndex = 2;
            // 
            // txtBox_Artist
            // 
            this.txtBox_Artist.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBox_Artist.Location = new System.Drawing.Point(445, 176);
            this.txtBox_Artist.Name = "txtBox_Artist";
            this.txtBox_Artist.Size = new System.Drawing.Size(303, 48);
            this.txtBox_Artist.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(57, 176);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(297, 40);
            this.label2.TabIndex = 3;
            this.label2.Text = "My Favorite Artist";
            // 
            // checkBox_Content
            // 
            this.checkBox_Content.AutoSize = true;
            this.checkBox_Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_Content.Location = new System.Drawing.Point(126, 326);
            this.checkBox_Content.Name = "checkBox_Content";
            this.checkBox_Content.Size = new System.Drawing.Size(622, 44);
            this.checkBox_Content.TabIndex = 5;
            this.checkBox_Content.Text = "All of the content I put above is true!";
            this.checkBox_Content.UseVisualStyleBackColor = true;
            this.checkBox_Content.CheckedChanged += new System.EventHandler(this.checkBox_Content_CheckedChanged);
            // 
            // btn_Submit
            // 
            this.btn_Submit.Enabled = false;
            this.btn_Submit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Submit.Location = new System.Drawing.Point(304, 416);
            this.btn_Submit.Name = "btn_Submit";
            this.btn_Submit.Size = new System.Drawing.Size(226, 61);
            this.btn_Submit.TabIndex = 6;
            this.btn_Submit.Text = "Submit";
            this.btn_Submit.UseVisualStyleBackColor = true;
            this.btn_Submit.Click += new System.EventHandler(this.btn_Submit_Click);
            // 
            // MainWindowForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 726);
            this.Controls.Add(this.btn_Submit);
            this.Controls.Add(this.checkBox_Content);
            this.Controls.Add(this.txtBox_Artist);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBox_Name);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_NextForm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MainWindowForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_NextForm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBox_Name;
        private System.Windows.Forms.TextBox txtBox_Artist;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox checkBox_Content;
        private System.Windows.Forms.Button btn_Submit;
    }
}

