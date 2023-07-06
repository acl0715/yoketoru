namespace yoketoru
{
    partial class Form1
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
            components = new System.ComponentModel.Container();
            timer1 = new System.Windows.Forms.Timer(components);
            labelTitle = new Label();
            buttonStart = new Button();
            buttonTitle = new Button();
            labelClear = new Label();
            labelGameover = new Label();
            label1 = new Label();
            labelTimer = new Label();
            label3 = new Label();
            labelHighScore = new Label();
            label6 = new Label();
            labelCopyright = new Label();
            TempPlayer = new Label();
            tempObstacle = new Label();
            tempItem = new Label();
            labelscore = new Label();
            SuspendLayout();
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 50;
            timer1.Tick += timer1_Tick;
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.Font = new Font("Microsoft Sans Serif", 26.25F, FontStyle.Regular, GraphicsUnit.Point);
            labelTitle.Location = new Point(316, 115);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(169, 39);
            labelTitle.TabIndex = 0;
            labelTitle.Text = "よけとるCS";
            // 
            // buttonStart
            // 
            buttonStart.Font = new Font("Yu Gothic UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            buttonStart.Location = new Point(301, 213);
            buttonStart.Name = "buttonStart";
            buttonStart.Size = new Size(212, 58);
            buttonStart.TabIndex = 1;
            buttonStart.Text = "スタート！！";
            buttonStart.UseVisualStyleBackColor = true;
            buttonStart.Click += button1_Click;
            // 
            // buttonTitle
            // 
            buttonTitle.Font = new Font("Yu Gothic UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            buttonTitle.Location = new Point(293, 213);
            buttonTitle.Name = "buttonTitle";
            buttonTitle.Size = new Size(220, 62);
            buttonTitle.TabIndex = 2;
            buttonTitle.Text = "タイトルへ";
            buttonTitle.UseVisualStyleBackColor = true;
            buttonTitle.Click += buttonTitle_Click_1;
            // 
            // labelClear
            // 
            labelClear.AutoSize = true;
            labelClear.Font = new Font("Yu Gothic UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            labelClear.Location = new Point(342, 126);
            labelClear.Name = "labelClear";
            labelClear.Size = new Size(111, 45);
            labelClear.TabIndex = 3;
            labelClear.Text = "CLEAR";
            // 
            // labelGameover
            // 
            labelGameover.AutoSize = true;
            labelGameover.Font = new Font("Yu Gothic UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            labelGameover.Location = new Point(316, 126);
            labelGameover.Name = "labelGameover";
            labelGameover.Size = new Size(187, 45);
            labelGameover.TabIndex = 4;
            labelGameover.Text = "GAMEOVER";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(291, 12);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 5;
            // 
            // labelTimer
            // 
            labelTimer.AutoSize = true;
            labelTimer.Font = new Font("Yu Gothic UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            labelTimer.Location = new Point(696, 404);
            labelTimer.Name = "labelTimer";
            labelTimer.Size = new Size(92, 37);
            labelTimer.TabIndex = 6;
            labelTimer.Text = "00000";
            labelTimer.Click += labelTimer_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(301, 39);
            label3.Name = "label3";
            label3.Size = new Size(0, 15);
            label3.TabIndex = 7;
            // 
            // labelHighScore
            // 
            labelHighScore.AutoSize = true;
            labelHighScore.Font = new Font("Yu Gothic UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            labelHighScore.Location = new Point(316, 73);
            labelHighScore.Name = "labelHighScore";
            labelHighScore.Size = new Size(170, 30);
            labelHighScore.TabIndex = 9;
            labelHighScore.Text = "high score 00000";
            labelHighScore.Click += labelHighScore_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(216, 176);
            label6.Name = "label6";
            label6.Size = new Size(0, 15);
            label6.TabIndex = 10;
            // 
            // labelCopyright
            // 
            labelCopyright.AutoSize = true;
            labelCopyright.Font = new Font("Yu Gothic UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            labelCopyright.Location = new Point(361, 376);
            labelCopyright.Name = "labelCopyright";
            labelCopyright.Size = new Size(70, 25);
            labelCopyright.TabIndex = 11;
            labelCopyright.Text = "zibunn";
            // 
            // TempPlayer
            // 
            TempPlayer.AutoSize = true;
            TempPlayer.Location = new Point(1, 9);
            TempPlayer.Name = "TempPlayer";
            TempPlayer.Size = new Size(35, 15);
            TempPlayer.TabIndex = 12;
            TempPlayer.Text = "(-ω-)";
            // 
            // tempObstacle
            // 
            tempObstacle.AutoSize = true;
            tempObstacle.Location = new Point(5, 34);
            tempObstacle.Name = "tempObstacle";
            tempObstacle.Size = new Size(31, 15);
            tempObstacle.TabIndex = 13;
            tempObstacle.Text = "労働";
            // 
            // tempItem
            // 
            tempItem.AutoSize = true;
            tempItem.Location = new Point(5, 49);
            tempItem.Name = "tempItem";
            tempItem.Size = new Size(27, 15);
            tempItem.TabIndex = 14;
            tempItem.Text = "推し";
            // 
            // labelscore
            // 
            labelscore.AutoSize = true;
            labelscore.Font = new Font("Yu Gothic UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            labelscore.Location = new Point(361, 12);
            labelscore.Name = "labelscore";
            labelscore.Size = new Size(92, 37);
            labelscore.TabIndex = 15;
            labelscore.Text = "00000";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(labelscore);
            Controls.Add(tempItem);
            Controls.Add(tempObstacle);
            Controls.Add(TempPlayer);
            Controls.Add(labelCopyright);
            Controls.Add(label6);
            Controls.Add(labelHighScore);
            Controls.Add(label3);
            Controls.Add(labelTimer);
            Controls.Add(label1);
            Controls.Add(labelGameover);
            Controls.Add(labelClear);
            Controls.Add(buttonTitle);
            Controls.Add(buttonStart);
            Controls.Add(labelTitle);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private Label labelTitle;
        private Button buttonStart;
        private Button buttonTitle;
        private Label labelClear;
        private Label labelGameover;
        private Label label1;
        private Label labelTimer;
        private Label label3;
        private Label labelHighScore;
        private Label label6;
        private Label labelCopyright;
        private Label TempPlayer;
        private Label tempObstacle;
        private Label tempItem;
        private Label labelscore;
    }
}