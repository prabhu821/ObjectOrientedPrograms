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
                Console.WriteLine("Select the option \n1.InventoryManagement \n2.InventoryDataManagement \n3.Add Inventory Data" +
                    "\n4.Edit Inventory Data \n5.Exit");
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
                        case 3:
                            InventoryManagement inventoryManagement1 = new InventoryManagement();
                            inventoryManagement1.ReadJSONFile(JsonDataFilePath);
                            inventoryManagement1.AddInventoryDetails("Rice");
                            inventoryManagement1.WriteToJson(JsonDataFilePath);
                            break;
                        case 4:
                            InventoryManagement inventoryManagement2 = new InventoryManagement();
                            inventoryManagement2.EditInventoryData();
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