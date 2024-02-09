using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00811Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00811();
        sut.SubdomainVisits(["9001 discuss.leetcode.com"]).Should().BeEquivalentTo("9001 leetcode.com","9001 discuss.leetcode.com","9001 com");
    }

    [Test]
    public void T2()
    {
        var sut = new S00811();
        sut.SubdomainVisits(["900 google.mail.com", "50 yahoo.com", "1 intel.mail.com", "5 wiki.org"]).Should().BeEquivalentTo("901 mail.com","50 yahoo.com","900 google.mail.com","5 wiki.org","5 org","1 intel.mail.com","951 com");
    }
}