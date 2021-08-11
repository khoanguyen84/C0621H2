using System;

namespace UnitTest
{
    class Program
    {
        public static VietNamNet vietNamNet = new VietNamNet();
        static void Main(string[] args)
        {
            Console.Write("Enter title:");
            var title = Console.ReadLine();
            Console.Write("Enter author:");
            var author = Console.ReadLine();
            Console.Write("Enter publish date:");
            var publishDate = DateTime.Parse(Console.ReadLine());
            Console.Write("Enter content:");
            var content = Console.ReadLine();
            var news = new News()
            {
                Title = title,
                Author = author,
                Content = content,
                PublishDate = publishDate,
                RateList = new int[] { 4, 5, 2 }
            };
            Console.WriteLine(vietNamNet.InsertNews(news));
        }
    }
}
