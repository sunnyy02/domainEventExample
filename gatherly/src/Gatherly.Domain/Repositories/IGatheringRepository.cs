﻿using Gatherly.Domain.Entities;
using Gatherly.Domain.Primitives;

namespace Gatherly.Domain.Repositories;

public interface IRepository<T>
    where T : AggregateRoot
{
}

public interface IGatheringRepository : IRepository<Gathering>
{
    Task<Gathering?> GetByIdWithCreatorAsync(Guid id, CancellationToken cancellationToken = default);

    Task<Gathering?> GetByIdWithInvitationsAsync(Guid id, CancellationToken cancellationToken = default);

    void Add(Gathering gathering);

    void Remove(Gathering gathering);
}