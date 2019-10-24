<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Recommendations.aspx.cs" Inherits="BookWebApp.MyWork.Recommendations" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <p>
        <strong>
        <br style="font-size: xx-large" />
        </strong><span style="font-size: xx-large"><strong>Show Result</strong></span></p>
    <p>
        <asp:ListBox ID="ListBox1" runat="server" Height="239px" OnSelectedIndexChanged="ListBox1_SelectedIndexChanged" Width="418px"></asp:ListBox>
    </p>
    <p>
        <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/MyWork/Options.aspx">Show Options</asp:HyperLink>
    </p>
</asp:Content>
