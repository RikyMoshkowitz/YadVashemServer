
using Newtonsoft.Json;
using System;
using System.Net.Http.Json;
using System.Text.Json.Serialization;
using YadVashemOrdersContext.Interfaces;
using YadVashemOrdersContext.Models;

#nullable disable
namespace YadVashemOrdersContext
{
    public class YadVashemOrderContext : IContext
    {
        readonly string jsonContent;
        public virtual List<OrderObject> AllOrdersList { get; set; }
        public YadVashemOrderContext()
        {
            jsonContent = File.ReadAllText("D:\\jsonFile\\‏‏‫jsonFile.json");
            AllOrdersList = JsonConvert.DeserializeObject<List<OrderObject>>(jsonContent);
            Console.WriteLine("xdgjhk");
        }

        public async Task UpdateJsonFile(List<OrderObject> allOrdersList)
        {
            string jsonData = JsonConvert.SerializeObject(allOrdersList);
            string filePath = "D:\\jsonFile\\‏‏‫jsonFile.json";

            File.WriteAllText(filePath, jsonData);
        }


        //List<OrderObject> getAllOrders() 
        //{
        //    foreach (OrderObject myObject in allOrdersList)
        //    {
        //        string startTime = myObject.StartTime;
        //        int availablePlaces = myObject.AvailablePlaces;
        //        bool isClosed = myObject.IsClosed;
        //    }
        //    return allOrdersList; 
        //}

    }
}






