using CustomerManager.Application.Specifications.Base;
using CustomerManager.Domain.Entities.Misc;

namespace CustomerManager.Application.Specifications.Misc
{
    public class DocumentTypeFilterSpecification : CustomerMgtSpecification<DocumentType>
    {
        public DocumentTypeFilterSpecification(string searchString)
        {
            if (!string.IsNullOrEmpty(searchString))
            {
                Criteria = p => p.Name.Contains(searchString) || p.Description.Contains(searchString);
            }
            else
            {
                Criteria = p => true;
            }
        }
    }
}