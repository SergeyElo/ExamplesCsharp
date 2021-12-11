<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebPrim01._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h1>ASP.NET</h1>
        <p class="lead">ASP.NET is a free web framework for building great Web sites and Web applications using HTML, CSS, and JavaScript.</p>
        <p><a href="http://www.asp.net" class="btn btn-primary btn-lg">Learn more &raquo;</a></p>
    </div>

    <div class="row">
        <div class="col-md-4">
            <p>
                &nbsp;</p>
            <p>
                User:&nbsp;&nbsp;
                <asp:RadioButtonList ID="RadioButtonList1" runat="server" RepeatDirection="Horizontal" Width="149px">
                    <asp:ListItem Selected="True" Value="1">first</asp:ListItem>
                    <asp:ListItem Value="2">second</asp:ListItem>
                </asp:RadioButtonList>
            </p>
            <p>
                &nbsp; Message:&nbsp;
                <asp:TextBox ID="TextBoxMessage" runat="server" Height="28px" Width="444px"></asp:TextBox>
&nbsp;&nbsp;&nbsp;
            </p>
            <p>
                &nbsp;</p>
            <p>
                <asp:Button ID="ButtonSend" runat="server" OnClick="ButtonSend_Click" Text="Send" Width="140px" />
            </p>
            <p>
                Messages:</p>
        </div>
        <div class="col-md-4">
            <asp:ListBox ID="ListBox1" runat="server" Height="122px" Width="401px"></asp:ListBox>
        </div>
        <div class="col-md-4">
            <h2></h2>
        </div>
    </div>

</asp:Content>
