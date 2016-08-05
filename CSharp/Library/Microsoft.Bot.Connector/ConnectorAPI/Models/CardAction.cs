// Code generated by Microsoft (R) AutoRest Code Generator 0.13.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Bot.Connector
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;

    /// <summary>
    /// </summary>
    public partial class CardAction
    {
        /// <summary>
        /// Initializes a new instance of the CardAction class.
        /// </summary>
        public CardAction() { }

        /// <summary>
        /// Initializes a new instance of the CardAction class.
        /// </summary>
        public CardAction(string type = default(string), string title = default(string), string image = default(string), string value = default(string))
        {
            Type = type;
            Title = title;
            Image = image;
            Value = value;
        }

        /// <summary>
        /// Defines the type of action implemented by this button. Possible
        /// values for this property include: 'openUrl', 'imBack',
        /// 'postBack', 'playAudio', 'playVideo', 'showImage', 'downloadFile'.
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }

        /// <summary>
        /// Text description which appear on the button.
        /// </summary>
        [JsonProperty(PropertyName = "title")]
        public string Title { get; set; }

        /// <summary>
        /// URL Picture which will appear on the button, next to text label.
        /// Media hosted on 3rd party domains will be automatically hosted on
        /// auth protected CDN.Auth protection will be used to ensure that
        /// content
        /// uploaded to Skype CDN will only be accessible by Microsoft Clients
        /// Please refer to Chapter 7 for description of media caching
        /// algorithm.
        /// </summary>
        [JsonProperty(PropertyName = "image")]
        public string Image { get; set; }

        /// <summary>
        /// Supplementary parameter for action. Content of this property
        /// depends on the ActionType
        /// </summary>
        [JsonProperty(PropertyName = "value")]
        public string Value { get; set; }

    }
}