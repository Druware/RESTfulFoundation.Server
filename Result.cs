using System.Text.Json.Serialization;

namespace RESTfulFoundation.Server;

public class Result
{
    public static Result Error(List<string>? info = null)
    {
        Result result = new()
        {
            Succeeded = false,
            Info = info ?? new List<string>()
        };
        return result;
    }

    public static Result Error(string? info = null)
    {
        Result result = new()
        {
            Succeeded = false,
            Info = new List<string>()
        };
        if (info != null)
            result.Info!.Add(info);
        return result;
    }
    
    public static Result Error(
        object? entity = null)
    {
        Result result = new()
        {
            Succeeded = false,
            Entity = entity
        };
        return result;
    }

    public static Result Ok(
        List<string>? info = null)
    {
        Result result = new()
        {
            Succeeded = true,
            Info = info ?? new List<string>()
        };
        return result;
    }

    public static Result Ok(string? info = null)
    {
        Result result = new()
        {
            Succeeded = true,
            Info = new List<string>()
        };
        if (info != null)
            result.Info!.Add(info);
        return result;
    }
    
    public static Result Ok(
        object? entity = null)
    {
        Result result = new()
        {
            Succeeded = true,
            Entity = entity
        };
        return result;
    }

    public bool Succeeded { get; set; } = false;


    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public List<string>? Info { get; set; } = null;
    
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public object? Entity { get; set; } = null;
}

