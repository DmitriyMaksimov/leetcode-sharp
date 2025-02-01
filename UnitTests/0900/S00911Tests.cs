using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00911Tests
{
    [Test]
    public void T1()
    {
        var topVotedCandidate = new S00911.TopVotedCandidate([0, 1, 1, 0, 0, 1, 0], [0, 5, 10, 15, 20, 25, 30]);
        Assert.That(topVotedCandidate.Q(3), Is.EqualTo(0)); // return 0, At time 3, the votes are [0], and 0 is leading.
        Assert.That(topVotedCandidate.Q(12), Is.EqualTo(1)); // return 1, At time 12, the votes are [0,1,1], and 1 is leading.
        Assert.That(topVotedCandidate.Q(25), Is.EqualTo(1)); // return 1, At time 25, the votes are [0,1,1,0,0,1], and 1 is leading (as ties go to the most recent vote.)
        Assert.That(topVotedCandidate.Q(15), Is.EqualTo(0)); // return 0
        Assert.That(topVotedCandidate.Q(24), Is.EqualTo(0)); // return 0
        Assert.That(topVotedCandidate.Q(8), Is.EqualTo(1)); // return 1
    }
}
