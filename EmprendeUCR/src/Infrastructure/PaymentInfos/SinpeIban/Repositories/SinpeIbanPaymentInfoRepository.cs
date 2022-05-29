using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EmprendeUCR.Domain.Core.Repositories;
using EmprendeUCR.Domain.PaymentInfos.Entities;
using EmprendeUCR.Domain.PaymentInfos.Repositories;
using Microsoft.EntityFrameworkCore;

namespace EmprendeUCR.Infrastructure.PaymentInfos.SinpeIban.Repositories
{
    internal class SinpeIbanPaymentInfoRepository : ISinpeIbanPaymentInfoRepository
    {
        private readonly SinpeIbanPaymentInfoDbContext _dbContext;
        public IUnitOfWork UnitOfWork => _dbContext;
        public SinpeIbanPaymentInfoRepository(SinpeIbanPaymentInfoDbContext unitOfWork)
        {
            _dbContext = unitOfWork;
        }
        public async Task<IEnumerable<SinpeIbanPaymentInfo>> GetAllAsync()
        {
            return await _dbContext.SinpeIbanPaymentInfo
            .Select(p => new SinpeIbanPaymentInfo(p.Account_Number, p.Payment_Info_ID, p.Name_Payment_Method))
            .ToListAsync();
        }
        public async Task<SinpeIbanPaymentInfo?> GetByIdAsync(string accountNumber)
        {
            return await _dbContext.SinpeIbanPaymentInfo
            .FirstOrDefaultAsync(p => p.Account_Number == accountNumber);
        }
        /// <summary>
        /// Saves aggregate and commits changes
        /// </summary>
        public async Task SaveAsync(SinpeIbanPaymentInfo sinpeIbanPaymentInfo)
        {
            _dbContext.Update(sinpeIbanPaymentInfo);
            await _dbContext.SaveEntitiesAsync();
        }

        public async Task AddPaymentInfo(SinpeIbanPaymentInfo sinpeIbanPaymentInfo)
        {
            await _dbContext.AddAsync(sinpeIbanPaymentInfo);
            await _dbContext.SaveChangesAsync();
        }
        public async Task<SinpeIbanPaymentInfo?> GetByPaymentInfoID(int id)
        {
            return await _dbContext.SinpeIbanPaymentInfo
            .FirstOrDefaultAsync(p => p.Payment_Info_ID.Equals(id));
        }
    }
}