namespace Quiet_Attic_Films
{
    partial class Property_details
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Property_details));
            this.lblpropertyd = new System.Windows.Forms.Label();
            this.groupBoxdetails = new System.Windows.Forms.GroupBox();
            this.btnRegister = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.comboBoxproid = new System.Windows.Forms.ComboBox();
            this.productionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quietAttic_FilmsDataSet6 = new Quiet_Attic_Films.QuietAttic_FilmsDataSet6();
            this.comboBoxppt = new System.Windows.Forms.ComboBox();
            this.txtpdes = new System.Windows.Forms.TextBox();
            this.txtpname = new System.Windows.Forms.TextBox();
            this.txtpid = new System.Windows.Forms.TextBox();
            this.lblpid = new System.Windows.Forms.Label();
            this.lblProperty_Type = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblname = new System.Windows.Forms.Label();
            this.lblid = new System.Windows.Forms.Label();
            this.groupBoxEdit_details = new System.Windows.Forms.GroupBox();
            this.btnedlet = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.comboBoxPID = new System.Windows.Forms.ComboBox();
            this.lblproid = new System.Windows.Forms.Label();
            this.btnexit = new System.Windows.Forms.Button();
            this.btnlogout = new System.Windows.Forms.Button();
            this.btnmm = new System.Windows.Forms.Button();
            this.productionTableAdapter = new Quiet_Attic_Films.QuietAttic_FilmsDataSet6TableAdapters.ProductionTableAdapter();
            this.groupBoxdetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quietAttic_FilmsDataSet6)).BeginInit();
            this.groupBoxEdit_details.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblpropertyd
            // 
            this.lblpropertyd.AutoSize = true;
            this.lblpropertyd.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblpropertyd.Font = new System.Drawing.Font("Elephant", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpropertyd.ForeColor = System.Drawing.SystemColors.Control;
            this.lblpropertyd.Location = new System.Drawing.Point(12, 9);
            this.lblpropertyd.Name = "lblpropertyd";
            this.lblpropertyd.Size = new System.Drawing.Size(291, 42);
            this.lblpropertyd.TabIndex = 2;
            this.lblpropertyd.Text = "Property Details";
            // 
            // groupBoxdetails
            // 
            this.groupBoxdetails.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxdetails.Controls.Add(this.btnRegister);
            this.groupBoxdetails.Controls.Add(this.btnClear);
            this.groupBoxdetails.Controls.Add(this.comboBoxproid);
            this.groupBoxdetails.Controls.Add(this.comboBoxppt);
            this.groupBoxdetails.Controls.Add(this.txtpdes);
            this.groupBoxdetails.Controls.Add(this.txtpname);
            this.groupBoxdetails.Controls.Add(this.txtpid);
            this.groupBoxdetails.Controls.Add(this.lblpid);
            this.groupBoxdetails.Controls.Add(this.lblProperty_Type);
            this.groupBoxdetails.Controls.Add(this.lblDescription);
            this.groupBoxdetails.Controls.Add(this.lblname);
            this.groupBoxdetails.Controls.Add(this.lblid);
            this.groupBoxdetails.Font = new System.Drawing.Font("Elephant", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxdetails.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBoxdetails.Location = new System.Drawing.Point(19, 54);
            this.groupBoxdetails.Name = "groupBoxdetails";
            this.groupBoxdetails.Size = new System.Drawing.Size(606, 417);
            this.groupBoxdetails.TabIndex = 3;
            this.groupBoxdetails.TabStop = false;
            this.groupBoxdetails.Text = "Details";
            // 
            // btnRegister
            // 
            this.btnRegister.ForeColor = System.Drawing.Color.Black;
            this.btnRegister.Location = new System.Drawing.Point(456, 358);
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
            this.btnClear.Location = new System.Drawing.Point(222, 358);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(111, 36);
            this.btnClear.TabIndex = 6;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // comboBoxproid
            // 
            this.comboBoxproid.DataSource = this.productionBindingSource;
            this.comboBoxproid.DisplayMember = "ID";
            this.comboBoxproid.FormattingEnabled = true;
            this.comboBoxproid.Location = new System.Drawing.Point(222, 300);
            this.comboBoxproid.Name = "comboBoxproid";
            this.comboBoxproid.Size = new System.Drawing.Size(137, 34);
            this.comboBoxproid.TabIndex = 5;
            this.comboBoxproid.ValueMember = "ID";
            this.comboBoxproid.SelectedIndexChanged += new System.EventHandler(this.comboBoxproid_SelectedIndexChanged);
            // 
            // productionBindingSource
            // 
            this.productionBindingSource.DataMember = "Production";
            this.productionBindingSource.DataSource = this.quietAttic_FilmsDataSet6;
            // 
            // quietAttic_FilmsDataSet6
            // 
            this.quietAttic_FilmsDataSet6.DataSetName = "QuietAttic_FilmsDataSet6";
            this.quietAttic_FilmsDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // comboBoxppt
            // 
            this.comboBoxppt.FormattingEnabled = true;
            this.comboBoxppt.Items.AddRange(new object[] {
            "Vehicle                   ",
            "Furniture",
            "Building"});
            this.comboBoxppt.Location = new System.Drawing.Point(222, 245);
            this.comboBoxppt.Name = "comboBoxppt";
            this.comboBoxppt.Size = new System.Drawing.Size(345, 34);
            this.comboBoxppt.TabIndex = 4;
            // 
            // txtpdes
            // 
            this.txtpdes.Location = new System.Drawing.Point(222, 131);
            this.txtpdes.Multiline = true;
            this.txtpdes.Name = "txtpdes";
            this.txtpdes.Size = new System.Drawing.Size(345, 94);
            this.txtpdes.TabIndex = 3;
            // 
            // txtpname
            // 
            this.txtpname.Location = new System.Drawing.Point(222, 82);
            this.txtpname.Name = "txtpname";
            this.txtpname.Size = new System.Drawing.Size(345, 33);
            this.txtpname.TabIndex = 2;
            // 
            // txtpid
            // 
            this.txtpid.Location = new System.Drawing.Point(222, 36);
            this.txtpid.Name = "txtpid";
            this.txtpid.Size = new System.Drawing.Size(345, 33);
            this.txtpid.TabIndex = 1;
            // 
            // lblpid
            // 
            this.lblpid.AutoSize = true;
            this.lblpid.Location = new System.Drawing.Point(34, 303);
            this.lblpid.Name = "lblpid";
            this.lblpid.Size = new System.Drawing.Size(164, 26);
            this.lblpid.TabIndex = 4;
            this.lblpid.Text = "Production ID ";
            // 
            // lblProperty_Type
            // 
            this.lblProperty_Type.AutoSize = true;
            this.lblProperty_Type.Location = new System.Drawing.Point(34, 248);
            this.lblProperty_Type.Name = "lblProperty_Type";
            this.lblProperty_Type.Size = new System.Drawing.Size(154, 26);
            this.lblProperty_Type.TabIndex = 3;
            this.lblProperty_Type.Text = "Property Type";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(34, 134);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(131, 26);
            this.lblDescription.TabIndex = 2;
            this.lblDescription.Text = "Description";
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.Location = new System.Drawing.Point(34, 85);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(72, 26);
            this.lblname.TabIndex = 1;
            this.lblname.Text = "Name";
            // 
            // lblid
            // 
            this.lblid.AutoSize = true;
            this.lblid.Location = new System.Drawing.Point(34, 39);
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
            this.groupBoxEdit_details.Controls.Add(this.comboBoxPID);
            this.groupBoxEdit_details.Controls.Add(this.lblproid);
            this.groupBoxEdit_details.Font = new System.Drawing.Font("Elephant", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxEdit_details.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBoxEdit_details.Location = new System.Drawing.Point(19, 477);
            this.groupBoxEdit_details.Name = "groupBoxEdit_details";
            this.groupBoxEdit_details.Size = new System.Drawing.Size(403, 181);
            this.groupBoxEdit_details.TabIndex = 4;
            this.groupBoxEdit_details.TabStop = false;
            this.groupBoxEdit_details.Text = "Edit details";
            // 
            // btnedlet
            // 
            this.btnedlet.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnedlet.Location = new System.Drawing.Point(257, 117);
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
            this.btnUpdate.Location = new System.Drawing.Point(39, 117);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(102, 36);
            this.btnUpdate.TabIndex = 9;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // comboBoxPID
            // 
            this.comboBoxPID.FormattingEnabled = true;
            this.comboBoxPID.Location = new System.Drawing.Point(222, 60);
            this.comboBoxPID.Name = "comboBoxPID";
            this.comboBoxPID.Size = new System.Drawing.Size(137, 34);
            this.comboBoxPID.TabIndex = 8;
            this.comboBoxPID.SelectedIndexChanged += new System.EventHandler(this.comboBoxPID_SelectedIndexChanged);
            // 
            // lblproid
            // 
            this.lblproid.AutoSize = true;
            this.lblproid.Location = new System.Drawing.Point(34, 63);
            this.lblproid.Name = "lblproid";
            this.lblproid.Size = new System.Drawing.Size(135, 26);
            this.lblproid.TabIndex = 0;
            this.lblproid.Text = "Property ID";
            // 
            // btnexit
            // 
            this.btnexit.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnexit.Font = new System.Drawing.Font("Elephant", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexit.Location = new System.Drawing.Point(516, 676);
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
            this.btnlogout.Location = new System.Drawing.Point(19, 676);
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
            this.btnmm.Location = new System.Drawing.Point(241, 676);
            this.btnmm.Name = "btnmm";
            this.btnmm.Size = new System.Drawing.Size(144, 37);
            this.btnmm.TabIndex = 12;
            this.btnmm.Text = "Main Menu";
            this.btnmm.UseVisualStyleBackColor = true;
            this.btnmm.Click += new System.EventHandler(this.btnmm_Click);
            // 
            // productionTableAdapter
            // 
            this.productionTableAdapter.ClearBeforeFill = true;
            // 
            // Property_details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = global::Quiet_Attic_Films.Properties.Resources._00;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(650, 735);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.btnlogout);
            this.Controls.Add(this.btnmm);
            this.Controls.Add(this.groupBoxEdit_details);
            this.Controls.Add(this.groupBoxdetails);
            this.Controls.Add(this.lblpropertyd);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Property_details";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Property_details";
            this.Load += new System.EventHandler(this.Property_details_Load);
            this.groupBoxdetails.ResumeLayout(false);
            this.groupBoxdetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quietAttic_FilmsDataSet6)).EndInit();
            this.groupBoxEdit_details.ResumeLayout(false);
            this.groupBoxEdit_details.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblpropertyd;
        private System.Windows.Forms.GroupBox groupBoxdetails;
        private System.Windows.Forms.ComboBox comboBoxproid;
        private System.Windows.Forms.ComboBox comboBoxppt;
        private System.Windows.Forms.TextBox txtpdes;
        private System.Windows.Forms.TextBox txtpname;
        private System.Windows.Forms.TextBox txtpid;
        private System.Windows.Forms.Label lblpid;
        private System.Windows.Forms.Label lblProperty_Type;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.Label lblid;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.GroupBox groupBoxEdit_details;
        private System.Windows.Forms.Button btnedlet;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.ComboBox comboBoxPID;
        private System.Windows.Forms.Label lblproid;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.Button btnlogout;
        private System.Windows.Forms.Button btnmm;
        private QuietAttic_FilmsDataSet6 quietAttic_FilmsDataSet6;
        private System.Windows.Forms.BindingSource productionBindingSource;
        private QuietAttic_FilmsDataSet6TableAdapters.ProductionTableAdapter productionTableAdapter;
    }
}