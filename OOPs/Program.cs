using Oops.InventoryDataManagement;
using Oops.InventoryManagement;
using System;
namespace OOPSPrograms
{
    class Program
    {
        static string inventoryFilePath = @"D:\OneDrive\Documents\BridgeLabz\ObjectOrientedPrograms\OOPs\InventoryManagement\Inventory.json";
        static string JsonDataFilePath = @"D:\OneDrive\Documents\BridgeLabz\ObjectOrientedPrograms\OOPs\InventoryDataManagement\InventoryData.json";
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the OOPS Programs");
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("Inventory Data Management");
                Console.WriteLine("Select the option \n1.InventoryManagement \n2.InventoryDataManagement \n3.Exit");
                {
                    int choice = Convert.ToInt32(Console.ReadLine());
                    switch (choice)
                    {
                        case 1:
                            InventoryDetailsManagement inventoryDetailsManagement = new InventoryDetailsManagement();
                            inventoryDetailsManagement.ReadJSonFile(inventoryFilePath);
                            break;
                        case 2:
                            InventoryManagement inventoryManagement = new InventoryManagement();
                            inventoryManagement.ReadJSONFile(JsonDataFilePath);
                            break;
                        default:
                            flag = false;
                            break;
                    }
                }
            }
        }
    }
}