using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Microsoft.IdentityModel.Claims;
using System.Threading;

namespace cleverledgerACS
{
    public partial class _default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.Write("<p>Claims Received from ACS:</p><p>&nbsp;</p>");
            ClaimsIdentity ci = Thread.CurrentPrincipal.Identity as ClaimsIdentity;
            foreach (Claim c in ci.Claims)
            {
                Response.Write("Type: " + c.ClaimType + "- Value: " + c.Value + "<br/>");
            }
        }
    }
}