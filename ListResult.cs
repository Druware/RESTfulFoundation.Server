using System;
using System.Collections;
using System.Text.Json.Serialization;

namespace RESTfulFoundation.Server;

public class ListResult : Result
{
    /// <summary>
    /// A utility function to make creating a ListResult a quick and easy one
    /// function command. If the list is the only provided parameters, the
    /// result is assumed NOT to need or support paging. The Page will be 0,
    /// the perPage and total will be the same as the list.count.
    /// </summary>
    /// <param name="list"></param>
    /// <param name="total"></param>
    /// <param name="page"></param>
    /// <param name="perPage"></param>
    /// <param name="info"></param>
    /// <returns></returns>
    public static ListResult Ok(
        IList list,
        long? total = null,
        int? page = null,
        int? perPage = null,
        string? info = null)
    {
        ListResult result = new()
        {
            Succeeded = true,
            Info = null,
            Page = page,
            TotalRecords = total,
            PerPage = perPage,
            List = list
        };
        if (info != null)
        {
            result.Info = new();
            result.Info!.Add(info);
        }
        return result;
    }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public long? TotalRecords { get; set; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public int? Page { get; set; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public int? PerPage { get; set; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public IList? List { get; set; }
}

