using System;

namespace Kosmos.Domain.entities
{
    public sealed class World
    {
        public short Id { get; set; }
        public string Name { get; set; }
        public DateTime CreationDate { get; set; }
        public string GameServer { get; set; }
        public string Status { get; set; }
    }
}