using AutoMapper;
using score_system.DTOs;
using score_system.DTOs.Event;
using score_system.DTOs.Reward;
using score_system.DTOs.Score;
using score_system.DTOs.Team;

namespace score_system.Helpers
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {

            // MAPPER COMPETITOR
            CreateMap<Competitor, CompetitorDTO>().ReverseMap();
            CreateMap<Competitor, CompetitorInfoDTO>().ReverseMap();

            CreateMap<PaginationGeneric<Competitor>, PaginationGeneric<CompetitorDTO>>().ReverseMap();
            CreateMap<PaginationGeneric<Competitor>, PaginationGeneric<CompetitorInfoDTO>>().ReverseMap();

            CreateMap<CompetitorCreateDTO, Competitor>();


            // MAPPER REWARD
            CreateMap<Reward, RewardDTO>().ReverseMap();
            CreateMap<Reward, RewardInfoDTO>().ReverseMap();

            CreateMap<PaginationGeneric<Reward>, PaginationGeneric<RewardDTO>>().ReverseMap();
            CreateMap<PaginationGeneric<Reward>, PaginationGeneric<RewardInfoDTO>>().ReverseMap();

            CreateMap<RewardCreateDTO, Reward>();


            // MAPPER TEAM
            CreateMap<Team, TeamDTO>().ReverseMap();
            CreateMap<Team, TeamInfoDTO>().ReverseMap();

            CreateMap<PaginationGeneric<Team>, PaginationGeneric<TeamDTO>>().ReverseMap();
            CreateMap<PaginationGeneric<Team>, PaginationGeneric<TeamInfoDTO>>().ReverseMap();

            CreateMap<TeamCreateDTO, Team>();


            // MAPPER SCORE
            CreateMap<Score, ScoreDTO>().ReverseMap();
            CreateMap<Score, ScoreInfoDTO>().ReverseMap();

            CreateMap<PaginationGeneric<Score>, PaginationGeneric<ScoreDTO>>().ReverseMap();
            CreateMap<PaginationGeneric<Score>, PaginationGeneric<ScoreInfoDTO>>().ReverseMap();

            CreateMap<ScoreCreateDTO, Score>();


            // MAPPER EVENTS
            CreateMap<Event, EventDTO>().ReverseMap();
            CreateMap<Event, EventInfoDTO>().ReverseMap();

            CreateMap<PaginationGeneric<Event>, PaginationGeneric<EventDTO>>().ReverseMap();
            CreateMap<PaginationGeneric<Event>, PaginationGeneric<EventInfoDTO>>().ReverseMap();

            CreateMap<EventCreateDTO, Event>();

        }
    }
}
