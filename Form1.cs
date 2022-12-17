using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Signin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void SigninButton_Click(object sender, EventArgs e)
        {
            string userId = id.Text;
            string userPassword = password.Text;

            if(userId.Equals("닭은 왼발잡이다") && userPassword.Equals("ㄹㅇㅋㅋ"))
            {
                MessageBox.Show("로그인에 성공했습니다", "로그인");
            }
            else if(userId.Equals("ㅇ") && userPassword.Equals("ㅇ"))
            {
                MessageBox.Show("이걸찾아?", "제작자");
            }
            else
            {
                MessageBox.Show("로그인에 실패하였습니다", "로그인");
            }
        }
    }
}
