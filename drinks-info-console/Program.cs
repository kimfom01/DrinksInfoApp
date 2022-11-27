// See https://aka.ms/new-console-template for more information
using drinks_info_console.APIConsumerServices;

Console.WriteLine("Hello, World!");

var categoryList = await DrinksProcessor.GetCategoriesListAsync();

foreach (var category in categoryList)
{
    Console.WriteLine(category.CategoryName);
}


// list of categories
// www.thecocktaildb.com/api/json/v1/1/list.php?c=list

// filter by category to get drinks
// https://www.thecocktaildb.com/api/json/v1/1/filter.php?c=Ordinary_Drink

// fetch drink details by id
// https://www.thecocktaildb.com/api/json/v1/1/lookup.php?i=11007