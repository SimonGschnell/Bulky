using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace bulky.Models;

public class Movie{
    [Key]
    public int Id {get; set;}
    public string? Title {get; set;}
    
    [Display(Name = "Release Date", Description ="test")]
    [DataType(DataType.Date)]
    public DateTime ReleaseDate {get; set;}
    public string? Genre {get; set;}
    [Column(TypeName = "decimal(18, 2)")]
    public decimal Price {get; set;}
    public string? Rating {get; set;}
}