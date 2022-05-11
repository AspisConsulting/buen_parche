using BuenParche.Domain.Common;

namespace BuenParche.Application.Common.Interfaces;

public interface IDomainEventService
{
    Task Publish(DomainEvent domainEvent);
}
