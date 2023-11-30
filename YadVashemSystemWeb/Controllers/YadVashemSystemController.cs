using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using YadVashemOrdersContext.Models;
using YadVashemOrdersServices.Interfaces;
using YadVashemSystemContext.ModelsDto;

namespace YadVashemSystemWeb.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class YadVashemSystemController : ControllerBase
    {
        readonly IService service;
        public YadVashemSystemController(IService service)
        {
            this.service = service;
        }
        [HttpGet]
        public async Task<List<OrderObjectDto>> Get()
        {
            return await service.GetAllOrders();
        }
        [Route("/Update{updateList}")]
        [HttpPut ]
        public async Task updateHoursList(List<OrderObjectDto> updateHuorList)
        {
            await service.UpdateHourList(updateHuorList);
        }
    
    }
}
