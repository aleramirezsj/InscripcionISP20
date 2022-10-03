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
    public partial class AlumnoView : Form
    {
        IUnitOfWork unitOfWork;
        BindingSource listaAlumnos = new BindingSource();
        bool editando;
        public AlumnoView(IUnitOfWork unitOfWork)
        {
            InitializeComponent();
            this.unitOfWork = unitOfWork;
            GetAll();
            gridAlumnos.DataSource = listaAlumnos;  
        }

        private async void GetAll()
        {
            listaAlumnos.DataSource = await unitOfWork.AlumnoRepository.GetAllAsync(orderBy: c => c.OrderBy(c => c.ApellidoNombre));
        }
        private async void GetAll(string txtBusqueda)
        {
            listaAlumnos.DataSource = await unitOfWork.AlumnoRepository.GetAllAsync(orderBy: c => c.OrderBy(c => c.ApellidoNombre));
        }

        private void gridAlumnos_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewColumn columna in gridAlumnos.Columns)
            {
                if (columna.Name == "ApellidoNombre")
                    columna.HeaderText = "Nombre Completo";
                if (columna.Name == "Id")
                    columna.Width = 40;
                if (columna.Name == "Dni")
                    columna.HeaderText = "DNI";
                if (columna.Name == "Telefono")
                    columna.HeaderText = "Teléfono";
                if (columna.Name == "Inscripcions")
                    columna.Visible = false;
            }

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            IrAPestañaDetalle();
            LimpiarControles();
            editando = false;
        }

        private void LimpiarControles()
        {
            nudId.Value = 0;
            TxtNombre.Text = "";
            nudDNI.Value = 0;
            TxtEmail.Text = "";
            TxtTelefono.Text = "";
        }

        private void IrAPestañaDetalle()
        {
            ListaAlumnosTab.Enabled = false;

            //cambiar de pestaña
            DetalleFormAlumTab.Enabled = true;
            tabControl1.SelectedIndex = 1;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            var alumno = (Alumno)listaAlumnos.Current;
            var result = MessageBox.Show($"¿Está seguro que desea borrar el alumno {alumno.ApellidoNombre}?", "Eliminar alumno", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                unitOfWork.AlumnoRepository.Delete(alumno.Id);
                unitOfWork.Save();
                GetAll();
            }

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            GetAll(txtBusqueda.Text);
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            RecuperarAlumnoAEditar();
            IrAPestañaDetalle();
            editando = true;
        }

        private void RecuperarAlumnoAEditar()
        {
            var alumno = (Alumno)listaAlumnos.Current;
            nudId.Value = alumno.Id;
            TxtNombre.Text = alumno.ApellidoNombre;
            nudDNI.Value = alumno.Dni;
            TxtEmail.Text = alumno.Email;
            TxtTelefono.Text = alumno.Telefono;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Alumno alumno = new Alumno()
            {
                Id = (int)nudId.Value,
                ApellidoNombre = TxtNombre.Text,
                Email = TxtEmail.Text,
                Telefono = TxtTelefono.Text,
                Dni = (int)nudDNI.Value
            };
            if (editando)
                unitOfWork.AlumnoRepository.Update(alumno);
            else
                unitOfWork.AlumnoRepository.Add(alumno);


            unitOfWork.Save();
            GetAll();
            LimpiarControles();
            IrAPestañaLista();

        }

        private void IrAPestañaLista()
        {
            ListaAlumnosTab.Enabled = true;

            //cambiar de pestaña
            DetalleFormAlumTab.Enabled = false;
            tabControl1.SelectedIndex = 0;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            IrAPestañaLista();
            LimpiarControles();
        }
    }
}
