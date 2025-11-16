namespace NamingApp;

internal class Vehicle
{
    string Name { get; set; }

    int Capacity { get; set; }

    int Passengers { get; set; }

    bool IsRunning { get; set; }

    public Vehicle()
    {
        Passengers = 0;
        IsRunning = false;
    }

    public Vehicle(string name, int capacity) : this()
    {
        this.Name = name;
        this.Capacity = capacity;
    }

    void Ride()
    {
        string message = "Riding the vehicle";
        Console.WriteLine(message);
        Passengers++;
    }

    void Start()
    {
        string message = "Starting the vehicle";
        Console.WriteLine(message);
        IsRunning = true;
    }

    void Stop()
    {
        string message = "Stopping the vehicle";
        Console.WriteLine(message);
        IsRunning = false;
    }
}
