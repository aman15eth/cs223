namespace labexec.Properties{
    partial class aym
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.delete = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.add = new System.Windows.Forms.Label();
            this.userControl11 = new labexec.UserControl1();
            this.userControl12 = new labexec.UserControl1();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.flowLayoutPanel1);
            this.panel1.Controls.Add(this.userControl12);
            this.panel1.Controls.Add(this.userControl11);
            this.panel1.Location = new System.Drawing.Point(130, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(658, 343);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.delete);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.add);
            this.panel2.Location = new System.Drawing.Point(12, 15);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(112, 255);
            this.panel2.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Desktop;
            this.panel3.Location = new System.Drawing.Point(13, 68);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(13, 13);
            this.panel3.TabIndex = 4;
            // 
            // delete
            // 
            this.delete.AutoSize = true;
            this.delete.Location = new System.Drawing.Point(32, 193);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(36, 13);
            this.delete.TabIndex = 3;
            this.delete.Text = "delete";
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "update";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // add
            // 
            this.add.AutoSize = true;
            this.add.BackColor = System.Drawing.SystemColors.Highlight;
            this.add.Location = new System.Drawing.Point(32, 68);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(25, 13);
            this.add.TabIndex = 1;
            this.add.Text = "add";
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // userControl11
            // 
            this.userControl11.Location = new System.Drawing.Point(251, 71);
            this.userControl11.MyProperty = null;
            this.userControl11.Name = "userControl11";
            this.userControl11.Size = new System.Drawing.Size(704, 402);
            this.userControl11.TabIndex = 0;
            // 
            // userControl12
            // 
            this.userControl12.Location = new System.Drawing.Point(24, 24);
            this.userControl12.MyProperty = "aymen yusuf";
            this.userControl12.Name = "userControl12";
            this.userControl12.Size = new System.Drawing.Size(381, 142);
            this.userControl12.TabIndex = 1;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Controls.Add(this.button1);
            this.flowLayoutPanel1.Controls.Add(this.button2);
            this.flowLayoutPanel1.Controls.Add(this.button3);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(58, 196);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(87, 100);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(3, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(3, 32);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(3, 61);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 5;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // aym
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "aym";
            this.Text = "aym";
            this.Load += new System.EventHandler(this.aym_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label delete;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label add;
        private UserControl1 userControl11;
        private UserControl1 userControl12;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}