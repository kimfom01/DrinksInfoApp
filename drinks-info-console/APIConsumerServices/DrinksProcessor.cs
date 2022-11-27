using System.Text.Json;
using drinks_info_console.Models;

namespace drinks_info_console.APIConsumerServices;

public class DrinksProcessor
{
    public static async Task<List<Category>> GetCategoriesListAsync()
    {
        ApiClientHelper.InitializeClient();

        List<Category> categoryList = new List<Category>();

        using (var stream = await ApiClientHelper.Client!.GetStreamAsync("https://www.thecocktaildb.com/api/json/v1/1/list.php?c=list"))
        {
            var categories = await JsonSerializer.DeserializeAsync<Categories>(stream);

            categoryList = categories!.CategoryList!;
        }

        return categoryList;
    }
}