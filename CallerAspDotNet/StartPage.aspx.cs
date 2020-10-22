using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services.Description;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CallerAspDotNet
{
    public partial class StartPage : System.Web.UI.Page
    {
        public string GetMessage()
        {
            return CplusplusLib.MessageClass.Message;
        }

        protected void Page_Load(object sender, EventArgs e)
        {

        }
    }
}