using technical_test_application.contracts;
using technical_test_domain;

namespace technical_test_application
{
    public class Navigation : INavigation
    {
        public bool IsAccessAllowed(User user, Page page)
        {
            if (user.Role.Equals(Roles.PAGE_1))
            {
                return page.Name.Equals("Page 1");
            }

            return page.Name.Equals("Page 2");
        }
    }
}
