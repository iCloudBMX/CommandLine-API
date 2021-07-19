using AutoMapper;
using CommandLine.Dtos;
using CommandLine.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CommandLine.Profiles
{
    public class CommandsProfile : Profile
    {
        public CommandsProfile()
        {
            CreateMap<CommandCreatedDto, Command>();

            CreateMap<Command, CommandReadDto>();

            CreateMap<CommandUpdateDto, Command>();
        }

    }
}
