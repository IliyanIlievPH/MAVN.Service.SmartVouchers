﻿using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using MAVN.Service.SmartVouchers.Domain.Models;

namespace MAVN.Service.SmartVouchers.Domain.Repositories
{
    public interface ICampaignsRepository
    {
        Task<Guid> CreateAsync(VoucherCampaign campaign);
        Task UpdateAsync(VoucherCampaign campaign);
        Task DeleteAsync(VoucherCampaign campaign);
        Task<VoucherCampaign> GetByIdAsync(Guid campaignId, bool includeContents);
        Task<IReadOnlyCollection<VoucherCampaign>> GetCampaignsByIdsAsync(Guid[] campaignIds);
        Task<CampaignsPage> GetCampaignsAsync(CampaignListRequest request);
        Task<(long publishedCampaingsVouchersCount, long activeCampaingsVouchersCount)>
            GetPublishedAndActiveCampaignsVouchersCountAsync();
        Task<Guid[]> GetExpiredCampaignsIdsAsync(DateTime now);
        Task SetFinishedCampaignsAsCompletedAsync(DateTime now);
    }
}
