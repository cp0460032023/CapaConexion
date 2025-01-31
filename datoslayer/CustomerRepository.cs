﻿using DatosLayer;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datoslayer
{
    public class CustomerRepository
    {
        public List<customers> ObtenerTodos()
        {
            var conexion = DataBase.GetSqlConnection();

            String selectFrom = "";
            selectFrom = selectFrom + "SELECT[CompanyName]" + "\n";
            selectFrom = selectFrom + ",[ContactName]" + "\n";
            selectFrom = selectFrom + ",[ContactTitle]" + "\n";
            selectFrom = selectFrom + ",[Address]" + "\n";
            selectFrom = selectFrom + ",[City]" + "\n";
            selectFrom = selectFrom + ",[Region]" + "\n";
            selectFrom = selectFrom + ",[PostalCode]" + "\n";
            selectFrom = selectFrom + ",[Country]" + "\n";
            selectFrom = selectFrom + ",[Phone]" + "\n";
            selectFrom = selectFrom + ",[Fax]" + "\n";
            selectFrom = selectFrom + "FROM[dbo].[Customers]";


            SqlCommand comando = new SqlCommand(selectFrom, conexion);
            SqlDataReader reader = comando.ExecuteReader();

            List<customers> Customers = new List<customers>();

            while (reader.Read())
            {

                customers customers = new customers();
                customers.CompanyName = reader["CompanyName"] == DBNull.Value ? "" : (String)reader["CompanyName"];
                customers.ContactName = reader["ContactName"] == DBNull.Value ? "" : (String)reader["ContactName"];
                customers.ContactTitle = reader["ContactTitle"] == DBNull.Value ? "" : (String)reader["ContactTitle"];
                customers.Address = reader["Address"] == DBNull.Value ? "" : (String)reader["Address"];
                customers.City = reader["City"] == DBNull.Value ? "" : (String)reader["City"];
                customers.Region = reader["Region"] == DBNull.Value ? "" : (String)reader["Region"];
                customers.PostalCode = reader["PostalCode"] == DBNull.Value ? "" : (String)reader["PostalCode"];
                customers.Country = reader["Country"] == DBNull.Value ? "" : (String)reader["Country"];
                customers.Phone = reader["Phone"] == DBNull.Value ? "" : (String)reader["Phone"];
                customers.Fax = reader["Fax"] == DBNull.Value ? "" : (String)reader["Fax"];

                Customers.Add(customers);
            }
            conexion.Close();
            return Customers;

        }
    }
}
