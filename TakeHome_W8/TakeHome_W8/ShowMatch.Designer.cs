namespace TakeHome_W8
{
    partial class ShowMatch
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
            this.cmb_team = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_home = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.cmb_match = new System.Windows.Forms.ComboBox();
            this.btn_info = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label_home = new System.Windows.Forms.Label();
            this.label_away = new System.Windows.Forms.Label();
            this.dgv_away = new System.Windows.Forms.DataGridView();
            this.dgv_detail = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_home)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_away)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_detail)).BeginInit();
            this.SuspendLayout();
            // 
            // cmb_team
            // 
            this.cmb_team.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_team.FormattingEnabled = true;
            this.cmb_team.Location = new System.Drawing.Point(28, 45);
            this.cmb_team.Name = "cmb_team";
            this.cmb_team.Size = new System.Drawing.Size(107, 21);
            this.cmb_team.TabIndex = 0;
            this.cmb_team.SelectedIndexChanged += new System.EventHandler(this.cmb_team_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Select Team";
            // 
            // dgv_home
            // 
            this.dgv_home.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_home.Location = new System.Drawing.Point(28, 104);
            this.dgv_home.Name = "dgv_home";
            this.dgv_home.Size = new System.Drawing.Size(338, 132);
            this.dgv_home.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(288, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Select Date";
            // 
            // cmb_match
            // 
            this.cmb_match.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_match.FormattingEnabled = true;
            this.cmb_match.Location = new System.Drawing.Point(291, 45);
            this.cmb_match.Name = "cmb_match";
            this.cmb_match.Size = new System.Drawing.Size(107, 21);
            this.cmb_match.TabIndex = 4;
            this.cmb_match.SelectedIndexChanged += new System.EventHandler(this.cmb_match_SelectedIndexChanged);
            // 
            // btn_info
            // 
            this.btn_info.Location = new System.Drawing.Point(498, 43);
            this.btn_info.Name = "btn_info";
            this.btn_info.Size = new System.Drawing.Size(61, 23);
            this.btn_info.TabIndex = 5;
            this.btn_info.Text = "Info";
            this.btn_info.UseVisualStyleBackColor = true;
            this.btn_info.Click += new System.EventHandler(this.btn_info_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Home Team";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 248);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Away Team";
            // 
            // label_home
            // 
            this.label_home.AutoSize = true;
            this.label_home.Location = new System.Drawing.Point(105, 87);
            this.label_home.Name = "label_home";
            this.label_home.Size = new System.Drawing.Size(10, 13);
            this.label_home.TabIndex = 8;
            this.label_home.Text = "-";
            // 
            // label_away
            // 
            this.label_away.AutoSize = true;
            this.label_away.Location = new System.Drawing.Point(105, 248);
            this.label_away.Name = "label_away";
            this.label_away.Size = new System.Drawing.Size(10, 13);
            this.label_away.TabIndex = 9;
            this.label_away.Text = "-";
            // 
            // dgv_away
            // 
            this.dgv_away.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_away.Location = new System.Drawing.Point(28, 264);
            this.dgv_away.Name = "dgv_away";
            this.dgv_away.Size = new System.Drawing.Size(338, 132);
            this.dgv_away.TabIndex = 10;
            // 
            // dgv_detail
            // 
            this.dgv_detail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_detail.Location = new System.Drawing.Point(384, 104);
            this.dgv_detail.Name = "dgv_detail";
            this.dgv_detail.Size = new System.Drawing.Size(426, 292);
            this.dgv_detail.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(381, 87);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Details";
            // 
            // ShowMatch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dgv_detail);
            this.Controls.Add(this.dgv_away);
            this.Controls.Add(this.label_away);
            this.Controls.Add(this.label_home);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_info);
            this.Controls.Add(this.cmb_match);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgv_home);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmb_team);
            this.Name = "ShowMatch";
            this.Text = "ShowMatch";
            this.Load += new System.EventHandler(this.ShowMatch_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_home)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_away)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_detail)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmb_team;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_home;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmb_match;
        private System.Windows.Forms.Button btn_info;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label_home;
        private System.Windows.Forms.Label label_away;
        private System.Windows.Forms.DataGridView dgv_away;
        private System.Windows.Forms.DataGridView dgv_detail;
        private System.Windows.Forms.Label label5;
    }
}