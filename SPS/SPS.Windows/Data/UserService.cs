using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using static System.Net.WebRequestMethods;

namespace SPS.Windows.Data
{
    public class UserService
    {
        public Task<List<User>> GetUserDataAsync()
        {
            HttpClient client = new HttpClient();
            var data = client.GetFromJsonAsync<List<User>>("https://admin.navsharsoftware.com/api/User");
            return data;
        }
    }
}
