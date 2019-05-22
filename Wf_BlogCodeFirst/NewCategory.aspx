<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="NewCategory.aspx.cs" Inherits="Wf_BlogCodeFirst.NewCategory" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>New Category Add</h1>
    <asp:DropDownList ID="ddlCat" runat="server"></asp:DropDownList>
    <asp:TextBox ID="txtCat" runat="server" placeholde="Category Name" CssClass="form-control"></asp:TextBox>
    <asp:Button ID="btnCat" runat="server" Text="Button" CssClass="btn btn-primary" OnClick="btnCat_Click" />
</asp:Content>
