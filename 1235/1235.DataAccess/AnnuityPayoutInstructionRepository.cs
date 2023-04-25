using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1235.DTO;

namespace _1235
{
    public class AnnuityPayoutInstructionRepository
    {
        public void Create(AnnuityPayoutInstruction annuityPayoutInstruction)
        {
            using (var context = new _1235Context())
            {
                context.AnnuityPayoutInstructions.Add(annuityPayoutInstruction);
                context.SaveChanges();
            }
        }

        public void Update(AnnuityPayoutInstruction annuityPayoutInstruction)
        {
            using (var context = new _1235Context())
            {
                context.Entry(annuityPayoutInstruction).State = System.Data.Entity.EntityState.Modified;
                context.SaveChanges();
            }
        }

        public void Delete(int id)
        {
            using (var context = new _1235Context())
            {
                var annuityPayoutInstruction = context.AnnuityPayoutInstructions.Find(id);
                context.AnnuityPayoutInstructions.Remove(annuityPayoutInstruction);
                context.SaveChanges();
            }
        }

        public AnnuityPayoutInstruction GetById(int id)
        {
            using (var context = new _1235Context())
            {
                return context.AnnuityPayoutInstructions.Find(id);
            }
        }

        public IEnumerable<AnnuityPayoutInstruction> GetAll()
        {
            using (var context = new _1235Context())
            {
                return context.AnnuityPayoutInstructions.ToList();
            }
        }
    }
}