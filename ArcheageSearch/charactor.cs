using Newtonsoft.Json;
using System;
using System.Net;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Windows.Forms;
using HtmlAgilityPack;


namespace ArcheageSearch
{
    class Charactor
    {
        private const string SEARCH_URI = "https://archeage.xlgames.com/";

        private static WebBrowser mWebBrowser;

        public Charactor(WebBrowser webBrowser)
        {
            mWebBrowser = webBrowser;
        }

        public async static void GetCharactor(string Name)
        {
            var httpClient = new HttpClient();

            string WebUrl = SEARCH_URI;
            httpClient.BaseAddress = new Uri(WebUrl);

            var response = await httpClient.GetAsync($"search?dt=characters&keyword={Name}&server=HAJE").ConfigureAwait(false);
            string contentDetailsString = await response.Content.ReadAsStringAsync();

            HtmlAgilityPack.HtmlDocument pageDocument = new HtmlAgilityPack.HtmlDocument();
            pageDocument.LoadHtml(contentDetailsString);

            IList<HtmlNode> headlineText = pageDocument.DocumentNode.QuerySelectorAll("#container-common>div>div>div.view>div>ul>li");

        }
    }
}
