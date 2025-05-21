using Boleteria.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;

namespace Boleteria
{
    public partial class fReserva : Form
    {
        public fReserva()
        {
            InitializeComponent();
        }

        private void fReserva_Load(object sender, EventArgs e)
        {
            RevisarYActualizar();

        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            var boleto = new Classes.Boletos();
            boleto.Nombre = txtNombre.Text.ToUpper();
            boleto.Correo = txtCorreo.Text.ToLower();
            boleto.Numero = txtTelefono.Text;
            int cantidad = int.Parse(txtCantidad.Text);

            var resultados = new List<ValidationResult>();
            var contexto = new ValidationContext(boleto, null, null);
            bool esValido = Validator.TryValidateObject(boleto,
                contexto, resultados, true);

            if (Classes.Acciones.Excedido(boleto.Correo, cantidad))
            {
                MessageBox.Show("Exediste el numero de boletos que se puede adquirir por usuario");
                return;
            }

            if (cantidad > Acciones.AsientosDisponibles())
            {
                MessageBox.Show("No hay suficientes boletos disponibles");
                return;
            }

            if (cantidad > 5)
            {
                MessageBox.Show("No puedes comprar mas de 5 boletos");
                return;
            }

            if (esValido == false)
            {
                string errores = string.Join('\n',
                    resultados.ConvertAll(x => x.ErrorMessage));
                MessageBox.Show(errores);
            }
            else
            {
                List<string> asientos = Classes.Acciones.AgregarBoleto(boleto, cantidad);
                var al = string.Join(", ", asientos);
                MessageBox.Show(boleto.Nombre + ", Gracias por adquirir tus boletos. \n Tu(s) asientos son: " + al);
                RevisarYActualizar();
            }
        }

        public bool RevisarYActualizar()
        {
            int asientosDisponibles = Acciones.AsientosDisponibles();
            int disponibles = asientosDisponibles;
            qtyCantidad.Text = disponibles.ToString();
            if (disponibles == 0)
            {
                btnEnviar.Enabled = false;
            }
            return true;
        }

        private void btnVer_Click(object sender, EventArgs e)
        {
            var vista = new fVista();
            vista.ShowDialog();
        }
    }
}
