

namespace ReferenceApi.Employees;

public class EmployeeSlugGenerator
{
    public string Generate(string firstname, string? lastname)
    {
        //string? firstName = null;
        //if (string.IsNullOrEmpty(lastname))
        //{
        //    return Clean(firstname);
        //}
        //return $"{Clean(lastname)}-{Clean(firstname)}";
        var slug = (Clean(firstname), Clean(lastname)) switch
        {
            (string first, null) => first,
            (string first, string last) => $"{last}-{first}",
            _ => throw new InvalidOperationException() // Chaos
        };
        return slug;

    }


    private static string? Clean(string? part)
    {
        if (string.IsNullOrWhiteSpace(part)) { return null; }

        return part.ToLowerInvariant().Trim();
    }
}
