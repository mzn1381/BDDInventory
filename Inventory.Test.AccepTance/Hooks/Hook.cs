using System;
using Inventory.Presentation.Test.Integration;
using Inventory.Presentation.Test.Integration.NetCoreHosting;
using TechTalk.SpecFlow;

namespace Inventory.Test.AccepTance.Hooks;

    [Binding]
    public class Hooks
    {
        
        [BeforeFeature("Inventory")]
        public static void StartHost()
        {
         DotNetCoreHost _host = new DotNetCoreHost(new DotNetCoreHostOptions()
        {
            CsProjectPath =HostConstants.CsProjectPath,
            Port = HostConstants.Port
        });
        _host.Start();

        } 
        [AfterFeature("Inventory")]
        public static void StopHost()
        {
  DotNetCoreHost _host = new DotNetCoreHost(new DotNetCoreHostOptions()
        {
            CsProjectPath =HostConstants.CsProjectPath,
            Port = HostConstants.Port
        });
        _host.Stop();
        }

    }

