<%@ Page Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage" %>

<%--Step #5d--%>
<%--
<%@ Page Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<HelloWorld.Models.HomeViewModel>" %>
--%>


<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    Home Page
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: ViewData["Message"] %></h2>
    <p>
        To learn more about ASP.NET MVC visit <a href="http://asp.net/mvc" title="ASP.NET MVC Website">http://asp.net/mvc</a>.
    </p>


    <%--Step #3--%>
    <%--
    <p>
        <% Response.Write("Hello World from View!"); %>
    </p>
    --%>
    
    
    <%--Step #5e--%>
    <%--
    <p>
        <%= Model.Message %>
    </p>
    --%>
    

</asp:Content>
