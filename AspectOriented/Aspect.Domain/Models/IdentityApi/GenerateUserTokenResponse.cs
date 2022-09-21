using System.Collections.Generic;
using Phoenix.Core.Common;

namespace Aspect.Domain.Models.IdentityApi
{
    public class GenerateUserTokenResponse
    {
        public string Token { get; set; }
        public string RefreshToken { get; set; }
        public IEnumerable<UserResultParameter> UserResults { get; set; }
        public IEnumerable<UserUnsuccessfulLogin> UserUnsuccessfulLogin { get; set; }
    }
}
