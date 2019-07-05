<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="GenericPopulator._Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
   <title></title>

   <style type="text/css">
      th { background-color: blue; color: White; font-weight: bold; text-align: center; border-bottom: 1px solid black; padding: 3px; }
      td { border-bottom: 1px solid black; padding: 3px; }
   </style>
</head>
<body>
   <form id="form1" runat="server">
   <div>

      <asp:Repeater ID="rptEmployees" runat="server">
         <HeaderTemplate>
            <table border="0" cellpadding="0" cellspacing="0">
            <tr>
               <th>Last Name</th>
               <th>First Name</th>
               <th>Title</th>
               <th>Birth Date</th>
               <th>Hire Date</th>
               <th>City</th>
            </tr>
         </HeaderTemplate>
         <FooterTemplate>
            </table>
         </FooterTemplate>
         <ItemTemplate>
            <tr>
               <td><%# DataBinder.Eval(Container.DataItem, "LastName") %></td>
               <td><%# DataBinder.Eval(Container.DataItem, "FirstName") %></td>
               <td><%# DataBinder.Eval(Container.DataItem, "Title") %></td>
               <td><%# DataBinder.Eval(Container.DataItem, "BirthDate", "{0:MM/dd/yyyy}") %></td>
               <td><%# DataBinder.Eval(Container.DataItem, "HireDate", "{0:MM/dd/yyyy}") %></td>
               <td><%# DataBinder.Eval(Container.DataItem, "City") %></td>
            </tr>
         </ItemTemplate>
      </asp:Repeater>
    
   </div>
   </form>
</body>
</html>
