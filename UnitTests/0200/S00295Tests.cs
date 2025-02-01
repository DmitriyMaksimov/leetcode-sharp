using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00295Tests
{
    [Test]
    public void Test1()
    {
        var sut = new S00295();

        sut.AddNum(2);
        sut.AddNum(3);

        Assert.That(sut.FindMedian(), Is.EqualTo(2.5));

        sut.AddNum(4);
        Assert.That(sut.FindMedian(), Is.EqualTo(3));
    }

    [Test]
    public void Test2()
    {
        var operations = new[]
        {
            "MedianFinder", "addNum", "findMedian", "addNum", "findMedian", "addNum", "findMedian", "addNum", "findMedian", "addNum", "findMedian", "addNum", "findMedian",
            "addNum", "findMedian", "addNum", "findMedian", "addNum", "findMedian", "addNum", "findMedian", "addNum", "findMedian"
        };

        var args = new int?[] {null, 6, null, 10, null, 2, null, 6, null, 5, null, 0, null, 6, null, 3, null, 1, null, 0, null, 0, null};
        var expected = new double?[]
        {
            null,
            null, 6.00000, null, 8.00000, null, 6.00000, null, 6.00000, null, 6.00000, null, 5.50000, null, 6.00000, null, 5.50000, null, 5.00000, null, 4.00000, null, 3.00000
        };

        var sut = new S00295();

        for (var i = 0; i < operations.Length; i++)
        {
            switch (operations[i])
            {
                case "MedianFinder":
                    sut = new S00295();
                    break;
                case "addNum":
                    sut.AddNum(args[i] ?? 0);
                    break;
                case "findMedian":
                    sut.FindMedian().Should().Be(expected[i], $"{i}");
                    break;
            }
        }
    }
}