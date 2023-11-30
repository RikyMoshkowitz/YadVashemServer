using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YadVashemOrdersContext.Models;
using YadVashemSystemContext.ModelsDto;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace YadVashemSystemServices
{
    class MappingProfile : Profile
    {
        public MappingProfile()
        {
            // Add as many of these lines as you need to map your objects
            CreateMap<OrderObjectDto, OrderObject>();
            CreateMap<OrderObject, OrderObjectDto>();
        }
    }
}
