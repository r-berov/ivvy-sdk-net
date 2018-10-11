using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Ivvy
{
    public partial class Api : IApi
    {
        /// <summary>
        /// Returns a specific venue.
        /// </summary>
        public async Task<ResultOrError<Venue.Venue>> GetVenueAsync(
            int id)
        {
            return await this.CallAsync<Venue.Venue>(
                "venue", "getVenue", new { id = id }
            );
        }

        /// <summary>
        /// Returns a collection of venue accommodation rooms.
        /// </summary>
        public async Task<ResultOrError<ResultList<Venue.Room>>> GetVenueRoomListAsync(
            int venueId,
            int perPage,
            int start)
        {
            return await this.CallAsync<ResultList<Venue.Room>>(
                "venue", "getVenueRoomList", new { venueId = venueId, perPage = perPage, start = start }
            );
        }

        /// <summary>
        /// Returns a collection of venue rate plans.
        /// </summary>
        public async Task<ResultOrError<ResultList<Venue.RatePlan>>> GetVenueRatePlanListAsync(
            int venueId,
            int perPage,
            int start)
        {
            return await this.CallAsync<ResultList<Venue.RatePlan>>(
                "venue", "getVenueRatePlanList", new { venueId = venueId, perPage = perPage, start = start }
            );
        }

        /// <summary>
        /// Returns a specific venue booking.
        /// </summary>
        public async Task<ResultOrError<Venue.Booking>> GetVenueBookingAsync(int venueId, int id)
        {
            return await this.CallAsync<Venue.Booking>(
                "venue", "getBooking", new {
                    venueId = venueId,
                    id = id
                }
            );
        }

        /// <summary>
        /// Returns a collection of venue bookings in an iVvy venue.
        /// </summary>
        public async Task<ResultOrError<ResultList<Venue.Booking>>> GetVenueBookingListAsync(
            int venueId,
            int perPage,
            int start,
            Dictionary<string, string> filterRequest)
        {
            return await this.CallAsync<ResultList<Venue.Booking>>(
                "venue", "getBookingList", new {
                    venueId = venueId,
                    perPage = perPage,
                    start = start,
                    filter = filterRequest
                }
            );
        }

        /// <summary>
        /// Returns a collection of venue bookings in an iVvy account.
        /// </summary>
        public async Task<ResultOrError<ResultList<Venue.Booking>>> GetVenueBookingListForAccountAsync(
            int perPage,
            int start,
            Dictionary<string, string> filterRequest)
        {
            return await this.CallAsync<ResultList<Venue.Booking>>(
                "venue", "getBookingListForAccount", new
                {
                    perPage = perPage,
                    start = start,
                    filter = filterRequest
                }
            );
        }

        /// <inheritdoc />
        public async Task<ResultOrError<ResultSuccess>> AddOrUpdateVenueRoomCounts(
            int venueId,
            int roomId,
            string startDate,
            string endDate,
            int roomCount)
        {
            return await this.CallAsync<ResultSuccess>(
                "venue", "addOrUpdateRoomCounts", new
                {
                    venueId = venueId,
                    roomId = roomId,
                    startDate = startDate,
                    endDate = endDate,
                    roomCount = roomCount
                }
            );
        }

        /// <inheritdoc />
        public async Task<ResultOrError<ResultSuccess>> AddOrUpdateVenueRoomDynamicRates(
            int venueId,
            int ratePlanId,
            int roomId,
            string startDate,
            string endDate,
            double cost)
        {
            return await this.CallAsync<ResultSuccess>(
                "venue", "addOrUpdateRoomDynamicRates", new
                {
                    venueId = venueId,
                    barId = ratePlanId,
                    roomId = roomId,
                    startDate = startDate,
                    endDate = endDate,
                    cost = cost
                }
            );
        }

        /// <inheritdoc />
        public async Task<ResultOrError<ResultSuccess>> RemoveVenueRoomDynamicRates(
            int venueId,
            int ratePlanId,
            int roomId,
            string startDate,
            string endDate)
        {
            return await this.CallAsync<ResultSuccess>(
                "venue", "removeRoomDynamicRates", new
                {
                    venueId = venueId,
                    barId = ratePlanId,
                    roomId = roomId,
                    startDate = startDate,
                    endDate = endDate
                }
            );
        }

        /// <inheritdoc />
        public async Task<ResultOrError<ResultSuccess>> AddOrUpdateVenueRatePlanRules(
            int venueId,
            int ratePlanId,
            int roomId,
            string startDate,
            string endDate,
            Venue.RatePlan.CloseOutStatusOptions closeOutStatus)
        {
            return await this.CallAsync<ResultSuccess>(
                "venue", "addOrUpdateRatePlanBookingRules", new
                {
                    venueId = venueId,
                    barId = ratePlanId,
                    roomId = roomId,
                    startDate = startDate,
                    endDate = endDate,
                    closeOutStatus = closeOutStatus
                }
            );
        }
    }
}