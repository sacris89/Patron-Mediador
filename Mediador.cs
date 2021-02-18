using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediador
{
    
    public class Mediador : IMediador
    {
        public List<ICliente> clientes;
        public Mediador()
        {
            clientes = new List<ICliente>();
        }    
 
        public void Informar(Mensaje mensaje, ICliente cliente)
        {
            foreach (ICliente i in clientes)
            {
                if (cliente != i)
                {
                    cliente.recibirMensaje(mensaje);
                }
            }
        }
    }
}
