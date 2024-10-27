using System;
using System.IO;
using System.Text.Json;
using Zoho_Migration.ZOHO.Projects;

public class ProjectMapper
{
    public static Project MapJsonFileToProject(string jsonResponse)
    {
        try
        {
            // Deserialize the JSON string into the Project object
            Project project = JsonSerializer.Deserialize<Project>(jsonResponse);

            if (project == null)
            {
                throw new Exception("Deserialization failed. The project object is null.");
            }

            //// Access project details
            //Console.WriteLine("Project Name: " + project.Name);
            //Console.WriteLine("Owner Name: " + project.OwnerName);
            //Console.WriteLine("Bug Count (Open): " + project.BugCount.Open);
            //Console.WriteLine("Task Count (Closed): " + project.TaskCount.Closed);
            //Console.WriteLine("Is Chat Enabled: " + project.IsChatEnabled);
            //Console.WriteLine("Start Date: " + project.StartDate);

            // Access nested properties like links
            Console.WriteLine("Task URL: " + project.Link.Task.UrlValue);

            return project;
        }
        catch (FileNotFoundException ex)
        {
            Console.WriteLine("File not found: " + ex.Message);
            return null;
        }
        catch (IOException ex)
        {
            Console.WriteLine("An error occurred while reading the file: " + ex.Message);
            return null;
        }
        catch (Exception ex)
        {
            Console.WriteLine("An error occurred while mapping JSON to Project: " + ex.Message);
            return null;
        }
    }
}
