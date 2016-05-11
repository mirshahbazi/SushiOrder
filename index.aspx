<%@ Page Language="C#" AutoEventWireup="true" CodeFile="index.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>
<html lang="en">
<head>
  <meta http-equiv="Content-Type" content="text/html; charset=UTF-8"/>
  <meta name="viewport" content="width=device-width, initial-scale=1, maximum-scale=1.0, user-scalable=no"/>
  <title>Parallax Template - Materialize</title>

  <!-- CSS  -->
  <link href="https://fonts.googleapis.com/icon?family=Material+Icons" rel="stylesheet">
  <link href="css/materialize.css" type="text/css" rel="stylesheet" media="screen,projection"/>
  <link href="css/style.css" type="text/css" rel="stylesheet" media="screen,projection"/>
    <script src="js/jquery-2.2.3.min.js">
    </script>

    <script>
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
        }
    </style>


</head>
<body>
    <nav class="white" role="navigation">
        <div class="nav-wrapper container">
            <a id="logo-container" href="#" class="brand-logo">
                <img src="img/logo_big.png" style="height:55px" />
            </a>
            <ul class="right hide-on-med-and-down">
                <li id="how_to"><a href="#">How To</a></li>
                <li id="menu"><a href="#">Menu</a></li>
                <li id="carrello"><a href="#">€ 0</a></li>
            </ul>

            <ul id="nav-mobile" class="side-nav">
                <li id="how_to_mobile"><a href="#">How To</a></li>
                <li id="menu_mobile"><a href="#">Menu</a></li>
                <li id="carrello_mobile"><a href="#">€ 0</a></li>
            </ul>
            <a href="#" data-activates="nav-mobile" class="button-collapse"><i class="material-icons">menu</i></a>
        </div>
    </nav>



            <div class="row" style="background-color:#343434">
                <br />
                <h4 class="header center orange-text text-lighten-2" style="margin-top:0px">Sushi Order</h4>
                <div class="row center" id="frase">
                    <p class="header col s12 light" style="color:white;margin-top:0px">L'App per prenotare il tuo sushi preferito!</p>
                </div>
            </div>



    <div class="container" id="cont">
        <div class="section">

            <div class="row">
                <div class="col s12 center">
                    <h3><i class="mdi-content-send brown-text"></i></h3>
                    <h4>Crea il tuo Menù</h4>
                    <br /><br />
                    <a href="food.aspx" id="btn_pietanze" style="height:auto; padding:15px; background-color:#FF2000" class="btn-flat waves-effect text-lighten-1 lighten-1 col s5" onclick="btnfunc()">
                        <img src="img/sushi_transparent.png" style="width:48px" />
                        <p>MENU'</p>
                    </a>
                    <a id="btn_carrello" style="height:auto; padding:15px; background-color:#D2D2D2" class="btn-flat waves-effect text-lighten-1  lighten-1 col col s5 offset-s2" onclick="btnfunc()">
                        <img src="img/cart.png" />
                        <p>CARRELLO</p>
                    </a>
                    <a id="btn_bevande" style="height:auto;margin-top:20px; padding:15px; background-color:#FF7300" class="btn-flat waves-effect text-lighten-1  lighten-1 col s5">
                        <img src="img/drink.png" />
                        <p>DRINK</p>
                    </a>
                    <a id="btn_ordine" style="height:auto;margin-top:20px; padding:15px; background-color:#D2D2D2" class="btn-flat waves-effect text-lighten-1  lighten-1 col col s5 offset-s2" >
                        <img src="img/user.png" />
                        <p>IL TUO ORDINE</p>
                    </a>
                </div>
            </div>
            <br /><br /><br /><br /><br /><br /><br /><br /><br /><br /><br /><br />
        </div>
    </div>



    <footer class="page-footer" style="background-color:#2F2F2F">
        <div class="container">
            <div class="row">
                <div class="col l6 s12">
                    <p class="grey-text text-lighten-4">Description.</p>


                </div>
                <div class="col l3 s12">
                    <h5 class="white-text">Links</h5>
                    <ul>
                        <li><a class="white-text" href="#!">Link1</a></li>
                    </ul>
                </div>
            </div>
        </div>
        <div class="footer-copyright" style="background-color:#1d1d1d">
            <div class="container">
                Powered By <a class="brown-text text-lighten-3" href="http://materializecss.com"> FC</a>
            </div>
        </div>
    </footer>


    <!--  Scripts-->
    <script src="https://code.jquery.com/jquery-2.1.1.min.js"></script>
    <script src="js/materialize.js"></script>
    <script src="js/init.js"></script>

</body>
</html>
