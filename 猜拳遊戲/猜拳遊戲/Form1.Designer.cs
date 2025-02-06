namespace 猜拳遊戲
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
            imageList1 = new ImageList(components);
            pictureBox_scissors = new PictureBox();
            pictureBox_stone = new PictureBox();
            pictureBox_paper = new PictureBox();
            label4 = new Label();
            gameTime = new System.Windows.Forms.Timer(components);
            user_result = new PictureBox();
            computer_result = new PictureBox();
            submit = new Button();
            startGame = new Button();
            showTime = new Label();
            result = new Label();
            groupBox1 = new GroupBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox_scissors).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox_stone).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox_paper).BeginInit();
            ((System.ComponentModel.ISupportInitialize)user_result).BeginInit();
            ((System.ComponentModel.ISupportInitialize)computer_result).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageSize = new Size(16, 16);
            imageList1.TransparentColor = Color.Transparent;
            // 
            // pictureBox_scissors
            // 
            pictureBox_scissors.Image = Properties.Resources.scissors;
            pictureBox_scissors.Location = new Point(11, 27);
            pictureBox_scissors.Name = "pictureBox_scissors";
            pictureBox_scissors.Size = new Size(173, 173);
            pictureBox_scissors.TabIndex = 0;
            pictureBox_scissors.TabStop = false;
            pictureBox_scissors.Click += pictureBox1_Click;
            // 
            // pictureBox_stone
            // 
            pictureBox_stone.Image = Properties.Resources.stone;
            pictureBox_stone.Location = new Point(190, 27);
            pictureBox_stone.Name = "pictureBox_stone";
            pictureBox_stone.Size = new Size(173, 173);
            pictureBox_stone.TabIndex = 1;
            pictureBox_stone.TabStop = false;
            pictureBox_stone.Click += pictureBox2_Click;
            // 
            // pictureBox_paper
            // 
            pictureBox_paper.Image = Properties.Resources.paper;
            pictureBox_paper.Location = new Point(369, 27);
            pictureBox_paper.Name = "pictureBox_paper";
            pictureBox_paper.Size = new Size(173, 173);
            pictureBox_paper.TabIndex = 2;
            pictureBox_paper.TabStop = false;
            pictureBox_paper.Click += pictureBox3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft JhengHei UI", 20F, FontStyle.Bold);
            label4.Location = new Point(37, 89);
            label4.Name = "label4";
            label4.Size = new Size(123, 35);
            label4.TabIndex = 6;
            label4.Text = "猜拳遊戲";
            // 
            // gameTime
            // 
            gameTime.Interval = 1000;
            // 
            // user_result
            // 
            user_result.BorderStyle = BorderStyle.FixedSingle;
            user_result.Location = new Point(260, 281);
            user_result.Name = "user_result";
            user_result.Size = new Size(173, 173);
            user_result.TabIndex = 7;
            user_result.TabStop = false;
            // 
            // computer_result
            // 
            computer_result.Location = new Point(516, 281);
            computer_result.Name = "computer_result";
            computer_result.Size = new Size(173, 173);
            computer_result.TabIndex = 8;
            computer_result.TabStop = false;
            // 
            // submit
            // 
            submit.Location = new Point(304, 460);
            submit.Name = "submit";
            submit.Size = new Size(75, 23);
            submit.TabIndex = 9;
            submit.Text = "確認";
            submit.UseVisualStyleBackColor = true;
            submit.Click += submit_Click;
            // 
            // startGame
            // 
            startGame.Font = new Font("Microsoft JhengHei UI", 9F, FontStyle.Bold);
            startGame.Location = new Point(48, 143);
            startGame.Name = "startGame";
            startGame.Size = new Size(95, 35);
            startGame.TabIndex = 10;
            startGame.Text = "開始遊戲";
            startGame.UseVisualStyleBackColor = true;
            startGame.Click += button1_Click;
            // 
            // showTime
            // 
            showTime.AutoSize = true;
            showTime.Font = new Font("Microsoft JhengHei UI", 14F, FontStyle.Bold);
            showTime.Location = new Point(79, 201);
            showTime.Name = "showTime";
            showTime.Size = new Size(32, 24);
            showTime.TabIndex = 11;
            showTime.Text = "30";
            // 
            // result
            // 
            result.AutoSize = true;
            result.Font = new Font("Microsoft JhengHei UI", 20F);
            result.Location = new Point(456, 354);
            result.Name = "result";
            result.Size = new Size(0, 35);
            result.TabIndex = 12;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(pictureBox_scissors);
            groupBox1.Controls.Add(pictureBox_stone);
            groupBox1.Controls.Add(pictureBox_paper);
            groupBox1.Font = new Font("Microsoft JhengHei UI", 12F);
            groupBox1.Location = new Point(194, 49);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(553, 217);
            groupBox1.TabIndex = 14;
            groupBox1.TabStop = false;
            groupBox1.Text = "請出拳";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(32, 290);
            label1.Name = "label1";
            label1.Size = new Size(140, 105);
            label1.TabIndex = 15;
            label1.Text = "遊戲規則:\r\n\r\n1. 遊戲時間30秒\r\n\r\n2. 按下開始遊戲才會開始\r\n\r\n3. 選擇圖片來出拳吧~";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft JhengHei UI", 18F);
            label2.Location = new Point(217, 354);
            label2.Name = "label2";
            label2.Size = new Size(37, 30);
            label2.TabIndex = 16;
            label2.Text = "您";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft JhengHei UI", 18F);
            label3.Location = new Point(695, 354);
            label3.Name = "label3";
            label3.Size = new Size(109, 30);
            label3.TabIndex = 17;
            label3.Text = "超強電腦";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(816, 508);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(result);
            Controls.Add(showTime);
            Controls.Add(startGame);
            Controls.Add(submit);
            Controls.Add(computer_result);
            Controls.Add(user_result);
            Controls.Add(label4);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "猜拳小遊戲";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox_scissors).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox_stone).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox_paper).EndInit();
            ((System.ComponentModel.ISupportInitialize)user_result).EndInit();
            ((System.ComponentModel.ISupportInitialize)computer_result).EndInit();
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ImageList imageList1;
        private PictureBox pictureBox_scissors;
        private PictureBox pictureBox_stone;
        private PictureBox pictureBox_paper;
        private Label label4;
        private System.Windows.Forms.Timer gameTime;
        private PictureBox user_result;
        private PictureBox computer_result;
        private Button submit;
        private Button startGame;
        private Label showTime;
        private Label result;
        private GroupBox groupBox1;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}
