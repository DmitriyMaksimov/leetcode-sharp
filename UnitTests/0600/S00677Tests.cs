using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00677Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00677.MapSum();
        sut.Insert("apple", 3);
        Assert.That(sut.Sum("ap"), Is.EqualTo(3)); // return 3 (apple = 3)
        sut.Insert("app", 2);
        Assert.That(sut.Sum("ap"), Is.EqualTo(5)); // return 5 (apple + app = 3 + 2 = 5)
    }
}
