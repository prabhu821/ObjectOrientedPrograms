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

        //EDIT DATA 
        public void EditInventoryData()
        {
            Console.WriteLine("Select the Option  to edit\nInventories are Rice,Wheat and Pulses");
            string editinventory = Console.ReadLine();
            if (editinventory.Equals("Rice"))
            {
                Console.WriteLine("Enter Which Rice type you want to edit");
                string rice = Console.ReadLine();
                foreach (var data in RiceList)
                {
                    if (data.Name.Equals(rice))
                    {
                        Console.WriteLine("select what you want to edit\n1.Name 2.Weight 3.Price");
                        int choice = Convert.ToInt32(Console.ReadLine());
                        switch (choice)
                        {
                            case 1:
                                Console.WriteLine("Enter the new Name");
                                data.Name = Console.ReadLine();
                                break;
                            case 2:
                                Console.WriteLine("Enter the new Weight");
                                data.Weight = Convert.ToInt32(Console.ReadLine());
                                break;
                            case 3:
                                Console.WriteLine("Enter the new Price per kg");
                                data.Price = Convert.ToInt64(Console.ReadLine());
                                break;
                        }
                    }
                }
            }
            else if (editinventory.Equals("Wheat"))
            {
                Console.WriteLine("Enter Which Wheat type you want to edit");
                string wheat = Console.ReadLine();
                foreach (var data in WheatList)
                {
                    if (data.Name.Equals(wheat))
                    {
                        Console.WriteLine("select what you want to edit\n1.Name 2.Weight 3.Price");
                        int choice = Convert.ToInt32(Console.ReadLine());
                        switch (choice)
                        {
                            case 1:
                                Console.WriteLine("Enter the new Name");
                                data.Name = Console.ReadLine();
                                break;
                            case 2:
                                Console.WriteLine("Enter the new Weight");
                                data.Weight = Convert.ToInt32(Console.ReadLine());
                                break;
                            case 3:
                                Console.WriteLine("Enter the new Price per kg");
                                data.Price = Convert.ToInt64(Console.ReadLine());
                                break;
                        }
                    }
                }
            }
            else if (editinventory.Equals("Pulses"))
            {
                Console.WriteLine("Enter which Pulses type you want to edit");
                string pulses = Console.ReadLine();
                foreach (var data in PulsesList)
                {
                    if (data.Name.Equals(pulses))
                    {
                        Console.WriteLine("select what you want to edit\n1.Name 2.Weight 3.Price");
                        int choice = Convert.ToInt32(Console.ReadLine());
                        switch (choice)
                        {
                            case 1:
                                Console.WriteLine("Enter the new Name");
                                data.Name = Console.ReadLine();
                                break;
                            case 2:
                                Console.WriteLine("Enter the new Weight");
                                data.Weight = Convert.ToInt32(Console.ReadLine());
                                break;
                            case 3:
                                Console.WriteLine("Enter the new Price ");
                                data.Price = Convert.ToInt64(Console.ReadLine());
                                break;
                        }
                    }
                }
            }
            else
                Console.WriteLine("Invalid Data");
        }


        //DELETE DATA
        public void DeleteInventoryData()
        {
            Console.WriteLine("Enter  data you want to delete");
            string deleteinventory = Console.ReadLine();
            if (deleteinventory.Equals("Rice"))
            {
                Console.WriteLine("Enter which data you want to delete");
                string deleterice = Console.ReadLine();
                Inventory deletedata = new Inventory();
                foreach (var delete in RiceList)
                {
                    if (delete.Name.Equals(deleterice))
                    {
                        deletedata = delete;
                    }
                }
                RiceList.Remove(deletedata);
            }
            else if (deleteinventory.Equals("Wheat"))
            {
                Console.WriteLine("Enter which data you want to delete");
                string deletewheat = Console.ReadLine();
                Inventory deletedata = new Inventory();
                foreach (var delete in WheatList)
                {
                    if (delete.Name.Equals(deletewheat))
                    {
                        deletedata = delete;
                    }
                }
                WheatList.Remove(deletedata);
            }
            else if (deleteinventory.Equals("Pulses"))
            {
                Console.WriteLine("Enter which data you want to delete");
                string deletepulses = Console.ReadLine();
                Inventory deletedata = new Inventory();
                foreach (var delete in PulsesList)
                {
                    if (delete.Name.Equals(deletepulses))
                    {
                        deletedata = delete;
                    }
                }
                PulsesList.Remove(deletedata);
            }
        }


    }
}