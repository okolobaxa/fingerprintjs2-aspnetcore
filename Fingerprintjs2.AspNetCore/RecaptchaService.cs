using System.ComponentModel.DataAnnotations;
using System.Linq;
using Microsoft.AspNetCore.Http;

namespace Fingerprintjs2.AspNetCore
{
    public class RecaptchaService : IRecaptchaService
    {
        public string Validate(HttpRequest request)
        {
            if (!request.Form.ContainsKey("f-fingerprint")) // error if no reason to do anything, this is to alert developers they are calling it without reason.
                throw new ValidationException("Google recaptcha response not found in form. Did you forget to include it?");

            var response = request.Form["f-fingerprint"];

            return response.FirstOrDefault();
        }
    }
}
