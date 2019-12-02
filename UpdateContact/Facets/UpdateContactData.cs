using System;

namespace UpdateContact.Facets
{
    /// <summary>
    /// UpdateContactData
    /// </summary>
    public class UpdateContactData
    {
        /// <summary>
        /// FirstName
        /// </summary>

        public Guid FirstNameFieldId { get; set; }

        /// <summary>
        /// LastName
        /// </summary>

        public Guid LastNameFieldId { get; set; }

        /// <summary>
        /// Email
        /// </summary>

        public Guid EmailFieldId { get; set; }
    }
}
