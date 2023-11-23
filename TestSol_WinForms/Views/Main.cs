using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestSol_WinForms.ViewModels;

namespace TestSol_WinForms
{
    public partial class FrmMain : Form
    {
        VMMain vMMain = new VMMain();

        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Shown(object sender, EventArgs e)
        {
            Thread.Sleep(3000);
            vMMain.InitMain(this);
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            vMMain.AgregarEmpleado(this);
            vMMain.InitMain(this);
        }

        private void BtnUp_Click(object sender, EventArgs e)
        {
            vMMain.ActualizarEmpleado(this);
            vMMain.InitMain(this);
        }

        private void BtnDel_Click(object sender, EventArgs e)
        {
            vMMain.BorrarEmpleado(this);
            vMMain.InitMain(this);
        }
    }
}
