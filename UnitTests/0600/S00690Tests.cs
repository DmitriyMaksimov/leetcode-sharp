using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00690Tests
{
    [Test]
    public void T1()
    {
        var e1 = new S00690.Employee { id = 1, importance = 5, subordinates = [2, 3] };
        var e2 = new S00690.Employee { id = 2, importance = 3, subordinates = [] };
        var e3 = new S00690.Employee { id = 3, importance = 3, subordinates = [] };

        var sut = new S00690();
        Assert.That(sut.GetImportance([e1, e2, e3], 1), Is.EqualTo(11));
    }

    [Test]
    public void T3()
    {
        var e1 = new S00690.Employee { id = 1, importance = 2, subordinates = [5] };
        var e2 = new S00690.Employee { id = 5, importance = -3, subordinates = [] };

        var sut = new S00690();
        Assert.That(sut.GetImportance([e1, e2], 5), Is.EqualTo(-3));
    }
}
