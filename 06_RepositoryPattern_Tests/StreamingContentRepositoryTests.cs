using _06_RepositoryPattern_Repository;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace _06_RepositoryPattern_Tests
{
    [TestClass]
    public class StreamingContentRepositoryTests                                                       
    {
        private StreamingContentRepository _repo;                                                       //declaring a field for the object of 'StreamingContentRepository' called '_repo' .  //Just declaring here
        private StreamingContent _content;                                                              //declaring a field for the object of 'StreamingContent' called '_content'           //Just declaring here

        [TestInitialize]                                                                                //For all of our test we can set up some other methods and other content so that we do not have to do every single step every single time. 

        public void Arrange()                                                                           //this code will now run before each one of our below [Test Methods]
        {
            _repo = new StreamingContentRepository();                                                   //assigning value to our field that will assign each time a test is run. 
            _content = new StreamingContent("Rubber", "A car tyre comes to life with the power to make people explode and goes on a murderous rampage through the Californian desert.", "R", 5.8, false, GenreType.Drama);

            _repo.AddContentToList(_content);                                                           //Adding the content to the list so that when we access the _repo field we can actually see everything that is on that _repo
        }



                                                                                   //AAA paradigm.   Arrange, Act, Assert.
        //Add Method
        [TestMethod]
        public void AddToList_ShouldGetNotNull()                                                        //Method named.    Testing the 'AddToList' method
        {
            //Arrange --> Setting up the playing field
            StreamingContent content = new StreamingContent();                                          //new instance of StreamingContent called 'content'
            content.Title = "Toy Story";                                                                //give content a name or a title
            StreamingContentRepository repository = new StreamingContentRepository();                   //new instance of StreamingContentRepository named 'repository'

            //Act --> Get/run the code we want to test
            repository.AddContentToList(content);                                                       //adding content to the repository list.  Call 'repository' .AddContentToList(pass in 'content') 
            StreamingContent contentFromDirectory = repository.GetContentByTitle("Toy Story");          //get content back from repository.  naming it 'contentFromDirectory'

            //Assert --> Use the assert class to verify the expected outcome
            Assert.IsNotNull(contentFromDirectory);                                                     //passing in value for 'contentFromDirectory' to verify that it is not null. Test will fail if the title is anything but "Toy Story".
        }

        //Update
        [TestMethod]
        public void UpdateExistingContent_ShouldReturnTrue()                                            //Method named.    Testing our 'UpdateExistingContent' bool method
        {
            //Arrange
            //TestInitialize                                                                            //below has new content that will be updated 
            StreamingContent newContent = new StreamingContent("Rubber", "A car tyre comes to life with the power to make people explode and goes on a murderous rampage through the Californian desert.", "R", 10, false, GenreType.RomCom);

            //Act
            bool updateResult = _repo.UpdateExistingContent("Rubber", newContent);                      //updating actual content.  passing in original title of "Rubber" and passing in our 'newContent' from above              

            //Assert
            Assert.IsTrue(updateResult);                                                                
        }

        [DataTestMethod]                                                                                //Data Test Method allows us to test Data inline  by using Data Rows.  //Can you this to see multiple different sets of input.
        [DataRow ("Rubber", true)]                                                                      
        [DataRow("Toy Story", false)]
        public void UpdateExistingContent_ShouldMathcGivenBool(string originalTitle, bool shouldUpdate) //changing what our title is "Rubber" to a parameter.
        {
            //Arrange
            //TestInitialize
            StreamingContent newContent = new StreamingContent("Rubber", "A car tyre comes to life with the power to make people explode and goes on a murderous rampage through the Californian desert.", "R", 10, false, GenreType.RomCom);

            //Act
            bool updateResult = _repo.UpdateExistingContent("originalTitle", newContent);               //Updating existing title.

            //Assert
            Assert.AreEqual(shouldUpdate, updateResult);                                                //if title is "Rubber" it should return True.  If anything else it should return False. according to our DataRow from above. 
        }

        [TestMethod]
        public void DeleteContent_ShouldReturnTrue()                                                    //Testing DeleteContent method
        {
            //Arrange
                                                                                                        // Arrange already defined with our [TestInitialize]
            //Act
            bool deleteResult = _repo.RemoveContentFromList(_content.Title);                            //getting boolian 'deleteResult' setting = to our '_repoRemoveContentFromList' and passing in '_content.Title'

            //Assert
            Assert.IsTrue(deleteResult);

        }
        
    }
}
