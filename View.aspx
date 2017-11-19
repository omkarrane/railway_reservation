<%@ Page Title="" Language="C#" MasterPageFile="~/Navigation.Master" AutoEventWireup="true" CodeBehind="View.aspx.cs" Inherits="WebApplication1.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" href="CSS.css" media="all"/>
      <script type="text/javascript" src="https://ajax.googleapis.com/ajax/libs/jquery/1.9.1/jquery.min.js"></script>

</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="Footer" runat="server">
</asp:Content>
<asp:Content ID="Content5" runat="server" contentplaceholderid="form">
    <form id="form1" runat="server">
        <p>
            <asp:Label ID="Label1" runat="server" Text="Enter Booking ID"></asp:Label>
&nbsp;
        </p>
        <p>
&nbsp;<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Button ID="Button" runat="server" OnClick="Button_Click" Text="View" CssClass="button" Font-Size="Medium" />
        </p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            <asp:GridView ID="GridView1" runat="server" OnRowCreated="bla_RowCreated" OnRowDeleting="GridView1_RowDeleting" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" AutoGenerateColumns="False" OnRowUpdating="GridView1_RowUpdating" OnRowEditing="GridView1_RowEditing">
                <Columns>
                    <asp:TemplateField HeaderText="Booking ID">
                        <ItemTemplate>
                            <asp:TextBox ID="TextBox2" runat="server" Text='<%# Eval("bookid") %>'></asp:TextBox>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Train ID">
                        <ItemTemplate>
                            <asp:TextBox ID="TextBox3" runat="server" Text='<%# Eval("train_id") %>'></asp:TextBox>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="No of Passengers">
                        <ItemTemplate>
                            <asp:TextBox ID="TextBox4" runat="server" Text='<%# Eval("train_nop") %>'></asp:TextBox>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Category">
                        <ItemTemplate>
                            <asp:TextBox ID="TextBox5" runat="server" Text='<%# Eval("train_ac") %>'></asp:TextBox>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Date of Booking">
                        <ItemTemplate>
                            <asp:TextBox ID="TextBox6" runat="server" Text='<%# Eval("dateofbooking") %>'></asp:TextBox>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:CommandField HeaderText="Delete" ShowDeleteButton="True" />
                    <asp:CommandField HeaderText="Update" ShowEditButton="True" />
                </Columns>
            </asp:GridView>
        </p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            <br />
        </p>
        <p>
        </p>
        <p>
        </p>
        <p>
        </p>
    </form>
</asp:Content>

