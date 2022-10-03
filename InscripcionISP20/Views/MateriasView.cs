using Data.Interfaces;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Data.Models;

namespace Desktop.Views
{
    public partial class MateriasView : Form
    {
        IUnitOfWork unitOfWork;
        BindingSource listaMaterias = new BindingSource();
        bool Editando;

        public MateriasView(IUnitOfWork unitOfWork)
        {
            InitializeComponent();
            this.unitOfWork = unitOfWork;
            GetAll();
            GridMaterias.DataSource = listaMaterias;
            CargarComboBox();
        }

        private async void CargarComboBox()
        {
            CboAño.DataSource = await unitOfWork.AniocarreraRepository.GetAllAsync();
            CboAño.DisplayMember = "Nombre";
            CboAño.ValueMember = "Id";
        }

        private async void GetAll()
        {
            listaMaterias.DataSource = await unitOfWork.MateriaRepository.GetAllAsync(orderBy: c => c.OrderBy(c => c.Nombre));

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            IrAPestañaDetalle();
            LimpiarControles();
            Editando = false;
        }

        private void LimpiarControles()
        {
            TxtNombre.Text = "";
            nudId.Value = 0;
        }

        private void IrAPestañaDetalle()
        {
            ListaMaterias.Enabled = false;

            //cambiar de pestaña
            FormularioMaterias.Enabled = true;
            tabControl1.SelectedIndex = 1;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Materia materia = new Materia()
            {
                Id = (int)nudId.Value,
                Nombre = TxtNombre.Text,
                
                AnioCarreraId1 = (int)CboAño.SelectedValue,

            };
            if (Editando)
                unitOfWork.MateriaRepository.Update(materia);
            else
                unitOfWork.MateriaRepository.Add(materia);


            unitOfWork.Save();
            GetAll();
            LimpiarControles();
            IrAPestañaLista();
        }

        private void IrAPestañaLista()
        {
            ListaMaterias.Enabled = true;

            //cambiar de pestaña
            FormularioMaterias.Enabled = false;
            tabControl1.SelectedIndex = 0;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            IrAPestañaLista();
            LimpiarControles();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            RecuperarMateriaAEditar();
            IrAPestañaDetalle();
            Editando = true;
        }

        private void RecuperarMateriaAEditar()
        {
            var materia = (Materia)listaMaterias.Current;
            nudId.Value = materia.Id;
            TxtNombre.Text = materia.Nombre;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            var materia = (Materia)listaMaterias.Current;
            var result = MessageBox.Show($"¿Está seguro que desea borrar a la materia {materia.Nombre}?", "Eliminar carrera", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                unitOfWork.MateriaRepository.Delete(materia.Id);
                unitOfWork.Save();
                GetAll();
            }
        }

        private void GridMaterias_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewColumn columna in GridMaterias.Columns)
            {
                if (columna.Name == "AnioCarreraId1")
                    columna.Visible = false;
                if (columna.Name == "AnioCarreraId")
                    columna.Visible = false;
                if (columna.Name == "AnioCarreraId1Navigation")
                    columna.Visible = false;
                if (columna.Name == "Id")
                    columna.Width = 60;
                if (columna.Name == "Materiasciclolectivos")
                    columna.Visible=false;
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
