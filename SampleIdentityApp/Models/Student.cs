namespace SampleIdentityApp.Models;

public class Student
{
    #region StudentId
    /// <summary>
    /// Gets or sets the unique identifier for the entity.
    /// </summary>
    public required int Id { get; set; }
    #endregion

    #region FirstName
    /// <summary>
    /// The students legal first name.
    /// </summary>
    public required string FirstName { get; set; }
    #endregion

    #region LastName
    /// <summary>
    /// he students legal last name.
    /// </summary>
    public required string LastName { get; set; }
    #endregion
}