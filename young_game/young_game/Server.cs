using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

using System.Net;
using System.Net.Sockets;
using System.Xml.Linq;
using System.Security.Cryptography;

namespace young_game
{
    public partial class Server : Form
    {

        static Form1 F_1; // 게임 로비 
        static GamePlay G_P_F; // 메인 게임
        static Game_Help G_H_F; // 사용자 설정
       // static Client C_S_R;

        static Game_Engine G_E_Function = new Game_Engine(); // 게임 

        public int I_GHF_Check = -1; //사용자 설정 확인 버튼 여부

        public int I_F1_Check = -1; //게임 로비 버튼 여부

        string Fm_Conut; // 폼 활성화 갯수

        string[] S_Problem; //문제 or 정답 Split 변수
        string S_PcAnswer; // pc정답
        string S_UserAnswer; // 유저 정답

        int I_Enter_Conut = 0; // 남은 문제 횟수
        int I_Problem_Conut = 1; // 유저가 푼 문제 횟수

        int Game_Start = 0; // 게임 로딩 액션 부분

        string S_total; // 최종 MessageBox 출력될 부분

        public Server()
        {
            InitializeComponent();
        }
        public Server(GamePlay G_Play)
        {
            InitializeComponent();
            G_P_F = G_Play;
        }

        public Server(Game_Help G_Hely)
        {
            InitializeComponent();
            G_H_F = G_Hely;
        }

       
        private void timer1_Tick(object sender, EventArgs e)
        {
            if(Game_Start == 0 && F_1 == null)
            {
                F_1 = new Form1();
                F_1.Opacity = 0;
                F_1.Show();
                Thread.Sleep(1000);
                this.Opacity = 0;
                F_1.Opacity = 100;
            } // 로딩 화면 액션 부분

            Fm_Conut = Application.OpenForms.Count.ToString(); //활성화되어 있는 폼의 갯수

            if(Fm_Conut == "1")
            {
                Application.Exit();
            }// 서버를 제외한 폼이 없을시 서버 종료

            if (I_F1_Check == 1 && F_1 != null)
            {
                G_H_F = new Game_Help();
                I_F1_Check = -1;
                G_H_F.ShowDialog();
                F_1.button1.Enabled = true;
            }// 사용자 설정 버튼

            if(F_1.button1.Enabled == true)
            {
                F_1.button1.Image = Properties.Resources.Button_PNG_Free_Download;
            }//게임시작 버튼 활성화 이미지

            if (I_GHF_Check == 0 && G_H_F != null)
            {
                G_H_F.Dispose();
                I_GHF_Check = -1;
            } // 사용자 설정 확인 버튼 액션 부분

            /// <summary>
            ///if(F_1.OnOff.Text == "OnLine")
            ///{
            ///    if(C_S_R == null)
            ///    { 
            ///    C_S_R = new Client();
            ///    C_S_R.Client_Run();
            ///    }
            ///}//OnLine or OffLine

            if (I_F1_Check == 0 && F_1 != null) 
            {
                G_P_F = new GamePlay();
                G_P_F.Show(); // 폼play 생성
                F_1.Close();
                I_F1_Check = -1;
            }// 메인 게임 시작 버튼

            if (G_P_F != null)
            {
                if (G_P_F.label2.Text.Length > 0 && G_P_F.label2.Text.Length < 8)
                { 
                G_P_F.button10.Enabled = true;
                } // Enter 활성화

                else
                {
                G_P_F.button10.Enabled = false;
                } // 조건에 부합하지 않으면 Enter 비활성화

                if (I_Enter_Conut == G_H_F.hScrollBar1.Value) 
                {
                    I_Enter_Conut = 0;
                    F_1 = new Form1();
                    F_1.Show();
                    G_P_F.Dispose();

                    foreach (var indexItem in G_P_F.listBox1.Items)
                    {
                        S_total += string.Format("{0}\n", indexItem);
                    }// 변수에 모든 기록 담기

                    MessageBox.Show(S_total);
                    
                }//게임 종료

            } //메인 게임 시작 하면
        }
        public void Number_Case(int str) // 버튼 누른 번호에 따른 함수
        {
            if (str >= 0 && str <= 9) 
            {
                G_P_F.label2.Text += str.ToString();
            }//number 0 ~ 9번까지
            else if (str == 11) 
            {
                if (G_P_F.label2.Text.Length != 0)
                    G_P_F.label2.Text = G_P_F.label2.Text.Substring(0, G_P_F.label2.Text.Length - 1);
            }// <- 버튼
            else
            {
                I_Enter_Conut++;
                S_UserAnswer = G_P_F.label2.Text; // 유저가 입력한 정답
                int I_UserAnswer = Convert.ToInt32(S_UserAnswer);
                int I_PcAnswer = Convert.ToInt32(S_PcAnswer);
                if (I_UserAnswer == I_PcAnswer)
                {
                    G_P_F.listBox1.Items.Add(string.Format("{0}문제 정답입니다.", I_Problem_Conut));
                    G_P_F.listBox1.SelectedIndex = G_P_F.listBox1.Items.Count - 1;
                   I_Problem_Conut++;
                    Problem_label();// 다음 문제 출력
                }// 유저 정답 확인 부분

                else
                {
                    G_P_F.listBox1.Items.Add(string.Format("{0}문제 오답입니다.", I_Problem_Conut));
                    G_P_F.listBox1.SelectedIndex = G_P_F.listBox1.Items.Count - 1;
                    I_Problem_Conut++;
                     Problem_label();// 다음 문제 출력
                }// 유저 오답

                G_P_F.label2.Text = String.Empty; // 라벨 초기화

            } // Enter 부분
        }
        public void Problem_label() 
        {
            S_Problem = G_E_Function.S_Rand_Num().Split('%');
            G_P_F.label1.Text = S_Problem[0];
            S_PcAnswer = S_Problem[1];
        }//문제 출력 함수
    }
}
