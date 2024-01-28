using AutoMapper;
using AutoMapperSample.Models;

//AutoMappingdan foydalanish:

var source = new HrmContractDto()
{
    Id = Guid.NewGuid(),
    ContractNumber = "c-001",
    DirectorPinfl = "289289829",
    Tin = "8292892"
};
var config = new MapperConfiguration(cfg =>
{
    cfg.CreateMap<HrmContractDto, UdocsContractDto>()
    .ForMember(s => s.CNumber, d => d.MapFrom(m => m.ContractNumber))
    .ForMember(s=>s.inn,d=>d.MapFrom(m=>m.Tin))
    .ForMember(s=>s.DirectorPINFL, d=>d.MapFrom(m=>m.DirectorPinfl)).ReverseMap();
});

var mapper = config.CreateMapper();
//sorce dagi int property (Tin) ni auto string qiladi (inn)
var result = mapper.Map<HrmContractDto, UdocsContractDto>(source);

Console.WriteLine(result);

