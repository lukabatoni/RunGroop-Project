﻿using RunGroopWebApp.Models;

namespace RunGroopWebApp.Interfaces
{
    public interface IDashboardRepository
    {
        Task<List<Race>> GetAllUserRaces();
        Task<List<Club>> GetAllUserClubs();
        Task<AppUser> GetUserById(string id);

        Task<AppUser> GetUserByIdNoTracking(string id);
        public bool Update(AppUser user);
        public bool Save();
    }
}
