using Fingerprintjs2.AspNetCore.Models;

namespace Fingerprintjs2.AspNetCore.Templates
{
    public partial class Template
    {
        private Model Model { get; }

        public Template(Model model)
        {
            Model = model;
        }
    }
}
