using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Database
{

    public partial class user_page : Form
    {
        MySqlConnection con;
        student_info s_page;
        course_info c_page;
        info i_page;
        AutoSizeForm auto=new AutoSizeForm();
        public user_page(MySqlConnection con)
        {
            this.con = con;
            InitializeComponent();
        }

        //点击check按钮，进入相应界面
        private void students_CheckedChanged(object sender, EventArgs e)
        {
            s_page = new student_info(con);
            this.Hide();
            s_page.ShowDialog();
            
        }

        private void course_CheckedChanged(object sender, EventArgs e)
        {
            c_page = new course_info(con);
            this.Hide();
            c_page.ShowDialog();
            
        }

        private void info_CheckedChanged(object sender, EventArgs e)
        {
            i_page = new info(con);
            this.Hide();
            i_page.ShowDialog();
            
        }

        private void exit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("退出学生选课管理系统！");
            try
            {
                if (con != null)
                {
                    con.Close();
                    Application.ExitThread();
                }
            }
            catch(Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
            
            
        }

        private void user_page_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                con.Close();
                Application.ExitThread();
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }

        private void user_page_Load(object sender, EventArgs e)
        {
            auto.controlInitial(this);
        }

        private void user_page_ResizeEnd(object sender, EventArgs e)
        {
            auto.controlAutoSize(this);
        }
    }
}
