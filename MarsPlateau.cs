/// <summary>
/// A 'Composite' class
/// </summary>
public class MarsPlateau : Robot
{
    List<Robot> children = new List<Robot>();
    private string _size;
    private int _maxLatitude;
    private int _maxLongitude;

    public MarsPlateau(string size, string? name) : base(name)
    {
        if (name is null)
        {
            this.name = "Mars Plateau";
        }
        this._size = size.ToLower();
        string[] splitedSize = this._size.Split('x');

        this._maxLatitude = Int32.Parse(splitedSize[0]);
        this._maxLongitude = Int32.Parse(splitedSize[1]);
    }

    public override void Add(Robot component)
    {
        children.Add(component);
    }

    public override void Remove(Robot component)
    {
        children.Remove(component);
    }

    public override void Display()
    {

        Console.WriteLine(name);
        // Recursively display child nodes
        int robotNumber = 1;
        foreach (Robot component in children)
        {
            if (component.name is null)
            {
                Console.WriteLine("Robot number " + robotNumber);
            } 
            else
            {
                component.Display();
            }
            robotNumber++;
        }
    }

    public String getSize()
    {
        return this._size;
    }

    public Int32 getMaxLatitude()
    {
        return this._maxLatitude;
    }

    public Int32 getMaxLongitude()
    {
        return this._maxLongitude;
    }

    public bool validatePosition(int latitude, int longitude)
    {
        if (latitude > this._maxLatitude || longitude > this._maxLongitude)
        {
            throw new WrongCommandException("Command out of range");
        }

        return true;
    }
}