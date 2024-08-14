using Microsoft.AspNetCore.Mvc.Rendering;

namespace bulky.Models;

public class MovieGenreViewModel{

    public List<Movie>? MovieList {get; set;}
    public List<string>? GenreList {get; set;}
    public string? SearchString {get; set;}
    public string? SelectedGenre {get; set;}
}