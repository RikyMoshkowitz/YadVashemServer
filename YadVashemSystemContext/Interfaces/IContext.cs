using YadVashemOrdersContext.Models;

namespace YadVashemOrdersContext.Interfaces
{
    public interface IContext
    {
        List<OrderObject> AllOrdersList { get; set; }
        Task UpdateJsonFile(List<OrderObject> allOrdersList);
    }
}
