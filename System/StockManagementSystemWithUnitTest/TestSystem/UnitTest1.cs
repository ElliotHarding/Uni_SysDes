using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StockManagementSystem;
using System.Collections.Generic;
using StockManagementSystem.Pages;
using System.Drawing;

namespace TestSystem
{
    [TestClass]
    public class UnitTest1
    {
        public Product product1 = new Product(null);//"123", "321", "lol.jpg", "ayy", "101.100", "982.100", "8", "01/01/2020", "10", "23412", "flamable", "0900", "choco");

        public Product product2 = new Product(null);//"103", "3521", "lel.jpg", "aye", "101.110", "982.101", "5", "01/03/2020", "20", "73412", "flamable", "0901", "chocolate");

        
        [TestMethod]
        public void test(int i)
        {
            int excepted = 5;
            Assert.AreEqual(i, excepted);
        }
        //OK
        [TestMethod]
        public void NewShipmentUpdateQuantity()
        {
            try
            {
                DatabaseComms.updateProductQuantity(TestUpdateProductQuantityCallback, "5", "id = '" + product1.id + "'");
            }
            catch (Exception f)
            {
                Assert.Fail();
            }
        }

        private void TestUpdateProductQuantityCallback(bool success)
        {
            Assert.IsTrue(success);
        }

        //OK
        [TestMethod]
        public void UploadProduct()
        {
            List<Product> pList = new List<Product>();
            pList.Add(product1);
            pList.Add(product2);

            try
            {
                DatabaseComms.uploadProducts(pList, testUploadProduct);
            }
            catch (Exception f)
            {
                Assert.Fail();
            }
        }

        private void testUploadProduct(bool success)
        {
            Assert.IsTrue(success);
        }

        //OK?
        [TestMethod]
        public void GetProducts()
        {
            NewShipment newShipment = new NewShipment();

            Exception e = null;

            try
            {
                DatabaseComms.getProducts(testGetProductsCallback);
            }
            catch (Exception f)
            {
                Assert.Fail();
            }
        }

        private void testGetProductsCallback(List<Product> products)
        {
            //Assert.AreEqual(/*?*/,products);
        }

        //OK?
        [TestMethod]
        public void GetDepts()
        {
            try
            {
                DatabaseComms.getDepartments(textGetDepartmentsCallback);
            }
            catch (Exception f)
            {
                Assert.Fail();
            }
        }

        private void textGetDepartmentsCallback(List<String> depts)
        {
            //Assert.AreEqual(/*?*/, depts);
        }

        //OK
        [TestMethod]
        public void UploadUser()
        {
            AdminSettings admin = new AdminSettings();
            User user = new User("356", "53454", "cs", "customer");

            Exception e = null;

            try
            {
                DatabaseComms.uploadUser(user, testUploadUserCallBack);
            }
            catch (Exception f)
            {
                Assert.Fail();
            }
        }

        private void testUploadUserCallBack(bool success)
        {
            Assert.IsTrue(success);
        }

        //OK
        [TestMethod]
        public void SetDepts()
        {
            List<String> depts = new List<string>();
            depts.Add("cs");
            depts.Add("math");

            try
            {
                DatabaseComms.setDepartments(depts, testUploadDepartmentsCallback);
            }
            catch (Exception f)
            {
                Assert.Fail();
            }
        }

        private void testUploadDepartmentsCallback(bool success)
        {
            Assert.IsTrue(success);
        }

        //OK
        [TestMethod]
        public void UpdateUser()
        {
            AdminSettings admin = new AdminSettings();
            User user = new User("356", "53454", "cs", "customer");

            try
            {
                DatabaseComms.updateUser(user, testUpdateUserCallback);
            }
            catch (Exception f)
            {
                Assert.Fail();
            }
        }

        private void testUpdateUserCallback(bool success)
        {
            Assert.IsTrue(success);
        }

        //OK
        [TestMethod]
        public void UploadShipment()
        {
            Shipment shipment = new Shipment("123", "ayy", "ayy.com", "3fa", "24saf", "234dfs", "34af",
                "234", "234a", "1/11/2020", "4/2/2019", "12/2/2020", "2432f", "234234", "243", "865", "gsdfg", "754");

            try
            {
                DatabaseComms.uploadShipment(shipment, testAddShipmentCallback);
            }
            catch (Exception f)
            {
                Assert.Fail();
            }
        }

