<%@ Control Language="C#" Inherits="System.Web.Mvc.ViewUserControl<IEnumerable<Demo.Models.Order>>" %>

this is from the template
<fieldset>
<legend>Orders</legend>
<% foreach (var order in Model) { %>
    <p>
    <%: order.Id %> - <%: order.Amount.ToString("$#.00") %>
    </p>
<% } %>
</fieldset>