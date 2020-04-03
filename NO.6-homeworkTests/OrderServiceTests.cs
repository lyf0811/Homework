using Microsoft.VisualStudio.TestTools.UnitTesting;
using NO._5_homework1;
using System;
using System.Collections.Generic;
using System.Text;

namespace NO._5_homework1.Tests
{
    [TestClass()]
    public class OrderServiceTests
    {

        OrderService a = new OrderService();
        [TestMethod()]
        public void addorderTest()
        {
            int ordernum = 184;
            int orderamount = 4332000;
            string goodsname = "电脑";
            string customer = "甲方";
            string[] information = { "100台hp笔记本", "100台联想电脑" };
            a.addorder(ordernum, orderamount, goodsname, customer, information);
            // Assert.Fail();
        }

        [TestMethod()]
        public void deleteorderTest()
        {
            int ordernum = 124;
            a.deleteorder(ordernum);

        }

        [TestMethod()]
        public void modifyorderTest()
        {
            int num = 0;
            int ordernum = 184;
            int orderamount = 4332000;
            string goodsname = "电脑";
            string customer = "甲方";
            string[] information = { "100台hp笔记本", "100台联想电脑" };
            a.addorder(ordernum, orderamount, goodsname, customer, information);
            int ordernum1 = 184;
            int orderamount1 = 7562000;
            string goodsname1 = "服务器";
            string customer1 = "乙方";
            a.modifyorder(num, ordernum1, orderamount1, goodsname1, customer1);
        }

        [TestMethod()]
        public void searchorderTest()
        {
            int funcnum = 2;
            a.searchorder(funcnum);

        }

        [TestMethod()]
        public void ExportTest()
        {

        }

        [TestMethod()]
        public void ImportTest()
        {

        }
    }
}