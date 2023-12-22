using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Tyuiu.DudkovIE.Sprint7.Forms
{
    public partial class FormUser : Form
    {

        public BindingList<Product> productList;
        private BindingSource bindingSource;
        private SortOrder currentSortOrder = SortOrder.Ascending;

        public FormUser()
        {
            InitializeComponent();

            // Инициализируем список и источник данных
            productList = new BindingList<Product>();
            bindingSource = new BindingSource(productList, null);

            // Привязываем источник данных к DataGridView
            dataGridView_ProductsInfo_DIE.DataSource = bindingSource;

            dataGridView_ProductsInfo_DIE.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void button_AddProduct_DIE_Click(object sender, EventArgs e)
        {
            try
            {
                int ID = Convert.ToInt32(textBox_ID_DIE.Text);
                string name = textBox_Name_DIE.Text;
                string surname = textBox_Surname_DIE.Text;
                string otchestvo = textBox_otchestvo_DIE.Text;
                string position = textBox_Position_DIE.Text;

                // Создаем объект продукта
                Product newProduct = new Product(ID, name, surname, otchestvo, position);

                // Добавляем продукт в список
                productList.Add(newProduct);

                // Очищаем текстовые поля после добавления
                textBox_ID_DIE.Clear();
                textBox_Name_DIE.Clear();
                textBox_Surname_DIE.Clear();
                textBox_otchestvo_DIE.Clear();
                textBox_Position_DIE.Clear();
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button_OpenFile_DIE_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Filter = "CSV files (*.csv)|*.csv|All files (*.*)|*.*";
                openFileDialog.Title = "Выберите CSV файл для открытия";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = openFileDialog.FileName;

                    // Читаем все строки из файла
                    string[] lines = File.ReadAllLines(filePath);

                    // Парсим заголовки столбцов
                    string[] headers = lines[0].Split(',');

                    // Очищаем старые данные в BindingList
                    productList.Clear();

                    // Заполняем BindingList данными из файла
                    for (int i = 1; i < lines.Length; i++)
                    {
                        string[] values = lines[i].Split(',');
                        productList.Add(new Product {
                            ID = Convert.ToInt32(values[0]),
                            Name = values[1],
                            Surname = values[2],
                            Otchestvo = values[3],
                            Position = values[4]
                        });
                    }

                    MessageBox.Show("Файл успешно открыт!", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при открытии файла: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public class Product
        {
            public int ID { get; set; }
            public string Name { get; set; }
            public string Surname { get; set; }
            public string Otchestvo { get; set; }
            public string Position { get; set; }

            // Конструктор по умолчанию
            public Product()
            {

            }

            public Product(int id, string name, string surname, string otchestvo, string position)
            {
                ID = id;
                Name = name;
                Surname = surname;
                Otchestvo = otchestvo;
                Position = position;
            }
        }

        private void button_SaveFile_DIE_Click(object sender, EventArgs e)
        {
            try
            {
                string directoryPath = $@"{Directory.GetCurrentDirectory()}";
                string fileName = "UserTable.csv";
                string path = Path.Combine(directoryPath, fileName);


                // Создаем строку для записи заголовков столбцов
                string header = string.Join(",", dataGridView_ProductsInfo_DIE.Columns.Cast<DataGridViewColumn>().Select(column => column.HeaderText));

                // Создаем строки для каждой записи данных
                List<string> lines = new List<string>();
                foreach (DataGridViewRow row in dataGridView_ProductsInfo_DIE.Rows)
                {
                    if (!row.IsNewRow)
                    {
                        string line = string.Join(",", row.Cells.Cast<DataGridViewCell>().Select(cell => cell.Value.ToString()));
                        lines.Add(line);
                    }
                }

                // Соединяем заголовок и строки вместе
                string content = header + Environment.NewLine + string.Join(Environment.NewLine, lines);

                // Записываем содержимое в файл
                File.WriteAllText(path, content);

                DialogResult dialogResult = MessageBox.Show("Файл " + path + " сохранен успешно!\nОткрыть его в блокноте?", "Сообщение", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dialogResult == DialogResult.Yes)
                {
                    System.Diagnostics.Process txt = new System.Diagnostics.Process();
                    txt.StartInfo.FileName = "notepad.exe";
                    txt.StartInfo.Arguments = path;
                    txt.Start();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при сохранении файла: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button_DeleteProduct_Click(object sender, EventArgs e)
        {
            if (dataGridView_ProductsInfo_DIE.SelectedRows.Count > 0)
            {
                // Получить выбранную строку
                DataGridViewRow selectedRow = dataGridView_ProductsInfo_DIE.SelectedRows[0];

                // Получить объект продукта из выбранной строки
                Product selectedProduct = (Product)selectedRow.DataBoundItem;

                // Удалить продукт из списка
                productList.Remove(selectedProduct);
            }
            else
            {
                MessageBox.Show("Выберите строку для удаления", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
