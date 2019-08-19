namespace NameApi.Models
{
    using System.Collections.Generic;
    public class NameItem
    {
        public long Id { get; set; }
        private string _firstName;
        public string FirstName
        {
            get { return _firstName; }
           set { _firstName = value; }
        }
        private string _email;
        public string Email
        {
            get { return _email; }
           set { _email = value; }
        }
        private int _password;
        public string Password
        {
            get { return _password.ToString(); }
           set { _password = value.GetHashCode(); }
        }
        private string _surname;
        public string Surname
        {
            get { return _surname; }
           set { _surname = value; }
        }

        public bool isPasswordMatch(string password){
            return password == Password;
        }
    }
}