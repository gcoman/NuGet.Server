using System;

namespace NuGet.Server.Core.Infrastructure
{
    public class PackageAddedEventArgs : EventArgs
    {
        public ServerPackage Package { get; set; }
    }
}