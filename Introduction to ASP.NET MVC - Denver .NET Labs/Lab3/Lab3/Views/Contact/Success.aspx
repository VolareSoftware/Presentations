<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<ContactViewModel>" %>
<%@ Import Namespace="Lab3.Models"%>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    Success
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <h2>
        Success</h2>
    <p>
        Thanks for sending us your contact info, <%= Model.FirstName %>.
    </p>
    
</asp:Content>
