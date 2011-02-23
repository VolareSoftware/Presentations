<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    Index
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <h2>
        Contact Form
    </h2>
    
    <%--Lab #2, Step #3--%>
    <% using (Html.BeginForm()) { %>
        <div>
            <fieldset>
                <legend>Contact Information</legend>
                <p>
                    <label for="FirstName">
                        First Name
                    </label>
                    <%= Html.TextBox("FirstName") %>
                </p>
                <p>
                    <label for="LastName">
                        Last Name
                    </label>
                    <%= Html.TextBox("LastName")%>
                </p>
                <p>
                    <label for="Phone">
                        Phone
                    </label>
                    <%= Html.TextBox("Phone")%>
                </p>
                <p>
                    <label for="Email">
                        Email
                    </label>
                    <%= Html.TextBox("Email") %>
                </p>
                <p>
                    <input type="submit" value="Submit" />
                </p>
            </fieldset>
        </div>
    <% } %>    
    
</asp:Content>
