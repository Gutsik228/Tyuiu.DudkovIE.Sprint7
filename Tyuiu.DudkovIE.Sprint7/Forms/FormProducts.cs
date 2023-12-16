using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tyuiu.DudkovIE.Sprint7.Forms
{
    public partial class FormProducts : Form
    {
        public BindingList<Product> productList;
        private BindingSource bindingSource;

        public FormProducts()
        {
            InitializeComponent();

            // Инициализируем список и источник данных
            productList = new BindingList<Product>();
            bindingSource = new BindingSource(productList, null);

            // Привязываем источник данных к DataGridView
            dataGridView_ProductsInfo_DIE.DataSource = bindingSource;

            // Создаем столбцы для каждого свойства класса Product
        }

       
        private void button_AddProduct_DIE_Click(object sender, EventArgs e)
        {
            int ID = Convert.ToInt32(textBox_ID_DIE.Text);
            string category = textBox_Category_DIE.Text;
            string name = textBox_NameOfProduct.Text;
            string quality = textBox_QualitiyProduct_DIE.Text;
            int price = Convert.ToInt32(textBox_Price_DIE.Text);

            // Создаем объект продукта
            Product newProduct = new Product(ID, category, name, quality, price);

            // Добавляем продукт в список
            productList.Add(newProduct);

            // Очищаем текстовые поля после добавления
            textBox_ID_DIE.Clear();
            textBox_Category_DIE.Clear();
            textBox_NameOfProduct.Clear();
            textBox_QualitiyProduct_DIE.Clear();
            textBox_Price_DIE.Clear();
        }

        public class Product
        {
            public int ID { get; set; }
            public string Category { get; set; }
            public string Name { get; set; }
            public string Quality { get; set; }
            public int Price { get; set; }

            public Product(int id,  string category, string name, string quality, int price)
            {
                ID = id;
                Category = category;
                Name = name;
                Quality = quality;
                Price = price;
            }
        }
    }
}
