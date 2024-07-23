using System;
using System.Collections.Generic;

public class CreateContentItemParameters {
    public string Title { get; set; }
    public string Description { get; set; }
    public List<string> Tags { get; set; }
    public string CreatedBy { get; set; }
    public DateTime CreatedAt { get; set; }

    // Constructor
    public CreateContentItemParameters(string title, string description, List<string> tags, string createdBy) {
        Title = title;
        Description = description;
        Tags = tags;
        CreatedBy = createdBy;
        CreatedAt = DateTime.Now; // current date and time
    }
}
