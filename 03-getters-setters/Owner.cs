public class Owner
{
    // Properties
    public string? Name { get; set; }
    public string? Country { get; set; }

    // Constructor
    public Owner(string name, string country)
    {
        Name = name;
        Country = country;
    }

    // Constructor sin parámetros
    public Owner()
    {
        Name = "";
        Country = "";
    }

    // Método para establecer el nombre
    public void SetName(string name)
    {
        Name = string.IsNullOrEmpty(name) ? "Binyamin Hoffman" : name;
    }

    // Método para obtener el nombre
    public string? GetName()
    {
        return Name;
    }
}
