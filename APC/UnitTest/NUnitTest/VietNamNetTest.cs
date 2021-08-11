using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using UnitTest;

namespace NUnitTest
{
    class VietNamNetTest
    {
        private VietNamNet vietNameNet;
        [SetUp]
        public void Setup()
        {
            vietNameNet = new VietNamNet();
        }

        [Test]
        public void Test_InsertNew_01()
        {
            var news = new News()
            {
                Title = "C#",
                Author = "Khoa",
                Content = "C#",
                PublishDate = DateTime.Parse("2021-10-10"),
                RateList = new int[] { 4, 5, 3 }
            };
            var latestId = vietNameNet.InsertNews(news);

            Assert.AreEqual(vietNameNet.NewsList.Count, latestId);
        }
    }
}
