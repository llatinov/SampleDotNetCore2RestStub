using System.Net;

namespace SampleDotNetCore2RestStub.Integration.Test.Client
{
    public class ApiResponse<T>
    {
        public HttpStatusCode StatusCode { get; set; }
        public T Result { get; set; }
        public string ResultAsString { get; set; }
    }
}