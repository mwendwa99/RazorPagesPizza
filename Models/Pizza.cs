using System.ComponentModel.DataAnnotations;

namespace RazorPagesPizza.Pages;

public class Pizza{
    public int id {get;set;}
    [Required]
    public string? Name {get; set;}
    public PizzaSize Size {get; set;}
    public bool isGlutenFree {get; set;}

    [Range(0.01, 9999.99)]
    public decimal Price {get; set;}
}

public enum PizzaSize {small, medium, large}