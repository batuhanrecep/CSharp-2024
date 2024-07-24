﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _21___Demo3___EntityFrameWork;

namespace _21___Demo4___EntityFrameWork
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void dgwProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbxNameUpdate.Text = dgwProducts.CurrentRow.Cells[1].Value.ToString();
            tbxUnitPriceUpdate.Text = dgwProducts.CurrentRow.Cells[2].Value.ToString();
            tbxStockAmountUpdate.Text = dgwProducts.CurrentRow.Cells[3].Value.ToString();
        }


        private ProductDal _productDal = new ProductDal();
        private void Form1_Load(object sender, EventArgs e)
        {
            LoadProducts();
        }

        private void LoadProducts()
        {
            dgwProducts.DataSource = _productDal.GetAll();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            _productDal.Add(new Product
            {
                Name=tbxName.Text,
                UnitPrice = Convert.ToDecimal(tbxUnitPrice.Text),
                StockAmount = Convert.ToInt32(tbxStockAmount.Text)
            });
            MessageBox.Show("Added");
            LoadProducts();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
          _productDal.Update(new Product
          {
              
              Id = Convert.ToInt32(dgwProducts.CurrentRow.Cells[0].Value),
              Name = tbxNameUpdate.Text,
              UnitPrice = Convert.ToDecimal(tbxUnitPriceUpdate.Text),
              StockAmount = Convert.ToInt32(tbxStockAmountUpdate.Text)
          }); 
          LoadProducts();
          MessageBox.Show("Updated");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            _productDal.Delete(new Product
            {
                Id = Convert.ToInt32(dgwProducts.CurrentRow.Cells[0].Value)
            });

            LoadProducts();
            MessageBox.Show("Deleted");
        }

        private void SearchProducts(string key)
        {
            //First way (against to solid principles)  
            //Query from collection 
            //Also C# is key sensitive because of that we are using ToLower
            //dgwProducts.DataSource = _productDal.GetAll().Where(p=>p.Name.ToLower().Contains(key.ToLower()).ToList();

            //Second way
            //Query from database
            var result = _productDal.GetByName(key);
            dgwProducts.DataSource = result;

        }
        private void tbxSearch_TextChanged(object sender, EventArgs e)
        {
            SearchProducts(tbxSearch.Text);
        }
        
    }
}