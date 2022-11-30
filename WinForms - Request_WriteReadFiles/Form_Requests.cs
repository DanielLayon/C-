using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Curso.Aula60
{
    public partial class Form_MainStart : Form
    {
        public Form_MainStart()
        {
            InitializeComponent();
        }

        private void btn_Request_Click(object sender, EventArgs e)
        {   
            string sUrlRequest = tb_UrlRequest.Text;


            try
            {
                WebRequest wrRequest = WebRequest.Create(sUrlRequest);

                //Caso queira adicionar proxy no request
                //WebProxy wpProxy = new WebProxy("myproxy", 80);
                //wpProxy.BypassProxyOnLocal = true;
                //wrRequest.Proxy = wpProxy;

                WebResponse wpResponse = wrRequest.GetResponse();

                Stream strDados = wpResponse.GetResponseStream();
                StreamReader strReader = new StreamReader(strDados);

                string sLine = "";
                List<string> sLines = new List<string>();
                int i = 0;

                while (sLine != null)
                {
                    i++;
                    sLine = strReader.ReadLine();
                    if (sLine != null)
                        sLines.Add(sLine);
                }

                tb_Response.Lines = sLines.ToArray<string>();
                btn_Request.BackColor= Color.Green;
                

            }
            catch(Exception ex)
            {
                tb_Response.Text = ex.Message;
                btn_Request.BackColor = Color.Red;
            }

            WaitSecondsBtnChangeColor(5000,btn_Request);
        }


        private void bt_WriteJSON_Click(object sender, EventArgs e)
        {
            WriteArchive(btn_WriteJSON, "Request_JSON.json");
        }

        private void btn_WriteTXT_Click(object sender, EventArgs e)
        {
            WriteArchive(btn_WriteTXT, "Request_Text.txt");
        }

        private void btn_WriteCSV_Click(object sender, EventArgs e)
        {
            WriteArchive(btn_WriteCSV, "Request_CSV.csv");
        }

        private void btn_WriteDOCX_Click(object sender, EventArgs e)
        {
            WriteArchive(btn_WriteDOCX, "Request_DOCX.docx");
        }
        void WriteArchive(Button btn,string sNameArchive)
        {
            try
            {
                StreamWriter sw = new StreamWriter(Directory.GetCurrentDirectory() + "\\"+ sNameArchive);
                foreach (string sLine in tb_Response.Lines)
                {
                    sw.WriteLine(sLine);
                }

                sw.Close();
                btn.BackColor = Color.Green;
            }
            catch (Exception ex)
            {
                btn.Text = ex.Message;
                btn.BackColor = Color.Red;
            }

            WaitSecondsBtnChangeColor(5000, btn);
        }
        async void WaitSecondsBtnChangeColor(int miliseconds,Button btn)
        {
            await Task.Run(() => { 
                System.Threading.Thread.Sleep(miliseconds);
                btn.BackColor = Color.LightGray;
            });
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }

}
