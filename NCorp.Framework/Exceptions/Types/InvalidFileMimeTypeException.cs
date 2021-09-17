using System;
using System.Runtime.Serialization;

namespace NCorp.Framework.Exceptions.Types
{
    [Serializable]
    public class InvalidFileMimeTypeException : Exception
    {
        public InvalidFileMimeTypeException() : base() { }
        public InvalidFileMimeTypeException(string mimeType) : base($"File type {mimeType} is not valid!") { }
        public InvalidFileMimeTypeException(string mimeType, Exception innerException) : base($"File type {mimeType} is not valid!", innerException) { }

        protected InvalidFileMimeTypeException(SerializationInfo info, StreamingContext context) : base(info, context) { }
    }
}