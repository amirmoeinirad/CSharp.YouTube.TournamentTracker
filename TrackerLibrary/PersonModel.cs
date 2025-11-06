namespace TrackerLibrary
{
    // This class holds the data for a person.
    public class PersonModel
    {
        // We are initializing the properties to avoid null reference issues.
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string EmailAddress { get; set; } = string.Empty;
        public string CellPhoneNumber { get; set; } = string.Empty;
    }
}
