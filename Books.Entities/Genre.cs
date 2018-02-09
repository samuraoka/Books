using System.ComponentModel.DataAnnotations;

namespace Books.Entities
{
    public enum Genre
    {
        // MVC EnumDropdownListFor bind with enum example 
        // http://www.advancesharp.com/blog/1163/mvc-enumdropdownlistfor-bind-with-enum-example
        [Display(Name = "Non Fiction")]
        NonFiction,
        Romance,
        Action,
        [Display(Name = "Science Fiction")]
        ScienceFiction,
    }
}
