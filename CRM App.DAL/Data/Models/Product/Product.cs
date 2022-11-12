﻿using System.ComponentModel.DataAnnotations;

namespace CRM_App.DAL;

public class Product
{
    public Guid ProductId { get; set; }
    [Required]
    public string ProductName { get; set; } = "";
    public string ProductDescription { get; set; } = "";
    [Required]
    public decimal ProductPrice { get; set; }

}
