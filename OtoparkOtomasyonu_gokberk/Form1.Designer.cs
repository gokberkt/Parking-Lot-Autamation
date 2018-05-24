namespace OtoparkOtomasyonu_gokberk
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
            this.grbCustomer = new System.Windows.Forms.GroupBox();
            this.txtPhoneNo = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtTC = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grbVehicleInfo = new System.Windows.Forms.GroupBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtColor = new System.Windows.Forms.TextBox();
            this.txtLicensePlate = new System.Windows.Forms.TextBox();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtBrand = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lwRecords = new System.Windows.Forms.ListView();
            this.grbCustomer.SuspendLayout();
            this.grbVehicleInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbCustomer
            // 
            this.grbCustomer.Controls.Add(this.txtPhoneNo);
            this.grbCustomer.Controls.Add(this.txtLastName);
            this.grbCustomer.Controls.Add(this.txtName);
            this.grbCustomer.Controls.Add(this.txtTC);
            this.grbCustomer.Controls.Add(this.label4);
            this.grbCustomer.Controls.Add(this.label3);
            this.grbCustomer.Controls.Add(this.label2);
            this.grbCustomer.Controls.Add(this.label1);
            this.grbCustomer.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grbCustomer.Location = new System.Drawing.Point(12, 12);
            this.grbCustomer.Name = "grbCustomer";
            this.grbCustomer.Size = new System.Drawing.Size(390, 257);
            this.grbCustomer.TabIndex = 0;
            this.grbCustomer.TabStop = false;
            this.grbCustomer.Text = "Müşteri Bilgileri";
            // 
            // txtPhoneNo
            // 
            this.txtPhoneNo.Location = new System.Drawing.Point(133, 163);
            this.txtPhoneNo.Name = "txtPhoneNo";
            this.txtPhoneNo.Size = new System.Drawing.Size(160, 29);
            this.txtPhoneNo.TabIndex = 7;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(133, 124);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(160, 29);
            this.txtLastName.TabIndex = 6;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(133, 89);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(160, 29);
            this.txtName.TabIndex = 5;
            // 
            // txtTC
            // 
            this.txtTC.Location = new System.Drawing.Point(133, 52);
            this.txtTC.Name = "txtTC";
            this.txtTC.Size = new System.Drawing.Size(160, 29);
            this.txtTC.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(55, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 21);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tel No. :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(62, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Soyad :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(88, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ad :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "T.C Kimlik No :";
            // 
            // grbVehicleInfo
            // 
            this.grbVehicleInfo.Controls.Add(this.btnDelete);
            this.grbVehicleInfo.Controls.Add(this.btnSave);
            this.grbVehicleInfo.Controls.Add(this.txtColor);
            this.grbVehicleInfo.Controls.Add(this.txtLicensePlate);
            this.grbVehicleInfo.Controls.Add(this.txtModel);
            this.grbVehicleInfo.Controls.Add(this.label8);
            this.grbVehicleInfo.Controls.Add(this.txtBrand);
            this.grbVehicleInfo.Controls.Add(this.label7);
            this.grbVehicleInfo.Controls.Add(this.label6);
            this.grbVehicleInfo.Controls.Add(this.label5);
            this.grbVehicleInfo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grbVehicleInfo.Location = new System.Drawing.Point(408, 12);
            this.grbVehicleInfo.Name = "grbVehicleInfo";
            this.grbVehicleInfo.Size = new System.Drawing.Size(365, 257);
            this.grbVehicleInfo.TabIndex = 1;
            this.grbVehicleInfo.TabStop = false;
            this.grbVehicleInfo.Text = "Araç Bilgileri";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(178, 222);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(136, 29);
            this.btnDelete.TabIndex = 17;
            this.btnDelete.Text = "Araç Çıkış";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(23, 222);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(136, 29);
            this.btnSave.TabIndex = 16;
            this.btnSave.Text = "Araç Giriş";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtColor
            // 
            this.txtColor.Location = new System.Drawing.Point(81, 158);
            this.txtColor.Name = "txtColor";
            this.txtColor.Size = new System.Drawing.Size(160, 29);
            this.txtColor.TabIndex = 15;
            // 
            // txtLicensePlate
            // 
            this.txtLicensePlate.Location = new System.Drawing.Point(81, 47);
            this.txtLicensePlate.Name = "txtLicensePlate";
            this.txtLicensePlate.Size = new System.Drawing.Size(160, 29);
            this.txtLicensePlate.TabIndex = 12;
            // 
            // txtModel
            // 
            this.txtModel.Location = new System.Drawing.Point(81, 119);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(160, 29);
            this.txtModel.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 50);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 21);
            this.label8.TabIndex = 8;
            this.label8.Text = "Plaka :";
            // 
            // txtBrand
            // 
            this.txtBrand.Location = new System.Drawing.Point(81, 84);
            this.txtBrand.Name = "txtBrand";
            this.txtBrand.Size = new System.Drawing.Size(160, 29);
            this.txtBrand.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 84);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 21);
            this.label7.TabIndex = 9;
            this.label7.Text = "Marka :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 119);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 21);
            this.label6.TabIndex = 10;
            this.label6.Text = "Model :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 158);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 21);
            this.label5.TabIndex = 11;
            this.label5.Text = "Renk :";
            // 
            // lwRecords
            // 
            this.lwRecords.FullRowSelect = true;
            this.lwRecords.Location = new System.Drawing.Point(15, 275);
            this.lwRecords.MultiSelect = false;
            this.lwRecords.Name = "lwRecords";
            this.lwRecords.Size = new System.Drawing.Size(758, 254);
            this.lwRecords.TabIndex = 2;
            this.lwRecords.UseCompatibleStateImageBehavior = false;
            this.lwRecords.View = System.Windows.Forms.View.Details;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(785, 548);
            this.Controls.Add(this.lwRecords);
            this.Controls.Add(this.grbVehicleInfo);
            this.Controls.Add(this.grbCustomer);
            this.Name = "Form1";
            this.Text = "Timurözü Otopark";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grbCustomer.ResumeLayout(false);
            this.grbCustomer.PerformLayout();
            this.grbVehicleInfo.ResumeLayout(false);
            this.grbVehicleInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbCustomer;
        private System.Windows.Forms.TextBox txtPhoneNo;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtTC;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grbVehicleInfo;
        private System.Windows.Forms.TextBox txtColor;
        private System.Windows.Forms.TextBox txtLicensePlate;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtBrand;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ListView lwRecords;
    }
}

