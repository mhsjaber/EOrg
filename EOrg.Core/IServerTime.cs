using System;

namespace EOrg.Core
{
    public interface IServerTime
    {
        DateTime CurrentDateTime { get; }
    }
}