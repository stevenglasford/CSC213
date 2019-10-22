<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="book.aspx.cs" Inherits="TestWebApp.MyWork.book" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <p>
        <br />
        <asp:Label ID="Label1" runat="server" style="font-size: xx-large" Text="Label"></asp:Label>
    </p>
    <p>
        Please Fill</p>
    <table style="width: 100%; color: #000000; background-color: #FFFFFF;">
        <tr>
            <td style="width: 237px">Name</td>
            <td style="width: 554px">
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtName" ErrorMessage="Enter A Name" ForeColor="Red"></asp:RequiredFieldValidator>
                <br />
                <asp:TextBox ID="txtName" runat="server" height="22px" width="496px"></asp:TextBox>
                <br />
                Please Enter Your Name</td>
            <td>Johnny Appleseed</td>
        </tr>
        <tr>
            <td style="width: 237px">Email</td>
            <td style="width: 554px">
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtEmail" ErrorMessage="Enter An Email" ForeColor="Red"></asp:RequiredFieldValidator>
                <br />
                <asp:TextBox ID="txtEmail" runat="server" height="22px" width="496px"></asp:TextBox>
                <br />
                Please Enter your Email</td>
            <td>asd@ghj.com<asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="txtEmail" ErrorMessage="Invalid Email" ForeColor="Red" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
            </td>
        </tr>
        <tr>
            <td style="width: 237px">Phone</td>
            <td style="width: 554px">
                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="txtPhone" ErrorMessage="Enter A Phone Number" ForeColor="Red"></asp:RequiredFieldValidator>
                <br />
                <asp:TextBox ID="txtPhone" runat="server" Width="492px"></asp:TextBox>
                <br />
                Please Enter Your Phone Number</td>
            <td>(555) 555-1234<asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ControlToValidate="txtPhone" ErrorMessage="Invalid Phone Number" ForeColor="Red" ValidationExpression="((\(\d{3}\) ?)|(\d{3}-))?\d{3}-\d{4}"></asp:RegularExpressionValidator>
            </td>
        </tr>
        <tr>
            <td style="width: 237px; height: 26px">
                <asp:Button ID="Button1" runat="server" Text="Submit" />
            </td>
            <td style="width: 554px; height: 26px"></td>
            <td style="height: 26px"></td>
        </tr>
    </table>
    <p>
        <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
        <asp:Wizard ID="Wizard1" runat="server">
            <WizardSteps>
                <asp:WizardStep runat="server" title="Step 1">
                </asp:WizardStep>
                <asp:WizardStep runat="server" title="Step 2">
                </asp:WizardStep>
            </WizardSteps>
        </asp:Wizard>
        <asp:MultiView ID="MultiView1" runat="server">
        </asp:MultiView>
    </p>
    <asp:Panel ID="Panel1" runat="server">
    </asp:Panel>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
</asp:Content>
