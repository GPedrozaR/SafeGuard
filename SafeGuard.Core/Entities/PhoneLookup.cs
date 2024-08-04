using SafeGuard.Core.Base;

namespace SafeGuard.Core.Entities
{
    internal class PhoneLookup : BaseEntity
    {
        public PhoneLookup(
            int phone, 
            bool successLookup)
        {
            Phone = phone;
            SuccessLookup = successLookup;
        }

        public int Phone { get; private set; }
        public bool SuccessLookup { get; private set; }
    }
}
