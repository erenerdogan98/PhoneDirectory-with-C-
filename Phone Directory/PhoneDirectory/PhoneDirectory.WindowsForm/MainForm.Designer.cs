namespace PhoneDirectory.WindowsForm
{
    partial class MainForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lst_list = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.txt_website = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_emailadress = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_phonenoIII = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_phonenoII = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_phonenoI = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_surname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_adress = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.txt_explanation = new System.Windows.Forms.TextBox();
            this.btn_newregister = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_event = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.btn_Json = new System.Windows.Forms.Button();
            this.btn_CSV = new System.Windows.Forms.Button();
            this.btn_xmlexport = new System.Windows.Forms.Button();
            this.btn_Remove = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lst_list);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(189, 479);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Directory List";
            // 
            // lst_list
            // 
            this.lst_list.FormattingEnabled = true;
            this.lst_list.Location = new System.Drawing.Point(7, 16);
            this.lst_list.Name = "lst_list";
            this.lst_list.Size = new System.Drawing.Size(182, 459);
            this.lst_list.TabIndex = 0;
            this.lst_list.SelectedIndexChanged += new System.EventHandler(this.lst_list_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.panel2);
            this.groupBox2.Location = new System.Drawing.Point(208, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(607, 282);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "New Directory Registration";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tabControl1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 16);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(601, 263);
            this.panel2.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(3, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(595, 305);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.txt_website);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.txt_emailadress);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.txt_phonenoIII);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.txt_phonenoII);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.txt_phonenoI);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.txt_surname);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.txt_adress);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.txt_name);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(587, 279);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Personal Information";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // txt_website
            // 
            this.txt_website.Location = new System.Drawing.Point(125, 195);
            this.txt_website.Name = "txt_website";
            this.txt_website.Size = new System.Drawing.Size(209, 20);
            this.txt_website.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(29, 198);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Web Site";
            // 
            // txt_emailadress
            // 
            this.txt_emailadress.Location = new System.Drawing.Point(125, 169);
            this.txt_emailadress.Name = "txt_emailadress";
            this.txt_emailadress.Size = new System.Drawing.Size(209, 20);
            this.txt_emailadress.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(29, 172);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Email Adress";
            // 
            // txt_phonenoIII
            // 
            this.txt_phonenoIII.Location = new System.Drawing.Point(125, 143);
            this.txt_phonenoIII.Name = "txt_phonenoIII";
            this.txt_phonenoIII.Size = new System.Drawing.Size(209, 20);
            this.txt_phonenoIII.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 146);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Phone Number III";
            // 
            // txt_phonenoII
            // 
            this.txt_phonenoII.Location = new System.Drawing.Point(125, 117);
            this.txt_phonenoII.Name = "txt_phonenoII";
            this.txt_phonenoII.Size = new System.Drawing.Size(209, 20);
            this.txt_phonenoII.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Phone Number II";
            // 
            // txt_phonenoI
            // 
            this.txt_phonenoI.Location = new System.Drawing.Point(125, 91);
            this.txt_phonenoI.Name = "txt_phonenoI";
            this.txt_phonenoI.Size = new System.Drawing.Size(209, 20);
            this.txt_phonenoI.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Phone Number*";
            // 
            // txt_surname
            // 
            this.txt_surname.Location = new System.Drawing.Point(125, 65);
            this.txt_surname.Name = "txt_surname";
            this.txt_surname.Size = new System.Drawing.Size(209, 20);
            this.txt_surname.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Surname*";
            // 
            // txt_adress
            // 
            this.txt_adress.Location = new System.Drawing.Point(382, 65);
            this.txt_adress.Multiline = true;
            this.txt_adress.Name = "txt_adress";
            this.txt_adress.Size = new System.Drawing.Size(199, 146);
            this.txt_adress.TabIndex = 7;
            this.txt_adress.TextChanged += new System.EventHandler(this.textBox8_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(443, 42);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Adress";
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(125, 39);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(209, 20);
            this.txt_name.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name*";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.txt_explanation);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(587, 279);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Explanation";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // txt_explanation
            // 
            this.txt_explanation.Location = new System.Drawing.Point(7, 7);
            this.txt_explanation.Multiline = true;
            this.txt_explanation.Name = "txt_explanation";
            this.txt_explanation.Size = new System.Drawing.Size(574, 266);
            this.txt_explanation.TabIndex = 0;
            // 
            // btn_newregister
            // 
            this.btn_newregister.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_newregister.Location = new System.Drawing.Point(218, 301);
            this.btn_newregister.Name = "btn_newregister";
            this.btn_newregister.Size = new System.Drawing.Size(587, 41);
            this.btn_newregister.TabIndex = 2;
            this.btn_newregister.Text = "New Register";
            this.btn_newregister.UseVisualStyleBackColor = true;
            this.btn_newregister.Click += new System.EventHandler(this.btn_newregister_Click);
            // 
            // btn_update
            // 
            this.btn_update.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_update.Location = new System.Drawing.Point(218, 342);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(282, 44);
            this.btn_update.TabIndex = 3;
            this.btn_update.Text = "Update";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.panel1);
            this.groupBox3.Location = new System.Drawing.Point(218, 392);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(594, 100);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Import/Export Data";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.lbl_event);
            this.panel1.Controls.Add(this.button6);
            this.panel1.Controls.Add(this.btn_Json);
            this.panel1.Controls.Add(this.btn_CSV);
            this.panel1.Controls.Add(this.btn_xmlexport);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 16);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(588, 81);
            this.panel1.TabIndex = 0;
            // 
            // lbl_event
            // 
            this.lbl_event.AutoSize = true;
            this.lbl_event.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_event.Location = new System.Drawing.Point(404, 33);
            this.lbl_event.Name = "lbl_event";
            this.lbl_event.Size = new System.Drawing.Size(120, 20);
            this.lbl_event.TabIndex = 1;
            this.lbl_event.Text = "Event : Pending";
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button6.Location = new System.Drawing.Point(296, 22);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 45);
            this.button6.TabIndex = 0;
            this.button6.Text = "Export XML";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // btn_Json
            // 
            this.btn_Json.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Json.Location = new System.Drawing.Point(204, 22);
            this.btn_Json.Name = "btn_Json";
            this.btn_Json.Size = new System.Drawing.Size(75, 45);
            this.btn_Json.TabIndex = 0;
            this.btn_Json.Text = "JSON";
            this.btn_Json.UseVisualStyleBackColor = true;
            this.btn_Json.Click += new System.EventHandler(this.btn_Json_Click);
            // 
            // btn_CSV
            // 
            this.btn_CSV.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_CSV.Location = new System.Drawing.Point(113, 22);
            this.btn_CSV.Name = "btn_CSV";
            this.btn_CSV.Size = new System.Drawing.Size(75, 45);
            this.btn_CSV.TabIndex = 0;
            this.btn_CSV.Text = "CSV";
            this.btn_CSV.UseVisualStyleBackColor = true;
            this.btn_CSV.Click += new System.EventHandler(this.btn_CSV_Click);
            // 
            // btn_xmlexport
            // 
            this.btn_xmlexport.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_xmlexport.Location = new System.Drawing.Point(18, 22);
            this.btn_xmlexport.Name = "btn_xmlexport";
            this.btn_xmlexport.Size = new System.Drawing.Size(75, 45);
            this.btn_xmlexport.TabIndex = 0;
            this.btn_xmlexport.Text = "XML";
            this.btn_xmlexport.UseVisualStyleBackColor = true;
            this.btn_xmlexport.Click += new System.EventHandler(this.btn_xmlexport_Click);
            // 
            // btn_Remove
            // 
            this.btn_Remove.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Remove.Location = new System.Drawing.Point(506, 342);
            this.btn_Remove.Name = "btn_Remove";
            this.btn_Remove.Size = new System.Drawing.Size(299, 44);
            this.btn_Remove.TabIndex = 5;
            this.btn_Remove.Text = "Remove";
            this.btn_Remove.UseVisualStyleBackColor = true;
            this.btn_Remove.Click += new System.EventHandler(this.btn_Remove_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(827, 517);
            this.Controls.Add(this.btn_Remove);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.btn_newregister);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox txt_website;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_emailadress;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_phonenoIII;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_phonenoII;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_phonenoI;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_surname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_adress;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.Button btn_newregister;
        private System.Windows.Forms.TextBox txt_explanation;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_event;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button btn_Json;
        private System.Windows.Forms.Button btn_CSV;
        private System.Windows.Forms.Button btn_xmlexport;
        private System.Windows.Forms.ListBox lst_list;
        private System.Windows.Forms.Button btn_Remove;
    }
}