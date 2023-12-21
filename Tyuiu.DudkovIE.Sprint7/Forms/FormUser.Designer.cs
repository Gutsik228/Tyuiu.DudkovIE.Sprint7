
namespace Tyuiu.DudkovIE.Sprint7.Forms
{
    partial class FormUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormUser));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label_Name_DIE = new System.Windows.Forms.Label();
            this.label_Surname_DIE = new System.Windows.Forms.Label();
            this.label_Otchestvo = new System.Windows.Forms.Label();
            this.label_Position_DIE = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label_ID_DIE = new System.Windows.Forms.Label();
            this.textBox_ID_DIE = new System.Windows.Forms.TextBox();
            this.textBox_Name_DIE = new System.Windows.Forms.TextBox();
            this.textBox_Surname_DIE = new System.Windows.Forms.TextBox();
            this.textBox_otchestvo_DIE = new System.Windows.Forms.TextBox();
            this.button_AddProduct_DIE = new System.Windows.Forms.Button();
            this.button_DeleteProduct = new System.Windows.Forms.Button();
            this.dataGridView_ProductsInfo_DIE = new System.Windows.Forms.DataGridView();
            this.button_OpenFile_DIE = new System.Windows.Forms.Button();
            this.button_SaveFile_DIE = new System.Windows.Forms.Button();
            this.textBox_Position_DIE = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ProductsInfo_DIE)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Controls.Add(this.label_Name_DIE);
            this.panel1.Controls.Add(this.label_Surname_DIE);
            this.panel1.Controls.Add(this.label_Otchestvo);
            this.panel1.Controls.Add(this.label_Position_DIE);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(333, 364);
            this.panel1.TabIndex = 0;
            // 
            // label_Name_DIE
            // 
            this.label_Name_DIE.AutoSize = true;
            this.label_Name_DIE.BackColor = System.Drawing.Color.Black;
            this.label_Name_DIE.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Name_DIE.ForeColor = System.Drawing.Color.White;
            this.label_Name_DIE.Location = new System.Drawing.Point(23, 70);
            this.label_Name_DIE.Name = "label_Name_DIE";
            this.label_Name_DIE.Size = new System.Drawing.Size(40, 20);
            this.label_Name_DIE.TabIndex = 64;
            this.label_Name_DIE.Text = "Имя";
            // 
            // label_Surname_DIE
            // 
            this.label_Surname_DIE.AutoSize = true;
            this.label_Surname_DIE.BackColor = System.Drawing.Color.Black;
            this.label_Surname_DIE.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Surname_DIE.ForeColor = System.Drawing.Color.White;
            this.label_Surname_DIE.Location = new System.Drawing.Point(3, 128);
            this.label_Surname_DIE.Name = "label_Surname_DIE";
            this.label_Surname_DIE.Size = new System.Drawing.Size(81, 20);
            this.label_Surname_DIE.TabIndex = 66;
            this.label_Surname_DIE.Text = "Фамилия";
            // 
            // label_Otchestvo
            // 
            this.label_Otchestvo.AutoSize = true;
            this.label_Otchestvo.BackColor = System.Drawing.Color.Black;
            this.label_Otchestvo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Otchestvo.ForeColor = System.Drawing.Color.White;
            this.label_Otchestvo.Location = new System.Drawing.Point(6, 184);
            this.label_Otchestvo.Name = "label_Otchestvo";
            this.label_Otchestvo.Size = new System.Drawing.Size(83, 20);
            this.label_Otchestvo.TabIndex = 68;
            this.label_Otchestvo.Text = "Отчество";
            // 
            // label_Position_DIE
            // 
            this.label_Position_DIE.AutoSize = true;
            this.label_Position_DIE.BackColor = System.Drawing.Color.Black;
            this.label_Position_DIE.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Position_DIE.ForeColor = System.Drawing.Color.White;
            this.label_Position_DIE.Location = new System.Drawing.Point(-4, 243);
            this.label_Position_DIE.Name = "label_Position_DIE";
            this.label_Position_DIE.Size = new System.Drawing.Size(95, 20);
            this.label_Position_DIE.TabIndex = 70;
            this.label_Position_DIE.Text = "Должность";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-16, 26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(346, 367);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label_ID_DIE
            // 
            this.label_ID_DIE.AutoSize = true;
            this.label_ID_DIE.BackColor = System.Drawing.Color.Black;
            this.label_ID_DIE.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_ID_DIE.ForeColor = System.Drawing.Color.White;
            this.label_ID_DIE.Location = new System.Drawing.Point(45, 24);
            this.label_ID_DIE.Name = "label_ID_DIE";
            this.label_ID_DIE.Size = new System.Drawing.Size(26, 20);
            this.label_ID_DIE.TabIndex = 62;
            this.label_ID_DIE.Text = "ID";
            // 
            // textBox_ID_DIE
            // 
            this.textBox_ID_DIE.BackColor = System.Drawing.Color.Black;
            this.textBox_ID_DIE.ForeColor = System.Drawing.Color.White;
            this.textBox_ID_DIE.Location = new System.Drawing.Point(7, 47);
            this.textBox_ID_DIE.Name = "textBox_ID_DIE";
            this.textBox_ID_DIE.Size = new System.Drawing.Size(100, 20);
            this.textBox_ID_DIE.TabIndex = 63;
            // 
            // textBox_Name_DIE
            // 
            this.textBox_Name_DIE.BackColor = System.Drawing.Color.Black;
            this.textBox_Name_DIE.ForeColor = System.Drawing.Color.White;
            this.textBox_Name_DIE.Location = new System.Drawing.Point(7, 105);
            this.textBox_Name_DIE.Name = "textBox_Name_DIE";
            this.textBox_Name_DIE.Size = new System.Drawing.Size(100, 20);
            this.textBox_Name_DIE.TabIndex = 65;
            // 
            // textBox_Surname_DIE
            // 
            this.textBox_Surname_DIE.BackColor = System.Drawing.Color.Black;
            this.textBox_Surname_DIE.ForeColor = System.Drawing.Color.White;
            this.textBox_Surname_DIE.Location = new System.Drawing.Point(7, 163);
            this.textBox_Surname_DIE.Name = "textBox_Surname_DIE";
            this.textBox_Surname_DIE.Size = new System.Drawing.Size(100, 20);
            this.textBox_Surname_DIE.TabIndex = 67;
            // 
            // textBox_otchestvo_DIE
            // 
            this.textBox_otchestvo_DIE.BackColor = System.Drawing.Color.Black;
            this.textBox_otchestvo_DIE.ForeColor = System.Drawing.Color.White;
            this.textBox_otchestvo_DIE.Location = new System.Drawing.Point(7, 219);
            this.textBox_otchestvo_DIE.Name = "textBox_otchestvo_DIE";
            this.textBox_otchestvo_DIE.Size = new System.Drawing.Size(100, 20);
            this.textBox_otchestvo_DIE.TabIndex = 69;
            // 
            // button_AddProduct_DIE
            // 
            this.button_AddProduct_DIE.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_AddProduct_DIE.BackgroundImage")));
            this.button_AddProduct_DIE.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button_AddProduct_DIE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_AddProduct_DIE.ForeColor = System.Drawing.Color.White;
            this.button_AddProduct_DIE.Location = new System.Drawing.Point(351, 15);
            this.button_AddProduct_DIE.Name = "button_AddProduct_DIE";
            this.button_AddProduct_DIE.Size = new System.Drawing.Size(103, 48);
            this.button_AddProduct_DIE.TabIndex = 71;
            this.button_AddProduct_DIE.Text = "ДОБАВИТЬ";
            this.button_AddProduct_DIE.UseVisualStyleBackColor = true;
            this.button_AddProduct_DIE.Click += new System.EventHandler(this.button_AddProduct_DIE_Click);
            // 
            // button_DeleteProduct
            // 
            this.button_DeleteProduct.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_DeleteProduct.BackgroundImage")));
            this.button_DeleteProduct.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button_DeleteProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_DeleteProduct.ForeColor = System.Drawing.Color.White;
            this.button_DeleteProduct.Location = new System.Drawing.Point(460, 15);
            this.button_DeleteProduct.Name = "button_DeleteProduct";
            this.button_DeleteProduct.Size = new System.Drawing.Size(108, 48);
            this.button_DeleteProduct.TabIndex = 73;
            this.button_DeleteProduct.Text = "УДАЛИТЬ";
            this.button_DeleteProduct.UseVisualStyleBackColor = true;
            this.button_DeleteProduct.Click += new System.EventHandler(this.button_DeleteProduct_Click);
            // 
            // dataGridView_ProductsInfo_DIE
            // 
            this.dataGridView_ProductsInfo_DIE.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_ProductsInfo_DIE.Location = new System.Drawing.Point(324, 82);
            this.dataGridView_ProductsInfo_DIE.Name = "dataGridView_ProductsInfo_DIE";
            this.dataGridView_ProductsInfo_DIE.ReadOnly = true;
            this.dataGridView_ProductsInfo_DIE.Size = new System.Drawing.Size(539, 362);
            this.dataGridView_ProductsInfo_DIE.TabIndex = 74;
            // 
            // button_OpenFile_DIE
            // 
            this.button_OpenFile_DIE.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_OpenFile_DIE.BackgroundImage")));
            this.button_OpenFile_DIE.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button_OpenFile_DIE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_OpenFile_DIE.ForeColor = System.Drawing.Color.White;
            this.button_OpenFile_DIE.Location = new System.Drawing.Point(574, 15);
            this.button_OpenFile_DIE.Name = "button_OpenFile_DIE";
            this.button_OpenFile_DIE.Size = new System.Drawing.Size(103, 48);
            this.button_OpenFile_DIE.TabIndex = 75;
            this.button_OpenFile_DIE.Text = "ОТКРЫТЬ ФАЙЛ";
            this.button_OpenFile_DIE.UseVisualStyleBackColor = true;
            this.button_OpenFile_DIE.Click += new System.EventHandler(this.button_OpenFile_DIE_Click);
            // 
            // button_SaveFile_DIE
            // 
            this.button_SaveFile_DIE.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_SaveFile_DIE.BackgroundImage")));
            this.button_SaveFile_DIE.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button_SaveFile_DIE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_SaveFile_DIE.ForeColor = System.Drawing.Color.White;
            this.button_SaveFile_DIE.Location = new System.Drawing.Point(683, 15);
            this.button_SaveFile_DIE.Name = "button_SaveFile_DIE";
            this.button_SaveFile_DIE.Size = new System.Drawing.Size(108, 48);
            this.button_SaveFile_DIE.TabIndex = 76;
            this.button_SaveFile_DIE.Text = "СОХРАНИТЬ ФАЙЛ";
            this.button_SaveFile_DIE.UseVisualStyleBackColor = true;
            this.button_SaveFile_DIE.Click += new System.EventHandler(this.button_SaveFile_DIE_Click);
            // 
            // textBox_Position_DIE
            // 
            this.textBox_Position_DIE.BackColor = System.Drawing.Color.Black;
            this.textBox_Position_DIE.ForeColor = System.Drawing.Color.White;
            this.textBox_Position_DIE.Location = new System.Drawing.Point(7, 278);
            this.textBox_Position_DIE.Name = "textBox_Position_DIE";
            this.textBox_Position_DIE.Size = new System.Drawing.Size(100, 20);
            this.textBox_Position_DIE.TabIndex = 77;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(258, 15);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 20);
            this.label7.TabIndex = 78;
            // 
            // FormUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(866, 450);
            this.Controls.Add(this.button_DeleteProduct);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button_AddProduct_DIE);
            this.Controls.Add(this.textBox_Position_DIE);
            this.Controls.Add(this.button_SaveFile_DIE);
            this.Controls.Add(this.button_OpenFile_DIE);
            this.Controls.Add(this.dataGridView_ProductsInfo_DIE);
            this.Controls.Add(this.textBox_otchestvo_DIE);
            this.Controls.Add(this.textBox_Surname_DIE);
            this.Controls.Add(this.textBox_Name_DIE);
            this.Controls.Add(this.textBox_ID_DIE);
            this.Controls.Add(this.label_ID_DIE);
            this.Controls.Add(this.panel1);
            this.Name = "FormUser";
            this.Text = "FormUser";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ProductsInfo_DIE)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label_ID_DIE;
        private System.Windows.Forms.TextBox textBox_ID_DIE;
        private System.Windows.Forms.Label label_Name_DIE;
        private System.Windows.Forms.TextBox textBox_Name_DIE;
        private System.Windows.Forms.Label label_Surname_DIE;
        private System.Windows.Forms.TextBox textBox_Surname_DIE;
        private System.Windows.Forms.Label label_Otchestvo;
        private System.Windows.Forms.TextBox textBox_otchestvo_DIE;
        private System.Windows.Forms.Label label_Position_DIE;
        private System.Windows.Forms.Button button_AddProduct_DIE;
        private System.Windows.Forms.Button button_DeleteProduct;
        private System.Windows.Forms.DataGridView dataGridView_ProductsInfo_DIE;
        private System.Windows.Forms.Button button_OpenFile_DIE;
        private System.Windows.Forms.Button button_SaveFile_DIE;
        private System.Windows.Forms.TextBox textBox_Position_DIE;
        private System.Windows.Forms.Label label7;
    }
}