﻿using System;
using System.ComponentModel;

namespace CapnProto
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Field | AttributeTargets.Enum, AllowMultiple = false, Inherited = false)]
    [ImmutableObject(true)]
    public class IdAttribute : Attribute
    {
        public IdAttribute(ulong id)
        {
            this.Id = id;
        }
        public ulong Id { get; private set; }
    }
}