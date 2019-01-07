using System;

namespace SemanticArchitecture.Domain.Core.Shared
{
    public class Entity
    {
        public Guid Id { get; set; } = Guid.NewGuid();
    }
}
