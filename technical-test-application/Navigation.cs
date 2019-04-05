using technical_test_application.contracts;
using technical_test_domain;

namespace technical_test_application
{
    public class Navigation : INavigation
    {
        public bool IsAccessAllowed(User user, Page page)
        {
            switch (user.Role)
            {
                case Roles.PAGE_1:
                    return page.Name.Equals("Page 1");
                case Roles.PAGE_2:
                    return page.Name.Equals("Page 2");
                case Roles.PAGE_3:
                    return page.Name.Equals("Page 3");
                default:
                    return false;
            }
        }
    }
}
