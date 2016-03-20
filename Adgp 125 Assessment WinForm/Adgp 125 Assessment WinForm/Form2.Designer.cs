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
            this.BattleText = new System.Windows.Forms.RichTextBox();
            this.BeginButton = new System.Windows.Forms.Button();
            this.Enemy1Button = new System.Windows.Forms.Button();
            this.Enemy2Button = new System.Windows.Forms.Button();
            this.Enemy3Button = new System.Windows.Forms.Button();
            this.ProcessEnemyAttack = new System.Windows.Forms.Button();
            this.BattleOrderTextBox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // Enemy1Label
            // 
            this.Enemy1Label.AutoSize = true;
            this.Enemy1Label.Location = new System.Drawing.Point(344, 84);
            this.Enemy1Label.Name = "Enemy1Label";
            this.Enemy1Label.Size = new System.Drawing.Size(35, 13);
            this.Enemy1Label.TabIndex = 0;
            this.Enemy1Label.Text = "label1";
            // 
            // Enemy2Label
            // 
            this.Enemy2Label.AutoSize = true;
            this.Enemy2Label.Location = new System.Drawing.Point(541, 84);
            this.Enemy2Label.Name = "Enemy2Label";
            this.Enemy2Label.Size = new System.Drawing.Size(35, 13);
            this.Enemy2Label.TabIndex = 1;
            this.Enemy2Label.Text = "label2";
            // 
            // Enemy3Label
            // 
            this.Enemy3Label.AutoSize = true;
            this.Enemy3Label.Location = new System.Drawing.Point(731, 84);
            this.Enemy3Label.Name = "Enemy3Label";
            this.Enemy3Label.Size = new System.Drawing.Size(35, 13);
            this.Enemy3Label.TabIndex = 2;
            this.Enemy3Label.Text = "label3";
            // 
            // Player1Label
            // 
            this.Player1Label.AutoSize = true;
            this.Player1Label.Location = new System.Drawing.Point(328, 520);
            this.Player1Label.Name = "Player1Label";
            this.Player1Label.Size = new System.Drawing.Size(35, 13);
            this.Player1Label.TabIndex = 3;
            this.Player1Label.Text = "label1";
            // 
            // Player2Label
            // 
            this.Player2Label.AutoSize = true;
            this.Player2Label.Location = new System.Drawing.Point(541, 520);
            this.Player2Label.Name = "Player2Label";
            this.Player2Label.Size = new System.Drawing.Size(35, 13);
            this.Player2Label.TabIndex = 4;
            this.Player2Label.Text = "label2";
            // 
            // Player3Label
            // 
            this.Player3Label.AutoSize = true;
            this.Player3Label.Location = new System.Drawing.Point(744, 520);
            this.Player3Label.Name = "Player3Label";
            this.Player3Label.Size = new System.Drawing.Size(35, 13);
            this.Player3Label.TabIndex = 5;
            this.Player3Label.Text = "label3";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(502, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 6;
            // 
            // BattleText
            // 
            this.BattleText.Location = new System.Drawing.Point(331, 191);
            this.BattleText.Name = "BattleText";
            this.BattleText.Size = new System.Drawing.Size(448, 270);
            this.BattleText.TabIndex = 8;
            this.BattleText.Text = "";
            // 
            // BeginButton
            // 
            this.BeginButton.Location = new System.Drawing.Point(12, 610);
            this.BeginButton.Name = "BeginButton";
            this.BeginButton.Size = new System.Drawing.Size(75, 23);
            this.BeginButton.TabIndex = 9;
            this.BeginButton.Text = "Start Battle";
            this.BeginButton.UseVisualStyleBackColor = true;
            this.BeginButton.Click += new System.EventHandler(this.BeginButton_Click);
            // 
            // Enemy1Button
            // 
            this.Enemy1Button.Location = new System.Drawing.Point(331, 114);
            this.Enemy1Button.Name = "Enemy1Button";
            this.Enemy1Button.Size = new System.Drawing.Size(62, 23);
            this.Enemy1Button.TabIndex = 10;
            this.Enemy1Button.Text = "Attack";
            this.Enemy1Button.UseVisualStyleBackColor = true;
            this.Enemy1Button.Click += new System.EventHandler(this.Enemy1Button_Click);
            // 
            // Enemy2Button
            // 
            this.Enemy2Button.Location = new System.Drawing.Point(524, 114);
            this.Enemy2Button.Name = "Enemy2Button";
            this.Enemy2Button.Size = new System.Drawing.Size(62, 23);
            this.Enemy2Button.TabIndex = 11;
            this.Enemy2Button.Text = "Attack";
            this.Enemy2Button.UseVisualStyleBackColor = true;
            this.Enemy2Button.Click += new System.EventHandler(this.Enemy2Button_Click);
            // 
            // Enemy3Button
            // 
            this.Enemy3Button.Location = new System.Drawing.Point(717, 114);
            this.Enemy3Button.Name = "Enemy3Button";
            this.Enemy3Button.Size = new System.Drawing.Size(62, 23);
            this.Enemy3Button.TabIndex = 12;
            this.Enemy3Button.Text = "Attack";
            this.Enemy3Button.UseVisualStyleBackColor = true;
            this.Enemy3Button.Click += new System.EventHandler(this.Enemy3Button_Click);
            // 
            // ProcessEnemyAttack
            // 
            this.ProcessEnemyAttack.Location = new System.Drawing.Point(493, 567);
            this.ProcessEnemyAttack.Name = "ProcessEnemyAttack";
            this.ProcessEnemyAttack.Size = new System.Drawing.Size(121, 23);
            this.ProcessEnemyAttack.TabIndex = 13;
            this.ProcessEnemyAttack.Text = "Process Enemy Turn";
            this.ProcessEnemyAttack.UseVisualStyleBackColor = true;
            this.ProcessEnemyAttack.Click += new System.EventHandler(this.ProcessEnemyAttack_Click);
            // 
            // BattleOrderTextBox
            // 
            this.BattleOrderTextBox.Location = new System.Drawing.Point(12, 191);
            this.BattleOrderTextBox.Name = "BattleOrderTextBox";
            this.BattleOrderTextBox.Size = new System.Drawing.Size(181, 270);
            this.BattleOrderTextBox.TabIndex = 14;
            this.BattleOrderTextBox.Text = "Order Of Battle:";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1178, 645);
            this.Controls.Add(this.BattleOrderTextBox);
            this.Controls.Add(this.ProcessEnemyAttack);
            this.Controls.Add(this.Enemy3Button);
            this.Controls.Add(this.Enemy2Button);
            this.Controls.Add(this.Enemy1Button);
            this.Controls.Add(this.BeginButton);
            this.Controls.Add(this.BattleText);
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
        private System.Windows.Forms.RichTextBox BattleText;
        private System.Windows.Forms.Button BeginButton;
        private System.Windows.Forms.Button Enemy1Button;
        private System.Windows.Forms.Button Enemy2Button;
        private System.Windows.Forms.Button Enemy3Button;
        private System.Windows.Forms.Button ProcessEnemyAttack;
        private System.Windows.Forms.RichTextBox BattleOrderTextBox;
    }
}