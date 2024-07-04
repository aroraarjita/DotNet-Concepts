using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;

namespace ConfiguringDataTablesAndDataSets
{
    class Program
    {
        static void Main(string[] args)
        {
            DataTable dt = new DataTable("MyTable");

            DataColumn column1 = dt.Columns.Add();
            column1.ColumnName = "First";
            column1.DataType = typeof(int);
            column1.DefaultValue = 0;
            column1.Unique = true;
            column1.AllowDBNull = false;

            DataColumn column2 = new DataColumn();
            column2.ColumnName = "Second";
            column2.DataType = typeof(string);
            column2.MaxLength = 25;
            dt.Columns.Add(column2);


            dt.Columns.Add("Third", typeof(string)).MaxLength = 40;

            DataColumn column4 = new DataColumn("Fourth");
            column4.DataType = typeof(int);
            DataColumn column5 = new DataColumn("Fifth", typeof(Decimal));
            dt.Columns.AddRange(new DataColumn[] { column4, column5 });

            Console.WriteLine("DataTable {0} has {1} columns:", dt.TableName, dt.Columns.Count);
            Console.WriteLine();

            foreach (DataColumn dataColumn in dt.Columns)
            {
                Console.WriteLine("\t\t\t{0}", dataColumn.ColumnName);
            }

            //Console.ReadKey();

            DataSet dataSet = new DataSet("MyDataSet");
            DataTable table1 = dataSet.Tables.Add("Table-1");

            DataTable table2 = new DataTable("Table-2");
            dataSet.Tables.Add(table2);

            DataTable table3 = new DataTable("Table-3");
            DataTable table4 = new DataTable("Table-4");

            dataSet.Tables.AddRange(new DataTable[] { table3, table4 });

            Console.WriteLine("Dataset {0} has the following {1} DataTables", dataSet.DataSetName,
                dataSet.Tables.Count);

            foreach (DataTable dataTable in dataSet.Tables)
            {
                Console.WriteLine("\t\t\t {0}", dataTable.TableName);
            }

            //Console.ReadKey();

            string sqlConn = "Server=MSI;Database=AdventureWorks2019;User Id=MyLogin;Password =Password@1234; ";


            string sqlSelect = "SELECT TOP 5 Title, FirstName, LastName " + "FROM Person.Person";

            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlSelect, sqlConn);
            DataTableMapping dataTableMapping = sqlDataAdapter.TableMappings.Add("Table", "TablePersonMapped");
            dataTableMapping.ColumnMappings.Add("Title", "ColumnTitleMapped");
            dataTableMapping.ColumnMappings.Add("FirstName", "ColumnFirstNameMapped");
            dataTableMapping.ColumnMappings.Add("LastName", "ColumnLastNameMapped");

            DataSet ds = new DataSet();

            sqlDataAdapter.Fill(ds);


        

            Console.WriteLine("DataTable name:{0}", ds.Tables[0].TableName);

            foreach (DataColumn dataColumn in ds.Tables["TablePersonMapped"].Columns)
            {
                Console.WriteLine("\tDataColumn {0} name {1}", dataColumn.Ordinal,
                    dataColumn.ColumnName);
            }

            foreach (DataRow dataRow in ds.Tables["TablePersonMapped"].Rows)
            {
                Console.WriteLine("Title = {0}, FirstName = {1}, LastName = {2}",
                    dataRow["ColumnTitleMapped"],
                    dataRow["ColumnFirstNameMapped"],
                    dataRow["ColumnLastNameMapped"]);

            }

            Console.WriteLine("\nPress any key to continue.");
            Console.ReadKey();


            //DataTable dt = new DataTable("Product");
            //DataColumn column1 = new DataColumn("Id");
            //column1.DataType = typeof(int);
            //dt.Columns.Add(column1);

            //dt.Columns.Add("ProductName", typeof(string)).MaxLength = 40;
            //dt.PrimaryKey = new DataColumn[] { column1 };

            //try
            //{
            //    dt.Rows.Add(new object[] { 1, "Golf" });
            //    dt.Rows.Add(new object[] { 2, "Volvo" });
            //    dt.Rows.Add(new object[] { 3, "BMW" });
            //    dt.Rows.Add(new object[] { 1, "Ferrari" });

            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine("Row cannot be added...");
            //    Console.WriteLine("Error: {0}", ex.Message);

            //}
            //finally
            //{
            //    foreach (DataRow dataRow in dt.Rows)
            //    {
            //        Console.WriteLine("Product {0}: Name {1}", dataRow["Id"], dataRow["ProductName"]);
            //    }
            //}

