using WebApplication1.Models;

namespace WebApplication1.Services;

public class ProductService
{
    private string[] _typeOfEntertainment = new []{ "Книга", "Фильм", "Игра" };
    private string[] _nameOfTheGames = new[] { "Warcraft III", "Neighbours back From Hell", "Dota 2", "Zuma", "Heroes of Might and Magic III" };
    private string[] _nameOfBooks = new[] { "На Западном фронте без перемен", "Посторонний", "Мартин Иден", "Маленький принц", "Бродяга" };
    private string[] _nameOfFilms = new[]
    {
        "Форрест Гамп", "Криминальное чтиво", "Побег из Шоушенка", "Список Шиндлера", "Американский психопат",
        "Американская история X", "Назад в будущее", "Бойцовский клуб", "Крестный отец", "Старикам тут нее место"
    };
    
    private Random _random = new Random();
    
    public List<Product> GetAllProducts()
    {
        var products = new List<Product>();
        var id = 1;

        foreach (var name in _nameOfTheGames)
        {
            products.Add(new Product
            {
                Id = id++,
                Category = "Игра",
                Description = name,
                Price = _random.Next(1, 31) * 100,
                Quantity = _random.Next(100),
                Actions = "✎⌫"
            });
        }

        foreach (var name in _nameOfBooks)
        {
            products.Add(new Product
            {
                Id = id++,
                Category = "Книга",
                Description = name,
                Price = _random.Next(1, 31) * 100,
                Quantity = _random.Next(100),
                Actions = "✎⌫"
            });
        }
        
        foreach (var name in _nameOfFilms)
        {
            products.Add(new Product
            {
                Id = id++,
                Category = "Фильм",
                Description = name,
                Price = _random.Next(1, 31) * 100,
                Quantity = _random.Next(100),
                Actions = "✎⌫"
            });
        }

        return products.OrderBy(x => Guid.NewGuid()).ToList();

    }
}