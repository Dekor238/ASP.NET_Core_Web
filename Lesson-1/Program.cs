using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Lesson_1
{
    class Program
    {
        private static readonly HttpClient client = new HttpClient();
        private static readonly string file = "result.txt";

        public static async Task Main(string[] args)
        {
            File.Delete(file);
            File.Create(file);
            
            Console.WriteLine("-------- BEGIN GET API --------");
            
            var task1 = GetPostAsync(4);
            var task2 = GetPostAsync(5);
            var task3 = GetPostAsync(6);
            var task4 = GetPostAsync(7);
            var task5 = GetPostAsync(8);
            var task6 = GetPostAsync(9);
            var task7 = GetPostAsync(10);
            var task8 = GetPostAsync(11);
            var task9 = GetPostAsync(12);
            var task10 = GetPostAsync(13);

            var tasks = new List<Task<string>>();
            tasks.AddRange(new []{task1, task2, task3, task4, task5, task6, task7, task8, task9, task10});
            await Task.WhenAll(tasks);
            var d = 1;
            tasks.ForEach(t => { File.AppendAllText(file,t.Result); });

            Console.WriteLine();
            Console.WriteLine("-------- END --------");
        }

        public static async Task<string> GetPostAsync(int id)
        {
            string url = $"https://jsonplaceholder.typicode.com/posts/{id}";
            var response = await client.GetAsync(url);
            var cont = response.Content.ReadFromJsonAsync<Post>().Result;
            return cont.ToString();
        }
    }

    internal class Post
    {
        public int userId { get; set; }
        public int id { get; set; }
        public string title { get; set; }
        public string body { get; set; }
        
        public override string ToString()
        {
            return $"{userId}\n{id}\n{title}\n{body}\r\n\n";
        }
    }
}