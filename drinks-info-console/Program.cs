// See https://aka.ms/new-console-template for more information
using drinks_info_console.APIConsumerServices;
using drinks_info_console.UI;

Console.WriteLine("Hello, World!");

var categoryList = await DrinksProcessor.GetCategoriesListAsync();

var tableBuilder = new TableBuilder();

tableBuilder.DisplayTable(categoryList, "Categories");


// list of categories
// www.thecocktaildb.com/api/json/v1/1/list.php?c=list

// filter by category to get drinks
// https://www.thecocktaildb.com/api/json/v1/1/filter.php?c=Ordinary_Drink

// fetch drink details by id
// https://www.thecocktaildb.com/api/json/v1/1/lookup.php?i=11007