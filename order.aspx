﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="order.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>
<html lang="en">
<head>
    <meta http-equiv="Content-Type" content="text/html; charset=UTF-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1, maximum-scale=1.0, user-scalable=no" />
    <title>SUSHIORDER</title>

    <!-- CSS  -->
    <link href="https://fonts.googleapis.com/icon?family=Material+Icons" rel="stylesheet">
    <link href="css/materialize.css" type="text/css" rel="stylesheet" media="screen,projection" />
    <link href="css/style.css" type="text/css" rel="stylesheet" media="screen,projection" />
    <script src="js/jquery-2.2.3.min.js">
    </script>
    <script src="js/picker.js"></script>
    <script src="js/picker.date.js"></script>
    <script>
        //auto dropdown
        //$(document).ready(function () {
        //    // Handler for .ready() called.
        //    $('html, body').animate({
        //        scrollTop: $('#cont').offset().top
        //    }, 'slow');
        //});

        $('.datepicker').pickadate({
            selectMonths: true, // Creates a dropdown to control month
            selectYears: 15 // Creates a dropdown of 15 years to control year
        });
    </script>

    <style>
        #frase {
            display: none;
        }

        @media (min-width: 992px) {
            #frase {
                display: inline;
            }

            #app_title {
                font-size: 19px;
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
    </style>

</head>
<body>
    <nav class="white" role="navigation">
        <div class="nav-wrapper container">
            <a id="logo-container" href="#" class="brand-logo">
                <img src="img/logo_big.png" style="height: 55px" />
            </a>
            <ul class="right hide-on-med-and-down">
                <li id="how_to"><a href="#">How To</a></li>
                <li id="menu"><a href="index.aspx">Home</a></li>
                <li id="carrello"><a href="cart.aspx" id="total_cart" runat="server">€0</a></li>
            </ul>

            <ul id="nav-mobile" class="side-nav">
                <li id="how_to_mobile"><a href="#">How To</a></li>
                <li id="menu_mobile"><a href="index.aspx">Home</a></li>
                <li id="carrello_mobile"><a href="#" id="total_cart_mobile" runat="server">€0</a></li>
            </ul>
            <a href="#" data-activates="nav-mobile" class="button-collapse"><i class="material-icons">menu</i></a>
        </div>
    </nav>



    <div class="row" style="background-color: #343434; margin-bottom: 2px">
        <br />
        <h4 id="app_title" class="header center orange-text text-lighten-2" style="margin-top: 0px">Sushi Order</h4>
        <div class="row center" id="frase">
            <p class="header col s12 light" style="color: white; margin-top: 0px">L'App per prenotare il tuo sushi preferito!</p>
        </div>
    </div>



    <div class="container" id="cont">
        <div class="section" style="margin-top: 50px;text-align:center">
            <h5> MANDA L'ORDINE ORA! </h5><br />
            <div class="row">
                <div class="col s12 center card">
                    <div class="row">
                        <form class="col s12" runat="server">
                            <div class="row">
                                <div class="input-field col s6">
                                    <input runat="server" id="first_name" type="text" class="validate">
                                    <label for="first_name">NOME</label>
                                </div>
                                <div class="input-field col s6">
                                    <input runat="server" id="last_name" type="text" class="validate">
                                    <label for="last_name">COGNOME</label>
                                </div>
                            </div>
                            <div class="row">
                            <div class="input-field col s6">
                                <asp:TextBox ID="emailbox" runat="server" TextMode="Email" class="validate"></asp:TextBox> 
                                    <input id="email" type="email" >
                                    <label for="email">Email</label>
                                </div>
                                <div class="input-field col s6">

                                    <input runat="server" id="icon_telephone" type="tel" class="validate">
                                    <label for="email">Telefono</label>
                                </div>
                            </div>
                            <div class="row">
                                <div class="input-field col s6">

                                    <label>Data</label>
                                    <input runat="server" id="dtpicker" type="date" class="datepicker">
                                </div>

                                <div class="input-field col s6">
                                    <select runat="server" id="multiselection" class="browser-default">
                                        <option value="" disabled selected>Ora Ritiro</option>
                                        <option value="1">Option 1</option>
                                        <option value="2">Option 2</option>
                                        <option value="3">Option 3</option>
                                    </select>
                                </div>
                            </div>
                            <div class="row">
                                <div class="input-field col s12">

                                    <input runat="server" type="checkbox" id="test5" />
                                    <label for="test5">Confermo il mio carrello e la data di arrivo</label>
                                </div>
                            </div>
                            <div class="row">
                                <div class="input-field col s12">

                                    <button runat="server" id="btnSubmit" class="btn waves-effect waves-light" type="submit" name="action" onserverclick="btnSubmit_ServerClick">
                                        INVIA L'ORDINE!
    <i class="material-icons right">send</i>
                                    </button>
                                </div>
                            </div>


                        </form>
                    </div>


                </div>

            </div>
        </div>
        <br />
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

        <div style="background-color: #1d1d1d">
            Powered By <a class="brown-text text-lighten-3" href="http://www.chiarani.it">FC</a>
        </div>
    </footer>



    <script>
        $('.datepicker').pickadate({
            selectMonths: true, // Creates a dropdown to control month
            selectYears: 15 // Creates a dropdown of 15 years to control year
        });
    </script>
    <!--  Scripts-->
    <script src="https://code.jquery.com/jquery-2.1.1.min.js"></script>
    <script src="js/materialize.js"></script>
    <script src="js/init.js"></script>

</body>
</html>
