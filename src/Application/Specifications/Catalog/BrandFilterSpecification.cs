using CustomerManager.Application.Specifications.Base;
using CustomerManager.Domain.Entities.Catalog;

namespace CustomerManager.Application.Specifications.Catalog
{
    public class BrandFilterSpecification : CustomerMgtSpecification<Brand>
    {
        public BrandFilterSpecification(string searchString)
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
