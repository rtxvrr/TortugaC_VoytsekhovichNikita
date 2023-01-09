using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using TortugaC_VoytsekhovichNikita.ClassHepler;

namespace TortugaCTestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TotalPrice_TrueDataOneProduct_True()
        {
            //avg
            TortugaC_VoytsekhovichNikita.EF.Product prd = new TortugaC_VoytsekhovichNikita.EF.Product();
            prd.Price = 100;
            List<TortugaC_VoytsekhovichNikita.EF.Product> products = new List<TortugaC_VoytsekhovichNikita.EF.Product>();
            products.Add(prd);
            string RealResult = "100";
            //act
            string FactialResult = WhiteSaturday.totalPrice(products);
            //assert
            Assert.AreEqual(RealResult, FactialResult);
        }
        [TestMethod]
        public void TotalPrice_FalseDataOneProduct_False()
        {
            //avg
            TortugaC_VoytsekhovichNikita.EF.Product prd = new TortugaC_VoytsekhovichNikita.EF.Product();
            prd.Price = -0;
            List<TortugaC_VoytsekhovichNikita.EF.Product> products = new List<TortugaC_VoytsekhovichNikita.EF.Product>();
            products.Add(prd);
            string RealResult = "0";
            //act
            string FactialResult = WhiteSaturday.totalPrice(products);
            //assert
            Assert.AreEqual(RealResult, FactialResult);
        }
        [TestMethod]
        public void TotalPrice_NoDataNoProducts_True()
        {
            //avg
            TortugaC_VoytsekhovichNikita.EF.Product prd = new TortugaC_VoytsekhovichNikita.EF.Product();
            prd.Price = 100;
            List<TortugaC_VoytsekhovichNikita.EF.Product> products = new List<TortugaC_VoytsekhovichNikita.EF.Product>();
            //products.Add(prd);
            string RealResult = "0";
            //act
            string FactialResult = WhiteSaturday.totalPrice(products);
            //assert
            Assert.AreEqual(RealResult, FactialResult);
        }
        [TestMethod]
        public void TotalPrice_ZeroPriceOneProduct_True()
        {
            //avg
            TortugaC_VoytsekhovichNikita.EF.Product prd = new TortugaC_VoytsekhovichNikita.EF.Product();
            prd.Price = 0;
            List<TortugaC_VoytsekhovichNikita.EF.Product> products = new List<TortugaC_VoytsekhovichNikita.EF.Product>();
            products.Add(prd);
            string RealResult = "0";
            //act
            string FactialResult = WhiteSaturday.totalPrice(products);
            //assert
            Assert.AreEqual(RealResult, FactialResult);
        }
        [TestMethod]
        public void TotalPrice_MinusPriceOneProd_True()
        {
            //avg
            TortugaC_VoytsekhovichNikita.EF.Product prd = new TortugaC_VoytsekhovichNikita.EF.Product();
            prd.Price = -100;
            List<TortugaC_VoytsekhovichNikita.EF.Product> products = new List<TortugaC_VoytsekhovichNikita.EF.Product>();
            products.Add(prd);
            string RealResult = "0";
            //act
            string FactialResult = WhiteSaturday.totalPrice(products);
            //assert
            Assert.AreEqual(RealResult, FactialResult);
        }
        [TestMethod]
        public void TotalPrice_TrueDataTwoProduct_True()
        {
            //avg
            TortugaC_VoytsekhovichNikita.EF.Product prd = new TortugaC_VoytsekhovichNikita.EF.Product();
            TortugaC_VoytsekhovichNikita.EF.Product prd2 = new TortugaC_VoytsekhovichNikita.EF.Product();
            prd.Price = 100;
            prd2.Price = 150;
            List<TortugaC_VoytsekhovichNikita.EF.Product> products = new List<TortugaC_VoytsekhovichNikita.EF.Product>();
            products.Add(prd);
            products.Add(prd2);
            string RealResult = "250";
            //act
            string FactialResult = WhiteSaturday.totalPrice(products);
            //assert
            Assert.AreEqual(RealResult, FactialResult);
        }
        [TestMethod]
        public void TotalPrice_OnePriceGoodOnePriceMinusTwoProduct_True()
        {
            //avg
            TortugaC_VoytsekhovichNikita.EF.Product prd = new TortugaC_VoytsekhovichNikita.EF.Product();
            TortugaC_VoytsekhovichNikita.EF.Product prd2 = new TortugaC_VoytsekhovichNikita.EF.Product();
            prd.Price = 100;
            prd2.Price = -50;
            List<TortugaC_VoytsekhovichNikita.EF.Product> products = new List<TortugaC_VoytsekhovichNikita.EF.Product>();
            products.Add(prd);
            products.Add(prd2);
            string RealResult = "50";
            //act
            string FactialResult = WhiteSaturday.totalPrice(products);
            //assert
            Assert.AreEqual(RealResult, FactialResult);
        }
        [TestMethod]
        public void TotalPrice_TwoPriceMinusOneGoodThreeProduct_True()
        {
            //avg
            TortugaC_VoytsekhovichNikita.EF.Product prd = new TortugaC_VoytsekhovichNikita.EF.Product();
            TortugaC_VoytsekhovichNikita.EF.Product prd2 = new TortugaC_VoytsekhovichNikita.EF.Product();
            TortugaC_VoytsekhovichNikita.EF.Product prd3 = new TortugaC_VoytsekhovichNikita.EF.Product();
            prd.Price = -50;
            prd2.Price = 100;
            prd2.Price = -51;
            List<TortugaC_VoytsekhovichNikita.EF.Product> products = new List<TortugaC_VoytsekhovichNikita.EF.Product>();
            products.Add(prd);
            products.Add(prd2);
            products.Add(prd3);
            string RealResult = "0";
            //act
            string FactialResult = WhiteSaturday.totalPrice(products);
            //assert
            Assert.AreEqual(RealResult, FactialResult);
        }
    }
}
