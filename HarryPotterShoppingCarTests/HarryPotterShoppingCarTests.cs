using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace HarryPotterShoppingCar.Tests
{
    [TestClass()]
    public class HarryPotterShoppingCarTests
    {
        [TestMethod()]
        public void HarryPotterShoppingCarTest_buy_BookName_1_BookCount_1_Total_100()
        {
            List<Product> BookLists = new List<Product>()
            {
             new Product(){ BookName = "HarryPotter1",BookCount = 1}
            };
            int price = 100;

            var Total = 100;

            //act
            var actual = BookLists[0].BookCount * price;

            //assert
            Assert.AreEqual(Total, actual);
        }

        [TestMethod()]
        public void HarryPotterShoppingCarTests_buy_Book1_1_Book2_1_Total_190()
        {
            var target = new HarryPotterShoppingCar();
            List<Product> BookLists = new List<Product>()
            {
             new Product(){ BookName = "HarryPotter1",BookCount = 1}
             , new Product(){ BookName = "HarryPotter2",BookCount = 1}
            };
            int price = 100;

            var Total = 190;

            var actual = target.ShoppingCar(BookLists, price);

            Assert.AreEqual(Total, actual);
        }

        [TestMethod()]
        public void HarryPotterShoppingCarTests_buy_Book1_1_Book2_1_Book3_1_Total_270()
        {
            var target = new HarryPotterShoppingCar();
            List<Product> BookLists = new List<Product>()
            {
             new Product(){ BookName = "HarryPotter1",BookCount = 1}
             , new Product(){ BookName = "HarryPotter2",BookCount = 1}
             , new Product(){ BookName = "HarryPotter3",BookCount = 1}
            };
            int price = 100;

            var Total = 270;

            var actual = target.ShoppingCar(BookLists, price);

            Assert.AreEqual(Total, actual);
        }

        [TestMethod()]
        public void HarryPotterShoppingCarTests_buy_Book1_1_Book2_1_Book3_1_Book4_1_Total_320()
        {
            var target = new HarryPotterShoppingCar();
            List<Product> BookLists = new List<Product>()
            {
             new Product(){ BookName = "HarryPotter1",BookCount = 1}
             , new Product(){ BookName = "HarryPotter2",BookCount = 1}
             , new Product(){ BookName = "HarryPotter3",BookCount = 1}
             , new Product(){ BookName = "HarryPotter4",BookCount = 1}
            };
            int price = 100;

            var Total = 320;

            var actual = target.ShoppingCar(BookLists, price);

            Assert.AreEqual(Total, actual);
        }

        [TestMethod()]
        public void HarryPotterShoppingCarTests_buy_Book1_1_Book2_1_Book3_1_Book4_1_Book5_1_Total_375()
        {
            var target = new HarryPotterShoppingCar();
            List<Product> BookLists = new List<Product>()
            {
             new Product(){ BookName = "HarryPotter1",BookCount = 1}
             , new Product(){ BookName = "HarryPotter2",BookCount = 1}
             , new Product(){ BookName = "HarryPotter3",BookCount = 1}
             , new Product(){ BookName = "HarryPotter4",BookCount = 1}
             , new Product(){ BookName = "HarryPotter5",BookCount = 1}
            };
            int price = 100;

            var Total = 375;

            var actual = target.ShoppingCar(BookLists, price);

            Assert.AreEqual(Total, actual);
        }

        [TestMethod()]
        public void HarryPotterShoppingCarTests_buy_Book1_1_Book2_1_Book3_Book5_1_Total_375()
        {
            var target = new HarryPotterShoppingCar();
            List<Product> BookLists = new List<Product>()
            {
             new Product(){ BookName = "HarryPotter1",BookCount = 1}
             , new Product(){ BookName = "HarryPotter2",BookCount = 1}
             , new Product(){ BookName = "HarryPotter3",BookCount = 2}
            };
            int price = 100;

            var Total = 370;

            var actual = target.ShoppingCar(BookLists, price);

            Assert.AreEqual(Total, actual);
        }

        [TestMethod()]
        public void HarryPotterShoppingCarTests_buy_Book1_1_Book2_2_Book3_Total_375()
        {
            var target = new HarryPotterShoppingCar();
            List<Product> BookLists = new List<Product>()
            {
             new Product(){ BookName = "HarryPotter1",BookCount = 1}
             , new Product(){ BookName = "HarryPotter2",BookCount = 2}
             , new Product(){ BookName = "HarryPotter3",BookCount = 2}
            };
            int price = 100;

            var Total = 460;

            var actual = target.ShoppingCar(BookLists, price);

            Assert.AreEqual(Total, actual);
        }
    }
}