using Xunit;
using ProjectMVCExample.Models;

namespace ProjectMVCExample.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void TestBookCreation()
        {
            // Arrange
            var title = "Sample Book";

            // Act
            var book = new Book { Title = title };

            // Assert
            Assert.Equal(title, book.Title);
        }

        [Fact]
        public void TestBookProperties()
        {
            // Arrange
            var id = 1;
            var title = "Test Book";
            var author = "Test Author";
            var genre = "Test Genre";

            // Act
            var book = new Book 
            { 
                Id = id, 
                Title = title, 
                Author = author, 
                Genre = genre 
            };

            // Assert
            Assert.Equal(id, book.Id);
            Assert.Equal(title, book.Title);
            Assert.Equal(author, book.Author);
            Assert.Equal(genre, book.Genre);
        }

        [Fact]
        public void TestBookEquality()
        {
            // Arrange
            var book1 = new Book { Id = 1, Title = "Test Book", Author = "Test Author", Genre = "Test Genre" };
            var book2 = new Book { Id = 1, Title = "Test Book", Author = "Test Author", Genre = "Test Genre" };

            // Act & Assert
            Assert.Equal(book1.Id, book2.Id);
            Assert.Equal(book1.Title, book2.Title);
            Assert.Equal(book1.Author, book2.Author);
            Assert.Equal(book1.Genre, book2.Genre);
        }

        [Fact]
        public void TestBookInequality()
        {
            // Arrange
            var book1 = new Book { Id = 1, Title = "Test Book", Author = "Test Author", Genre = "Test Genre" };
            var book2 = new Book { Id = 2, Title = "Another Book", Author = "Another Author", Genre = "Another Genre" };

            // Act & Assert
            Assert.NotEqual(book1.Id, book2.Id);
            Assert.NotEqual(book1.Title, book2.Title);
            Assert.NotEqual(book1.Author, book2.Author);
            Assert.NotEqual(book1.Genre, book2.Genre);
        }
    }
}
