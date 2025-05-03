namespace Quiet_Attic_Films
{
    partial class Location_details
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Location_details));
            this.lblld = new System.Windows.Forms.Label();
            this.groupBoxdetails = new System.Windows.Forms.GroupBox();
            this.txtlt = new System.Windows.Forms.TextBox();
            this.btnRegister = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.comboBoxpid = new System.Windows.Forms.ComboBox();
            this.productionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quietAttic_FilmsDataSet5 = new Quiet_Attic_Films.QuietAttic_FilmsDataSet5();
            this.txtlcn = new System.Windows.Forms.TextBox();
            this.txtladdress = new System.Windows.Forms.TextBox();
            this.txtlname = new System.Windows.Forms.TextBox();
            this.txtlid = new System.Windows.Forms.TextBox();
            this.lblPROid = new System.Windows.Forms.Label();
            this.lblLocation_Type = new System.Windows.Forms.Label();
            this.lblContact_No = new System.Windows.Forms.Label();
            this.lbladdress = new System.Windows.Forms.Label();
            this.lblname = new System.Windows.Forms.Label();
            this.lbllid = new System.Windows.Forms.Label();
            this.groupBoxEdit_details = new System.Windows.Forms.GroupBox();
            this.btnedlet = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.comboBoxLID = new System.Windows.Forms.ComboBox();
            this.lbllocation_id = new System.Windows.Forms.Label();
            this.btnexit = new System.Windows.Forms.Button();
            this.btnlogout = new System.Windows.Forms.Button();
            this.btnmm = new System.Windows.Forms.Button();
            this.productionTableAdapter = new Quiet_Attic_Films.QuietAttic_FilmsDataSet5TableAdapters.ProductionTableAdapter();
            this.groupBoxdetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quietAttic_FilmsDataSet5)).BeginInit();
            this.groupBoxEdit_details.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblld
            // 
            this.lblld.AutoSize = true;
            this.lblld.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblld.Font = new System.Drawing.Font("Elephant", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblld.ForeColor = System.Drawing.SystemColors.Control;
            this.lblld.Location = new System.Drawing.Point(12, 9);
            this.lblld.Name = "lblld";
            this.lblld.Size = new System.Drawing.Size(292, 42);
            this.lblld.TabIndex = 3;
            this.lblld.Text = "Location Details";
            // 
            // groupBoxdetails
            // 
            this.groupBoxdetails.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxdetails.Controls.Add(this.txtlt);
            this.groupBoxdetails.Controls.Add(this.btnRegister);
            this.groupBoxdetails.Controls.Add(this.btnClear);
            this.groupBoxdetails.Controls.Add(this.comboBoxpid);
            this.groupBoxdetails.Controls.Add(this.txtlcn);
            this.groupBoxdetails.Controls.Add(this.txtladdress);
            this.groupBoxdetails.Controls.Add(this.txtlname);
            this.groupBoxdetails.Controls.Add(this.txtlid);
            this.groupBoxdetails.Controls.Add(this.lblPROid);
            this.groupBoxdetails.Controls.Add(this.lblLocation_Type);
            this.groupBoxdetails.Controls.Add(this.lblContact_No);
            this.groupBoxdetails.Controls.Add(this.lbladdress);
            this.groupBoxdetails.Controls.Add(this.lblname);
            this.groupBoxdetails.Controls.Add(this.lbllid);
            this.groupBoxdetails.Font = new System.Drawing.Font("Elephant", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxdetails.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBoxdetails.Location = new System.Drawing.Point(19, 54);
            this.groupBoxdetails.Name = "groupBoxdetails";
            this.groupBoxdetails.Size = new System.Drawing.Size(594, 460);
            this.groupBoxdetails.TabIndex = 4;
            this.groupBoxdetails.TabStop = false;
            this.groupBoxdetails.Text = "Details";
            // 
            // txtlt
            // 
            this.txtlt.Location = new System.Drawing.Point(217, 289);
            this.txtlt.Name = "txtlt";
            this.txtlt.Size = new System.Drawing.Size(331, 33);
            this.txtlt.TabIndex = 9;
            // 
            // btnRegister
            // 
            this.btnRegister.ForeColor = System.Drawing.Color.Black;
            this.btnRegister.Location = new System.Drawing.Point(437, 403);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(111, 36);
            this.btnRegister.TabIndex = 8;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Transparent;
            this.btnClear.ForeColor = System.Drawing.Color.Black;
            this.btnClear.Location = new System.Drawing.Point(226, 403);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(111, 36);
            this.btnClear.TabIndex = 7;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // comboBoxpid
            // 
            this.comboBoxpid.DataSource = this.productionBindingSource;
            this.comboBoxpid.DisplayMember = "ID";
            this.comboBoxpid.FormattingEnabled = true;
            this.comboBoxpid.Location = new System.Drawing.Point(217, 347);
            this.comboBoxpid.Name = "comboBoxpid";
            this.comboBoxpid.Size = new System.Drawing.Size(159, 34);
            this.comboBoxpid.TabIndex = 6;
            this.comboBoxpid.ValueMember = "ID";
            // 
            // productionBindingSource
            // 
            this.productionBindingSource.DataMember = "Production";
            this.productionBindingSource.DataSource = this.quietAttic_FilmsDataSet5;
            // 
            // quietAttic_FilmsDataSet5
            // 
            this.quietAttic_FilmsDataSet5.DataSetName = "QuietAttic_FilmsDataSet5";
            this.quietAttic_FilmsDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtlcn
            // 
            this.txtlcn.Location = new System.Drawing.Point(217, 239);
            this.txtlcn.Name = "txtlcn";
            this.txtlcn.Size = new System.Drawing.Size(331, 33);
            this.txtlcn.TabIndex = 4;
            // 
            // txtladdress
            // 
            this.txtladdress.Location = new System.Drawing.Point(217, 149);
            this.txtladdress.Multiline = true;
            this.txtladdress.Name = "txtladdress";
            this.txtladdress.Size = new System.Drawing.Size(331, 74);
            this.txtladdress.TabIndex = 3;
            // 
            // txtlname
            // 
            this.txtlname.Location = new System.Drawing.Point(217, 95);
            this.txtlname.Name = "txtlname";
            this.txtlname.Size = new System.Drawing.Size(331, 33);
            this.txtlname.TabIndex = 2;
            // 
            // txtlid
            // 
            this.txtlid.Location = new System.Drawing.Point(217, 38);
            this.txtlid.Name = "txtlid";
            this.txtlid.Size = new System.Drawing.Size(331, 33);
            this.txtlid.TabIndex = 1;
            // 
            // lblPROid
            // 
            this.lblPROid.AutoSize = true;
            this.lblPROid.Location = new System.Drawing.Point(35, 350);
            this.lblPROid.Name = "lblPROid";
            this.lblPROid.Size = new System.Drawing.Size(164, 26);
            this.lblPROid.TabIndex = 5;
            this.lblPROid.Text = "Production ID ";
            // 
            // lblLocation_Type
            // 
            this.lblLocation_Type.AutoSize = true;
            this.lblLocation_Type.Location = new System.Drawing.Point(35, 292);
            this.lblLocation_Type.Name = "lblLocation_Type";
            this.lblLocation_Type.Size = new System.Drawing.Size(155, 26);
            this.lblLocation_Type.TabIndex = 4;
            this.lblLocation_Type.Text = "Location Type";
            // 
            // lblContact_No
            // 
            this.lblContact_No.AutoSize = true;
            this.lblContact_No.Location = new System.Drawing.Point(35, 242);
            this.lblContact_No.Name = "lblContact_No";
            this.lblContact_No.Size = new System.Drawing.Size(125, 26);
            this.lblContact_No.TabIndex = 3;
            this.lblContact_No.Text = "Contact No";
            // 
            // lbladdress
            // 
            this.lbladdress.AutoSize = true;
            this.lbladdress.Location = new System.Drawing.Point(35, 152);
            this.lbladdress.Name = "lbladdress";
            this.lbladdress.Size = new System.Drawing.Size(92, 26);
            this.lbladdress.TabIndex = 2;
            this.lbladdress.Text = "Address";
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.Location = new System.Drawing.Point(35, 98);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(72, 26);
            this.lblname.TabIndex = 1;
            this.lblname.Text = "Name";
            // 
            // lbllid
            // 
            this.lbllid.AutoSize = true;
            this.lbllid.Location = new System.Drawing.Point(35, 41);
            this.lbllid.Name = "lbllid";
            this.lbllid.Size = new System.Drawing.Size(42, 26);
            this.lbllid.TabIndex = 0;
            this.lbllid.Text = "ID";
            // 
            // groupBoxEdit_details
            // 
            this.groupBoxEdit_details.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxEdit_details.Controls.Add(this.btnedlet);
            this.groupBoxEdit_details.Controls.Add(this.btnUpdate);
            this.groupBoxEdit_details.Controls.Add(this.comboBoxLID);
            this.groupBoxEdit_details.Controls.Add(this.lbllocation_id);
            this.groupBoxEdit_details.Font = new System.Drawing.Font("Elephant", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxEdit_details.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBoxEdit_details.Location = new System.Drawing.Point(19, 520);
            this.groupBoxEdit_details.Name = "groupBoxEdit_details";
            this.groupBoxEdit_details.Size = new System.Drawing.Size(403, 181);
            this.groupBoxEdit_details.TabIndex = 5;
            this.groupBoxEdit_details.TabStop = false;
            this.groupBoxEdit_details.Text = "Edit details";
            // 
            // btnedlet
            // 
            this.btnedlet.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnedlet.Location = new System.Drawing.Point(257, 117);
            this.btnedlet.Name = "btnedlet";
            this.btnedlet.Size = new System.Drawing.Size(102, 36);
            this.btnedlet.TabIndex = 11;
            this.btnedlet.Text = "Delete";
            this.btnedlet.UseVisualStyleBackColor = true;
            this.btnedlet.Click += new System.EventHandler(this.btnedlet_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnUpdate.Location = new System.Drawing.Point(39, 117);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(102, 36);
            this.btnUpdate.TabIndex = 10;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // comboBoxLID
            // 
            this.comboBoxLID.FormattingEnabled = true;
            this.comboBoxLID.Location = new System.Drawing.Point(222, 60);
            this.comboBoxLID.Name = "comboBoxLID";
            this.comboBoxLID.Size = new System.Drawing.Size(137, 34);
            this.comboBoxLID.TabIndex = 9;
            this.comboBoxLID.SelectedIndexChanged += new System.EventHandler(this.comboBoxLID_SelectedIndexChanged);
            // 
            // lbllocation_id
            // 
            this.lbllocation_id.AutoSize = true;
            this.lbllocation_id.Location = new System.Drawing.Point(34, 63);
            this.lbllocation_id.Name = "lbllocation_id";
            this.lbllocation_id.Size = new System.Drawing.Size(136, 26);
            this.lbllocation_id.TabIndex = 0;
            this.lbllocation_id.Text = "Location ID";
            // 
            // btnexit
            // 
            this.btnexit.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnexit.Font = new System.Drawing.Font("Elephant", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexit.Location = new System.Drawing.Point(511, 716);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(102, 37);
            this.btnexit.TabIndex = 14;
            this.btnexit.Text = "Exit";
            this.btnexit.UseVisualStyleBackColor = true;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // btnlogout
            // 
            this.btnlogout.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnlogout.Font = new System.Drawing.Font("Elephant", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlogout.Location = new System.Drawing.Point(19, 716);
            this.btnlogout.Name = "btnlogout";
            this.btnlogout.Size = new System.Drawing.Size(102, 37);
            this.btnlogout.TabIndex = 12;
            this.btnlogout.Text = "Logout";
            this.btnlogout.UseVisualStyleBackColor = true;
            this.btnlogout.Click += new System.EventHandler(this.btnlogout_Click);
            // 
            // btnmm
            // 
            this.btnmm.Font = new System.Drawing.Font("Elephant", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmm.Location = new System.Drawing.Point(251, 716);
            this.btnmm.Name = "btnmm";
            this.btnmm.Size = new System.Drawing.Size(144, 37);
            this.btnmm.TabIndex = 13;
            this.btnmm.Text = "Main Menu";
            this.btnmm.UseVisualStyleBackColor = true;
            this.btnmm.Click += new System.EventHandler(this.btnmm_Click);
            // 
            // productionTableAdapter
            // 
            this.productionTableAdapter.ClearBeforeFill = true;
            // 
            // Location_details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = global::Quiet_Attic_Films.Properties.Resources._00;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(641, 770);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.btnlogout);
            this.Controls.Add(this.btnmm);
            this.Controls.Add(this.groupBoxEdit_details);
            this.Controls.Add(this.groupBoxdetails);
            this.Controls.Add(this.lblld);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Location_details";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Location_details";
            this.Load += new System.EventHandler(this.Location_details_Load);
            this.groupBoxdetails.ResumeLayout(false);
            this.groupBoxdetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quietAttic_FilmsDataSet5)).EndInit();
            this.groupBoxEdit_details.ResumeLayout(false);
            this.groupBoxEdit_details.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblld;
        private System.Windows.Forms.GroupBox groupBoxdetails;
        private System.Windows.Forms.ComboBox comboBoxpid;
        private System.Windows.Forms.TextBox txtlcn;
        private System.Windows.Forms.TextBox txtladdress;
        private System.Windows.Forms.TextBox txtlname;
        private System.Windows.Forms.TextBox txtlid;
        private System.Windows.Forms.Label lblPROid;
        private System.Windows.Forms.Label lblLocation_Type;
        private System.Windows.Forms.Label lblContact_No;
        private System.Windows.Forms.Label lbladdress;
        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.Label lbllid;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.GroupBox groupBoxEdit_details;
        private System.Windows.Forms.Button btnedlet;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.ComboBox comboBoxLID;
        private System.Windows.Forms.Label lbllocation_id;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.Button btnlogout;
        private System.Windows.Forms.Button btnmm;
        private QuietAttic_FilmsDataSet5 quietAttic_FilmsDataSet5;
        private System.Windows.Forms.BindingSource productionBindingSource;
        private QuietAttic_FilmsDataSet5TableAdapters.ProductionTableAdapter productionTableAdapter;
        private System.Windows.Forms.TextBox txtlt;
    }
}