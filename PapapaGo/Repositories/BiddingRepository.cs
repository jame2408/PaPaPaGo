﻿using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PapapaGo.Models.Bidding;

namespace PapapaGo.Repositories
{
    public class BiddingRepository : BaseRepository, IBiddingRepository
    {
        public BiddingRepository(string connectionString) : base(connectionString)
        {
        }

        public async Task<List<Bidding>> GetBiddingsAsync()
        {
            return (await GetListAsync<Bidding>("WHERE 1")).ToList();
        }

        public async Task<Bidding> GetBiddingsAsync(int id)
        {
            return (await GetListAsync<Bidding>("WHERE Id = @id", new {id})).FirstOrDefault();
        }

        public async Task<List<Bidding>> GetBiddingsAsync(bool isSoldout)
        {
            return (await GetListAsync<Bidding>("WHERE IsSoldout = @isSoldout AND Link IS NOT NULL AND Link <> ''", new {isSoldout})).ToList();
        }

        public async Task<List<Bidding>> GetBiddingsAsync(string name)
        {
            return (await GetListAsync<Bidding>("WHERE Name = @name", new {name})).ToList();
        }

        public async Task<int> CreateBiddingAsync(Bidding bidding)
        {
            return (await InsertAsync(bidding)).GetValueOrDefault();
        }

        public async Task<bool> UpdateBiddingAsync(Bidding bidding)
        {
            return await UpdateAsync(bidding) > 0;
        }
    }
}