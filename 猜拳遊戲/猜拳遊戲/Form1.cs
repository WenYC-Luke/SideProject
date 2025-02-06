using System.Diagnostics.Tracing;
using System.Windows.Forms;

namespace 猜拳遊戲
{
    public partial class Form1 : Form
    {
        //電腦選擇圖片
        Random random = new Random();
        Image[] images;

        //勝負計數
        int userWin, userLoss, userTie;

        //時間計數
        int gameStartTime;
        System.Windows.Forms.Timer gameTimer;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            images = new Image[] { pictureBox_scissors.Image, pictureBox_stone.Image, pictureBox_paper.Image };
            gameTimer = new System.Windows.Forms.Timer();

            submit.Enabled = false;
            pictureBox_scissors.Enabled = false;
            pictureBox_stone.Enabled = false;
            pictureBox_paper.Enabled = false;

        }

        //開始遊戲btn
        private void button1_Click(object sender, EventArgs e)
        {
            submit.Enabled = true;
            pictureBox_scissors.Enabled = true;
            pictureBox_stone.Enabled = true;
            pictureBox_paper.Enabled = true;

            //計時器
            gameStartTime = 30;
            gameTimer.Interval = 1000;
            gameTimer.Start();

            //倒計時事件
            gameTimer.Tick += (s, e) =>
            {
                if (gameStartTime > 0)
                {
                    gameStartTime--;
                    showTime.Text = $"剩餘{gameStartTime}秒";
                }
                else if (gameStartTime == 0)
                {
                    gameTimer.Stop();
                    showTime.Text = $"時間到";

                    DialogResult result = MessageBox.Show($"您 勝{userWin}\n 敗{userLoss}\n 平{userTie}\n 是否再來一局?", "時間到", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (result == DialogResult.Yes)
                    {
                        InitialGame();
                    }
                    else if (result == DialogResult.No)
                    {
                        Application.Exit();
                    }
                }
            };
        }

        //重來遊戲
        private void InitialGame()
        {
            submit.Enabled = false;
            computer_result.Image = null;
            pictureBox_scissors.Enabled = false;
            pictureBox_stone.Enabled = false;
            pictureBox_paper.Enabled = false;
            userWin = 0;
            userLoss = 0;
            userTie = 0;
        }

        //放入圖片-剪刀
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            user_result.Image = pictureBox_scissors.Image;
        }
        //放入圖片-石頭
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            user_result.Image = pictureBox_stone.Image;
        }
        //放入圖片-布
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            user_result.Image = pictureBox_paper.Image;
        }


        //決定選擇
        private void submit_Click(object sender, EventArgs e)
        {
            if (user_result.Image != null)
            {
                //電腦隨機選圖片
                int randomIndex = random.Next(0, 3);
                computer_result.Image = images[randomIndex];

                int userImgIdx = Array.IndexOf(images, user_result.Image);
                int computerImgIdx = Array.IndexOf(images, computer_result.Image);
                
                //比較勝負
                if (userImgIdx == computerImgIdx)
                {
                    result.Text = "平";
                    result.ForeColor = Color.Black;
                    userTie++;
                }
                else if ((userImgIdx == 0 && computerImgIdx == 1) ||
                         (userImgIdx == 1 && computerImgIdx == 2) ||
                         (userImgIdx == 2 && computerImgIdx == 0))
                {
                    result.Text = "敗";
                    result.ForeColor = Color.Blue;
                    userLoss++;
                }
                else
                {
                    result.Text = "勝";
                    result.ForeColor = Color.Red;
                    userWin++;
                }
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
