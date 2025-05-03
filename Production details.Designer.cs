namespace Quiet_Attic_Films
{
    partial class Production_details
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Production_details));
            this.groupBoxRegistration = new System.Windows.Forms.GroupBox();
            this.btnRegister = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.dateTimePickerpdate = new System.Windows.Forms.DateTimePicker();
            this.comboBoxcid = new System.Windows.Forms.ComboBox();
            this.clientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quietAttic_FilmsDataSet3 = new Quiet_Attic_Films.QuietAttic_FilmsDataSet3();
            this.comboBoxppt = new System.Windows.Forms.ComboBox();
            this.txtpname = new System.Windows.Forms.TextBox();
            this.txtpid = new System.Windows.Forms.TextBox();
            this.lblcid = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblProductio_nType = new System.Windows.Forms.Label();
            this.lblname = new System.Windows.Forms.Label();
            this.lblid = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBoxEdit_details = new System.Windows.Forms.GroupBox();
            this.btnedlet = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.comboBoxproid = new System.Windows.Forms.ComboBox();
            this.productionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quietAttic_FilmsDataSet4 = new Quiet_Attic_Films.QuietAttic_FilmsDataSet4();
            this.lblpid = new System.Windows.Forms.Label();
            this.btnexit = new System.Windows.Forms.Button();
            this.btnlogout = new System.Windows.Forms.Button();
            this.btnmm = new System.Windows.Forms.Button();
            this.clientTableAdapter = new Quiet_Attic_Films.QuietAttic_FilmsDataSet3TableAdapters.ClientTableAdapter();
            this.productionTableAdapter = new Quiet_Attic_Films.QuietAttic_FilmsDataSet4TableAdapters.ProductionTableAdapter();
            this.groupBoxRegistration.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quietAttic_FilmsDataSet3)).BeginInit();
            this.groupBoxEdit_details.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quietAttic_FilmsDataSet4)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxRegistration
            // 
            this.groupBoxRegistration.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxRegistration.Controls.Add(this.btnRegister);
            this.groupBoxRegistration.Controls.Add(this.btnClear);
            this.groupBoxRegistration.Controls.Add(this.dateTimePickerpdate);
            this.groupBoxRegistration.Controls.Add(this.comboBoxcid);
            this.groupBoxRegistration.Controls.Add(this.comboBoxppt);
            this.groupBoxRegistration.Controls.Add(this.txtpname);
            this.groupBoxRegistration.Controls.Add(this.txtpid);
            this.groupBoxRegistration.Controls.Add(this.lblcid);
            this.groupBoxRegistration.Controls.Add(this.lblDate);
            this.groupBoxRegistration.Controls.Add(this.lblProductio_nType);
            this.groupBoxRegistration.Controls.Add(this.lblname);
            this.groupBoxRegistration.Controls.Add(this.lblid);
            this.groupBoxRegistration.Font = new System.Drawing.Font("Elephant", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxRegistration.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBoxRegistration.Location = new System.Drawing.Point(19, 54);
            this.groupBoxRegistration.Name = "groupBoxRegistration";
            this.groupBoxRegistration.Size = new System.Drawing.Size(622, 416);
            this.groupBoxRegistration.TabIndex = 0;
            this.groupBoxRegistration.TabStop = false;
            this.groupBoxRegistration.Text = "Registration";
            // 
            // btnRegister
            // 
            this.btnRegister.ForeColor = System.Drawing.Color.Black;
            this.btnRegister.Location = new System.Drawing.Point(470, 352);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(111, 36);
            this.btnRegister.TabIndex = 7;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Transparent;
            this.btnClear.ForeColor = System.Drawing.Color.Black;
            this.btnClear.Location = new System.Drawing.Point(267, 352);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(111, 36);
            this.btnClear.TabIndex = 6;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // dateTimePickerpdate
            // 
            this.dateTimePickerpdate.Location = new System.Drawing.Point(267, 227);
            this.dateTimePickerpdate.Name = "dateTimePickerpdate";
            this.dateTimePickerpdate.Size = new System.Drawing.Size(314, 33);
            this.dateTimePickerpdate.TabIndex = 4;
            // 
            // comboBoxcid
            // 
            this.comboBoxcid.DataSource = this.clientBindingSource;
            this.comboBoxcid.DisplayMember = "ID";
            this.comboBoxcid.FormattingEnabled = true;
            this.comboBoxcid.Location = new System.Drawing.Point(267, 294);
            this.comboBoxcid.Name = "comboBoxcid";
            this.comboBoxcid.Size = new System.Drawing.Size(151, 34);
            this.comboBoxcid.TabIndex = 5;
            this.comboBoxcid.ValueMember = "ID";
            this.comboBoxcid.SelectedIndexChanged += new System.EventHandler(this.comboBoxcid_SelectedIndexChanged);
            // 
            // clientBindingSource
            // 
            this.clientBindingSource.DataMember = "Client";
            this.clientBindingSource.DataSource = this.quietAttic_FilmsDataSet3;
            // 
            // quietAttic_FilmsDataSet3
            // 
            this.quietAttic_FilmsDataSet3.DataSetName = "QuietAttic_FilmsDataSet3";
            this.quietAttic_FilmsDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // comboBoxppt
            // 
            this.comboBoxppt.FormattingEnabled = true;
            this.comboBoxppt.Items.AddRange(new object[] {
            "Advertisement",
            "Information Film",
            "Training Film"});
            this.comboBoxppt.Location = new System.Drawing.Point(267, 162);
            this.comboBoxppt.Name = "comboBoxppt";
            this.comboBoxppt.Size = new System.Drawing.Size(314, 34);
            this.comboBoxppt.TabIndex = 3;
            // 
            // txtpname
            // 
            this.txtpname.Location = new System.Drawing.Point(267, 103);
            this.txtpname.Name = "txtpname";
            this.txtpname.Size = new System.Drawing.Size(314, 33);
            this.txtpname.TabIndex = 2;
            // 
            // txtpid
            // 
            this.txtpid.Location = new System.Drawing.Point(267, 44);
            this.txtpid.Name = "txtpid";
            this.txtpid.Size = new System.Drawing.Size(314, 33);
            this.txtpid.TabIndex = 1;
            // 
            // lblcid
            // 
            this.lblcid.AutoSize = true;
            this.lblcid.Location = new System.Drawing.Point(48, 297);
            this.lblcid.Name = "lblcid";
            this.lblcid.Size = new System.Drawing.Size(114, 26);
            this.lblcid.TabIndex = 4;
            this.lblcid.Text = "Client ID ";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(48, 232);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(62, 26);
            this.lblDate.TabIndex = 3;
            this.lblDate.Text = "Date";
            // 
            // lblProductio_nType
            // 
            this.lblProductio_nType.AutoSize = true;
            this.lblProductio_nType.Location = new System.Drawing.Point(48, 165);
            this.lblProductio_nType.Name = "lblProductio_nType";
            this.lblProductio_nType.Size = new System.Drawing.Size(178, 26);
            this.lblProductio_nType.TabIndex = 2;
            this.lblProductio_nType.Text = "Production Type";
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.Location = new System.Drawing.Point(48, 106);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(72, 26);
            this.lblname.TabIndex = 1;
            this.lblname.Text = "Name";
            // 
            // lblid
            // 
            this.lblid.AutoSize = true;
            this.lblid.Location = new System.Drawing.Point(48, 47);
            this.lblid.Name = "lblid";
            this.lblid.Size = new System.Drawing.Size(42, 26);
            this.lblid.TabIndex = 0;
            this.lblid.Text = "ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Font = new System.Drawing.Font("Elephant", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(332, 42);
            this.label1.TabIndex = 1;
            this.label1.Text = "Production Details";
            // 
            // groupBoxEdit_details
            // 
            this.groupBoxEdit_details.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxEdit_details.Controls.Add(this.btnedlet);
            this.groupBoxEdit_details.Controls.Add(this.btnUpdate);
            this.groupBoxEdit_details.Controls.Add(this.comboBoxproid);
            this.groupBoxEdit_details.Controls.Add(this.lblpid);
            this.groupBoxEdit_details.Font = new System.Drawing.Font("Elephant", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxEdit_details.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBoxEdit_details.Location = new System.Drawing.Point(19, 476);
            this.groupBoxEdit_details.Name = "groupBoxEdit_details";
            this.groupBoxEdit_details.Size = new System.Drawing.Size(447, 181);
            this.groupBoxEdit_details.TabIndex = 3;
            this.groupBoxEdit_details.TabStop = false;
            this.groupBoxEdit_details.Text = "Edit details";
            // 
            // btnedlet
            // 
            this.btnedlet.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnedlet.Location = new System.Drawing.Point(316, 117);
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
            // comboBoxproid
            // 
            this.comboBoxproid.DataSource = this.productionBindingSource;
            this.comboBoxproid.DisplayMember = "ID";
            this.comboBoxproid.FormattingEnabled = true;
            this.comboBoxproid.Location = new System.Drawing.Point(267, 63);
            this.comboBoxproid.Name = "comboBoxproid";
            this.comboBoxproid.Size = new System.Drawing.Size(151, 34);
            this.comboBoxproid.TabIndex = 8;
            this.comboBoxproid.ValueMember = "ID";
            this.comboBoxproid.SelectedIndexChanged += new System.EventHandler(this.comboBoxproid_SelectedIndexChanged);
            // 
            // productionBindingSource
            // 
            this.productionBindingSource.DataMember = "Production";
            this.productionBindingSource.DataSource = this.quietAttic_FilmsDataSet4;
            // 
            // quietAttic_FilmsDataSet4
            // 
            this.quietAttic_FilmsDataSet4.DataSetName = "QuietAttic_FilmsDataSet4";
            this.quietAttic_FilmsDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lblpid
            // 
            this.lblpid.AutoSize = true;
            this.lblpid.Location = new System.Drawing.Point(30, 66);
            this.lblpid.Name = "lblpid";
            this.lblpid.Size = new System.Drawing.Size(159, 26);
            this.lblpid.TabIndex = 0;
            this.lblpid.Text = "Production ID";
            // 
            // btnexit
            // 
            this.btnexit.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnexit.Font = new System.Drawing.Font("Elephant", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexit.Location = new System.Drawing.Point(539, 680);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(102, 37);
            this.btnexit.TabIndex = 13;
            this.btnexit.Text = "Exit";
            this.btnexit.UseVisualStyleBackColor = true;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // btnlogout
            // 
            this.btnlogout.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnlogout.Font = new System.Drawing.Font("Elephant", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlogout.Location = new System.Drawing.Point(19, 680);
            this.btnlogout.Name = "btnlogout";
            this.btnlogout.Size = new System.Drawing.Size(102, 37);
            this.btnlogout.TabIndex = 11;
            this.btnlogout.Text = "Logout";
            this.btnlogout.UseVisualStyleBackColor = true;
            this.btnlogout.Click += new System.EventHandler(this.btnlogout_Click);
            // 
            // btnmm
            // 
            this.btnmm.Font = new System.Drawing.Font("Elephant", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmm.Location = new System.Drawing.Point(253, 680);
            this.btnmm.Name = "btnmm";
            this.btnmm.Size = new System.Drawing.Size(144, 37);
            this.btnmm.TabIndex = 12;
            this.btnmm.Text = "Main Menu";
            this.btnmm.UseVisualStyleBackColor = true;
            this.btnmm.Click += new System.EventHandler(this.btnmm_Click);
            // 
            // clientTableAdapter
            // 
            this.clientTableAdapter.ClearBeforeFill = true;
            // 
            // productionTableAdapter
            // 
            this.productionTableAdapter.ClearBeforeFill = true;
            // 
            // Production_details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = global::Quiet_Attic_Films.Properties.Resources._00;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(672, 741);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.btnlogout);
            this.Controls.Add(this.btnmm);
            this.Controls.Add(this.groupBoxEdit_details);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBoxRegistration);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Production_details";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Production_details";
            this.Load += new System.EventHandler(this.Production_details_Load);
            this.groupBoxRegistration.ResumeLayout(false);
            this.groupBoxRegistration.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quietAttic_FilmsDataSet3)).EndInit();
            this.groupBoxEdit_details.ResumeLayout(false);
            this.groupBoxEdit_details.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quietAttic_FilmsDataSet4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxRegistration;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblcid;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblProductio_nType;
        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.Label lblid;
        private System.Windows.Forms.ComboBox comboBoxcid;
        private System.Windows.Forms.ComboBox comboBoxppt;
        private System.Windows.Forms.TextBox txtpname;
        private System.Windows.Forms.TextBox txtpid;
        private System.Windows.Forms.DateTimePicker dateTimePickerpdate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.GroupBox groupBoxEdit_details;
        private System.Windows.Forms.Button btnedlet;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.ComboBox comboBoxproid;
        private System.Windows.Forms.Label lblpid;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.Button btnlogout;
        private System.Windows.Forms.Button btnmm;
        private QuietAttic_FilmsDataSet3 quietAttic_FilmsDataSet3;
        private System.Windows.Forms.BindingSource clientBindingSource;
        private QuietAttic_FilmsDataSet3TableAdapters.ClientTableAdapter clientTableAdapter;
        private QuietAttic_FilmsDataSet4 quietAttic_FilmsDataSet4;
        private System.Windows.Forms.BindingSource productionBindingSource;
        private QuietAttic_FilmsDataSet4TableAdapters.ProductionTableAdapter productionTableAdapter;
    }
}