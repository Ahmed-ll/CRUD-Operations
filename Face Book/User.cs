namespace Face_Book
{
    class User
    {
        public int Id { set; get; }
        public string Name { set; get; }
        public int Age { set; get; }
        public string Address { set; get; }
        public string Email { set; get; }

        public User( int id , string name,int age, string address, string email)
        {
            Id = id;
            Name = name;
            Age = age;
            Address = address;
            Email = email;
        }
    }
}
