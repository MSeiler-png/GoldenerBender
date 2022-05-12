using System.Net;

public static class BookApiInterface
{
	public static readonly HttpClient client = new HttpClient();

	public static async Task<OpenLibrarySearch> SearchAsync(OpenLibrarySearchParams @params)
	{
		string searchparams = "http://openlibrary.org/search.json?";
		if(@params.Title != null)
		{
			searchparams += "&title=" + @params.Title;
		}
		
		if(@params.Author != null)
		{
			searchparams += "&author=" + @params.Author;
		}
		
		if(@params.Place != null)
		{
			searchparams += "&place=" + @params.Place;
		}
		
		if(@params.Language != null)
		{
			searchparams += "&language=" + @params.Language;
		}
		
		if(@params.Harper != null)
		{
			searchparams += "&harper=" + @params.Harper;
		}
		HttpResponseMessage response = await client.GetAsync(searchparams);
		if(!response.IsSuccessStatusCode)
		{
			return default;
		}
		
		string responseBody = await response.Content.ReadAsString();
		
		return JsonSerializer.Deserialize<OpenLibrarySearch>(responseBody);
	}
}
