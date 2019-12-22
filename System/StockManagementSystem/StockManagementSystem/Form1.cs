using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockManagementSystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            User u = new User("n0688119", "testpassword", "department", "role");
            DatabaseComms.uploadUser(u, cb);
        }

        public void cb(bool result)
        {
            if(result)
            {
                DatabaseComms.getUsers(userCallback);
            }
        }

        public void userCallback(List<User> users)
        {
            if(users != null && users.Count() > 0)
            {
                Product product = new Product("test","test","test", "test", "test", "test", "test", "test", "test", "test", "test", "test");
                DatabaseComms.uploadProduct(product, productUploadCallback);
            }
        }

        public void productUploadCallback(bool result)
        {
            if(result)
            {
                DatabaseComms.getProducts(productCallback);
            }
        }

        public void productCallback(List<Product> products)
        {
            if (products != null && products.Count() > 0)
            {
                Transation transation = new Transation("test", "test", "test", "test", "test", "test");
                DatabaseComms.uploadTransation(transation, uploadTransactionCallback);
            }
        }
        public void uploadTransactionCallback(bool result)
        {
            if(result)
            {
                DatabaseComms.getTransations(getTransationCallback);
            }
        }

        public void getTransationCallback(List<Transation> transations)
        {
            if(transations != null && transations.Count() > 0)
            {
                ExpectedShipment expectedShipment = new ExpectedShipment("test", "test", "test", "test");
                DatabaseComms.uploadExpectedShipment(expectedShipment, uploadExpectedShipmentCallback);
            }
        }

        public void uploadExpectedShipmentCallback(bool result)
        {
            if(result)
            {
                DatabaseComms.getExpectedShipment(getExpectedShipmentCallback);
            }
        }

        public void getExpectedShipmentCallback(List<ExpectedShipment> expectedShipments)
        {
            if(expectedShipments != null && expectedShipments.Count() > 0)
            {
                Invoice invoice = new Invoice("test", "test", "test", "test", "test", "test", "test");
                DatabaseComms.uploadInvoice(invoice, uploadInvoiceCallback);
            }
        }

        public void uploadInvoiceCallback(bool result)
        {
            if(result)
            {
                DatabaseComms.getInvoices(getInvoicesCallback);
            }
        }

        public void getInvoicesCallback(List<Invoice> invoices)
        {
            if(invoices != null && invoices.Count() > 0)
            {
                Shipment shipment = new Shipment("test", "test", "test", "test", "test", "test", "test", "test", "test", "test", "test", "test", "test", "test", "test", "test", "test", "test", "test", "test", "test");
                DatabaseComms.uploadShipment(shipment, uploadShipmentCallback);
            }
        }

        public void uploadShipmentCallback(bool result)
        {
            if(result)
            {
                DatabaseComms.getShipments(getShipmentCallback);
            }
        }

        public void getShipmentCallback(List<Shipment> shipments)
        {
            if(shipments != null && shipments.Count() > 0)
            {

            }
        }
    }
}
