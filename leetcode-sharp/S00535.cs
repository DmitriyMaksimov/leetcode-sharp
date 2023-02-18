namespace leetcode_sharp;

// 535. Encode and Decode TinyURL
// https://leetcode.com/problems/encode-and-decode-tinyurl/
public class S00535
{
    private const string baseUrl = "http://tinyurl.com/";
    private Dictionary<string, string> _id2url = new();
    private Dictionary<string, string> _url2id = new();
    
    // Encodes a URL to a shortened URL
    public string encode(string longUrl)
    {
        if (_url2id.TryGetValue(longUrl, out var id))
        {
            return baseUrl + id;
        }

        var newId = Guid.NewGuid().ToString("N");
        _url2id[longUrl] = newId;
        _id2url[newId] = longUrl;
        
        return baseUrl + newId;
    }

    // Decodes a shortened URL to its original URL.
    public string decode(string shortUrl)
    {
        var id = shortUrl[baseUrl.Length..];

        if (_id2url.TryGetValue(id, out var url))
        {
            return url;
        }
        
        return null;
    }
}