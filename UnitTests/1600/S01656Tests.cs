using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01656Tests
{
    [Test]
    public void T1()
    {
        var os = new S01656.OrderedStream(5);
        Assert.That(os.Insert(3, "ccccc"), Is.Empty); // Inserts (3, "ccccc"), returns [].
        os.Insert(1, "aaaaa").Should().Equal("aaaaa"); // Inserts (1, "aaaaa"), returns ["aaaaa"].
        os.Insert(2, "bbbbb").Should().Equal("bbbbb", "ccccc"); // Inserts (2, "bbbbb"), returns ["bbbbb", "ccccc"].
        Assert.That(os.Insert(5, "eeeee"), Is.Empty); // Inserts (5, "eeeee"), returns [].
        os.Insert(4, "ddddd").Should().Equal("ddddd", "eeeee"); // Inserts (4, "ddddd"), returns ["ddddd", "eeeee"].
    }
}