namespace csharp_errors
{
  public class Contact
  {
    public string FirstName { get; set; }

    public string LastName { get; set; }

    public string Email { get; set; }

    public string Address { get; set; }

    // Calculated property that has no setter. It is readonly.
    public string FullName
    {
      get
      {
        return $"{FirstName} {LastName}";
      }
    }
  }
}
