﻿using System.Runtime.CompilerServices;
using FitnessCenter.Data;
using FitnessCenter.Service.Interface;
using Microsoft.EntityFrameworkCore;
namespace ClassLibrary.Providers;

public class ClassRegistrationProvider : IBaseProvider<ClassRegistration>
{
    private readonly ApplicationContext _applicationContext;

    public ClassRegistrationProvider (ApplicationContext applicationContext)
    {
        _applicationContext = applicationContext;
    }

    public async Task<Guid> AddAsync(ClassRegistration entity, CancellationToken cancellationToken)
    {
        _applicationContext.Add(entity);
        await _applicationContext.SaveChangesAsync(cancellationToken).ConfigureAwait(false);
        return entity.Id;
    }

    public async Task DeleteAsync(ClassRegistration entity, CancellationToken cancellationToken)
    {
        _applicationContext.Remove(entity);
        await _applicationContext.SaveChangesAsync(cancellationToken);
    }

    public async Task<ClassRegistration> UpdateAsync(ClassRegistration entity, CancellationToken cancellationToken)
    {
        _applicationContext.Update(entity);
        await _applicationContext.SaveChangesAsync(cancellationToken);
        return entity;
    }

    public async Task<ClassRegistration> FindAsync(Guid id, CancellationToken cancellationToken)
    {
        return  await _applicationContext.ClassRegistrations.FirstOrDefaultAsync(p => p.Id == id);
    }
    
    public async Task<List<ClassRegistration>> GetAllAsync(CancellationToken cancellationToken)
    {
        return await _applicationContext.ClassRegistrations.ToListAsync(cancellationToken: cancellationToken);
    }
}