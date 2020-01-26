using System;
using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc.Rendering;
using Fingerprintjs2.AspNetCore.Models;
using Fingerprintjs2.AspNetCore.Templates;

namespace Fingerprintjs2.AspNetCore
{
    public static class FingerprintHtmlHelper
    {
        /// <summary>
        /// Helper extension to get user's browser fingerprint with fingerprintjs2 library.
        /// </summary>
        /// <param name="helper">Html helper object.</param>
        /// <param name="libraryUrl">Url to fingerprintjs2 if used via CDN</returns>
        /// <param name="id">Id of hidden input</returns>
        public static HtmlString Fingerprint(this IHtmlHelper helper, string libraryUrl, string id = "f-fingerprint")
        {
            if (string.IsNullOrEmpty(id))
                throw new ArgumentException("id can't be null");

            if (id.ToLower() == "submit")
                throw new ArgumentException("id can't be named submit");

            return new HtmlString(new Template(new Model()
            {
                Id = id,
                LibraryUrl = libraryUrl,
            }).TransformText());
        }
    }
}
