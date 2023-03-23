namespace TakeHome_W4
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbBox_Country = new System.Windows.Forms.ComboBox();
            this.cmbBox_Team = new System.Windows.Forms.ComboBox();
            this.btn_AddTeam = new System.Windows.Forms.Button();
            this.listBox_TeamList = new System.Windows.Forms.ListBox();
            this.btn_Remove = new System.Windows.Forms.Button();
            this.txtBox_TeamName = new System.Windows.Forms.TextBox();
            this.txtBox_TeamCountry = new System.Windows.Forms.TextBox();
            this.txtBox_TeamCity = new System.Windows.Forms.TextBox();
            this.txtBox_PlayerNumber = new System.Windows.Forms.TextBox();
            this.txtBox_PlayerName = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btn_AddPlayer = new System.Windows.Forms.Button();
            this.cmbBox_Position = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(759, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Adding Team";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(759, 197);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Team Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(759, 268);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(170, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "Team Country:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(759, 340);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 29);
            this.label4.TabIndex = 3;
            this.label4.Text = "Team City:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(66, 125);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(201, 29);
            this.label5.TabIndex = 4;
            this.label5.Text = "Soccer Team List";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(66, 202);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(191, 29);
            this.label6.TabIndex = 5;
            this.label6.Text = "Choose Country:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(66, 276);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(172, 29);
            this.label7.TabIndex = 6;
            this.label7.Text = "Choose Team:";
            // 
            // cmbBox_Country
            // 
            this.cmbBox_Country.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBox_Country.FormattingEnabled = true;
            this.cmbBox_Country.Location = new System.Drawing.Point(299, 194);
            this.cmbBox_Country.Name = "cmbBox_Country";
            this.cmbBox_Country.Size = new System.Drawing.Size(270, 37);
            this.cmbBox_Country.TabIndex = 7;
            this.cmbBox_Country.SelectedIndexChanged += new System.EventHandler(this.cmbBox_Country_SelectedIndexChanged);
            // 
            // cmbBox_Team
            // 
            this.cmbBox_Team.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBox_Team.FormattingEnabled = true;
            this.cmbBox_Team.Location = new System.Drawing.Point(299, 268);
            this.cmbBox_Team.Name = "cmbBox_Team";
            this.cmbBox_Team.Size = new System.Drawing.Size(270, 37);
            this.cmbBox_Team.TabIndex = 8;
            this.cmbBox_Team.SelectedIndexChanged += new System.EventHandler(this.cmbBox_Team_SelectedIndexChanged);
            // 
            // btn_AddTeam
            // 
            this.btn_AddTeam.Location = new System.Drawing.Point(764, 494);
            this.btn_AddTeam.Name = "btn_AddTeam";
            this.btn_AddTeam.Size = new System.Drawing.Size(148, 57);
            this.btn_AddTeam.TabIndex = 9;
            this.btn_AddTeam.Text = "Add";
            this.btn_AddTeam.UseVisualStyleBackColor = true;
            this.btn_AddTeam.Click += new System.EventHandler(this.btn_AddTeam_Click);
            // 
            // listBox_TeamList
            // 
            this.listBox_TeamList.FormattingEnabled = true;
            this.listBox_TeamList.ItemHeight = 29;
            this.listBox_TeamList.Location = new System.Drawing.Point(65, 385);
            this.listBox_TeamList.Name = "listBox_TeamList";
            this.listBox_TeamList.Size = new System.Drawing.Size(503, 294);
            this.listBox_TeamList.TabIndex = 10;
            // 
            // btn_Remove
            // 
            this.btn_Remove.Location = new System.Drawing.Point(66, 725);
            this.btn_Remove.Name = "btn_Remove";
            this.btn_Remove.Size = new System.Drawing.Size(173, 57);
            this.btn_Remove.TabIndex = 11;
            this.btn_Remove.Text = "Remove";
            this.btn_Remove.UseVisualStyleBackColor = true;
            this.btn_Remove.Click += new System.EventHandler(this.btn_Remove_Click);
            // 
            // txtBox_TeamName
            // 
            this.txtBox_TeamName.Location = new System.Drawing.Point(953, 197);
            this.txtBox_TeamName.Name = "txtBox_TeamName";
            this.txtBox_TeamName.Size = new System.Drawing.Size(247, 35);
            this.txtBox_TeamName.TabIndex = 12;
            // 
            // txtBox_TeamCountry
            // 
            this.txtBox_TeamCountry.Location = new System.Drawing.Point(953, 270);
            this.txtBox_TeamCountry.Name = "txtBox_TeamCountry";
            this.txtBox_TeamCountry.Size = new System.Drawing.Size(247, 35);
            this.txtBox_TeamCountry.TabIndex = 13;
            // 
            // txtBox_TeamCity
            // 
            this.txtBox_TeamCity.Location = new System.Drawing.Point(953, 340);
            this.txtBox_TeamCity.Name = "txtBox_TeamCity";
            this.txtBox_TeamCity.Size = new System.Drawing.Size(247, 35);
            this.txtBox_TeamCity.TabIndex = 14;
            // 
            // txtBox_PlayerNumber
            // 
            this.txtBox_PlayerNumber.Location = new System.Drawing.Point(1519, 270);
            this.txtBox_PlayerNumber.Name = "txtBox_PlayerNumber";
            this.txtBox_PlayerNumber.Size = new System.Drawing.Size(247, 35);
            this.txtBox_PlayerNumber.TabIndex = 20;
            // 
            // txtBox_PlayerName
            // 
            this.txtBox_PlayerName.Location = new System.Drawing.Point(1519, 197);
            this.txtBox_PlayerName.Name = "txtBox_PlayerName";
            this.txtBox_PlayerName.Size = new System.Drawing.Size(247, 35);
            this.txtBox_PlayerName.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(1325, 340);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(180, 29);
            this.label8.TabIndex = 18;
            this.label8.Text = "Player Position:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(1325, 268);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(180, 29);
            this.label9.TabIndex = 17;
            this.label9.Text = "Player Number:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(1325, 197);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(158, 29);
            this.label10.TabIndex = 16;
            this.label10.Text = "Player Name:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(1325, 125);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(163, 29);
            this.label11.TabIndex = 15;
            this.label11.Text = "Adding Player";
            // 
            // btn_AddPlayer
            // 
            this.btn_AddPlayer.Location = new System.Drawing.Point(1330, 494);
            this.btn_AddPlayer.Name = "btn_AddPlayer";
            this.btn_AddPlayer.Size = new System.Drawing.Size(153, 57);
            this.btn_AddPlayer.TabIndex = 22;
            this.btn_AddPlayer.Text = "Add";
            this.btn_AddPlayer.UseVisualStyleBackColor = true;
            this.btn_AddPlayer.Click += new System.EventHandler(this.btn_AddPlayer_Click);
            // 
            // cmbBox_Position
            // 
            this.cmbBox_Position.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBox_Position.FormattingEnabled = true;
            this.cmbBox_Position.Items.AddRange(new object[] {
            "GK",
            "DF",
            "MF",
            "FW"});
            this.cmbBox_Position.Location = new System.Drawing.Point(1519, 337);
            this.cmbBox_Position.Name = "cmbBox_Position";
            this.cmbBox_Position.Size = new System.Drawing.Size(247, 37);
            this.cmbBox_Position.TabIndex = 23;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1963, 932);
            this.Controls.Add(this.cmbBox_Position);
            this.Controls.Add(this.btn_AddPlayer);
            this.Controls.Add(this.txtBox_PlayerNumber);
            this.Controls.Add(this.txtBox_PlayerName);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtBox_TeamCity);
            this.Controls.Add(this.txtBox_TeamCountry);
            this.Controls.Add(this.txtBox_TeamName);
            this.Controls.Add(this.btn_Remove);
            this.Controls.Add(this.listBox_TeamList);
            this.Controls.Add(this.btn_AddTeam);
            this.Controls.Add(this.cmbBox_Team);
            this.Controls.Add(this.cmbBox_Country);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbBox_Country;
        private System.Windows.Forms.ComboBox cmbBox_Team;
        private System.Windows.Forms.Button btn_AddTeam;
        private System.Windows.Forms.ListBox listBox_TeamList;
        private System.Windows.Forms.Button btn_Remove;
        private System.Windows.Forms.TextBox txtBox_TeamName;
        private System.Windows.Forms.TextBox txtBox_TeamCountry;
        private System.Windows.Forms.TextBox txtBox_TeamCity;
        private System.Windows.Forms.TextBox txtBox_PlayerNumber;
        private System.Windows.Forms.TextBox txtBox_PlayerName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btn_AddPlayer;
        private System.Windows.Forms.ComboBox cmbBox_Position;
    }
}

