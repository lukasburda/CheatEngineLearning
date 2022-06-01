namespace CELearningLvl1
{
    partial class MainWindow
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.enemyHpSetButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // enemyHpSetButton
            // 
            this.enemyHpSetButton.Location = new System.Drawing.Point(12, 12);
            this.enemyHpSetButton.Name = "enemyHpSetButton";
            this.enemyHpSetButton.Size = new System.Drawing.Size(320, 77);
            this.enemyHpSetButton.TabIndex = 0;
            this.enemyHpSetButton.Text = "Set enemy HP to 1";
            this.enemyHpSetButton.UseVisualStyleBackColor = true;
            this.enemyHpSetButton.Click += new System.EventHandler(this.enemyHpSetButton_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 101);
            this.Controls.Add(this.enemyHpSetButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainWindow";
            this.Text = "Cheat Engine: Learning level 1";
            this.ResumeLayout(false);

        }

        #endregion

        private Button enemyHpSetButton;
    }
}