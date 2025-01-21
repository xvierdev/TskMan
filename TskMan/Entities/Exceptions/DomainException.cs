using System;

namespace TskMan.Entities.Exceptions
{
    class DomainException(string message) : ApplicationException(message)
    {

    }
}