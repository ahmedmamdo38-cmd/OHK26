using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace WindowsFormsApplication3
{
   
    public static class DatabaseHelper
    {
   
        private const string Server = "localhost";
        private const string Database = "pizza_db";
        private const string User = "root";
        private const string Password = "";         
        private const uint Port = 3306;

        private static string ConnectionString =>
            $"Server={Server};Port={Port};Database={Database};" +
            $"Uid={User};Pwd={Password};CharSet=utf8mb4;";

       
        public static bool TestConnection()
        {
            try
            {
                using (var conn = new MySqlConnection(ConnectionString))
                {
                    conn.Open();
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }

        public static int SaveOrder(OrderData order)
        {
            int newOrderId = -1;

            try
            {
                using (var conn = new MySqlConnection(ConnectionString))
                {
                    conn.Open();

                    using (var transaction = conn.BeginTransaction())
                    {
                        try
                        {

                            string orderSql = @"
                                INSERT INTO orders
                                    (first_name, last_name, address, province, city,
                                     postal_code, contact_no, email,
                                     payment_method, card_no,
                                     subtotal, hst, total_due,
                                     amount_paid, change_amount)
                                VALUES
                                    (@firstName, @lastName, @address, @province, @city,
                                     @postalCode, @contactNo, @email,
                                     @paymentMethod, @cardNo,
                                     @subtotal, @hst, @totalDue,
                                     @amountPaid, @changeAmount);
                                SELECT LAST_INSERT_ID();";

                            using (var cmd = new MySqlCommand(orderSql, conn, transaction))
                            {
                                cmd.Parameters.AddWithValue("@firstName", order.FirstName);
                                cmd.Parameters.AddWithValue("@lastName", order.LastName);
                                cmd.Parameters.AddWithValue("@address", order.Address);
                                cmd.Parameters.AddWithValue("@province", order.Province);
                                cmd.Parameters.AddWithValue("@city", order.City);
                                cmd.Parameters.AddWithValue("@postalCode", order.PostalCode);
                                cmd.Parameters.AddWithValue("@contactNo", order.ContactNo);
                                cmd.Parameters.AddWithValue("@email", order.Email);
                                cmd.Parameters.AddWithValue("@paymentMethod", order.PaymentMethod);
                                cmd.Parameters.AddWithValue("@cardNo", order.CardNo ?? (object)DBNull.Value);
                                cmd.Parameters.AddWithValue("@subtotal", order.Subtotal);
                                cmd.Parameters.AddWithValue("@hst", order.Hst);
                                cmd.Parameters.AddWithValue("@totalDue", order.TotalDue);
                                cmd.Parameters.AddWithValue("@amountPaid", order.AmountPaid);
                                cmd.Parameters.AddWithValue("@changeAmount", order.ChangeAmount);

                                newOrderId = Convert.ToInt32(cmd.ExecuteScalar());
                            }

                            string itemSql = @"
                                INSERT INTO order_items (order_id, item_name, quantity, price)
                                VALUES (@orderId, @itemName, @quantity, @price);";

                            foreach (var item in order.Items)
                            {
                                using (var cmd = new MySqlCommand(itemSql, conn, transaction))
                                {
                                    cmd.Parameters.AddWithValue("@orderId", newOrderId);
                                    cmd.Parameters.AddWithValue("@itemName", item.ItemName);
                                    cmd.Parameters.AddWithValue("@quantity", item.Quantity);
                                    cmd.Parameters.AddWithValue("@price", item.Price);
                                    cmd.ExecuteNonQuery();
                                }
                            }

                            transaction.Commit();
                        }
                        catch
                        {
                            transaction.Rollback();
                            throw;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Database error:\n" + ex.Message,
                    "Database Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                newOrderId = -1;
            }

            return newOrderId;
        }
    }


    public class OrderData
    {

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string Province { get; set; }
        public string City { get; set; }
        public string PostalCode { get; set; }
        public string ContactNo { get; set; }
        public string Email { get; set; }

        public string PaymentMethod { get; set; }
        public string CardNo { get; set; }
        public decimal Subtotal { get; set; }
        public decimal Hst { get; set; }
        public decimal TotalDue { get; set; }
        public decimal AmountPaid { get; set; }
        public decimal ChangeAmount { get; set; }

        public List<OrderItem> Items { get; set; } = new List<OrderItem>();
    }

    public class OrderItem
    {
        public string ItemName { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
    }
}
