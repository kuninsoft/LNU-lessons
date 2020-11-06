namespace lab_5_1
{
    struct Person
    {
        string _firstname, _lastname;
        byte _age;

        public Person(string firstname, string lastname, byte age)
        {
            _firstname = firstname;
            _lastname = lastname;
            _age = age;
        }

        public string isOlderThan(byte n)
        {
            if (_age > n)
            {
                return $"{_firstname} {_lastname} is older than {n}.";
            }
            else if (_age < n)
            {
                return $"{_firstname} {_lastname} is younger than {n}.";
            }
            else
            {
                return $"{_firstname} {_lastname} is exactly {n} years old.";
            }
        }
    }
}
