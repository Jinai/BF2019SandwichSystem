namespace OnlineServices.Shared.FacilityServices.TransfertObjects
{
    public class RoomTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public FloorTO FloorAttached { get; set; }
    }
}
