using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

public partial class pageHeader : MasterPage {
   protected void Page_Load(object sender, EventArgs e) {
        Session["Asset"] = Environment.MachineName;
        if(Request.Url.PathAndQuery == "/index.aspx"){
            String Username = System.Security.Principal.WindowsIdentity.GetCurrent().Name;
        }
   }    
}

        
   
   
   

