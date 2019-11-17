using System;
using System.Runtime.Serialization;

namespace Calculadorastack
{
    [Serializable]
    internal class ArgumentosInsuficientes : Exception
    {
        public ArgumentosInsuficientes()
        {
        }

        public ArgumentosInsuficientes(string message) : base(message)
        {
        }

        public ArgumentosInsuficientes(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected ArgumentosInsuficientes(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}