using System;

namespace Kosmos.Application.Exceptions
{
    public sealed class NotFoundException : Exception
    {
        public NotFoundException(string name, object key) : base($"Entity \"{name}\" ({key}) was not found.")
        {
        }
    }
}