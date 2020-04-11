﻿using System.Web.Mvc;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace PFC_Toolbox.v._4._0.Controllers
{
    public class NewProductController : Controller
    {
        public void CreateNewProduct(
                // Required Parameters:
                int store, string UPC, string Brand, string ShortDescription, string Size, string LongDescription, int Category, int Report,
                int Subdepartment, string POSDescription,
                float Retail, int PriceLevel, float Quantity,
                string VendorID, string ReorderCode, int Case, float Cost,
                string Label,
                string Mettler,
                // Optional Parameters:
                string SNAP = null, string WIC = null, string Others = null, string ForcePrice = null, string Scalable = null, string Tax1 = null, string Tax2 = null, string PLU = null, string StopDiscount = null, int Family = 0, int ClientAge = 0,
                int Like = 0,
                string Ingredients1 = null, string Ingredients2 = null, string Ingredients3 = null, string Ingredients4 = null, string Ingredients5 = null, string Ingredients6 = null, string Ingredients7 = null, string Ingredients8 = null, string Ingredients9 = null, string Ingredients10 = null, string Ingredients11 = null, string Ingredients12 = null, string Ingredients13 = null,
                float Tare = 0, int ProdLife = 0, int TextLink = 0)
        {

            // Executes Toolbox-Add-NewProduct stored procedure located on La Crosse SMS SQL Server and provides parameters
            using (SqlConnection con1 = new SqlConnection { ConnectionString = ConfigurationManager.ConnectionStrings["SMSLaxConnection"].ConnectionString })
            {
                using (SqlCommand cmd1 = new SqlCommand("[Toolbox-Add-NewProduct]", con1))
                {
                    cmd1.CommandType = CommandType.StoredProcedure;

                    cmd1.Parameters.Add("@F01", SqlDbType.VarChar).Value = UPC;
                    cmd1.Parameters.Add("@F155", SqlDbType.VarChar).Value = Brand;
                    cmd1.Parameters.Add("@F29", SqlDbType.VarChar).Value = ShortDescription;
                    cmd1.Parameters.Add("@F22", SqlDbType.VarChar).Value = Size;
                    cmd1.Parameters.Add("@F255", SqlDbType.VarChar).Value = LongDescription;
                    cmd1.Parameters.Add("@F17", SqlDbType.Int).Value = Category;
                    cmd1.Parameters.Add("@F16", SqlDbType.Int).Value = Family;
                    cmd1.Parameters.Add("@F18", SqlDbType.Int).Value = Report;
                    cmd1.Parameters.Add("@F1000", SqlDbType.VarChar).Value = "PAL";
                    cmd1.Parameters.Add("@F04", SqlDbType.Int).Value = Subdepartment;
                    cmd1.Parameters.Add("@F02", SqlDbType.VarChar).Value = POSDescription;
                    cmd1.Parameters.Add("@F79", SqlDbType.VarChar).Value = SNAP;
                    cmd1.Parameters.Add("@F178", SqlDbType.VarChar).Value = WIC;
                    cmd1.Parameters.Add("@F1120", SqlDbType.VarChar).Value = Others;
                    cmd1.Parameters.Add("@F83", SqlDbType.VarChar).Value = ForcePrice;
                    cmd1.Parameters.Add("@F82", SqlDbType.VarChar).Value = Scalable;
                    cmd1.Parameters.Add("@F81", SqlDbType.VarChar).Value = Tax1;
                    cmd1.Parameters.Add("@F96", SqlDbType.VarChar).Value = Tax2;
                    cmd1.Parameters.Add("@F171", SqlDbType.Int).Value = ClientAge;
                    cmd1.Parameters.Add("@F123", SqlDbType.VarChar).Value = PLU;
                    cmd1.Parameters.Add("@F150", SqlDbType.VarChar).Value = StopDiscount;
                    cmd1.Parameters.Add("@F30", SqlDbType.Money).Value = Retail;
                    cmd1.Parameters.Add("@F126", SqlDbType.Int).Value = PriceLevel;
                    cmd1.Parameters.Add("@F31", SqlDbType.Float).Value = Quantity;
                    cmd1.Parameters.Add("@F122", SqlDbType.Int).Value = Like;
                    cmd1.Parameters.Add("@F27", SqlDbType.VarChar).Value = VendorID;
                    cmd1.Parameters.Add("@F26", SqlDbType.VarChar).Value = ReorderCode;
                    cmd1.Parameters.Add("@F19", SqlDbType.Float).Value = Case;
                    cmd1.Parameters.Add("@F38", SqlDbType.Money).Value = Cost;
                    cmd1.Parameters.Add("@F95", SqlDbType.VarChar).Value = Label;

                    con1.Open();
                    cmd1.ExecuteNonQuery();
                }
            }

            // Executes Toolbox-Add - NewProduct stored procedure located on Rochester SMS SQL Server and provides parameters
            using (SqlConnection con2 = new SqlConnection { ConnectionString = ConfigurationManager.ConnectionStrings["SMSRochConnection"].ConnectionString })
            {
                using (SqlCommand cmd2 = new SqlCommand("[Toolbox-Add-NewProduct]", con2))
                {
                    cmd2.CommandType = CommandType.StoredProcedure;

                    cmd2.Parameters.Add("@F01", SqlDbType.VarChar).Value = UPC;
                    cmd2.Parameters.Add("@F155", SqlDbType.VarChar).Value = Brand;
                    cmd2.Parameters.Add("@F29", SqlDbType.VarChar).Value = ShortDescription;
                    cmd2.Parameters.Add("@F22", SqlDbType.VarChar).Value = Size;
                    cmd2.Parameters.Add("@F255", SqlDbType.VarChar).Value = LongDescription;
                    cmd2.Parameters.Add("@F17", SqlDbType.Int).Value = Category;
                    cmd2.Parameters.Add("@F16", SqlDbType.Int).Value = Family;
                    cmd2.Parameters.Add("@F18", SqlDbType.Int).Value = Report;
                    cmd2.Parameters.Add("@F1000", SqlDbType.VarChar).Value = "PAL";
                    cmd2.Parameters.Add("@F04", SqlDbType.Int).Value = Subdepartment;
                    cmd2.Parameters.Add("@F02", SqlDbType.VarChar).Value = POSDescription;
                    cmd2.Parameters.Add("@F79", SqlDbType.VarChar).Value = SNAP;
                    cmd2.Parameters.Add("@F178", SqlDbType.VarChar).Value = WIC;
                    cmd2.Parameters.Add("@F1120", SqlDbType.VarChar).Value = Others;
                    cmd2.Parameters.Add("@F83", SqlDbType.VarChar).Value = ForcePrice;
                    cmd2.Parameters.Add("@F82", SqlDbType.VarChar).Value = Scalable;
                    cmd2.Parameters.Add("@F81", SqlDbType.VarChar).Value = Tax1;
                    cmd2.Parameters.Add("@F96", SqlDbType.VarChar).Value = Tax2;
                    cmd2.Parameters.Add("@F171", SqlDbType.Int).Value = ClientAge;
                    cmd2.Parameters.Add("@F123", SqlDbType.VarChar).Value = PLU;
                    cmd2.Parameters.Add("@F150", SqlDbType.VarChar).Value = StopDiscount;
                    cmd2.Parameters.Add("@F30", SqlDbType.Money).Value = Retail;
                    cmd2.Parameters.Add("@F126", SqlDbType.Int).Value = PriceLevel;
                    cmd2.Parameters.Add("@F31", SqlDbType.Float).Value = Quantity;
                    cmd2.Parameters.Add("@F122", SqlDbType.Int).Value = Like;
                    cmd2.Parameters.Add("@F27", SqlDbType.VarChar).Value = VendorID;
                    cmd2.Parameters.Add("@F26", SqlDbType.VarChar).Value = ReorderCode;
                    cmd2.Parameters.Add("@F19", SqlDbType.Float).Value = Case;
                    cmd2.Parameters.Add("@F38", SqlDbType.Money).Value = Cost;
                    cmd2.Parameters.Add("@F95", SqlDbType.VarChar).Value = Label;

                    con2.Open();
                    cmd2.ExecuteNonQuery();
                }
            }
            
            // Executes Toolbox-Add-ScaleInfo stored procedure located on Host SMS SQL Server and provides parameters
            if (Mettler.Equals("Yes"))
            {
                using (SqlConnection con7 = new SqlConnection { ConnectionString = ConfigurationManager.ConnectionStrings["SMSHostConnection"].ConnectionString })
                {
                    using (SqlCommand cmd7 = new SqlCommand("[Toolbox-Add-ScaleInfo]", con7))
                    {
                        cmd7.CommandType = CommandType.StoredProcedure;

                        cmd7.Parameters.Add("@F01", SqlDbType.VarChar).Value = UPC;
                        cmd7.Parameters.Add("@F155", SqlDbType.VarChar).Value = Brand;
                        cmd7.Parameters.Add("@F256", SqlDbType.VarChar).Value = LongDescription;
                        cmd7.Parameters.Add("@F258", SqlDbType.Float).Value = Tare * 1000;
                        cmd7.Parameters.Add("@F264", SqlDbType.Int).Value = ProdLife;
                        cmd7.Parameters.Add("@F267", SqlDbType.Int).Value = TextLink;
                        cmd7.Parameters.Add("@F04", SqlDbType.Int).Value = Subdepartment;
                        cmd7.Parameters.Add("@F1836", SqlDbType.VarChar).Value = LongDescription;
                        cmd7.Parameters.Add("@F297", SqlDbType.VarChar).Value = Ingredients1;
                        cmd7.Parameters.Add("@F1837", SqlDbType.VarChar).Value = Ingredients2;
                        cmd7.Parameters.Add("@F1838", SqlDbType.VarChar).Value = Ingredients3;
                        cmd7.Parameters.Add("@F1839", SqlDbType.VarChar).Value = Ingredients4;
                        cmd7.Parameters.Add("@F1853", SqlDbType.VarChar).Value = Ingredients5;
                        cmd7.Parameters.Add("@F1854", SqlDbType.VarChar).Value = Ingredients6;
                        cmd7.Parameters.Add("@F1855", SqlDbType.VarChar).Value = Ingredients7;
                        cmd7.Parameters.Add("@F1856", SqlDbType.VarChar).Value = Ingredients8;
                        cmd7.Parameters.Add("@F1968", SqlDbType.VarChar).Value = Ingredients9;
                        cmd7.Parameters.Add("@F1969", SqlDbType.VarChar).Value = Ingredients10;
                        cmd7.Parameters.Add("@F1970", SqlDbType.VarChar).Value = Ingredients11;
                        cmd7.Parameters.Add("@F1971", SqlDbType.VarChar).Value = Ingredients12;
                        cmd7.Parameters.Add("@F1972", SqlDbType.VarChar).Value = Ingredients12;

                        con7.Open();
                        cmd7.ExecuteNonQuery();
                    }
                }
            }

            // Executes Toolbox-Queue-Label stored procedure located on store argument given; 1 for La Crosse, 2 for Rochester, or both stores.
            if (store == 1)
            {
                using (SqlConnection con3 = new SqlConnection { ConnectionString = ConfigurationManager.ConnectionStrings["SMSLaxConnection"].ConnectionString })
                {
                    using (SqlCommand cmd3 = new SqlCommand("[Toolbox-Queue-Label]", con3))
                    {
                        cmd3.CommandType = CommandType.StoredProcedure;

                        cmd3.Parameters.Add("@F01", SqlDbType.VarChar).Value = UPC;
                        cmd3.Parameters.Add("@F155", SqlDbType.VarChar).Value = Brand;
                        cmd3.Parameters.Add("@F29", SqlDbType.VarChar).Value = ShortDescription;
                        cmd3.Parameters.Add("@F22", SqlDbType.VarChar).Value = Size;
                        cmd3.Parameters.Add("@F255", SqlDbType.VarChar).Value = LongDescription;
                        cmd3.Parameters.Add("@F17", SqlDbType.Int).Value = Category;
                        cmd3.Parameters.Add("@F18", SqlDbType.Int).Value = Report;
                        cmd3.Parameters.Add("@F04", SqlDbType.Int).Value = Subdepartment;
                        cmd3.Parameters.Add("@F02", SqlDbType.VarChar).Value = POSDescription;
                        cmd3.Parameters.Add("@F82", SqlDbType.VarChar).Value = Scalable;
                        cmd3.Parameters.Add("@F30", SqlDbType.Money).Value = Retail;
                        cmd3.Parameters.Add("@F126", SqlDbType.Int).Value = PriceLevel;
                        cmd3.Parameters.Add("@F31", SqlDbType.Float).Value = Quantity;
                        cmd3.Parameters.Add("@F95", SqlDbType.VarChar).Value = Label;

                        con3.Open();
                        cmd3.ExecuteNonQuery();
                    }
                }
            }
            else if (store == 2)
            {
                using (SqlConnection con4 = new SqlConnection { ConnectionString = ConfigurationManager.ConnectionStrings["SMSRochConnection"].ConnectionString })
                {
                    using (SqlCommand cmd4 = new SqlCommand("[Toolbox-Queue-Label]", con4))
                    {
                        cmd4.CommandType = CommandType.StoredProcedure;

                        cmd4.Parameters.Add("@F01", SqlDbType.VarChar).Value = UPC;
                        cmd4.Parameters.Add("@F155", SqlDbType.VarChar).Value = Brand;
                        cmd4.Parameters.Add("@F29", SqlDbType.VarChar).Value = ShortDescription;
                        cmd4.Parameters.Add("@F22", SqlDbType.VarChar).Value = Size;
                        cmd4.Parameters.Add("@F255", SqlDbType.VarChar).Value = LongDescription;
                        cmd4.Parameters.Add("@F17", SqlDbType.Int).Value = Category;
                        cmd4.Parameters.Add("@F18", SqlDbType.Int).Value = Report;
                        cmd4.Parameters.Add("@F04", SqlDbType.Int).Value = Subdepartment;
                        cmd4.Parameters.Add("@F02", SqlDbType.VarChar).Value = POSDescription;
                        cmd4.Parameters.Add("@F82", SqlDbType.VarChar).Value = Scalable;
                        cmd4.Parameters.Add("@F30", SqlDbType.Money).Value = Retail;
                        cmd4.Parameters.Add("@F126", SqlDbType.Int).Value = PriceLevel;
                        cmd4.Parameters.Add("@F31", SqlDbType.Float).Value = Quantity;
                        cmd4.Parameters.Add("@F95", SqlDbType.VarChar).Value = Label;

                        con4.Open();
                        cmd4.ExecuteNonQuery();
                    }
                }
            }
            else
            {
                using (SqlConnection con5 = new SqlConnection { ConnectionString = ConfigurationManager.ConnectionStrings["SMSLaxConnection"].ConnectionString })
                {
                    using (SqlCommand cmd5 = new SqlCommand("[Toolbox-Queue-Label]", con5))
                    {
                        cmd5.CommandType = CommandType.StoredProcedure;

                        cmd5.Parameters.Add("@F01", SqlDbType.VarChar).Value = UPC;
                        cmd5.Parameters.Add("@F155", SqlDbType.VarChar).Value = Brand;
                        cmd5.Parameters.Add("@F29", SqlDbType.VarChar).Value = ShortDescription;
                        cmd5.Parameters.Add("@F22", SqlDbType.VarChar).Value = Size;
                        cmd5.Parameters.Add("@F255", SqlDbType.VarChar).Value = LongDescription;
                        cmd5.Parameters.Add("@F17", SqlDbType.Int).Value = Category;
                        cmd5.Parameters.Add("@F18", SqlDbType.Int).Value = Report;
                        cmd5.Parameters.Add("@F04", SqlDbType.Int).Value = Subdepartment;
                        cmd5.Parameters.Add("@F02", SqlDbType.VarChar).Value = POSDescription;
                        cmd5.Parameters.Add("@F82", SqlDbType.VarChar).Value = Scalable;
                        cmd5.Parameters.Add("@F30", SqlDbType.Money).Value = Retail;
                        cmd5.Parameters.Add("@F126", SqlDbType.Int).Value = PriceLevel;
                        cmd5.Parameters.Add("@F31", SqlDbType.Float).Value = Quantity;
                        cmd5.Parameters.Add("@F95", SqlDbType.VarChar).Value = Label;

                        con5.Open();
                        cmd5.ExecuteNonQuery();
                    }
                }

                using (SqlConnection con6 = new SqlConnection { ConnectionString = ConfigurationManager.ConnectionStrings["SMSRochConnection"].ConnectionString })
                {
                    using (SqlCommand cmd6 = new SqlCommand("[Toolbox-Queue-Label]", con6))
                    {
                        cmd6.CommandType = CommandType.StoredProcedure;

                        cmd6.Parameters.Add("@F01", SqlDbType.VarChar).Value = UPC;
                        cmd6.Parameters.Add("@F155", SqlDbType.VarChar).Value = Brand;
                        cmd6.Parameters.Add("@F29", SqlDbType.VarChar).Value = ShortDescription;
                        cmd6.Parameters.Add("@F22", SqlDbType.VarChar).Value = Size;
                        cmd6.Parameters.Add("@F255", SqlDbType.VarChar).Value = LongDescription;
                        cmd6.Parameters.Add("@F17", SqlDbType.Int).Value = Category;
                        cmd6.Parameters.Add("@F18", SqlDbType.Int).Value = Report;
                        cmd6.Parameters.Add("@F04", SqlDbType.Int).Value = Subdepartment;
                        cmd6.Parameters.Add("@F02", SqlDbType.VarChar).Value = POSDescription;
                        cmd6.Parameters.Add("@F82", SqlDbType.VarChar).Value = Scalable;
                        cmd6.Parameters.Add("@F30", SqlDbType.Money).Value = Retail;
                        cmd6.Parameters.Add("@F126", SqlDbType.Int).Value = PriceLevel;
                        cmd6.Parameters.Add("@F31", SqlDbType.Float).Value = Quantity;
                        cmd6.Parameters.Add("@F95", SqlDbType.VarChar).Value = Label;


                        con6.Open();
                        cmd6.ExecuteNonQuery();
                    }
                }
            }
        }
    }
}