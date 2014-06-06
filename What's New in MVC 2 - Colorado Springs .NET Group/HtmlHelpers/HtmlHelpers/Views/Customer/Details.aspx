<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<HtmlHelpers.Models.Customer>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	Details
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <h2>Details</h2>

    <fieldset>
        <legend>Fields</legend>
        
        <!-- new way, but more typing -->
        <div class="display-label">FirstName</div>
        <div class="display-field"><%: Model.FirstName %></div>
        
        <div class="display-label">LastName</div>
        <div class="display-field"><%: Model.LastName %></div>
        
        <div class="display-label">City</div>
        <div class="display-field"><%: Model.City %></div>
        
        <div class="display-label">State</div>
        <div class="display-field"><%: Model.State %></div>
        
        <div class="display-label">Zip</div>
        <div class="display-field"><%: Model.Zip %></div>

        <!-- new way using templates -->
        <%= Html.DisplayForModel()%>
        
    </fieldset>
    <p>
        <%: Html.ActionLink("Edit", "Edit", new { /* id=Model.PrimaryKey */ }) %> |
        <%: Html.ActionLink("Back to List", "Index") %>
    </p>

</asp:Content>

