using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LINQTOSQL
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            RydoEntities rydodbContext = new RydoEntities();

            //START-----------------List of Employees in easy way.--------------
            //List<Employees> rydolistemployees = rydodbContext.Employees.ToList();
            //GridView1.DataSource = rydolistemployees.ToList();
            //GridView1.DataBind();
            //END-----------------List of Employees in easy way.--------------

            //START-----------------List of Employees using LINQ Quert.--------------
            IQueryable<Employee> rydolistemployees = from rydoemployee in rydodbContext.Employees
                                                     select rydoemployee;
            GridView1.DataSource = rydolistemployees.ToList();
            GridView1.DataBind();
            //END-----------------List of Employees in easy way.--------------


            // START----------------List of "MALE" Employees.--------
            //IQueryable<Employees> rydolistemployees = from rydoemployee in rydodbContext.Employees
            //                                    where rydoemployee.Gender=="Male"
            //                                    orderby rydoemployee.Salary descending
            //                                    select rydoemployee;

            //GridView1.DataSource = rydolistemployees.ToList();
            //GridView1.DataBind();

            //            SELECT
            //    [Extent1].[ID] AS[ID], 
            //    [Extent1].[FirstName] AS[FirstName], 
            //    [Extent1].[LastName] AS[LastName], 
            //    [Extent1].[Gender] AS[Gender], 
            //    [Extent1].[Salary] AS[Salary], 
            //    [Extent1].[DepartmentId]
            //        AS[DepartmentId]
            //FROM[dbo].[Employees]
            //        AS[Extent1]
            //WHERE N'Male' = [Extent1].[Gender]
            //        ORDER BY[Extent1].[Salary]
            //        DESC

            // END----------------List of "MALE" Employees.--------
        }
    }
}