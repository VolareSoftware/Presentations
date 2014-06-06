<%@ Control Language="C#" Inherits="System.Web.Mvc.ViewUserControl" %>

<%: Html.TextBox(null, 
        Model != null 
        ? Model.ToString() 
        : "[please enter a value]") 
%>