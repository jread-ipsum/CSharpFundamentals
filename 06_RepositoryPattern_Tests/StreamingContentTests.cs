using _06_RepositoryPattern_Repository;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace _06_RepositoryPattern_Tests
{
    [TestClass]
    public class StreamingContentTests                                  //Writing Tests in order to Test our Repository CRUD
    {
        [TestMethod]
        public void SetTitle_ShouldSetCorrectString()                       
        {
            // Arrange
            StreamingContent content = new StreamingContent();          //new instance of POCO.  'content' is the new instance of 'StreamingContent'

            content.Title = "Toy Story";                                //Setting title.  'content.Title using our 'setter' to set value "Toy Story" to Title.  calling content, using '.' operator to access 'Title' from 'StreamingConent.cs' file. Then assigning a new value ex: "Toy Story"

            // Act
            string expected = "Toy Story";                              //Declaring variables.  
            string actual = content.Title;                              // 'content.Title' using our getter. Getting the value and assigning it to 'actual'.

            // Assert
            Assert.AreEqual(expected, actual);                          //The expected and actual do not at all need to match the above string names. 
        }
    }
}
