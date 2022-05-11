using BuenParche.Application.Common.Interfaces;

namespace BuenParche.Infrastructure.Services;

public class DateTimeService : IDateTime
{
    public DateTime Now => DateTime.Now;
}
