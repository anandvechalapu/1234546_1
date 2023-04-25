using System;
using _1235.DTO;
using _1235.DataAccess;

namespace _1235
{
    public class ReopenClaimBasedOnLitigationService
    {
        private readonly ReopenClaimBasedOnLitigationRepository _repository;

        public ReopenClaimBasedOnLitigationService()
        {
            _repository = new ReopenClaimBasedOnLitigationRepository();
        }

        public void Create(ReopenClaimBasedOnLitigation claim)
        {
            _repository.Create(claim);
        }

        public ReopenClaimBasedOnLitigation Get(Guid id)
        {
            return _repository.Get(id);
        }

        public void Update(ReopenClaimBasedOnLitigation claim)
        {
            _repository.Update(claim);
        }

        public void Delete(Guid id)
        {
            _repository.Delete(id);
        }
    }
}