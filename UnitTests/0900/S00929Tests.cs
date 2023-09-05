using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00929Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00929();
        sut.NumUniqueEmails(new[]
                {"test.email+alex@leetcode.com", "test.e.mail+bob.cathy@leetcode.com", "testemail+david@lee.tcode.com"})
            .Should().Be(2);
    }

    [Test]
    public void T2()
    {
        var sut = new S00929();
        sut.NumUniqueEmails(new[]
                {"a@leetcode.com", "b@leetcode.com", "c@leetcode.com"})
            .Should().Be(3);
    }
}