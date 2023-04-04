using System.Drawing;

namespace young_game
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.OnOff = new System.Windows.Forms.CheckBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // OnOff
            // 
            this.OnOff.AutoSize = true;
            this.OnOff.BackColor = System.Drawing.Color.Transparent;
            this.OnOff.FlatAppearance.BorderSize = 0;
            this.OnOff.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.OnOff.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.OnOff.Font = new System.Drawing.Font("비트로 코어 OTF", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.OnOff.ForeColor = System.Drawing.SystemColors.WindowText;
            this.OnOff.Location = new System.Drawing.Point(668, 408);
            this.OnOff.Name = "OnOff";
            this.OnOff.Size = new System.Drawing.Size(111, 31);
            this.OnOff.TabIndex = 2;
            this.OnOff.Text = "OffLine";
            this.OnOff.UseVisualStyleBackColor = false;
            this.OnOff.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("비트로 인스파이어 OTF", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button2.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.button2.Image = global::young_game.Properties.Resources.Button_PNG_Free_Download;
            this.button2.Location = new System.Drawing.Point(281, 384);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(216, 55);
            this.button2.TabIndex = 0;
            this.button2.Text = "풀이 횟수 선택하기";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.G_Help_Click);
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Font = new System.Drawing.Font("비트로 인스파이어 OTF", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.button1.Image = global::young_game.Properties.Resources.Button_PNG_off;
            this.button1.Location = new System.Drawing.Point(281, 316);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(216, 55);
            this.button1.TabIndex = 0;
            this.button1.Text = "게 임 시 작";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.G_play_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::young_game.Properties.Resources.MainBackIMG;
            this.pictureBox1.Location = new System.Drawing.Point(-5, -6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(794, 471);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.OnOff);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button2;
        public System.Windows.Forms.Button button1;
        public System.Windows.Forms.CheckBox OnOff;
    }
}

