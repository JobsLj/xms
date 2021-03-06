﻿using System.Collections.Generic;
using System.ComponentModel;
using Xms.Core.Data;
using Xms.Event.Abstractions;

namespace Xms.Sdk.Event
{
    [Description("实体创建后事件")]
    public class EntityCreatedEvent : ObjectCreatedEvent<Entity>, IEvent
    {
        public EntityCreatedEvent(Entity @object) : base(@object)
        {
            Object = @object;
        }

        public Schema.Domain.Entity EntityMetadata { get; set; }
        public List<Schema.Domain.Attribute> AttributeMetadatas { get; set; }
    }
}