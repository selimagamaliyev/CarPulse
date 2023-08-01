using AutoMapper;
using CarPulse.Application.DTO_s;
using CarPulse.Application.DTO_s.EntityGet;
using CarPulse.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarPulse.Application.AutoMap
{
    public class Mapping : Profile
    {
        public Mapping()
        {
            //CreateMap<Announcement, AnnouncementDTO>();
            CreateMap<Car, CarDTO>();
            CreateMap<Supply, SupplyDTO>();
            CreateMap<Engine, EngineDTO>();
            CreateMap<Photo, PhotoDTO>();
            CreateMap<Price, PriceDTO>();
            CreateMap<Mileage, MileageDTO>();
            CreateMap<Salesman, SalesmanDTO>();

            //CreateMap<AnnouncementDTO, Announcement>();
            CreateMap<CarDTO, Car>();
            CreateMap<SupplyDTO, Supply>();
            CreateMap<EngineDTO, Engine>();
            CreateMap<PhotoDTO, Photo>();
            CreateMap<PriceDTO, Price>();
            CreateMap<MileageDTO, Mileage>();
            CreateMap<SalesmanDTO, Salesman>();

            CreateMap<AnnouncementDTOput, Announcement>();
            CreateMap<CarDTOput, Car>();
            CreateMap<SupplyDTOput, Supply>();
            CreateMap<EngineDTOput, Engine>();
            CreateMap<PhotoDTOput, Photo>();
            CreateMap<PriceDTOput, Price>();
            CreateMap<MileageDTOput, Mileage>();
            CreateMap<SalesmanDTOput, Salesman>();

            CreateMap<Announcement, AnnouncementDTOput>();
            CreateMap<Car, CarDTOput>();
            CreateMap<Supply, SupplyDTOput>();
            CreateMap<Engine, EngineDTOput>();
            CreateMap<Photo, PhotoDTOput>();
            CreateMap<Price, PriceDTOput>();
            CreateMap<Mileage, MileageDTOput>();
            CreateMap<Salesman, SalesmanDTOput>();

            //         CreateMap<Car, CarDTO>()
            //.ForMember(dest => dest.Engine, opt => opt.MapFrom(src => src.Engine))
            //.ForMember(dest => dest.Mileage, opt => opt.MapFrom(src => src.Mileage))
            //.ForMember(dest => dest.Price, opt => opt.MapFrom(src => src.Price))
            //.ForMember(dest => dest.Photos, opt => opt.MapFrom(src => src.Photos.Select(p => p.PhotoAdress).ToList()))
            //.ForMember(dest => dest.Supplies, opt => opt.MapFrom(src => src.Supplies.Select(s => s.AddSupplies).ToList()));

            ////         CreateMap<Announcement, AnnouncementDTO>()
            ////            .ForMember(dest => dest.AnnouncementID, opt => opt.MapFrom(src => src.AnnouncementID))
            ////            .ForMember(dest => dest.CarID, opt => opt.MapFrom(src => src.CarID))
            ////            .ForMember(dest => dest.SalesmanID, opt => opt.MapFrom(src => src.SalesmanID))
            ////            .ForMember(dest => dest.Salesman, opt => opt.MapFrom(src => src.Salesman))
            ////            .ForMember(dest => dest.Car, opt => opt.MapFrom(src => src.Car))
            ////            .ForPath(dest => dest.Car.Engine, opt => opt.MapFrom(src => src.Car.Engine))
            ////.ForPath(dest => dest.Car.Mileage, opt => opt.MapFrom(src => src.Car.Mileage))
            ////.ForPath(dest => dest.Car.Price, opt => opt.MapFrom(src => src.Car.Price))
            ////.ForPath(dest => dest.Car.Photos, opt => opt.MapFrom(src => src.Car.Photos.Select(p => p.PhotoAdress).ToList()))
            ////.ForPath(dest => dest.Car.Supplies, opt => opt.MapFrom(src => src.Car.Supplies.Select(s => s.AddSupplies).ToList()));

            //         CreateMap<Announcement, AnnouncementDTO>()
            // .ForMember(dest => dest.AnnouncementID, opt => opt.MapFrom(src => src.AnnouncementID))
            // .ForMember(dest => dest.CarID, opt => opt.MapFrom(src => src.CarID))
            // .ForMember(dest => dest.SalesmanID, opt => opt.MapFrom(src => src.SalesmanID))
            // .ForMember(dest => dest.Salesman, opt => opt.MapFrom(src => src.Salesman))
            // .ForMember(dest => dest.Car, opt => opt.MapFrom(src => src.Car))
            // .ForPath(dest => dest.Car.Engine, opt => opt.MapFrom(src => src.Car.Engine))
            // .ForPath(dest => dest.Car.Mileage, opt => opt.MapFrom(src => src.Car.Mileage))
            // .ForPath(dest => dest.Car.Price, opt => opt.MapFrom(src => src.Car.Price))
            // .ForPath(dest => dest.Car.Photos, opt => opt.MapFrom(src => src.Car.Photos.Select(p => p.PhotoAdress).ToList()))
            // .ForPath(dest => dest.Car.Supplies, opt => opt.MapFrom(src => src.Car.Supplies.Select(s => s.AddSupplies).ToList()));
            //// Automapper konfigürasyonunu başlat
            //var config = new MapperConfiguration(cfg => {
            //    cfg.CreateMap<Car, CarDTO>();
            //    cfg.CreateMap<Engine, EngineDTO>();
            //    cfg.CreateMap<Mileage, MileageDTO>();
            //    cfg.CreateMap<Price, PriceDTO>();
            //});

            //// Automapper'ı yapılandır
            //IMapper mapper = config.CreateMapper();
            //CreateMap<Announcement, AnnouncementDTO>()
            //    .ForMember(dest => dest.AnnouncementID, opt => opt.MapFrom(src => src.AnnouncementID))
            //    .ForMember(dest => dest.Car, opt => opt.MapFrom(src => src.Car))
            //    .ForMember(dest => dest.Salesman, opt => opt.MapFrom(src => src.Salesman));
            ////.ForMember(dest => dest.CarID, opt => opt.MapFrom(src => src.CarID))
            ////.ForPath(dest => dest.Car.Engine, opt => opt.MapFrom(src => src.Car.Engine))
            ////.ForPath(dest => dest.Car.Mileage, opt => opt.MapFrom(src => src.Car.Mileage))
            ////.ForPath(dest => dest.Car.Price, opt => opt.MapFrom(src => src.Car.Price))
            ////.ForPath(dest => dest.Car.Photos, opt => opt.MapFrom(src => src.Car.Photos))
            ////.ForPath(dest => dest.Car.Supplies, opt => opt.MapFrom(src => src.Car.Supplies));

            // CreateMap<Announcement, AnnouncementDTO>()
            //.ForMember(dest => dest.AnnouncementID, opt => opt.MapFrom(src => src.AnnouncementID))
            //.ForMember(dest => dest.CarID, opt => opt.MapFrom(src => src.CarID))
            //.ForMember(dest => dest.Engine, opt => opt.MapFrom(src => src.Car.Engine))
            // .ForMember(dest => dest.Mileage, opt => opt.MapFrom(src => src.Car.Mileage))
            // .ForMember(dest => dest.Price, opt => opt.MapFrom(src => src.Car.Price))
            // .ForMember(dest => dest.Photos, opt => opt.MapFrom(src => src.Car.Photos.Select(p => p.PhotoAdress).ToList()))
            // .ForMember(dest => dest.Supplies, opt => opt.MapFrom(src => src.Car.Supplies.Select(s => s.AddSupplies).ToList()))
            //.ForMember(dest => dest.SalesmanID, opt => opt.MapFrom(src => src.SalesmanID))
            //.ForMember(dest => dest.Salesman, opt => opt.MapFrom(src => src.Salesman))
            //.ForMember(dest => dest.Car, opt => opt.MapFrom(src => src.Car));
            //CreateMap<Car, CarDTO>()
            //.ForMember(dest => dest.CarID, opt => opt.MapFrom(src => src.CarID))
            //.ForMember(dest => dest.Engine, opt => opt.MapFrom(src => src.Engine))
            // .ForMember(dest => dest.Mileage, opt => opt.MapFrom(src => src.Mileage))
            // .ForMember(dest => dest.Price, opt => opt.MapFrom(src => src.Price))
            // .ForMember(dest => dest.Photos, opt => opt.MapFrom(src => src.Photos.Select(p => p.PhotoAdress).ToList()))
            // .ForMember(dest => dest.Supplies, opt => opt.MapFrom(src => src.Supplies.Select(s => s.AddSupplies).ToList()));
            //.ForMember(dest => dest.Engine, opt => opt.MapFrom(src => src.Car.Engine))
            //.ForMember(dest => dest.Mileage, opt => opt.MapFrom(src => src.Car.Mileage))
            //.ForMember(dest => dest.Price, opt => opt.MapFrom(src => src.Car.Price))
            //.ForMember(dest => dest.Photos, opt => opt.MapFrom(src => src.Car.Photos))
            //.ForMember(dest => dest.Supplies, opt => opt.MapFrom(src => src.Car.Supplies));

            //CreateMap<Car, CarDTO>()
            //.ForMember(dest => dest.CarID, opt => opt.MapFrom(src => src.CarID))
            //// Diğer alan eşlemelerini burada tanımlayabilirsiniz...
            //.ForMember(dest => dest.Engine, opt => opt.MapFrom(src => src.Engine))
            //.ForMember(dest => dest.Mileage, opt => opt.MapFrom(src => src.Mileage))
            //.ForMember(dest => dest.Price, opt => opt.MapFrom(src => src.Price))
            //.ForMember(dest => dest.Photos, opt => opt.MapFrom(src => src.Photos.Select(p => p.PhotoAdress).ToList()))
            //.ForMember(dest => dest.Supplies, opt => opt.MapFrom(src => src.Supplies.Select(s => s.AddSupplies).ToList()));

            //// Engine sınıfı için eşlemeler
            //CreateMap<Engine, EngineDTO>();

            //// Mileage sınıfı için eşlemeler
            //CreateMap<Mileage, MileageDTO>();

            //// Price sınıfı için eşlemeler
            //CreateMap<Price, PriceDTO>();

            //// Photos sınıfı için eşlemeler
            //CreateMap<Photo, PhotoDTO>()
            //    .ForMember(dest => dest.PhotoAdress, opt => opt.MapFrom(src => src.PhotoAdress));

            //// Supplies sınıfı için eşlemeler
            //CreateMap<Supply, SupplyDTO>()
            //    .ForMember(dest => dest.AddSupplies, opt => opt.MapFrom(src => src.AddSupplies));

            // Announcement sınıfı için eşlemeler
            //CreateMap<Engine, EngineDTO>();
            //CreateMap<Mileage, MileageDTO>();
            //CreateMap<Price, PriceDTO>();

            CreateMap<Car, CarDTO>()
               .ForMember(dest => dest.Engine, opt => opt.MapFrom(src => src.Engine))
               .ForMember(dest => dest.Mileage, opt => opt.MapFrom(src => src.Mileage))
               .ForMember(dest => dest.Price, opt => opt.MapFrom(src => src.Price))
               .ForMember(dest => dest.Photos, opt => opt.MapFrom(src => src.Photos.Select(p => p.PhotoAdress).ToList()))
               .ForMember(dest => dest.Supplies, opt => opt.MapFrom(src => src.Supplies.Select(s => s.AddSupplies).ToList()));

            CreateMap<Announcement, AnnouncementDTO>()
            //    .ForMember(dest => dest.CarID, opt => opt.MapFrom(src => src.CarID))
            //    .ForMember(dest => dest.SalesmanID, opt => opt.MapFrom(src => src.SalesmanID))
                .ForMember(dest => dest.Salesman, opt => opt.MapFrom(src => src.Salesman))
                .ForMember(dest => dest.Car, opt => opt.MapFrom(src => src.Car));

        }
    }
}
