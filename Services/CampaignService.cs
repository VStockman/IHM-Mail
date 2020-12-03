using Microsoft.EntityFrameworkCore;
using Models;
using Provider.EntityFramework;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Services
{
    public class CampaignService
    {
        private readonly Context context;

        public CampaignService(Context context)
        {
            this.context = context;
        }

        public async Task<Campaign> AddCampaign(Campaign newCampaign)
        {
            if (newCampaign == null)
                throw new ArgumentNullException();

            context.Campaign.Add(newCampaign);
            await context.SaveChangesAsync();

            return newCampaign;
        }

        public async Task<List<Campaign>> CampaignList()
        {
            var campaigns = await context.Campaign.AsQueryable().ToListAsync();
            return campaigns;
        }

    }
}
