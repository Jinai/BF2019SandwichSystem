namespace FacilityServices.BusinessLayer.Domain
{
    public class RoomComponent
    {
        public int ComponentTypeId { get; set; }
        public ComponentType ComponentType { get; set; }

        public Room Room { get; set; }
    }
}
