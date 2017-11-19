<%@ Page Title="" Language="C#" MasterPageFile="~/Navigation.Master" AutoEventWireup="true" CodeBehind="Update.aspx.cs" Inherits="WebApplication1.WebForm2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
     <link rel="stylesheet" href="CSS.css" media="all"/>
      <script type="text/javascript" src="https://ajax.googleapis.com/ajax/libs/jquery/1.9.1/jquery.min.js"></script>

</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="form" runat="server">

    <form id="form1" runat="server">
        <asp:Label ID="Label1" runat="server" Text="Enter Booking ID"></asp:Label>
        <br />
        <br />
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>

        <br />
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" CssClass="button" OnClick="btnFind_Click" Text="Find" Font-Size="Medium" />
        <br />
        <br />
        <asp:Label ID="Label2" runat="server" Text="Enter Train ID"></asp:Label>
        <br />
        <br />
        <asp:DropDownList ID="droptrain" runat="server" CssClass="dropsource" AutoPostBack="True">
        </asp:DropDownList>
        <br />
        <br />
        Enter Source Location<br />
        <asp:DropDownList ID="dropsource" runat="server" CssClass="dropdestination" OnSelectedIndexChanged="dropsource_SelectedIndexChanged" AutoPostBack="True">
        </asp:DropDownList>
        <br />
        <br />
        <br />
        Enter Destination<br />
        <br />
        <asp:DropDownList ID="dropdestination" runat="server" CssClass="dropdestination" OnSelectedIndexChanged="dropdestination_SelectedIndexChanged" AutoPostBack="True">
        </asp:DropDownList>
        <br />
        <br />
        Enter Number of Passengers<br />
        <br />
        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="Button2" runat="server" CssClass="button" OnClick="Button2_Click" Text="Update" Font-Size="Medium" />
        <br />

    </form>

</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="Footer" runat="server">
</asp:Content>
