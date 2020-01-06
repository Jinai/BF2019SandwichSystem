using OnlineServices.Shared.DataAccessHelpers;

namespace OnlineServices.Shared.FacilityServices.TransfertObjects
{
    public class RoomTO : IEntity<int>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public FloorTO Floor { get; set; }
    }
}
