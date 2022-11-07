using SimpleMVVM.Model;
using System.Text.Json;
using System.Net.Http.Json;


namespace SimpleMVVM.Services;

public class PeopleService
{
    // List of person objects
    List<Person> _peopleList = new List<Person>();

    // .Net HTTP client for REST calls
    HttpClient _httpClient;
    public PeopleService()
    {
        _httpClient = new HttpClient();
    }
    // <summary>
    // The GetPeopleFileAsync task reads a list of people from local JSON file
    // <returns> list of people objects

    public async Task<List<Person>> GetPeopleFileAsync()
    {
        if(_peopleList.Count > 0)
        {
            return _peopleList;
            // maybe dont fetch fresh data if within a certain timeframe?
        }

        //Load the Json data from file
        using var stream = await FileSystem.OpenAppPackageFileAsync("People.json");
        using var reader = new StreamReader(stream);
        var contents = await reader.ReadToEndAsync(); // big long string of data

        //need to deserealise
        _peopleList = JsonSerializer.Deserialize<List<Person>>(contents);
        
        //Return the list of people
        return _peopleList;

    }

    public async Task<List<Person>> GetPeopleRemoteAsync()
    {
        if (_peopleList.Count > 0)
        {
            return _peopleList;
            // maybe dont fetch fresh data if within a certain timeframe?
        }

        // Fetch the data from the remote repository
        var url = "https://raw.githubusercontent.com/Atlantic-Technological-University/CrossPlatformDev/main/Week5/SimpleMVVM/SimpleMVVM/Resources/Raw/People.json";
        var response = await _httpClient.GetAsync(url);

        if(response.IsSuccessStatusCode)
        {
            _peopleList = await response.Content.ReadFromJsonAsync<List<Person>>();
        }
        
        //Return the list of people
        return _peopleList;

    }

    // https://github.com/Atlantic-Technological-University/CrossPlatformDev/blob/main/Week5/SimpleMVVM/SimpleMVVM/Resources/Raw/People.json
}
