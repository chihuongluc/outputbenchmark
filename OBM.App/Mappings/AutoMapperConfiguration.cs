using AutoMapper;
using OBM.App.ViewModels;
using OBM.Data.Models;

namespace OBM.App.Mappings
{
    public class AutoMapperConfiguration
    {
        public static void Configure()
        {
            Mapper.CreateMap<Role, RoleVM>();
            Mapper.CreateMap<Account, AccountVM>();
            Mapper.CreateMap<FinalTest, FinalTestVM>();
            Mapper.CreateMap<Register, RegisterVM>();
            Mapper.CreateMap<Room, RoomVM>();
            Mapper.CreateMap<Subject, SubjectVM>();
            Mapper.CreateMap<Student, StudentVM>();
            Mapper.CreateMap<Schedule, ScheduleVM>();
            Mapper.CreateMap<Score, ScoreVM>();
            Mapper.CreateMap<ITScore, ITScoreVM>();
            Mapper.CreateMap<ToeicScore, ToeicScoreVM>();
            Mapper.CreateMap<ChineseScore, ChineseScoreVM>();
        }
    }
}