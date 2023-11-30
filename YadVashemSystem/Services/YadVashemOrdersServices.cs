using AutoMapper;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YadVashemOrdersContext.Models;
using YadVashemOrdersServices.Interfaces;
using YadVashemSystemContext.ModelsDto;
using YadVashenOrdersRepositories.Interfaces;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace YadVashemOrdersServices.Services
{
    internal class YadVashemOrderService : IService
    {
        private readonly IRepository repository;
        private readonly IMapper mapper;
        public YadVashemOrderService(IRepository repository, IMapper mapper)
        {
            this.repository = repository;
            this.mapper = mapper;
        }
        public async Task<List<OrderObjectDto>> GetAllOrders()
        {
            var List= await this.repository.GetAllAsync();
            return this.mapper.Map<List<OrderObjectDto>>(List);

        }

        public async  Task UpdateHourList(List<OrderObjectDto> updateList)
        {
           await this.repository.UpdateHourList(updateList);
        }
    }
    }



