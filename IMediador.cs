using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediador
{
   public  interface IMediador
    {
       
        public  void Informar(Mensaje mensaje, ICliente cliente);

    }
}
