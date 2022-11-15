using AutoMapper;
using ShopMVC.Application.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopMVC.Application.ViewModels.Customer
{
    public class CustomerToListVm : IMapFrom<ShopMVC.Domain.Model.Customer>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        
        public void Mapping(Profile profile)
        {
            profile.CreateMap<ShopMVC.Domain.Model.Customer, CustomerToListVm>()
                .ForMember(d => d.Id, opt => opt.MapFrom(s => s.Id))
                .ForMember(d => d.Name, opt => opt.MapFrom(s => s.Name));
        }
    }
}
