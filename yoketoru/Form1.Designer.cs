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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            labelHighScore = new Label();
            label6 = new Label();
            labelCopyright = new Label();
            label5 = new Label();
            tempObstacle = new Label();
            tempItem = new Label();
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
            labelTitle.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            labelTitle.Location = new Point(371, 115);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(57, 13);
            labelTitle.TabIndex = 0;
            labelTitle.Text = "よけとるCS";
            // 
            // buttonStart
            // 
            buttonStart.Location = new Point(294, 201);
            buttonStart.Name = "buttonStart";
            buttonStart.Size = new Size(212, 58);
            buttonStart.TabIndex = 1;
            buttonStart.Text = "スタート！！";
            buttonStart.UseVisualStyleBackColor = true;
            buttonStart.Click += button1_Click;
            // 
            // buttonTitle
            // 
            buttonTitle.Location = new Point(288, 274);
            buttonTitle.Name = "buttonTitle";
            buttonTitle.Size = new Size(220, 62);
            buttonTitle.TabIndex = 2;
            buttonTitle.Text = "タイトルへ";
            buttonTitle.UseVisualStyleBackColor = true;
            // 
            // labelClear
            // 
            labelClear.AutoSize = true;
            labelClear.Location = new Point(122, 126);
            labelClear.Name = "labelClear";
            labelClear.Size = new Size(14, 15);
            labelClear.TabIndex = 3;
            labelClear.Text = "C";
            // 
            // labelGameover
            // 
            labelGameover.AutoSize = true;
            labelGameover.Location = new Point(608, 126);
            labelGameover.Name = "labelGameover";
            labelGameover.Size = new Size(15, 15);
            labelGameover.TabIndex = 4;
            labelGameover.Text = "G";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(291, 12);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(384, 9);
            label2.Name = "label2";
            label2.Size = new Size(37, 15);
            label2.TabIndex = 6;
            label2.Text = "00000";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(301, 39);
            label3.Name = "label3";
            label3.Size = new Size(0, 15);
            label3.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(678, 388);
            label4.Name = "label4";
            label4.Size = new Size(25, 15);
            label4.TabIndex = 8;
            label4.Text = "000";
            // 
            // labelHighScore
            // 
            labelHighScore.AutoSize = true;
            labelHighScore.Location = new Point(353, 39);
            labelHighScore.Name = "labelHighScore";
            labelHighScore.Size = new Size(95, 15);
            labelHighScore.TabIndex = 9;
            labelHighScore.Text = "high score 00000";
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
            labelCopyright.Location = new Point(277, 374);
            labelCopyright.Name = "labelCopyright";
            labelCopyright.Size = new Size(43, 15);
            labelCopyright.TabIndex = 11;
            labelCopyright.Text = "zibunn";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(102, 181);
            label5.Name = "label5";
            label5.Size = new Size(45, 15);
            label5.TabIndex = 12;
            label5.Text = "\"(-\"\"-)\"";
            // 
            // tempObstacle
            // 
            tempObstacle.AutoSize = true;
            tempObstacle.Location = new Point(85, 260);
            tempObstacle.Name = "tempObstacle";
            tempObstacle.Size = new Size(19, 15);
            tempObstacle.TabIndex = 13;
            tempObstacle.Text = "死";
            // 
            // tempItem
            // 
            tempItem.AutoSize = true;
            tempItem.Location = new Point(159, 245);
            tempItem.Name = "tempItem";
            tempItem.Size = new Size(27, 15);
            tempItem.TabIndex = 14;
            tempItem.Text = "推し";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tempItem);
            Controls.Add(tempObstacle);
            Controls.Add(label5);
            Controls.Add(labelCopyright);
            Controls.Add(label6);
            Controls.Add(labelHighScore);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
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
        private Label label2;
        private Label label3;
        private Label label4;
        private Label labelHighScore;
        private Label label6;
        private Label labelCopyright;
        private Label label5;
        private Label tempObstacle;
        private Label tempItem;
    }
}