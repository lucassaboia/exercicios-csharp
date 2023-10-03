using Balta.SharedContext;

namespace Balta.ContentContext
{
    public abstract class Content : Base
    {
        public Content(string title, string url)
        {
            Title = title;
            Url = url;
        }
        public string Url { get; set; }

        public string Title { get; set; }
    }
}