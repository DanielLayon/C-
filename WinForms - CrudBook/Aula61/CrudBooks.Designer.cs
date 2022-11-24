namespace Aula61
{
    partial class Form_Aula61
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
            this.lb_Title = new System.Windows.Forms.Label();
            this.tab_GET = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lb_Get_Response = new System.Windows.Forms.Label();
            this.tb_Get_Response = new System.Windows.Forms.TextBox();
            this.btn_Get_All = new System.Windows.Forms.Button();
            this.btn_Get_Id = new System.Windows.Forms.Button();
            this.lb_Get_Id = new System.Windows.Forms.Label();
            this.tb_Get_Id = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.lb_Post_Author = new System.Windows.Forms.Label();
            this.tb_Post_Author = new System.Windows.Forms.TextBox();
            this.lb_Post_Title = new System.Windows.Forms.Label();
            this.tb_Post_Title = new System.Windows.Forms.TextBox();
            this.tb_Post_Description = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Post = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btn_Put = new System.Windows.Forms.Button();
            this.tb_Put_Description = new System.Windows.Forms.TextBox();
            this.tb_Put_Title = new System.Windows.Forms.TextBox();
            this.lb_Put_Title = new System.Windows.Forms.Label();
            this.tb_Put_Author = new System.Windows.Forms.TextBox();
            this.lb_Put_Author = new System.Windows.Forms.Label();
            this.lb_Put_Id = new System.Windows.Forms.Label();
            this.tb_Put_Id = new System.Windows.Forms.TextBox();
            this.lb_Put_Description = new System.Windows.Forms.Label();
            this.tb_Delete_Id = new System.Windows.Forms.TextBox();
            this.lb_Delete_Id = new System.Windows.Forms.Label();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.tab_GET.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // lb_Title
            // 
            this.lb_Title.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_Title.Font = new System.Drawing.Font("Noto Sans Cond", 21.75F, System.Drawing.FontStyle.Bold);
            this.lb_Title.Location = new System.Drawing.Point(12, 9);
            this.lb_Title.Name = "lb_Title";
            this.lb_Title.Size = new System.Drawing.Size(268, 36);
            this.lb_Title.TabIndex = 0;
            this.lb_Title.Text = "Books Consumer";
            this.lb_Title.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tab_GET
            // 
            this.tab_GET.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tab_GET.Controls.Add(this.tabPage1);
            this.tab_GET.Controls.Add(this.tabPage2);
            this.tab_GET.Controls.Add(this.tabPage3);
            this.tab_GET.Controls.Add(this.tabPage4);
            this.tab_GET.Location = new System.Drawing.Point(12, 59);
            this.tab_GET.Name = "tab_GET";
            this.tab_GET.SelectedIndex = 0;
            this.tab_GET.Size = new System.Drawing.Size(268, 379);
            this.tab_GET.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lb_Get_Response);
            this.tabPage1.Controls.Add(this.tb_Get_Response);
            this.tabPage1.Controls.Add(this.btn_Get_All);
            this.tabPage1.Controls.Add(this.btn_Get_Id);
            this.tabPage1.Controls.Add(this.lb_Get_Id);
            this.tabPage1.Controls.Add(this.tb_Get_Id);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(260, 353);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "GET";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // lb_Get_Response
            // 
            this.lb_Get_Response.AutoSize = true;
            this.lb_Get_Response.Location = new System.Drawing.Point(3, 60);
            this.lb_Get_Response.Name = "lb_Get_Response";
            this.lb_Get_Response.Size = new System.Drawing.Size(58, 13);
            this.lb_Get_Response.TabIndex = 5;
            this.lb_Get_Response.Text = "Response:";
            // 
            // tb_Get_Response
            // 
            this.tb_Get_Response.Location = new System.Drawing.Point(6, 76);
            this.tb_Get_Response.Multiline = true;
            this.tb_Get_Response.Name = "tb_Get_Response";
            this.tb_Get_Response.Size = new System.Drawing.Size(248, 271);
            this.tb_Get_Response.TabIndex = 4;
            // 
            // btn_Get_All
            // 
            this.btn_Get_All.Location = new System.Drawing.Point(179, 12);
            this.btn_Get_All.Name = "btn_Get_All";
            this.btn_Get_All.Size = new System.Drawing.Size(75, 23);
            this.btn_Get_All.TabIndex = 3;
            this.btn_Get_All.Text = "Get All";
            this.btn_Get_All.UseVisualStyleBackColor = true;
            this.btn_Get_All.Click += new System.EventHandler(this.btn_Get_All_Click);
            // 
            // btn_Get_Id
            // 
            this.btn_Get_Id.Location = new System.Drawing.Point(99, 13);
            this.btn_Get_Id.Name = "btn_Get_Id";
            this.btn_Get_Id.Size = new System.Drawing.Size(65, 23);
            this.btn_Get_Id.TabIndex = 2;
            this.btn_Get_Id.Text = "Get ID";
            this.btn_Get_Id.UseVisualStyleBackColor = true;
            this.btn_Get_Id.Click += new System.EventHandler(this.btn_Get_Id_Click);
            // 
            // lb_Get_Id
            // 
            this.lb_Get_Id.AutoSize = true;
            this.lb_Get_Id.Location = new System.Drawing.Point(7, 18);
            this.lb_Get_Id.Name = "lb_Get_Id";
            this.lb_Get_Id.Size = new System.Drawing.Size(21, 13);
            this.lb_Get_Id.TabIndex = 1;
            this.lb_Get_Id.Text = "ID:";
            // 
            // tb_Get_Id
            // 
            this.tb_Get_Id.Location = new System.Drawing.Point(34, 15);
            this.tb_Get_Id.Name = "tb_Get_Id";
            this.tb_Get_Id.Size = new System.Drawing.Size(59, 20);
            this.tb_Get_Id.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btn_Post);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.tb_Post_Description);
            this.tabPage2.Controls.Add(this.tb_Post_Title);
            this.tabPage2.Controls.Add(this.lb_Post_Title);
            this.tabPage2.Controls.Add(this.tb_Post_Author);
            this.tabPage2.Controls.Add(this.lb_Post_Author);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(260, 353);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "POST";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.btn_Delete);
            this.tabPage4.Controls.Add(this.tb_Delete_Id);
            this.tabPage4.Controls.Add(this.lb_Delete_Id);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(260, 353);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "DELETE";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // lb_Post_Author
            // 
            this.lb_Post_Author.AutoSize = true;
            this.lb_Post_Author.Location = new System.Drawing.Point(6, 13);
            this.lb_Post_Author.Name = "lb_Post_Author";
            this.lb_Post_Author.Size = new System.Drawing.Size(41, 13);
            this.lb_Post_Author.TabIndex = 2;
            this.lb_Post_Author.Text = "Author:";
            // 
            // tb_Post_Author
            // 
            this.tb_Post_Author.Location = new System.Drawing.Point(53, 10);
            this.tb_Post_Author.Name = "tb_Post_Author";
            this.tb_Post_Author.Size = new System.Drawing.Size(201, 20);
            this.tb_Post_Author.TabIndex = 3;
            // 
            // lb_Post_Title
            // 
            this.lb_Post_Title.AutoSize = true;
            this.lb_Post_Title.Location = new System.Drawing.Point(6, 51);
            this.lb_Post_Title.Name = "lb_Post_Title";
            this.lb_Post_Title.Size = new System.Drawing.Size(30, 13);
            this.lb_Post_Title.TabIndex = 4;
            this.lb_Post_Title.Text = "Title:";
            // 
            // tb_Post_Title
            // 
            this.tb_Post_Title.Location = new System.Drawing.Point(33, 48);
            this.tb_Post_Title.Name = "tb_Post_Title";
            this.tb_Post_Title.Size = new System.Drawing.Size(221, 20);
            this.tb_Post_Title.TabIndex = 5;
            // 
            // tb_Post_Description
            // 
            this.tb_Post_Description.Location = new System.Drawing.Point(9, 97);
            this.tb_Post_Description.Multiline = true;
            this.tb_Post_Description.Name = "tb_Post_Description";
            this.tb_Post_Description.Size = new System.Drawing.Size(245, 221);
            this.tb_Post_Description.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Description:";
            // 
            // btn_Post
            // 
            this.btn_Post.Location = new System.Drawing.Point(179, 324);
            this.btn_Post.Name = "btn_Post";
            this.btn_Post.Size = new System.Drawing.Size(75, 23);
            this.btn_Post.TabIndex = 10;
            this.btn_Post.Text = "Post";
            this.btn_Post.UseVisualStyleBackColor = true;
            this.btn_Post.Click += new System.EventHandler(this.btn_Post_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.lb_Put_Description);
            this.tabPage3.Controls.Add(this.tb_Put_Id);
            this.tabPage3.Controls.Add(this.lb_Put_Id);
            this.tabPage3.Controls.Add(this.btn_Put);
            this.tabPage3.Controls.Add(this.tb_Put_Description);
            this.tabPage3.Controls.Add(this.tb_Put_Title);
            this.tabPage3.Controls.Add(this.lb_Put_Title);
            this.tabPage3.Controls.Add(this.tb_Put_Author);
            this.tabPage3.Controls.Add(this.lb_Put_Author);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(260, 353);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "PUT";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // btn_Put
            // 
            this.btn_Put.Location = new System.Drawing.Point(179, 327);
            this.btn_Put.Name = "btn_Put";
            this.btn_Put.Size = new System.Drawing.Size(75, 23);
            this.btn_Put.TabIndex = 17;
            this.btn_Put.Text = "Put";
            this.btn_Put.UseVisualStyleBackColor = true;
            this.btn_Put.Click += new System.EventHandler(this.btn_Put_Click);
            // 
            // tb_Put_Description
            // 
            this.tb_Put_Description.Location = new System.Drawing.Point(9, 95);
            this.tb_Put_Description.Multiline = true;
            this.tb_Put_Description.Name = "tb_Put_Description";
            this.tb_Put_Description.Size = new System.Drawing.Size(245, 226);
            this.tb_Put_Description.TabIndex = 15;
            // 
            // tb_Put_Title
            // 
            this.tb_Put_Title.Location = new System.Drawing.Point(33, 46);
            this.tb_Put_Title.Name = "tb_Put_Title";
            this.tb_Put_Title.Size = new System.Drawing.Size(221, 20);
            this.tb_Put_Title.TabIndex = 14;
            // 
            // lb_Put_Title
            // 
            this.lb_Put_Title.AutoSize = true;
            this.lb_Put_Title.Location = new System.Drawing.Point(6, 49);
            this.lb_Put_Title.Name = "lb_Put_Title";
            this.lb_Put_Title.Size = new System.Drawing.Size(30, 13);
            this.lb_Put_Title.TabIndex = 13;
            this.lb_Put_Title.Text = "Title:";
            // 
            // tb_Put_Author
            // 
            this.tb_Put_Author.Location = new System.Drawing.Point(135, 8);
            this.tb_Put_Author.Name = "tb_Put_Author";
            this.tb_Put_Author.Size = new System.Drawing.Size(119, 20);
            this.tb_Put_Author.TabIndex = 12;
            // 
            // lb_Put_Author
            // 
            this.lb_Put_Author.AutoSize = true;
            this.lb_Put_Author.Location = new System.Drawing.Point(88, 11);
            this.lb_Put_Author.Name = "lb_Put_Author";
            this.lb_Put_Author.Size = new System.Drawing.Size(41, 13);
            this.lb_Put_Author.TabIndex = 11;
            this.lb_Put_Author.Text = "Author:";
            // 
            // lb_Put_Id
            // 
            this.lb_Put_Id.AutoSize = true;
            this.lb_Put_Id.Location = new System.Drawing.Point(6, 11);
            this.lb_Put_Id.Name = "lb_Put_Id";
            this.lb_Put_Id.Size = new System.Drawing.Size(19, 13);
            this.lb_Put_Id.TabIndex = 18;
            this.lb_Put_Id.Text = "Id:";
            // 
            // tb_Put_Id
            // 
            this.tb_Put_Id.Location = new System.Drawing.Point(31, 8);
            this.tb_Put_Id.Name = "tb_Put_Id";
            this.tb_Put_Id.Size = new System.Drawing.Size(51, 20);
            this.tb_Put_Id.TabIndex = 19;
            // 
            // lb_Put_Description
            // 
            this.lb_Put_Description.AutoSize = true;
            this.lb_Put_Description.Location = new System.Drawing.Point(6, 79);
            this.lb_Put_Description.Name = "lb_Put_Description";
            this.lb_Put_Description.Size = new System.Drawing.Size(63, 13);
            this.lb_Put_Description.TabIndex = 20;
            this.lb_Put_Description.Text = "Description:";
            // 
            // tb_Delete_Id
            // 
            this.tb_Delete_Id.Location = new System.Drawing.Point(33, 13);
            this.tb_Delete_Id.Name = "tb_Delete_Id";
            this.tb_Delete_Id.Size = new System.Drawing.Size(51, 20);
            this.tb_Delete_Id.TabIndex = 21;
            // 
            // lb_Delete_Id
            // 
            this.lb_Delete_Id.AutoSize = true;
            this.lb_Delete_Id.Location = new System.Drawing.Point(8, 16);
            this.lb_Delete_Id.Name = "lb_Delete_Id";
            this.lb_Delete_Id.Size = new System.Drawing.Size(19, 13);
            this.lb_Delete_Id.TabIndex = 20;
            this.lb_Delete_Id.Text = "Id:";
            // 
            // btn_Delete
            // 
            this.btn_Delete.Location = new System.Drawing.Point(169, 11);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(75, 23);
            this.btn_Delete.TabIndex = 22;
            this.btn_Delete.Text = "button1";
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // Form_Aula61
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 450);
            this.Controls.Add(this.tab_GET);
            this.Controls.Add(this.lb_Title);
            this.Name = "Form_Aula61";
            this.Text = "Form_Consumer";
            this.tab_GET.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lb_Title;
        private System.Windows.Forms.TabControl tab_GET;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label lb_Get_Id;
        private System.Windows.Forms.TextBox tb_Get_Id;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Label lb_Get_Response;
        private System.Windows.Forms.TextBox tb_Get_Response;
        private System.Windows.Forms.Button btn_Get_All;
        private System.Windows.Forms.Button btn_Get_Id;
        private System.Windows.Forms.Button btn_Post;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_Post_Description;
        private System.Windows.Forms.TextBox tb_Post_Title;
        private System.Windows.Forms.Label lb_Post_Title;
        private System.Windows.Forms.TextBox tb_Post_Author;
        private System.Windows.Forms.Label lb_Post_Author;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label lb_Put_Description;
        private System.Windows.Forms.TextBox tb_Put_Id;
        private System.Windows.Forms.Label lb_Put_Id;
        private System.Windows.Forms.Button btn_Put;
        private System.Windows.Forms.TextBox tb_Put_Description;
        private System.Windows.Forms.TextBox tb_Put_Title;
        private System.Windows.Forms.Label lb_Put_Title;
        private System.Windows.Forms.TextBox tb_Put_Author;
        private System.Windows.Forms.Label lb_Put_Author;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.TextBox tb_Delete_Id;
        private System.Windows.Forms.Label lb_Delete_Id;
    }
}

