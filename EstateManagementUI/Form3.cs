using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EstateDataAccess.Repository;
using EstateModels;
using EstateDataAccess.SqlRepository;
using System.IO;
using System.Configuration;

namespace EstateManagementUI
{
    public partial class Form3 : Form
    {
        private readonly IRepository<Estate> _estateRepository;
        private readonly IRepository<Owner> _ownerRepository;
        private readonly PictureRepository _pictureRepository;

        private string selectedImagePath = string.Empty;

        public Form3()
        {
            InitializeComponent();
            _estateRepository = new EstateRepository();
            _ownerRepository = new OwnerRepository();
            _pictureRepository = new PictureRepository();

            LoadOwners();
            LoadEstates();
            LoadEstateTypes();
        }

        private void LoadOwners()
        {
            var owners = _ownerRepository.GetAll();
            cmbOwner.DataSource = owners;
            cmbOwner.DisplayMember = "Name";
            cmbOwner.ValueMember = "Id";
        }

        private void LoadEstates()
        {
            var estates = _estateRepository.GetAll();
            dgvAdminEstates.DataSource = estates.Select(e => new
            {
                e.Id,
                e.Name,
                e.Address,
                e.Price,
                e.Type,
                e.CreateDate
            }).ToList();
        }

        private void LoadEstateTypes()
        {
            cmbEstateType.Items.Clear();
            foreach (var type in Enum.GetValues(typeof(EstateType)))
            {
                cmbEstateType.Items.Add(type); 
            }
            cmbEstateType.SelectedIndex = 0;
        }



        private void btnAddEstate_Click(object sender, EventArgs e)
        {
            if (!Enum.TryParse<EstateType>(cmbEstateType.SelectedItem.ToString(), out var selectedType))
            {
                MessageBox.Show("Tipul de proprietate selectat nu este valid.", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var estate = new Estate
            {
                Name = txtEstateName.Text,
                Address = txtEstateAddress.Text,
                Price = double.TryParse(txtEstatePrice.Text, out var price) ? price : 0.0,
                Type = selectedType,
                OwnerId = (int)cmbOwner.SelectedValue,
                CreateDate = DateTime.Now
            };

            var createdEstate = _estateRepository.Create(estate);

            if (!string.IsNullOrEmpty(selectedImagePath))
            {
                SavePicture(createdEstate.Id);
            }

            MessageBox.Show("Estate added successfully!");
            LoadEstates();
        }


        private void btnUpdateEstate_Click(object sender, EventArgs e)
        {
            if (dgvAdminEstates.SelectedRows.Count > 0)
            {
                var selectedEstateId = (int)dgvAdminEstates.SelectedRows[0].Cells["Id"].Value;
                var estate = _estateRepository.GetById(selectedEstateId);

                estate.Name = txtEstateName.Text;
                estate.Address = txtEstateAddress.Text;
                estate.Price = double.TryParse(txtEstatePrice.Text, out var price) ? price : estate.Price;
                estate.Type = (EstateType)cmbEstateType.SelectedItem;
                estate.OwnerId = (int)cmbOwner.SelectedValue;

                _estateRepository.Update(estate);

                if (!string.IsNullOrEmpty(selectedImagePath))
                {
                    SavePicture(estate.Id);
                }

                MessageBox.Show("Estate updated successfully!");
                LoadEstates();
            }
            else
            {
                MessageBox.Show("Select an estate to update.");
            }
        }

        private void btnDeleteEstate_Click(object sender, EventArgs e)
        {
            if (dgvAdminEstates.SelectedRows.Count > 0)
            {
                var selectedEstateId = (int)dgvAdminEstates.SelectedRows[0].Cells["Id"].Value;

                _estateRepository.Delete(selectedEstateId);
                MessageBox.Show("Estate deleted successfully!");
                LoadEstates();
            }
            else
            {
                MessageBox.Show("Select an estate to delete.");
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            var mainForm = new Form1();
            mainForm.Show();
            this.Close();
        }

        private void btnUploadImage_Click(object sender, EventArgs e)
        {
            using (var openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    selectedImagePath = openFileDialog.FileName;
                    pbEstateImage.Image = null;

                    using (var tempImage = Image.FromFile(selectedImagePath))
                    {
                        pbEstateImage.Image = new Bitmap(tempImage); 
                    }
                }
            }
        }




        private void dgvAdminEstates_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvAdminEstates.SelectedRows.Count > 0)
            {
                var selectedEstateId = (int)dgvAdminEstates.SelectedRows[0].Cells["Id"].Value;
                var estate = _estateRepository.GetById(selectedEstateId);

                txtEstateName.Text = estate.Name;
                txtEstateAddress.Text = estate.Address;
                txtEstatePrice.Text = estate.Price.ToString();
                cmbEstateType.SelectedItem = estate.Type;
                cmbOwner.SelectedValue = estate.OwnerId;

                if (estate.Pictures.Count > 0)
                {
                    var firstPicture = estate.Pictures[0];
                    string fullImagePath = Path.Combine(ConfigurationManager.AppSettings["PicturesFolder"], firstPicture.Name);
                    if (File.Exists(fullImagePath))
                    {
                        using (var tempImage = Image.FromFile(fullImagePath))
                        {
                            pbEstateImage.Image = new Bitmap(tempImage);
                        }
                    }
                    else
                    {
                        pbEstateImage.Image = null;
                    }
                }
                else
                {
                    pbEstateImage.Image = null;
                }
            }
        }

        private bool IsFileLocked(string filePath)
        {
            try
            {
                using (FileStream stream = File.Open(filePath, FileMode.Open, FileAccess.ReadWrite, FileShare.None))
                {
                    stream.Close();
                }
                return false;
            }
            catch (IOException)
            {
                return true;
            }
        }

        private void SavePicture(int estateId)
        {
            try
            {
                if (IsFileLocked(selectedImagePath))
                {
                    MessageBox.Show("Imaginea este utilizată de un alt proces. Închide fișierul și încearcă din nou.",
                                    "Eroare",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                    return;
                }

                var picturesFolder = ConfigurationManager.AppSettings["PicturesFolder"];
                if (!Directory.Exists(picturesFolder))
                {
                    Directory.CreateDirectory(picturesFolder); 
                }

                var fileName = Path.GetFileName(selectedImagePath);
                var destinationPath = Path.Combine(picturesFolder, fileName);

                File.Copy(selectedImagePath, destinationPath, true);

                var picture = new Picture
                {
                    EstateId = estateId,
                    Name = fileName,
                    FilePath = destinationPath,
                    Size = new FileInfo(destinationPath).Length,
                    CreateDate = DateTime.Now
                };

                _pictureRepository.Create(picture);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"A apărut o eroare la salvarea imaginii: {ex.Message}", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }




        private void btnReset_Click(object sender, EventArgs e)
        {
            ClearControls(this);

            cmbEstateType.SelectedIndex = 0; 
            cmbOwner.SelectedIndex = 0;    
            pbEstateImage.Image = null;     

            MessageBox.Show("Fields have been reset.", "Reset", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ClearControls(Control parent)
        {
            foreach (Control control in parent.Controls)
            {
                if (control is TextBox textBox)
                {
                    textBox.Clear();
                }
                else if (control is ComboBox comboBox)
                {
                    comboBox.SelectedIndex = -1; 
                }
                else if (control is PictureBox pictureBox)
                {
                    pictureBox.Image = null; 
                }
                else if (control.HasChildren)
                {
                    ClearControls(control); 
                }
            }
        }


    }
}
