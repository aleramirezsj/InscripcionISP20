using Data.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Desktop.Views
{
    public partial class CarrerasView : Form
    {
        IUnitOfWork unitOfWork;
        public CarrerasView(IUnitOfWork unitOfWork)
        {
            InitializeComponent();
            this.unitOfWork = unitOfWork;
            GetAll();
            
        }

        private void GetAll()
        {
            gridCarreras.DataSource=unitOfWork.CarreraRepository.GetAll();
        }
        private void GetAll(string txtBusqueda)
        {
            gridCarreras.DataSource = unitOfWork.CarreraRepository.GetAll(filter:c=>c.Nombre.Contains(txtBusqueda),orderBy:c=>c.OrderBy(c=>c.Nombre));
        }

        private void txtBusqueda_TextChanged(object sender, EventArgs e)
        {
            GetAll(txtBusqueda.Text);
        }

        private void gridCarreras_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach(DataGridViewColumn columna in gridCarreras.Columns)
            {
                if (columna.Name == "Aniocarreras")
                    columna.Visible = false;
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            //cambiar de pestaña
            tabControl1.SelectedIndex = 1;
            //llamamos a un método que limpie los controles
            //colocar el cursar en el txtnombre
        }
    }
}
