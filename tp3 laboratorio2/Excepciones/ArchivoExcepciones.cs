using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    public class ArchivoExcepciones : Exception
    {
        public ArchivoExcepciones()
        {
        }

        public ArchivoExcepciones(string message) : base(message)
        {
        }

        public ArchivoExcepciones(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected ArchivoExcepciones(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
