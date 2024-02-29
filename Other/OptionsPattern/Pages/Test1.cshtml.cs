using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Options;
using OptionsPattern.Models;

namespace OptionsPattern.Pages
{
    public class Test1Model : PageModel
    {
        private readonly ComplexOptions _complexOptions;

        public Test1Model(IOptions<ComplexOptions> complexOptions)
        {
            _complexOptions = complexOptions.Value;
        }

        public ContentResult OnGet()
        {
            return Content($"#OptionName: {_complexOptions.Name}\r\n" +
                $"#OptionUrl: {_complexOptions.Url}\r\n" +
                $"#SubOptionNames: \r\n\t-{string.Join("\r\n\t-", _complexOptions.ComplexSubOptions.Select(x => x.Name))}");
        }
    }
}
