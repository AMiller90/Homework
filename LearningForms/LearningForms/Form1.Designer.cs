namespace LearningForms
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textOutput = new System.Windows.Forms.TextBox();
            this.clearButton = new System.Windows.Forms.Button();
            this.Editing = new System.Windows.Forms.HelpProvider();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Editing.SetHelpKeyword(this.pictureBox1, "");
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.Editing.SetShowHelp(this.pictureBox1, true);
            this.pictureBox1.Size = new System.Drawing.Size(332, 328);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // textOutput
            // 
            this.Editing.SetHelpKeyword(this.textOutput, "");
            this.textOutput.Location = new System.Drawing.Point(359, 12);
            this.textOutput.Multiline = true;
            this.textOutput.Name = "textOutput";
            this.Editing.SetShowHelp(this.textOutput, true);
            this.textOutput.Size = new System.Drawing.Size(233, 328);
            this.textOutput.TabIndex = 2;
            this.textOutput.TextChanged += new System.EventHandler(this.textOutput_TextChanged);
            this.textOutput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textOutput_KeyPress);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(359, 356);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 23);
            this.clearButton.TabIndex = 3;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // Editing
            // 
            this.Editing.HelpNamespace = "C:\\Users\\HeavensGate\\Desktop\\HTML WorkshopStuff\\Winform.chm";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 517);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.textOutput);
            this.Controls.Add(this.pictureBox1);
            this.Editing.SetHelpKeyword(this, "");
            this.Editing.SetHelpNavigator(this, System.Windows.Forms.HelpNavigator.Topic);
            this.Name = "Form1";
            this.Editing.SetShowHelp(this, true);
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textOutput;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.HelpProvider Editing;
    }
}

