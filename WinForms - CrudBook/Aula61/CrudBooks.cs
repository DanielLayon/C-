using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula61
{
    public partial class Form_Aula61 : Form
    {
        public Form_Aula61()
        {
            InitializeComponent();
        }

        private void btn_Get_Id_Click(object sender, EventArgs e)
        {
            Request("https://localhost:7101/api/Books/" + tb_Get_Id.Text, "GET", null, tb_Get_Response);
        }
        private void btn_Get_All_Click(object sender, EventArgs e)
        {
            Request("https://localhost:7101/api/Books", "GET", null, tb_Get_Response);
        }
        private void btn_Post_Click(object sender, EventArgs e)
        {
            Book book = new Book();
            book.Author = tb_Post_Author.Text;
            book.Title = tb_Post_Title.Text;
            book.Description = tb_Post_Description.Text;

            Request("https://localhost:7101/api/Books", "POST", book, null);
        }
        private void btn_Put_Click(object sender, EventArgs e)
        {
            Book book = new Book();
            book.Id = int.Parse(tb_Put_Id.Text);
            book.Author = tb_Put_Author.Text;
            book.Title = tb_Put_Title.Text;
            book.Description = tb_Put_Description.Text;

            Request("https://localhost:7101/api/Books?id="+ tb_Put_Id.Text, "PUT", book, null);
        }
        private void btn_Delete_Click(object sender, EventArgs e)
        {
            Request("https://localhost:7101/api/Books?id=" + tb_Delete_Id.Text, "DELETE", null, null);
        }

        private void Request(string sUrl,string sMethod, Book book,TextBox tb_response)
        {
            string sData;

            try
            {
                HttpWebRequest reqWeb = WebRequest.CreateHttp(sUrl);
                reqWeb.Method = sMethod;
                reqWeb.UserAgent = "ApiBooks_Consumer";

                //Inject a body with stream data when request is PUT or POST
                if (reqWeb.Method == "POST" | reqWeb.Method == "PUT")
                {
                    ASCIIEncoding encoding = new ASCIIEncoding();
                    string jsonString = Newtonsoft.Json.JsonConvert.SerializeObject(book);
                    byte[] bytesJson = encoding.GetBytes(jsonString);

                    reqWeb.ContentType = "application/json";
                    Stream stream = reqWeb.GetRequestStream();
                    stream.Write(bytesJson, 0, bytesJson.Length);
                }

                HttpWebResponse resWeb = (HttpWebResponse)reqWeb.GetResponse();
                if (resWeb.StatusCode.ToString() == "OK")
                {
                    //Read Data
                    string sLine = "";
                    List<string> sLines = new List<string>();
                    int i = 0;

                    StreamReader sr = new StreamReader(resWeb.GetResponseStream());
                    while (sLine != null)
                    {
                        i++;
                        sLine = sr.ReadLine();
                        if (sLine != null)
                            sLines.Add(sLine);
                    }
                    tb_response.Lines = sLines.ToArray();
                }
                else
                {
                    throw new Exception("Request error");
                }
            }
            catch (Exception ex)
            {
                tb_Get_Response.Text = ex.Message;
            }
        }

    }

    class Book
    {
        public int Id { get; set; }
        public string Author { get; set; }
        public string Description { get; set; }
        public string Title { get; set; }
    }
}
