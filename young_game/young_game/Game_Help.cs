using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace young_game
{
    public partial class Game_Help : Form
    {
        Server Sver_frm;
        public Game_Help()
        {
            InitializeComponent();
        }

        private void Enter_Click(object sender, EventArgs e)
        {
            Sver_frm = new Server(this);
            Sver_frm.I_GHF_Check = 0;
        }  //확인버튼

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            label1.Text = hScrollBar1.Value.ToString();
        } //스크롤바 Value -> label
    }
}
