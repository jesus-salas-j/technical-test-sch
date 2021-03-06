using Microsoft.VisualStudio.TestTools.UnitTesting;
using technical_test_application;
using technical_test_domain;
using technical_test_application.contracts;

namespace unit_tests
{
    [TestClass]
    public class NavigationShould
    {
        private static INavigation navigation;

        [ClassInitialize]
        public static void BeforeAll(TestContext context)
        {
            navigation = new Navigation();
        }

        [TestMethod]
        public void Allow_role_page1_access_page1_view()
        {
            User user = new User(Roles.PAGE_1);
            Page page = new Page("Page 1");

            bool userIsAllowedToAccessPage = navigation.IsAccessAllowed(user, page);

            Assert.IsTrue(userIsAllowedToAccessPage);
        }

        [TestMethod]
        public void Allow_role_page2_access_page2_view()
        {
            User user = new User(Roles.PAGE_2);
            Page page = new Page("Page 2");

            bool userIsAllowedToAccessPage = navigation.IsAccessAllowed(user, page);

            Assert.IsTrue(userIsAllowedToAccessPage);
        }

        [TestMethod]
        public void Allow_role_page3_access_page3_view()
        {
            User user = new User(Roles.PAGE_3);
            Page page = new Page("Page 3");

            bool userIsAllowedToAccessPage = navigation.IsAccessAllowed(user, page);

            Assert.IsTrue(userIsAllowedToAccessPage);
        }
    }
}
