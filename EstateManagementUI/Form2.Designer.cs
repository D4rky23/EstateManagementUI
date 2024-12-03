namespace EstateManagementUI
{
    partial class Form2
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
            this.dgvEstates = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSearchName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbEstateType = new System.Windows.Forms.ComboBox();
            this.rbSortByName = new System.Windows.Forms.RadioButton();
            this.rbSortByPrice = new System.Windows.Forms.RadioButton();
            this.btnSearchAndFilter = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.pbEstateImage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstates)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEstateImage)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvEstates
            // 
            this.dgvEstates.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEstates.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEstates.Location = new System.Drawing.Point(12, 232);
            this.dgvEstates.Name = "dgvEstates";
            this.dgvEstates.Size = new System.Drawing.Size(755, 242);
            this.dgvEstates.TabIndex = 0;
            this.dgvEstates.SelectionChanged += new System.EventHandler(this.dgvEstates_SelectionChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cautare dupa nume";
            // 
            // txtSearchName
            // 
            this.txtSearchName.Location = new System.Drawing.Point(195, 15);
            this.txtSearchName.Name = "txtSearchName";
            this.txtSearchName.Size = new System.Drawing.Size(130, 20);
            this.txtSearchName.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Filtrare dupa tip";
            // 
            // cmbEstateType
            // 
            this.cmbEstateType.FormattingEnabled = true;
            this.cmbEstateType.Location = new System.Drawing.Point(195, 47);
            this.cmbEstateType.Name = "cmbEstateType";
            this.cmbEstateType.Size = new System.Drawing.Size(121, 21);
            this.cmbEstateType.TabIndex = 4;
            // 
            // rbSortByName
            // 
            this.rbSortByName.AutoSize = true;
            this.rbSortByName.Location = new System.Drawing.Point(17, 88);
            this.rbSortByName.Name = "rbSortByName";
            this.rbSortByName.Size = new System.Drawing.Size(115, 17);
            this.rbSortByName.TabIndex = 5;
            this.rbSortByName.TabStop = true;
            this.rbSortByName.Text = "Sortare dupa nume";
            this.rbSortByName.UseVisualStyleBackColor = true;
            // 
            // rbSortByPrice
            // 
            this.rbSortByPrice.AutoSize = true;
            this.rbSortByPrice.Location = new System.Drawing.Point(147, 88);
            this.rbSortByPrice.Name = "rbSortByPrice";
            this.rbSortByPrice.Size = new System.Drawing.Size(107, 17);
            this.rbSortByPrice.TabIndex = 6;
            this.rbSortByPrice.TabStop = true;
            this.rbSortByPrice.Text = "Sortare dupa pret";
            this.rbSortByPrice.UseVisualStyleBackColor = true;
            // 
            // btnSearchAndFilter
            // 
            this.btnSearchAndFilter.Location = new System.Drawing.Point(17, 140);
            this.btnSearchAndFilter.Name = "btnSearchAndFilter";
            this.btnSearchAndFilter.Size = new System.Drawing.Size(132, 36);
            this.btnSearchAndFilter.TabIndex = 7;
            this.btnSearchAndFilter.Text = "Cauta si filtreaza";
            this.btnSearchAndFilter.UseVisualStyleBackColor = true;
            this.btnSearchAndFilter.Click += new System.EventHandler(this.btnSearchAndFilter_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(195, 140);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(130, 36);
            this.btnLogout.TabIndex = 8;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // pbEstateImage
            // 
            this.pbEstateImage.Location = new System.Drawing.Point(404, 12);
            this.pbEstateImage.Name = "pbEstateImage";
            this.pbEstateImage.Size = new System.Drawing.Size(302, 163);
            this.pbEstateImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbEstateImage.TabIndex = 9;
            this.pbEstateImage.TabStop = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(779, 486);
            this.Controls.Add(this.pbEstateImage);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnSearchAndFilter);
            this.Controls.Add(this.rbSortByPrice);
            this.Controls.Add(this.rbSortByName);
            this.Controls.Add(this.cmbEstateType);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSearchName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvEstates);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form2";
            this.Text = "ClientUI";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstates)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEstateImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvEstates;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSearchName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbEstateType;
        private System.Windows.Forms.RadioButton rbSortByName;
        private System.Windows.Forms.RadioButton rbSortByPrice;
        private System.Windows.Forms.Button btnSearchAndFilter;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.PictureBox pbEstateImage;
    }
}