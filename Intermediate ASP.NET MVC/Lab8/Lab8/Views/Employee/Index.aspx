<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<IEnumerable<Lab8.Models.Employee>>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	Index
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <h2>Index</h2>

    <table>
        <tr>
            <th></th>
            <th>
                FirstName
            </th>
            <th>
                LastName
            </th>
            <th>
                Department
            </th>
            <th>
                StartDate
            </th>
        </tr>

    <% foreach (var item in Model) { %>
    
        <tr>
            <td>
                <%= Html.ActionLink("Edit", "Edit", new {  id=item.Id }) %> |
                <%= Html.ActionLink("Details", "Details", new {  id=item.Id })%>
            </td>
            <td>
                <%= Html.Encode(item.FirstName) %>
            </td>
            <td>
                <%= Html.Encode(item.LastName) %>
            </td>
            <td>
                <%= Html.Encode(item.Department) %>
            </td>
            <td>
                <%= Html.Encode(String.Format("{0:g}", item.StartDate)) %>
            </td>
        </tr>
    
    <% } %>

    </table>

    <p>
        <%= Html.ActionLink("Create New", "Create") %>
    </p>

</asp:Content>

