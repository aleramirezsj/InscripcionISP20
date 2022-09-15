using Data.Interfaces;
using Data.Models;
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
        BindingSource listaCarreras = new BindingSource();
        bool Editando;

        public CarrerasView(IUnitOfWork unitOfWork)
        {
            InitializeComponent();
            this.unitOfWork = unitOfWork;
            GetAll();
            gridCarreras.DataSource = listaCarreras;

        }

        private async  void GetAll()
        {
            listaCarreras.DataSource = await unitOfWork.CarreraRepository.GetAll();
        }
        private async void GetAll(string txtBusqueda)
        {
            listaCarreras.DataSource = await unitOfWork.CarreraRepository.GetAll(filter: c => c.Nombre.Contains(txtBusqueda), orderBy: c => c.OrderBy(c => c.Nombre));
        }

        private void txtBusqueda_TextChanged(object sender, EventArgs e)
        {
            GetAll(txtBusqueda.Text);
        }

        private void gridCarreras_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewColumn columna in gridCarreras.Columns)
            {
                if (columna.Name == "Aniocarreras")
                    columna.Visible = false;
                if (columna.Name == "Id")
                    columna.Width = 60;
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            RecuperarCarreraAEditar();
            IrAPestañaDetalle();
            Editando = true;
        }

        private void RecuperarCarreraAEditar()
        {
            var carrera = (Carrera)listaCarreras.Current;
            nudId.Value = carrera.Id;
            txtNombre.Text = carrera.Nombre;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            IrAPestañaDetalle();
            LimpiarControles();
        }

        private void IrAPestañaDetalle()
        {
            tabLista.Enabled = false;

            //cambiar de pestaña
            tabDetalle.Enabled = true;
            tabControl1.SelectedIndex = 1;
        }

        private void IrAPestañaLista()
        {
            tabLista.Enabled = true;

            //cambiar de pestaña
            tabDetalle.Enabled = false;
            tabControl1.SelectedIndex = 0;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            IrAPestañaLista();
            LimpiarControles();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Carrera carrera = new Carrera()
            {
                Id = (int)nudId.Value,
                Nombre = txtNombre.Text
            };
            if (Editando)
                unitOfWork.CarreraRepository.Update(carrera);
            else
                unitOfWork.CarreraRepository.Add(carrera);


            unitOfWork.Save();
            GetAll();
            LimpiarControles();
            IrAPestañaLista();
        }

        private void LimpiarControles()
        {
            nudId.Value = 0;
            txtNombre.Text = "";
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            var carrera = (Carrera)listaCarreras.Current;
            var result = MessageBox.Show($"¿Está seguro que desea borrar a la carrera {carrera.Nombre}?", "Eliminar carrera", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                unitOfWork.CarreraRepository.Delete(carrera.Id);
                unitOfWork.Save();
            }
        }
    }
}