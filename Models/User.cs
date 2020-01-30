using System.Collections.Generic;
using Newtonsoft.Json.Linq;

namespace MyApiCall.Models
{
    public class User
    {
        public List<JObject> data = new List<JObject>();
    }
}