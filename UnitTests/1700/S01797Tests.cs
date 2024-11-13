using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01797Tests
{
    [Test]
    public void T1()
    {
        var authenticationManager = new S01797.AuthenticationManager(5);
        authenticationManager.Renew("aaa", 1); // No token exists with tokenId "aaa" at time 1, so nothing happens.
        authenticationManager.Generate("aaa", 2); // Generates a new token with tokenId "aaa" at time 2.
        authenticationManager.CountUnexpiredTokens(6).Should().Be(1); // The token with tokenId "aaa" is the only unexpired one at time 6, so return 1.
        authenticationManager.Generate("bbb", 7); // Generates a new token with tokenId "bbb" at time 7.
        authenticationManager.Renew("aaa", 8); // The token with tokenId "aaa" expired at time 7, and 8 >= 7, so at time 8 the renew request is ignored, and nothing happens.
        authenticationManager.Renew("bbb", 10); // The token with tokenId "bbb" is unexpired at time 10, so the renew request is fulfilled and now the token will expire at time 15.
        authenticationManager.CountUnexpiredTokens(15).Should().Be(0); // The token with tokenId "bbb" expires at time 15, and the token with tokenId "aaa" expired at time 7, so currently no token is unexpired, so return 0.
    }
}
