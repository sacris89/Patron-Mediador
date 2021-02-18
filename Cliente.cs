using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediador
{
    class Cliente : ICliente
    {
        public int id;
        public IMediador m;



        public Cliente(int id, IMediador m) {
            this.id = id;
            this.m = m;
            
        }


        public void EnviarMensaje(String mensaje)
        {
            m.Informar(new Mensaje() {  mensaje = mensaje}, this);
        }

        public void recibirMensaje(Mensaje m)
        {
            Console.WriteLine("El usuario es" + id + "El mensaje es: " + m.mensaje);
        }
    }
}
