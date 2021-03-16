using AutoMapper;
using NoseDelivery.API.ViewModels;
using NoseDelivery.Business.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NoseDelivery.API.Configuration
{
    public class AutoMapperConfig : Profile
    {
        public AutoMapperConfig()
        {
            CreateMap<Pedido, PedidoViewModel>().ReverseMap();
            CreateMap<ProdutoParaPedido, ProdutoParaPedidoViewModel>().ReverseMap();
            CreateMap<Produto, ProdutoViewModel>().ReverseMap();

        }

    }
}
