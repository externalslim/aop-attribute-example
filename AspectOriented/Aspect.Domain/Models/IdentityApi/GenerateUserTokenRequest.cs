using System.Collections.Generic;
using Phoenix.Core.Common;

namespace Aspect.Domain.Models.IdentityApi
{
    public class GenerateUserTokenRequest
    {
        public IEnumerable<TokenParameter> Parameters { get; set; }
        public Channel Channel { get; set; }
    }
}
