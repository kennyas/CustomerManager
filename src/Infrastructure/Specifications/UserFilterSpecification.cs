using CustomerManager.Infrastructure.Models.Identity;
using CustomerManager.Application.Specifications.Base;

namespace CustomerManager.Infrastructure.Specifications
{
    public class UserFilterSpecification : CustomerMgtSpecification<ApplicationUser>
    {
        public UserFilterSpecification(string searchString)
        {
            if (!string.IsNullOrEmpty(searchString))
            {
                Criteria = p => p.FirstName.Contains(searchString) || p.LastName.Contains(searchString) || p.Email.Contains(searchString) || p.PhoneNumber.Contains(searchString) || p.UserName.Contains(searchString);
            }
            else
            {
                Criteria = p => true;
            }
        }
    }
}