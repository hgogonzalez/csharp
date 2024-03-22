public class Owner
{
    // Properties
    public string Name { get; set; }
    public string Country { get; set; }

    // Constructor
    public Owner(string name, string country)
    {
        Name = name;
        Country = country;
    }

    public Owner(){}

    public void SetName(string name)
    {
        if (name == "")
        {
            Name = "Binyamin Hoffman";
        }
        else
        {
            Name = name;
        }
    }

}
