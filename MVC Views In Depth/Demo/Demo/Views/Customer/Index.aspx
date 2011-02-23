<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<Demo.Models.Customer>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	Index
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <h2>Index</h2>

    <fieldset>
        <legend>Customer</legend>
        
        <%: Html.DisplayForModel() %>
        
    </fieldset>
    <%: Html.DisplayFor(model => model.Orders) %>
    <%--<% Html.RenderPartial("OrderList", Model.Orders); %>--%>

    <p>
        <%: Html.ActionLink("Edit", "Edit", new { id=Model.Id }) %>
    </p>

</asp:Content>

