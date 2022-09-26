using Data.Interfaces;
using Data.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desktop.Views
{
    public partial class AnioCarreraView : Form
    {
        IUnitOfWork unitOfWork;
        BindingSource listaCarreras = new BindingSource();
        BindingSource listaAniosCarrera = new BindingSource();
        bool Editando;
        private int idAnio = 0;

        public AnioCarreraView(IUnitOfWork unitOfWork)
        {
            InitializeComponent();
            MostrarOcultarTxt();
            this.unitOfWork = unitOfWork;
            GetAllCarreras();
            CargarComboCarreras();

            GetAllAnios();
            gridAnios.DataSource = listaAniosCarrera;
        }

        private async void GetAllAnios()
        {
            listaAniosCarrera.DataSource = await unitOfWork.AniocarreraRepository.GetAllAsync(filter: a => a.CarreraId1 == (int)comboBoxCarreras.SelectedValue);
        }

        private void CargarComboCarreras()
        {
            comboBoxCarreras.DataSource = listaCarreras;
            comboBoxCarreras.DisplayMember = "Nombre";
            comboBoxCarreras.ValueMember = "Id";
        }

        private async void GetAllCarreras()
        {
            listaCarreras.DataSource = await unitOfWork.CarreraRepository.GetAllAsync(orderBy: c => c.OrderBy(c => c.Nombre));
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Editando = false;
            MostrarOcultarTxt();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Editando=true;
            RecuperarCarreraAEditar();
            MostrarOcultarTxt();

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            var anioCarrera = (Aniocarrera)listaAniosCarrera.Current;
            var result = MessageBox.Show($"¿Está seguro que desea borrar a la carrera {anioCarrera.Nombre}?", "Eliminar carrera", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                unitOfWork.AniocarreraRepository.Delete(anioCarrera.Id);
                unitOfWork.Save();
                GetAllAnios();
            }
        }

        private void MostrarOcultarTxt()
        {
            if (txtAnio.Enabled) { 
                txtAnio.Enabled = false;
                txtAnio.Text = ""; 
            }
            else
            {
                txtAnio.Enabled = true;

            }
            if (btnGuardar.Enabled)
            {
                btnGuardar.Enabled = false;
            }
            else
            {
                btnGuardar.Enabled = true;
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

            Aniocarrera anioCarrera = new Aniocarrera()
            {
                Nombre = txtAnio.Text,
                CarreraId1 = (int)comboBoxCarreras.SelectedValue
            };

            if (Editando)
            {
                anioCarrera.Id = idAnio;
                unitOfWork.AniocarreraRepository.Update(anioCarrera);
            }
            else
            {
                unitOfWork.AniocarreraRepository.Add(anioCarrera);
            }

            unitOfWork.Save();
            GetAllAnios();
            MostrarOcultarTxt();
        }

        private void RecuperarCarreraAEditar()
        {
            var aniocarrera = (Aniocarrera)listaAniosCarrera.Current;
            idAnio = aniocarrera.Id;
            txtAnio.Text = aniocarrera.Nombre;
        }

        private void gridAnios_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewColumn columna in gridAnios.Columns)
            {
                if (columna.Name == "Aniocarreras")
                    columna.Visible = false;
                if (columna.Name == "Materias")
                    columna.Visible = false;
                if (columna.Name == "CarreraId")
                    columna.Visible = false;
                if (columna.Name == "CarreraId1")
                    columna.Visible = false;
                if (columna.Name == "CarreraId1Navigation")
                    columna.Visible = false;

            }
        }

        private void comboBoxCarreras_SelectedIndexChanged(object sender, EventArgs e)
        {
            //GetAllAnios();
        }

        private void comboBoxCarreras_SelectionChangeCommitted(object sender, EventArgs e)
        {
            GetAllAnios();
        }
    }
}
