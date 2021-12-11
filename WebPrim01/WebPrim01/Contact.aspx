<%@ Page Title="Contact" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Contact.aspx.cs" Inherits="WebPrim01.Contact" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: Title %>.</h2>
    <h3>Your contact page.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        </h3>
    <address>
        One Microsoft Way<br />
        Redmond, WA 98052-6399<br />
        <abbr title="Phone">P:</abbr>
        425.555.0100&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="LabelUser" runat="server" Text="..."></asp:Label>
    </address>
    <address>
        &nbsp;<asp:Button ID="Button1" runat="server" Height="25px" OnClick="Button1_Click" Text="Show Users" Width="90px" />
        <asp:Button ID="Button2" runat="server" Height="25px" OnClick="Button2_Click" Text="Clear" Width="92px" />
        <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="Messages" />
    </address>
    <address>
        <asp:ListBox ID="ListBox1" runat="server" Height="108px" Width="259px" OnSelectedIndexChanged="ListBox1_SelectedIndexChanged"></asp:ListBox>
    </address>

    <address>
        <strong>Support:</strong>   <a href="mailto:Support@example.com">Support@example.com</a><br />
        <strong>Marketing:</strong> <a href="mailto:Marketing@example.com">Marketing@example.com</a>
    </address>
</asp:Content>
