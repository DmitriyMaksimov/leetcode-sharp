using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00729Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00729.MyCalendar();
        Assert.That(sut.Book(10, 20), Is.True);
        Assert.That(sut.Book(15, 25), Is.False);
        Assert.That(sut.Book(20, 30), Is.True);
    }
}
