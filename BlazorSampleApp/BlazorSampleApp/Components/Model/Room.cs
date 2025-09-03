namespace BlazorSampleApp.Components.Model
{
    public class Room
    {
        public string RoomId { get; }

        public Room(string roomId)
        {
            RoomId = roomId;
        }
    }
}