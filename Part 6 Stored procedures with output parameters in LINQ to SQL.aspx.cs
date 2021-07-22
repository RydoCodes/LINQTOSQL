﻿using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Objects;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LINQTOSQL
{
    public partial class Part_6_Stored_procedures_with_output_parameters_in_LINQ_to_SQL : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            GetAllRydoEmployees();
        }

        private void GetAllRydoEmployees()
        {
            RydoEntities rydodbContext = new RydoEntities();
            var rydolistemployees = rydodbContext.GetEmployees();

            GridView1.DataSource = rydolistemployees.ToList();
            GridView1.DataBind();
        }

        protected void btnGetData_Click(object sender, EventArgs e)
        {
            GetAllRydoEmployees();
        }

        protected void btnInsertData_Click(object sender, EventArgs e)
        {
            using (RydoEntities rydodbContext = new RydoEntities())
            {
                Employee newEmployee = new Employee
                {
                    FirstName = "Tim",
                    LastName = "T",
                    Gender = "Male",
                    Salary = 55000,
                    DepartmentId = 1
                };

                rydodbContext.Employees.Add(newEmployee);
                rydodbContext.SaveChanges();
            }

            GetAllRydoEmployees();
        }

        protected void btnUpdateData_Click(object sender, EventArgs e)
        {
            using (RydoEntities rydodbContext = new RydoEntities())
            {
                Employee rydoemployee = rydodbContext.Employees.FirstOrDefault(x => x.ID == 9);

                rydoemployee.Salary = 65000;
                rydodbContext.SaveChanges();
            }
        }

        protected void btnDeleteData_Click(object sender, EventArgs e)
        {
            using (RydoEntities rydodbContext = new RydoEntities())
            {
                Employee rydoemployee = rydodbContext.Employees.FirstOrDefault(x => x.ID == 9);
                rydodbContext.Employees.Remove(rydoemployee);
                rydodbContext.SaveChanges();
            }
        }

        protected void btnGetEmployeesByDepartment_Click(object sender, EventArgs e)
        {
            using (RydoEntities rydodbContext = new RydoEntities())
            {
                ObjectParameter objectParameter = new ObjectParameter("DeptName", typeof(string));
                objectParameter.Value = "test";

                GridView1.DataSource = rydodbContext.GetEmployeesByDepartment(1, objectParameter).ToList(); // This does not work. You need to ask about it.
                GridView1.DataBind();

                RydoLabel.Text = $"Rydo Label is {objectParameter.Name}";
            }
        }
    }
}