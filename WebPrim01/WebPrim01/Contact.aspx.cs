using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Npgsql;

namespace WebPrim01
{
    public partial class Contact : Page
    {
        ClassBD z = new ClassBD();   
        protected void Button1_Click(object sender, EventArgs e)
        {            
            z.ZapListBoxFromBD("select id, mat, login, email from users;", ref ListBox1);
        }
        protected void Button2_Click(object sender, EventArgs e)
        {
            ListBox1.Items.Clear();
        }
        protected void Button3_Click(object sender, EventArgs e)
        {            
            z.ZapListBoxFromBD("select m.id, m.mat, u1.mat, u2.mat from messages m " +
                "left join users u1 on u1.id=m.id_first left join users u2 on u2.id=m.id_second;", ref ListBox1);
        }                 
        protected void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            LabelUser.Text = ListBox1.SelectedIndex.ToString();
        }                       
    }
}