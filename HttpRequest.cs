using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns {
    public class HttpRequest {
        public string URL     { get; private set; }
        public string Method  { get; private set; }
        public string Headers { get; private set; }
        public string Body    { get; private set; }

        public class Builder {
            private HttpRequest _request = new HttpRequest();

            public Builder SetURL(string url) {
                _request.URL = url;
                return this;
            }

            public Builder SetMethod(string method) {
                _request.Method = method;
                return this;
            }

            public Builder SetHeaders(string headers) {
                _request.Headers = headers;
                return this;
            }

            public Builder SetBody(string body) {
                _request.Body = body;
                return this;
            }

            public HttpRequest Build() {
                return _request;
            }
        }
    }
}
