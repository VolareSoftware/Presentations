<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<Lab8.Models.Employee>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	Create
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <!-- Lab #8, Step #6 -->
    <%-- 
    <script src="../../Scripts/jquery-1.3.2.min.js" type="text/javascript"></script>
    --%>
    
    
    <!-- Lab #8, Step #7 -->
    <%--
    <script type="text/javascript">
        $(function() {
            $("#btnShowDepartments").click(function() {
                $.getJSON("/Employee/GetAllDepartments", null, function(data) {
                    for (item in data) {
                        var department = data[item];
                        $("#divDepartments").append(department.Name, ", ");
                    }
                });                
            });
        });        
    </script>
    --%>
    

    <h2>Create</h2>

    <%= Html.ValidationSummary("Create was unsuccessful. Please correct the errors and try again.") %>

    <% using (Html.BeginForm()) {%>

        <fieldset>
            <legend>Fields</legend>
            <p>
                <label for="FirstName">FirstName:</label>
                <%= Html.TextBox("FirstName") %>
                <%= Html.ValidationMessage("FirstName", "*") %>
            </p>
            <p>
                <label for="LastName">LastName:</label>
                <%= Html.TextBox("LastName") %>
                <%= Html.ValidationMessage("LastName", "*") %>
            </p>
            <p>
                <label for="Department">Department:</label>
                <%= Html.TextBox("Department") %>
                <%= Html.ValidationMessage("Department", "*") %>
                
            </p>
            
            <!-- Lab #8, Step #5 -->            
            <%--
            <p>
                <input id="btnShowDepartments" type="button" value="Show Departments" />
                <p id="divDepartments"></p>
            </p>
            --%>
                     
            
            <p>
                <label for="StartDate">StartDate:</label>
                <%= Html.TextBox("StartDate") %>
                <%= Html.ValidationMessage("StartDate", "*") %>
            </p>
            <p>
                <input type="submit" value="Create" />
            </p>
        </fieldset>

    <% } %>

    <div>
        <%=Html.ActionLink("Back to List", "Index") %>
    </div>

</asp:Content>

