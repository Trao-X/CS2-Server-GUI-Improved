namespace cs2servergui
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
            this.start_btn = new System.Windows.Forms.Button();
            this.title = new System.Windows.Forms.Label();
            this.game_mode = new System.Windows.Forms.Label();
            this.game_mode_sel = new System.Windows.Forms.ComboBox();
            this.game_type = new System.Windows.Forms.Label();
            this.game_type_sel = new System.Windows.Forms.ComboBox();
            this.map_sel = new System.Windows.Forms.ComboBox();
            this.map = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // start_btn
            // 
            this.start_btn.Location = new System.Drawing.Point(116, 277);
            this.start_btn.Name = "start_btn";
            this.start_btn.Size = new System.Drawing.Size(141, 44);
            this.start_btn.TabIndex = 0;
            this.start_btn.Text = "Start Server";
            this.start_btn.UseVisualStyleBackColor = true;
            this.start_btn.Click += new System.EventHandler(this.start_btn_Click);
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("HP Simplified", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.Location = new System.Drawing.Point(22, 9);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(313, 24);
            this.title.TabIndex = 1;
            this.title.Text = "Easy Counter-Strike 2 Server Config";
            this.title.Click += new System.EventHandler(this.title_Click);
            // 
            // game_mode
            // 
            this.game_mode.AutoSize = true;
            this.game_mode.Font = new System.Drawing.Font("HP Simplified", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.game_mode.Location = new System.Drawing.Point(73, 45);
            this.game_mode.Name = "game_mode";
            this.game_mode.Size = new System.Drawing.Size(83, 18);
            this.game_mode.TabIndex = 2;
            this.game_mode.Text = "Game Mode:";
            this.game_mode.Click += new System.EventHandler(this.game_mode_Click);
            // 
            // game_mode_sel
            // 
            this.game_mode_sel.FormattingEnabled = true;
            this.game_mode_sel.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4"});
            this.game_mode_sel.Location = new System.Drawing.Point(162, 45);
            this.game_mode_sel.Name = "game_mode_sel";
            this.game_mode_sel.Size = new System.Drawing.Size(141, 21);
            this.game_mode_sel.TabIndex = 3;
            this.game_mode_sel.SelectedIndexChanged += new System.EventHandler(this.game_mode_SelectedIndexChanged);
            // 
            // game_type
            // 
            this.game_type.AutoSize = true;
            this.game_type.Font = new System.Drawing.Font("HP Simplified", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.game_type.Location = new System.Drawing.Point(73, 74);
            this.game_type.Name = "game_type";
            this.game_type.Size = new System.Drawing.Size(80, 18);
            this.game_type.TabIndex = 4;
            this.game_type.Text = "Game Type:";
            // 
            // game_type_sel
            // 
            this.game_type_sel.FormattingEnabled = true;
            this.game_type_sel.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.game_type_sel.Location = new System.Drawing.Point(162, 75);
            this.game_type_sel.Name = "game_type_sel";
            this.game_type_sel.Size = new System.Drawing.Size(141, 21);
            this.game_type_sel.TabIndex = 5;
            this.game_type_sel.SelectedIndexChanged += new System.EventHandler(this.game_type_SelectedIndexChanged);
            // 
            // map_sel
            // 
            this.map_sel.FormattingEnabled = true;
            this.map_sel.Items.AddRange(new object[] {
            "cs_italy",
            "cs_office",
            "de_ancient",
            "de_anubis",
            "de_dust2",
            "de_inferno",
            "de_mirage",
            "de_nuke",
            "de_overpass",
            "de_vertigo"});
            this.map_sel.Location = new System.Drawing.Point(162, 105);
            this.map_sel.Name = "map_sel";
            this.map_sel.Size = new System.Drawing.Size(141, 21);
            this.map_sel.TabIndex = 7;
            this.map_sel.SelectedIndexChanged += new System.EventHandler(this.map_sel_SelectedIndexChanged);
            // 
            // map
            // 
            this.map.AutoSize = true;
            this.map.Font = new System.Drawing.Font("HP Simplified", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.map.Location = new System.Drawing.Point(112, 103);
            this.map.Name = "map";
            this.map.Size = new System.Drawing.Size(38, 18);
            this.map.TabIndex = 6;
            this.map.Text = "Map:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 327);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(339, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Information about the game modes and game types.";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(11, 146);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(340, 20);
            this.textBox1.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("HP Simplified", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 14);
            this.label1.TabIndex = 10;
            this.label1.Text = "The Counter-Strike 2 executable file:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(326, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "In order to find the executable, go into where you installed the game";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(332, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "then after that go to /game/bin/win64 and hold shift then right click it";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 195);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(289, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "and then you want to copy it as path. Paste it in the textbox.";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(8, 208);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(333, 15);
            this.label5.TabIndex = 14;
            this.label5.Text = "And don\'t forget to remove the \"s at the start and end!";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 362);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.map_sel);
            this.Controls.Add(this.map);
            this.Controls.Add(this.game_type_sel);
            this.Controls.Add(this.game_type);
            this.Controls.Add(this.game_mode_sel);
            this.Controls.Add(this.game_mode);
            this.Controls.Add(this.title);
            this.Controls.Add(this.start_btn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button start_btn;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Label game_mode;
        private System.Windows.Forms.ComboBox game_mode_sel;
        private System.Windows.Forms.Label game_type;
        private System.Windows.Forms.ComboBox game_type_sel;
        private System.Windows.Forms.ComboBox map_sel;
        private System.Windows.Forms.Label map;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

