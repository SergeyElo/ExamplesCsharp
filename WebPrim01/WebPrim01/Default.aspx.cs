using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace WebPrim01
{
    public partial class _Default : Page
    {
        
        
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void ButtonSend_Click(object sender, EventArgs e)
        {
            ClassBD y = new ClassBD();
            ListBox1.Items.Add(y.ConnectionString());
            string cmd = "insert into messages (mat,id_first,id_second) values ('" +
                TextBoxMessage.Text + "',";

            string s = "";
            if (RadioButtonList1.SelectedIndex == 0)
            {
                s += "First say second";
                cmd += "1,2);";
            }
            else
            {
                s += "Second say first";
                cmd += "2,1);";
            }
            s += ": " + TextBoxMessage.Text;
            y.RuncmdBD(cmd);
            ListBox1.Items.Add(s);
            TextBoxMessage.Text = "";
        }

 
    }
}