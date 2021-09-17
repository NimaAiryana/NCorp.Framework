using System;
using System.Runtime.Serialization;

namespace NCorp.Framework.Exceptions.Types
{
    [Serializable]
    public class InvalidFileException : Exception
    {
        public InvalidFileException() : base() { }
        public InvalidFileException(string mimeType) : base($"File type {mimeType} is not valid!") { }
        public InvalidFileException(string mimeType, Exception innerException) : base($"File type {mimeType} is not valid!", innerException) { }

        protected InvalidFileException(SerializationInfo info, StreamingContext context) : base(info, context) { }
    }
}