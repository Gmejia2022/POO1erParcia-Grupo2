using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using ATM_Cajero;
using ATM_Cajero.Clases;
using static System.Windows.Forms.LinkLabel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
// Developer: GMEJIA
// Fecha: 18 Agosto 2023
// Cajero Automatico
namespace ATM_Cajero
{
    public partial class FrmCajero : Form
    {
        public CargaDatosMaestro maestroCuentas;

        public MaestroCuenta CuentaEncontrada { get; private set; }

        public int TipoTransaccion;

        public FrmCajero()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Carga datos Maestro
            maestroCuentas = new CargaDatosMaestro("MOCK_DATA.json");
            //maestroCuentas.ListaCuentas();

            LblTiempo.Text = ($"Carga Cuentas: {maestroCuentas.TiempoProceso.ElapsedMilliseconds} ms");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // Presenta le Fecha y Hora
            DateTime now = DateTime.Now;
            string result = $"{now:dd MMMM yyyy  HH:mm:ss}";
            LblDate.Text = result;
        }

        private void BtnConsulta_Click(object sender, EventArgs e)
        {
            OpcionMenu(1, "CONSULTA DE SALDOS");
        }
        private void BtnDeposito_Click(object sender, EventArgs e)
        {
            OpcionMenu(2, "DEPOSITO DE DINERO");   
        }

        private void BtnRetiro_Click(object sender, EventArgs e)
        {
            OpcionMenu(3, "RETIRO DE DINERO");            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpcionMenu(4, "");
        }
        private void OpcionMenu(int tipo, string valor)
        {

            LblTipo.Text = valor; CuentaEncontrada = null;
            TipoTransaccion = tipo;
            switch (tipo)
            {
                case 1:
                    label1.Visible = true; label2.Visible = true; LblSaldo.Visible = true;
                    TxtID.Text = ""; TxtID.Visible = true;
                    TxtClave.Text = ""; TxtClave.Visible = true;
                    label3.Visible = false; TxtMonto.Visible = false; TxtMonto.Text = "";
                    TxtID.Focus();
                    LblTipo.Visible = true; PictureA.Visible = false;
                    break;
                case 2:
                    label1.Visible = true; label2.Visible = true; LblSaldo.Visible = true;
                    TxtID.Text = ""; TxtID.Visible = true;
                    TxtClave.Text = ""; TxtClave.Visible = true;
                    label3.Visible = true; TxtMonto.Visible = true; TxtMonto.Text = "";
                    TxtID.Focus();
                    LblTipo.Visible = true; PictureA.Visible = false;
                    break;

                case 3:
                    label1.Visible = true; label2.Visible = true; LblSaldo.Visible = true;
                    TxtID.Text = ""; TxtID.Visible = true;
                    TxtClave.Text = ""; TxtClave.Visible = true;
                    label3.Visible = true; TxtMonto.Visible = true; TxtMonto.Text = "";
                    TxtID.Focus();
                    LblTipo.Visible = true; PictureA.Visible = false;
                    break;

                case 4:
                    LblTipo.Visible = true; PictureA.Visible = false;
                    label1.Visible = false; label2.Visible = false; LblSaldo.Visible = false;
                    label3.Visible = false; TxtMonto.Visible = false; TxtMonto.Text = "";
                    TxtID.Text = ""; TxtID.Visible = false;
                    TxtClave.Text = ""; TxtClave.Visible = false;
                    LblTipo.Visible = false; PictureA.Visible = true;
                    break;
                default:                    
                    break;
            }            
        }

        private void TxtID_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                BuscaClienteID();
            }
        }

        private void BuscaClienteID()
        {
            if (int.TryParse(TxtID.Text, out int idBuscado))
            {

                CuentaEncontrada = maestroCuentas.BuscarPorId(idBuscado);

                if (CuentaEncontrada != null)
                {
                    LblTiempo.Text = ($"Consulta: {maestroCuentas.TiempoProceso.ElapsedMilliseconds} ms");
                    LblSaldo.Text = $"Hola: {CuentaEncontrada.Nombre} {CuentaEncontrada.Apellido}";
                    TxtClave.Focus();
                }
                else
                {
                    LblSaldo.Text = $"Cuenta ID: {idBuscado} no Existe.";                    
                }
            }
            else
            {
                MessageBox.Show("Ingresa un valor numérico válido en el campo de búsqueda.");
            }
         
        }

        private void TxtClave_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                string ClaveE = CuentaEncontrada.Clave.ToString();

                if (TxtClave.Text == ClaveE)
                {
                    LblSaldo.Text = $"Hola: {CuentaEncontrada.Nombre} {CuentaEncontrada.Apellido} Saldo: {CuentaEncontrada.Saldo} ";
                    if (TxtMonto.Visible == true )
                    {
                        TxtMonto.Focus();
                    }
                    else
                    {
                        timer2.Enabled = true;
                    }
                }
                else
                {
                    LblSaldo.Text = $"Hola: {CuentaEncontrada.Nombre} {CuentaEncontrada.Apellido} Clave Incorrecta ";
                }
            }
        }

        private void TxtClave_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtMonto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {

                if (TipoTransaccion == 2)
                {
                    string saldo = maestroCuentas.Deposito(TxtID.Text.ToString(), TxtMonto.Text.ToString());
                    LblSaldo.Text = $"Hola: {CuentaEncontrada.Nombre} {CuentaEncontrada.Apellido} Nuevo Saldo: {saldo} ";
                }

                if (TipoTransaccion == 3)
                {
                    string saldo = maestroCuentas.Retiro(TxtID.Text.ToString(), TxtMonto.Text.ToString());
                    LblSaldo.Text = $"Hola: {CuentaEncontrada.Nombre} {CuentaEncontrada.Apellido} {saldo} ";
                }

                timer2.Enabled = true;

            }
        }

        private void TxtMonto_TextChanged(object sender, EventArgs e)
        {

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            OpcionMenu(4, "");
            timer2.Enabled = false;
        }
    }
  
    }
