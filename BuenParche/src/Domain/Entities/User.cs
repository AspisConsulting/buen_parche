namespace BuenParche.Domain.Entities;

public class User
{
    public Guid Id { get; set; }
    public string Email { get; set; }
    public string FirstName { get; set; }
    public string SecondName { get; set; }
    public string FirstLastName { get; set; }
    public string SecondLastName { get; set; }
    public int CodeCountry { get; set; }
    public int CityCountry { get; set; }
    public DateTime? BornDate { get; set; } = null;
    public DateTime? ActivatedDate { get; set; }
    public bool IsPremium { get; set; } = false;
    public string AboutMe { get; set; }
    public string Skills { get; set; }
    public string MusicMoviesBooks { get; set; }
    public string SportsHobbies { get; set; }
    public string ProfilePhotoUrl { get; set; }
    public string FirstPhone { get; set; }
    public string SecondPhone { get; set; }
    public string FacebookUrl { get; set; }
    public string TwitterUrl { get; set; }
    public string InstagramUrl { get; set; }
    public string GoogleUrl { get; set; }
    public Guid IdAzureDirectory { get; set; }        
    public DateTime? LastLogin { get; set; } = null;
    public DateTime? LastLogout { get; set; } = null;
    public int State { get; set; }
    public bool IsLogged { get; set; }
}