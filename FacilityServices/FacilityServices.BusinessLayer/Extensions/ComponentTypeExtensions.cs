using FacilityServices.BusinessLayer.Domain;
using OnlineServices.Shared.FacilityServices.TransfertObjects;
using System;
using System.Linq;
using System.Runtime.Serialization;

namespace FacilityServices.BusinessLayer.Extensions
{
    public static class ComponentTypeExtensions
    {
        public static ComponentType ToDomain(this ComponentTypeTO ComponentTypeTO)
        {
            if (ComponentTypeTO is null)
                throw new NotExistingCoponentTypeException(nameof(ComponentTypeTO));

            return new ComponentType()
            {
                Id = ComponentTypeTO.Id,
                Archived = ComponentTypeTO.Archived,
                Name = ComponentTypeTO.Name,
                //Issues = ComponentTypeTO.Issues.Select(x => x.ToDomain()).ToList(),
                
                
                
            };
        }
        public static ComponentTypeTO ToTransfertObject(this ComponentType ComponentType)
        {
            if (ComponentType is null)
                throw new NotExistingCoponentTypeException(nameof(ComponentType));

            return new ComponentTypeTO()
            {
                Id = ComponentType.Id,
                Archived = ComponentType.Archived,
                Name = ComponentType.Name,
                //Issues = ComponentType.Issues.Select(x => x.ToTransfertObject()).ToList(),


            };
        }

        [Serializable]
        private class NotExistingCoponentTypeException : Exception
        {
            public NotExistingCoponentTypeException()
            {
            }

            public NotExistingCoponentTypeException(string message) : base(message)
            {
            }

            public NotExistingCoponentTypeException(string message, Exception innerException) : base(message, innerException)
            {
            }

            protected NotExistingCoponentTypeException(SerializationInfo info, StreamingContext context) : base(info, context)
            {
            }
        }
    }
}