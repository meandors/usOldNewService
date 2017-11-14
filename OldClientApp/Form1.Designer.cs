namespace OldClientApp
{
    partial class ClientApp
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bAdd = new System.Windows.Forms.Button();
            this.tbSurname = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.nClientID = new System.Windows.Forms.NumericUpDown();
            this.bGetByID = new System.Windows.Forms.Button();
            this.bGetAll = new System.Windows.Forms.Button();
            this.lbClients = new System.Windows.Forms.ListBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.bModify = new System.Windows.Forms.Button();
            this.tbModSurname = new System.Windows.Forms.TextBox();
            this.tbModName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.nModID = new System.Windows.Forms.NumericUpDown();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nClientID)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nModID)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.bAdd);
            this.groupBox1.Controls.Add(this.tbSurname);
            this.groupBox1.Controls.Add(this.tbName);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(263, 97);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add Client";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Surname";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Name";
            // 
            // bAdd
            // 
            this.bAdd.Location = new System.Drawing.Point(171, 54);
            this.bAdd.Name = "bAdd";
            this.bAdd.Size = new System.Drawing.Size(75, 23);
            this.bAdd.TabIndex = 2;
            this.bAdd.Text = "Add";
            this.bAdd.UseVisualStyleBackColor = true;
            this.bAdd.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbSurname
            // 
            this.tbSurname.Location = new System.Drawing.Point(65, 57);
            this.tbSurname.Name = "tbSurname";
            this.tbSurname.Size = new System.Drawing.Size(100, 20);
            this.tbSurname.TabIndex = 1;
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(65, 31);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(100, 20);
            this.tbName.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.nClientID);
            this.groupBox2.Controls.Add(this.bGetByID);
            this.groupBox2.Controls.Add(this.bGetAll);
            this.groupBox2.Controls.Add(this.lbClients);
            this.groupBox2.Location = new System.Drawing.Point(281, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(382, 237);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Get Clients";
            // 
            // nClientID
            // 
            this.nClientID.Location = new System.Drawing.Point(169, 30);
            this.nClientID.Name = "nClientID";
            this.nClientID.Size = new System.Drawing.Size(70, 20);
            this.nClientID.TabIndex = 3;
            // 
            // bGetByID
            // 
            this.bGetByID.Location = new System.Drawing.Point(87, 28);
            this.bGetByID.Name = "bGetByID";
            this.bGetByID.Size = new System.Drawing.Size(75, 23);
            this.bGetByID.TabIndex = 2;
            this.bGetByID.Text = "Get by ID";
            this.bGetByID.UseVisualStyleBackColor = true;
            this.bGetByID.Click += new System.EventHandler(this.bGetByID_Click);
            // 
            // bGetAll
            // 
            this.bGetAll.Location = new System.Drawing.Point(6, 29);
            this.bGetAll.Name = "bGetAll";
            this.bGetAll.Size = new System.Drawing.Size(75, 23);
            this.bGetAll.TabIndex = 1;
            this.bGetAll.Text = "Get all";
            this.bGetAll.UseVisualStyleBackColor = true;
            this.bGetAll.Click += new System.EventHandler(this.bGetAll_Click);
            // 
            // lbClients
            // 
            this.lbClients.FormattingEnabled = true;
            this.lbClients.Location = new System.Drawing.Point(6, 58);
            this.lbClients.Name = "lbClients";
            this.lbClients.Size = new System.Drawing.Size(370, 173);
            this.lbClients.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.nModID);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.bModify);
            this.groupBox3.Controls.Add(this.tbModSurname);
            this.groupBox3.Controls.Add(this.tbModName);
            this.groupBox3.Location = new System.Drawing.Point(12, 115);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(263, 134);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Modify client";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Surname";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Name";
            // 
            // bModify
            // 
            this.bModify.Location = new System.Drawing.Point(171, 88);
            this.bModify.Name = "bModify";
            this.bModify.Size = new System.Drawing.Size(75, 23);
            this.bModify.TabIndex = 2;
            this.bModify.Text = "Modify";
            this.bModify.UseVisualStyleBackColor = true;
            this.bModify.Click += new System.EventHandler(this.bModify_Click);
            // 
            // tbModSurname
            // 
            this.tbModSurname.Location = new System.Drawing.Point(65, 91);
            this.tbModSurname.Name = "tbModSurname";
            this.tbModSurname.Size = new System.Drawing.Size(100, 20);
            this.tbModSurname.TabIndex = 1;
            // 
            // tbModName
            // 
            this.tbModName.Location = new System.Drawing.Point(65, 65);
            this.tbModName.Name = "tbModName";
            this.tbModName.Size = new System.Drawing.Size(100, 20);
            this.tbModName.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(41, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(18, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "ID";
            // 
            // nModID
            // 
            this.nModID.Location = new System.Drawing.Point(65, 39);
            this.nModID.Name = "nModID";
            this.nModID.Size = new System.Drawing.Size(100, 20);
            this.nModID.TabIndex = 7;
            // 
            // ClientApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 262);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "ClientApp";
            this.Text = "Client App v1.00";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nClientID)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nModID)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bAdd;
        private System.Windows.Forms.TextBox tbSurname;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.NumericUpDown nClientID;
        private System.Windows.Forms.Button bGetByID;
        private System.Windows.Forms.Button bGetAll;
        private System.Windows.Forms.ListBox lbClients;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.NumericUpDown nModID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button bModify;
        private System.Windows.Forms.TextBox tbModSurname;
        private System.Windows.Forms.TextBox tbModName;
    }
}

