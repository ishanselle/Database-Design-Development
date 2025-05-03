namespace Quiet_Attic_Films
{
    partial class Staff_details
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Staff_details));
            this.lblsd = new System.Windows.Forms.Label();
            this.groupBoxdetails = new System.Windows.Forms.GroupBox();
            this.btnRegister = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.comboBoxpid = new System.Windows.Forms.ComboBox();
            this.productionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quietAttic_FilmsDataSet7 = new Quiet_Attic_Films.QuietAttic_FilmsDataSet7();
            this.comboBoxst = new System.Windows.Forms.ComboBox();
            this.txtsfn = new System.Windows.Forms.TextBox();
            this.txtsid = new System.Windows.Forms.TextBox();
            this.lblProductionib = new System.Windows.Forms.Label();
            this.lblST = new System.Windows.Forms.Label();
            this.lblfullname = new System.Windows.Forms.Label();
            this.lblSid = new System.Windows.Forms.Label();
            this.groupBoxSsalary = new System.Windows.Forms.GroupBox();
            this.btnsalary = new System.Windows.Forms.Button();
            this.comboBoxperday = new System.Windows.Forms.ComboBox();
            this.txtssalary = new System.Windows.Forms.TextBox();
            this.txtswd = new System.Windows.Forms.TextBox();
            this.lblSalary = new System.Windows.Forms.Label();
            this.lblWorking_Day = new System.Windows.Forms.Label();
            this.lblPerdaychargesforproduction = new System.Windows.Forms.Label();
            this.groupBoxEdit_details = new System.Windows.Forms.GroupBox();
            this.btnedlet = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.comboBoxSID = new System.Windows.Forms.ComboBox();
            this.lblstaff_id = new System.Windows.Forms.Label();
            this.btnexit = new System.Windows.Forms.Button();
            this.btnlogout = new System.Windows.Forms.Button();
            this.btnmm = new System.Windows.Forms.Button();
            this.productionTableAdapter = new Quiet_Attic_Films.QuietAttic_FilmsDataSet7TableAdapters.ProductionTableAdapter();
            this.groupBoxdetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quietAttic_FilmsDataSet7)).BeginInit();
            this.groupBoxSsalary.SuspendLayout();
            this.groupBoxEdit_details.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblsd
            // 
            this.lblsd.AutoSize = true;
            this.lblsd.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblsd.Font = new System.Drawing.Font("Elephant", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsd.ForeColor = System.Drawing.SystemColors.Control;
            this.lblsd.Location = new System.Drawing.Point(12, 9);
            this.lblsd.Name = "lblsd";
            this.lblsd.Size = new System.Drawing.Size(223, 42);
            this.lblsd.TabIndex = 4;
            this.lblsd.Text = "Staff Details";
            // 
            // groupBoxdetails
            // 
            this.groupBoxdetails.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxdetails.Controls.Add(this.btnRegister);
            this.groupBoxdetails.Controls.Add(this.btnClear);
            this.groupBoxdetails.Controls.Add(this.comboBoxpid);
            this.groupBoxdetails.Controls.Add(this.comboBoxst);
            this.groupBoxdetails.Controls.Add(this.txtsfn);
            this.groupBoxdetails.Controls.Add(this.txtsid);
            this.groupBoxdetails.Controls.Add(this.lblProductionib);
            this.groupBoxdetails.Controls.Add(this.lblST);
            this.groupBoxdetails.Controls.Add(this.lblfullname);
            this.groupBoxdetails.Controls.Add(this.lblSid);
            this.groupBoxdetails.Controls.Add(this.groupBoxSsalary);
            this.groupBoxdetails.Font = new System.Drawing.Font("Elephant", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxdetails.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBoxdetails.Location = new System.Drawing.Point(19, 54);
            this.groupBoxdetails.Name = "groupBoxdetails";
            this.groupBoxdetails.Size = new System.Drawing.Size(763, 582);
            this.groupBoxdetails.TabIndex = 5;
            this.groupBoxdetails.TabStop = false;
            this.groupBoxdetails.Text = "Details";
            // 
            // btnRegister
            // 
            this.btnRegister.ForeColor = System.Drawing.Color.Black;
            this.btnRegister.Location = new System.Drawing.Point(629, 527);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(111, 36);
            this.btnRegister.TabIndex = 10;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Transparent;
            this.btnClear.ForeColor = System.Drawing.Color.Black;
            this.btnClear.Location = new System.Drawing.Point(393, 527);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(111, 36);
            this.btnClear.TabIndex = 9;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // comboBoxpid
            // 
            this.comboBoxpid.DataSource = this.productionBindingSource;
            this.comboBoxpid.DisplayMember = "ID";
            this.comboBoxpid.FormattingEnabled = true;
            this.comboBoxpid.Location = new System.Drawing.Point(226, 482);
            this.comboBoxpid.Name = "comboBoxpid";
            this.comboBoxpid.Size = new System.Drawing.Size(210, 34);
            this.comboBoxpid.TabIndex = 8;
            this.comboBoxpid.ValueMember = "ID";
            // 
            // productionBindingSource
            // 
            this.productionBindingSource.DataMember = "Production";
            this.productionBindingSource.DataSource = this.quietAttic_FilmsDataSet7;
            // 
            // quietAttic_FilmsDataSet7
            // 
            this.quietAttic_FilmsDataSet7.DataSetName = "QuietAttic_FilmsDataSet7";
            this.quietAttic_FilmsDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // comboBoxst
            // 
            this.comboBoxst.AllowDrop = true;
            this.comboBoxst.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxst.FormattingEnabled = true;
            this.comboBoxst.Items.AddRange(new object[] {
            "- - Select Type - -",
            "Camera Crew",
            "Runner",
            "Actor",
            "Voice Actor",
            "Producer"});
            this.comboBoxst.Location = new System.Drawing.Point(226, 171);
            this.comboBoxst.Name = "comboBoxst";
            this.comboBoxst.Size = new System.Drawing.Size(422, 34);
            this.comboBoxst.TabIndex = 3;
            this.comboBoxst.Tag = "";
            this.comboBoxst.SelectedIndexChanged += new System.EventHandler(this.comboBoxst_SelectedIndexChanged);
            // 
            // txtsfn
            // 
            this.txtsfn.Location = new System.Drawing.Point(226, 107);
            this.txtsfn.Name = "txtsfn";
            this.txtsfn.Size = new System.Drawing.Size(422, 33);
            this.txtsfn.TabIndex = 2;
            // 
            // txtsid
            // 
            this.txtsid.Location = new System.Drawing.Point(226, 43);
            this.txtsid.Name = "txtsid";
            this.txtsid.Size = new System.Drawing.Size(422, 33);
            this.txtsid.TabIndex = 1;
            // 
            // lblProductionib
            // 
            this.lblProductionib.AutoSize = true;
            this.lblProductionib.Location = new System.Drawing.Point(35, 485);
            this.lblProductionib.Name = "lblProductionib";
            this.lblProductionib.Size = new System.Drawing.Size(164, 26);
            this.lblProductionib.TabIndex = 5;
            this.lblProductionib.Text = "Production ID ";
            // 
            // lblST
            // 
            this.lblST.AutoSize = true;
            this.lblST.Location = new System.Drawing.Point(35, 174);
            this.lblST.Name = "lblST";
            this.lblST.Size = new System.Drawing.Size(119, 26);
            this.lblST.TabIndex = 2;
            this.lblST.Text = "Staff  Type";
            // 
            // lblfullname
            // 
            this.lblfullname.AutoSize = true;
            this.lblfullname.Location = new System.Drawing.Point(35, 110);
            this.lblfullname.Name = "lblfullname";
            this.lblfullname.Size = new System.Drawing.Size(115, 26);
            this.lblfullname.TabIndex = 1;
            this.lblfullname.Text = "Full name";
            // 
            // lblSid
            // 
            this.lblSid.AutoSize = true;
            this.lblSid.Location = new System.Drawing.Point(35, 46);
            this.lblSid.Name = "lblSid";
            this.lblSid.Size = new System.Drawing.Size(42, 26);
            this.lblSid.TabIndex = 0;
            this.lblSid.Text = "ID";
            // 
            // groupBoxSsalary
            // 
            this.groupBoxSsalary.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxSsalary.Controls.Add(this.btnsalary);
            this.groupBoxSsalary.Controls.Add(this.comboBoxperday);
            this.groupBoxSsalary.Controls.Add(this.txtssalary);
            this.groupBoxSsalary.Controls.Add(this.txtswd);
            this.groupBoxSsalary.Controls.Add(this.lblSalary);
            this.groupBoxSsalary.Controls.Add(this.lblWorking_Day);
            this.groupBoxSsalary.Controls.Add(this.lblPerdaychargesforproduction);
            this.groupBoxSsalary.Font = new System.Drawing.Font("Elephant", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxSsalary.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBoxSsalary.Location = new System.Drawing.Point(16, 224);
            this.groupBoxSsalary.Name = "groupBoxSsalary";
            this.groupBoxSsalary.Size = new System.Drawing.Size(724, 240);
            this.groupBoxSsalary.TabIndex = 6;
            this.groupBoxSsalary.TabStop = false;
            this.groupBoxSsalary.Text = "Staff Salary";
            // 
            // btnsalary
            // 
            this.btnsalary.ForeColor = System.Drawing.Color.Black;
            this.btnsalary.Location = new System.Drawing.Point(574, 187);
            this.btnsalary.Name = "btnsalary";
            this.btnsalary.Size = new System.Drawing.Size(111, 36);
            this.btnsalary.TabIndex = 7;
            this.btnsalary.Text = "Salary";
            this.btnsalary.UseVisualStyleBackColor = true;
            this.btnsalary.Click += new System.EventHandler(this.btnsalary_Click);
            // 
            // comboBoxperday
            // 
            this.comboBoxperday.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxperday.FormattingEnabled = true;
            this.comboBoxperday.Items.AddRange(new object[] {
            "- - Select Per day - -",
            "100.00",
            "25.00",
            "200.00",
            "100.00",
            "550.00"});
            this.comboBoxperday.Location = new System.Drawing.Point(377, 91);
            this.comboBoxperday.Name = "comboBoxperday";
            this.comboBoxperday.Size = new System.Drawing.Size(308, 34);
            this.comboBoxperday.TabIndex = 5;
            // 
            // txtssalary
            // 
            this.txtssalary.Enabled = false;
            this.txtssalary.Location = new System.Drawing.Point(377, 139);
            this.txtssalary.Name = "txtssalary";
            this.txtssalary.Size = new System.Drawing.Size(308, 33);
            this.txtssalary.TabIndex = 6;
            // 
            // txtswd
            // 
            this.txtswd.Location = new System.Drawing.Point(377, 47);
            this.txtswd.Name = "txtswd";
            this.txtswd.Size = new System.Drawing.Size(308, 33);
            this.txtswd.TabIndex = 4;
            // 
            // lblSalary
            // 
            this.lblSalary.AutoSize = true;
            this.lblSalary.Location = new System.Drawing.Point(33, 142);
            this.lblSalary.Name = "lblSalary";
            this.lblSalary.Size = new System.Drawing.Size(77, 26);
            this.lblSalary.TabIndex = 4;
            this.lblSalary.Text = "Salary";
            // 
            // lblWorking_Day
            // 
            this.lblWorking_Day.AutoSize = true;
            this.lblWorking_Day.Location = new System.Drawing.Point(33, 50);
            this.lblWorking_Day.Name = "lblWorking_Day";
            this.lblWorking_Day.Size = new System.Drawing.Size(147, 26);
            this.lblWorking_Day.TabIndex = 3;
            this.lblWorking_Day.Text = "Working Day";
            // 
            // lblPerdaychargesforproduction
            // 
            this.lblPerdaychargesforproduction.AutoSize = true;
            this.lblPerdaychargesforproduction.Location = new System.Drawing.Point(33, 94);
            this.lblPerdaychargesforproduction.Name = "lblPerdaychargesforproduction";
            this.lblPerdaychargesforproduction.Size = new System.Drawing.Size(317, 26);
            this.lblPerdaychargesforproduction.TabIndex = 6;
            this.lblPerdaychargesforproduction.Text = "Per day charges for production";
            // 
            // groupBoxEdit_details
            // 
            this.groupBoxEdit_details.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxEdit_details.Controls.Add(this.btnedlet);
            this.groupBoxEdit_details.Controls.Add(this.btnUpdate);
            this.groupBoxEdit_details.Controls.Add(this.comboBoxSID);
            this.groupBoxEdit_details.Controls.Add(this.lblstaff_id);
            this.groupBoxEdit_details.Font = new System.Drawing.Font("Elephant", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxEdit_details.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBoxEdit_details.Location = new System.Drawing.Point(19, 642);
            this.groupBoxEdit_details.Name = "groupBoxEdit_details";
            this.groupBoxEdit_details.Size = new System.Drawing.Size(403, 181);
            this.groupBoxEdit_details.TabIndex = 6;
            this.groupBoxEdit_details.TabStop = false;
            this.groupBoxEdit_details.Text = "Edit details";
            // 
            // btnedlet
            // 
            this.btnedlet.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnedlet.Location = new System.Drawing.Point(261, 117);
            this.btnedlet.Name = "btnedlet";
            this.btnedlet.Size = new System.Drawing.Size(102, 36);
            this.btnedlet.TabIndex = 13;
            this.btnedlet.Text = "Delete";
            this.btnedlet.UseVisualStyleBackColor = true;
            this.btnedlet.Click += new System.EventHandler(this.btnedlet_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnUpdate.Location = new System.Drawing.Point(54, 117);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(102, 36);
            this.btnUpdate.TabIndex = 12;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // comboBoxSID
            // 
            this.comboBoxSID.FormattingEnabled = true;
            this.comboBoxSID.Location = new System.Drawing.Point(226, 60);
            this.comboBoxSID.Name = "comboBoxSID";
            this.comboBoxSID.Size = new System.Drawing.Size(137, 34);
            this.comboBoxSID.TabIndex = 11;
            this.comboBoxSID.SelectedIndexChanged += new System.EventHandler(this.comboBoxSID_SelectedIndexChanged);
            // 
            // lblstaff_id
            // 
            this.lblstaff_id.AutoSize = true;
            this.lblstaff_id.Location = new System.Drawing.Point(49, 63);
            this.lblstaff_id.Name = "lblstaff_id";
            this.lblstaff_id.Size = new System.Drawing.Size(95, 26);
            this.lblstaff_id.TabIndex = 0;
            this.lblstaff_id.Text = "Staff ID";
            // 
            // btnexit
            // 
            this.btnexit.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnexit.Font = new System.Drawing.Font("Elephant", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexit.Location = new System.Drawing.Point(680, 835);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(102, 37);
            this.btnexit.TabIndex = 16;
            this.btnexit.Text = "Exit";
            this.btnexit.UseVisualStyleBackColor = true;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // btnlogout
            // 
            this.btnlogout.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnlogout.Font = new System.Drawing.Font("Elephant", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlogout.Location = new System.Drawing.Point(19, 835);
            this.btnlogout.Name = "btnlogout";
            this.btnlogout.Size = new System.Drawing.Size(102, 37);
            this.btnlogout.TabIndex = 14;
            this.btnlogout.Text = "Logout";
            this.btnlogout.UseVisualStyleBackColor = true;
            this.btnlogout.Click += new System.EventHandler(this.btnlogout_Click);
            // 
            // btnmm
            // 
            this.btnmm.Font = new System.Drawing.Font("Elephant", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmm.Location = new System.Drawing.Point(327, 835);
            this.btnmm.Name = "btnmm";
            this.btnmm.Size = new System.Drawing.Size(144, 37);
            this.btnmm.TabIndex = 15;
            this.btnmm.Text = "Main Menu";
            this.btnmm.UseVisualStyleBackColor = true;
            this.btnmm.Click += new System.EventHandler(this.btnmm_Click);
            // 
            // productionTableAdapter
            // 
            this.productionTableAdapter.ClearBeforeFill = true;
            // 
            // Staff_details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::Quiet_Attic_Films.Properties.Resources._00;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(808, 889);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.btnlogout);
            this.Controls.Add(this.btnmm);
            this.Controls.Add(this.groupBoxEdit_details);
            this.Controls.Add(this.groupBoxdetails);
            this.Controls.Add(this.lblsd);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Staff_details";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Staff_details";
            this.Load += new System.EventHandler(this.Staff_details_Load);
            this.groupBoxdetails.ResumeLayout(false);
            this.groupBoxdetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quietAttic_FilmsDataSet7)).EndInit();
            this.groupBoxSsalary.ResumeLayout(false);
            this.groupBoxSsalary.PerformLayout();
            this.groupBoxEdit_details.ResumeLayout(false);
            this.groupBoxEdit_details.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblsd;
        private System.Windows.Forms.GroupBox groupBoxdetails;
        private System.Windows.Forms.Label lblProductionib;
        private System.Windows.Forms.Label lblSalary;
        private System.Windows.Forms.Label lblWorking_Day;
        private System.Windows.Forms.Label lblST;
        private System.Windows.Forms.Label lblfullname;
        private System.Windows.Forms.Label lblSid;
        private System.Windows.Forms.ComboBox comboBoxpid;
        private System.Windows.Forms.ComboBox comboBoxst;
        private System.Windows.Forms.TextBox txtsfn;
        private System.Windows.Forms.TextBox txtsid;
        private System.Windows.Forms.GroupBox groupBoxSsalary;
        private System.Windows.Forms.ComboBox comboBoxperday;
        private System.Windows.Forms.TextBox txtssalary;
        private System.Windows.Forms.TextBox txtswd;
        private System.Windows.Forms.Label lblPerdaychargesforproduction;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnsalary;
        private System.Windows.Forms.GroupBox groupBoxEdit_details;
        private System.Windows.Forms.Button btnedlet;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.ComboBox comboBoxSID;
        private System.Windows.Forms.Label lblstaff_id;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.Button btnlogout;
        private System.Windows.Forms.Button btnmm;
        private QuietAttic_FilmsDataSet7 quietAttic_FilmsDataSet7;
        private System.Windows.Forms.BindingSource productionBindingSource;
        private QuietAttic_FilmsDataSet7TableAdapters.ProductionTableAdapter productionTableAdapter;
    }
}