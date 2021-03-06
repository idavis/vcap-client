// -----------------------------------------------------------------------
// <copyright file="EntityBase.cs" company="Tier 3">
// Copyright © 2012 Tier 3 Inc., All Rights Reserved
// </copyright>
// -----------------------------------------------------------------------

namespace IronFoundry.Models
{
    using System;
    using Newtonsoft.Json;

    [Serializable]
    public abstract class EntityBase
    {
        public static T FromJson<T>(string argJson)
        {
            T rv = JsonConvert.DeserializeObject<T>(argJson);

            var message = rv as Message;
            if (null != message)
            {
                message.RawJson = argJson;
            }

            return rv;
        }

        public string ToJson()
        {
            return JsonConvert.SerializeObject(this);
        }

        public override string ToString()
        {
            return ToJson();
        }
    }
}
