﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="food.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>
<html lang="en">
<head>
  <meta http-equiv="Content-Type" content="text/html; charset=UTF-8"/>
  <meta name="viewport" content="width=device-width, initial-scale=1, maximum-scale=1.0, user-scalable=no"/>
  <title>SUSHIORDER</title>

  <!-- CSS  -->
  <link href="https://fonts.googleapis.com/icon?family=Material+Icons" rel="stylesheet">
  <link href="css/materialize.css" type="text/css" rel="stylesheet" media="screen,projection"/>
  <link href="css/style.css" type="text/css" rel="stylesheet" media="screen,projection"/>
    <script src="js/jquery-2.2.3.min.js">
    </script>

    <script>
        //auto dropdown
        //$(document).ready(function () {
        //    // Handler for .ready() called.
        //    $('html, body').animate({
        //        scrollTop: $('#cont').offset().top
        //    }, 'slow');
        //});
</script>

    <style>
        #frase {
                display: none;
            }

        @media (min-width: 992px) {
            #frase {
                display: inline;
            }
                    #app_title{
            font-size:19px;
        }
        }

         .navbar-fixed-bottom {
            background-color: #bbbbbb;
            color: #4A4A4A;
            text-align: center;
        }
		
				html {
    position: relative;
    min-height: 100%;
}
body {
    margin: 0 0 150px;
}
footer {
    background: silver;
    position: absolute;
    left: 0;
    bottom: 0;
    width: 100%;
}
.frame {

    white-space: nowrap;
    
    text-align: center; margin: 1em 0;
}
.helper {
    display: inline-block;
    height: 100%;
    vertical-align: middle;
}
    </style>
   
</head>
<body>
    <div class="navbar-fixed">
    <nav class="white" role="navigation">
        <div class="nav-wrapper container">
            <a id="logo-container" href="#" class="brand-logo">
                <img src="img/logo_big.png" style="height:55px" />
            </a>
            <ul class="right hide-on-med-and-down">
                <li id="how_to"><a href="howto.aspx">How To</a></li>
                <li id="home"><a href="index.aspx">Home</a></li>
                <li id="menu"><a href="#">Menu</a></li>
                <li id="carrello"><a href="cart.aspx" id="total_cart" runat="server">Carrello: €0</a></li>
            </ul>

            <ul id="nav-mobile" class="side-nav">
                <li id="how_to_mobile"><a href="howto.aspx">How To</a></li>
                <li id="home_mobile"><a href="index.aspx">Home</a></li>
                <li id="menu_mobile"><a href="#">Menu</a></li>
                <li id="carrello_mobil" class="light-green"><a href="cart.aspx" id="carrello_mobile" runat="server">Carrello: €0</a></li>
            </ul>
            <a href="#" data-activates="nav-mobile" class="button-collapse"><i class="material-icons">menu</i></a>
        </div>
    </nav>
        </div>



            <div class="row" style="background-color:#343434;margin-bottom:2px">
                <br />
                <h4 id="app_title" class="header center orange-text text-lighten-2" style="margin-top:0px">Sushi Order</h4>
                <div class="row center" id="frase">
                    <p class="header col s12 light" style="color:white;margin-top:0px">L'App per prenotare il tuo sushi preferito!</p>
                </div>
            </div>



    <div class="container" id="cont">
        <div class="section" style="padding-top:0px">
                        <div class="row" style="text-align: center">
                <div class="col s12 center"style="padding-top:3px">
                    <div class="col s4">
                        <img src="img/food.png" style="width:10px" />
                        <br />
                                            <a href="#"  class="light-green white-text">Menù</a>
                    </div>
                    <div class="col s4">
                        <img src="img/cart.png" style="width:22px"/>
                        <br />
                                            <a href="cart.aspx" class="green-text">Carrello</a>
                    </div>
                    <div class="col s4">
                        <img src="img/user.png" style="width:22px"/><br />
                                            <a href="order.aspx" class="green-text">Invia l'ordine</a>
                    </div>

                </div>
            </div>
            <br />
            <div class="row">
                <div class="col s12 center">
                    <h5 style="margin:0px">MENU</h5>
                    <br />
                    <form runat="server">
                                                
<div class="row">
                                                <asp:PlaceHolder ID="plholder" runat="server" />
</div>

                    </form>
                </div>      
            </div>
            <br />
        </div>
    </div>


    
    <footer style="background-color: #2F2F2F; text-align: center;">
              <div class="container">
            <div class="row">
                <div class="col s12">
                    <p class="grey-text text-lighten-4">The best app to order your favourite sushi</p>


                </div>
                <div class="col s12">
                 <a class="white-text" href="#!">Webmaster</a>
            </div>
        </div>
                  </div>

        <div  style="background-color:#1d1d1d">
                          <span style="color:white">Powered By</span>   <a class="brown-text text-lighten-3" href="http://www.chiarani.it"> FC</a>
        </div>
    </footer>




    <!--  Scripts-->
    <script src="https://code.jquery.com/jquery-2.1.1.min.js"></script>
    <script src="js/materialize.js"></script>
    <script src="js/init.js"></script>

</body>
</html>
