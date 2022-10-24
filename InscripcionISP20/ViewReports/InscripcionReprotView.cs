using Data.Models;
using Data.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Linq;

namespace Desktop.ViewReports
{
    public partial class InscripcionReprotView : Form
    {
        ReportViewer reporte = new ReportViewer();
        UnitOfWork unitOfWork = new UnitOfWork();
        public InscripcionReprotView()
        {
            InitializeComponent();
            reporte.Dock = DockStyle.Fill;
            reporte.SetDisplayMode(DisplayMode.PrintLayout);
            reporte.ZoomMode = ZoomMode.Percent;
            reporte.ZoomPercent = 100;
            Controls.Add(reporte);
        }

        private void InscripcionReprotView_Load(object sender, EventArgs e)
        {
            CargarReporteAsync();
        }

        private async Task CargarReporteAsync()
        {
            reporte.LocalReport.ReportEmbeddedResource = "Desktop.Reports.RptInscripcion.rdlc";
            var inscripciones = await unitOfWork.InscripcionRepository.GetAllAsync(
                include: i => i.Include(i => i.Alumno).Include(i => i.CicloLectivo).Include(i => i.Materia).ThenInclude(m => m.AnioCarreraId1Navigation).ThenInclude(a => a.CarreraId1Navigation));
            var InscripcionesFormateadas = from Inscripcion inscripcion in inscripciones
                                           select new
                                           {
                                               Alumno = inscripcion.Alumno.ApellidoNombre,
                                               DNI = inscripcion.Alumno.Dni,
                                               Telefono = inscripcion.Alumno.Telefono,
                                               Email = inscripcion.Alumno.Email,
                                               Materia = inscripcion.Materia.Nombre,
                                               AñoCarrera = inscripcion.Materia.AnioCarreraId1Navigation.Nombre,
                                               Carrera = inscripcion.Materia.AnioCarreraId1Navigation.CarreraId1Navigation.Nombre,
                                               CicloLectivo = inscripcion.CicloLectivo.Nombre,
                                           };
            reporte.LocalReport.DataSources.Add(new ReportDataSource("DSInscripcion", InscripcionesFormateadas));

            reporte.RefreshReport();
        }
    }
}
