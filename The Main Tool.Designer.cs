namespace BuildScript
{
    partial class mainForm
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
            this.components = new System.ComponentModel.Container();
            this.GENERATE = new System.Windows.Forms.Button();
            this.textAdded = new System.Windows.Forms.TextBox();
            this.clock = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.wb = new System.Windows.Forms.TextBox();
            this.build = new System.Windows.Forms.TextBox();
            this.clockUpdateTimer = new System.Windows.Forms.Timer(this.components);
            this.closeAfterBuilding = new System.Windows.Forms.CheckBox();
            this.wiFiBox = new System.Windows.Forms.CheckBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.botTextBox = new System.Windows.Forms.RichTextBox();
            this.botRTFButton = new System.Windows.Forms.Button();
            this.discordBox = new System.Windows.Forms.CheckBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // GENERATE
            // 
            this.GENERATE.Location = new System.Drawing.Point(47, 103);
            this.GENERATE.Name = "GENERATE";
            this.GENERATE.Size = new System.Drawing.Size(198, 23);
            this.GENERATE.TabIndex = 0;
            this.GENERATE.Text = "BUILD ITTTTT";
            this.GENERATE.UseVisualStyleBackColor = true;
            this.GENERATE.Click += new System.EventHandler(this.button1_Click);
            // 
            // textAdded
            // 
            this.textAdded.Location = new System.Drawing.Point(47, 77);
            this.textAdded.Name = "textAdded";
            this.textAdded.Size = new System.Drawing.Size(198, 20);
            this.textAdded.TabIndex = 2;
            // 
            // clock
            // 
            this.clock.AutoSize = true;
            this.clock.Location = new System.Drawing.Point(44, 31);
            this.clock.Name = "clock";
            this.clock.Size = new System.Drawing.Size(34, 13);
            this.clock.TabIndex = 3;
            this.clock.Text = "Clock";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(82, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Changelog for this version:";
            // 
            // wb
            // 
            this.wb.BackColor = System.Drawing.SystemColors.Control;
            this.wb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.wb.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.wb.Location = new System.Drawing.Point(14, 144);
            this.wb.Multiline = true;
            this.wb.Name = "wb";
            this.wb.Size = new System.Drawing.Size(270, 26);
            this.wb.TabIndex = 6;
            this.wb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // build
            // 
            this.build.BackColor = System.Drawing.SystemColors.Control;
            this.build.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.build.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.build.Location = new System.Drawing.Point(193, 22);
            this.build.Name = "build";
            this.build.Size = new System.Drawing.Size(52, 24);
            this.build.TabIndex = 7;
            this.build.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // closeAfterBuilding
            // 
            this.closeAfterBuilding.AutoSize = true;
            this.closeAfterBuilding.Checked = true;
            this.closeAfterBuilding.CheckState = System.Windows.Forms.CheckState.Checked;
            this.closeAfterBuilding.Location = new System.Drawing.Point(47, 176);
            this.closeAfterBuilding.Name = "closeAfterBuilding";
            this.closeAfterBuilding.Size = new System.Drawing.Size(104, 17);
            this.closeAfterBuilding.TabIndex = 8;
            this.closeAfterBuilding.Text = "Close afterwards";
            this.closeAfterBuilding.UseVisualStyleBackColor = true;
            // 
            // wiFiBox
            // 
            this.wiFiBox.AutoSize = true;
            this.wiFiBox.Checked = true;
            this.wiFiBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.wiFiBox.Location = new System.Drawing.Point(157, 176);
            this.wiFiBox.Name = "wiFiBox";
            this.wiFiBox.Size = new System.Drawing.Size(88, 17);
            this.wiFiBox.TabIndex = 9;
            this.wiFiBox.Text = "Wi-Fi support";
            this.wiFiBox.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(297, 258);
            this.tabControl1.TabIndex = 10;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage1.Controls.Add(this.discordBox);
            this.tabPage1.Controls.Add(this.build);
            this.tabPage1.Controls.Add(this.clock);
            this.tabPage1.Controls.Add(this.wiFiBox);
            this.tabPage1.Controls.Add(this.GENERATE);
            this.tabPage1.Controls.Add(this.textAdded);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.closeAfterBuilding);
            this.tabPage1.Controls.Add(this.wb);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(289, 232);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Build EKDS";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage2.Controls.Add(this.botRTFButton);
            this.tabPage2.Controls.Add(this.botTextBox);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(289, 232);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Interact with Discord";
            // 
            // botTextBox
            // 
            this.botTextBox.Location = new System.Drawing.Point(8, 6);
            this.botTextBox.Name = "botTextBox";
            this.botTextBox.Size = new System.Drawing.Size(273, 162);
            this.botTextBox.TabIndex = 0;
            this.botTextBox.Text = "";
            // 
            // botRTFButton
            // 
            this.botRTFButton.Location = new System.Drawing.Point(34, 186);
            this.botRTFButton.Name = "botRTFButton";
            this.botRTFButton.Size = new System.Drawing.Size(222, 23);
            this.botRTFButton.TabIndex = 1;
            this.botRTFButton.Text = "Write as bot";
            this.botRTFButton.UseVisualStyleBackColor = true;
            this.botRTFButton.Click += new System.EventHandler(this.botRTF_Click);
            // 
            // discordBox
            // 
            this.discordBox.AutoSize = true;
            this.discordBox.Checked = true;
            this.discordBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.discordBox.Location = new System.Drawing.Point(69, 199);
            this.discordBox.Name = "discordBox";
            this.discordBox.Size = new System.Drawing.Size(156, 17);
            this.discordBox.TabIndex = 10;
            this.discordBox.Text = "Send Changelog to Discord";
            this.discordBox.UseVisualStyleBackColor = true;
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(297, 258);
            this.Controls.Add(this.tabControl1);
            this.Name = "mainForm";
            this.Text = "EKDS Dashboard";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button GENERATE;
        private System.Windows.Forms.TextBox textAdded;
        private System.Windows.Forms.Label clock;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox wb;
        private System.Windows.Forms.TextBox build;
        private System.Windows.Forms.Timer clockUpdateTimer;
        private System.Windows.Forms.CheckBox closeAfterBuilding;
        private System.Windows.Forms.CheckBox wiFiBox;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.CheckBox discordBox;
        private System.Windows.Forms.Button botRTFButton;
        private System.Windows.Forms.RichTextBox botTextBox;
    }
}

