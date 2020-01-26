using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Fingerprintjs2.AspNetCore.Example.Pages
{
    public class IndexModel : PageModel
    {
        private readonly IFingerprintProvider _fingerprintProvider;

        public IndexModel(IFingerprintProvider fingerprintProvider)
        {
            _fingerprintProvider = fingerprintProvider;
        }

        public string Fingerprint { get; set; }

        public void OnGet()
        {
        }

        public void OnPost()
        {
            Fingerprint = _fingerprintProvider.Get(Request);
        }
    }
}
