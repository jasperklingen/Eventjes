using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evendjes.DataModel.Entities
{
    public class Activities
    {
        /// <summary>
        /// Technical db id
        /// </summary>
        public long Id { get; set; }

        /// <summary>
        /// functional application id
        /// </summary>
        public long FunctionalId { get; set; }

        /// <summary>
        /// Name of the Activity
        /// </summary>
        public required string Name { get; set; }

        /// <summary>
        /// The start datetime the activity is planned
        /// </summary>
        public DateTime StartTime { get; set; }

        /// <summary>
        /// The end datetime of the activity
        /// </summary>
        public DateTime EndTime { get; set; }

        /// <summary>
        /// Short description of the activity
        /// </summary>
        public string? Description { get; set; }

        /// <summary>
        /// Users who own the activity
        /// </summary>
        public required IEnumerable<Users> Organisers { get; set; }

        /// <summary>
        /// Users who want to attend
        /// </summary>
        public IEnumerable<Users>? Attendees { get; set; }

        /// <summary>
        /// Users who 
        /// </summary>
        public IEnumerable<Users>? Invitees { get; set; }
    }
}
