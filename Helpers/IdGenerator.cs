
using System;

namespace LegacyOrderSystem.Helpers
{
    public static class IdGenerator
    {
        public static Guid NewId()
        {
            return Guid.NewGuid();
        }
    }
}
