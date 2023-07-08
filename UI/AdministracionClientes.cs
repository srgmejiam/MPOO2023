using EL;
using BLL;
namespace UI
{
    public partial class AdministracionClientes : Form
    {
        public AdministracionClientes()
        {
            InitializeComponent();
        }
      
        private void AdministracionClientes_Load(object sender, EventArgs e)
        {
            cargarGrid();
        }

        private void cargarGrid()
        {
            gridClientes.DataSource = BLL_Clientes.Lista();
        }
        private void Guardar()
        {
            Clientes Cliente = new();
            Cliente.NombreCliente = txtNombreCliente.Text;
            Cliente.Numero = txtNumero.Text;
            Cliente.Correo= txtCorreo.Text;
            BLL_Clientes.Insert(Cliente);

        }
        private void LimpiarCampos()
        {
            txtNombreCliente.Text = string.Empty;
            txtCorreo.Text = string.Empty;  
            txtNumero.Text = string.Empty;  
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Guardar();
            cargarGrid();
            LimpiarCampos();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
            cargarGrid();
        }
    }
}