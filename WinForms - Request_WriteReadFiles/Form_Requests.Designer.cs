namespace Curso.Aula60
{
    partial class Form_MainStart
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_MainStart));
            this.btn_Request = new System.Windows.Forms.Button();
            this.lb_Title = new System.Windows.Forms.Label();
            this.tb_UrlRequest = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_Response = new System.Windows.Forms.TextBox();
            this.btn_WriteJSON = new System.Windows.Forms.Button();
            this.btn_WriteTXT = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_WriteCSV = new System.Windows.Forms.Button();
            this.btn_WriteDOCX = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_Request
            // 
            this.btn_Request.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_Request.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Request.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_Request.Location = new System.Drawing.Point(595, 90);
            this.btn_Request.Name = "btn_Request";
            this.btn_Request.Size = new System.Drawing.Size(177, 31);
            this.btn_Request.TabIndex = 0;
            this.btn_Request.Text = "Send Request";
            this.btn_Request.UseVisualStyleBackColor = false;
            this.btn_Request.Click += new System.EventHandler(this.btn_Request_Click);
            // 
            // lb_Title
            // 
            this.lb_Title.AutoSize = true;
            this.lb_Title.Font = new System.Drawing.Font("MV Boli", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Title.Location = new System.Drawing.Point(300, 9);
            this.lb_Title.Name = "lb_Title";
            this.lb_Title.Size = new System.Drawing.Size(222, 34);
            this.lb_Title.TabIndex = 1;
            this.lb_Title.Text = "Request Screen";
            this.lb_Title.UseMnemonic = false;
            // 
            // tb_UrlRequest
            // 
            this.tb_UrlRequest.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_UrlRequest.Location = new System.Drawing.Point(12, 90);
            this.tb_UrlRequest.MaximumSize = new System.Drawing.Size(577, 35);
            this.tb_UrlRequest.MinimumSize = new System.Drawing.Size(4, 35);
            this.tb_UrlRequest.Name = "tb_UrlRequest";
            this.tb_UrlRequest.Size = new System.Drawing.Size(577, 31);
            this.tb_UrlRequest.TabIndex = 2;
            this.tb_UrlRequest.Text = "https://httpbin.org/get";
            this.tb_UrlRequest.WordWrap = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Noto Sans Cond", 20.25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(12, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 37);
            this.label1.TabIndex = 3;
            this.label1.Text = "Url:";
            // 
            // tb_Response
            // 
            this.tb_Response.Location = new System.Drawing.Point(12, 171);
            this.tb_Response.Multiline = true;
            this.tb_Response.Name = "tb_Response";
            this.tb_Response.Size = new System.Drawing.Size(577, 378);
            this.tb_Response.TabIndex = 4;
            // 
            // btn_WriteJSON
            // 
            this.btn_WriteJSON.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_WriteJSON.Location = new System.Drawing.Point(697, 526);
            this.btn_WriteJSON.Name = "btn_WriteJSON";
            this.btn_WriteJSON.Size = new System.Drawing.Size(75, 23);
            this.btn_WriteJSON.TabIndex = 5;
            this.btn_WriteJSON.Text = "JSON";
            this.btn_WriteJSON.UseVisualStyleBackColor = true;
            this.btn_WriteJSON.Click += new System.EventHandler(this.bt_WriteJSON_Click);
            // 
            // btn_WriteTXT
            // 
            this.btn_WriteTXT.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_WriteTXT.Location = new System.Drawing.Point(595, 526);
            this.btn_WriteTXT.Name = "btn_WriteTXT";
            this.btn_WriteTXT.Size = new System.Drawing.Size(75, 23);
            this.btn_WriteTXT.TabIndex = 6;
            this.btn_WriteTXT.Text = "TXT";
            this.btn_WriteTXT.UseVisualStyleBackColor = true;
            this.btn_WriteTXT.Click += new System.EventHandler(this.btn_WriteTXT_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Noto Sans Cond", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label2.Location = new System.Drawing.Point(595, 433);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(173, 51);
            this.label2.TabIndex = 7;
            this.label2.Text = "Write Files";
            // 
            // btn_WriteCSV
            // 
            this.btn_WriteCSV.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_WriteCSV.Location = new System.Drawing.Point(697, 487);
            this.btn_WriteCSV.Name = "btn_WriteCSV";
            this.btn_WriteCSV.Size = new System.Drawing.Size(75, 23);
            this.btn_WriteCSV.TabIndex = 8;
            this.btn_WriteCSV.Text = "CSV";
            this.btn_WriteCSV.UseVisualStyleBackColor = true;
            this.btn_WriteCSV.Click += new System.EventHandler(this.btn_WriteCSV_Click);
            // 
            // btn_WriteDOCX
            // 
            this.btn_WriteDOCX.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_WriteDOCX.Location = new System.Drawing.Point(595, 487);
            this.btn_WriteDOCX.Name = "btn_WriteDOCX";
            this.btn_WriteDOCX.Size = new System.Drawing.Size(75, 23);
            this.btn_WriteDOCX.TabIndex = 9;
            this.btn_WriteDOCX.Text = "DOCX";
            this.btn_WriteDOCX.UseVisualStyleBackColor = true;
            this.btn_WriteDOCX.Click += new System.EventHandler(this.btn_WriteDOCX_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(595, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(180, 25);
            this.label3.TabIndex = 10;
            this.label3.Text = "Request Project";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(601, 207);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(174, 226);
            this.label4.TabIndex = 11;
            this.label4.Text = resources.GetString("label4.Text");
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // Form_MainStart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_WriteDOCX);
            this.Controls.Add(this.btn_WriteCSV);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_WriteTXT);
            this.Controls.Add(this.btn_WriteJSON);
            this.Controls.Add(this.tb_Response);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_UrlRequest);
            this.Controls.Add(this.lb_Title);
            this.Controls.Add(this.btn_Request);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(800, 600);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "Form_MainStart";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Curso C# - Manuseio de Componentes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Request;
        private System.Windows.Forms.Label lb_Title;
        private System.Windows.Forms.TextBox tb_UrlRequest;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_Response;
        private System.Windows.Forms.Button btn_WriteJSON;
        private System.Windows.Forms.Button btn_WriteTXT;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_WriteCSV;
        private System.Windows.Forms.Button btn_WriteDOCX;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

