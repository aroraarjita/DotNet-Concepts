using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace BusinessLibrary
{
    public class EmployeeBusinessLayer
    {
       
        public IEnumerable<Employee> Employees
        {
            get
            {
                string connectionString = ConfigurationManager.ConnectionStrings["EmployeeContext"].ConnectionString;
                List<Employee> employees = new List<Employee>();


                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand("spGetAllEmployees", connection);
                    command.CommandType = CommandType.StoredProcedure;
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        Employee employee = new Employee();
                        employee.Id = Convert.ToInt32(reader["EmployeeId"]);
                        employee.Name = reader["Name"].ToString();
                        employee.Gender = reader["Gender"].ToString();
                        employee.City = reader["City"].ToString();

                        if(!(reader["DateOfBirth"] is DBNull))
                        {
                            employee.DateOfBirth = Convert.ToDateTime(reader["DateOfBirth"]);
                        }
                        
                        employees.Add(employee);

                    }

                    return employees;
                }




            }

        }

        public void AddEmployee(Employee employee)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["EmployeeContext"].ConnectionString;


             using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("spAddEmployee", con);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter paraName = new SqlParameter();
                paraName.ParameterName = "@Name";
                paraName.Value = employee.Name;
                cmd.Parameters.Add(paraName);

                SqlParameter paraGender = new SqlParameter();
                paraGender.ParameterName = "@Gender";
                paraGender.Value = employee.Gender;
                cmd.Parameters.Add(paraGender);

                SqlParameter paraCity = new SqlParameter();
                paraCity.ParameterName = "@City";
                paraCity.Value = employee.City;
                cmd.Parameters.Add(paraCity);

                SqlParameter paramDateOfBirth = new SqlParameter();
                paramDateOfBirth.ParameterName = "@DateOfBirth";
                paramDateOfBirth.Value = employee.DateOfBirth;
                cmd.Parameters.Add(paramDateOfBirth);


                SqlParameter paramDepartmentId = new SqlParameter();
                paramDepartmentId.ParameterName = "@DepartmentId";
                paramDepartmentId.Value = employee.DepartmentId;
                cmd.Parameters.Add(paramDepartmentId);



                con.Open();
                cmd.ExecuteNonQuery();

            }


        }

        public void SaveEmployee(Employee employee)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["EmployeeContext"].ConnectionString;


            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("spSaveEmployee", con);
                cmd.CommandType = CommandType.StoredProcedure;


                SqlParameter paraId = new SqlParameter();
                paraId.ParameterName = "@Id";
                paraId.Value = employee.Id;
                cmd.Parameters.Add(paraId);

                SqlParameter paraName = new SqlParameter();
                paraName.ParameterName = "@Name";
                paraName.Value = employee.Name;
                cmd.Parameters.Add(paraName);

                SqlParameter paraGender = new SqlParameter();
                paraGender.ParameterName = "@Gender";
                paraGender.Value = employee.Gender;
                cmd.Parameters.Add(paraGender);

                SqlParameter paraCity = new SqlParameter();
                paraCity.ParameterName = "@City";
                paraCity.Value = employee.City;
                cmd.Parameters.Add(paraCity);

                SqlParameter paramDateOfBirth = new SqlParameter();
                paramDateOfBirth.ParameterName = "@DateOfBirth";
                paramDateOfBirth.Value = employee.DateOfBirth;
                cmd.Parameters.Add(paramDateOfBirth);


                SqlParameter paramDepartmentId = new SqlParameter();
                paramDepartmentId.ParameterName = "@DepartmentId";
                paramDepartmentId.Value = employee.DepartmentId;
                cmd.Parameters.Add(paramDepartmentId);



                con.Open();
                cmd.ExecuteNonQuery();

            }





        }
        
        public void DeleteEmployee(int id)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["EmployeeContext"].ConnectionString;

            using(SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand("spDeleteEmployee", connection);
                command.CommandType = CommandType.StoredProcedure;

                SqlParameter sqlParameter = new SqlParameter();
                sqlParameter.ParameterName = "@Id";
                sqlParameter.Value = id;
                command.Parameters.Add(sqlParameter);
                connection.Open();
                command.ExecuteNonQuery();

            }

        }
    }
}
