using Microsoft.VisualStudio.TestTools.UnitTesting;
using XMl_Lab2;
using System;
using System.Collections.Generic;
using System.Text;

namespace XMl_Lab2.Tests
{
    [TestClass()]
    public class SearchTests
    {
        ISearch algo = new Linq(XmlSearch.path);
        [TestMethod()]
        public void OneParametrRequest_LittleWomenReturn()
        {
            // arrange
            string[] movie = new string[5] { null, null, "Little Women", null, null };
            Movie request = new Movie(movie);
            List<Movie> expected = new List<Movie> { new Movie(new string[5] { "Drama", "Columbia Pictures", "Little Women", "2019", "140" }) };

            // act
            var result = algo.Method(request);

            // assert
            Assert.AreEqual(true, result[0].Equal(expected[0]));
            Assert.AreEqual(1, result.Count);
        }
        [TestMethod()]
        public void TwoParametrsRequest_DeadpoolReturn()
        {
            // arrange
            string[] movie = new string[5] { "Comedy", null, "Deadpool", null, null };
            Movie request = new Movie(movie);
            List<Movie> expected = new List<Movie> { new Movie(new string[5] { "Comedy", "20th Century Fox", "Deadpool", "2016", "100" }) };

            // act
            var result = algo.Method(request);

            // assert
            Assert.AreEqual(true, result[0].Equal(expected[0]));
            Assert.AreEqual(1, result.Count);
        }

        [TestMethod()]
        public void TwoParametrsRequest_Comedy20thCenturyReturn()
        {
            // arrange
            string[] movie = new string[5] { "Comedy", "20th Century Fox", null, null, null };
            Movie request = new Movie(movie);
            List<Movie> expected = new List<Movie> { new Movie(new string[5] { "Comedy", "20th Century Fox", "Deadpool", "2016", "100" }),
                new Movie(new string[5] { "Comedy", "20th Century Fox", "Bride wars", "2009", "90" }) };

            // act
            var result = algo.Method(request);

            // assert
            Assert.AreEqual(true, result[0].Equal(expected[0]));
            Assert.AreEqual(true, result[1].Equal(expected[1]));
            Assert.AreEqual(2, result.Count);
        }
        [TestMethod()]
        public void TwoParametrsRequest_NothingReturn()
        {
            // arrange
            string[] movie = new string[5] { "Comedy", null, "X-Men", null, null };
            Movie request = new Movie(movie);

            // act
            var result = algo.Method(request);

            // assert
            Assert.AreEqual(0, result.Count);
        }
        [TestMethod()]
        public void ThreeParametrRequest_MaleficentReturn()
        {
            // arrange
            string[] movie = new string[5] { "Adventure", "Walt Disney Pictures", null, null, "100" };
            Movie request = new Movie(movie);
            List<Movie> expected = new List<Movie> { new Movie(new string[5] { "Adventure", "Walt Disney Pictures", "Maleficent", "2014", "100" }) };

            // act
            var result = algo.Method(request);

            // assert
            Assert.AreEqual(true, result[0].Equal(expected[0]));
            Assert.AreEqual(1, result.Count);
        }

        [TestMethod()]
        public void AllParametrRequest_LittleWomenReturn()
        {
            // arrange
            string[] movie = new string[5] { "Drama", "Columbia Pictures", "Little Women", "2019", "140" };
            Movie request = new Movie(movie);
            List<Movie> expected = new List<Movie> { new Movie(new string[5] { "Drama", "Columbia Pictures", "Little Women", "2019", "140" }) };

            // act
            var result = algo.Method(request);

            // assert
            Assert.AreEqual(true, result[0].Equal(expected[0]));
            Assert.AreEqual(1, result.Count);
        }
    }
}