using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace FrmPrincipal
{
    public class FaltaMateriasExcepcion : Exception
    {
        public FaltaMateriasExcepcion()
        {
        }

        public FaltaMateriasExcepcion(string message) : base(message)
        {
        }

        public FaltaMateriasExcepcion(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected FaltaMateriasExcepcion(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
