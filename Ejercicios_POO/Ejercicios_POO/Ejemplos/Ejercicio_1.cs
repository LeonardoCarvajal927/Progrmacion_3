//Simulador de Cajero Automático (Clase Cuenta)

using System;

namespace Ejercicios_POO.Ejemplos
{
    public class CuentaBancaria
    {
        public string Titular { get; set; }
        public decimal Saldo { get; set; }

        public CuentaBancaria(string titular)
        {
            Titular = titular;
            Saldo = 0;
        }

        public void ConsultarSaldo()
        {
            Console.WriteLine("Saldo actual: $" + Saldo);
        }

        public void Depositar(decimal cantidad)
        {
            if (cantidad > 0)
            {
                Saldo += cantidad;
                Console.WriteLine("Depósito realizado correctamente.");
            }
            else
            {
                Console.WriteLine("La cantidad debe ser mayor a cero.");
            }
        }

        public void Retirar(decimal cantidad)
        {
            if (cantidad <= 0)
            {
                Console.WriteLine("La cantidad debe ser mayor a cero.");
            }
            else if (cantidad > Saldo)
            {
                Console.WriteLine("Fondos insuficientes.");
            }
            else
            {
                Saldo -= cantidad;
                Console.WriteLine("Retiro realizado correctamente.");
            }
        }
    }

    public class Ejercicio_1
    {
        public static void Ejecutar()
        {
            Console.Write("Simulador de Cajero Automático\n");
            Console.Write("\nIngrese su nombre: ");
            string nombre = Console.ReadLine();

            CuentaBancaria cuenta = new CuentaBancaria(nombre);

            int opcion;

            do
            {

                Console.WriteLine("Simulador de Cajero Automático\n");
                Console.WriteLine("\n--- Cajero Automático ---");
                Console.WriteLine("1. Consultar saldo");
                Console.WriteLine("2. Depositar");
                Console.WriteLine("3. Retirar");
                Console.WriteLine("4. Salir");
                Console.Write("Seleccione una opción: ");

                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        cuenta.ConsultarSaldo();
                        break;

                    case 2:
                        Console.Write("Ingrese cantidad a depositar: ");
                        decimal deposito = decimal.Parse(Console.ReadLine());
                        cuenta.Depositar(deposito);
                        break;

                    case 3:
                        Console.Write("Ingrese cantidad a retirar: ");
                        decimal retiro = decimal.Parse(Console.ReadLine());
                        cuenta.Retirar(retiro);
                        break;

                    case 4:
                        Console.WriteLine("Gracias por usar el cajero.");
                        break;

                    default:
                        Console.WriteLine("Opción inválida.");
                        break;
                }

            } while (opcion != 4);
        }
    }
}