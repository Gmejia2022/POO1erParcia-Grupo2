using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// Clase para Operacion del Cajero Automatico
// Developer: GMEJIA
// Fecha: 17 Agosto 2023
// Link para generar datos Fake, para pruebas: https://www.mockaroo.com/

namespace ATM_Cajero.Clases
{
    // Clase para representar el Maestro de Cuentas
    public class MaestroCuenta
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public double Saldo { get; set; }
        public int Clave { get; set; }
        public string TipoCuenta { get; set; }
    }

    // Clase para Cargar y Crear Lista
    public class CargaDatosMaestro
        {
        // Atributos
        public Stopwatch TiempoProceso { get; set; }
        public List<MaestroCuenta> ListCuentas { get; set; }

        // Variables de la Clase
        //private List<MaestroCuenta> _listaCuentas;

        // Constructor de la Clase
        public CargaDatosMaestro(string rutaArchivo)
            {

            try
            {
                CargarDesdeArchivo(rutaArchivo);
            }
            catch (Exception ex)
            {
                MessageBox.Show ($"Error al cargar los datos: {ex.Message}", "Mensaje del Sistema",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            }

        private void CargarDesdeArchivo(string rutaArchivo)
        {
            // Calculo del Tiempo del Proceso
            TiempoProceso = new Stopwatch();
            TiempoProceso.Start();
            
            string contenido = System.IO.File.ReadAllText(rutaArchivo);
            ListCuentas = JsonConvert.DeserializeObject<List<MaestroCuenta>>(contenido);

            TiempoProceso.Stop();

        }

        // Método para buscar por ID
        public MaestroCuenta BuscarPorId(int idBuscado)
        {
            // Calculo del Tiempo del Proceso
            TiempoProceso = new Stopwatch();
            TiempoProceso.Start();
            ListCuentas.Find(cuenta => cuenta.Id == idBuscado);
            TiempoProceso.Stop();
            return ListCuentas.Find(cuenta => cuenta.Id == idBuscado);
        }

        public string Deposito(String idBuscado, String MontoDeposito)
        {
            
            int idBuscadoInteger = int.Parse(idBuscado);
            
            double MontoDouble = double.Parse(MontoDeposito);
            int indiceCuenta = ListCuentas.FindIndex(cuenta => cuenta.Id == idBuscadoInteger);

            if (indiceCuenta != -1)
            {
                ListCuentas[indiceCuenta].Saldo = ListCuentas[indiceCuenta].Saldo + MontoDouble;
                return ListCuentas[indiceCuenta].Saldo.ToString();
            }
            else
            {
                return ListCuentas[indiceCuenta].Saldo.ToString();
            }
        }

        public string Retiro(String idBuscado, String MontoRetiro)
        {

            int idBuscadoInteger = int.Parse(idBuscado);

            double MontoDouble = double.Parse(MontoRetiro);
            int indiceCuenta = ListCuentas.FindIndex(cuenta => cuenta.Id == idBuscadoInteger);

            if (indiceCuenta != -1)
            {
                double MontoActual = ListCuentas[indiceCuenta].Saldo;

                if (MontoActual < MontoDouble)
                    {
                    return "Saldo Insuficiente";
                }
                else
                {
                    ListCuentas[indiceCuenta].Saldo = ListCuentas[indiceCuenta].Saldo - MontoDouble;
                    return "Nuevo Saldo:" + ListCuentas[indiceCuenta].Saldo.ToString();
                }                
            }
            else
            {
                return ListCuentas[indiceCuenta].Saldo.ToString();
            }
        }
        public void ListaCuentas()
        {
            foreach (var cuenta in ListCuentas)
            {
                Console.WriteLine($"ID: {cuenta.Id}");
                Console.WriteLine($"Nombre: {cuenta.Nombre}");
                Console.WriteLine($"Apellido: {cuenta.Apellido}");
                Console.WriteLine($"Saldo: {cuenta.Saldo}");
                Console.WriteLine($"Clave: {cuenta.Clave}");
                Console.WriteLine($"Tipo de Cuenta: {cuenta.TipoCuenta}");
                Console.WriteLine();
            }
        }

    }
}
