using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;

namespace young_game
{
    public partial class Form1 : Form
    {
        Server Sver_frm = new Server();
        
        public Form1()
        {
            InitializeComponent();
            
        }
        private void G_Help_Click(object sender, EventArgs e) 
        {
            Sver_frm.I_F1_Check = 1;
        }//사용사 설정

        private void G_play_Click(object sender, EventArgs e)
        {
            Sver_frm.I_F1_Check = 0;
            
        } //Game Start

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(OnOff.Checked == true)
                OnOff.Text = "OnLine";
            else
            {
                OnOff.Text = "OffLine";
            }
        }
    }
}
