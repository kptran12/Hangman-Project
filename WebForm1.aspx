<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Assignment4.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<html> 

   <meta charset="utf-8" />
    <meta http-equiv="X-UA-Compatible" />
   
	
<title> Kristen Tran</title>



<link href = "~/CSS/bootstrap.min.css" rel= "stylesheet"/>
<link href= "~/CSS/hangman.css" rel= "stylesheet"/>

</head>

<body> 
<nav class= "navbar-inverse navbar-fixed-top">
	<div class = "container">
	<div class= "navbar-header">
		<button type = "button" class = "navbar-toggle collapsed" data-toggle="collapse" data-target="#navbar" aria controls = "navbar">
			
			<span class = "sr-only"> Toggle Navigation </span>
			<span class = "icon-bar"></span>
			<span class = "icon-bar"> </span>
			<span class = "icon-bar"> </span>
			<span class = "icon-bar"> </span>
			</button>
			<a class = "navbar-brand" href="index.html"> Kristen Tran</a>
			</div>
			<div id = "navbar" class = "collapse navbar-collapse">
				<ul class = "nav navbar-nav">
					<li class ="active"><a href="#"> Home </a></li>
					</ul>
					</div>
					</div>
					</nav>
					
<body>
    <form id="form1" runat="server">
    <div>
     <div id="hangmanContainer" style="height: 435px; margin-left: 173px; margin-right: 170px; left: 55px; width: 1022px;">
        <asp:Label ID="answerLb" runat="server" Text="Label"></asp:Label>
    
        <asp:Image ID="hangmanImg" runat="server" ImageUrl ="~/Images/hangman.png" />
        <asp:Label ID="guessNum" runat="server" Text="Number of Guesses:"></asp:Label>
    
    
    </div>
        <p>
            <asp:TextBox ID="guessTb" runat="server"></asp:TextBox>
            <asp:Button ID="fullGuessBtn" runat="server" OnClick="fullGuessBtn_Click" Text="Submit Full Guess" />
        </p>
        <asp:TextBox ID="letterGuess" runat="server"></asp:TextBox>
        <asp:Button ID="letterGuessBtn" runat="server" OnClick="letterGuessBtn_Click" Text="Submit Letter Guess" />
        <p>
            <asp:Label ID="guessLb" runat="server" Text="You have guessed..."></asp:Label>
        </p>
        <p>
            <asp:Label ID="validLb" runat="server" Text="Will you guess right?"></asp:Label>
        </p>
    
         <asp:RadioButtonList ID="difficultyRB" runat="server" >
             <asp:ListItem Value ="easyBtn" Selected="True" Text="Easy"></asp:ListItem>
             <asp:ListItem Value ="medBtn" Text="Medium"></asp:ListItem>
             <asp:ListItem Value ="hardBtn" Text="Hard"></asp:ListItem>
         </asp:RadioButtonList>

    
        </div>
    </form>
</body>
</html>
