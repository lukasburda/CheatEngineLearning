namespace CELearningLvl2
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
            this.components = new System.ComponentModel.Container();
            this.infoPanel = new System.Windows.Forms.Panel();
            this.EnemyTwoHealthLabel = new System.Windows.Forms.Label();
            this.EnemyOneHealthLabel = new System.Windows.Forms.Label();
            this.enemyTwoLabel = new System.Windows.Forms.Label();
            this.enemyOneLabel = new System.Windows.Forms.Label();
            this.healthAmountLabel = new System.Windows.Forms.Label();
            this.healthTextLabel = new System.Windows.Forms.Label();
            this.refreshTimer = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.enemyTwoSetButton = new System.Windows.Forms.Button();
            this.enemyOneSetButton = new System.Windows.Forms.Button();
            this.enemyTwoHpTextBox = new System.Windows.Forms.TextBox();
            this.enemyOneHpTextBox = new System.Windows.Forms.TextBox();
            this.EnemyTwoHpLabel = new System.Windows.Forms.Label();
            this.enemyOneHpLabel = new System.Windows.Forms.Label();
            this.hpContinuousSet = new System.Windows.Forms.Button();
            this.hpSetButton = new System.Windows.Forms.Button();
            this.hpTextBox = new System.Windows.Forms.TextBox();
            this.playerHpModifiyLabel = new System.Windows.Forms.Label();
            this.hpUpdater = new System.Windows.Forms.Timer(this.components);
            this.infoPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // infoPanel
            // 
            this.infoPanel.Controls.Add(this.EnemyTwoHealthLabel);
            this.infoPanel.Controls.Add(this.EnemyOneHealthLabel);
            this.infoPanel.Controls.Add(this.enemyTwoLabel);
            this.infoPanel.Controls.Add(this.enemyOneLabel);
            this.infoPanel.Controls.Add(this.healthAmountLabel);
            this.infoPanel.Controls.Add(this.healthTextLabel);
            this.infoPanel.Location = new System.Drawing.Point(12, 12);
            this.infoPanel.Name = "infoPanel";
            this.infoPanel.Size = new System.Drawing.Size(465, 141);
            this.infoPanel.TabIndex = 0;
            // 
            // EnemyTwoHealthLabel
            // 
            this.EnemyTwoHealthLabel.AutoSize = true;
            this.EnemyTwoHealthLabel.Font = new System.Drawing.Font("Microsoft JhengHei", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.EnemyTwoHealthLabel.Location = new System.Drawing.Point(189, 98);
            this.EnemyTwoHealthLabel.Name = "EnemyTwoHealthLabel";
            this.EnemyTwoHealthLabel.Size = new System.Drawing.Size(27, 30);
            this.EnemyTwoHealthLabel.TabIndex = 5;
            this.EnemyTwoHealthLabel.Text = "0";
            // 
            // EnemyOneHealthLabel
            // 
            this.EnemyOneHealthLabel.AutoSize = true;
            this.EnemyOneHealthLabel.Font = new System.Drawing.Font("Microsoft JhengHei", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.EnemyOneHealthLabel.Location = new System.Drawing.Point(189, 51);
            this.EnemyOneHealthLabel.Name = "EnemyOneHealthLabel";
            this.EnemyOneHealthLabel.Size = new System.Drawing.Size(27, 30);
            this.EnemyOneHealthLabel.TabIndex = 4;
            this.EnemyOneHealthLabel.Text = "0";
            // 
            // enemyTwoLabel
            // 
            this.enemyTwoLabel.AutoSize = true;
            this.enemyTwoLabel.Font = new System.Drawing.Font("Microsoft JhengHei", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.enemyTwoLabel.Location = new System.Drawing.Point(18, 98);
            this.enemyTwoLabel.Name = "enemyTwoLabel";
            this.enemyTwoLabel.Size = new System.Drawing.Size(115, 30);
            this.enemyTwoLabel.TabIndex = 3;
            this.enemyTwoLabel.Text = "Enemy 2:";
            // 
            // enemyOneLabel
            // 
            this.enemyOneLabel.AutoSize = true;
            this.enemyOneLabel.Font = new System.Drawing.Font("Microsoft JhengHei", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.enemyOneLabel.Location = new System.Drawing.Point(18, 51);
            this.enemyOneLabel.Name = "enemyOneLabel";
            this.enemyOneLabel.Size = new System.Drawing.Size(115, 30);
            this.enemyOneLabel.TabIndex = 2;
            this.enemyOneLabel.Text = "Enemy 1:";
            // 
            // healthAmountLabel
            // 
            this.healthAmountLabel.AutoSize = true;
            this.healthAmountLabel.Font = new System.Drawing.Font("Microsoft JhengHei", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.healthAmountLabel.Location = new System.Drawing.Point(189, 9);
            this.healthAmountLabel.Name = "healthAmountLabel";
            this.healthAmountLabel.Size = new System.Drawing.Size(27, 30);
            this.healthAmountLabel.TabIndex = 1;
            this.healthAmountLabel.Text = "0";
            // 
            // healthTextLabel
            // 
            this.healthTextLabel.AutoSize = true;
            this.healthTextLabel.Font = new System.Drawing.Font("Microsoft JhengHei", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.healthTextLabel.Location = new System.Drawing.Point(18, 9);
            this.healthTextLabel.Name = "healthTextLabel";
            this.healthTextLabel.Size = new System.Drawing.Size(165, 30);
            this.healthTextLabel.TabIndex = 0;
            this.healthTextLabel.Text = "Player health:";
            // 
            // refreshTimer
            // 
            this.refreshTimer.Tick += new System.EventHandler(this.refresher_Tick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.enemyTwoSetButton);
            this.panel1.Controls.Add(this.enemyOneSetButton);
            this.panel1.Controls.Add(this.enemyTwoHpTextBox);
            this.panel1.Controls.Add(this.enemyOneHpTextBox);
            this.panel1.Controls.Add(this.EnemyTwoHpLabel);
            this.panel1.Controls.Add(this.enemyOneHpLabel);
            this.panel1.Controls.Add(this.hpContinuousSet);
            this.panel1.Controls.Add(this.hpSetButton);
            this.panel1.Controls.Add(this.hpTextBox);
            this.panel1.Controls.Add(this.playerHpModifiyLabel);
            this.panel1.Location = new System.Drawing.Point(12, 159);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(465, 190);
            this.panel1.TabIndex = 1;
            // 
            // enemyTwoSetButton
            // 
            this.enemyTwoSetButton.Location = new System.Drawing.Point(387, 154);
            this.enemyTwoSetButton.Name = "enemyTwoSetButton";
            this.enemyTwoSetButton.Size = new System.Drawing.Size(75, 23);
            this.enemyTwoSetButton.TabIndex = 11;
            this.enemyTwoSetButton.Text = "Set";
            this.enemyTwoSetButton.UseVisualStyleBackColor = true;
            this.enemyTwoSetButton.Click += new System.EventHandler(this.enemyTwoSetButton_Click);
            // 
            // enemyOneSetButton
            // 
            this.enemyOneSetButton.Location = new System.Drawing.Point(387, 85);
            this.enemyOneSetButton.Name = "enemyOneSetButton";
            this.enemyOneSetButton.Size = new System.Drawing.Size(75, 23);
            this.enemyOneSetButton.TabIndex = 8;
            this.enemyOneSetButton.Text = "Set";
            this.enemyOneSetButton.UseVisualStyleBackColor = true;
            this.enemyOneSetButton.Click += new System.EventHandler(this.enemyOneSetButton_Click);
            // 
            // enemyTwoHpTextBox
            // 
            this.enemyTwoHpTextBox.Location = new System.Drawing.Point(162, 153);
            this.enemyTwoHpTextBox.Name = "enemyTwoHpTextBox";
            this.enemyTwoHpTextBox.Size = new System.Drawing.Size(219, 23);
            this.enemyTwoHpTextBox.TabIndex = 7;
            this.enemyTwoHpTextBox.Text = "1";
            this.enemyTwoHpTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // enemyOneHpTextBox
            // 
            this.enemyOneHpTextBox.Location = new System.Drawing.Point(162, 84);
            this.enemyOneHpTextBox.Name = "enemyOneHpTextBox";
            this.enemyOneHpTextBox.Size = new System.Drawing.Size(219, 23);
            this.enemyOneHpTextBox.TabIndex = 6;
            this.enemyOneHpTextBox.Text = "1";
            this.enemyOneHpTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // EnemyTwoHpLabel
            // 
            this.EnemyTwoHpLabel.AutoSize = true;
            this.EnemyTwoHpLabel.Font = new System.Drawing.Font("Microsoft JhengHei", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.EnemyTwoHpLabel.Location = new System.Drawing.Point(3, 146);
            this.EnemyTwoHpLabel.Name = "EnemyTwoHpLabel";
            this.EnemyTwoHpLabel.Size = new System.Drawing.Size(153, 30);
            this.EnemyTwoHpLabel.TabIndex = 5;
            this.EnemyTwoHpLabel.Text = "Enemy 2 HP:";
            // 
            // enemyOneHpLabel
            // 
            this.enemyOneHpLabel.AutoSize = true;
            this.enemyOneHpLabel.Font = new System.Drawing.Font("Microsoft JhengHei", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.enemyOneHpLabel.Location = new System.Drawing.Point(3, 77);
            this.enemyOneHpLabel.Name = "enemyOneHpLabel";
            this.enemyOneHpLabel.Size = new System.Drawing.Size(153, 30);
            this.enemyOneHpLabel.TabIndex = 4;
            this.enemyOneHpLabel.Text = "Enemy 1 HP:";
            // 
            // hpContinuousSet
            // 
            this.hpContinuousSet.Location = new System.Drawing.Point(353, 19);
            this.hpContinuousSet.Name = "hpContinuousSet";
            this.hpContinuousSet.Size = new System.Drawing.Size(109, 23);
            this.hpContinuousSet.TabIndex = 3;
            this.hpContinuousSet.Text = "Set continuously";
            this.hpContinuousSet.UseVisualStyleBackColor = true;
            this.hpContinuousSet.Click += new System.EventHandler(this.hpContinuousSet_Click);
            // 
            // hpSetButton
            // 
            this.hpSetButton.Location = new System.Drawing.Point(272, 19);
            this.hpSetButton.Name = "hpSetButton";
            this.hpSetButton.Size = new System.Drawing.Size(75, 23);
            this.hpSetButton.TabIndex = 2;
            this.hpSetButton.Text = "Set";
            this.hpSetButton.UseVisualStyleBackColor = true;
            this.hpSetButton.Click += new System.EventHandler(this.hpSetButton_Click);
            // 
            // hpTextBox
            // 
            this.hpTextBox.Location = new System.Drawing.Point(134, 19);
            this.hpTextBox.Name = "hpTextBox";
            this.hpTextBox.Size = new System.Drawing.Size(132, 23);
            this.hpTextBox.TabIndex = 1;
            this.hpTextBox.Text = "100";
            this.hpTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // playerHpModifiyLabel
            // 
            this.playerHpModifiyLabel.AutoSize = true;
            this.playerHpModifiyLabel.Font = new System.Drawing.Font("Microsoft JhengHei", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.playerHpModifiyLabel.Location = new System.Drawing.Point(3, 10);
            this.playerHpModifiyLabel.Name = "playerHpModifiyLabel";
            this.playerHpModifiyLabel.Size = new System.Drawing.Size(125, 30);
            this.playerHpModifiyLabel.TabIndex = 0;
            this.playerHpModifiyLabel.Text = "Player HP:";
            // 
            // hpUpdater
            // 
            this.hpUpdater.Tick += new System.EventHandler(this.hpUpdater_Tick);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 361);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.infoPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "MainWindow";
            this.Text = "Cheat Engine: Learning Level 2";
            this.infoPanel.ResumeLayout(false);
            this.infoPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel infoPanel;
        private Label healthTextLabel;
        private Label healthAmountLabel;
        private System.Windows.Forms.Timer refreshTimer;
        private Panel panel1;
        private Label playerHpModifiyLabel;
        private Button hpSetButton;
        private TextBox hpTextBox;
        private Button hpContinuousSet;
        private System.Windows.Forms.Timer hpUpdater;
        private Label enemyTwoLabel;
        private Label enemyOneLabel;
        private Label EnemyOneHealthLabel;
        private Label EnemyTwoHealthLabel;
        private TextBox enemyTwoHpTextBox;
        private TextBox enemyOneHpTextBox;
        private Label EnemyTwoHpLabel;
        private Label enemyOneHpLabel;
        private Button enemyTwoSetButton;
        private Button enemyOneSetButton;
    }
}