<%@ Page Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<System.Web.Mvc.HandleErrorInfo>" %>

<asp:Content ID="errorTitle" ContentPlaceHolderID="TitleContent" runat="server">
    Error
</asp:Content>
<asp:Content ID="errorContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2>
        Sorry, an error occurred while processing your request.
    </h2>
    <div>
        <p>
            <b>Controller:</b>
            <%= Model.ControllerName %>
        </p>
        <p>
            <b>Action:</b>
            <%= Model.ActionName %>
        </p>
        <p>
            <b>Exception Message:</b>
            <%= Model.Exception.Message %>
        </p>
    </div>
</asp:Content>
