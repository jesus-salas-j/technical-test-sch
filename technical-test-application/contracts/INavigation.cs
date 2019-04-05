using technical_test_domain;

namespace technical_test_application.contracts
{
    public interface INavigation
    {
        bool IsAccessAllowed(User user, Page page);
    }
}
