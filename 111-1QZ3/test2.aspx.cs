using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _111_1QZ3
{
    public partial class test2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lb_Msg.Text = "紀錄編號:" + Request.Form.Get("tb_Num") + "<br/>" + "通訊種類:" + Request.Form.Get("rbl_Phone") + "<br/>" + "所在城市:" + Request.Form.Get("dpl_City") + "<br/>" + "所在區域:" + Request.Form.Get("dpl_Area");
        }
    }
}