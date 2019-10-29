<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="newstudent.aspx.cs" Inherits="Oct29.MyWork.newstudent" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <p>
        <br />
    </p>
    <p>
        <table style="width:100%;">
            <tr>
                <td style="height: 20px; width: 132px">First Name</td>
                <td style="height: 20px; width: 657px">
                    <asp:TextBox ID="txtFirst" runat="server"></asp:TextBox>
                </td>
                <td style="height: 20px"></td>
            </tr>
            <tr>
                <td style="width: 132px">Last Name</td>
                <td style="width: 657px">
                    <asp:TextBox ID="txtLast" runat="server"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td style="width: 132px">GPA</td>
                <td style="width: 657px">
                    <asp:TextBox ID="txtGPA" runat="server"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td style="width: 132px; height: 22px">Username</td>
                <td style="height: 22px; width: 657px">
                    <asp:TextBox ID="txtUserName" runat="server"></asp:TextBox>
                </td>
                <td style="height: 22px"></td>
            </tr>
            <tr>
                <td style="width: 132px">Password</td>
                <td style="width: 657px">
                    <asp:TextBox ID="txtPassword" runat="server" TextMode="Password"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
        </table>
    </p>
    <p>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Add" />
    </p>
    <p>
        <asp:GridView ID="GridView1" runat="server" Height="149px" Width="627px">
        </asp:GridView>
    </p>
    <p>
    </p>
    <p>
    </p>
    <p>
    </p>
    <p>
    </p>
    <p>
    </p>
    <p>
    </p>
</asp:Content>
