namespace leetcode_sharp;

// 535. Encode and Decode TinyURL
// https://leetcode.com/problems/encode-and-decode-tinyurl/
public class S00535
{
    private const string BaseUrl = "http://tinyurl.com/";
    private readonly Dictionary<string, string> _id2Url = new();
    private readonly Dictionary<string, string> _url2Id = new();
    
    // Encodes a URL to a shortened URL
    public string encode(string longUrl)
    {
        if (_url2Id.TryGetValue(longUrl, out var id))
        {
            return BaseUrl + id;
        }

        var newId = Guid.NewGuid().ToString("N");
        _url2Id[longUrl] = newId;
        _id2Url[newId] = longUrl;
        
        return BaseUrl + newId;
    }

    // Decodes a shortened URL to its original URL.
    public string? decode(string shortUrl)
    {
        var id = shortUrl[BaseUrl.Length..];

        if (_id2Url.TryGetValue(id, out var url))
        {
            return url;
        }
        
        return null;
    }
}