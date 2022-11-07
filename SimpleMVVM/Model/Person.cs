
namespace SimpleMVVM.Model;

public class Person
{
    // Root myDeserializedClass = JsonConvert.DeserializeObject<List<Root>>(myJsonResponse);
    public int ID { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public string Gender { get; set; }
    public string ProfilePic { get; set; }
        
}
