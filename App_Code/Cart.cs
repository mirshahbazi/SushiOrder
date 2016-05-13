using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descrizione di riepilogo per Cart
/// </summary>
public class Item
{

    public int    IdItem    { get; set; }
    public int    IdProduct { get; set; }
    public double Price     { get;set;  }

    public Item()
	{
	}

    public Item(int idItem, int idproduct, double price)
    {
        IdItem    = idItem;
        IdProduct = idproduct;
        Price     = price;
    }
}

public class Items : List<Item>
{
    public Items()
    {

    }

    public void AddItem(int idItem, int idproduct, double price)
    {
        this.Add(new Item(idItem, idproduct, price));
    }

    public void RemoveItem(int idItem)
    {
        this.RemoveItem(idItem);
    }

    public double TotalPrice()
    {
        double tmp = 0;

        foreach(Item i in this)
        {
            tmp += i.Price;
        }
        return tmp;
    }
}