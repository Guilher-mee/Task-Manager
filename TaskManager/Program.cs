using System;
using System.Collections.Generic;
using System.Linq;
using TaskManager;
public class Program
{
    static List<TaskItem> tasks = new List<TaskItem>
    {

    };

    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Task Manager!");
        Console.WriteLine("Please enter a command (add, list, finish, exit):");



        while (true)
        {
            string? command = Console.ReadLine()?.Trim().ToLower();

            switch (command)
            {
                case "add":
                    AddTask();
                    break;
                case "list":
                    ListTasks();
                    break;
                case "finish":
                    FinishTask();
                    break;
                case "exit":
                    return;
                default:
                    Console.WriteLine("Unknown command. Please try again.");
                    break;
            }
        }
    }

    static void AddTask()
    {
        Console.WriteLine("Enter task title:");
        string? title = Console.ReadLine();
        if (!string.IsNullOrWhiteSpace(title))
        {
            int id = tasks.Count + 1;
            tasks.Add(new TaskItem { Id = id, Title = title, Finished = false });
            Console.WriteLine($"Task '{title}' added with ID {id}.");
        }
        else
        {
            Console.WriteLine("Task title cannot be empty.");
        }

    }

    static void ListTasks()
    {
        if (tasks.Count == 0)
        {
            Console.WriteLine("No tasks available.");
            return;
        }
        Console.WriteLine("Tasks:");
        foreach (var task in tasks)
        {
            string status = task.Finished ? "Finished" : "Pending";
            Console.WriteLine($"ID: {task.Id}, Title: {task.Title}, Status: {status}");


        }
    }
    static void FinishTask()
    {
        Console.WriteLine("Enter task ID to mark as finished:");
        if (int.TryParse(Console.ReadLine(), out int id))
        {
            var task = tasks.FirstOrDefault(t => t.Id == id);
            if (task != null)
            {
                task.Finished = true;
                Console.WriteLine($"Task '{task.Title}' marked as finished.");
            }
            else
            {
                Console.WriteLine($"No task found with ID {id}.");
            }
        }
        else
        {
            Console.WriteLine("Invalid ID. Please enter a numeric value.");
        }
    }
}




