using System.ComponentModel.DataAnnotations;
using ConsoleTableExt;

namespace drinks_info_console.UI;

public class TableBuilder
{
    public void DisplayTable<T>(List<T> listOfObjectsToBuildTable, [Required] string tableName) where T : class
    {
        Console.Clear();

        ConsoleTableBuilder
            .From(listOfObjectsToBuildTable)
            .WithTitle(tableName)
            .ExportAndWriteLine();

        Console.WriteLine();
    }
}
