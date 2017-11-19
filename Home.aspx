<%@ Page Title="" Language="C#" MasterPageFile="~/Navigation.Master" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="WebApplication1.WebForm4" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" href="CSS.css" media="all"/>
      <script type="text/javascript" src="https://ajax.googleapis.com/ajax/libs/jquery/1.9.1/jquery.min.js"></script>

    <style type="text/css">
        .newStyle2 {
          line-height: normal;
            vertical-align: baseline;
            text-align: justify;
            word-spacing: 0.4cm;
            border: thin groove #000000;
            padding: 10px 15px 10px 15px;
            image-resolution: 800dpi;
            margin-right: 10px;  
        }
        .img{
            width: 100%;
            height: 550px;
        }
    </style>

</asp:Content>
<asp:Content ID="Content2" runat="server" contentplaceholderid="Footer">
    <br /><span style="color:red; font-family: 'Palatino Linotype'; font-size: 20px; font-style: normal; font-variant-ligatures: normal; font-variant-caps: normal; font-weight: normal; letter-spacing: normal; orphans: 2; text-align: center; text-indent: 0px; text-transform: none; white-space: normal; widows: 2; word-spacing: 0px; -webkit-text-stroke-width: 0px;   float: none;">KOPS is an online booking service for train travel in India. It sells tickets, without booking fees, through its website.Simple,fast Rail Bookings.</span><br /><br />
    <form id="form1" runat="server" aria-orientation="vertical">



       
        
        <div class="slideshow-container">
  <div class="mySlides fade" style="align-content:center">
      <asp:Image ID="Image5" runat="server" ImageUrl="~/Images/3.jpg" CssClass="img" ImageAlign="Middle" />
  </div>

  <div class="mySlides fade" style="align-content:center">
      <asp:Image ID="Image6" runat="server" ImageUrl="~/Images/4.jpg" CssClass="img" ImageAlign="Middle" />
  </div>

  <div class="mySlides fade" style="align-content:center">
      <asp:Image ID="Image7" runat="server" ImageUrl="~/Images/5.jpg" CssClass="img" ImageAlign="Middle" />
  </div>
   
  <div class="mySlides fade" style="align-content:center">
      <asp:Image ID="Image8" runat="server" ImageUrl="~/Images/6.jpg" CssClass="img" ImageAlign="Middle" />
  </div>
</div>


<script>var slideIndex = 0;
    showSlides();

    function showSlides() {
        var i;
        var slides = document.getElementsByClassName("mySlides");
        for (i = 0; i < slides.length; i++) {
            slides[i].style.display = "none";
        }
        slideIndex++;
        if (slideIndex > slides.length) { slideIndex = 1 }
        slides[slideIndex - 1].style.display = "block";
        setTimeout(showSlides, 2000); // Change image every 2 seconds
    }</script>

&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <br />

____________________________________________________________________________________________________________________________
        <br />
        <br />
        <asp:Label ID="Label1" runat="server" Text="News" style="text-align:center" Font-Bold="True" Font-Names="Palatino Linotype" Font-Size="Larger" ForeColor="Black"></asp:Label>
        <br />
        <br />
        <div style="font-size:large">Here in this selection you will find latest articles on Indian Railways.
            Stay updated, travel safe.</div>
        <br />
        <br />
       <div class="homenews1 content" >
           <a href="News.aspx#n1"> Rail Ministry tweets about official menu rate.</a>Check out full price list of meal items

       </div>
       <div class="homenews2 content"><a href="News.aspx#n2">
           Indian Railways Is Set to Reduce Wastage and Save Crores Through Recycled Water.</a></div>
       <div class="homenews1 content"><a href="News.aspx#n3">
           Travel in luxury trains like Rajdhani express at mail fare rates from April 1</a></div>
       <div class="homenews2 content"><a href="News.aspx#n4">
           Railways launches Vikalp scheme to help wait-listed passengers.</a>Click here to know more</div>


____________________________________________________________________________________________________________________________<br />
        <h3 style="margin: 0px 0px 21px; padding: 0px; border: 0px; font-style: normal; font-variant-ligatures: normal; font-variant-caps: normal; font-variant-numeric: inherit; font-weight: bold; font-stretch: inherit; line-height: inherit; font-family: 'Palatino Linotype'; font-size: 35px; vertical-align: baseline; color:black; letter-spacing: -0.64px; orphans: 2; text-align: start; text-indent: 0px; text-transform: none; white-space: normal; widows: 2; word-spacing: 0px; -webkit-text-stroke-width: 0px;">Meet some of our geeks</h3>
           <div font-family: 'Palatino Linotype'> From engineers to round-the-clock customer support, our friendly team is dedicated to providing an excellent train booking experience</div>
        <br />
&nbsp;<div class="homeleft1">
    <asp:Image ID="Image1" runat="server" ImageUrl="~/Images/PicsArt_03-26-12.01.00.png" Height="100px" Width="100px" ForeColor="Red" />
    <br />
    Kushal:
From Mechanical Engineer to coder, Kushal has been involved with (KOPS) since its begining.</div>
 



<div class="homeleft1">
    <asp:Image ID="Image2" runat="server" ImageUrl="~/Images/omkar.png" Height="100px" Width="100px" />
    <br />
    Omkar:
Designing for over 8 years, Omkar combines thoughtful design with cutting edge technology to deliver digital experiences with impact.

</div>
        <div class="homeleft1">
            <asp:Image ID="Image3" runat="server" ImageUrl="~/Images/pugal.jpg" Height="100px" Width="100px" />
            <br />
            Pugal:
Forever the optimist, Pugal is now expert in all things, he takes the lead in building relationships.

        </div>
        <div class="homeleft1">
            <asp:Image ID="Image4" runat="server" ImageUrl="~/Images/Sanjanna.jpg" Height="100px" Width="100px" />
            <br />
            Sanjana:
Originally from Assam, Sanjana brings an efficient North-Eastern touch (and delicious homemade biscuits) to the team.

        </div>
        <br />





        <br />
        <br /><br /><br />





    </form>
</asp:Content>
