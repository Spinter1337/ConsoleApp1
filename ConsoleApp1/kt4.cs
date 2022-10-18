// See https://aka.ms/new-console-template for more information
Room r1 = new Room();
Room r2 = new Room(20);
Room r3 = new Room(r2);

r1.Show();
r2.Show();
r3.Show();
class Room
{
    private int number;
    public void Show()
    {
        Console.WriteLine(number);
    }
    public Room()
    {
        Random rnd = new Random();
        number = rnd.Next();
    }
    public Room(int number)
    {
        this.number = number;
    }
    public Room(Room room)
    {
        this.number = room.number;
    }
}
