# SushiOrder
```
   MVC asp.NET app to order your favorite sushi ! 
```
[DEV WebSite](http://www.chiarani.it "Fabio Chiarani") ![logos](https://github.com/Xiryl/SushiOrder/blob/master/DH.png = 100x)
<br /> 
[REF WebSite](http://www.ristorantefuhao.it "Ristorante Fu Hao") 

<br />
<br />
## *README CONTENTS*

- Technologies
- MVC Scheme
- Database Scheme
- References
- Copy / License

<br />
<br />
## *MVC Scheme*

..todo..

<br />
<br />
## *Database Scheme*
<br />
###### CUSTOMERS TABLE
| NAME        | TYPE           | NULL  |
| ------------- |:-------------:| -----:|
| idcustomer      | int |  |
| name      | varchar(x)      |    |
| surname | varchar(x)      |     |
| cell | varchar(x)      |     |
| mail | varchar(x)      |     |
| `PRIMARY KEY`  (idcustomer)           |

<br />
###### PRODUCTS TABLE
| NAME        | TYPE           | NULL  |
| ------------- |:-------------:| -----:|
| idproduct      | int |  |
| description      | varchar(x)      |    |
| quantity | int      |     |
| ingredients | varchar(x)      |     |
| price | double     |     |
| notes | varchar(x)      |   X  |
| isfrozen | bool      |     |
| `PRIMARY KEY`  (idproduct)           |

<br />
###### SHOPPINGCART TABLE
| NAME        | TYPE           | NULL  |
| ------------- |:-------------:| -----:|
| idcustomer      | int |  |
| idproduct      |int      |    |
| orderdate | datetime      |     |
| pickupdate | datetime      |     |
| total | double     |     |
| paymentmethod | varchar(x)      |   x  |
| notes | bool      |    x |
| `PRIMARY KEY`  (idproduct)      |     |
| `FOREIGN KEY`(idcustomer) `REFERENCES` customers(idcustomer)||
|`FOREIGN KEY`(idproduct) `REFERENCES` products(idproduct)||

<br />
<br />
## *Technologies*
- MVC4 asp.NET (.NET Framework 4.5)
- MySql db
- Azure for test hosting
- VisualStudio for developing
- Aruba for final hosting
 
<br />
<br />
## *COPYRIGHT*
SushiOrder di Fabio Chiarani è distribuito con Licenza Creative Commons Attribuzione - Non commerciale - Non opere derivate 4.0 Internazionale.
 > [SEE MORE CC](http://creativecommons.org/licenses/by-nc-nd/4.0/ "CopyRight") 

<br />
<br />
## *LICENSE*
You can review the code, or make copies of it, but you can't use it or change it in any way. Allows a window (no pun intended) on formerly completely proprietary, secret code.
