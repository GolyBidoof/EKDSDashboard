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
            this.SuspendLayout();
            // 
            // GENERATE
            // 
            this.GENERATE.Location = new System.Drawing.Point(38, 103);
            this.GENERATE.Name = "GENERATE";
            this.GENERATE.Size = new System.Drawing.Size(198, 23);
            this.GENERATE.TabIndex = 0;
            this.GENERATE.Text = "BUILD ITTTTT";
            this.GENERATE.UseVisualStyleBackColor = true;
            this.GENERATE.Click += new System.EventHandler(this.button1_Click);
            // 
            // textAdded
            // 
            this.textAdded.Location = new System.Drawing.Point(38, 77);
            this.textAdded.Name = "textAdded";
            this.textAdded.Size = new System.Drawing.Size(198, 20);
            this.textAdded.TabIndex = 2;
            // 
            // clock
            // 
            this.clock.AutoSize = true;
            this.clock.Location = new System.Drawing.Point(35, 31);
            this.clock.Name = "clock";
            this.clock.Size = new System.Drawing.Size(34, 13);
            this.clock.TabIndex = 3;
            this.clock.Text = "Clock";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(73, 61);
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
            this.wb.Location = new System.Drawing.Point(38, 142);
            this.wb.Name = "wb";
            this.wb.Size = new System.Drawing.Size(198, 13);
            this.wb.TabIndex = 6;
            this.wb.Text = "Welcome back, ";
            this.wb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // build
            // 
            this.build.BackColor = System.Drawing.SystemColors.Control;
            this.build.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.build.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.build.Location = new System.Drawing.Point(184, 22);
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
            this.closeAfterBuilding.Location = new System.Drawing.Point(76, 173);
            this.closeAfterBuilding.Name = "closeAfterBuilding";
            this.closeAfterBuilding.Size = new System.Drawing.Size(115, 17);
            this.closeAfterBuilding.TabIndex = 8;
            this.closeAfterBuilding.Text = "Close after building";
            this.closeAfterBuilding.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(280, 208);
            this.Controls.Add(this.closeAfterBuilding);
            this.Controls.Add(this.build);
            this.Controls.Add(this.wb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.clock);
            this.Controls.Add(this.textAdded);
            this.Controls.Add(this.GENERATE);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

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
    }
}

