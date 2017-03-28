using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalReports.controlador;
using CrystalDecisions.CrystalReports.Engine;

namespace CrystalReports
{    
    public partial class frmReporte : Form
    {
        ReportDocument crpDocument;
        public void GenerarReporte()
        {
            crpDocument = new ReportDocument();
            crpDocument.Load(@"Reportes\rptProductos.rpt");
            crpDocument.SetDataSource(ProductoManager.GetList());
            crpDocument.SetParameterValue("parUsuario", "Juanito");
            this.crystalReportViewer1.ReportSource = crpDocument;
        }
        public void CargarDeptos()
        {
            this.cmbDepartamento.DataSource = ProductoManager.ListarDeptos();
            this.cmbDepartamento.SelectedItem = this.cmbDepartamento.Items.Count - 1;
        }
        public frmReporte()
        {
            InitializeComponent();
        }
        private void frmReporte_Load(object sender, EventArgs e)
        {
            this.CargarDeptos();
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            GenerarReporte();
        }
    }
}