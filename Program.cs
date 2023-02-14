public class CommandHandler
{
    static void Main(string[] args) 
    {
        string? marsPlateauSize;
        string? commands;

        Console.WriteLine("Welcome to the robot moviment console!");
        Console.WriteLine("You can use following commands:");
        Console.WriteLine("L: Turn the robot left");
        Console.WriteLine("R: Turn the robot right");
        Console.WriteLine("F: Move forward on its facing direction");
        Console.WriteLine("Enter a plateau size: default (5x5):");

        try
        {
            marsPlateauSize = Console.ReadLine();
            if (string.IsNullOrEmpty(marsPlateauSize))
            {
                marsPlateauSize = "5x5";
            }
            MarsPlateau marsPlateau = new MarsPlateau(marsPlateauSize, null);

            Console.WriteLine("Enter a moviment command: default (FFRFLFLF):");
            commands = Console.ReadLine();
            if (string.IsNullOrEmpty(commands))
            {
                commands = "FFRFLFLF";
            }
            DefaultRobot robot = new DefaultRobot(null);
            marsPlateau.Add(robot);
            string location = robot.move(commands);
            if(marsPlateau.validatePosition(robot.getLatitude(), robot.getLongitude())){
                Console.WriteLine(location);
            }
        }
        catch (Exception e) when (
          e is WrongCommandException ||
          e is ProgrammingException
        ) {
            Console.WriteLine("Error: " + e.Message);
        } 
        catch
        {
            Console.WriteLine("Error: Invalid input!!");
        }
        
    }
}
