<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

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

    <script>
        function btnfunc() {
            document.getElementById("here").scrollIntoView();
        }
        
    </script>

</head>
<body>
    <nav class="white" role="navigation">
        <div class="nav-wrapper container">
            <a id="logo-container" href="#" class="brand-logo">
                <img src="img/logo_big.png" style="height:63px" />
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



        <div class="section">
            <div class="row" style="background-color:#343434">
                <br><br>
                <h1 class="header center orange-text text-lighten-2">Suhi Order</h1>
                <div class="row center">
                    <h5 class="header col s12 light" style="color:white">L'App per prenotare il tuo sushi preferito!</h5>
                </div>
            </div>
        </div>



    <div class="container">
        <div class="section">

            <div class="row">
                <div class="col s12 center">
                    <h3><i class="mdi-content-send brown-text"></i></h3>
                    <br /><br />
                    <h4>Inizia Ora!</h4>
                    <br /><br />
                    <a id="download-button" style="height:auto; padding:15px; background-color:#C5D336" class="btn-flat waves-effect text-lighten-1 lighten-1 col s5" onclick="btnfunc()">
                        <img src="img/sushi_transparent.png" style="width:48px" />
                        <p>PIETANZE</p>
                    </a>
                    <a id="download-button1" style="height:auto; padding:15px; background-color:#A6CB45" class="btn-flat waves-effect text-lighten-1  lighten-1 col col s5 offset-s2" onclick="btnfunc()">
                        <img src="img/cart.png" />
                        <p>CARRELLO</p>
                    </a>
                    <a id="download-button11" style="height:auto;margin-top:20px; padding:15px; background-color:#4AB2D6" class="btn-flat waves-effect text-lighten-1  lighten-1 col s5" onclick="btnfunc()">
                        <img src="img/drink.png" />
                        <p>BEVANDE</p>
                    </a>
                    <a id="download-button111" style="height:auto;margin-top:20px; padding:15px; background-color:#71B238" class="btn-flat waves-effect text-lighten-1  lighten-1 col col s5 offset-s2" onclick="btnfunc()">
                        <img src="img/user.png" />
                        <p>ORDINE</p>
                    </a>

                </div>

            </div>
            <br /><br /><br /><br /><br /><br /><br /><br /><br /><br /><br /><br />
        </div>
    </div>



    <footer class="page-footer teal">
        <div class="container">
            <div class="row">
                <div class="col l6 s12">
                    <h5 class="white-text">Company Bio</h5>
                    <p class="grey-text text-lighten-4">We are a team of college students working on this project like it's our full time job. Any amount would help support and continue development on this project and is greatly appreciated.</p>


                </div>
                <div class="col l3 s12">
                    <h5 class="white-text">Settings</h5>
                    <ul>
                        <li><a class="white-text" href="#!">Link 1</a></li>
                        <li><a class="white-text" href="#!">Link 2</a></li>
                        <li><a class="white-text" href="#!">Link 3</a></li>
                        <li><a class="white-text" href="#!">Link 4</a></li>
                    </ul>
                </div>
                <div class="col l3 s12">
                    <h5 class="white-text">Connect</h5>
                    <ul>
                        <li><a class="white-text" href="#!">Link 1</a></li>
                        <li><a class="white-text" href="#!">Link 2</a></li>
                        <li><a class="white-text" href="#!">Link 3</a></li>
                        <li><a class="white-text" href="#!">Link 4</a></li>
                    </ul>
                </div>
            </div>
        </div>
        <div class="footer-copyright">
            <div class="container">
                Made by <a class="brown-text text-lighten-3" href="http://materializecss.com">Materialize</a>
            </div>
        </div>
    </footer>


    <!--  Scripts-->
    <script src="https://code.jquery.com/jquery-2.1.1.min.js"></script>
    <script src="js/materialize.js"></script>
    <script src="js/init.js"></script>

</body>
</html>
