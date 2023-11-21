using Xunit;

//https://leetcode.com/problems/flood-fill/

namespace Tests
{
    public class FloodFillTests
    {
        [Fact]
        public void TestFloodFillCase1()
        {
            var input = new int[][] { new int [] { 1, 1, 1 },
                                      new int [] { 1, 1, 0 },
                                      new int [] { 1, 0, 1 } };

            var expected = new int[][] { new int [] { 2, 2, 2 },
                                      new int [] { 2, 2, 0 },
                                      new int [] { 2, 0, 1 } };

            var output = FloodFill(input, 1, 1, 2);

            Assert.Equivalent(expected, output);
        }

        [Fact]
        public void TestFloodFillCase2()
        {
            var input = new int[][] { new int [] { 0, 0, 0 },
                                      new int [] { 0, 0, 0 } };

            var output = FloodFill(input, 0, 0, 0);

            Assert.Equivalent(input, output);
        }

        public int[][] FloodFill(int[][] image, int sr, int sc, int color)
        {
            var currentColor = image[sr][sc];

            if (currentColor == color) return image;

            image[sr][sc] = color;

            if (sr > 0 && image[sr - 1][sc] == currentColor)
            {
                image = FloodFill(image, sr - 1, sc, color);
            }
            if (sc > 0 && image[sr][sc - 1] == currentColor)
            {
                image = FloodFill(image, sr, sc - 1, color);
            }
            if (sr + 1 < image.Length && image[sr + 1][sc] == currentColor)
            {
                image = FloodFill(image, sr + 1, sc, color);
            }   
            if (sc + 1 < image[0].Length && image[sr][sc + 1] == currentColor)
            {
                image = FloodFill(image, sr, sc + 1, color);
            }

            return image;
        }
    }
}
