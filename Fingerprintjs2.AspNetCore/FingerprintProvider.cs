using System.ComponentModel.DataAnnotations;
using System.Linq;
using Microsoft.AspNetCore.Http;

namespace Fingerprintjs2.AspNetCore
{
    public class FingerprintProvider : IFingerprintProvider
    {
        public string Get(HttpRequest request)
        {
            if (!request.Form.ContainsKey("f-fingerprint"))
            {
                throw new ValidationException("Fingerprint not found in form. Did you forget to include it?");
            }

            var response = request.Form["f-fingerprint"];

            return response.FirstOrDefault();
        }
    }
}
