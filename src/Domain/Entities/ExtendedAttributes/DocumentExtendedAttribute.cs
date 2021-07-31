using CustomerManager.Domain.Contracts;
using CustomerManager.Domain.Entities.Misc;

namespace CustomerManager.Domain.Entities.ExtendedAttributes
{
    public class DocumentExtendedAttribute : AuditableEntityExtendedAttribute<int, int, Document>
    {
    }
}