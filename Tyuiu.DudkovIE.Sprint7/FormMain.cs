using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tyuiu.DudkovIE.Sprint7
{
    public partial class FormMain : Form
    {
        bool SideBarExpand;
        public FormMain()
        {
            InitializeComponent();
        }

        private void TimerSideBar_DIE_Tick(object sender, EventArgs e)
        {
            if (SideBarExpand)
            {
                PanelSideBar_DIE.Width -= 10;
                if (PanelSideBar_DIE.Width == PanelSideBar_DIE.MinimumSize.Width)
                {
                    SideBarExpand = false;
                    TimerSideBar_DIE.Stop();
                }
            }

            else
            {
                PanelSideBar_DIE.Width += 10;
                if (PanelSideBar_DIE.Width == PanelSideBar_DIE.MaximumSize.Width)
                {
                    SideBarExpand = true;
                    TimerSideBar_DIE.Stop();
                }
            }
            
        }

        private void Button_Menu_DIE_Click(object sender, EventArgs e)
        {
            TimerSideBar_DIE.Start();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void PanelSideBar_DIE_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
