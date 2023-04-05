﻿using API.Data.Dtos;
using API.Models;
using AutoMapper;

namespace API.Profiles;

public class TutorProfile : Profile
{
    public TutorProfile()
    {
        CreateMap<CreateTutorDto, Tutor>();
    }
}
