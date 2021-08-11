using System;
using System.Collections.Generic;
using System.Text;

namespace UnitTest
{
    public class News : INews
    {
        //public int Id { get => Id; set => Id =value; }
        //public string Title { get => Title; set => Title = value; }
        //public DateTime PublishDate { get => PublishDate; set => PublishDate = value; }
        //public string Author { get => Author; set => Author = value; }
        //public string Content { get => Content; set => Content = value; }
        public int Id { get; set; }
        public string Title { get; set; }
        public DateTime PublishDate { get; set; }
        public string Author { get; set; }
        public string Content { get; set; }
        public double AverageRate => Calculate();
        
        public int[] RateList = new int[3];
        public double Calculate()
        {
            double total = 0;
            for(int i=0; i<RateList.Length; i++)
            {
                total += RateList[i];
            }
            return total / RateList.Length;
        }
        public void Display()
        {
            Console.WriteLine($"Title: {Title}; Publish Date: {PublishDate}; Author: {Author}; Content: {Content}; Average Rate: {AverageRate}");
        }
    }
}
