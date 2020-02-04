using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Build.Tasks.Deployment.Bootstrapper;
using Newtonsoft.Json;
using WebApi.Models;

namespace WebApi.Services
{
 public   class ApiHelper 
    {


        public static async Task<List<PhotoAlbum>> GetAll()
        {
           List<PhotoAlbum>  photo;
            using (HttpClient httpClient = new HttpClient())
            {

               

                    try
                    {
                        var response =
                            await httpClient.GetAsync("https://api.unsplash.com/photos/?client_id=e4555b6c8bcca1b4bb335e2ad77885519b4badb665980d1e74bb4a588689e503");
                        
                        //response.Version = new Version("V1");

                        Console.WriteLine(response.EnsureSuccessStatusCode());
                        var Content = await response.Content.ReadAsStringAsync();
                        photo = JsonConvert.DeserializeObject<List<PhotoAlbum>>(Content);
                       
                }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                        throw;
                    }


            }

            return photo;
        }

        

        
    }
}
