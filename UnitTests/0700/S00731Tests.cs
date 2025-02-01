using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00731Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00731.MyCalendarTwo();
        Assert.That(sut.Book(10, 20), Is.True);
        Assert.That(sut.Book(50, 60), Is.True);
        Assert.That(sut.Book(10, 40), Is.True);
        Assert.That(sut.Book(5, 15), Is.False);
        Assert.That(sut.Book(5, 10), Is.True);
        Assert.That(sut.Book(25, 55), Is.True);
    }
}
