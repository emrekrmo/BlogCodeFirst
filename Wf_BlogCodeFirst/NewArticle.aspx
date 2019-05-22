<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="NewArticle.aspx.cs" Inherits="Wf_BlogCodeFirst.NewArticle" EnableEventValidation="false" ValidateRequest="false" %>

<%--EnableEventValidation="false" ValidateRequest="false" added--%>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="Assets/select2/css/select2.min.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Add New Article</h1>
    <asp:TextBox ID="txtHeader" runat="server" placeholder="Header"></asp:TextBox>
    <asp:TextBox ID="txtContent" runat="server" placeholder="Content" TextMode="MultiLine"></asp:TextBox><%--TextMode="MultiLine" to let content save--%>
    <select class="js-example-basic-multiple" name="tags[]" multiple="multiple">
        <%foreach (var item in AllTags)
            { %>
        <option value="<%=item.TagId %>"><%=item.Name %></option>
        <% } %>
    </select>
    <%--<asp:TextBox ID="txtTags" runat="server" placeholder="Tags"></asp:TextBox>--%>
    <asp:DropDownList ID="ddlCategory" runat="server"></asp:DropDownList>
    <asp:Button ID="btnAdd" runat="server" Text="Button" OnClick="btnAdd_Click" />
    <script src="//code.jquery.com/jquery-1.11.1.min.js"></script>
    <script src="Assets/select2/js/select2.min.js"></script>
    <script src="Assets/ckeditor/ckeditor.js"></script>
    <script>
        $(document).ready(function () {
            $('.js-example-basic-multiple').select2();
        });
        CKEDITOR.replace('ContentPlaceHolder1_txtContent', {
            extraPlugins: 'easyimage',
            removePlugins: 'image',
            cloudServices_tokenUrl: 'https://example.com/cs-token-endpoint',
            cloudServices_uploadUrl: 'https://your-organization-id.cke-cs.com/easyimage/upload/'
        });
    </script>
</asp:Content>
