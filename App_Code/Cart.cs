using System;
using System.Collections.Generic;
using System.Web;

/// <summary>
/// Descrizione di riepilogo per Cart
/// </summary>
public class Product
{
    public int ID { get; set; }
    public int IdProduct { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public int Quantity { get; set; }
    public string Ingriedients { get; set; }
    public double Price { get; set; }
    public string Notes { get; set; }
    public bool IsFrozen { get; set; }
    public string ImgUri { get; set; }

    public Product()
    {
    }

    public Product(int id, int idproduct, string name, string description, int quantity, string ingriedients, double price, string notes, bool isfrozen, string imguri)
    {
        ID = id;
        IdProduct = idproduct;
        Name = name;
        Description = description;
        Quantity = quantity;
        Ingriedients = ingriedients;
        Price = price;
        Notes = notes;
        IsFrozen = isfrozen;
        ImgUri = imguri;
    }
}

public class Products : List<Product>
{
    public Products()
    {

    }

    public void AddItem(int id, int idproduct, string name, string description, int quantity, string ingriedients, double price, string notes, bool isfrozen, string imguri)
    {
        this.Add(new Product(id, idproduct, name, description, quantity, ingriedients, price, notes, isfrozen, imguri));
    }

    public void RemoveItem(int i)
    {
        this.RemoveAt(i);
    }

    public double TotalPrice()
    {
        double tmp = 0;

        foreach (Product i in this)
        {
            tmp += i.Price;
        }
        return tmp;
    }
}