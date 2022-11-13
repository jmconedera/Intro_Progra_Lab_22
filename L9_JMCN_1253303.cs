using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9_JMCN_1253303
{
    class Program
    {
        static void Main(string[] args)
        {
            Automovil objAutomovil = new Automovil(2019, 10000.00, "", false, 7.50, 0.00);

            Console.WriteLine("Ingrese la marca del automóvil:");
            objAutomovil.DefinirMarca(Console.ReadLine());

            Console.WriteLine(objAutomovil.MostrarInformacion());

            
            Console.ReadKey();
        }
    }

    class Automovil
    {
        
        private int modelo;
        private double precio;
        private string marca;
        private bool disponible;
        private double tipoCambioDolar;
        private double descuentoAplicado;

       
        
        public Automovil (int Modelo, double Precio, string Marca, bool Disponible, double TipoCambioDolar, double DescuentoAplicado)
        {
            modelo = Modelo;
            precio = Precio;
            marca = Marca;
            disponible = Disponible;
            tipoCambioDolar = TipoCambioDolar;
            descuentoAplicado = DescuentoAplicado;
        }

        public void DefinirModelo(int unModelo)
        {
            modelo = unModelo;
        }

        public void DefinirPrecio(double unPrecio)
        {
            precio = unPrecio;
        }

        public void DefinirMarca(string unaMarca)
        {
            marca = unaMarca;
        }

        public void DefinirTipoCambio(double unTipoCambio)
        {
            tipoCambioDolar = unTipoCambio;
        }

        public void CambiarDisponibilidad()
        {
            if (disponible == true)
            {
                disponible = false;
            }
            else
            {
                disponible = true;
            }
        }

        public string MostrarDisponibilidad()
        {
            if (disponible == true)
            {
                return "Disponible";
            }
            else
            {
                return "No se encuentra disponible actualmente";
            }
        }

        
        public string MostrarInformacion()
        {
            return "Marca: " + marca + ", precio: " + precio;
        }
    }
}
