using System;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using System.Diagnostics;

public partial class _Default : System.Web.UI.Page 
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            int[] numbers = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25 };
            Random rmd = new Random();
            int[] MyRandom = numbers.OrderBy(x => rmd.Next()).ToArray();
            Button1.Text = MyRandom[0].ToString();
            Button2.Text = MyRandom[1].ToString();
            Button3.Text = MyRandom[2].ToString();
            Button4.Text = MyRandom[3].ToString();
            Button5.Text = MyRandom[4].ToString();
            Button6.Text = MyRandom[5].ToString();
            Button7.Text = MyRandom[6].ToString();
            Button8.Text = MyRandom[7].ToString();
            Button9.Text = MyRandom[8].ToString();
            Button10.Text = MyRandom[9].ToString();
            Button11.Text = MyRandom[10].ToString();
            Button12.Text = MyRandom[11].ToString();
            Button13.Text = MyRandom[12].ToString();
            Button14.Text = MyRandom[13].ToString();
            Button15.Text = MyRandom[14].ToString();
            Button16.Text = MyRandom[15].ToString();
            Button17.Text = MyRandom[16].ToString();
            Button18.Text = MyRandom[17].ToString();
            Button19.Text = MyRandom[18].ToString();
            Button20.Text = MyRandom[19].ToString();
            Button21.Text = MyRandom[20].ToString();
            Button22.Text = MyRandom[21].ToString();
            Button23.Text = MyRandom[22].ToString();
            Button24.Text = MyRandom[23].ToString();
            Button25.Text = MyRandom[24].ToString();
            ViewState["Incre_Val"] = 1;
        }
    }
    
    protected void Button1_Click(object sender, EventArgs e)
    {
        la.Text = "";
        int CompareVal=Convert.ToInt32(ViewState["Incre_Val"]);
        Stopwatch stp_W = new Stopwatch();
        stp_W.Start();
            Button btn = sender as Button;
            if (btn.Text != "")
            {
                if (Convert.ToInt32(btn.Text) == CompareVal)
                {
                    int i_btnVal = Convert.ToInt32(btn.Text);
                    ViewState["Incre_Val"] = Convert.ToInt32(btn.Text) + 1;
                    int Total = i_btnVal + 25;
                    if (Total <= 60)
                    {
                        btn.Text = Total.ToString();
                       
                    }
                    else
                    {
                        stp_W.Stop();
                        la.Text = stp_W.Elapsed.ToString();
                        btn.Text = "";
                    }
                }
                else
                    btn.CssClass = "red";
            }
    }
}
