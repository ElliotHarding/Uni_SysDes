using StockManagementSystem.Classes;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Threading.Tasks;

namespace StockManagementSystem
{
    class DatabaseComms
    {
        private const string m_connectionString = "Data Source=den1.mssql7.gear.host;Initial Catalog=smdatabase;User ID=smdatabase;Password=Jj80-f1I!M3c";

        public static void uploadProducts(List<Product> products, Action<bool> callback)
        {
            new Task(() =>
            {
                try
                {
                    string productsValues = "";
                    foreach(Product product in products)
                    {
                        productsValues += " ( NEWID(), '" + product.externalId + "', '" + product.image + "', '" + product.information + "', '" + product.locationX + "', '" + product.locationY + "', '" + product.quantity + "', '" + product.expiryDate + "', '" + product.price + "', '" + product.vat + "', '" + product.dangerDescription + "', '" + product.retProductNo + "', '" + product.name + "'),";
                    }
                    productsValues = productsValues.Substring(0, productsValues.Length - 1);

                    SqlConnection connection = new SqlConnection(m_connectionString);
                    SqlCommand command = new SqlCommand("INSERT INTO PRODUCTS (id, externalId, image, information, locationX, locationY, quantity, expiryDate, price, vat, dangerDescription, retProductNo, name) VALUES" +
                        productsValues +";", connection);

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

        public static void updateProduct(Product product, Action<bool> callback)
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

        public static void updateProductQuantity(Action<bool> callback, string quantity, string where)
        {
            new Task(() =>
            {
                try
                {
                    SqlConnection connection = new SqlConnection(m_connectionString);
                    SqlCommand command = new SqlCommand("UPDATE PRODUCTS SET " +                        
                        "quantity = '" + quantity +                        
                        "' WHERE " + where + ";", connection);

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

        public static void updateProductQuantities(Action<bool> callback, List<Product> products, List<Transation> transations)
        {
            new Task(() =>
            {
                try
                {
                    if(products.Count != transations.Count)
                    {
                        callback(false);
                        return;
                    }

                    string updates = "";
                    for (int i = 0; i < products.Count; i++)
                    {
                        updates += "UPDATE PRODUCTS SET quantity = '" + products[i].quantity + "' WHERE id = '" + products[i].id + "';";
                        updates += "INSERT INTO TRANSACTIONS VALUES (NEWID(), '"+ transations[i].date + "', '"+ transations[i].productId + "', '"+ transations[i].quantity + "', '"+ transations[i].nNumber + "', '"+ transations[i].department + "', '"+ transations[i].price+ "', '"+ transations[i].isReturn+ "');";
                    }                 

                    SqlConnection connection = new SqlConnection(m_connectionString);
                    SqlCommand command = new SqlCommand(updates, connection);

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

        public static void getProducts(Action<List<Product>> callback, int rowCount = 0, string where = null)
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
                    else if (where == null && rowCount != 0)
                    {
                        command = new SqlCommand("SELECT * FROM PRODUCTS LIMIT " + rowCount.ToString() + ";", connection);
                    }
                    else if(rowCount != 0)
                    {                      
                        command = new SqlCommand("SET ROWCOUNT "+ rowCount.ToString() +"; SELECT * FROM PRODUCTS WHERE " + where + ";", connection);
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

        public static void uploadShipment(Shipment shipment, Action<bool> callback)
        {
            new Task(() =>
            {

                try
                {
                    SqlConnection connection = new SqlConnection(m_connectionString);
                    SqlCommand command = new SqlCommand("INSERT INTO SHIPMENTS VALUES (" +
                        "NEWID()," +
                        "@supplierName," +
                        "@supplierSiteName," +
                        "@supplierRemitToAddressLine1," +
                        "@supplierRemitToAddressLine2," +
                        "@supplierRemitToAddressLine3," +
                        "@supplierRemitToAddressLine4," +
                        "@orderNo," +
                        "@orderLine," +
                        "@orderDate," +
                        "@requestedDate," +
                        "@promisedDate," +
                        "@goodsAndServicesAddressLine1," +
                        "@goodsAndServicesAddressLine2," +
                        "@goodsAndServicesAddressLine3," +
                        "@goodsAndServicesAddressLine4," +
                        "@vat," +
                        "@invoiceTotal);", connection);

                    command.Parameters.AddWithValue("@supplierName", shipment.supplierName);
                    command.Parameters.AddWithValue("@supplierSiteName", shipment.supplierSiteName);
                    command.Parameters.AddWithValue("@supplierRemitToAddressLine1", shipment.supplierRemitToAddress.line1);
                    command.Parameters.AddWithValue("@supplierRemitToAddressLine2", shipment.supplierRemitToAddress.line2);
                    command.Parameters.AddWithValue("@supplierRemitToAddressLine3", shipment.supplierRemitToAddress.line3);
                    command.Parameters.AddWithValue("@supplierRemitToAddressLine4", shipment.supplierRemitToAddress.postCode);
                    command.Parameters.AddWithValue("@orderNo", shipment.orderNo);
                    command.Parameters.AddWithValue("@orderLine", shipment.orderLine);
                    command.Parameters.AddWithValue("@orderDate", shipment.orderDate);
                    command.Parameters.AddWithValue("@requestedDate", shipment.requestedDate);
                    command.Parameters.AddWithValue("@promisedDate", shipment.promisedDate);
                    command.Parameters.AddWithValue("@goodsAndServicesAddressLine1", shipment.goodsAndServicesAddress.line1);
                    command.Parameters.AddWithValue("@goodsAndServicesAddressLine2", shipment.goodsAndServicesAddress.line2);
                    command.Parameters.AddWithValue("@goodsAndServicesAddressLine3", shipment.goodsAndServicesAddress.line3);
                    command.Parameters.AddWithValue("@goodsAndServicesAddressLine4", shipment.goodsAndServicesAddress.postCode);
                    command.Parameters.AddWithValue("@vat", shipment.vat);
                    command.Parameters.AddWithValue("@invoiceTotal", shipment.invoiceTotal);

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

        public static void updateShipment(Shipment shipment, Action<bool> callback)
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
                        "supplierRemitToAddressLine4=@supplierRemitToAddressLine4," +
                        "orderNo=@orderNo," +
                        "orderDate=@orderDate," +
                        "requestedDate=@requestedDate," +
                        "promisedDate=@promisedDate," +
                        "goodsAndServicesAddressLine1=@goodsAndServicesAddressLine1," +
                        "goodsAndServicesAddressLine2=@goodsAndServicesAddressLine2," +
                        "goodsAndServicesAddressLine3=@goodsAndServicesAddressLine3," +
                        "goodsAndServicesAddressLine4=@goodsAndServicesAddressLine4," +
                        "vat=@vat," +
                        "invoiceTotal=@invoiceTotal where id = @id;", connection);

                    command.Parameters.AddWithValue("@id", shipment.id);
                    command.Parameters.AddWithValue("@supplierName", shipment.supplierName);
                    command.Parameters.AddWithValue("@supplierSiteName", shipment.supplierSiteName);
                    command.Parameters.AddWithValue("@supplierRemitToAddressLine1", shipment.supplierRemitToAddress.line1);
                    command.Parameters.AddWithValue("@supplierRemitToAddressLine2", shipment.supplierRemitToAddress.line2);
                    command.Parameters.AddWithValue("@supplierRemitToAddressLine3", shipment.supplierRemitToAddress.line3);
                    command.Parameters.AddWithValue("@supplierRemitToAddressLine4", shipment.supplierRemitToAddress.postCode);
                    command.Parameters.AddWithValue("@orderNo", shipment.orderNo);
                    command.Parameters.AddWithValue("@orderDate", shipment.orderDate);
                    command.Parameters.AddWithValue("@requestedDate", shipment.requestedDate);
                    command.Parameters.AddWithValue("@promisedDate", shipment.promisedDate);
                    command.Parameters.AddWithValue("@goodsAndServicesAddressLine1", shipment.goodsAndServicesAddress.line1);
                    command.Parameters.AddWithValue("@goodsAndServicesAddressLine2", shipment.goodsAndServicesAddress.line2);
                    command.Parameters.AddWithValue("@goodsAndServicesAddressLine3", shipment.goodsAndServicesAddress.line3);
                    command.Parameters.AddWithValue("@goodsAndServicesAddressLine4", shipment.goodsAndServicesAddress.postCode);
                    command.Parameters.AddWithValue("@vat", shipment.vat);
                    command.Parameters.AddWithValue("@invoiceTotal", shipment.invoiceTotal);

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

        public static void getShipments(Action<List<Shipment>> callback, string where = null)
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
                        reader["supplierRemitToAddressLine4"].ToString(),
                        reader["orderNo"].ToString(),
                        reader["orderLine"].ToString(),
                        reader["orderDate"].ToString(),
                        reader["requestedDate"].ToString(),
                        reader["promisedDate"].ToString(),
                        reader["goodsAndServicesAddressLine1"].ToString(),
                        reader["goodsAndServicesAddressLine2"].ToString(),
                        reader["goodsAndServicesAddressLine3"].ToString(),
                        reader["goodsAndServicesAddressLine4"].ToString(),
                        reader["vat"].ToString(),
                        reader["invoiceTotal"].ToString()
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

        public static void uploadTransation(Transation transaction, Action<bool> callback)
        {
            new Task(() =>
            {
                try
                {
                    SqlConnection connection = new SqlConnection(m_connectionString);
                    SqlCommand command = new SqlCommand("INSERT INTO TRANSACTIONS VALUES (" +
                        "@id, @date, @productId, @quantitiy, @nNumber, @department, @price, @isReturn);", connection);

                    command.Parameters.AddWithValue("@id", "NEWID()");
                    command.Parameters.AddWithValue("@date", transaction.date);
                    command.Parameters.AddWithValue("@productId", transaction.productId);
                    command.Parameters.AddWithValue("@quantitiy", transaction.quantity);
                    command.Parameters.AddWithValue("@nNumber", transaction.nNumber);
                    command.Parameters.AddWithValue("@department", transaction.department);
                    command.Parameters.AddWithValue("@price", transaction.price);
                    command.Parameters.AddWithValue("@isReturn", transaction.isReturn);

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

        public static void getTransations(Action<List<Transation>> callback, string where = null)
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
                        reader["department"].ToString(),
                        reader["price"].ToString(),
                        reader["isReturn"].ToString()
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

        public static void uploadUser(User user, Action<bool> callback)
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

        public static void updateUser(User user, Action<bool> callback)
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

        public static void getUsers(Action<List<User>> callback, string where = null)
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


        public static void getDepartments(Action<List<string>> callback)
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

        public static void setDepartments(List<string> departments, Action<bool> callback)
        {
            new Task(() =>
            {
                try
                {
                    SqlConnection connection = new SqlConnection(m_connectionString);
                    SqlCommand command = new SqlCommand("DELETE DEPARTMENTS; INSERT INTO DEPARTMENTS (name) VALUES ('" +
                        string.Join("'),('", departments.ToArray())+"');", connection);

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

        public static void uploadItemsMap(Bitmap map, Action<bool> callback)
        {
            new Task(() =>
            {
                try
                {
                    SqlConnection connection = new SqlConnection(m_connectionString);
                    Tools t = new Tools();
                    SqlCommand command = new SqlCommand("UPDATE SETTINGS SET map = '"+ t.bitmapToBase64(map) + "';", connection);

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

        public static void getItemsMap(Action<Bitmap> callback)
        {
            new Task(() =>
            {
                try
                {
                    //Prep connection to database & query for user with given id
                    SqlConnection connection = new SqlConnection(m_connectionString);
                    SqlCommand command = new SqlCommand("SELECT * FROM SETTINGS;", connection);

                    //Execute connection
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    Bitmap bmp = null;

                    //Read results of query into list
                    if (reader.Read())
                        bmp = new Tools().base64ToBitmap(reader["map"].ToString());

                    connection.Close();
                    callback(bmp);
                }
                catch (Exception e)
                {
                    callback(null);
                }
            }).Start();
        }

        public static void query(string query, Action<bool> callback)
        {
            new Task(() =>
            {
                try
                {
                    SqlConnection connection = new SqlConnection(m_connectionString);
                    SqlCommand command = new SqlCommand(query, connection);

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

        public static void getScannedProduct(string nNumber, Action<Product> callback)
        {
            new Task(() =>
            {
                try
                {
                    //Prep connection to database & query for user with given id
                    SqlConnection connection = new SqlConnection(m_connectionString);
                    SqlCommand command = new SqlCommand("SELECT * FROM PRODUCTS WHERE id = (SELECT pid FROM SCANS WHERE nNumber = '"+nNumber+ "'); DELETE FROM SCANS WHERE nNumber = '" + nNumber + "';", connection);

                    //Execute connection
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    //Read results of query into list
                    Product product = null;
                    if (reader.Read())
                    {
                        product = new Product(
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
                        reader["name"].ToString());
                    }                     

                    connection.Close();
                    callback(product);
                }
                catch (Exception e)
                {
                    callback(null);
                }
            }).Start();
        }
    }
}
