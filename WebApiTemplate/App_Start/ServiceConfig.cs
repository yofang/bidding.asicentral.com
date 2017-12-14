﻿using ASI.Services.Statistics.Data;
using StructureMap;

namespace WebApiTemplate
{
    public static class ServiceConfig
    {
        public static void RegisterServices(ConfigurationExpression config)
        {
            config.ForSingletonOf<IQuery>().Use(context => new InMemoryRecordStore(432000000));
        }
    }
}