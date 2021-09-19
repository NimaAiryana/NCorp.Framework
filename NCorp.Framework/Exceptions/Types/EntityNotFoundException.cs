using System;
using System.Runtime.Serialization;

namespace NCorp.Framework.Exceptions.Types
{
    [Serializable]
    public class EntityNotFoundException : Exception
    {
        public EntityNotFoundException() : base("The entity not found!") { }
        public EntityNotFoundException(string message) : base(message) { }
        public EntityNotFoundException(string message, Exception innerException) : base(message, innerException) { }

        protected EntityNotFoundException(SerializationInfo info, StreamingContext context) : base(info, context) { }
    }
}