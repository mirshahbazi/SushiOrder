# SushiOrder
 > MVC asp.NET app to order your favorite sushi !
 > [DEV WebSite](https://www.chiarani.it "Fabio Chiarani")
 > [REF WebSite](https://www.ristorantefuhao.it "Ristorante Fu Hao") 

--------

### *CONTENTS*
- Technologies
- MVC Scheme
- Database Scheme
- References
- COPY / LICENSE

##### *MVC Scheme*
Not code first..

##### *Database Scheme*
######### CUSTOMERS
| NAME        | TYPE           | NULL  |
| ------------- |:-------------:| -----:|
| idcustomer      | int |  |
| name      | varchar(x)      |    |
| surname | varchar(x)      |     |
| cell | varchar(x)      |     |
| mail | varchar(x)      |     |
| 'PRIMARY KEY  (idcustomer)'           |


######### PRODUCTS
| NAME        | TYPE           | NULL  |
| ------------- |:-------------:| -----:|
| idproduct      | int |  |
| description      | varchar(x)      |    |
| quantity | int      |     |
| ingredients | varchar(x)      |     |
| price | double     |     |
| notes | varchar(x)      |   X  |
| isfrozen | bool      |     |
| 'PRIMARY KEY  (idproduct)'           |


##### *Technologies*
- MVC4 asp.NET (.NET Framework 4.5)
- MySql db
- Azure for test hosting
- VisualStudio for developing
- Aruba for final hosting


##### *COPYRIGHT*
SushiOrder di Fabio Chiarani è distribuito con Licenza Creative Commons Attribuzione - Non commerciale - Non opere derivate 4.0 Internazionale.
 > [SEE MORE CC](http://creativecommons.org/licenses/by-nc-nd/4.0/ "CopyRight") 


##### *LICENSE*
You can review the code, or make copies of it, but you can't use it or change it in any way. Allows a window (no pun intended) on formerly completely proprietary, secret code.
