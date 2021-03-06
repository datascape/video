using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using ManagementSuite.Web.UI;

// Place in head tag to show bubbles - good for generating a snapshot of a linked site for the portfolio page.
// <script type="text/javascript" src="http://shots.snap.com/ss/7e16b98a4b736bb14426c98fda9796ce/snap_shots.js"></script>

public partial class MasterPage : UIMasterPage
{
    protected bool showGallery = true;

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!PUP.IsMode("e"))
        {
            PUP.IncludeJQuery = true;
        }
        if (!PUP.IsMode("aep"))
        {
            //StyleOverridePH.Controls.Add(new LiteralControl("<style type='text/css'>body {background-position: center top; background-image: url(/dreamstudio/images/bkgd/DarkSkyBkgd.jpg); text-align:center; margin:0 auto;}</style>"));
            StyleOverridePH.Controls.Add(new LiteralControl("<style type='text/css'>#MasterAll{background:#fff;height:auto;width:100%;min-width:750px;max-width:950px;text-align:left;margin: 0 auto;}</style>"));
            StyleOverridePH.Controls.Add(new LiteralControl("<style type='text/css'>#ContentArea{margin-left: 24px; margin-right: 20px;}</style>")); 
        } else {
            //TopNavigationPanel.Visible = false;
            SearchPanel.Visible = false;
        }
        if (PUP.IsMode("a"))
        {
            StyleOverridePH.Controls.Add(new LiteralControl("<style type='text/css'>body {text-align:left; margin:0 auto;}</style>"));
            StyleOverridePH.Controls.Add(new LiteralControl("<style type='text/css'>#ContentArea{margin-left: 0px; margin-right: 0px;}</style>"));
            StyleOverridePH.Controls.Add(new LiteralControl("<style type='text/css'>.contentArea{margin-left: 0px; margin-right: 0px;}</style>"));
            StyleOverridePH.Controls.Add(new LiteralControl("<style type='text/css'>#MasterAll{background:#fff;height:auto;width:100%;min-width:180px;max-width:950px;text-align:left;margin: 0 auto;}</style>"));
        }
        if (PUP.IsMode("ae"))
        {
            StyleOverridePH.Controls.Add(new LiteralControl("<style type='text/css'>body {line-height: 1em; } .contentBox { margin-top: 80px; } .masterMessageArea { background-color:#fff; }</style>"));
            SearchPanel.Visible = false;
            //FooterPanel.Visible = false;
        }
        if (PUP.IsMode("ae"))
        {
            HeaderPanel.Visible = false;
        }
        //HomeHL.NavigateUrl = PUP.GetLink("/core/item/page.aspx", 56809);
        //ArtworkHL.NavigateUrl = PUP.GetLink("/core/item/page.aspx", 56810);
        //AboutHL.NavigateUrl = PUP.GetLink("/core/item/page.aspx", 56819);
        //ContactHL.NavigateUrl = PUP.GetLink("/core/item/page.aspx", 56820);

        if (PUP.IContains(PUP.Host, "dynamicspd.com"))
        {
            CopyrightHL.NavigateUrl = "http://DynamicsPD.com";
            CopyrightHL.Text = "&copy; " + DateTime.Now.Year.ToString() + " Patrol Dynamics - Community Policing System";
        }
        else if (PUP.ItemID != 94009) // The Old Explorer
        {
            CopyrightHL.NavigateUrl = "http://DreamStudio.com";
            CopyrightHL.Text = "&copy; " + DateTime.Now.Year.ToString() + " dreamstudio";
        }
        CopyrightHL.CssClass = "tinytext";
    }
}
