using AutoMapper;
using System.Collections.Generic;
using YadVashemOrdersContext.Interfaces;
using YadVashemOrdersContext.Models;
using YadVashemSystemContext.ModelsDto;
using YadVashenOrdersRepositories.Interfaces;

namespace YadVashenOrdersRepositories.repositories
{
    internal class OrdersRepository : IRepository
    {
        private readonly IMapper mapper;
        private readonly IContext context;
        public OrdersRepository(IContext context, IMapper mapper)
        {
            this.context = context;
            this.mapper = mapper;
        }

        public async Task<List<OrderObject>> GetAllAsync()
        {
            return this.context.AllOrdersList;

        }

        public async Task UpdateHourList(List<OrderObjectDto> updateList)
        {
             var mapList= this.mapper.Map<List<OrderObject>>(updateList);
            this.context.UpdateJsonFile(mapList);
        }
    }
}

