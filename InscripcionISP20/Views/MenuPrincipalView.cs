using Data.Interfaces;
using Data.Repositories;
using Desktop.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desktop
{
    public partial class MenuPrincipalView : Form
    {
        public MenuPrincipalView()
        {
            InitializeComponent();
        }

        private void listaDeCarrerasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void iconMenuItem2_Click(object sender, EventArgs e)
        {
            IUnitOfWork unitOfWork = new UnitOfWork();
            var carrerasView = new CarrerasView(unitOfWork);
            carrerasView.ShowDialog();
        }

        private void iconMenuItem4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cicloLectivoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IUnitOfWork unitOfWork = new UnitOfWork();
            var cicloLectivoView = new CicloLectivoView(unitOfWork);
            cicloLectivoView.ShowDialog();

        }
        private void iconMenuItem5_Click(object sender, EventArgs e)
        {
            IUnitOfWork unitOfWork = new UnitOfWork();
            var materiasView = new MateriasView(unitOfWork);
            materiasView.ShowDialog();
        }
    }
}
