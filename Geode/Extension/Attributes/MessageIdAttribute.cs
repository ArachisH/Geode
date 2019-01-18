﻿using System;

namespace Geode.Extension
{
    [AttributeUsage(AttributeTargets.Property)]
    public sealed class MessageIdAttribute : Attribute
    {
        public string Hash { get; }

        public MessageIdAttribute(string hash)
        {
            Hash = hash;
        }
    }
}