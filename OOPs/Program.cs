using Oops.InventoryManagement;
using System;
namespace OOPSPrograms
{
    class Program
    {
        static string InventoryFilePath = @"D:\OneDrive\Documents\BridgeLabz\ObjectOrientedPrograms\OOPs\InventoryManagement\Inventory.json";
        static void Main(string[] args)
        {
            InventoryDetailsManagement inventoryDetailsManagement = new InventoryDetailsManagement();
            inventoryDetailsManagement.ReadJSonFile(InventoryFilePath);
        }
    }
}