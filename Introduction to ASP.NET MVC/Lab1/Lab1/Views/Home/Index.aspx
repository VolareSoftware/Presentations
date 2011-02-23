<%@ Page Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage" %>

<%--Lab #1, Step #4d--%>
<%--<%@ Page Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<HomeViewModel>" %>
<%@ Import Namespace="Lab1.Models"%>--%>


<asp:Content ID="indexTitle" ContentPlaceHolderID="TitleContent" runat="server">
    Home Page
</asp:Content>

<asp:Content ID="indexContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%= Html.Encode(ViewData["Message"]) %></h2>
    <p>
        To learn more about ASP.NET MVC visit <a href="http://asp.net/mvc" title="ASP.NET MVC Website">http://asp.net/mvc</a>.
    </p>
    
    
    <%--
    Lab #1, Step #2
    <p>
        <% Response.Write("Hello World from View!"); %>
    </p>
    --%>
    
    
    <%--
    Lab #1, Step #4e
    <p>
        <%= Model.Message %>
    </p>
    --%>
    
</asp:Content>