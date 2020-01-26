using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc.Rendering;
using Fingerprintjs2.AspNetCore.Templates;

namespace Fingerprintjs2.AspNetCore
{
    public static class FingerprintHtmlHelper
    {
        /// <summary>
        /// Helper extension to get user's browser fingerprint with fingerprintjs2 library.
        /// </summary>
        public static HtmlString Fingerprint(this IHtmlHelper helper)
        {
            return new HtmlString(new Template().TransformText());
        }
    }
}
