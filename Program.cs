using System;

namespace Mediador
{
    class Program
    {
        static void Main(string[] args)
        {
            Mediador mediador = new Mediador();
            ICliente c1 = new Cliente(1,mediador);
            ICliente c2 = new Cliente(2,mediador);
            mediador.clientes.Add(c1);
            mediador.clientes.Add(c2);
            c1.EnviarMensaje("Perico de los palotes");
            c2.EnviarMensaje("Perica");

        }
    }
}
