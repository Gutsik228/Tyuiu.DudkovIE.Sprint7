﻿
namespace Tyuiu.DudkovIE.Sprint7
{
    partial class FormMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.TimerSideBar_DIE = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.Button_Menu_DIE = new System.Windows.Forms.Button();
            this.PanelSideBar_DIE = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.PanelSideBar_DIE.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // TimerSideBar_DIE
            // 
            this.TimerSideBar_DIE.Interval = 10;
            this.TimerSideBar_DIE.Tick += new System.EventHandler(this.TimerSideBar_DIE_Tick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(3, 83);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 68);
            this.panel1.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(3, 17);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(10, 1, 1, 1);
            this.button1.Size = new System.Drawing.Size(188, 38);
            this.button1.TabIndex = 1;
            this.button1.Text = "Главный экран";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.Button_Menu_DIE);
            this.panel5.Controls.Add(this.label1);
            this.panel5.Location = new System.Drawing.Point(3, 3);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(200, 74);
            this.panel5.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label1.Location = new System.Drawing.Point(95, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Меню";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Button_Menu_DIE
            // 
            this.Button_Menu_DIE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Menu_DIE.ForeColor = System.Drawing.Color.Black;
            this.Button_Menu_DIE.Image = ((System.Drawing.Image)(resources.GetObject("Button_Menu_DIE.Image")));
            this.Button_Menu_DIE.Location = new System.Drawing.Point(9, 15);
            this.Button_Menu_DIE.Name = "Button_Menu_DIE";
            this.Button_Menu_DIE.Size = new System.Drawing.Size(63, 48);
            this.Button_Menu_DIE.TabIndex = 1;
            this.Button_Menu_DIE.UseVisualStyleBackColor = true;
            this.Button_Menu_DIE.Click += new System.EventHandler(this.Button_Menu_DIE_Click);
            // 
            // PanelSideBar_DIE
            // 
            this.PanelSideBar_DIE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(45)))), ((int)(((byte)(50)))));
            this.PanelSideBar_DIE.Controls.Add(this.panel5);
            this.PanelSideBar_DIE.Controls.Add(this.panel1);
            this.PanelSideBar_DIE.Controls.Add(this.panel2);
            this.PanelSideBar_DIE.Controls.Add(this.panel3);
            this.PanelSideBar_DIE.Controls.Add(this.panel4);
            this.PanelSideBar_DIE.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanelSideBar_DIE.ForeColor = System.Drawing.Color.White;
            this.PanelSideBar_DIE.Location = new System.Drawing.Point(0, 0);
            this.PanelSideBar_DIE.MaximumSize = new System.Drawing.Size(205, 631);
            this.PanelSideBar_DIE.MinimumSize = new System.Drawing.Size(70, 631);
            this.PanelSideBar_DIE.Name = "PanelSideBar_DIE";
            this.PanelSideBar_DIE.Size = new System.Drawing.Size(205, 631);
            this.PanelSideBar_DIE.TabIndex = 0;
            this.PanelSideBar_DIE.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelSideBar_DIE_Paint);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button2);
            this.panel2.ForeColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(3, 157);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 68);
            this.panel2.TabIndex = 3;
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(3, 17);
            this.button2.Name = "button2";
            this.button2.Padding = new System.Windows.Forms.Padding(10, 1, 1, 1);
            this.button2.Size = new System.Drawing.Size(188, 38);
            this.button2.TabIndex = 1;
            this.button2.Text = "Настройки";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.button3);
            this.panel3.ForeColor = System.Drawing.Color.White;
            this.panel3.Location = new System.Drawing.Point(3, 231);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 68);
            this.panel3.TabIndex = 4;
            // 
            // button3
            // 
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.button3.ForeColor = System.Drawing.Color.Black;
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(3, 17);
            this.button3.Name = "button3";
            this.button3.Padding = new System.Windows.Forms.Padding(10, 1, 1, 1);
            this.button3.Size = new System.Drawing.Size(188, 38);
            this.button3.TabIndex = 1;
            this.button3.Text = "О нас";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.button4);
            this.panel4.ForeColor = System.Drawing.Color.White;
            this.panel4.Location = new System.Drawing.Point(3, 305);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(200, 68);
            this.panel4.TabIndex = 3;
            // 
            // button4
            // 
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.button4.ForeColor = System.Drawing.Color.Black;
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(3, 17);
            this.button4.Name = "button4";
            this.button4.Padding = new System.Windows.Forms.Padding(10, 1, 1, 1);
            this.button4.Size = new System.Drawing.Size(188, 38);
            this.button4.TabIndex = 1;
            this.button4.Text = "Помощь";
            this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button4.UseVisualStyleBackColor = true;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1265, 631);
            this.Controls.Add(this.PanelSideBar_DIE);
            this.Name = "FormMain";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.PanelSideBar_DIE.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer TimerSideBar_DIE;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button Button_Menu_DIE;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel PanelSideBar_DIE;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button button4;
    }
}

