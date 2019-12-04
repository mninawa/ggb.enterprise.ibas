using Newtonsoft.Json;

namespace graphservice.api.Models
{
    public class InputClaimsModel
    {
        public string personId { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public string mobile { get; set; }
        public string userid { get; set; }
        public string otp { get; set; }
        public string passport { get; set; }
        public string dependant { get; set; }

        public string memberno { get; set; }

        public string body { get; set; }


        public override string ToString()
        {
            return JsonConvert.SerializeObject(this);
        }
    }

}