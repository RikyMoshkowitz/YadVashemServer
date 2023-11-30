using YadVashemOrdersContext.Models;
using YadVashemSystemContext.ModelsDto;

namespace YadVashenOrdersRepositories.Interfaces
{
    public interface IRepository
    {
        Task<List<OrderObject>> GetAllAsync();
        Task UpdateHourList(List<OrderObjectDto> updateList);
    }
}
