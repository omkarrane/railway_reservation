<%@ Page Title="" Language="C#" MasterPageFile="~/Navigation.Master" AutoEventWireup="true" CodeBehind="Booking.aspx.cs" Inherits="WebApplication1.WebForm5" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" href="CSS.css" media="all" />
        <script type="text/javascript" src="https://ajax.googleapis.com/ajax/libs/jquery/1.9.1/jquery.min.js"></script>

</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="form" runat="server">
    <form id="form1" runat="server">
        <div style="text-align:right">
            </div>
        <asp:Label ID="Label8" runat="server" Text="Label"></asp:Label>
        <br /><br /><br />
        <asp:Label ID="Label1" runat="server" Text="From Location" CssClass="booking_text"></asp:Label><br />
        <asp:DropDownList ID="dropsource"  CssClass="dropsource" runat="server" AutoPostBack="True" DataSourceID="SqlDataSource1" DataTextField="TRAIN_FROM" DataValueField="TRAIN_FROM"></asp:DropDownList>
        
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="Data Source=inchnilpdb02\mssqlserver1;Initial Catalog=CHN39_MMS249_TEST;User ID=mms249user;Password=mms249user" ProviderName="System.Data.SqlClient" SelectCommand="SELECT DISTINCT [TRAIN_FROM] FROM [TBL_TRAIN_TEAM3]"></asp:SqlDataSource>
        
        <br />
        
        <asp:CompareValidator ID="CompareValidator2" runat="server" ErrorMessage="Enter Correct Source" ControlToValidate="dropsource" Operator="LessThan" Type="String" ValueToCompare="Select"></asp:CompareValidator>
        &nbsp;<br />
        <br />
        <asp:Label ID="Label2" runat="server" Text="To Location"></asp:Label><br />
        <asp:DropDownList ID="dropdestination"  CssClass="dropdestination" runat="server" AutoPostBack="True" DataSourceID="SqlDataSource2" DataTextField="TRAIN_TO" DataValueField="TRAIN_TO"></asp:DropDownList>
        <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:CHN39_MMS249_TESTConnectionString %>" SelectCommand="SELECT DISTINCT [TRAIN_TO] FROM [TBL_TRAIN_TEAM3] WHERE ([TRAIN_TO] NOT LIKE '%' + @TRAIN_TO + '%')">
            <SelectParameters>
                <asp:ControlParameter ControlID="dropsource" DefaultValue="AHEMDABAD" Name="TRAIN_TO" PropertyName="SelectedValue" Type="String" />
            </SelectParameters>
        </asp:SqlDataSource>
        <asp:CompareValidator ID="CompareValidator3" runat="server" ErrorMessage="Enter Correct Destination" ControlToValidate="dropdestination" Operator="LessThan" Type="String" ValueToCompare="Select"></asp:CompareValidator>
        
        <br />
        <br />
        
        <br />
        <asp:Label ID="Label3" runat="server" Text="Enter Compartment Type"></asp:Label>
    <br />
    <br />
        <asp:RadioButtonList ID="RadioButtonList1" runat="server">
            <asp:ListItem Value="1">AC</asp:ListItem>
            <asp:ListItem Value="0">Non-AC</asp:ListItem>
        </asp:RadioButtonList>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="RadioButtonList1" ErrorMessage="Choose Compartment Type"></asp:RequiredFieldValidator>
        <br />
        <br />
    <br />





        <asp:Label ID="Label4" runat="server" Text="Enter Train Number"></asp:Label><br />
        <asp:DropDownList ID="droptrain" CssClass="droptrain" runat="server" DataSourceID="SqlDataSource3" DataTextField="TRAIN_ID" DataValueField="TRAIN_ID">
        </asp:DropDownList>
        <asp:SqlDataSource ID="SqlDataSource3" runat="server" ConnectionString="<%$ ConnectionStrings:CHN39_MMS249_TESTConnectionString %>" SelectCommand="SELECT [TRAIN_ID] FROM [TBL_TRAIN_TEAM3] WHERE (([TRAIN_FROM] = @TRAIN_FROM) AND ([TRAIN_TO] = @TRAIN_TO))">
            <SelectParameters>
                <asp:ControlParameter ControlID="dropsource" Name="TRAIN_FROM" PropertyName="SelectedValue" Type="String" />
                <asp:ControlParameter ControlID="dropdestination" Name="TRAIN_TO" PropertyName="SelectedValue" Type="String" />
            </SelectParameters>
        </asp:SqlDataSource>
        <br />
        <asp:CompareValidator ID="CompareValidator4" runat="server" ErrorMessage="Enter Train Number" Type="String" ControlToValidate="droptrain" ValueToCompare="Select" SetFocusOnError="true" Operator="LessThan"></asp:CompareValidator>
        <br />
        <asp:Label ID="Train_Name" runat="server"></asp:Label>
        <br />
        <br />
        <br />
        <asp:Label ID="Label5" runat="server" Text="Enter Number of Passengers"></asp:Label><br />
        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        <br />
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBox2" ErrorMessage="Enter Number of Passengers" SetFocusOnError="true"></asp:RequiredFieldValidator>
        <br />
        <asp:RangeValidator ID="RangeValidator1" runat="server" ErrorMessage="Maximum Value for Number of Passengers is 5" ControlToValidate="TextBox2" Type="Integer" MinimumValue="1" MaximumValue="5"></asp:RangeValidator>
        <br />
        <br />
        <br />
        <asp:Label ID="Label6" runat="server" Text="Enter Date"></asp:Label><br />         
        <asp:TextBox ID="TextBox3" runat="server" TextMode="Date" CssClass="dropsource"></asp:TextBox>
        <br />
        <asp:CompareValidator ID="CompareValidator1" runat="server" ErrorMessage="Invalid Date" ControlToValidate="TextBox3" Operator="GreaterThan" Type="Date"></asp:CompareValidator>
        <br />
        <br />
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" Text="Submit" OnClick="Button1_Click" CssClass="button" />&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button2" runat="server" Text="Cancel" OnClick="Button2_Click" CssClass="button" />&nbsp;&nbsp;&nbsp;
       
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Label ID="Label7" runat="server"></asp:Label>
       
    </form>
    <asp:ImageMap ID="ImageMap1" runat="server" ImageUrl="~/Images/final map.gif" Height="586px" Width="500px" HotSpotMode="Navigate">

                <asp:CircleHotSpot AlternateText="Srinagar" Radius="40"
            NavigateUrl="Location.aspx#Srinagar" X="130" Y="98" HotSpotMode="Navigate" />
                <asp:CircleHotSpot AlternateText="Delhi" Radius="30"
            NavigateUrl="Location.aspx#Delhi" X="167" Y="198" HotSpotMode="Navigate" />
                <asp:CircleHotSpot AlternateText="Gangtok" Radius="40"
            NavigateUrl="Location.aspx#Gangtok" X="347" Y="218" HotSpotMode="Navigate" />
                <asp:CircleHotSpot AlternateText="Ahmedabad" Radius="40"
            NavigateUrl="Location.aspx#Ahmedabad" X="104" Y="300" HotSpotMode="Navigate" />
                <asp:CircleHotSpot AlternateText="Kolkata" Radius="30"
            NavigateUrl="Location.aspx#Kolkata" X="345" Y="309" HotSpotMode="Navigate" />
                <asp:CircleHotSpot AlternateText="Nagpur" Radius="40"
            NavigateUrl="Location.aspx#Nagpur" X="210" Y="337" HotSpotMode="Navigate" />
                <asp:CircleHotSpot AlternateText="Mumbai" Radius="40"
            NavigateUrl="Location.aspx#Mumbai" X="98" Y="368" HotSpotMode="Navigate" />
                <asp:CircleHotSpot AlternateText="Hyderabad" Radius="30"
            NavigateUrl="Location.aspx#Hyderabad" X="189" Y="388" HotSpotMode="Navigate" />
                <asp:CircleHotSpot AlternateText="Bengaluru" Radius="20"
            NavigateUrl="Location.aspx#Bengaluru" X="169" Y="467" HotSpotMode="Navigate" />
                <asp:CircleHotSpot AlternateText="Chennai" Radius="20"
            NavigateUrl="Location.aspx#Chennai" X="215" Y="473" HotSpotMode="Navigate" />

        </asp:ImageMap>

</asp:Content>

<asp:Content ID="Content5" runat="server" contentplaceholderid="Footer">

</asp:Content>


