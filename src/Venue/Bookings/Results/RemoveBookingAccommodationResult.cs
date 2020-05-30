using Ivvy.API.Json;
using Newtonsoft.Json;

namespace Ivvy.API.Venue.Bookings
{
    public class RemoveBookingAccommodationResult : ISerializable
    {
        public enum Errors
        {
            Unknown = 1,
            HasReservations = 2,
        }

        /// <summary>
        /// Indicates success or failure of the api action.
        /// </summary>
        [JsonProperty("success")]
        public bool Success
        {
            get; set;
        }

        /// <summary>
        /// The error code on failure.
        /// </summary>
        [JsonProperty("errorType")]
        public Errors? ErrorType
        {
            get; set;
        }
    }
}