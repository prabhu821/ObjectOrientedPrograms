using Newtonsoft.Json;
using Oops.InventoryDataManagement;
using Oops.InventoryManagement;
using OOPs.InventoryDataManagement;
using OOPs.InventoryManagement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oops.InventoryDataManagement
{

    class InventoryManagement
    {
        List<Inventory> RiceList;
        List<Inventory> WheatList;
        List<Inventory> PulsesList;
        InventoryData inventories;
        public void ReadJSONFile(string file)
        {
            var json = File.ReadAllText(file);
            InventoryData inventories = JsonConvert.DeserializeObject<InventoryData>(json);
            
            RiceList = inventories.Rice;
            Display(RiceList);
           
            WheatList = inventories.Wheat;
            Display(WheatList);
            
            PulsesList = inventories.Pulses;
            Display(PulsesList);
        }
        public void Display(List<Inventory> inventories)
        {
            foreach (var data in inventories)
            {
                Console.WriteLine(data.Name + " \n " + data.Weight + " \n " + data.Price);
            }
        }

        public void AddInventoryDetails(string inventoryName)
        {
            Inventory inventory = new Inventory();
            string addinventory = Console.ReadLine();
            if (inventoryName.Equals("Rice"))
            {
                inventory.Name = "D";
                inventory.Weight = 50;
                inventory.Price = 10.0;
                RiceList.Add(inventory);
            }
        }
        public void WriteToJson(string filePath)
        {
            var json = JsonConvert.SerializeObject(inventories);
            File.WriteAllText(filePath, json);
        }
    }
}