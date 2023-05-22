using AutoMapper;
using StudentsDetails.Dto;
using StudentsDetails.Models;

namespace StudentsDetails.Helpers
{
    public class APIMapping:Profile
    {
        public APIMapping()
        {
            CreateMap<Student, StudentsDetailDto>();
            CreateMap<StudentsDetailDto, Student>();
        }
    }
}
