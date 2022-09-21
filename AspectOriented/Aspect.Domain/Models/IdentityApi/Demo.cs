using System;

namespace Aspect.Domain.Models.IdentityApi
{
    public class Demo
    {
        public string Message { get; set; }
        public Guid UniqueId { get; set; } = Guid.NewGuid();
    }
}
