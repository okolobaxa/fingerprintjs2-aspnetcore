using Microsoft.AspNetCore.Http;

namespace Fingerprintjs2.AspNetCore
{
    public interface IFingerprintProvider
    {
        string Get(HttpRequest request);
    }
}
