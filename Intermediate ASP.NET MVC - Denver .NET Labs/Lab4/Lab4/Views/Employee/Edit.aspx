<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<Lab4.ApplicationServices.ViewModel.EmployeeViewModel>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    Edit
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <h2>
        Edit</h2>
    <%= Html.ValidationSummary("Edit was unsuccessful. Please correct the errors and try again.") %>
    <% using (Html.BeginForm())
       {%>
    <fieldset>
        <legend>Fields</legend>
        <p>
            <label for="FirstName">
                FirstName:</label>
            <%= Html.TextBox("FirstName", Model.FirstName) %>
            <%= Html.ValidationMessage("FirstName", "*") %>
        </p>
        <p>
            <label for="LastName">
                LastName:</label>
            <%= Html.TextBox("LastName", Model.LastName) %>
            <%= Html.ValidationMessage("LastName", "*") %>
        </p>
        <p>
            <label for="Department">
                Department:</label>
            <%= Html.TextBox("Department", Model.Department) %>
            <%= Html.ValidationMessage("Department", "*") %>
        </p>
        <p>
            <input type="submit" value="Save" />
        </p>
    </fieldset>
    <% } %>
    <div>
        <%=Html.ActionLink("Back to List", "Index") %>
    </div>
</asp:Content>
