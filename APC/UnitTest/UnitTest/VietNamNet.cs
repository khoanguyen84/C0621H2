using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace UnitTest
{
    public class VietNamNet
    {
        public Hashtable NewsList = new Hashtable();
        public int InsertNews(News news)
        {
            int max = 0;
            foreach(int key in NewsList.Keys)
            {
                if (key > max)
                    max = key;
            }
            news.Id = max + 1;
            NewsList.Add(news.Id, news);
            return news.Id;
        }
    }
}
