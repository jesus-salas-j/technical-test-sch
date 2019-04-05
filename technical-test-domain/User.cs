namespace technical_test_domain
{
    public class User
    {
        public Roles Role { get; }

        public User(Roles role)
        {
            Role = role;
        }
    }
}
