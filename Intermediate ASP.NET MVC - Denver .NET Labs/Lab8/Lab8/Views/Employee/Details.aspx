<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<Lab8.Models.Employee>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	Details
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <h2>Details</h2>

    <fieldset>
        <legend>Fields</legend>
        <p>
            FirstName:
            <%= Html.Encode(Model.FirstName) %>
        </p>
        <p>
            LastName:
            <%= Html.Encode(Model.LastName) %>
        </p>
        <p>
            Department:
            <%= Html.Encode(Model.Department) %>
        </p>
        <p>
            StartDate:
            <%= Html.Encode(String.Format("{0:g}", Model.StartDate)) %>
        </p>
    </fieldset>
    <p>
        <%=Html.ActionLink("Edit", "Edit", new { id = Model.Id })%> |        
        <%=Html.ActionLink("Back to List", "Index") %>
    </p>

</asp:Content>

