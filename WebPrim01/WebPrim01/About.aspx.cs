using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebPrim01
{
    public partial class About : Page
    {
        protected void Button1_Click(object sender, EventArgs e)
        {
            ClassBD x = new ClassBD();
            string cmd = "insert into users(mat,login,password,email,phone) values('" +
                TextBox_mat.Text + "','" + TextBox_login.Text + "','" +
                TextBox_password.Text + "','" + TextBox_email.Text + "','" + TextBox_phone.Text + "')";
            x.RuncmdBD(cmd);
            Label1.Text = TextBox_mat.Text + " was added.";
            TextBox_mat.Text = "";
            TextBox_login.Text = "";
            TextBox_password.Text = "";
            TextBox_email.Text = "";
            TextBox_phone.Text = "";
            TextBox_mat.Focus();
        }
    }
}