<%--Lab #2, Step #6--%>
<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<ContactViewModel>" %>
<%@ Import Namespace="Lab2.Models"%>


<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    Success
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <h2>
        Success
    </h2>    
    
    <%--Lab #2, Step #6a--%>    
    <p>
        Thanks for sending us your contact info, <%= Model.FirstName %>.
    </p>  
    
</asp:Content>
