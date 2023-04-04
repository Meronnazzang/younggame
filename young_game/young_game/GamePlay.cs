using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace young_game
{
    public partial class GamePlay : Form
    {

        Server Sver_frm;
        

        public GamePlay() //GamePlay 만든 후 this를 서버에 넘기기
        {
            InitializeComponent();
            Sver_frm = new Server(this);
        }
        private void GamePlay_Load(object sender, EventArgs e)
        {
            Sver_frm.Problem_label();
        } //첫 문제 출력

        private void Number1_Click(object sender, EventArgs e)
        {
           Sver_frm.Number_Case(Convert.ToInt32(((Button)sender).Name.Substring(6)));
        } // 넘버 버튼 클릭
    }
}
