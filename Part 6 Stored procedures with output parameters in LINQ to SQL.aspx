<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Part 6 Stored procedures with output parameters in LINQ to SQL.aspx.cs" Inherits="LINQTOSQL.Part_6_Stored_procedures_with_output_parameters_in_LINQ_to_SQL" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:GridView ID="GridView1" runat="server">
        </asp:GridView>
        <asp:Button ID="btnGetData" runat="server" OnClick="btnGetData_Click" Text="Get Data" />
        <asp:Button ID="btnInsertData" runat="server" Text="Insert Tim's Row" OnClick="btnInsertData_Click" />
        <asp:Button ID="btnUpdateData" runat="server" Text="Update Tim's Salary" OnClick="btnUpdateData_Click" />
        <asp:Button ID="btnDeleteData" runat="server" Text="Delete Tim's Salary" OnClick="btnDeleteData_Click"/>
        <div style="margin-left: 40px">
            <asp:Button ID="btnGetEmployeesByDepartment" runat="server" OnClick="btnGetEmployeesByDepartment_Click" Text="GetEmployeesByDepartment" />
        </div>
        <asp:Label runat="server" ID="RydoLabel"></asp:Label>
    </form>
</body>
</html>
