using System.Net;
using System.Reflection;

namespace ggb.enterprise.ibas.api.Models
{
    public class ResponseContent
    {
        public string version { get; set; }
        public int status { get; set; }
        public string userMessage { get; set; }

        public ResponseContent(string message, HttpStatusCode status)
        {
            this.userMessage = message;
            this.status = (int)status;
            this.version = Assembly.GetExecutingAssembly().GetName().Version.ToString();
        }
    }

}