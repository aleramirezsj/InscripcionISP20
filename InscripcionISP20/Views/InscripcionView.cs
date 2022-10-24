using Data.Interfaces;
using Data.Models;
using Desktop.ViewReports;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desktop.Views
{
    public partial class InscripcionView : Form
    {
        IUnitOfWork unitOfWork;
        BindingSource ListaAlumnos = new BindingSource();
        BindingSource ListaMaterias = new BindingSource();
        BindingSource ListaMateriasInscriptas = new BindingSource();

        Alumno alumnoSeleccionado;
        Materia materiaSeleccionada;

        IEnumerable<Materia> materias;

        public InscripcionView(IUnitOfWork unitOfWork)
        {
            InitializeComponent();
            this.unitOfWork = unitOfWork;
            CargaDeDatosDelFormulario();
            AsociarEventosDePantalla();
            gridAlumnos.DataSource = ListaAlumnos;
            GridBuscarMateria.DataSource = ListaMaterias;
            GridMateriasInscriptas.DataSource = ListaMateriasInscriptas;


        }

        private void AsociarEventosDePantalla()
        {
            GridMateriasInscriptas.DataBindingComplete += delegate
            {
                BtnQuitar.Enabled = GridMateriasInscriptas.Rows.Count > 0;
                BtnQuitarTodas.Enabled = GridMateriasInscriptas.Rows.Count > 0;
                PanelBotones.Enabled = GridMateriasInscriptas.Rows.Count > 0; 

            };
            
            GridBuscarMateria.DataBindingComplete +=delegate
            {
                BtnAgregar.Enabled = GridBuscarMateria.Rows.Count > 0;
                BtnAgregarTodas.Enabled = GridBuscarMateria.Rows.Count > 0;
            };

            gridAlumnos.DataBindingComplete += delegate
            {
                BtnSeleccionarAlumno.Enabled = gridAlumnos.Rows.Count > 0 && GridBuscarMateria.Rows.Count > 0;
            };

            GridBuscarMateria.DataBindingComplete += delegate
            {
                BtnSeleccionarAlumno.Enabled = gridAlumnos.Rows.Count > 0 && GridBuscarMateria.Rows.Count > 0;
            };

            gridAlumnos.DataBindingComplete += delegate {
                BtnBuscar.Enabled = gridAlumnos.Rows.Count > 0 && TxtBuscarAlumno.Text.Trim().Length > 0;
            };

            TxtBuscarAlumno.TextChanged += delegate
            {
                BtnBuscar.Enabled = gridAlumnos.Rows.Count > 0 && TxtBuscarAlumno.Text.Trim().Length > 0;

            };
        }

        private async Task CargaDeDatosDelFormulario()
        {
            await CargarCboCicloLectivo();
            await GetAlumnos();
            await CargarCboCarrera();
            await CargarCboAño();
            await CargarMaterias();
        }

        private async Task CargarCboCicloLectivo()
        {
   
             var listaCicloLectivo = await unitOfWork.CiclolectivoRepository.GetAllAsync();
            cboCicloLectivo.DataSource = listaCicloLectivo.ToList();
            cboCicloLectivo.DisplayMember = "Nombre";
            cboCicloLectivo.ValueMember = "Id";

            cboCicloLectivo.SelectedValue = listaCicloLectivo.Where(c => c.Nombre.Contains(DateTime.Now.Year.ToString())).FirstOrDefault().Id;
        }

        private async Task CargarMaterias()
        {
            if(CboAñoCarrera?.SelectedValue.GetType() == typeof(int) )
            {
                var idAnioCarrera = (int)CboAñoCarrera.SelectedValue;
                materias = await unitOfWork.MateriaRepository.GetAllAsync(filter: m => m.AnioCarreraId1 == idAnioCarrera);
                ListaMaterias.DataSource = materias;
                LblStatusText.Text = $"Se obtuvieron: {materias.Count()} Materias";
                EliminarInscripcionesDuplicadas();
            }
        }

        private async Task CargarCboAño()
        {
            var idCarrera = (int) CboCarreras.SelectedValue;
            var años = await unitOfWork.AniocarreraRepository.GetAllAsync(filter:a =>a.CarreraId1 == idCarrera,
                include: a => a.Include(a => a.CarreraId1Navigation));
            CboAñoCarrera.DataSource = años;
            CboAñoCarrera.DisplayMember = "Nombre";
            CboAñoCarrera.ValueMember = "Id";
        }

        private async Task CargarCboCarrera()
        {

            var carreras = await unitOfWork.CarreraRepository.GetAllAsync();
            CboCarreras.DisplayMember = "Nombre";
            CboCarreras.ValueMember = "Id";
            CboCarreras.DataSource = carreras.ToList();

            AutoCompleteStringCollection autoCompletado = new AutoCompleteStringCollection();
            foreach (Carrera item in carreras)
            {
                //agrega el texto encontrado en la segunda columna del datatable
                //si el datatable no tiene 2da columna va a dar error
                autoCompletado.Add(item.Nombre.ToString());
            }
            CboCarreras.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            CboCarreras.AutoCompleteSource = AutoCompleteSource.CustomSource;
            CboCarreras.AutoCompleteCustomSource = autoCompletado;
        }

        private async Task GetAlumnos()
        {
            var alumnos = await unitOfWork.AlumnoRepository.GetAllAsync();
            ListaAlumnos.DataSource = alumnos;

        }

        private void CboCarreras_SelectionChangeCommitted(object sender, EventArgs e)
        {
            CargarCboAño();
        }


        private void BtnSeleccionarAlumno_Click(object sender, EventArgs e)
        {
            PanelMaterias.Enabled = true;
            alumnoSeleccionado = (Alumno)ListaAlumnos.Current;
            LblNombreAlumno.Text = alumnoSeleccionado.ApellidoNombre;
            PanelAlumno.Enabled = false;
            CargarMateriasInscriptas();
            EliminarInscripcionesDuplicadas();
        }

        private async Task CargarMateriasInscriptas()
        {
            ListaMateriasInscriptas.DataSource = await unitOfWork.InscripcionRepository.GetAllAsync(filter: i => i.CicloLectivoId == (int)cboCicloLectivo.SelectedValue && i.AlumnoId == alumnoSeleccionado.Id, include: i => i.Include( m => m.Materia).Include( m => m.Alumno ).Include(m => m.CicloLectivo));
        }

        private void CboAñoCarrera_SelectedValueChanged(object sender, EventArgs e)
        {
            CargarMaterias();
        }


        private async void BtnBuscar_Click(object sender, EventArgs e)
        {
            var alumnos = await unitOfWork.AlumnoRepository.GetAllAsync(filter: a => a.ApellidoNombre.Contains(TxtBuscarAlumno.Text) || a.Dni == Convert.ToInt32(TxtBuscarAlumno.Text));
            ListaAlumnos.DataSource = alumnos;
        }

        private async void BtnBuscarMateria_Click(object sender, EventArgs e)
        {
            var idAnioCarrera = (int)CboAñoCarrera.SelectedValue;

            var materias = await unitOfWork.MateriaRepository.GetAllAsync(filter: m => m.Nombre.Contains(TxtBuscarMateria.Text) && m.AnioCarreraId1 == idAnioCarrera);
            ListaMaterias.DataSource = materias;
        }

        private async void BtnAgregar_Click(object sender, EventArgs e)
        {
            materiaSeleccionada = (Materia)ListaMaterias.Current;
            BtnAgregar.Enabled = false;
            BtnAgregarTodas.Enabled = false;
            await InsertarMateriaSeleccionada(materiaSeleccionada.Id);
            unitOfWork.Save();
            await CargarMateriasInscriptas();
            EliminarInscripcionesDuplicadas();

        }

        private void EliminarInscripcionesDuplicadas()
        {
            List<Materia> materiasFiltradas = materias.ToList();

            foreach (Inscripcion inscripcion in ListaMateriasInscriptas)
            {
                var materiaABorrar = materiasFiltradas.Where(m => m.Id == inscripcion.MateriaId).FirstOrDefault();
                if (materiaABorrar != null)
                {
                    materiasFiltradas.Remove(materiaABorrar);
                }
            }
            materias = materiasFiltradas.AsEnumerable<Materia>();
            ListaMaterias.DataSource = materias;
        }

        private async Task InsertarMateriaSeleccionada(int idMateria)
        {

            var inscripcion = new Inscripcion()
            {
                MateriaId = idMateria,
                AlumnoId = alumnoSeleccionado.Id,
                CicloLectivoId = (int)cboCicloLectivo.SelectedValue,
            };
            await unitOfWork.InscripcionRepository.AddAsync(inscripcion);
        }

        private async void BtnQuitar_Click(object sender, EventArgs e)
        {

                var inscripcionSeleccionada = (Inscripcion)ListaMateriasInscriptas.Current;
                var respuesta = MessageBox.Show($"Esta seguro que desea eliminar la materia {inscripcionSeleccionada.Materia.Nombre} de la inscripcion", $"Eliminar Materia inscripta", MessageBoxButtons.YesNo,MessageBoxIcon.Question);
                if(respuesta == DialogResult.Yes)
                {
                    BtnQuitar.Enabled = false;
                    BtnQuitarTodas.Enabled = false;
                    await unitOfWork.InscripcionRepository.DeleteAsync(inscripcionSeleccionada.Id);
                    unitOfWork.Save();
                    await CargarMateriasInscriptas();
                    await CargarMaterias();
                    EliminarInscripcionesDuplicadas();
                    
                }
        }

        private async void BtnAgregarTodas_Click(object sender, EventArgs e)
        {
                BtnAgregarTodas.Enabled = false;
            BtnAgregar.Enabled = false;
                ProgresBar.Visible = true;
                var incremento = Math.Floor(100 / (decimal)ListaMaterias.Count);
                ProgresBar.Value = 0;

                foreach (Materia materia in ListaMaterias)
                {
                    await InsertarMateriaSeleccionada(materia.Id);
                    ProgresBar.Value += (int)incremento;
                }

                unitOfWork.Save();
                ProgresBar.Visible = false;
                await CargarMateriasInscriptas();
                EliminarInscripcionesDuplicadas();
        }

        private async void BtnQuitarTodas_Click(object sender, EventArgs e)
        {
            var respuesta = MessageBox.Show($"Esta seguro que desea eliminar todas las inscripciones a las materias", $"Eliminar inscripciones ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (respuesta == DialogResult.Yes)
            {
                BtnQuitarTodas.Enabled =false;
                BtnQuitar.Enabled = false;
                foreach (Inscripcion inscripcion in ListaMateriasInscriptas)
                {
                    await unitOfWork.InscripcionRepository.DeleteAsync(inscripcion.Id);

                }
                unitOfWork.Save();
                await CargarMateriasInscriptas();
                await CargarMaterias();
                EliminarInscripcionesDuplicadas();

            }
            

        }

        private void BtnVistaPrevia_Click(object sender, EventArgs e)
        {
            InscripcionReprotView inscripcionReportView = new InscripcionReprotView();
            inscripcionReportView.ShowDialog();
        }
    }
}
