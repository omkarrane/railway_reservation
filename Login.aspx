<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="WebApplication1.WebForm3" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" href="CSS.css" />
    <style>
        .trans{
            background-color: black;
            opacity: 0.6;
            filter: alpha(opacity=60);
            width: 446px;
            margin-left: 257px;
            margin-top: 26px;
            color: #FFFFFF;
            font-style: normal;
        }
        .newStyle1 {
            background-image: url('Images/Login%20image.jpg' );
            background-size: cover;
            background-repeat: no-repeat;
        }
        .newStyle1 {
            background-image: url('Images/Login image.jpg');
        }
    </style>
</head>
<body class="newStyle1">
    <div style="text-align : center">
       

    <form id="form1" runat="server">
        <div class="bar">
            <asp:Image ID="Image1" runat="server" ImageUrl="~/Images/final_finalest_pakka_final_logo.png" Height="75px" ImageAlign="Left" style="margin-left: 13px; margin-top: 8px" Width="159px" />
        </div>
        <br />
        <br />
        <br />
        <br />
        <br />
        <div class="trans">
        <br />
        <br />
        <asp:Label ID="Label3" runat="server" CssClass="label" Text="The one-stop shop for your train travel" style="color:#FF0000; font-size: x-large;" ForeColor="Red"></asp:Label>
        <br />
        <br />
        <br />
        <asp:Label ID="Label1" runat="server" Text="UserID" CssClass="label" style="color:#FFFFFF; font-style: normal; font-size: x-large;"></asp:Label>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;
        <asp:TextBox ID="userid" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label2" runat="server" Text="Password" CssClass="label" style="color:#FFFFFF; font-style: normal; font-size: x-large;"></asp:Label>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="userpass" runat="server" TextMode="Password"></asp:TextBox>
        <br />
        <asp:Label ID="Msg" runat="server"></asp:Label>
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" OnClick="Logon_Click" Text="Login" Height="37px" Width="200px" CssClass="button" OnClientClick="Logon_Click" />
        &nbsp;&nbsp;&nbsp;&nbsp;<asp:Button ID="Button2" runat="server" CssClass="button" Height="37px" Text="Reset" Width="200px" OnClick="Button2_Click" />
            <br />
            <br />
    </div></form>
        </div>
    <p>
        &nbsp;</p>
</body>
</html>
