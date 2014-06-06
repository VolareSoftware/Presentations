<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<HtmlHelpers.Models.Customer>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    Create
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <h2>
        Create</h2>
    <% using (Html.BeginForm())
       {%>
    <%: Html.ValidationSummary(true) %>
    <fieldset>
        <legend>Fields</legend>
        
        <!-- new way, but more typing -->
        <div class="editor-label">
            <%: Html.LabelFor(model => model.FirstName) %>
        </div>
        <div class="editor-field">
            <%: Html.TextBoxFor(model => model.FirstName)%>
            <%: Html.ValidationMessageFor(model => model.FirstName)%>
        </div>
        <div class="editor-label">
            <%: Html.LabelFor(model => model.LastName) %>
        </div>
        <div class="editor-field">
            <%: Html.TextBoxFor(model => model.LastName) %>
            <%: Html.ValidationMessageFor(model => model.LastName) %>
        </div>
        <div class="editor-label">
            <%: Html.LabelFor(model => model.City) %>
        </div>
        <div class="editor-field">
            <%: Html.TextBoxFor(model => model.City) %>
            <%: Html.ValidationMessageFor(model => model.City) %>
        </div>
        <div class="editor-label">
            <%: Html.LabelFor(model => model.State) %>
        </div>
        <div class="editor-field">
            <%: Html.TextBoxFor(model => model.State) %>
            <%: Html.ValidationMessageFor(model => model.State) %>
        </div>
        <div class="editor-label">
            <%: Html.LabelFor(model => model.Zip) %>
        </div>
        <div class="editor-field">
            <%: Html.TextBoxFor(model => model.Zip) %>
            <%: Html.ValidationMessageFor(model => model.Zip) %>
        </div>
        
        <p>
            <input type="submit" value="Create" />
        </p>
    </fieldset>
    <% } %>
    <div>
        <%: Html.ActionLink("Back to List", "Index") %>
    </div>
</asp:Content>
