using System.Text;

namespace DesignPatterns.BuilderPattern.Method1
{
    // endpoint builder sınıfı
    public class EndpointBuilder
    {
        private readonly StringBuilder sbUrl = new();

        private readonly StringBuilder sbParams = new();

        private const char defaultDelimeter = '/';
        public string BaseUrl { get; set; }

        public EndpointBuilder(string baseUrl)
        {
            BaseUrl = baseUrl;
        }

        public EndpointBuilder Append(string value)
        {
            // localhost/api/v1/user
            sbUrl.Append(value);
            sbUrl.Append(defaultDelimeter);
            return this;
        }

        public EndpointBuilder AppendParam(string name, string value)
        {
            // localhost/api/v1/user?[id=5]
            sbParams.AppendFormat("{0}={1}&", name, value);
            return this;
        }

        public string Build()
        {
            if (BaseUrl.EndsWith(defaultDelimeter))
                sbUrl.Insert(0, BaseUrl);
            else
                sbUrl.Insert(0, BaseUrl + defaultDelimeter);
            // localhost/api/v1/user
            var url = sbUrl.ToString().TrimEnd('&');

            if (sbParams.Length > 0)
            {
                string qParams = sbParams.ToString().TrimEnd('&');
                url = sbUrl.ToString().TrimEnd(defaultDelimeter).Trim('?');

                url = $"{url}?{qParams}";
            }

            return url.TrimEnd(defaultDelimeter);
        }
    }
}