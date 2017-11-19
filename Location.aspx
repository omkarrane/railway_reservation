<%@ Page Title="" Language="C#" MasterPageFile="~/Navigation.Master" AutoEventWireup="true" CodeBehind="Location.aspx.cs" Inherits="WebApplication1.Location" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
     <link rel="stylesheet" href="CSS.css" media="all"/>
      <script type="text/javascript" src="https://ajax.googleapis.com/ajax/libs/jquery/1.9.1/jquery.min.js"></script>
    <style type="text/css">
        #TextArea1 {
            width: 552px;
            margin-top: 0px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="Footer" runat="server">
    <form id="form1" runat="server">
        <div class="station1 content">
            <asp:Image ID="Image1" runat="server" Style="margin:10px 10px" Height="200px" ImageAlign="Left" ImageUrl="~/Images/Ahmedabad-1.jpg" Width="350px" />
        </div>
        <a name="Ahmedabad"><h3>Ahmedabad</h3></a>
        <div style="margin:10px 10px">
            Ahmedabad, in western India, is the largest city in the state of Gujarat. The Sabarmati River runs through its center. On the western bank is the Gandhi Ashram at Sabarmati, which displays the spiritual leader’s living quarters and artifacts. Across the river, the Calico Museum of Textiles, once a cloth merchant&#39;s mansion, has a significant collection of antique and modern fabrics.</div>
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <asp:Image ID="Image2" runat="server" Style="margin:10px 10px" Height="200px" ImageAlign="Right" ImageUrl="~/Images/Bengaluru2.jpg"  Width="350px" />
        <br />
        <a name="Bengaluru"><h3>&nbsp;&nbsp;Bengaluru</h3></a>
        <div style="margin:10px 10px">
            Bengaluru (also called Bangalore) is the capital of India's southern Karnataka state. The center of India's high-tech industry, the city is also known for its parks and nightlife. By Cubbon Park, Vidhana Soudha is a Neo-Dravidian legislative building. Former royal residences include 19th-century Bangalore Palace, modeled after England’s Windsor Castle, and Tipu Sultan’s Summer Palace, an 18th-century teak structure.</div>
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <asp:Image ID="Image3" runat="server" Style="margin:10px 10px" Height="200px" ImageAlign="Left" ImageUrl="~/Images/Chennai_Central_side.jpg" Width="350px" />
        <a name="Chennai"><h3>Chennai</h3></a>
        <div style="margin:10px 10px">
            Chennai, on the Bay of Bengal in eastern India, is the capital of the state of Tamil Nadu. The city is home to Fort St. George, built in 1644 and now a museum showcasing the city’s roots as a British military garrison and East India Company trading outpost, when it was called Madras. Religious sites include Kapaleeshwarar Temple, adorned with carved and painted gods, and St. Mary’s, a 17th-century Anglican church.</div>
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <asp:Image ID="Image4" runat="server" Style="margin:10px 10px" Height="200px" ImageAlign="Right" ImageUrl="~/Images/download.jpg" Width="350px" />
        <a name="Delhi"><h3>&nbsp;&nbsp; Delhi</h3></a>
        <div style="margin:10px 10px">
            Delhi, India’s capital territory, is a massive metropolitan area in the country’s north. In Old Delhi, a neighborhood dating to the 1600s, stands the imposing Mughal-era Red Fort, a symbol of India, and the sprawling Jama Masjid mosque, whose courtyard accommodates 25,000 people. Nearby is Chandni Chowk, a vibrant bazaar filled with food carts, sweets shops and spice stalls.</div>
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <asp:Image ID="Image5" runat="server" Style="margin:10px 10px" Height="200px" ImageAlign="Left" ImageUrl="~/Images/3 Darjeeling.jpg" Width="350px" />
        <a name="Gangtok"><h3>Gangtok</h3></a>
        <div style="margin:10px 10px">
            Gangtok is the capital of the mountainous northern Indian state of Sikkim. Established as a Buddhist pilgrimage site in the 1840s, the city became capital of an independent monarchy after British rule ended, but joined India in 1975. Today, it remains a Tibetan Buddhist center and a base for hikers organizing permits and transport for treks through Sikkim’s Himalayan mountain ranges.</div>
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <asp:Image ID="Image6" runat="server" Style="margin:10px 10px" Height="200px" ImageAlign="Right" ImageUrl="~/Images/hyderabad railway station.jpg" Width="350px" />
        <a name="Hyderabad"><h3>&nbsp;&nbsp; Hyderabad</h3></a>
        <div style="margin:10px 10px">
            Hyderabad is the capital of southern India&#39;s Telangana state. A major center for the technology industry, it&#39;s home to many upscale restaurants and shops. Its historic sites include Golconda Fort, a former diamond-trading center that was once the Qutb Shahi dynastic capital. The Charminar, a 16th-century mosque whose 4 arches support towering minarets, is an old city landmark near the long-standing Laad Bazaar.</div>
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <asp:Image ID="Image7" runat="server" Style="margin:10px 10px" Height="200px" ImageAlign="Left" ImageUrl="~/Images/Howrah_Bridge_Kolkata3.jpg" Width="350px" />
        <a name="Kolkata"><h3>Kolkata</h3></a>
        <div style="margin:10px 10px">
            Kolkata (formerly Calcutta) is the capital of India&#39;s West Bengal state. Founded as an East India Company trading post, it was India&#39;s capital under the British Raj from 1773–1911. Today it’s known for its grand colonial architecture, art galleries and cultural festivals. It’s also home to Mother House, headquarters of the Missionaries of Charity, founded by Mother Teresa, whose tomb is on site.</div>
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <asp:Image ID="Image8" runat="server" Style="margin:10px 10px" Height="200px" ImageAlign="Right" ImageUrl="~/Images/Mumbai1.jpg" Width="350px" />
        <a name="Mumbai"><h3>&nbsp;&nbsp; Mumbai</h3></a>
        <div style="margin:10px 10px">
            Mumbai (formerly called Bombay) is a densely populated city on India’s west coast. A financial center, it&#39;s India&#39;s largest city. On the Mumbai Harbour waterfront stands the iconic Gateway of India stone arch, built by the British Raj in 1924. Offshore, nearby Elephanta Island holds ancient cave temples dedicated to the Hindu god Shiva. The city&#39;s also famous as the heart of the Bollywood film industry.</div>
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <asp:Image ID="Image9" runat="server" Style="margin:10px 10px" Height="200px" ImageAlign="Left" ImageUrl="~/Images/Nagpur.jpg" Width="350px" />
        <a name="Nagpur"><h3>Nagpur</h3></a>
        <div style="margin:10px 10px">
            Nagpur is the winter capital and the third largest city of the Indian state of Maharashtra and largest city of central India. It is famous for the Nagpur orange and is known as the &quot;Orange City&quot; for being a major trade centre of oranges cultivated in the region.</div>
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <asp:Image ID="Image11" Style="margin:10px 10px" runat="server" Height="200px"  ImageAlign="Right" ImageUrl="~/Images/srinagar.jpg" Width="350px" />
        <a name="Srinagar"><h3>&nbsp;&nbsp; Srinagar</h3></a>
        <div style="margin:10px 10px">
            Srinagar is the largest city and the summer capital of the Indian state of Jammu and Kashmir. It lies on the banks of the Jhelum River, a tributary of the Indus, and Dal and Anchar lakes.</div>
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
    </form>
</asp:Content>

