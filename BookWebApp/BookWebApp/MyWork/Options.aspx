<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Options.aspx.cs" Inherits="BookWebApp.MyWork.Options" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <p>
        <strong>
        <br style="font-size: xx-large" />
        </strong><span style="font-size: xx-large"><strong>Select</strong></span></p>
    <p>
        <asp:RadioButtonList ID="RadioButtonList1" runat="server">
            <asp:ListItem Value="6519815">C#.NET</asp:ListItem>
            <asp:ListItem Value="84651651">Java</asp:ListItem>
            <asp:ListItem Value="35465181">VB</asp:ListItem>
            <asp:ListItem Value="6854641">Lisp</asp:ListItem>
        </asp:RadioButtonList>
    </p>
    <p>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Submit" />
    </p>
    <p>
        <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/MyWork/Recommendations.aspx">Show Books</asp:HyperLink>
    </p>
    <p>
    </p>
    <p>
    </p>
</asp:Content>
