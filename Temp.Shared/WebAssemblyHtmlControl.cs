using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Markup;

namespace Weather.History.Control
{
    [ContentProperty(Name = nameof(HtmlContent))]
    public class WebAssemblyHtmlControl : FrameworkElement
    {
        string _html;

        public WebAssemblyHtmlControl()
        {

        }

        public string HtmlContent
        {
            get => _html;
            set
            {
#if __WASM__
                this.SetHtmlContent(value);
#endif
                _html = value;
            }
        }
    }
}