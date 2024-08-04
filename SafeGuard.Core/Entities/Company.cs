using SafeGuard.Core.Base;
using SafeGuard.Core.Enums;

namespace SafeGuard.Core.Entities
{
    internal class Company : BaseEntity
    {
        public Company(
            string name,
            string email,
            string password,
            string document,
            string address,
            int supportPhoneNumber,
            string bannerImageUrl,
            string companyImageUrl,
            string documentImageUrl,
            EnumDocType documentType,
            EnumStatusCompany statusCompany)
        {
            Name = name;
            Email = email;
            Password = password;
            Document = document;
            Address = address;
            SupportPhoneNumber = supportPhoneNumber;
            BannerImageUrl = new Uri(bannerImageUrl);
            CompanyImageUrl = new Uri(companyImageUrl);
            DocumentImageUrl = new Uri(documentImageUrl);
            DocumentType = documentType;
            StatusCompany = statusCompany;
        }

        public string Name { get; private set; }
        public string Email { get; private set; }
        public string Password { get; private set; }
        public string Document { get; private set; }
        public string Address { get; private set; }

        public int SupportPhoneNumber { get; private set; }

        public Uri BannerImageUrl { get; private set; }
        public Uri CompanyImageUrl { get; private set; }
        public Uri DocumentImageUrl { get; private set; }

        public EnumDocType DocumentType { get; private set; }
        public EnumStatusCompany StatusCompany { get; private set; }

        public List<PhoneNumber> Numbers { get; private set; } = [];
    }
}
