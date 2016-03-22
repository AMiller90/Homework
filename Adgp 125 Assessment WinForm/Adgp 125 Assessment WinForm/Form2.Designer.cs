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
            this.CurrentStateBox = new System.Windows.Forms.TextBox();
            this.BattleText = new System.Windows.Forms.RichTextBox();
            this.BeginButton = new System.Windows.Forms.Button();
            this.Enemy1Button = new System.Windows.Forms.Button();
            this.Enemy2Button = new System.Windows.Forms.Button();
            this.Enemy3Button = new System.Windows.Forms.Button();
            this.ProcessEnemyAttack = new System.Windows.Forms.Button();
            this.BattleOrderTextBox = new System.Windows.Forms.RichTextBox();
            this.StatsBox = new System.Windows.Forms.RichTextBox();
            this.p1PictureBox = new System.Windows.Forms.PictureBox();
            this.p2PictureBox = new System.Windows.Forms.PictureBox();
            this.p3PictureBox = new System.Windows.Forms.PictureBox();
            this.e1PictureBox = new System.Windows.Forms.PictureBox();
            this.e2PictureBox = new System.Windows.Forms.PictureBox();
            this.e3PictureBox = new System.Windows.Forms.PictureBox();
            this.SaveGameButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.p1PictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.p2PictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.p3PictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.e1PictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.e2PictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.e3PictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // Enemy1Label
            // 
            this.Enemy1Label.AutoSize = true;
            this.Enemy1Label.Location = new System.Drawing.Point(353, 127);
            this.Enemy1Label.Name = "Enemy1Label";
            this.Enemy1Label.Size = new System.Drawing.Size(35, 13);
            this.Enemy1Label.TabIndex = 0;
            this.Enemy1Label.Text = "label1";
            // 
            // Enemy2Label
            // 
            this.Enemy2Label.AutoSize = true;
            this.Enemy2Label.Location = new System.Drawing.Point(527, 127);
            this.Enemy2Label.Name = "Enemy2Label";
            this.Enemy2Label.Size = new System.Drawing.Size(35, 13);
            this.Enemy2Label.TabIndex = 1;
            this.Enemy2Label.Text = "label2";
            // 
            // Enemy3Label
            // 
            this.Enemy3Label.AutoSize = true;
            this.Enemy3Label.Location = new System.Drawing.Point(697, 127);
            this.Enemy3Label.Name = "Enemy3Label";
            this.Enemy3Label.Size = new System.Drawing.Size(35, 13);
            this.Enemy3Label.TabIndex = 2;
            this.Enemy3Label.Text = "label3";
            // 
            // Player1Label
            // 
            this.Player1Label.AutoSize = true;
            this.Player1Label.Location = new System.Drawing.Point(353, 580);
            this.Player1Label.Name = "Player1Label";
            this.Player1Label.Size = new System.Drawing.Size(35, 13);
            this.Player1Label.TabIndex = 3;
            this.Player1Label.Text = "label1";
            // 
            // Player2Label
            // 
            this.Player2Label.AutoSize = true;
            this.Player2Label.Location = new System.Drawing.Point(527, 580);
            this.Player2Label.Name = "Player2Label";
            this.Player2Label.Size = new System.Drawing.Size(35, 13);
            this.Player2Label.TabIndex = 4;
            this.Player2Label.Text = "label2";
            // 
            // Player3Label
            // 
            this.Player3Label.AutoSize = true;
            this.Player3Label.Location = new System.Drawing.Point(697, 580);
            this.Player3Label.Name = "Player3Label";
            this.Player3Label.Size = new System.Drawing.Size(35, 13);
            this.Player3Label.TabIndex = 5;
            this.Player3Label.Text = "label3";
            // 
            // CurrentStateBox
            // 
            this.CurrentStateBox.Location = new System.Drawing.Point(12, 15);
            this.CurrentStateBox.Name = "CurrentStateBox";
            this.CurrentStateBox.Size = new System.Drawing.Size(100, 20);
            this.CurrentStateBox.TabIndex = 6;
            // 
            // BattleText
            // 
            this.BattleText.Location = new System.Drawing.Point(331, 191);
            this.BattleText.Name = "BattleText";
            this.BattleText.Size = new System.Drawing.Size(422, 270);
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
            this.Enemy1Button.Location = new System.Drawing.Point(340, 162);
            this.Enemy1Button.Name = "Enemy1Button";
            this.Enemy1Button.Size = new System.Drawing.Size(62, 23);
            this.Enemy1Button.TabIndex = 10;
            this.Enemy1Button.Text = "Attack";
            this.Enemy1Button.UseVisualStyleBackColor = true;
            this.Enemy1Button.Click += new System.EventHandler(this.Enemy1Button_Click);
            // 
            // Enemy2Button
            // 
            this.Enemy2Button.Location = new System.Drawing.Point(512, 162);
            this.Enemy2Button.Name = "Enemy2Button";
            this.Enemy2Button.Size = new System.Drawing.Size(62, 23);
            this.Enemy2Button.TabIndex = 11;
            this.Enemy2Button.Text = "Attack";
            this.Enemy2Button.UseVisualStyleBackColor = true;
            this.Enemy2Button.Click += new System.EventHandler(this.Enemy2Button_Click);
            // 
            // Enemy3Button
            // 
            this.Enemy3Button.Location = new System.Drawing.Point(682, 162);
            this.Enemy3Button.Name = "Enemy3Button";
            this.Enemy3Button.Size = new System.Drawing.Size(62, 23);
            this.Enemy3Button.TabIndex = 12;
            this.Enemy3Button.Text = "Attack";
            this.Enemy3Button.UseVisualStyleBackColor = true;
            this.Enemy3Button.Click += new System.EventHandler(this.Enemy3Button_Click);
            // 
            // ProcessEnemyAttack
            // 
            this.ProcessEnemyAttack.Location = new System.Drawing.Point(502, 610);
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
            // StatsBox
            // 
            this.StatsBox.Location = new System.Drawing.Point(954, 191);
            this.StatsBox.Name = "StatsBox";
            this.StatsBox.Size = new System.Drawing.Size(212, 270);
            this.StatsBox.TabIndex = 15;
            this.StatsBox.Text = "";
            // 
            // p1PictureBox
            // 
            this.p1PictureBox.Location = new System.Drawing.Point(331, 467);
            this.p1PictureBox.Name = "p1PictureBox";
            this.p1PictureBox.Size = new System.Drawing.Size(80, 110);
            this.p1PictureBox.TabIndex = 16;
            this.p1PictureBox.TabStop = false;
            // 
            // p2PictureBox
            // 
            this.p2PictureBox.Location = new System.Drawing.Point(502, 467);
            this.p2PictureBox.Name = "p2PictureBox";
            this.p2PictureBox.Size = new System.Drawing.Size(80, 110);
            this.p2PictureBox.TabIndex = 17;
            this.p2PictureBox.TabStop = false;
            // 
            // p3PictureBox
            // 
            this.p3PictureBox.Location = new System.Drawing.Point(673, 467);
            this.p3PictureBox.Name = "p3PictureBox";
            this.p3PictureBox.Size = new System.Drawing.Size(80, 110);
            this.p3PictureBox.TabIndex = 18;
            this.p3PictureBox.TabStop = false;
            // 
            // e1PictureBox
            // 
            this.e1PictureBox.Location = new System.Drawing.Point(331, 15);
            this.e1PictureBox.Name = "e1PictureBox";
            this.e1PictureBox.Size = new System.Drawing.Size(80, 110);
            this.e1PictureBox.TabIndex = 19;
            this.e1PictureBox.TabStop = false;
            // 
            // e2PictureBox
            // 
            this.e2PictureBox.Location = new System.Drawing.Point(502, 15);
            this.e2PictureBox.Name = "e2PictureBox";
            this.e2PictureBox.Size = new System.Drawing.Size(80, 110);
            this.e2PictureBox.TabIndex = 20;
            this.e2PictureBox.TabStop = false;
            // 
            // e3PictureBox
            // 
            this.e3PictureBox.Location = new System.Drawing.Point(673, 15);
            this.e3PictureBox.Name = "e3PictureBox";
            this.e3PictureBox.Size = new System.Drawing.Size(80, 110);
            this.e3PictureBox.TabIndex = 21;
            this.e3PictureBox.TabStop = false;
            // 
            // SaveGameButton
            // 
            this.SaveGameButton.Location = new System.Drawing.Point(1091, 610);
            this.SaveGameButton.Name = "SaveGameButton";
            this.SaveGameButton.Size = new System.Drawing.Size(75, 23);
            this.SaveGameButton.TabIndex = 22;
            this.SaveGameButton.Text = "Save Game";
            this.SaveGameButton.UseVisualStyleBackColor = true;
            this.SaveGameButton.Click += new System.EventHandler(this.SaveGameButton_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1178, 645);
            this.Controls.Add(this.SaveGameButton);
            this.Controls.Add(this.e3PictureBox);
            this.Controls.Add(this.e2PictureBox);
            this.Controls.Add(this.e1PictureBox);
            this.Controls.Add(this.p3PictureBox);
            this.Controls.Add(this.p2PictureBox);
            this.Controls.Add(this.p1PictureBox);
            this.Controls.Add(this.StatsBox);
            this.Controls.Add(this.BattleOrderTextBox);
            this.Controls.Add(this.ProcessEnemyAttack);
            this.Controls.Add(this.Enemy3Button);
            this.Controls.Add(this.Enemy2Button);
            this.Controls.Add(this.Enemy1Button);
            this.Controls.Add(this.BeginButton);
            this.Controls.Add(this.BattleText);
            this.Controls.Add(this.CurrentStateBox);
            this.Controls.Add(this.Player3Label);
            this.Controls.Add(this.Player2Label);
            this.Controls.Add(this.Player1Label);
            this.Controls.Add(this.Enemy3Label);
            this.Controls.Add(this.Enemy2Label);
            this.Controls.Add(this.Enemy1Label);
            this.Name = "Form2";
            this.Text = "Turn-Based RPG";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.p1PictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.p2PictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.p3PictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.e1PictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.e2PictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.e3PictureBox)).EndInit();
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
        private System.Windows.Forms.TextBox CurrentStateBox;
        private System.Windows.Forms.RichTextBox BattleText;
        private System.Windows.Forms.Button BeginButton;
        private System.Windows.Forms.Button Enemy1Button;
        private System.Windows.Forms.Button Enemy2Button;
        private System.Windows.Forms.Button Enemy3Button;
        private System.Windows.Forms.Button ProcessEnemyAttack;
        private System.Windows.Forms.RichTextBox BattleOrderTextBox;
        private System.Windows.Forms.RichTextBox StatsBox;
        private System.Windows.Forms.PictureBox p1PictureBox;
        private System.Windows.Forms.PictureBox p2PictureBox;
        private System.Windows.Forms.PictureBox p3PictureBox;
        private System.Windows.Forms.PictureBox e1PictureBox;
        private System.Windows.Forms.PictureBox e2PictureBox;
        private System.Windows.Forms.PictureBox e3PictureBox;
        private System.Windows.Forms.Button SaveGameButton;
    }
}