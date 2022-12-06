namespace Iterator
{
    class Application
    {
        SocialSpammer spammer = new SocialSpammer();
        ISocialNetwork network = new Facebook();

        public ISocialNetwork Network { get => network; set => network = value; }

        public void sendSpamToFriends(Profile profile)
        {
            IProfileIterator iterator = Network.createFriendsIterator(profile);
            spammer.send(iterator, "Message");
        }
        public void sendSpamToCoworkers(Profile profile)
        {
            IProfileIterator iterator = Network.createCoworkersIterator(profile);
            spammer.send(iterator, "Message");
        }
    }
}