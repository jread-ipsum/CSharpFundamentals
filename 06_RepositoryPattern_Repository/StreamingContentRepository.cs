using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_RepositoryPattern_Repository                                              //CRUD = Create Read Update Delete
{
    public class StreamingContentRepository                                             //This class will be used to manipulate and hold our data
    {           //Type                  //Name          //new up a list of content
        private List<StreamingContent> _listOfContent = new List<StreamingContent>();   //creation of a "Field".    //Field is a class level 'variable'


        //CREATE
          //return type //name of method            //object                            //first step
        public void AddContentToList(StreamingContent content)                          //method
        {
            _listOfContent.Add(content);                                                //fields always start with and underscore '_' ex: _listOfContent.  
        }

        //READ                                                                          //second step
        public List<StreamingContent> GetContentList()                                  //This method creates a bridge to return the 'private' _list of contents
        {
            return _listOfContent;
        }

        //UPDATE                                                                        //last step.  Need to be able to be given new preferred what we want our content to look like, but also know what our content was before.
        public bool UpdateExistingContent(string originalTitle, StreamingContent newContent)    //need 2 parameters, 1 to know what was the original content? and 2 what is my new content?
        {
            //Find the content
            StreamingContent oldContent = GetContentByTitle(originalTitle);

            //Update the content
            if(oldContent != null)                                                      //if oldContent is not = to null.    //Use of bang operator 
            {
                oldContent.Title = newContent.Title;                                    //just updating properties to fill list.
                oldContent.Description = newContent.Description;                        //what we are doing is taking new values that we are now given from our object 'StreamingContent' and assigning them to the existing object on that list.  
                oldContent.MaturityRating = newContent.MaturityRating;
                oldContent.IsFamilyFriendly = newContent.IsFamilyFriendly;
                oldContent.StarRating = newContent.StarRating;
                oldContent.TypeOfGenre = newContent.TypeOfGenre;
                return true;
            }
            else
            {
                return false;
            }
        }

        //DELETE                                                                        //3rd step.
        public bool RemoveContentFromList(string title)                                 //Here is a title to remove, lets remove this object and then if we remove it return a true or false value 
        {
            StreamingContent content = GetContentByTitle(title);                        //first we need to find the content by its title

            if( content == null)                                                        //can't find content, return false
            {
                return false;
            }
                                                                                        //we now know there will be content to return because it passed the null bool.  We now need to 'get the count from the list' in order to check and make sure it successfully removed.  
            int initialCount = _listOfContent.Count;                                    //Count is property of our list
            _listOfContent.Remove(content);                                             //from our list of content we need to remove 'content' because content should be on this list

            if(initialCount > _listOfContent.Count)                                     
            {
                return true;                                                            //return True because 'intial count' of _listOfContent fires off before we removed single 'content' from _listOfContent
            }
            else
            {
                return false;
            }

        }

        //Helper method                                                                 //job is just to help the other methods in this class.
        public StreamingContent GetContentByTitle(string title)                        //gets the correct streaming content based on a parameter, in this case 'title'
        {
            foreach(StreamingContent content in _listOfContent)                         //need to iterate over the _list of content to check the title in order to find the correct one. 
            {
                if(content.Title.ToLower() == title.ToLower())                                              //Logic //if content Title = title then return the content
                {
                    return content;
                }
            }

            return null;                                                                //possibity that content not found then must return something, in this case 'null'. 
        }

    }
}
