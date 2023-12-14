
namespace Tyuiu.DudkovIE.Sprint7.Forms
{
    partial class FormProducts
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_ID_DIE = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_NameOfProduct = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_QualitiyProduct_DIE = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_Price_DIE = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox_Category_DIE = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(77, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox_ID_DIE
            // 
            this.textBox_ID_DIE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(87)))), ((int)(((byte)(100)))));
            this.textBox_ID_DIE.Location = new System.Drawing.Point(39, 37);
            this.textBox_ID_DIE.Name = "textBox_ID_DIE";
            this.textBox_ID_DIE.Size = new System.Drawing.Size(100, 20);
            this.textBox_ID_DIE.TabIndex = 1;
            this.textBox_ID_DIE.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(16, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Название продукта";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // textBox_NameOfProduct
            // 
            this.textBox_NameOfProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(87)))), ((int)(((byte)(100)))));
            this.textBox_NameOfProduct.Location = new System.Drawing.Point(39, 95);
            this.textBox_NameOfProduct.Name = "textBox_NameOfProduct";
            this.textBox_NameOfProduct.Size = new System.Drawing.Size(100, 20);
            this.textBox_NameOfProduct.TabIndex = 3;
            this.textBox_NameOfProduct.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(16, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Качество товара";
            // 
            // textBox_QualitiyProduct_DIE
            // 
            this.textBox_QualitiyProduct_DIE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(87)))), ((int)(((byte)(100)))));
            this.textBox_QualitiyProduct_DIE.Location = new System.Drawing.Point(39, 153);
            this.textBox_QualitiyProduct_DIE.Name = "textBox_QualitiyProduct_DIE";
            this.textBox_QualitiyProduct_DIE.Size = new System.Drawing.Size(100, 20);
            this.textBox_QualitiyProduct_DIE.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(67, 186);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Цена";
            // 
            // textBox_Price_DIE
            // 
            this.textBox_Price_DIE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(87)))), ((int)(((byte)(100)))));
            this.textBox_Price_DIE.Location = new System.Drawing.Point(39, 209);
            this.textBox_Price_DIE.Name = "textBox_Price_DIE";
            this.textBox_Price_DIE.Size = new System.Drawing.Size(100, 20);
            this.textBox_Price_DIE.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(50, 245);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Категория";
            // 
            // comboBox_Category_DIE
            // 
            this.comboBox_Category_DIE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(87)))), ((int)(((byte)(100)))));
            this.comboBox_Category_DIE.ForeColor = System.Drawing.Color.White;
            this.comboBox_Category_DIE.FormattingEnabled = true;
            this.comboBox_Category_DIE.Location = new System.Drawing.Point(34, 268);
            this.comboBox_Category_DIE.Name = "comboBox_Category_DIE";
            this.comboBox_Category_DIE.Size = new System.Drawing.Size(121, 21);
            this.comboBox_Category_DIE.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(12, 312);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(78, 48);
            this.button1.TabIndex = 11;
            this.button1.Text = "ДОБАВИТЬ";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(96, 312);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(78, 48);
            this.button2.TabIndex = 12;
            this.button2.Text = "РЕДАКТИРОВАТЬ";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(180, 312);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(78, 48);
            this.button3.TabIndex = 13;
            this.button3.Text = "УДАЛИТЬ";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(294, 55);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(494, 383);
            this.dataGridView1.TabIndex = 14;
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(87)))), ((int)(((byte)(100)))));
            this.comboBox1.ForeColor = System.Drawing.Color.White;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(294, 28);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(310, 5);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 20);
            this.label6.TabIndex = 15;
            this.label6.Text = "Категория";
            // 
            // button4
            // 
            this.button4.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(421, 28);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(94, 21);
            this.button4.TabIndex = 17;
            this.button4.Text = "ПЕРЕМЕШАТЬ";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // FormProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(87)))), ((int)(((byte)(100)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox_Category_DIE);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox_Price_DIE);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox_QualitiyProduct_DIE);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_NameOfProduct);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_ID_DIE);
            this.Controls.Add(this.label1);
            this.Name = "FormProducts";
            this.Text = "FormProducts";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_ID_DIE;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_NameOfProduct;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_QualitiyProduct_DIE;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_Price_DIE;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox_Category_DIE;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button4;
    }
}