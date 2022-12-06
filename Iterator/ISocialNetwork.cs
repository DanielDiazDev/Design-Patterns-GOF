namespace Iterator
{
    interface ISocialNetwork
    {
        IProfileIterator createFriendsIterator(Profile profileId);
        IProfileIterator createCoworkersIterator(Profile profileId);
        void addProfile(Profile profile);
    }
}