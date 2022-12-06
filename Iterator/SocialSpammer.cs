using System;

namespace Iterator
{
    class SocialSpammer
    {
        public void send(IProfileIterator iterator, string message)
        {
            while (iterator.hasMore())
            {
                var profile = iterator.getNext();
            }

        }
    }
}