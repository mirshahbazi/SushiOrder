using System;
using System.Collections.Generic;
using System.Web;

/// <summary>
/// Descrizione di riepilogo per Cart
/// </summary>
public class Product
{
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

    public Product(int idproduct, string name, string description, int quantity, string ingriedients, double price, string notes, bool isfrozen, string imguri)
    {
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

    public void AddItem(int idproduct, string name, string description, int quantity, string ingriedients, double price, string notes, bool isfrozen, string imguri)
    {
        this.Add(new Product(idproduct, name, description, quantity, ingriedients, price, notes, isfrozen, imguri));
    }

    public void RemoveItem(int idItem)
    {
        this.RemoveItem(idItem);
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