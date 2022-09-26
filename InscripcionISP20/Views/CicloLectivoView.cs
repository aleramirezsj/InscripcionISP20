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
using System.Windows.Input;

namespace Desktop.Views
{
    public partial class CicloLectivoView : Form
    {
        IUnitOfWork unitOfWork;
        BindingSource listaCicloLectivo = new BindingSource();
        bool Editando;
        public CicloLectivoView(IUnitOfWork unitOfWork)
        {
            InitializeComponent();
            this.unitOfWork = unitOfWork;
            GetCicloLectivo();
            gridCicloLectivo.DataSource = listaCicloLectivo;
        }

        private async void GetCicloLectivo()
        {
            listaCicloLectivo.DataSource = await unitOfWork.CiclolectivoRepository.GetAllAsync(orderBy: c => c.OrderBy(c => c.Nombre));

        }

        private void btnAgregarCiclo_Click(object sender, EventArgs e)
        {
            Ciclolectivo ciclolectivo = new Ciclolectivo() 
            {
                Id = (int)nudId.Value,
                Nombre = txtNombreCiclo.Text
            };
            if (Editando)
                unitOfWork.CiclolectivoRepository.Update(ciclolectivo);
            else
                unitOfWork.CiclolectivoRepository.Add(ciclolectivo);


            unitOfWork.Save();
            GetCicloLectivo();
            LimpiarControles();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            var ciclo = (Ciclolectivo)listaCicloLectivo.Current;
            var result = MessageBox.Show($"¿Está seguro que desea borrar el Ciclo Lectivo {ciclo.Nombre}?", "Eliminar ciclo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                unitOfWork.CiclolectivoRepository.Delete(ciclo.Id);
                unitOfWork.Save();
                GetCicloLectivo();
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            var ciclo = (Ciclolectivo)listaCicloLectivo.Current;
            nudId.Value = ciclo.Id;
            txtNombreCiclo.Text = ciclo.Nombre;
            Editando = true;
        }

        private void LimpiarControles()
        {
            txtNombreCiclo.Text = "";
        }

        private void gridCicloLectivo_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewColumn columna in gridCicloLectivo.Columns)
            {
                if (columna.Name == "Materiasciclolectivos")
                    columna.Visible = false;
                if (columna.Name == "Id")
                    columna.Visible = false;
                if (columna.Name == "Nombre")
                    columna.HeaderText = "Ciclo Lectivo - Año";
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
