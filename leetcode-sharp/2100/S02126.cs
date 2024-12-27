namespace leetcode_sharp;

// 2126. Destroying Asteroids
// https://leetcode.com/problems/destroying-asteroids
public class S02126
{
    public bool AsteroidsDestroyed(int mass, int[] asteroids)
    {
        foreach (var asteroid in asteroids.Order())
        {
            if (mass < asteroid)
            {
                return false;
            }

            if (mass >= 100_000)
            {
                return true;
            }

            mass += asteroid;
        }

        return true;
    }
}
