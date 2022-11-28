using drinks_info_console.APIConsumerServices;
using drinks_info_console.Input;
using drinks_info_console.Models;
using drinks_info_console.UI;

namespace drinks_info_console.Controller;

public static class DrinksInfoController
{
    private static UserInput UserInput = new UserInput();
    private static TableBuilder TableBuilder = new TableBuilder();
    private static Validation Validator = new Validation();

    public static async Task StartProgram()
    {
        string ans, categoryName, drinkId;
        List<DrinkDetail> drinkDetails;
        do
        {
            categoryName = await SelectCategoryAsync();
            drinkId = await SelectDrinkAsync(categoryName);

            drinkDetails = await DrinksProcessor.GetDrinksDetailsAsync(drinkId);
            TableBuilder.DisplayTable(drinkDetails, "");

            Console.Write("Do you want to check another drink? (y/n): ");
            ans = UserInput.GetInput();
            while (!Validator.IsValidAns(ans))
            {
                Console.WriteLine("Invalid Input!");
                Console.Write("Do you want to check another drink? (y/n): ");
                ans = UserInput.GetInput();
            }
        } while (ans == "y");
    }

    private static async Task<string> SelectCategoryAsync()
    {
        var categoryList = await DrinksProcessor.GetCategoriesListAsync();

        TableBuilder.DisplayTable(categoryList, "Category");

        Console.Write("Enter a category name to select: ");
        var categoryChoice = UserInput.GetInput();
        while (!Validator.IsValidString(categoryChoice))
        {
            Console.WriteLine("Invalid Input!");
            Console.Write("Enter a category name to select: ");
            categoryChoice = UserInput.GetInput();
        }

        return categoryChoice;
    }

    private static async Task<string> SelectDrinkAsync(string category)
    {
        var drinksList = await DrinksProcessor.GetDrinksListAsync(category);

        TableBuilder.DisplayTable(drinksList, category);

        Console.Write("Enter a category Id to display drinks: ");
        var id = UserInput.GetInput();
        while (!Validator.IsValidId(id))
        {
            Console.WriteLine("Invalid Input!");
            Console.Write("Enter a category Id to display drinks: ");
            id = UserInput.GetInput();
        }

        return id;
    }

    private static List<DrinkDetail> CleanUpDetailsList(List<DrinkDetail> drinkDetails)
    {
        // remove all the null values and return cleaned up list

        return drinkDetails;
    }
}
