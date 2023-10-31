using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02433Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02433();
        sut.FindArray(new[] {5, 2, 0, 3, 1}).Should().Equal(5, 7, 2, 3, 2);
    }

    [Test]
    public void T2()
    {
        var sut = new S02433();
        sut.FindArray(new[] {13}).Should().Equal(13);
    }
}