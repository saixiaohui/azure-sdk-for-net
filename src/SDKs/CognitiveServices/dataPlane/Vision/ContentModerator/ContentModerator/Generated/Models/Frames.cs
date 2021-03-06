// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.CognitiveServices.ContentModerator.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// The response for a Get Frames request.
    /// </summary>
    public partial class Frames
    {
        /// <summary>
        /// Initializes a new instance of the Frames class.
        /// </summary>
        public Frames()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Frames class.
        /// </summary>
        /// <param name="reviewId">Id of the review.</param>
        public Frames(string reviewId = default(string), IList<Frame> videoFrames = default(IList<Frame>))
        {
            ReviewId = reviewId;
            VideoFrames = videoFrames;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets id of the review.
        /// </summary>
        [JsonProperty(PropertyName = "ReviewId")]
        public string ReviewId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "VideoFrames")]
        public IList<Frame> VideoFrames { get; set; }

    }
}
