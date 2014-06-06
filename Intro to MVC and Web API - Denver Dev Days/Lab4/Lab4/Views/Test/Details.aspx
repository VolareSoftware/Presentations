<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<Lab4.ApplicationServices.ViewModel.EmployeeViewModel>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	Details
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <h2>Details</h2>

    <fieldset>
        <legend>Fields</legend>
        <p>
            Id:
            <%= Html.Encode(Model.Id) %>
        </p>
        <p>
            FirstName:
            <%= Html.Encode(Model.FirstName) %>
        </p>
        <p>
            LastName:
            <%= Html.Encode(Model.LastName) %>
        </p>
        <p>
            FullName:
            <%= Html.Encode(Model.FullName) %>
        </p>
        <p>
            Department:
            <%= Html.Encode(Model.Department) %>
        </p>
    </fieldset>
    <p>
        <%=Html.ActionLink("Edit", "Edit", new { /* id=Model.PrimaryKey */ }) %> |
        <%=Html.ActionLink("Back to List", "Index") %>
    </p>

</asp:Content>

