using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YadVashemOrdersContext.Models;
using YadVashemSystemContext.ModelsDto;

namespace YadVashemOrdersServices.Interfaces
{
    public interface IService
    {
       Task< List<OrderObjectDto>> GetAllOrders();
        Task UpdateHourList(List<OrderObjectDto> updateList);
        //  Task< List<OrderObjectDto>> GetListOfHours(int amountOfPeople, string partOfTheDay);
    }
}
