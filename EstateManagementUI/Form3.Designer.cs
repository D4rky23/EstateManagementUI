namespace EstateManagementUI
{
    partial class Form3
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
            this.dgvAdminEstates = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbOwner = new System.Windows.Forms.ComboBox();
            this.cmbEstateType = new System.Windows.Forms.ComboBox();
            this.txtEstatePrice = new System.Windows.Forms.TextBox();
            this.txtEstateAddress = new System.Windows.Forms.TextBox();
            this.txtEstateName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblEstateName = new System.Windows.Forms.Label();
            this.pbEstateImage = new System.Windows.Forms.PictureBox();
            this.btnUploadImage = new System.Windows.Forms.Button();
            this.btnAddEstate = new System.Windows.Forms.Button();
            this.btnUpdateEstate = new System.Windows.Forms.Button();
            this.btnDeleteEstate = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdminEstates)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbEstateImage)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAdminEstates
            // 
            this.dgvAdminEstates.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAdminEstates.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAdminEstates.Location = new System.Drawing.Point(12, 259);
            this.dgvAdminEstates.MultiSelect = false;
            this.dgvAdminEstates.Name = "dgvAdminEstates";
            this.dgvAdminEstates.Size = new System.Drawing.Size(766, 229);
            this.dgvAdminEstates.TabIndex = 0;
            this.dgvAdminEstates.SelectionChanged += new System.EventHandler(this.dgvAdminEstates_SelectionChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnReset);
            this.groupBox1.Controls.Add(this.cmbOwner);
            this.groupBox1.Controls.Add(this.cmbEstateType);
            this.groupBox1.Controls.Add(this.txtEstatePrice);
            this.groupBox1.Controls.Add(this.txtEstateAddress);
            this.groupBox1.Controls.Add(this.txtEstateName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lblEstateName);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(210, 240);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Estate Details";
            // 
            // cmbOwner
            // 
            this.cmbOwner.FormattingEnabled = true;
            this.cmbOwner.Location = new System.Drawing.Point(38, 162);
            this.cmbOwner.Name = "cmbOwner";
            this.cmbOwner.Size = new System.Drawing.Size(121, 24);
            this.cmbOwner.TabIndex = 7;
            // 
            // cmbEstateType
            // 
            this.cmbEstateType.FormattingEnabled = true;
            this.cmbEstateType.Location = new System.Drawing.Point(38, 121);
            this.cmbEstateType.Name = "cmbEstateType";
            this.cmbEstateType.Size = new System.Drawing.Size(121, 24);
            this.cmbEstateType.TabIndex = 6;
            // 
            // txtEstatePrice
            // 
            this.txtEstatePrice.Location = new System.Drawing.Point(91, 75);
            this.txtEstatePrice.Name = "txtEstatePrice";
            this.txtEstatePrice.Size = new System.Drawing.Size(100, 22);
            this.txtEstatePrice.TabIndex = 5;
            // 
            // txtEstateAddress
            // 
            this.txtEstateAddress.Location = new System.Drawing.Point(91, 50);
            this.txtEstateAddress.Name = "txtEstateAddress";
            this.txtEstateAddress.Size = new System.Drawing.Size(100, 22);
            this.txtEstateAddress.TabIndex = 4;
            // 
            // txtEstateName
            // 
            this.txtEstateName.Location = new System.Drawing.Point(91, 22);
            this.txtEstateName.Name = "txtEstateName";
            this.txtEstateName.Size = new System.Drawing.Size(100, 22);
            this.txtEstateName.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Estate Price";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Estate Adress";
            // 
            // lblEstateName
            // 
            this.lblEstateName.AutoSize = true;
            this.lblEstateName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstateName.Location = new System.Drawing.Point(6, 27);
            this.lblEstateName.Name = "lblEstateName";
            this.lblEstateName.Size = new System.Drawing.Size(79, 13);
            this.lblEstateName.TabIndex = 0;
            this.lblEstateName.Text = "Estate Name";
            // 
            // pbEstateImage
            // 
            this.pbEstateImage.Location = new System.Drawing.Point(520, 12);
            this.pbEstateImage.Name = "pbEstateImage";
            this.pbEstateImage.Size = new System.Drawing.Size(258, 197);
            this.pbEstateImage.TabIndex = 2;
            this.pbEstateImage.TabStop = false;
            // 
            // btnUploadImage
            // 
            this.btnUploadImage.Location = new System.Drawing.Point(605, 215);
            this.btnUploadImage.Name = "btnUploadImage";
            this.btnUploadImage.Size = new System.Drawing.Size(96, 37);
            this.btnUploadImage.TabIndex = 3;
            this.btnUploadImage.Text = "Upload Image";
            this.btnUploadImage.UseVisualStyleBackColor = true;
            this.btnUploadImage.Click += new System.EventHandler(this.btnUploadImage_Click);
            // 
            // btnAddEstate
            // 
            this.btnAddEstate.Location = new System.Drawing.Point(310, 27);
            this.btnAddEstate.Name = "btnAddEstate";
            this.btnAddEstate.Size = new System.Drawing.Size(103, 39);
            this.btnAddEstate.TabIndex = 4;
            this.btnAddEstate.Text = "Add Estate";
            this.btnAddEstate.UseVisualStyleBackColor = true;
            this.btnAddEstate.Click += new System.EventHandler(this.btnAddEstate_Click);
            // 
            // btnUpdateEstate
            // 
            this.btnUpdateEstate.Location = new System.Drawing.Point(310, 88);
            this.btnUpdateEstate.Name = "btnUpdateEstate";
            this.btnUpdateEstate.Size = new System.Drawing.Size(103, 39);
            this.btnUpdateEstate.TabIndex = 5;
            this.btnUpdateEstate.Text = "Update Estate";
            this.btnUpdateEstate.UseVisualStyleBackColor = true;
            this.btnUpdateEstate.Click += new System.EventHandler(this.btnUpdateEstate_Click);
            // 
            // btnDeleteEstate
            // 
            this.btnDeleteEstate.Location = new System.Drawing.Point(310, 150);
            this.btnDeleteEstate.Name = "btnDeleteEstate";
            this.btnDeleteEstate.Size = new System.Drawing.Size(103, 39);
            this.btnDeleteEstate.TabIndex = 6;
            this.btnDeleteEstate.Text = "Delete Estate";
            this.btnDeleteEstate.UseVisualStyleBackColor = true;
            this.btnDeleteEstate.Click += new System.EventHandler(this.btnDeleteEstate_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(310, 213);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(103, 39);
            this.btnLogout.TabIndex = 7;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(47, 192);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(103, 39);
            this.btnReset.TabIndex = 8;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(790, 500);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnDeleteEstate);
            this.Controls.Add(this.btnUpdateEstate);
            this.Controls.Add(this.btnAddEstate);
            this.Controls.Add(this.btnUploadImage);
            this.Controls.Add(this.pbEstateImage);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvAdminEstates);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form3";
            this.Text = "AdminUI";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdminEstates)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbEstateImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAdminEstates;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtEstatePrice;
        private System.Windows.Forms.TextBox txtEstateAddress;
        private System.Windows.Forms.TextBox txtEstateName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblEstateName;
        private System.Windows.Forms.ComboBox cmbOwner;
        private System.Windows.Forms.ComboBox cmbEstateType;
        private System.Windows.Forms.PictureBox pbEstateImage;
        private System.Windows.Forms.Button btnUploadImage;
        private System.Windows.Forms.Button btnAddEstate;
        private System.Windows.Forms.Button btnUpdateEstate;
        private System.Windows.Forms.Button btnDeleteEstate;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnReset;
    }
}