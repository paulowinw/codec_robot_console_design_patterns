
/// <summary>
/// The 'Component' abstract class
/// </summary>
public abstract class Robot
{
    public string? name;
        // Constructor
    public Robot(string? name)
    {
        if (name is not null)
        {
            this.name = name;
        }
    }
    public abstract void Add(Robot component);
    public abstract void Remove(Robot component);
    public abstract void Display();

}