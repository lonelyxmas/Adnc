﻿namespace Adnc.Infra.Caching.Core
{
    /// <summary>
    /// EasyCaching const value.
    /// </summary>
    public class CachingConstValue
    {
        /// <summary>
        /// The config section.
        /// </summary>
        //public const string ConfigSection = "easycaching";
        /// <summary>
        /// The default name of the serializer.
        /// </summary>
        public const string DefaultSerializerName = "binary";

        public const string DefaultProtobufSerializerName = "proto";

        public const string DefaultJsonSerializerName = "json";

        public const string StackExchange = "redis.stackexchange";

        public const int PollyTimeout = 5;
    }
}