            //DataSet dataSet = new DataSet();
            //DataTable table1 = new DataTable("Product");
            //table1.Columns.Add("ProductId", typeof(int));
            //table1.Columns.Add("Name", typeof(string)).MaxLength = 30;
            //dataSet.Tables.Add(table1);

            //DataTable table2 = new DataTable("Order");
            //table2.Columns.Add("OrderId", typeof(int));
            //table2.Columns.Add("ProductId", typeof(int));
            //table2.Columns.Add("Customer", typeof(string)).MaxLength = 30;

            //dataSet.Tables.Add(table2);

            //ForeignKeyConstraint fk = new ForeignKeyConstraint("Fk_Order_Product", table1.Columns["ProductId"],
            //    table2.Columns["ProductId"]);
            //table2.Constraints.Add(fk);

            //try
            //{
            //    table1.Rows.Add(new object[] { 1, "Golf" });
            //    table1.Rows.Add(new object[] { 2, "BMW" });
            //    table1.Rows.Add(new object[] { 3, "Alpha Romeo" });


            //    table2.Rows.Add(new object[] { 1, 1, "Chris" });
            //    table2.Rows.Add(new object[] { 2, 2, "John" });
            //    table2.Rows.Add(new object[] { 3, 4, "Katherin" });


            //}

            //catch (Exception ex)
            //{
            //    Console.WriteLine("Row cannot be added...");
            //    Console.WriteLine("Error: {0}", ex.Message);
            //}

            //finally
            //{

            //    foreach (DataRow dataRow in table1.Rows)
            //    {
            //        Console.WriteLine("Product: {0}, Name: {1}", dataRow["ProductId"], dataRow["Name"]);
            //    }

            //    Console.WriteLine();
            //    Console.WriteLine("Orders....");

            //    foreach (DataRow dataRow1 in table2.Rows)
            //    {
            //        Console.WriteLine("Order: {0}, Product: {1}, Customer: {2}",
            //            dataRow1["OrderId"], dataRow1["ProductId"], dataRow1["Customer"]);
            //    }

            //    Console.ReadKey();
            //}

            //DataSet ds = new DataSet();
            //DataTable table1 = new DataTable("Product");
            //table1.Columns.Add("ProductId", typeof(int));
            //table1.Columns.Add("Name", typeof(string)).MaxLength = 30;
            //table1.Columns.Add("MadeIn", typeof(string)).MaxLength = 30;
            //ds.Tables.Add(table1);

            //DataTable table2 = new DataTable("Order");
            //table2.Columns.Add("OrderID", typeof(int));
            //table2.Columns.Add("ProductId", typeof(int));
            //table2.Columns.Add("MadeIn", typeof(string)).MaxLength = 30;
            //table2.Columns.Add("Customer", typeof(string)).MaxLength = 30;
            //ds.Tables.Add(table2);

            //DataRelation dataRelation = new DataRelation("Order_Product_Relation",
            //    new DataColumn[] { table1.Columns["ProductId"], table1.Columns["MadeIn"] },
            //    new DataColumn[] { table2.Columns["ProductId"], table2.Columns["MadeIn"] });
            //ds.Relations.Add(dataRelation);

            //try
            //{
            //    table1.Rows.Add(new object[] { 1, "Golf", "Germany" });
            //    table1.Rows.Add(new object[] { 2, "Toyota", "Japan" });
            //    table1.Rows.Add(new object[] { 3, "Alpha Romeo", "Italy" });

            //    table2.Rows.Add(new object[] { 1, 1, "Germany", "Chris" });
            //    table2.Rows.Add(new object[] { 2, 2, "Japan", "John" });
            //    table2.Rows.Add(new object[] { 3, 3, "Italy", "Katherin" });
            //    table2.Rows.Add(new object[] { 3, 3, "Japan", "Smith" });

            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine("Row cannot be added...");
            //    Console.WriteLine("Error:{0}", ex.Message);
            //}

            //finally
            //{
            //    foreach (DataRow dataRow in table1.Rows)
            //    {
            //        Console.WriteLine("Product {0}: Name {1}: Made in {2}"
            //            , dataRow["ProductId"], dataRow["Name"], dataRow["MadeIn"]);
            //    }

            //    Console.WriteLine();
            //    Console.WriteLine("Orders...");

            //    foreach (DataRow dataRow1 in table2.Rows)
            //    {
            //        Console.WriteLine("Order {0}: Product {1}: MadeIn {2}",
            //            dataRow1["OrderID"], dataRow1["ProductId"], dataRow1["MadeIn"]);
            //    }
            //}


            //Console.ReadKey();



        }
    }
}
;
