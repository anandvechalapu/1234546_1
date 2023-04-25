using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1235.DataAccess;
using _1235.DTO;

namespace _1235
{
    public class AnnuityPayoutInstructionService
    {
        private readonly AnnuityPayoutInstructionRepository _annuityPayoutInstructionRepository;

        public AnnuityPayoutInstructionService()
        {
            _annuityPayoutInstructionRepository = new AnnuityPayoutInstructionRepository();
        }

        public void Create(AnnuityPayoutInstruction annuityPayoutInstruction)
        {
            // Validate the purchase
            if (annuityPayoutInstruction.PurchaseLocation == null)
            {
                throw new ArgumentException("The purchase location must be specified.");
            }

            _annuityPayoutInstructionRepository.Create(annuityPayoutInstruction);
        }

        public void Update(AnnuityPayoutInstruction annuityPayoutInstruction)
        {
            // Validate the purchase
            if (annuityPayoutInstruction.PurchaseLocation == null)
            {
                throw new ArgumentException("The purchase location must be specified.");
            }

            _annuityPayoutInstructionRepository.Update(annuityPayoutInstruction);
        }

        public void Delete(int id)
        {
            _annuityPayoutInstructionRepository.Delete(id);
        }

        public AnnuityPayoutInstruction GetById(int id)
        {
            return _annuityPayoutInstructionRepository.GetById(id);
        }

        public IEnumerable<AnnuityPayoutInstruction> GetAll()
        {
            return _annuityPayoutInstructionRepository.GetAll();
        }
    }
}