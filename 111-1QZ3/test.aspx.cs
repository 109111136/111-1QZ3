using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _111_1QZ3
{
    public partial class test : System.Web.UI.Page
    {
        string[] s_City = new string[3] { "台北市", "新北市", "台中市" };
        string[,] s_Area = new string[3, 3] {
            {"中正區", "文山區", "大安區"},
            {"淡水區", "石碇區", "土城區"},
            {"西屯區", "北屯區", "東區"}
        };
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                for (int i = 0; i < s_City.GetLength(0); i++)
                {
                    ListItem C = new ListItem();
                    C.Text = s_City[i];
                    dpl_City.Items.Add(C);
                }
                country_List();
            }
        }
        protected void country_List()
        {
            int a = dpl_City.SelectedIndex;
            dpl_Area.Items.Clear();
            for (int s = 0; s < s_Area.GetLength(1); s++)
            {
                ListItem C = new ListItem();
                C.Text = C.Value = s_Area[a, s];
                dpl_Area.Items.Add(C);
            }
        }

        protected void dpl_City_SelectedIndexChanged(object sender, EventArgs e)
        {
            country_List();
        }
    }
}