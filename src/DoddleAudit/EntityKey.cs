using System;

namespace DoddleAudit
{
    public class EntityKey
    {
        public EntityKey(object key)
        {
            Key = key;
            KeyType = key.GetType();
        }

        public object Key { get; private set; }
        public Type KeyType { get; private set; }

        public override string ToString()
        {
            return Key != null ? Key.ToString() : "Unknown";
        }

        public static implicit operator int(EntityKey key)
        {
            if (key == null || key.Key == null)
                return -1;

            return (int) key.Key;
        }


        public static implicit operator int?(EntityKey key)
        {
            if (key == null || key.Key == null)
                return null;

            return (int?)key.Key;
        }

        public static implicit operator Guid?(EntityKey key)
        {
            if (key == null || key.Key == null)
                return null;

            return (Guid?)key.Key;
        }

        public static implicit operator Guid(EntityKey key)
        {
            if (key == null || key.Key == null)
                return Guid.Empty;

            return (Guid)key.Key;
        }
    }
}