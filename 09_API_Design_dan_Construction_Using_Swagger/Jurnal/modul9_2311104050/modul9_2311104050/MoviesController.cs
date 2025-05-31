using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/[controller]")]
public class MoviesController : ControllerBase
{
    private static List<Movie> movies = new List<Movie>
    {
        new Movie
        {
            Title = "The Shawshank Redemption",
            Director = "Frank Darabont",
            Stars = new List<string>{ "Tim Robbins", "Morgan Freeman" },
            Description = "Two imprisoned men bond over a number of years..."
        },
        new Movie
        {
            Title = "The Godfather",
            Director = "Francis Ford Coppola",
            Stars = new List<string>{ "Marlon Brando", "Al Pacino" },
            Description = "The aging patriarch of an organized crime dynasty..."
        },
        new Movie
        {
            Title = "The Dark Knight",
            Director = "Christopher Nolan",
            Stars = new List<string>{ "Christian Bale", "Heath Ledger" },
            Description = "When the menace known as the Joker emerges..."
        }
    };

    [HttpGet]
    public ActionResult<IEnumerable<Movie>> Get() => movies;

    [HttpGet("{id}")]
    public ActionResult<Movie> Get(int id) => movies.ElementAtOrDefault(id);

    [HttpPost]
    public IActionResult Post([FromBody] Movie m)
    {
        movies.Add(m);
        return Ok();
    }

    [HttpDelete("{id}")]
    public IActionResult Delete(int id)
    {
        if (id >= 0 && id < movies.Count)
        {
            movies.RemoveAt(id);
            return Ok();
        }
        return NotFound();
    }
} 