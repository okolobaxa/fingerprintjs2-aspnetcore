using Microsoft.AspNetCore.Http;

namespace Fingerprintjs2.AspNetCore
{
    public interface IRecaptchaService
    {
        string Validate(HttpRequest request);
    }
}
