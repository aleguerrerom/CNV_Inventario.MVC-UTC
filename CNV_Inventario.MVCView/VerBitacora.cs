using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CNV_Inventario.MVCController;

namespace CNV_Inventario.MVCView
{
    public partial class VerBitacora : Form
    {
        private Bitacora bitacora;
        private BitacoraHelper bitH;
        private DataTable table;
       

        public VerBitacora()
        {
            InitializeComponent();
        }
        
        private void listadoLogsUsuarios()
        {

            try
            {

                this.bitacora = new Bitacora();
                this.bitacora.opc = 1;

                //rolhelper
                this.bitH = new BitacoraHelper(bitacora);

                //datatable
                this.table = new DataTable();

                this.table = bitH.Listar();
                if (table.Rows.Count > 0)
                    this.dgvListar.DataSource = table;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        private void Bitacora_Load(object sender, EventArgs e)
        {
            listadoLogsUsuarios();
            LabelDescription.Text = "Logs de Usuarios Logeados";
            btnChange.Text = "VER LOGS DE MOVIMIENTOS";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (btnChange.Text == "VER LOGS DE LOG IN")
            {
                listadoLogsUsuarios();
                LabelDescription.Text = "Logs de Usuarios Logeados";
                btnChange.Text = "VER LOGS DE MOVIMIENTOS";
            }
            else
            {
                listadoLogsMovimientos();
                LabelDescription.Text = "Detalle de Logs de Movimientos en la Aplicacion";
                btnChange.Text = "VER LOGS DE LOG IN";
            }
        }

        private void listadoLogsMovimientos()
        {

            try
            {

                this.bitacora = new Bitacora();
                this.bitacora.opc = 4;

                //rolhelper
                this.bitH = new BitacoraHelper(bitacora);

                //datatable
                this.table = new DataTable();

                this.table = bitH.Listar();
                if (table.Rows.Count > 0)
                    this.dgvListar.DataSource = table;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
