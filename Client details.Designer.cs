namespace Quiet_Attic_Films
{
    partial class Client_details
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Client_details));
            this.label1 = new System.Windows.Forms.Label();
            this.groupBoxRegistration = new System.Windows.Forms.GroupBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnRegister = new System.Windows.Forms.Button();
            this.txtcemail = new System.Windows.Forms.TextBox();
            this.txtcaddress = new System.Windows.Forms.TextBox();
            this.txtccn = new System.Windows.Forms.TextBox();
            this.txtcfn = new System.Windows.Forms.TextBox();
            this.txtcid = new System.Windows.Forms.TextBox();
            this.lblemail = new System.Windows.Forms.Label();
            this.lbladdr = new System.Windows.Forms.Label();
            this.lblcn = new System.Windows.Forms.Label();
            this.lblfn = new System.Windows.Forms.Label();
            this.lblid = new System.Windows.Forms.Label();
            this.groupBoxEdit_details = new System.Windows.Forms.GroupBox();
            this.btnedlet = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.comboBoxCid = new System.Windows.Forms.ComboBox();
            this.lblCid = new System.Windows.Forms.Label();
            this.btnmm = new System.Windows.Forms.Button();
            this.btnlogout = new System.Windows.Forms.Button();
            this.btnexit = new System.Windows.Forms.Button();
            this.quietAttic_FilmsDataSet2 = new Quiet_Attic_Films.QuietAttic_FilmsDataSet2();
            this.clientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clientTableAdapter = new Quiet_Attic_Films.QuietAttic_FilmsDataSet2TableAdapters.ClientTableAdapter();
            this.groupBoxRegistration.SuspendLayout();
            this.groupBoxEdit_details.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.quietAttic_FilmsDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Font = new System.Drawing.Font("Elephant", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(244, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Client Details";
            // 
            // groupBoxRegistration
            // 
            this.groupBoxRegistration.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxRegistration.Controls.Add(this.btnClear);
            this.groupBoxRegistration.Controls.Add(this.btnRegister);
            this.groupBoxRegistration.Controls.Add(this.txtcemail);
            this.groupBoxRegistration.Controls.Add(this.txtcaddress);
            this.groupBoxRegistration.Controls.Add(this.txtccn);
            this.groupBoxRegistration.Controls.Add(this.txtcfn);
            this.groupBoxRegistration.Controls.Add(this.txtcid);
            this.groupBoxRegistration.Controls.Add(this.lblemail);
            this.groupBoxRegistration.Controls.Add(this.lbladdr);
            this.groupBoxRegistration.Controls.Add(this.lblcn);
            this.groupBoxRegistration.Controls.Add(this.lblfn);
            this.groupBoxRegistration.Controls.Add(this.lblid);
            this.groupBoxRegistration.Font = new System.Drawing.Font("Elephant", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxRegistration.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBoxRegistration.Location = new System.Drawing.Point(19, 54);
            this.groupBoxRegistration.Name = "groupBoxRegistration";
            this.groupBoxRegistration.Size = new System.Drawing.Size(552, 362);
            this.groupBoxRegistration.TabIndex = 1;
            this.groupBoxRegistration.TabStop = false;
            this.groupBoxRegistration.Text = "Registration";
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Transparent;
            this.btnClear.ForeColor = System.Drawing.Color.Black;
            this.btnClear.Location = new System.Drawing.Point(170, 301);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(111, 36);
            this.btnClear.TabIndex = 7;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnRegister
            // 
            this.btnRegister.ForeColor = System.Drawing.Color.Black;
            this.btnRegister.Location = new System.Drawing.Point(400, 301);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(111, 36);
            this.btnRegister.TabIndex = 6;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // txtcemail
            // 
            this.txtcemail.Location = new System.Drawing.Point(170, 243);
            this.txtcemail.Name = "txtcemail";
            this.txtcemail.Size = new System.Drawing.Size(341, 33);
            this.txtcemail.TabIndex = 5;
            // 
            // txtcaddress
            // 
            this.txtcaddress.Location = new System.Drawing.Point(170, 189);
            this.txtcaddress.Name = "txtcaddress";
            this.txtcaddress.Size = new System.Drawing.Size(341, 33);
            this.txtcaddress.TabIndex = 4;
            // 
            // txtccn
            // 
            this.txtccn.Location = new System.Drawing.Point(170, 138);
            this.txtccn.Name = "txtccn";
            this.txtccn.Size = new System.Drawing.Size(341, 33);
            this.txtccn.TabIndex = 3;
            // 
            // txtcfn
            // 
            this.txtcfn.Location = new System.Drawing.Point(170, 88);
            this.txtcfn.Name = "txtcfn";
            this.txtcfn.Size = new System.Drawing.Size(341, 33);
            this.txtcfn.TabIndex = 2;
            // 
            // txtcid
            // 
            this.txtcid.Location = new System.Drawing.Point(170, 38);
            this.txtcid.Name = "txtcid";
            this.txtcid.Size = new System.Drawing.Size(341, 33);
            this.txtcid.TabIndex = 1;
            // 
            // lblemail
            // 
            this.lblemail.AutoSize = true;
            this.lblemail.Location = new System.Drawing.Point(30, 246);
            this.lblemail.Name = "lblemail";
            this.lblemail.Size = new System.Drawing.Size(74, 26);
            this.lblemail.TabIndex = 4;
            this.lblemail.Text = "Email";
            // 
            // lbladdr
            // 
            this.lbladdr.AutoSize = true;
            this.lbladdr.Location = new System.Drawing.Point(30, 192);
            this.lbladdr.Name = "lbladdr";
            this.lbladdr.Size = new System.Drawing.Size(92, 26);
            this.lbladdr.TabIndex = 3;
            this.lbladdr.Text = "Address";
            // 
            // lblcn
            // 
            this.lblcn.AutoSize = true;
            this.lblcn.Location = new System.Drawing.Point(30, 141);
            this.lblcn.Name = "lblcn";
            this.lblcn.Size = new System.Drawing.Size(125, 26);
            this.lblcn.TabIndex = 2;
            this.lblcn.Text = "Contact No";
            // 
            // lblfn
            // 
            this.lblfn.AutoSize = true;
            this.lblfn.Location = new System.Drawing.Point(30, 91);
            this.lblfn.Name = "lblfn";
            this.lblfn.Size = new System.Drawing.Size(120, 26);
            this.lblfn.TabIndex = 1;
            this.lblfn.Text = "Full Name";
            // 
            // lblid
            // 
            this.lblid.AutoSize = true;
            this.lblid.Location = new System.Drawing.Point(30, 45);
            this.lblid.Name = "lblid";
            this.lblid.Size = new System.Drawing.Size(42, 26);
            this.lblid.TabIndex = 0;
            this.lblid.Text = "ID";
            // 
            // groupBoxEdit_details
            // 
            this.groupBoxEdit_details.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxEdit_details.Controls.Add(this.btnedlet);
            this.groupBoxEdit_details.Controls.Add(this.btnUpdate);
            this.groupBoxEdit_details.Controls.Add(this.comboBoxCid);
            this.groupBoxEdit_details.Controls.Add(this.lblCid);
            this.groupBoxEdit_details.Font = new System.Drawing.Font("Elephant", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxEdit_details.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBoxEdit_details.Location = new System.Drawing.Point(19, 436);
            this.groupBoxEdit_details.Name = "groupBoxEdit_details";
            this.groupBoxEdit_details.Size = new System.Drawing.Size(373, 181);
            this.groupBoxEdit_details.TabIndex = 2;
            this.groupBoxEdit_details.TabStop = false;
            this.groupBoxEdit_details.Text = "Edit details";
            // 
            // btnedlet
            // 
            this.btnedlet.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnedlet.Location = new System.Drawing.Point(232, 117);
            this.btnedlet.Name = "btnedlet";
            this.btnedlet.Size = new System.Drawing.Size(102, 36);
            this.btnedlet.TabIndex = 10;
            this.btnedlet.Text = "Delete";
            this.btnedlet.UseVisualStyleBackColor = true;
            this.btnedlet.Click += new System.EventHandler(this.btnedlet_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnUpdate.Location = new System.Drawing.Point(35, 117);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(102, 36);
            this.btnUpdate.TabIndex = 9;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // comboBoxCid
            // 
            this.comboBoxCid.DataSource = this.clientBindingSource;
            this.comboBoxCid.DisplayMember = "ID";
            this.comboBoxCid.FormattingEnabled = true;
            this.comboBoxCid.Location = new System.Drawing.Point(170, 63);
            this.comboBoxCid.Name = "comboBoxCid";
            this.comboBoxCid.Size = new System.Drawing.Size(164, 34);
            this.comboBoxCid.TabIndex = 8;
            this.comboBoxCid.ValueMember = "ID";
            this.comboBoxCid.SelectedIndexChanged += new System.EventHandler(this.comboBoxCid_SelectedIndexChanged);
            // 
            // lblCid
            // 
            this.lblCid.AutoSize = true;
            this.lblCid.Location = new System.Drawing.Point(30, 66);
            this.lblCid.Name = "lblCid";
            this.lblCid.Size = new System.Drawing.Size(109, 26);
            this.lblCid.TabIndex = 0;
            this.lblCid.Text = "Client ID";
            // 
            // btnmm
            // 
            this.btnmm.Font = new System.Drawing.Font("Elephant", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmm.Location = new System.Drawing.Point(224, 637);
            this.btnmm.Name = "btnmm";
            this.btnmm.Size = new System.Drawing.Size(144, 37);
            this.btnmm.TabIndex = 12;
            this.btnmm.Text = "Main Menu";
            this.btnmm.UseVisualStyleBackColor = true;
            this.btnmm.Click += new System.EventHandler(this.btnmm_Click);
            // 
            // btnlogout
            // 
            this.btnlogout.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnlogout.Font = new System.Drawing.Font("Elephant", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlogout.Location = new System.Drawing.Point(21, 637);
            this.btnlogout.Name = "btnlogout";
            this.btnlogout.Size = new System.Drawing.Size(102, 37);
            this.btnlogout.TabIndex = 11;
            this.btnlogout.Text = "Logout";
            this.btnlogout.UseVisualStyleBackColor = true;
            this.btnlogout.Click += new System.EventHandler(this.btnlogout_Click);
            // 
            // btnexit
            // 
            this.btnexit.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnexit.Font = new System.Drawing.Font("Elephant", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexit.Location = new System.Drawing.Point(469, 637);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(102, 37);
            this.btnexit.TabIndex = 13;
            this.btnexit.Text = "Exit";
            this.btnexit.UseVisualStyleBackColor = true;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // quietAttic_FilmsDataSet2
            // 
            this.quietAttic_FilmsDataSet2.DataSetName = "QuietAttic_FilmsDataSet2";
            this.quietAttic_FilmsDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clientBindingSource
            // 
            this.clientBindingSource.DataMember = "Client";
            this.clientBindingSource.DataSource = this.quietAttic_FilmsDataSet2;
            // 
            // clientTableAdapter
            // 
            this.clientTableAdapter.ClearBeforeFill = true;
            // 
            // Client_details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Quiet_Attic_Films.Properties.Resources._00;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(592, 704);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.btnlogout);
            this.Controls.Add(this.btnmm);
            this.Controls.Add(this.groupBoxEdit_details);
            this.Controls.Add(this.groupBoxRegistration);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Client_details";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Client_details";
            this.Load += new System.EventHandler(this.Client_details_Load);
            this.groupBoxRegistration.ResumeLayout(false);
            this.groupBoxRegistration.PerformLayout();
            this.groupBoxEdit_details.ResumeLayout(false);
            this.groupBoxEdit_details.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.quietAttic_FilmsDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBoxRegistration;
        private System.Windows.Forms.TextBox txtcemail;
        private System.Windows.Forms.TextBox txtcaddress;
        private System.Windows.Forms.TextBox txtccn;
        private System.Windows.Forms.TextBox txtcfn;
        private System.Windows.Forms.TextBox txtcid;
        private System.Windows.Forms.Label lblemail;
        private System.Windows.Forms.Label lbladdr;
        private System.Windows.Forms.Label lblcn;
        private System.Windows.Forms.Label lblfn;
        private System.Windows.Forms.Label lblid;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.GroupBox groupBoxEdit_details;
        private System.Windows.Forms.Button btnedlet;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.ComboBox comboBoxCid;
        private System.Windows.Forms.Label lblCid;
        private System.Windows.Forms.Button btnmm;
        private System.Windows.Forms.Button btnlogout;
        private System.Windows.Forms.Button btnexit;
        private QuietAttic_FilmsDataSet2 quietAttic_FilmsDataSet2;
        private System.Windows.Forms.BindingSource clientBindingSource;
        private QuietAttic_FilmsDataSet2TableAdapters.ClientTableAdapter clientTableAdapter;
    }
}