<%@ Page Title="Fizz Buzz" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true"
    CodeFile="Default.aspx.cs" Inherits="_Default" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
    <h2>
          FIZZ BUZZ!
    </h2>
     <p>
           It’s the summer of 1923. You and a few friends are on holiday in Goeteborg, Sweden. After one round ofstarköl in the Nobel Bar you start to
         feel funny. So you make fun of people around you – loudly. As you spot someone who has that distinct Einstein-haircut you tell him that "only
         two things are infinite, the universe and your stupidity, and I’m not sure about the former".
         As it turns out this man is indeed Einstein celebrating after his nobel price acceptance speech – and now he is mad at you. To settle this
         issue like civilized gentlemen he proposes a little drinking game called "fizz-buzz". In order to leave the table without a serious alcohol
         poisoning but some of your pride left you decide to do what every person would do: Cheat!

     </p>

     <asp:Label ID="Labeltxt" runat="server" Text="Insert an integer: "></asp:Label>
     <asp:TextBox ID="TextBox1" runat="server" ></asp:TextBox>
     <br/><br/>
     <asp:Button ID="Button1" runat="server" Text="Start FizzBuzz" onclick="Button1_Click" />
     <br/><br/>

     <div class="clear"style="color:green;">

       <asp:Label ID="LabelSucces" runat="server" Text=""></asp:Label>
            
     </div>

     <div class="Error" style="color:red;>

       <asp:Label ID="LabelError" runat="server" Text=""></asp:Label>

     </div>

</asp:Content>
