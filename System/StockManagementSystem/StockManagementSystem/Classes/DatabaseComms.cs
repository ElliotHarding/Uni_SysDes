using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace StockManagementSystem
{
    class DatabaseComms
    {
        private const string m_connectionString = "Data Source=den1.mssql7.gear.host;Initial Catalog=smdatabase;User ID=smdatabase;Password=Jj80-f1I!M3c";

        public static void uploadProduct(Product product, Action<bool> callback)
        {
            new Task(() => 
            {
                try
                {
                    SqlConnection connection = new SqlConnection(m_connectionString);
                    SqlCommand command = new SqlCommand("INSERT INTO PRODUCTS VALUES(" +
                        "@id,  @externalId, @image,  @information, @locationX,  @locationY, @quantity, @expiryDate, @price, @vat, @dangerDescription, @retProductNo, @name);", connection);

                    command.Parameters.AddWithValue("@id", product.id);
                    command.Parameters.AddWithValue("@externalId", product.externalId);
                    command.Parameters.AddWithValue("@image", product.image);
                    command.Parameters.AddWithValue("@information", product.information);
                    command.Parameters.AddWithValue("@locationX", product.locationX);
                    command.Parameters.AddWithValue("@locationY", product.locationY);
                    command.Parameters.AddWithValue("@quantity", product.quantity);
                    command.Parameters.AddWithValue("@expiryDate", product.expiryDate);
                    command.Parameters.AddWithValue("@price", product.price);
                    command.Parameters.AddWithValue("@vat", product.vat);
                    command.Parameters.AddWithValue("@dangerDescription", product.dangerDescription);
                    command.Parameters.AddWithValue("@retProductNo", product.retProductNo);
                    command.Parameters.AddWithValue("@name", product.name);

                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();

                    callback(true);
                }
                catch (Exception e)
                {
                    callback(false);
                }
            }).Start();
        }

        public static async void updateProduct(Product product, Action<bool> callback)
        {
            new Task(() =>
            {
                try
                {
                    SqlConnection connection = new SqlConnection(m_connectionString);
                    SqlCommand command = new SqlCommand("UPDATE PRODUCTS SET" +
                        " externalId = @externalId," +
                        " image = @image," +
                        " information = @information," +
                        " locationX = @locationX," +
                        " locationY = @locationY," +
                        " quantity = @quantity," +
                        " expiryDate = @expiryDate," +
                        " price = @price," +
                        " vat = @vat," +
                        " dangerDescription = @dangerDescription," +
                        " retProductNo = @retProductNo," +
                        " name = @name" +   
                        " WHERE id=@id;", connection);

                    command.Parameters.AddWithValue("@id", product.id);
                    command.Parameters.AddWithValue("@externalId", product.externalId);
                    command.Parameters.AddWithValue("@image", product.image);
                    command.Parameters.AddWithValue("@information", product.information);
                    command.Parameters.AddWithValue("@locationX", product.locationX);
                    command.Parameters.AddWithValue("@locationY", product.locationY);
                    command.Parameters.AddWithValue("@quantity", product.quantity);
                    command.Parameters.AddWithValue("@expiryDate", product.expiryDate);
                    command.Parameters.AddWithValue("@price", product.price);
                    command.Parameters.AddWithValue("@vat", product.vat);
                    command.Parameters.AddWithValue("@dangerDescription", product.dangerDescription);
                    command.Parameters.AddWithValue("@retProductNo", product.retProductNo);
                    command.Parameters.AddWithValue("@name", product.name);

                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();

                    callback(true);
                }
                catch (Exception e)
                {
                    callback(false);
                }
            }).Start();
        }

        public static async void getProducts(Action<List<Product>> callback, string where = null)
        {
            new Task(() =>
            {
                try
                {
                    //Prep connection to database & query for user with given id
                    SqlConnection connection = new SqlConnection(m_connectionString);
                    SqlCommand command;
                    if (where == null)
                    {
                        command = new SqlCommand("SELECT * FROM PRODUCTS;", connection);
                    }
                    else
                    {
                        command = new SqlCommand("SELECT * FROM PRODUCTS WHERE " + where + ";", connection);
                    }
                
                    //Execute connection
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    //Read results of query into list
                    List<Product> results = new List<Product>();
                    while (reader.Read())
                    {
                        results.Add(new Product(
                        reader["id"].ToString(),
                        reader["externalId"].ToString(),
                        reader["image"].ToString(),
                        reader["information"].ToString(),
                        reader["locationX"].ToString(),
                        reader["locationY"].ToString(),
                        reader["quantity"].ToString(),
                        reader["expiryDate"].ToString(),
                        reader["price"].ToString(),
                        reader["vat"].ToString(),
                        reader["dangerDescription"].ToString(),
                        reader["retProductNo"].ToString(),
                        reader["name"].ToString()
                        ));
                    }

                    connection.Close();
                    callback(results);
                }
                catch (Exception e)
                {
                    callback(null);
                }
            }).Start();
        }

        public static async void uploadInvoice(Invoice invoice, Action<bool> callback)
        {
            new Task(() =>
            {
                try
                {
                    SqlConnection connection = new SqlConnection(m_connectionString);
                    SqlCommand command = new SqlCommand("INSERT INTO INVOICES VALUES (" +
                        "@id," +
                        "@departmentId," +
                        "@productId," +
                        "@date," +
                        "@price," +
                        "@quantity," +
                        "@vat);", connection);

                    command.Parameters.AddWithValue("@id", invoice.id);
                    command.Parameters.AddWithValue("@departmentId", invoice.departmentId);
                    command.Parameters.AddWithValue("@productId", invoice.productId);
                    command.Parameters.AddWithValue("@date", invoice.date);
                    command.Parameters.AddWithValue("@price", invoice.price);
                    command.Parameters.AddWithValue("@quantity", invoice.quantitiy);
                    command.Parameters.AddWithValue("@vat", invoice.vat);

                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();

                    callback(true);
                }
                catch (Exception e)
                {
                    callback(false);
                }
            }).Start();
        }

        public static async void updateInvoice(Invoice invoice, Action<bool> callback)
        {
            new Task(() =>
            {
                try
                {
                    SqlConnection connection = new SqlConnection(m_connectionString);
                    SqlCommand command = new SqlCommand("UPDATE INVOICES SET" +
                        " departmentId = @departmentId," +
                        " productId = @productId," +
                        " date = @date," +
                        " price = @price," +
                        " quantity = @quantity," +
                        " vat = @vat; WHERE id=@id", connection);

                    command.Parameters.AddWithValue("@id", invoice.id);
                    command.Parameters.AddWithValue("@departmentId", invoice.departmentId);
                    command.Parameters.AddWithValue("@productId", invoice.productId);
                    command.Parameters.AddWithValue("@date", invoice.date);
                    command.Parameters.AddWithValue("@price", invoice.price);
                    command.Parameters.AddWithValue("@quantity", invoice.quantitiy);
                    command.Parameters.AddWithValue("@vat", invoice.vat);

                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();

                    callback(true);
                }
                catch (Exception e)
                {
                    callback(false);
                }
            }).Start();
        }

        public static async void getInvoices(Action<List<Invoice>> callback, string where = null)
        {
            new Task(() =>
            {
                try
                {
                    //Prep connection to database & query for user with given id
                    SqlConnection connection = new SqlConnection(m_connectionString);
                    SqlCommand command;
                    if (where == null)
                    {
                        command = new SqlCommand("SELECT * FROM INVOICES;", connection);
                    }
                    else
                    {
                        command = new SqlCommand("SELECT * FROM INVOICES WHERE " + where + ";", connection);
                    }

                    //Execute connection
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    //Read results of query into list
                    List<Invoice> results = new List<Invoice>();
                    while (reader.Read())
                    {
                        results.Add(new Invoice(
                        reader["id"].ToString(),
                        reader["departmentId"].ToString(),
                        reader["productId"].ToString(),
                        reader["date"].ToString(),
                        reader["price"].ToString(),
                        reader["quantitiy"].ToString(),
                        reader["vat"].ToString()
                        ));
                    }

                    connection.Close();
                    callback(results);
                }
                catch (Exception e)
                {
                    callback(null);
                }
            }).Start();
        }

        public static async void uploadShipment(Shipment shipment, Action<bool> callback)
        {
            new Task(() =>
            {

                try
                {
                    SqlConnection connection = new SqlConnection(m_connectionString);
                    SqlCommand command = new SqlCommand("INSERT INTO SHIPMENTS VALUES (" +
                        "@id," +
                        "@supplierName," +
                        "@supplierSiteName," +
                        "@supplierRemitToAddressLine1," +
                        "@supplierRemitToAddressLine2," +
                        "@supplierRemitToAddressLine3," +
                        "@supplierRemitToAddressPostCode," +
                        "@orderNo," +
                        "@date," +
                        "@requestedDate," +
                        "@promisedDate," +
                        "@goodsAndServices," +
                        "@vat," +
                        "@invoiceTotal," +
                        "@supplierIDNumber," +
                        "@universalProductCode," +
                        "@itemDescription," +
                        "@quantity," +
                        "@unitOfMeasure," +
                        "@unitOfPrice," +
                        "@extendedPrice);", connection);

                    command.Parameters.AddWithValue("@id", "NEWID()");
                    command.Parameters.AddWithValue("@supplierName", shipment.supplierName);
                    command.Parameters.AddWithValue("@supplierSiteName", shipment.supplierSiteName);
                    command.Parameters.AddWithValue("@supplierRemitToAddressLine1", shipment.supplierRemitToAddress.line1);
                    command.Parameters.AddWithValue("@supplierRemitToAddressLine2", shipment.supplierRemitToAddress.line2);
                    command.Parameters.AddWithValue("@supplierRemitToAddressLine3", shipment.supplierRemitToAddress.line3);
                    command.Parameters.AddWithValue("@supplierRemitToAddressPostCode", shipment.supplierRemitToAddress.postCode);
                    command.Parameters.AddWithValue("@orderNo", shipment.orderNo);
                    command.Parameters.AddWithValue("@date", shipment.date);
                    command.Parameters.AddWithValue("@requestedDate", shipment.requestedDate);
                    command.Parameters.AddWithValue("@promisedDate", shipment.promisedDate);
                    command.Parameters.AddWithValue("@goodsAndServices", shipment.goodsAndServices);
                    command.Parameters.AddWithValue("@vat", shipment.vat);
                    command.Parameters.AddWithValue("@invoiceTotal", shipment.invoiceTotal);
                    command.Parameters.AddWithValue("@supplierIDNumber", shipment.supplierIdNumber);
                    command.Parameters.AddWithValue("@universalProductCode", shipment.universalProductCode);
                    command.Parameters.AddWithValue("@itemDescription", shipment.itemDescription);
                    command.Parameters.AddWithValue("@quantity", shipment.quantity);
                    command.Parameters.AddWithValue("@unitOfMeasure", shipment.unitOfMeasure);
                    command.Parameters.AddWithValue("@unitOfPrice", shipment.unitOfPrice);
                    command.Parameters.AddWithValue("@extendedPrice", shipment.extendedPrice);

                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();

                    callback(true);
                }
                catch (Exception e)
                {
                    callback(false);
                }
            }).Start();
        }

        public static async void updateShipment(Shipment shipment, Action<bool> callback)
        {
            new Task(() =>
            {
                try
                {
                    SqlConnection connection = new SqlConnection(m_connectionString);
                    SqlCommand command = new SqlCommand("UPDATE SHIPMENTS SET " +
                        "supplierName=@supplierName," +
                        "supplierSiteName=@supplierSiteName," +
                        "supplierRemitToAddressLine1=@supplierRemitToAddressLine1," +
                        "supplierRemitToAddressLine2=@supplierRemitToAddressLine2," +
                        "supplierRemitToAddressLine3=@supplierRemitToAddressLine3," +
                        "supplierRemitToAddressPostCode=@supplierRemitToAddressPostCode," +
                        "orderNo=@orderNo," +
                        "date=@date," +
                        "requestedDate=@requestedDate," +
                        "promisedDate=@promisedDate," +
                        "goodsAndServices=@goodsAndServices," +
                        "vat=@vat," +
                        "invoiceTotal=@invoiceTotal," +
                        "supplierIDNumber=@supplierIDNumber," +
                        "universalProductCode=@universalProductCode," +
                        "itemDescription=@itemDescription," +
                        "quantity=@quantity," +
                        "unitOfMeasure=@unitOfMeasure," +
                        "unitOfPrice=@unitOfPrice," +
                        "extenedPrice=@extenedPrice where id = @id;", connection);

                    command.Parameters.AddWithValue("@id", shipment.id);
                    command.Parameters.AddWithValue("@supplierName", shipment.supplierName);
                    command.Parameters.AddWithValue("@supplierSiteName", shipment.supplierSiteName);
                    command.Parameters.AddWithValue("@supplierRemitToAddressLine1", shipment.supplierRemitToAddress.line1);
                    command.Parameters.AddWithValue("@supplierRemitToAddressLine2", shipment.supplierRemitToAddress.line2);
                    command.Parameters.AddWithValue("@supplierRemitToAddressLine3", shipment.supplierRemitToAddress.line3);
                    command.Parameters.AddWithValue("@supplierRemitToAddressPostCode", shipment.supplierRemitToAddress.postCode);
                    command.Parameters.AddWithValue("@orderNo", shipment.orderNo);
                    command.Parameters.AddWithValue("@date", shipment.date);
                    command.Parameters.AddWithValue("@requestedDate", shipment.requestedDate);
                    command.Parameters.AddWithValue("@promisedDate", shipment.promisedDate);
                    command.Parameters.AddWithValue("@goodsAndServices", shipment.goodsAndServices);
                    command.Parameters.AddWithValue("@vat", shipment.vat);
                    command.Parameters.AddWithValue("@invoiceTotal", shipment.invoiceTotal);
                    command.Parameters.AddWithValue("@supplierIDNumber", shipment.supplierIdNumber);
                    command.Parameters.AddWithValue("@universalProductCode", shipment.universalProductCode);
                    command.Parameters.AddWithValue("@itemDescription", shipment.itemDescription);
                    command.Parameters.AddWithValue("@quantity", shipment.quantity);
                    command.Parameters.AddWithValue("@unitOfMeasure", shipment.unitOfMeasure);
                    command.Parameters.AddWithValue("@unitOfPrice", shipment.unitOfPrice);
                    command.Parameters.AddWithValue("@extenedPrice", shipment.extendedPrice);

                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();

                    callback(true);
                }
                catch (Exception e)
                {
                    callback(false);
                }
            }).Start();
        }

        public static async void getShipments(Action<List<Shipment>> callback, string where = null)
        {
            new Task(() =>
            {
                try
                {
                    //Prep connection to database & query for user with given id
                    SqlConnection connection = new SqlConnection(m_connectionString);
                    SqlCommand command;
                    if(where == null)
                    {
                        command = new SqlCommand("SELECT * FROM SHIPMENTS;", connection);
                    }
                    else
                    {
                        command = new SqlCommand("SELECT * FROM SHIPMENTS WHERE " + where + ";", connection);
                    }

                    //Execute connection
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    //Read results of query into list
                    List<Shipment> results = new List<Shipment>();
                    while (reader.Read())
                    {
                        results.Add(new Shipment(
                        reader["id"].ToString(),
                        reader["supplierName"].ToString(),
                        reader["supplierSiteName"].ToString(),
                        reader["supplierRemitToAddressLine1"].ToString(),
                        reader["supplierRemitToAddressLine2"].ToString(),
                        reader["supplierRemitToAddressLine3"].ToString(),
                        reader["supplierRemitToAddressPostCode"].ToString(),
                        reader["orderNo"].ToString(),
                        reader["date"].ToString(),
                        reader["requestedDate"].ToString(),
                        reader["promisedDate"].ToString(),
                        reader["goodsAndServices"].ToString(),
                        reader["vat"].ToString(),
                        reader["invoiceTotal"].ToString(),
                        reader["supplierIdNumber"].ToString(),
                        reader["universalProductCode"].ToString(),
                        reader["itemDescription"].ToString(),
                        reader["quantity"].ToString(),
                        reader["unitOfMeasure"].ToString(),
                        reader["unitOfPrice"].ToString(),
                        reader["extenedPrice"].ToString()
                        ));
                    }

                    connection.Close();
                    callback(results);
                }
                catch (Exception e)
                {
                    callback(null);
                }
            }).Start();
        }

        public static async void uploadTransation(Transation transaction, Action<bool> callback)
        {
            new Task(() =>
            {
                try
                {
                    SqlConnection connection = new SqlConnection(m_connectionString);
                    SqlCommand command = new SqlCommand("INSERT INTO TRANSACTIONS VALUES (" +
                        "@id, @date, @productId, @quantitiy, @nNumber, @department);", connection);

                    command.Parameters.AddWithValue("@id", "NEWID()");
                    command.Parameters.AddWithValue("@date", transaction.date);
                    command.Parameters.AddWithValue("@productId", transaction.productId);
                    command.Parameters.AddWithValue("@quantitiy", transaction.quantity);
                    command.Parameters.AddWithValue("@nNumber", transaction.nNumber);
                    command.Parameters.AddWithValue("@department", transaction.department);

                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();

                    callback(true);
                }
                catch (Exception e)
                {
                    callback(false);
                }
            }).Start();
        }

        /*public static async void updateTransation(Transation product, Action<bool> callback)
        {
        }*/

        public static async void getTransations(Action<List<Transation>> callback, string where = null)
        {
            new Task(() =>
            {
                try
                {
                    //Prep connection to database & query for user with given id
                    SqlConnection connection = new SqlConnection(m_connectionString);
                    SqlCommand command;
                    if(where == null)
                    {
                        command = new SqlCommand("SELECT * FROM TRANSACTIONS;", connection);
                    }
                    else
                    {
                        command = new SqlCommand("SELECT * FROM TRANSACTIONS WHERE " + where + ";", connection);
                    }

                    //Execute connection
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    //Read results of query into list
                    List<Transation> results = new List<Transation>();
                    while (reader.Read())
                    {
                        results.Add(new Transation(
                        reader["id"].ToString(),
                        reader["date"].ToString(),
                        reader["productId"].ToString(),
                        reader["quantity"].ToString(),
                        reader["nNumber"].ToString(),
                        reader["department"].ToString()
                        ));
                    }

                    connection.Close();
                    callback(results);
                }
                catch (Exception e)
                {
                    callback(null);
                }
            }).Start();
        }

        public static async void uploadUser(User user, Action<bool> callback)
        {
            new Task(() =>
            {
                try
                {
                    SqlConnection connection = new SqlConnection(m_connectionString);
                    SqlCommand command = new SqlCommand("INSERT INTO USERS VALUES(" +
                        "@nNumber, @password,  @department, @role);", connection);

                    command.Parameters.AddWithValue("@nNumber", user.nNumber);
                    command.Parameters.AddWithValue("@password", user.password);
                    command.Parameters.AddWithValue("@department", user.department);
                    command.Parameters.AddWithValue("@role", user.role);

                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();

                    callback(true);
                }
                catch (Exception e)
                {
                    callback(false);
                }
            }).Start();
        }

        public static async void updateUser(User user, Action<bool> callback)
        {
            new Task(() =>
            {
                try
                {
                    SqlConnection connection = new SqlConnection(m_connectionString);
                    SqlCommand command = new SqlCommand("UPDATE USERS SET " +
                        "password=@password," +
                        "department=@department," +
                        "role=@role " +
                        "where nNumber=@nNumber;", connection);

                    command.Parameters.AddWithValue("@nNumber", user.nNumber);
                    command.Parameters.AddWithValue("@department", user.department);
                    command.Parameters.AddWithValue("@role", user.role);
                    command.Parameters.AddWithValue("@password", user.password);                

                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();

                    callback(true);
                }
                catch (Exception e)
                {
                    callback(false);
                }
            }).Start();
        }

        public static async void getUsers(Action<List<User>> callback, string where = null)
        {
            new Task(() =>
            {
                try
                {
                    //Prep connection to database & query for user with given id
                    SqlConnection connection = new SqlConnection(m_connectionString);
                    SqlCommand command;
                    if(where == null)
                    {
                        command = new SqlCommand("SELECT * FROM USERS;", connection);
                    }
                    else
                    {
                        command = new SqlCommand("SELECT * FROM USERS WHERE " + where + ";", connection);
                    }

                    //Execute connection
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    //Read results of query into list
                    List<User> users = new List<User>();
                    while(reader.Read())
                    {
                        users.Add(new User(
                        reader["nNumber"].ToString(),
                        reader["password"].ToString(),
                        reader["department"].ToString(),
                        reader["role"].ToString()
                        ));
                    }

                    connection.Close();
                    callback(users);
                }
                catch (Exception e)
                {
                    callback(null);
                }
            }).Start();
        }

        public static async void uploadExpectedShipment(ExpectedShipment expectedShipment, Action<bool> callback)
        {
            new Task(() =>
            {
                try
                {
                    SqlConnection connection = new SqlConnection(m_connectionString);
                    SqlCommand command = new SqlCommand("INSERT INTO EXPECTED_SHIPMENTS VALUES (" +
                        "@shipmentId, @dateExpected, @supplierName, @supplierId);", connection);

                    command.Parameters.AddWithValue("@shipmentId", expectedShipment.shipmentId);
                    command.Parameters.AddWithValue("@dateExpected", expectedShipment.dateExpected);
                    command.Parameters.AddWithValue("@supplierName", expectedShipment.supplierName);
                    command.Parameters.AddWithValue("@supplierId", expectedShipment.supplierId);

                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();

                    callback(true);
                }
                catch (Exception e)
                {
                    callback(false);
                }
            }).Start();
        }

        //public static async void updateExpectedShipment(ExpectedShipment product, Action<bool> callback)
        //{
        //}

        public static async void getExpectedShipment(Action<List<ExpectedShipment>> callback, string where = null)
        {
            new Task(() =>
            {
                try
                {
                    //Prep connection to database & query for user with given id
                    SqlConnection connection = new SqlConnection(m_connectionString);
                    SqlCommand command;
                    if (where == null)
                    {
                        command = new SqlCommand("SELECT * FROM EXPECTED_SHIPMENTS;", connection);
                    }
                    else
                    {
                        command = new SqlCommand("SELECT * FROM EXPECTED_SHIPMENTS WHERE " + where + ";", connection);
                    }

                    //Execute connection
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    //Read results of query into list
                    List<ExpectedShipment> results = new List<ExpectedShipment>();
                    while (reader.Read())
                    {
                        results.Add(new ExpectedShipment(
                        reader["shipmentId"].ToString(),
                        reader["dateExpected"].ToString(),
                        reader["supplierName"].ToString(),
                        reader["supplierId"].ToString()
                        ));
                    }

                    connection.Close();
                    callback(results);
                }
                catch (Exception e)
                {
                    callback(null);
                }
            }).Start();
        }

        public static async void getDepartments(Action<List<string>> callback)
        {
            new Task(() =>
            {
                try
                {
                    //Prep connection to database & query for user with given id
                    SqlConnection connection = new SqlConnection(m_connectionString);
                    SqlCommand command = new SqlCommand("SELECT * FROM DEPARTMENTS;", connection);

                    //Execute connection
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    //Read results of query into list
                    List<string> results = new List<string>();
                    while (reader.Read())
                        results.Add(reader["name"].ToString());

                    connection.Close();
                    callback(results);
                }
                catch (Exception e)
                {
                    callback(null);
                }
            }).Start();
        }

        public static async void setDepartments(List<string> departments, Action<bool> callback)
        {
            new Task(() =>
            {
                try
                {
                    SqlConnection connection = new SqlConnection(m_connectionString);
                    SqlCommand command = new SqlCommand("DELETE DEPARTMENTS; INSERT INTO DEPARTMENTS (name) VALUES (" +
                        string.Join(",", departments.ToArray())+");", connection);

                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();

                    callback(true);
                }
                catch (Exception e)
                {
                    callback(false);
                }
            }).Start();
        }
    }
}
