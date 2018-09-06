using System;

namespace NuGet.Server.Core.Infrastructure
{
    public class PackageRemovedEventArgs : EventArgs
    {
        public string Id { get; set; }
        public SemanticVersion Version { get; set; }
    }
}