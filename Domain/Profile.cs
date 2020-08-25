namespace Domain
{
    public class Profile
    {
        public int Id {get;set;}

        public string Name {get;set;}

        public string ProfilePicture {get;set;}

        public string Email{get;set;}

        public int Number {get;set;}

        public LostAdd MyLostAdds {get;set;}

        public FoundAdd MyFoundAdds {get;set;}
        
    }
}