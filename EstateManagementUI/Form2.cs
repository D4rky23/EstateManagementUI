using EstateDataAccess.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EstateDataAccess;
using EstateModels;
using EstateDataAccess.SqlRepository;
using System.IO;


namespace EstateManagementUI
{
    public partial class Form2 : Form
    {
        private readonly IRepository<Estate> _estateRepository;
        public Form2()
        {
            InitializeComponent();
            _estateRepository = new EstateRepository();

            LoadEstateTypes();
            LoadEstates();

            dgvEstates.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvEstates.MultiSelect = false;


        }

        private void LoadEstateTypes()
        {
           cmbEstateType.Items.Clear();
            cmbEstateType.Items.Add("Toate");
            foreach(var type in Enum.GetValues(typeof(EstateType)))
            {
                cmbEstateType.Items.Add(type);
            }
            cmbEstateType.SelectedIndex = 0;
        }

        private void LoadEstates(string searchTerm = "", string estateType = "Toate", bool sortByPrice = false, bool descending = false)
        {
            try
            {
               
                var estates = _estateRepository.GetAll();

                if (!string.IsNullOrWhiteSpace(searchTerm))
                {
                    estates = estates.Where(e => e.Name != null && e.Name.IndexOf(searchTerm, StringComparison.OrdinalIgnoreCase) >= 0).ToList();

                }

                if (estateType != "Toate" && Enum.TryParse(estateType, out EstateType type))
                {
                    estates = estates.Where(e => e.Type == type).ToList();
                }

                if (sortByPrice)
                {
                    estates = descending
                        ? estates.OrderByDescending(e => e.Price).ToList()
                        : estates.OrderBy(e => e.Price).ToList();
                }
                else
                {
                    estates = descending
                        ? estates.OrderByDescending(e => e.Name).ToList()
                        : estates.OrderBy(e => e.Name).ToList();
                }

               
                dgvEstates.DataSource = estates.Select(e => new
                {
                    e.Id,
                    e.Name,
                    e.Address,
                    Price = $"{e.Price:C}",
                    Type = e.Type.ToString(),
                    CreatedOn = e.CreateDate.ToString("yyyy-MM-dd")
                }).ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Eroare la încărcarea proprietăților: {ex.Message}");
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void btnSearchAndFilter_Click(object sender, EventArgs e)
        {
            string searchTerm = txtSearchName.Text;
            string estateType = cmbEstateType.SelectedItem.ToString();
            bool sortByPrice = rbSortByPrice.Checked;
            bool descending = false; 

            
            LoadEstates(searchTerm, estateType, sortByPrice, descending);
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {

            Form1 mainForm = new Form1();
            mainForm.Show();
            this.Close();
        }

        private void dgvEstates_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvEstates.SelectedRows.Count > 0)
            {
                int estateId = Convert.ToInt32(dgvEstates.SelectedRows[0].Cells["Id"].Value);

                var estate = _estateRepository.GetById(estateId);

                if (estate?.Pictures != null && estate.Pictures.Count > 0)
                {
                    var firstPicture = estate.Pictures[0];
                    string imagePath = firstPicture.FilePath; 
                   
                    if (!string.IsNullOrEmpty(imagePath))
                    {
                        string fullPath = Path.Combine(@"E:\Anul 2 Sem 1\MIP\EstateManagementUI\Pictures", imagePath); // Calea completă

                       
                        if (File.Exists(fullPath))
                        {
                            try
                            {
                                pbEstateImage.Image = Image.FromFile(fullPath); 
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show($"Eroare la încărcarea imaginii: {ex.Message}");
                                pbEstateImage.Image = null; 
                            }
                        }
                        else
                        {
                            MessageBox.Show("Imaginea nu a fost găsită: " + fullPath);
                            pbEstateImage.Image = null;  
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

    }
}