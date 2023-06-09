﻿using Microsoft.EntityFrameworkCore;
using MyRecommendationsService.Application.Interface;
using MyRecommendationsService.Domain;

namespace MyRecommendationsService.Application.CQRS.Command.GetAudioDowload
{
    public class AudiosRepository : IAudiosRepository
    {
        private readonly IContext _context;
        CancellationToken cancellationToken = new CancellationToken();

        public AudiosRepository(IContext context)
        {
            _context = context;
        }

        public async Task<List<Audio>> GetAllAsync()
        {
            return await _context.Audios.ToListAsync();
        }

        public async Task AddAsync(Audio myaudio)
        {
            await _context.Audios.AddAsync(myaudio);
        }

        public void Remove(Audio myaudio)
        {
            _context.Audios.Remove(myaudio);
        }

        public async Task SaveChangesAsync()
        {
            await _context.SaveChangesAsync(cancellationToken);
        }
    }
}
