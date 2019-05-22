<%@ Page Title="" Language="C#" MasterPageFile="~/SiteMaster.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Wf_BlogCodeFirst.Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <div class="col-md-12">
            <%foreach (var item in Articles)
                { %>
            <h1><%=item.Title %></h1>     
            <%=item.Content %>
            <div>
                <span class="badge"><%=item.Date.ToString("dd MMMM HH:mm") %></span>
                <div class="pull-right">
                    <%foreach (var t in item.Tags)
                        { %>
                    <span class="label label-default"><%=t.Name %></span>                 
                       <% } %>
                </div>
            </div>
            <hr>
            <% } %>
        </div>
    </div>
</asp:Content>
