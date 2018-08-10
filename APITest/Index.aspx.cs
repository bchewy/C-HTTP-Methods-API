using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net.Http;
using Newtonsoft.Json;
using System.Threading.Tasks;
using System.Diagnostics;
using APITest.Class;
using System.Text;
using System.Net;

namespace APITest
{
    public partial class Index : System.Web.UI.Page
    {
        HttpClient httpclient = new HttpClient();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                //GetData();
                //LoadCarParkList();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            buttonPressed();
        }
        /*
private async void LoadCarParkList()
{
   List<string> objList = new List<string>();
   RootObject carparkData = new RootObject();
   HttpResponseMessage response = new HttpResponseMessage();

   response = await httpcleint.GetAsync("http://api.data.gov.sg/v1/transport/carpark-availability");
   string reply = await response.Content.ReadAsStringAsync();
   carparkData = JsonConvert.DeserializeObject<RootObject>(reply);
   foreach(var i in carparkData.items[0].carpark_data)
   {

       Debug.WriteLine("Carpark Number:" + i.carpark_number);
       foreach(var x in i.carpark_info)
       {
           //Add the items into objList
           objList.Add(i.carpark_number);
           objList.Add(x.total_lots);
           objList.Add(x.lots_available);
           Debug.WriteLine("Car Total Lots:" + x.total_lots + "\n Lots Avail:" + x.lots_available+"\n");
       }
   }

   GridView1.DataSource = objList;
   GridView1.DataBind();
}
*/
        /*
        private async void GetData()
        {
            HttpResponseMessage response = new HttpResponseMessage();
            response = await httpcleint.GetAsync("https://reqres.in/api/users?page=2");
            string data = await response.Content.ReadAsStringAsync();

            Class2 users = new Class2();
            users = JsonConvert.DeserializeObject<Class2>(data);

            GridView1.DataSource = users.data;
            GridView1.DataBind();
        }
        */
        //THIS IS A GET REQUEST, TO GET THE USERS FROM THE WEBSITE
        private async void buttonPressed()
        {
            HttpResponseMessage response = new HttpResponseMessage();
            response = await httpclient.GetAsync("https://reqres.in/api/users?page=2");
            string data = await response.Content.ReadAsStringAsync();

            Class2 users = new Class2();
            users = JsonConvert.DeserializeObject<Class2>(data);
            /*
            for (int i = 0; i < users.data.Capacity; i++)
            {
                lbl.Text += Attributes.Name;
            }
            */
            foreach(Class1 x in users.data)
            {
                lbl.Text += x.first_name+"\n";
            }
        }
        //THIS IS A POST REQUEST, TO CREATEA A NEW USER ,EXPECTING A JSON RESPONSE
        /*
         * 
         * 
         * {
    "name": "morpheus",
    "job": "leader",
    "id": "932",
    "createdAt": "2018-08-07T09:33:15.746Z"
}
         *  
         **/
         private async void createNewUser(string username, string job)
        {
            Class1 newuser = new Class1();
            newuser.first_name = username;
            newuser.job = job;
            var json = JsonConvert.SerializeObject(newuser);
            var userContent = new StringContent(json, UnicodeEncoding.UTF8, "application/json");
            HttpResponseMessage response = new HttpResponseMessage();
            response = await httpclient.PostAsync("https://reqres.in/api/users", userContent);

            if (response.StatusCode == HttpStatusCode.Created)
            {
                var responseContent = await response.Content.ReadAsStringAsync();
                lbl.Text = "New user is added successfully. \n <pre><code>" + responseContent+"</pre></code>";

            }
            else
            {
                var error = await response.Content.ReadAsAsync<ErrorBody>();
                lbl.Text = "Failed to add data. Error:" + error.ToString();
            }


        }

        protected void btnAddUser_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbJob.Text) && string.IsNullOrWhiteSpace(tbUsername.Text))
            {
                lbl.Text = "Please don't leave the field empty!";
            }
            else
                createNewUser(tbUsername.Text, tbJob.Text);
        }

        protected void btnClear_Click(object sender, EventArgs e)
        {
            lbl.Text = "";
        }
    }
}
 