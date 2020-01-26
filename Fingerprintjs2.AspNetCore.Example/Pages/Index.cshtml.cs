using Microsoft.AspNetCore.Mvc.RazorPages;
using Fingerprintjs2.AspNetCore;

namespace Fingerprintjs2.AspNetCore.Example.Pages
{
    public class IndexModel : PageModel
    {
        private readonly IRecaptchaService _recaptcha;

        public IndexModel(IRecaptchaService recaptcha)
        {
            _recaptcha = recaptcha;
        }

        public string Fingerprint { get; set; }

        public void OnGet()
        {
        }

        public void OnPost()
        {
            Fingerprint = _recaptcha.Validate(Request);
        }
    }
}
