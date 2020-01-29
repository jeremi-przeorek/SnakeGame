using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Snake.Test
{
    [TestClass]
    public class SnackTests
    {
        [TestMethod]
        public void IfSnackInTailReturnTrue()
        {
            //arrange
            Snack snack = new Snack(1,1);
            Snake snake = new Snake(2,1);
            snake.Tail.Add(new Coordinate(1, 1));

            //act
            var output = snack.IsInSnake(snake);
            //asset
            Assert.IsTrue(output);
        }
        [TestMethod]
        public void IfSnackInHeadReturnTrue()
        {
            //arrange
            Snack snack = new Snack(1, 1);
            Snake snake = new Snake(1, 1);

            //act
            var output = snack.IsInSnake(snake);
            //asset
            Assert.IsTrue(output);
        }
        [TestMethod]
        public void IfSnackOutOfSnakeReturnFalse()
        {
            //arrange
            Snack snack = new Snack(10, 10);
            Snake snake = new Snake(5, 1);
            snake.Tail.Add(new Coordinate(4, 1));
            snake.Tail.Add(new Coordinate(3, 1));
            snake.Tail.Add(new Coordinate(2, 1));
            snake.Tail.Add(new Coordinate(1, 1));

            //act
            var output = snack.IsInSnake(snake);
            //asset
            Assert.IsFalse(output);
        }
    }
}
