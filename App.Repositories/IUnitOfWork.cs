﻿namespace App.Repositories
{
    public interface IUnitOfWork
    {
        Task<int> SaveChangeAsync();
    }
}
