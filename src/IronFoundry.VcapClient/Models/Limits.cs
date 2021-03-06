// -----------------------------------------------------------------------
// <copyright file="Limits.cs" company="Tier 3">
// Copyright © 2012 Tier 3 Inc., All Rights Reserved
// </copyright>
// -----------------------------------------------------------------------

namespace IronFoundry.Models
{
    using Newtonsoft.Json;

    public class Limits : EntityBase
    {
        [JsonProperty(PropertyName = "mem")]
        public int Mem { get; set; }

        [JsonProperty(PropertyName = "disk")]
        public int Disk { get; set; }

        [JsonProperty(PropertyName = "fds")]
        public int FDs { get; set; }
    }
}
