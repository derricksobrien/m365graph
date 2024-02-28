using Microsoft.Graph.Models.ExternalConnectors;
static class ConnectionConfiguration
{
  public static ExternalConnection ExternalConnection
  {
    get
    {
      return new ExternalConnection
      {
        Id = "msgraphdocs",
        Name = "Microsoft Graph documentation",
        Description = "Documentation for Microsoft Graph API which    explains what Microsoft Graph is and how to use it."
      };
    }
  }
  public static Schema Schema
  {
    get
    {
      return new Schema
      {
        BaseType = "microsoft.graph.externalItem",
        Properties = new()
        {
          new Property
          {
            Name = "title",
            Type = PropertyType.String,
            IsQueryable = true,
            IsSearchable = true,
            IsRetrievable = true,
            Labels = new() { Label.Title }
          },
          new Property
          {
            Name = "description",
            Type = PropertyType.String,
            IsQueryable = true,
            IsSearchable = true,
            IsRetrievable = true
          },
          new Property
          {
            Name = "iconUrl",
            Type = PropertyType.String,
            IsRetrievable = true,
            Labels = new() { Label.IconUrl }
          },
          new Property
          {
            Name = "url",
            Type = PropertyType.String,
            IsRetrievable = true,
            Labels = new() { Label.Url }
          }
        }
      };
    }
  }
}