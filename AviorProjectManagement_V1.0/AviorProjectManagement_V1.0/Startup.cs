﻿using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AviorProjectManagement_V1._0.Startup))]
namespace AviorProjectManagement_V1._0
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
