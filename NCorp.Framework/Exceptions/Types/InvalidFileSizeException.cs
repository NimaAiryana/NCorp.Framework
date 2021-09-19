using System;
using System.Runtime.Serialization;

namespace NCorp.Framework.Exceptions.Types
{
    [Serializable]
    public class InvalidFileSizeException : Exception
    {
        public InvalidFileSizeException() : base("The file size is out of range!") { }
        public InvalidFileSizeException(Exception innerException) : base("The file size is out of range!", innerException) { }
        public InvalidFileSizeException(string message) : base(message) { }
        public InvalidFileSizeException(string message, Exception innerException) : base(message, innerException) { }

        protected InvalidFileSizeException(SerializationInfo info, StreamingContext context) : base(info, context) { }
    }
}