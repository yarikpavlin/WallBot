namespace WallBot_Version1._0
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.create_WallPost = new System.Windows.Forms.Button();
            this.comment_WallPost = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.delete_WallPost = new System.Windows.Forms.Button();
            this.get_WallPost = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.start_AutoPost = new System.Windows.Forms.Button();
            this.get_Comments = new System.Windows.Forms.Button();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(1397, 593);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(43, 32);
            this.webBrowser1.TabIndex = 0;
            this.webBrowser1.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser1_DocumentCompleted);
            // 
            // create_WallPost
            // 
            this.create_WallPost.Location = new System.Drawing.Point(12, 12);
            this.create_WallPost.Name = "create_WallPost";
            this.create_WallPost.Size = new System.Drawing.Size(138, 43);
            this.create_WallPost.TabIndex = 1;
            this.create_WallPost.Text = "CreateWallPost";
            this.create_WallPost.UseVisualStyleBackColor = true;
            this.create_WallPost.Click += new System.EventHandler(this.create_WallPost_Click);
            // 
            // comment_WallPost
            // 
            this.comment_WallPost.Location = new System.Drawing.Point(12, 61);
            this.comment_WallPost.Name = "comment_WallPost";
            this.comment_WallPost.Size = new System.Drawing.Size(138, 43);
            this.comment_WallPost.TabIndex = 2;
            this.comment_WallPost.Text = "CommentWallPost";
            this.comment_WallPost.UseVisualStyleBackColor = true;
            this.comment_WallPost.Click += new System.EventHandler(this.comment_WallPost_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 110);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(604, 433);
            this.listBox1.TabIndex = 3;
            // 
            // delete_WallPost
            // 
            this.delete_WallPost.Location = new System.Drawing.Point(156, 12);
            this.delete_WallPost.Name = "delete_WallPost";
            this.delete_WallPost.Size = new System.Drawing.Size(138, 43);
            this.delete_WallPost.TabIndex = 4;
            this.delete_WallPost.Text = "DeleteWallPost";
            this.delete_WallPost.UseVisualStyleBackColor = true;
            this.delete_WallPost.Click += new System.EventHandler(this.delete_WallPost_Click);
            // 
            // get_WallPost
            // 
            this.get_WallPost.Location = new System.Drawing.Point(156, 61);
            this.get_WallPost.Name = "get_WallPost";
            this.get_WallPost.Size = new System.Drawing.Size(138, 43);
            this.get_WallPost.TabIndex = 5;
            this.get_WallPost.Text = "GetWallPost";
            this.get_WallPost.UseVisualStyleBackColor = true;
            this.get_WallPost.Click += new System.EventHandler(this.get_WallPost_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 30000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // start_AutoPost
            // 
            this.start_AutoPost.Location = new System.Drawing.Point(300, 12);
            this.start_AutoPost.Name = "start_AutoPost";
            this.start_AutoPost.Size = new System.Drawing.Size(138, 43);
            this.start_AutoPost.TabIndex = 6;
            this.start_AutoPost.Text = "StartAutoPost";
            this.start_AutoPost.UseVisualStyleBackColor = true;
            this.start_AutoPost.Click += new System.EventHandler(this.start_AutoPost_Click);
            // 
            // get_Comments
            // 
            this.get_Comments.Location = new System.Drawing.Point(300, 61);
            this.get_Comments.Name = "get_Comments";
            this.get_Comments.Size = new System.Drawing.Size(138, 43);
            this.get_Comments.TabIndex = 7;
            this.get_Comments.Text = "GetComments";
            this.get_Comments.UseVisualStyleBackColor = true;
            this.get_Comments.Click += new System.EventHandler(this.get_Comments_Click);
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(686, 110);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(604, 433);
            this.listBox2.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(449, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 42);
            this.button1.TabIndex = 9;
            this.button1.Text = "AutoUpdate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1474, 637);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.get_Comments);
            this.Controls.Add(this.start_AutoPost);
            this.Controls.Add(this.get_WallPost);
            this.Controls.Add(this.delete_WallPost);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.comment_WallPost);
            this.Controls.Add(this.create_WallPost);
            this.Controls.Add(this.webBrowser1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Button create_WallPost;
        private System.Windows.Forms.Button comment_WallPost;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button delete_WallPost;
        private System.Windows.Forms.Button get_WallPost;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button start_AutoPost;
        private System.Windows.Forms.Button get_Comments;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Button button1;
    }
}

