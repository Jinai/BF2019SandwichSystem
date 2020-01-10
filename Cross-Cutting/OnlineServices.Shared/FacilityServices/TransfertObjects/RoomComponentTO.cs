namespace OnlineServices.Common.FacilityServices.TransfertObjects
{
    public class RoomComponentTO
    {
        public int ComponentTypeId { get; set; }
        public ComponentTypeTO ComponentType { get; set; }

        public int RoomId { get; set; }
        public RoomTO Room { get; set; }
    }
}
