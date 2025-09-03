using BlazorSampleApp.Components.Model;

namespace BlazorSampleApp.Components.Objects
{
    public class RoomManager
    {
        public List<Room> Rooms { get; } = new();

        public event Action? OnChange;

        public void AddRoom(string roomId)
        {
            Rooms.Add(new Room(roomId));
            NotifyStateChanged();
        }

        public void DeleteRoom(Room room)
        {
            Rooms.Remove(room);
            NotifyStateChanged();
        }

        private void NotifyStateChanged() => OnChange?.Invoke();
    }
}
