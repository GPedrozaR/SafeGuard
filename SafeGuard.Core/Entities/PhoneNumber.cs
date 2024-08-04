using SafeGuard.Core.Base;

namespace SafeGuard.Core.Entities
{
    internal class PhoneNumber : BaseEntity
    {
        public PhoneNumber(
            int number, 
            int companyId)
        {
            Number = number;
            CompanyId = companyId;
        }

        public int Number { get; private set; }
        public int CompanyId { get; private set; }

        public Company Company { get; private set; }
    }
}
