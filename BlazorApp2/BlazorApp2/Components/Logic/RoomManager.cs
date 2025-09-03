using BlazorApp2.Components.Model;

namespace BlazorApp2.Components.Logic
{
    public class RoomManager
    {
        public List<Room> Rooms { get; } = new();

        public void AddRoom(string roomId)
        {
            if(string.IsNullOrWhiteSpace(roomId))
            {
                throw new ArgumentException("Room ID cannot be null or empty.", nameof(roomId));
            }

            if (Rooms.Any(r => r.Name == roomId))
            {
                throw new InvalidOperationException($"Room with ID '{roomId}' already exists.");
            }

            Rooms.Add(new Room(roomId));
        }

        public void RemoveRoom(string roomId)
        {
            var room = Rooms.FirstOrDefault(r => r.Name == roomId);
            if (room != null)
            {
                Rooms.Remove(room);
            }
            else
            {
                throw new InvalidOperationException($"Room with ID '{roomId}' does not exist.");
            }
        }
    }
}
