namespace Adgp_125_Assessment_WinForm
{
    partial class Form2
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
            this.Enemy1Label = new System.Windows.Forms.Label();
            this.Enemy2Label = new System.Windows.Forms.Label();
            this.Enemy3Label = new System.Windows.Forms.Label();
            this.Player1Label = new System.Windows.Forms.Label();
            this.Player2Label = new System.Windows.Forms.Label();
            this.Player3Label = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Enemy1Label
            // 
            this.Enemy1Label.AutoSize = true;
            this.Enemy1Label.Location = new System.Drawing.Point(39, 102);
            this.Enemy1Label.Name = "Enemy1Label";
            this.Enemy1Label.Size = new System.Drawing.Size(35, 13);
            this.Enemy1Label.TabIndex = 0;
            this.Enemy1Label.Text = "label1";
            // 
            // Enemy2Label
            // 
            this.Enemy2Label.AutoSize = true;
            this.Enemy2Label.Location = new System.Drawing.Point(39, 262);
            this.Enemy2Label.Name = "Enemy2Label";
            this.Enemy2Label.Size = new System.Drawing.Size(35, 13);
            this.Enemy2Label.TabIndex = 1;
            this.Enemy2Label.Text = "label2";
            // 
            // Enemy3Label
            // 
            this.Enemy3Label.AutoSize = true;
            this.Enemy3Label.Location = new System.Drawing.Point(39, 451);
            this.Enemy3Label.Name = "Enemy3Label";
            this.Enemy3Label.Size = new System.Drawing.Size(35, 13);
            this.Enemy3Label.TabIndex = 2;
            this.Enemy3Label.Text = "label3";
            // 
            // Player1Label
            // 
            this.Player1Label.AutoSize = true;
            this.Player1Label.Location = new System.Drawing.Point(1063, 102);
            this.Player1Label.Name = "Player1Label";
            this.Player1Label.Size = new System.Drawing.Size(35, 13);
            this.Player1Label.TabIndex = 3;
            this.Player1Label.Text = "label1";
            // 
            // Player2Label
            // 
            this.Player2Label.AutoSize = true;
            this.Player2Label.Location = new System.Drawing.Point(1063, 262);
            this.Player2Label.Name = "Player2Label";
            this.Player2Label.Size = new System.Drawing.Size(35, 13);
            this.Player2Label.TabIndex = 4;
            this.Player2Label.Text = "label1";
            // 
            // Player3Label
            // 
            this.Player3Label.AutoSize = true;
            this.Player3Label.Location = new System.Drawing.Point(1063, 451);
            this.Player3Label.Name = "Player3Label";
            this.Player3Label.Size = new System.Drawing.Size(35, 13);
            this.Player3Label.TabIndex = 5;
            this.Player3Label.Text = "label1";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(189, 23);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 6;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1178, 645);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Player3Label);
            this.Controls.Add(this.Player2Label);
            this.Controls.Add(this.Player1Label);
            this.Controls.Add(this.Enemy3Label);
            this.Controls.Add(this.Enemy2Label);
            this.Controls.Add(this.Enemy1Label);
            this.Name = "Form2";
            this.Text = "Turn-Based RPG";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Enemy1Label;
        private System.Windows.Forms.Label Enemy2Label;
        private System.Windows.Forms.Label Enemy3Label;
        private System.Windows.Forms.Label Player1Label;
        private System.Windows.Forms.Label Player2Label;
        private System.Windows.Forms.Label Player3Label;
        private System.Windows.Forms.TextBox textBox1;
    }
}