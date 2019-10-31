<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="logon.aspx.cs" Inherits="Halloween.logon" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
    <asp:Login ID="Login1" runat="server" Height="83px" OnAuthenticate="Login1_Authenticate" Width="281px">
    </asp:Login>
    <br />
</p>
<p>
</p>
<p>
</p>
</asp:Content>
