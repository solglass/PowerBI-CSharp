// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.PowerBI.Api.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// An object describing Export to file details and current state
    /// </summary>
    public partial class Export
    {
        /// <summary>
        /// Initializes a new instance of the Export class.
        /// </summary>
        public Export()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Export class.
        /// </summary>
        /// <param name="id">The Export to file job ID</param>
        /// <param name="createdDateTime">The start time of the Export to file
        /// job</param>
        /// <param name="lastActionDateTime">The time of last change in the
        /// Export to file job</param>
        /// <param name="reportId">The ID of the exported report</param>
        /// <param name="status">The current state of the Export to file job.
        /// Possible values include: 'Undefined', 'NotStarted', 'Running',
        /// 'Succeeded', 'Failed'</param>
        /// <param name="percentComplete">Indicate job progress as
        /// percentage</param>
        /// <param name="resourceLocation">The URL for retrieving the exported
        /// file</param>
        /// <param name="expirationTime">The expiration time of the URL</param>
        public Export(string id = default(string), System.DateTime? createdDateTime = default(System.DateTime?), System.DateTime? lastActionDateTime = default(System.DateTime?), System.Guid? reportId = default(System.Guid?), ExportState? status = default(ExportState?), int? percentComplete = default(int?), string resourceLocation = default(string), System.DateTime? expirationTime = default(System.DateTime?))
        {
            Id = id;
            CreatedDateTime = createdDateTime;
            LastActionDateTime = lastActionDateTime;
            ReportId = reportId;
            Status = status;
            PercentComplete = percentComplete;
            ResourceLocation = resourceLocation;
            ExpirationTime = expirationTime;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the Export to file job ID
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets the start time of the Export to file job
        /// </summary>
        [JsonProperty(PropertyName = "createdDateTime")]
        public System.DateTime? CreatedDateTime { get; set; }

        /// <summary>
        /// Gets or sets the time of last change in the Export to file job
        /// </summary>
        [JsonProperty(PropertyName = "lastActionDateTime")]
        public System.DateTime? LastActionDateTime { get; set; }

        /// <summary>
        /// Gets or sets the ID of the exported report
        /// </summary>
        [JsonProperty(PropertyName = "reportId")]
        public System.Guid? ReportId { get; set; }

        /// <summary>
        /// Gets or sets the current state of the Export to file job. Possible
        /// values include: 'Undefined', 'NotStarted', 'Running', 'Succeeded',
        /// 'Failed'
        /// </summary>
        [JsonProperty(PropertyName = "status")]
        public ExportState? Status { get; set; }

        /// <summary>
        /// Gets or sets indicate job progress as percentage
        /// </summary>
        [JsonProperty(PropertyName = "percentComplete")]
        public int? PercentComplete { get; set; }

        /// <summary>
        /// Gets or sets the URL for retrieving the exported file
        /// </summary>
        [JsonProperty(PropertyName = "resourceLocation")]
        public string ResourceLocation { get; set; }

        /// <summary>
        /// Gets or sets the expiration time of the URL
        /// </summary>
        [JsonProperty(PropertyName = "expirationTime")]
        public System.DateTime? ExpirationTime { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (PercentComplete > 100)
            {
                throw new ValidationException(ValidationRules.InclusiveMaximum, "PercentComplete", 100);
            }
            if (PercentComplete < 0)
            {
                throw new ValidationException(ValidationRules.InclusiveMinimum, "PercentComplete", 0);
            }
        }
    }
}
