using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;

using System;
using System.ComponentModel;
using System.Text;
using System.Threading;

using Microsoft.Web.WebView2.Core;

namespace Weather.History.Pages
{
    public sealed partial class AppEventViewPage : Page, INotifyPropertyChanged
    {
        const string LogDomain = "AppEvent";

        public event PropertyChangedEventHandler PropertyChanged;

        readonly StringBuilder _content;

        public AppEventViewPage()
        {
            InitializeComponent();

            _content = new StringBuilder();
        }

        public string HtmlLog => "";//Log4.LogFilename;

        public string HtmlContent => _content.ToString();

        private void OnClick(object sender, RoutedEventArgs args)
        {
            //var e = new AppEvent("Warning message", CrossCutting.AppEventSeverity.Warning);
            //var ee = new AppEvent("Debug message", CrossCutting.AppEventSeverity.Debug);

            OnReceived();
            OnReceived();
            OnReceived();
            OnReceived();
            OnReceived();
            OnReceived();
        }

        public void OnReceived()
        {
            var div = "<div>Formttted text</div>";


#if WINDOWS
            webView.ExecuteScriptAsync("window.location.reload(true);");
            webView.ExecuteScriptAsync("window.scrollTo(0, document.body.scrollHeight);");
#endif

//#if __WASM__
            _content.Append(div);

            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(HtmlContent)));

//#endif
        }

        private void OnNavigated(WebView2 sender, CoreWebView2NavigationCompletedEventArgs arg)
        {
            sender.ExecuteScriptAsync("MinimalistView()");
        }
    }
}
