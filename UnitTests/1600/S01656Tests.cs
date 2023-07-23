using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01656Tests
{
    [Test]
    public void T1()
    {
        var os = new S01656.OrderedStream(5);
        os.Insert(3, "ccccc").Should().Equal(); // Inserts (3, "ccccc"), returns [].
        os.Insert(1, "aaaaa").Should().Equal("aaaaa"); // Inserts (1, "aaaaa"), returns ["aaaaa"].
        os.Insert(2, "bbbbb").Should().Equal("bbbbb", "ccccc"); // Inserts (2, "bbbbb"), returns ["bbbbb", "ccccc"].
        os.Insert(5, "eeeee").Should().Equal(); // Inserts (5, "eeeee"), returns [].
        os.Insert(4, "ddddd").Should().Equal("ddddd", "eeeee"); // Inserts (4, "ddddd"), returns ["ddddd", "eeeee"].
    }
}