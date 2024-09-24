namespace _03
{
    public class User
    {
        private string name_;
        private string password_;
        private string login_;
        private string Surname_;
        public User(string login, string Surname, string name, string password)
        {
            name_ = name;
            password_ = password;
            login_ = login;
            Surname_ = Surname;

        }
        public string Login { get { return login_; } }
        public string Name { get { return name_; } }
        public string Surname { get { return Surname_; } }
        public string Password { get { return password_; } }

    }
}
