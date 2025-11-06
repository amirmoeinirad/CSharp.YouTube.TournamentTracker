namespace TrackerLibrary
{
    // This class hold the data for a team.
    public class TeamModel
    {
        // Here, we are initializing the properties to avoid null reference issues.
        public List<PersonModel> TeamMembers { get; set; } = [];
        public string TeamName { get; set; } = string.Empty;
    }
}
