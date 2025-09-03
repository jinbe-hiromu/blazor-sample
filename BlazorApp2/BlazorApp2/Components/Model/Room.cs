namespace BlazorApp2.Components.Model
{
    public class Room
    {
        public string Name { get; init; }

        public Room(string roomId)
        {
            Name = roomId;
        }
    }
}
