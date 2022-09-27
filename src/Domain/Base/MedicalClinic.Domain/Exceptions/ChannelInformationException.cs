using System;
namespace MedicalClinic.Domain.Exceptions
{
    public class ChannelInformationException : Exception
    {
        public ChannelInformationException()
        {
        }

        public ChannelInformationException(string name)
            : base(name)
        {
        }

        public ChannelInformationException(string name, Exception exceptionData)
            : base(name, exceptionData)
        {
        }
    }
}
