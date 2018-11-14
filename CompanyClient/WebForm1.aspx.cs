using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net.Http;
namespace CompanyClient
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            // "BasicHttpBinding_ICompanyPublicService" ifadesi web.configte yazan endpoint namedir
            CompanyService.CompanyPublicServiceClient client = 
                new CompanyService.CompanyPublicServiceClient("BasicHttpBinding_ICompanyPublicService");
            Label1.Text = client.GetPublicInformation();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            // "BasicHttpBinding_ICompanyPublicService" ifadesi web.configte yazan endpoint namedir
            CompanyService.CompanyConfidentialServiceClient client =
                new CompanyService.CompanyConfidentialServiceClient("NetTcpBinding_ICompanyConfidentialService");
            Label2.Text = client.GetConfidentialInformation();
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            HttpClient client = new HttpClient();
            HttpResponseMessage wcfResponse = client.GetAsync("http://localhost:64858/PayMentService.svc/PayBill/155").Result;
            HttpContent stream = wcfResponse.Content;
            var data = stream.ReadAsStringAsync();
            Label3.Text = data.Result;
        }
    }
}