        private void testAddShipmentCallback(bool success)
        {
            Assert.IsTrue(success);
        }

        //OK
        [TestMethod]
        public void UpdateShipment()
        {
            Shipment shipment = new Shipment("123", "ayy", "ayy.com", "3fa", "24saf", "234dfs", "34af",
                "234", "234a", "1/11/2020", "4/2/2019", "12/2/2020", "2432f", "234234", "243", "865", "gsdfg", "754");

            try
            {
                DatabaseComms.uploadShipment(shipment, testUpdateShipmentCallback);
            }
            catch (Exception f)
            {
                Assert.Fail();
            }
        }

        private void testUpdateShipmentCallback(bool success)
        {
            Assert.IsTrue(success);
        }


        [TestMethod]
        public void NewShipmentUpdateQuantities()
        {
            List<Transation> transations = new List<Transation>();
            transations.Add(new Transation("3243", "01/02/2003", "131", "2", "3432", "cs", "12", "1"));
            List<Product> products = new List<Product>();
            products.Add(product1);

            Exception e = null;

            try
            {
                DatabaseComms.updateProductQuantities(testReturnItemsCallback, products, transations);
            }
            catch (Exception)
            {
                Assert.Fail();
            }
        }

        private void testReturnItemsCallback(bool success)
        {
            Assert.IsTrue(success);
        }

        //OK?
        [TestMethod]
        public void GetScannedProduct()
        {
            try
            {
                DatabaseComms.getScannedProduct("3242", testGetScannedProductCallback);
            }
            catch (Exception f)
            {
                Assert.Fail();
            }
        }

        private void testGetScannedProductCallback(Product p)
        {
            Product expected = new Product(null);

            Assert.AreEqual(p, expected);
        }

        //OK
        [TestMethod]
        public void GetTransactions()
        {
            try
            {
                DatabaseComms.getTransations(testTransactionsCallback);
            }
            catch (Exception f)
            {
                Assert.Fail();
            }
        }

        private void testTransactionsCallback(List<Transation> transations)
        {
            List<Transation> expected = new List<Transation>();
            Assert.AreEqual(transations, expected); 
        }

        //OK?
        [TestMethod]
        public void GetUsers()
        {
            try
            {
                DatabaseComms.getUsers(testLoginCallback);
            }
            catch (Exception f)
            {
                Assert.Fail();
            }
        }

        private void testLoginCallback(List<User> users)
        {
            List<User> expected = new List<User>();
            Assert.AreEqual(users, expected);

        }

        [TestMethod]
        public void ResetPassword()
        {
            try
            {
                DatabaseComms.resetUserPassword(getForgottenPasswordCallback, "23432", "lololol");
            }
            catch (Exception f)
            {
               Assert.Fail();
            }
        }

        private void getForgottenPasswordCallback(bool success)
        {
            Assert.IsTrue(success);
        }

        //OK?
        [TestMethod]
        public void GetShipments()
        {
            try
            {
                DatabaseComms.getShipments(testShipment);
            }
            catch (Exception f)
            {
                Assert.Fail();
            }
        }

        private void testShipment(List<Shipment> shipments)
        {
            List<Shipment> expected = new List<Shipment>();
            Assert.AreEqual(shipments, expected);
        }

        //OK
        [TestMethod]
        public void UpdateProduct()
        {
            try
            {
                DatabaseComms.updateProduct(product1, testOnUpdateProductRequest);
            }
            catch (Exception f)
            {
                Assert.Fail();
            }
        }

        private void testOnUpdateProductRequest(bool success)
        {
            Assert.IsTrue(success);
        }

        [TestMethod]
        public void RemoveProduct()
        {
            try
            {
                DatabaseComms.query("DELETE FROM PRODUCTS WHERE id = '" + product1.id + "';", testRemoveProductCallback);
            }
            catch (Exception f)
            { 
                Assert.Fail();
            }
        }

        private void testRemoveProductCallback(bool success)
        {
            Assert.IsTrue(success);
        }

        [TestMethod]
        public void SendEmail()
        {
            StockManagementSystem.Classes.Tools tools = new StockManagementSystem.Classes.Tools();

            bool expected = true;

            bool result = tools.sendEmail(null, "wut up?", new string[] { "ayy" });

            Assert.AreEqual(expected, result);
        }
    }
}
