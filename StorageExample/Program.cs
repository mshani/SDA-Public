using StorageExample;

Menu.PrintMenu();
Storage storage = new Storage();
var option = Console.ReadLine();
while (option.ToUpper().Trim() != "EXIT")
{
    Menu.ExecuteOption(option, storage);
    Menu.PrintMenu();
    option = Console.ReadLine();
}


