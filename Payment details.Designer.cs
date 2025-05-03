namespace Quiet_Attic_Films
{
    partial class Payment_details
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Payment_details));
            this.lblPayment_D = new System.Windows.Forms.Label();
            this.groupBoxdetails = new System.Windows.Forms.GroupBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnRegister = new System.Windows.Forms.Button();
            this.comboBoxpid = new System.Windows.Forms.ComboBox();
            this.dateTimePickerpdate = new System.Windows.Forms.DateTimePicker();
            this.txtpamount = new System.Windows.Forms.TextBox();
            this.txtpmethod = new System.Windows.Forms.TextBox();
            this.txtpid = new System.Windows.Forms.TextBox();
            this.lblProduction_ID = new System.Windows.Forms.Label();
            this.lblamount = new System.Windows.Forms.Label();
            this.lblmethod = new System.Windows.Forms.Label();
            this.lbldate = new System.Windows.Forms.Label();
            this.lblPID = new System.Windows.Forms.Label();
            this.groupBoxEdit_details = new System.Windows.Forms.GroupBox();
            this.btnedlet = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.comboBoxPayID = new System.Windows.Forms.ComboBox();
            this.lblPayID = new System.Windows.Forms.Label();
            this.btnexit = new System.Windows.Forms.Button();
            this.btnlogout = new System.Windows.Forms.Button();
            this.btnmm = new System.Windows.Forms.Button();
            this.quietAttic_FilmsDataSet8 = new Quiet_Attic_Films.QuietAttic_FilmsDataSet8();
            this.productionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productionTableAdapter = new Quiet_Attic_Films.QuietAttic_FilmsDataSet8TableAdapters.ProductionTableAdapter();
            this.groupBoxdetails.SuspendLayout();
            this.groupBoxEdit_details.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.quietAttic_FilmsDataSet8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productionBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPayment_D
            // 
            this.lblPayment_D.AutoSize = true;
            this.lblPayment_D.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblPayment_D.Font = new System.Drawing.Font("Elephant", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPayment_D.ForeColor = System.Drawing.SystemColors.Control;
            this.lblPayment_D.Location = new System.Drawing.Point(12, 9);
            this.lblPayment_D.Name = "lblPayment_D";
            this.lblPayment_D.Size = new System.Drawing.Size(290, 42);
            this.lblPayment_D.TabIndex = 5;
            this.lblPayment_D.Text = "Payment Details";
            // 
            // groupBoxdetails
            // 
            this.groupBoxdetails.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxdetails.Controls.Add(this.btnClear);
            this.groupBoxdetails.Controls.Add(this.btnRegister);
            this.groupBoxdetails.Controls.Add(this.comboBoxpid);
            this.groupBoxdetails.Controls.Add(this.dateTimePickerpdate);
            this.groupBoxdetails.Controls.Add(this.txtpamount);
            this.groupBoxdetails.Controls.Add(this.txtpmethod);
            this.groupBoxdetails.Controls.Add(this.txtpid);
            this.groupBoxdetails.Controls.Add(this.lblProduction_ID);
            this.groupBoxdetails.Controls.Add(this.lblamount);
            this.groupBoxdetails.Controls.Add(this.lblmethod);
            this.groupBoxdetails.Controls.Add(this.lbldate);
            this.groupBoxdetails.Controls.Add(this.lblPID);
            this.groupBoxdetails.Font = new System.Drawing.Font("Elephant", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxdetails.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBoxdetails.Location = new System.Drawing.Point(19, 54);
            this.groupBoxdetails.Name = "groupBoxdetails";
            this.groupBoxdetails.Size = new System.Drawing.Size(601, 377);
            this.groupBoxdetails.TabIndex = 6;
            this.groupBoxdetails.TabStop = false;
            this.groupBoxdetails.Text = "Details";
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Transparent;
            this.btnClear.ForeColor = System.Drawing.Color.Black;
            this.btnClear.Location = new System.Drawing.Point(239, 322);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(111, 36);
            this.btnClear.TabIndex = 6;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnRegister
            // 
            this.btnRegister.ForeColor = System.Drawing.Color.Black;
            this.btnRegister.Location = new System.Drawing.Point(463, 322);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(111, 36);
            this.btnRegister.TabIndex = 7;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // comboBoxpid
            // 
            this.comboBoxpid.DataSource = this.productionBindingSource;
            this.comboBoxpid.DisplayMember = "ID";
            this.comboBoxpid.FormattingEnabled = true;
            this.comboBoxpid.Location = new System.Drawing.Point(239, 266);
            this.comboBoxpid.Name = "comboBoxpid";
            this.comboBoxpid.Size = new System.Drawing.Size(335, 34);
            this.comboBoxpid.TabIndex = 5;
            this.comboBoxpid.ValueMember = "ID";
            // 
            // dateTimePickerpdate
            // 
            this.dateTimePickerpdate.Location = new System.Drawing.Point(239, 91);
            this.dateTimePickerpdate.Name = "dateTimePickerpdate";
            this.dateTimePickerpdate.Size = new System.Drawing.Size(335, 33);
            this.dateTimePickerpdate.TabIndex = 2;
            // 
            // txtpamount
            // 
            this.txtpamount.Location = new System.Drawing.Point(239, 209);
            this.txtpamount.Name = "txtpamount";
            this.txtpamount.Size = new System.Drawing.Size(335, 33);
            this.txtpamount.TabIndex = 4;
            // 
            // txtpmethod
            // 
            this.txtpmethod.Location = new System.Drawing.Point(239, 153);
            this.txtpmethod.Name = "txtpmethod";
            this.txtpmethod.Size = new System.Drawing.Size(335, 33);
            this.txtpmethod.TabIndex = 3;
            // 
            // txtpid
            // 
            this.txtpid.Location = new System.Drawing.Point(239, 38);
            this.txtpid.Name = "txtpid";
            this.txtpid.Size = new System.Drawing.Size(335, 33);
            this.txtpid.TabIndex = 1;
            // 
            // lblProduction_ID
            // 
            this.lblProduction_ID.AutoSize = true;
            this.lblProduction_ID.Location = new System.Drawing.Point(37, 269);
            this.lblProduction_ID.Name = "lblProduction_ID";
            this.lblProduction_ID.Size = new System.Drawing.Size(159, 26);
            this.lblProduction_ID.TabIndex = 4;
            this.lblProduction_ID.Text = "Production ID";
            // 
            // lblamount
            // 
            this.lblamount.AutoSize = true;
            this.lblamount.Location = new System.Drawing.Point(37, 212);
            this.lblamount.Name = "lblamount";
            this.lblamount.Size = new System.Drawing.Size(91, 26);
            this.lblamount.TabIndex = 3;
            this.lblamount.Text = "Amount";
            this.lblamount.Click += new System.EventHandler(this.lblamount_Click);
            // 
            // lblmethod
            // 
            this.lblmethod.AutoSize = true;
            this.lblmethod.Location = new System.Drawing.Point(37, 156);
            this.lblmethod.Name = "lblmethod";
            this.lblmethod.Size = new System.Drawing.Size(89, 26);
            this.lblmethod.TabIndex = 2;
            this.lblmethod.Text = "Method";
            // 
            // lbldate
            // 
            this.lbldate.AutoSize = true;
            this.lbldate.Location = new System.Drawing.Point(37, 96);
            this.lbldate.Name = "lbldate";
            this.lbldate.Size = new System.Drawing.Size(62, 26);
            this.lbldate.TabIndex = 1;
            this.lbldate.Text = "Date";
            // 
            // lblPID
            // 
            this.lblPID.AutoSize = true;
            this.lblPID.Location = new System.Drawing.Point(37, 41);
            this.lblPID.Name = "lblPID";
            this.lblPID.Size = new System.Drawing.Size(42, 26);
            this.lblPID.TabIndex = 0;
            this.lblPID.Text = "ID";
            // 
            // groupBoxEdit_details
            // 
            this.groupBoxEdit_details.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxEdit_details.Controls.Add(this.btnedlet);
            this.groupBoxEdit_details.Controls.Add(this.btnUpdate);
            this.groupBoxEdit_details.Controls.Add(this.comboBoxPayID);
            this.groupBoxEdit_details.Controls.Add(this.lblPayID);
            this.groupBoxEdit_details.Font = new System.Drawing.Font("Elephant", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxEdit_details.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBoxEdit_details.Location = new System.Drawing.Point(19, 437);
            this.groupBoxEdit_details.Name = "groupBoxEdit_details";
            this.groupBoxEdit_details.Size = new System.Drawing.Size(418, 181);
            this.groupBoxEdit_details.TabIndex = 7;
            this.groupBoxEdit_details.TabStop = false;
            this.groupBoxEdit_details.Text = "Edit details";
            // 
            // btnedlet
            // 
            this.btnedlet.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnedlet.Location = new System.Drawing.Point(274, 117);
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
            this.btnUpdate.Location = new System.Drawing.Point(42, 117);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(102, 36);
            this.btnUpdate.TabIndex = 9;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // comboBoxPayID
            // 
            this.comboBoxPayID.FormattingEnabled = true;
            this.comboBoxPayID.Location = new System.Drawing.Point(239, 60);
            this.comboBoxPayID.Name = "comboBoxPayID";
            this.comboBoxPayID.Size = new System.Drawing.Size(137, 34);
            this.comboBoxPayID.TabIndex = 8;
            this.comboBoxPayID.SelectedIndexChanged += new System.EventHandler(this.comboBoxPayID_SelectedIndexChanged);
            // 
            // lblPayID
            // 
            this.lblPayID.AutoSize = true;
            this.lblPayID.Location = new System.Drawing.Point(37, 63);
            this.lblPayID.Name = "lblPayID";
            this.lblPayID.Size = new System.Drawing.Size(136, 26);
            this.lblPayID.TabIndex = 0;
            this.lblPayID.Text = "Payment ID";
            // 
            // btnexit
            // 
            this.btnexit.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnexit.Font = new System.Drawing.Font("Elephant", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexit.Location = new System.Drawing.Point(518, 636);
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
            this.btnlogout.Location = new System.Drawing.Point(19, 636);
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
            this.btnmm.Location = new System.Drawing.Point(251, 636);
            this.btnmm.Name = "btnmm";
            this.btnmm.Size = new System.Drawing.Size(144, 37);
            this.btnmm.TabIndex = 12;
            this.btnmm.Text = "Main Menu";
            this.btnmm.UseVisualStyleBackColor = true;
            this.btnmm.Click += new System.EventHandler(this.btnmm_Click);
            // 
            // quietAttic_FilmsDataSet8
            // 
            this.quietAttic_FilmsDataSet8.DataSetName = "QuietAttic_FilmsDataSet8";
            this.quietAttic_FilmsDataSet8.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productionBindingSource
            // 
            this.productionBindingSource.DataMember = "Production";
            this.productionBindingSource.DataSource = this.quietAttic_FilmsDataSet8;
            // 
            // productionTableAdapter
            // 
            this.productionTableAdapter.ClearBeforeFill = true;
            // 
            // Payment_details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = global::Quiet_Attic_Films.Properties.Resources._00;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(644, 690);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.btnlogout);
            this.Controls.Add(this.btnmm);
            this.Controls.Add(this.groupBoxEdit_details);
            this.Controls.Add(this.groupBoxdetails);
            this.Controls.Add(this.lblPayment_D);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Payment_details";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Payment_details";
            this.Load += new System.EventHandler(this.Payment_details_Load);
            this.groupBoxdetails.ResumeLayout(false);
            this.groupBoxdetails.PerformLayout();
            this.groupBoxEdit_details.ResumeLayout(false);
            this.groupBoxEdit_details.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.quietAttic_FilmsDataSet8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productionBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPayment_D;
        private System.Windows.Forms.GroupBox groupBoxdetails;
        private System.Windows.Forms.Label lblProduction_ID;
        private System.Windows.Forms.Label lblamount;
        private System.Windows.Forms.Label lblmethod;
        private System.Windows.Forms.Label lbldate;
        private System.Windows.Forms.Label lblPID;
        private System.Windows.Forms.ComboBox comboBoxpid;
        private System.Windows.Forms.DateTimePicker dateTimePickerpdate;
        private System.Windows.Forms.TextBox txtpamount;
        private System.Windows.Forms.TextBox txtpmethod;
        private System.Windows.Forms.TextBox txtpid;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.GroupBox groupBoxEdit_details;
        private System.Windows.Forms.Button btnedlet;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.ComboBox comboBoxPayID;
        private System.Windows.Forms.Label lblPayID;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.Button btnlogout;
        private System.Windows.Forms.Button btnmm;
        private QuietAttic_FilmsDataSet8 quietAttic_FilmsDataSet8;
        private System.Windows.Forms.BindingSource productionBindingSource;
        private QuietAttic_FilmsDataSet8TableAdapters.ProductionTableAdapter productionTableAdapter;
    }
}