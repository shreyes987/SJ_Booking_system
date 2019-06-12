namespace WindowsFormsApp6
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TicketNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.From = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.To = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtfname = new System.Windows.Forms.TextBox();
            this.txtto = new System.Windows.Forms.TextBox();
            this.txtlname = new System.Windows.Forms.TextBox();
            this.txtnt = new System.Windows.Forms.TextBox();
            this.txtfrom = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button3 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtprice = new System.Windows.Forms.TextBox();
            this.date = new System.Windows.Forms.Label();
            this.time = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Algerian", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(41, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "FIRST NAME";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Algerian", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(41, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "LAST NAME";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Algerian", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(41, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "NUMBER OF TICKETS";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.FirstName,
            this.LastName,
            this.TicketNo,
            this.From,
            this.To});
            this.dataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.dataGridView1.Location = new System.Drawing.Point(116, 288);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(542, 150);
            this.dataGridView1.TabIndex = 3;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.Visible = false;
            // 
            // FirstName
            // 
            this.FirstName.DataPropertyName = "FirstName";
            this.FirstName.HeaderText = "First Name";
            this.FirstName.Name = "FirstName";
            // 
            // LastName
            // 
            this.LastName.DataPropertyName = "LastName";
            this.LastName.HeaderText = "Last Name";
            this.LastName.Name = "LastName";
            // 
            // TicketNo
            // 
            this.TicketNo.DataPropertyName = "TicketsNo";
            this.TicketNo.HeaderText = "Ticket Numbers";
            this.TicketNo.Name = "TicketNo";
            // 
            // From
            // 
            this.From.DataPropertyName = "From";
            this.From.HeaderText = "From";
            this.From.Name = "From";
            // 
            // To
            // 
            this.To.DataPropertyName = "To";
            this.To.HeaderText = "To";
            this.To.Name = "To";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button1.Location = new System.Drawing.Point(203, 223);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 42);
            this.button1.TabIndex = 4;
            this.button1.Text = "BOOK";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Algerian", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(332, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "TO";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Algerian", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(41, 175);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 15);
            this.label5.TabIndex = 7;
            this.label5.Text = "FROM";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // txtfname
            // 
            this.txtfname.Location = new System.Drawing.Point(203, 51);
            this.txtfname.Name = "txtfname";
            this.txtfname.Size = new System.Drawing.Size(100, 20);
            this.txtfname.TabIndex = 8;
            // 
            // txtto
            // 
            this.txtto.Location = new System.Drawing.Point(361, 172);
            this.txtto.Name = "txtto";
            this.txtto.Size = new System.Drawing.Size(100, 20);
            this.txtto.TabIndex = 9;
            // 
            // txtlname
            // 
            this.txtlname.Location = new System.Drawing.Point(203, 81);
            this.txtlname.Name = "txtlname";
            this.txtlname.Size = new System.Drawing.Size(100, 20);
            this.txtlname.TabIndex = 10;
            // 
            // txtnt
            // 
            this.txtnt.Location = new System.Drawing.Point(203, 123);
            this.txtnt.Name = "txtnt";
            this.txtnt.Size = new System.Drawing.Size(100, 20);
            this.txtnt.TabIndex = 11;
            this.txtnt.TextChanged += new System.EventHandler(this.txtnt_TextChanged);
            // 
            // txtfrom
            // 
            this.txtfrom.Location = new System.Drawing.Point(203, 172);
            this.txtfrom.Name = "txtfrom";
            this.txtfrom.Size = new System.Drawing.Size(100, 20);
            this.txtfrom.TabIndex = 12;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(578, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(196, 160);
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button3.Location = new System.Drawing.Point(411, 223);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(94, 42);
            this.button3.TabIndex = 14;
            this.button3.Text = "CLEAR";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Algerian", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(319, 123);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 12);
            this.label6.TabIndex = 15;
            this.label6.Text = "PRICE:";
            // 
            // txtprice
            // 
            this.txtprice.Location = new System.Drawing.Point(389, 123);
            this.txtprice.Name = "txtprice";
            this.txtprice.ReadOnly = true;
            this.txtprice.Size = new System.Drawing.Size(100, 20);
            this.txtprice.TabIndex = 16;
            this.txtprice.Text = "0";
            // 
            // date
            // 
            this.date.AutoSize = true;
            this.date.Location = new System.Drawing.Point(398, 12);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(30, 13);
            this.date.TabIndex = 17;
            this.date.Text = "Date";
            this.date.Click += new System.EventHandler(this.date_Click);
            // 
            // time
            // 
            this.time.AutoSize = true;
            this.time.Location = new System.Drawing.Point(470, 12);
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(30, 13);
            this.time.TabIndex = 18;
            this.time.Text = "Time";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label7.Location = new System.Drawing.Point(44, 11);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(275, 30);
            this.label7.TabIndex = 19;
            this.label7.Text = "SJ BOOKING SYSTEM";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.time);
            this.Controls.Add(this.date);
            this.Controls.Add(this.txtprice);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtfrom);
            this.Controls.Add(this.txtnt);
            this.Controls.Add(this.txtlname);
            this.Controls.Add(this.txtto);
            this.Controls.Add(this.txtfname);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtfname;
        private System.Windows.Forms.TextBox txtto;
        private System.Windows.Forms.TextBox txtlname;
        private System.Windows.Forms.TextBox txtnt;
        private System.Windows.Forms.TextBox txtfrom;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtprice;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn TicketNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn From;
        private System.Windows.Forms.DataGridViewTextBoxColumn To;
        private System.Windows.Forms.Label date;
        private System.Windows.Forms.Label time;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label7;
    }
}

