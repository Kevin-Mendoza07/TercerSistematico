using AppCore.Interfaces;
using Domain;
using Domain.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalendarioPago
{
    public partial class FrmCalendario : Form
    {
        public ICalendarioService calendarioService;
        public FrmCalendario(ICalendarioService calendarioService)
        {
            this.calendarioService = calendarioService;
            InitializeComponent();
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BtnCrear_Click(object sender, EventArgs e)
        {
            FrmAgregarCuota frmAgregarCuota = new FrmAgregarCuota();
            frmAgregarCuota.calendarioService = calendarioService;
            frmAgregarCuota.ShowDialog();

            dgvVerCuotas.DataSource = calendarioService.GetAll();
        }

        private void FrmCalendario_Load(object sender, EventArgs e)
        {
            //dgvVerCuotas.DataSource = null;
            //dgvVerCuotas.DataSource = calendarioService.GetAll();

            cmbBusqueda.Items.AddRange(Enum.GetValues(typeof(Finder)).Cast<object>().ToArray());
            cmbEstado.Items.AddRange(Enum.GetValues(typeof(Estado)).Cast<object>().ToArray());
            cmbTipos.Items.AddRange(Enum.GetValues(typeof(Tipo)).Cast<object>().ToArray());
        }

        private void CmbBusqueda_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cmbBusqueda.SelectedIndex)
            {
                case 0:
                    cmbTipos.Visible= true;
                    cmbEstado.Visible = false;
                    break;
                case 1:
                    cmbTipos.Visible = false;
                    cmbEstado.Visible = true;
                    break;
            }
            List<Calendario> calendarios = calendarioService.GetAll();
            switch (cmbBusqueda.SelectedIndex)
            {
                case 0:
                    var filtrado = (from x in calendarios
                                    where (x.Tipo >= 0) && x.Tipo.Equals((Tipo)cmbTipos.SelectedIndex)
                                    select x).ToList();
                    dgvVerCuotas.DataSource = filtrado;
                    break;
                case 1:
                    filtrado = (from x in calendarios
                                    where (x.Estado >= 0) && x.Estado.Equals((Estado)cmbEstado.SelectedIndex)
                                    select x).ToList();
                    dgvVerCuotas.DataSource = filtrado;
                    break;
            }
        }

        private void CmbEstado_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
