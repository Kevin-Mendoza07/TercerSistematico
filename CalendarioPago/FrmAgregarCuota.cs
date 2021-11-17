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
    public partial class FrmAgregarCuota : Form
    {
        public ICalendarioService calendarioService { get; set; }
        public FrmAgregarCuota()
        {
            InitializeComponent();
        }

        private void FrmAgregarCuota_Load(object sender, EventArgs e)
        {
            cmbEstado.Items.AddRange(Enum.GetValues(typeof(Estado)).Cast<object>().ToArray());
            cmbTipo.Items.AddRange(Enum.GetValues(typeof(Tipo)).Cast<object>().ToArray());
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            Calendario calendarioPago = new Calendario()
            {
                Id = calendarioService.GetLastIdCuota() + 1,
                Tipo = (Tipo)cmbTipo.SelectedIndex,
                Estado = (Estado)cmbEstado.SelectedIndex,
                FechaPaga = dateTimePicker2.Value,
                FechaVencimiento = dateTimePicker1.Value,
                Monto = nudMonto.Value,
                Terminos = (int)nudTerminos.Value,
                Tasa = nudTasa.Value
            };
            calendarioService.Add(calendarioPago);
            Dispose();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
