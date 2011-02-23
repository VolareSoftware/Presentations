<%@ Page Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage" %>

<asp:Content ID="aboutTitle" ContentPlaceHolderID="TitleContent" runat="server">
    About Us
</asp:Content>

<asp:Content ID="aboutContent" ContentPlaceHolderID="MainContent" runat="server">
    
    <!-- Lab #8, Step #6 -->
    <%-- 
    <script src="../../Scripts/jquery-1.3.2.min.js" type="text/javascript"></script>
    --%>
    
    
    <!-- Lab #8, Step #7 -->
    <%--
    <script type="text/javascript">
        $(function() {
            $("#btnShowDepartments").click(function() {
                $.getJSON("/Home/GetAllDepartments", null, function(data) {
                    for (item in data) {
                        var department = data[item];
                        $("#divDepartments").append(department.Name, ", ");
                    }
                });                
            });
        });        
    </script>
    --%>

    
    <h2>About</h2>
    <p>
        Put content here.
    </p>
    
    <!-- Lab #8, Step #5 -->
    <p>
        <input id="btnShowDepartments" type="button" value="Show Departments" />
        <div id="divDepartments"></div>
    </p>
    
    
</asp:Content>
