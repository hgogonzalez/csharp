public class User
{
    // Properties
    public string? _name { get; set; }
    public string? _country { get; set; }

    // Constructor
    public User(string name, string country)
    {
        _name = name;
        _country = country;
    }

    // Constructor sin parámetros
    public User()
    {
        _name = "";
        _country = "";
    }

    // Public property
    public string Name
    {
        get { return _name; }
        set { _name = value; }
    }

    public string Country
    {
        get { return _country; }
        set { _country = value; }
    }
}
