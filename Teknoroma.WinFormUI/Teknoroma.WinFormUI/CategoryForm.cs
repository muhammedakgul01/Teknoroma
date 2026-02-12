using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Teknoroma.BLL.DesignPatterns.GenericRepository.ConcRep;
using Teknoroma.Entities;
using Teknoroma.WinFormUI.ViewModels;

namespace Teknoroma.WinFormUI
{
    public partial class CategoryForm : Form
    {
        CategoryRepository _categoryRepository;
        public CategoryForm()
        {
            InitializeComponent();

            _categoryRepository = new CategoryRepository();
        }
        void KategorileriListele()
        {
            lstKategoriler.DataSource = _categoryRepository.Select(x => new CategoryVM
            {
                ID = x.ID,
                Name = x.Name,
            }).ToList();
        }
        private void CategoryForm_Load(object sender, EventArgs e)
        {
            KategorileriListele();
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            KategorileriListele();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtKategoriIsmi.Text.Trim()))
            {
                MessageBox.Show("Lütfen eklemek istediğiniz kategorinin ismini giriniz!");
                return;
            }
            Category c = new Category
            {
                Name = txtKategoriIsmi.Text,
            };
            _categoryRepository.Add(c);
            KategorileriListele();
        }

        CategoryVM _selected;

        private void lstKategoriler_Click(object sender, EventArgs e)
        {
            if (lstKategoriler.SelectedIndex > -1)
            {
                _selected = (CategoryVM)lstKategoriler.SelectedItem;
                txtKategoriIsmi.Text = _selected.Name;
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (_selected != null)
            {
                Category toBeUpdated = _categoryRepository.Find(_selected.ID);
                toBeUpdated.Name = txtKategoriIsmi.Text;
                _categoryRepository.Update(toBeUpdated);
                KategorileriListele();
                _selected = null;
                txtKategoriIsmi.Text = null;
            }
            else
            {
                MessageBox.Show("Lütfen bir kategori seçiniz!");
            }
        }

        private void btnKategoriSil_Click(object sender, EventArgs e)
        {
            if (_selected != null)
            {
                Category deletedCategory = _categoryRepository.Find(_selected.ID);
                _categoryRepository.Delete(deletedCategory);
                KategorileriListele();
                _selected = null;
                txtKategoriIsmi.Text = null;
            }
            else
            {
                MessageBox.Show("Lütfen bir kategori seçiniz!");
            }
        }
    }
}
