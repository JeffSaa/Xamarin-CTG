using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace PostsDemo
{
    class Service
    {

        public static async Task<List<Post>> GetPost()
        {
            HttpClient client = new HttpClient();
            var query = "http://jsonplaceholder.typicode.com/posts";
            var response = await client.GetAsync(query);
            List<Post> posts = new List<Post>();
            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();
                posts = JsonConvert.DeserializeObject<List<Post>>(content);
            }
            return posts;
        }

    }
}
