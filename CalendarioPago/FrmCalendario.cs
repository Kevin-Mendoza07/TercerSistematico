using AppCore.Interfaces;
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
        }

        private void FrmCalendario_Load(object sender, EventArgs e)
        {
            dgvVerCuotas.DataSource = null;
            dgvVerCuotas.DataSource = calendarioService.GetAll();

            cmbBusqueda.Items.AddRange(Enum.GetValues(typeof(Finder)).Cast<object>().ToArray());
        }
    }
}
