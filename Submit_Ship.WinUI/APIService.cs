using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Flurl.Http;
using Flurl;
using System.Windows.Forms;
using Submit_Ship.Model;
namespace Submit_Ship.WinUI
{
    public class APIService
    {
        public static string Username { get; set; }
        public static string Password { get; set; }
        public static int Id { get; set; }
        public static string Uloga { get; set; }

        private string _route = null;


        public APIService(string route)
        {
            _route = route;
        }

        public async Task<T> Get<T>(object search)
        {
            var url = $"{Properties.Settings.Default.APIUrl}/{_route}";
       
            try
            {
                if(search != null)
                {
                    url += "?";
                    url += await search.ToQueryString();
                }
                return await url.WithBasicAuth(Username, Password).GetJsonAsync<T>();
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        public async Task<T> GetById<T>(object id)
        {
            var result = await $"{Properties.Settings.Default.APIUrl}/{_route}/{id}".WithBasicAuth(Username, Password).GetJsonAsync<T>();
            return result;
        }

        public async Task<T> Insert<T>(object request)
        {
            var url  =  $"{Properties.Settings.Default.APIUrl}/{_route}";
            return await url.WithBasicAuth(Username, Password).PostJsonAsync(request).ReceiveJson<T>();


        }

        public async Task<T> Update<T>(object id, object request)
        {
            var url = $"{Properties.Settings.Default.APIUrl}/{_route}/{id}";
            return await url.WithBasicAuth(Username, Password).PutJsonAsync(request).ReceiveJson<T>();


        }
    }
}
