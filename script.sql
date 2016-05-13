CREATE DATABASE sushiorder; 

USE sushiorder; 

CREATE TABLE customers 
  ( 
     idcustomer INT auto_increment NOT NULL, 
     name       VARCHAR(30) NOT NULL, 
     surname    VARCHAR(30) NOT NULL, 
     birthday   DATETIME NOT NULL, 
     cell       VARCHAR(30) NOT NULL, 
     mail       VARCHAR(40) NOT NULL, 
     PRIMARY KEY(idcustomer) 
  ); 

CREATE TABLE products 
  ( 
     idproduct   INT auto_increment NOT NULL, 
	 name VARCHAR(50) NOT NULL,
     description VARCHAR(50) NOT NULL, 
     quantity    INT NOT NULL, 
     ingredients VARCHAR(200) NOT NULL, 
     price       DOUBLE NOT NULL, 
     notes       VARCHAR(60), 
     isfrozen    BOOL NOT NULL, 
	 imguri      VARCHAR(50),
     PRIMARY KEY(idproduct) 
  ); 

CREATE TABLE shoppingcart 
  ( 
     idcustomer    INT NOT NULL, 
     idproduct     INT NOT NULL, 
     orderdate     DATETIME NOT NULL, 
     pickupdate    DATETIME NOT NULL, 
     total         DOUBLE NOT NULL, 
     paymentmethod VARCHAR(40) NOT NULL, 
     notes         VARCHAR(60), 
     FOREIGN KEY(idcustomer) REFERENCES customers(idcustomer), 
     FOREIGN KEY(idproduct) REFERENCES products(idproduct) 
  ); 

INSERT INTO customers 
VALUES      (NULL, 
             "fabio", 
             "chiarani", 
             "1996-12-31", 
             "3665944518", 
             "fabio@chiarani.it"); 

INSERT INTO customers 
VALUES      (NULL, 
             "giovanni", 
             "rossi", 
             "1997-12-31", 
             "3665444518", 
             "giovanni@rossi.it"); 

INSERT INTO customers 
VALUES      (NULL, 
             "gian", 
             "carlo", 
             "2005-12-31", 
             "388444518", 
             "dd@aa.it"); 

INSERT INTO products 
VALUES     (NULL, 
            "sushi", 
            3, 
            "rice, salmon", 
            20, 
            "", 
            false); 

INSERT INTO products 
VALUES     (NULL, 
            "pizza", 
            5, 
            "pomodoro, mozarella", 
            50, 
            "", 
            true); 

INSERT INTO products 
VALUES     (NULL, 
            "cotoletta", 
            5, 
            "pollo", 
            2, 
            "note1", 
            false); 

INSERT INTO products 
VALUES     (NULL, 
            "pasta", 
            1, 
            "pastahh", 
            17, 
            "", 
            false); 

INSERT INTO shoppingcart 
VALUES     (1, 
            1, 
            "2016-02-02", 
            "2016-02-02", 
            99, 
            "creditcard", 
            ""); 

INSERT INTO shoppingcart 
VALUES     (1, 
            2, 
            "2016-02-02", 
            "2016-02-02", 
            99, 
            "creditcard", 
            ""); 

INSERT INTO shoppingcart 
VALUES     (2, 
            1, 
            "2016-02-02", 
            "2016-02-02", 
            99, 
            "money", 
            ""); 

INSERT INTO shoppingcart 
VALUES     (2, 
            4, 
            "2016-02-02", 
            "2016-02-02", 
            99, 
            "money", 
            ""); 
