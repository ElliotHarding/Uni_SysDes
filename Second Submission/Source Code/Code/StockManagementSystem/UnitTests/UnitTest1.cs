using Microsoft.VisualStudio.TestTools.UnitTesting;
using StockManagementSystem;

namespace UnitTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestAddress()
        {
            Address address = new Address("1", "2", "3", "4");

            Assert.AreEqual(address.line1, "1");
            Assert.AreEqual(address.line2, "2");
            Assert.AreEqual(address.line3, "3");
            Assert.AreEqual(address.postCode, "4");
        }

        [TestMethod]
        public void TestProduct()
        {
            Product product = new Product("1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13");

            Assert.AreEqual(product.id, "1");
            Assert.AreEqual(product.externalId, "2");
            Assert.AreEqual(product.image, "3");
            Assert.AreEqual(product.information, "4");
            Assert.AreEqual(product.locationX, "5");
            Assert.AreEqual(product.locationY, "6");
            Assert.AreEqual(product.quantity, "7");
            Assert.AreEqual(product.expiryDate, "8");
            Assert.AreEqual(product.price, "9");
            Assert.AreEqual(product.vat, "10");
            Assert.AreEqual(product.dangerDescription, "11");
            Assert.AreEqual(product.retProductNo, "12");
            Assert.AreEqual(product.name, "13");
        }

        [TestMethod]
        public void TestShipment()
        {
            Shipment shipment = new Shipment("1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18");

            Assert.AreEqual(shipment.id, "1");
            Assert.AreEqual(shipment.supplierName, "2");
            Assert.AreEqual(shipment.supplierSiteName, "3");
            Assert.AreEqual(shipment.supplierRemitToAddress.line1, "4");
            Assert.AreEqual(shipment.supplierRemitToAddress.line2, "5");
            Assert.AreEqual(shipment.supplierRemitToAddress.line3, "6");
            Assert.AreEqual(shipment.supplierRemitToAddress.postCode, "7");
            Assert.AreEqual(shipment.orderNo, "8");
            Assert.AreEqual(shipment.orderLine, "9");
            Assert.AreEqual(shipment.orderDate, "10");
            Assert.AreEqual(shipment.requestedDate, "11");
            Assert.AreEqual(shipment.promisedDate, "12");
            Assert.AreEqual(shipment.goodsAndServicesAddress.line1, "13");
            Assert.AreEqual(shipment.goodsAndServicesAddress.line2, "14");
            Assert.AreEqual(shipment.goodsAndServicesAddress.line3, "15");
            Assert.AreEqual(shipment.goodsAndServicesAddress.postCode, "16");
            Assert.AreEqual(shipment.vat, "17");
            Assert.AreEqual(shipment.invoiceTotal, "18");            
        }

        [TestMethod]
        public void TestTransaction()
        {
            StockManagementSystem.Transaction transaction = new StockManagementSystem.Transaction("1", "2", "3", "4", "5", "6", "7", "8");

            Assert.AreEqual(transaction.id, "1");
            Assert.AreEqual(transaction.date, "2");
            Assert.AreEqual(transaction.productId, "3");
            Assert.AreEqual(transaction.quantity, "4");
            Assert.AreEqual(transaction.nNumber, "5");
            Assert.AreEqual(transaction.department, "6");
            Assert.AreEqual(transaction.price, "7");
            Assert.AreEqual(transaction.isReturn, "8");
        }

        [TestMethod]
        public void TestUser()
        {
            User user = new User("1", "2", "3", "4");

            Assert.AreEqual(user.nNumber, "1");
            Assert.AreEqual(user.password, "2");
            Assert.AreEqual(user.department, "3");
            Assert.AreEqual(user.role, "4");
        }

        //[TestMethod]
        //public void TestUserInputParagraphDialog()
        //{
        //    UserInputParagraphDialog uipd = new UserInputParagraphDialog("Test");
        //    Assert.IsNull(uipd.paragraph);
        //}

        //[TestMethod]
        //public void TestUserInputStringDialog()
        //{
        //    UserInputStringDialog uipd = new UserInputStringDialog("Test");
        //    Assert.IsNull(uipd.result);
        //}

        //[TestMethod]
        //public void TestQRCodeDisplay()
        //{
        //    try
        //    {
        //        QRCodeDisplay qRCodeDisplay = new QRCodeDisplay("code");
        //    }
        //    catch (Exception)
        //    {
        //        Assert.Fail();
        //    }           
        //}

        //[TestMethod]
        //public void TestPagesManagement()
        //{
        //    List<BaseForm> forms = new List<BaseForm>();
        //    //forms.Add()

        //    AdminSettings adminSettings = new AdminSettings();
        //    adminSettings.goToNextPage(SystemPage.AdminSettings);
        //    Assert.AreEqual(SystemPage.AdminSettings, adminSettings.getNextPage());

        //    Basket basket = new Basket();
        //    basket.goToNextPage(SystemPage.AdminSettings);
        //    Assert.AreEqual(SystemPage.AdminSettings, basket.getNextPage());

        //    ExpectedDelivery expectedDelivery = new ExpectedDelivery();
        //    expectedDelivery.goToNextPage(SystemPage.AdminSettings);
        //    Assert.AreEqual(SystemPage.AdminSettings, expectedDelivery.getNextPage());

        //    Invoices invoices = new Invoices();
        //    invoices.goToNextPage(SystemPage.AdminSettings);
        //    Assert.AreEqual(SystemPage.AdminSettings, invoices.getNextPage());

        //    Login login = new Login();
        //    login.goToNextPage(SystemPage.AdminSettings);
        //    Assert.AreEqual(SystemPage.AdminSettings, login.getNextPage());

        //    Messages messages = new Messages();
        //    messages.goToNextPage(SystemPage.AdminSettings);
        //    Assert.AreEqual(SystemPage.AdminSettings, messages.getNextPage());

        //    NewShipment newShipment = new NewShipment();
        //    newShipment.goToNextPage(SystemPage.AdminSettings);
        //    Assert.AreEqual(SystemPage.AdminSettings, newShipment.getNextPage());

        //    ProductsPage productsPage = new ProductsPage();
        //    productsPage.goToNextPage(SystemPage.AdminSettings);
        //    Assert.AreEqual(SystemPage.AdminSettings, productsPage.getNextPage());

        //    Settings settings = new Settings();
        //    settings.goToNextPage(SystemPage.AdminSettings);
        //    Assert.AreEqual(SystemPage.AdminSettings, settings.getNextPage());

        //    Shipments shipments = new Shipments();
        //    shipments.goToNextPage(SystemPage.AdminSettings);
        //    Assert.AreEqual(SystemPage.AdminSettings, shipments.getNextPage());

        //    SignUp signUp = new SignUp();
        //    signUp.goToNextPage(SystemPage.AdminSettings);
        //    Assert.AreEqual(SystemPage.AdminSettings, signUp.getNextPage());

        //    ViewProduct viewProduct = new ViewProduct();
        //    viewProduct.goToNextPage(SystemPage.AdminSettings);
        //    Assert.AreEqual(SystemPage.AdminSettings, viewProduct.getNextPage());

        //    ViewShipment viewShipment = new ViewShipment();
        //    viewShipment.goToNextPage(SystemPage.AdminSettings);
        //    Assert.AreEqual(SystemPage.AdminSettings, viewShipment.getNextPage());
        //}
    }
}
