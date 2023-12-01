using System;
using System.Collections.Generic;

public class ToDoList
{
    private List<string> tasks = new List<string>();

    // Додає нове завдання у список
    public void AddTask(string task)
    {
        tasks.Add(task);
        Console.WriteLine("Task added: " + task);
    }

    // Змінює існуюче завдання за вказаним індексом
    public void ChangeTask(int index, string newTask)
    {
        try
        {
            tasks[index] = newTask;
            Console.WriteLine("Task changed at index " + index + ": " + newTask);
        }
        catch (ArgumentOutOfRangeException)
        {
            Console.WriteLine("Invalid index. No task found at index " + index);
        }
    }

    // Видаляє завдання за вказаним індексом
    public void DeleteTask(int index)
    {
        try
        {
            tasks.RemoveAt(index);
            Console.WriteLine("Task deleted at index " + index);
        }
        catch (ArgumentOutOfRangeException)
        {
            Console.WriteLine("Invalid index. No task found at index " + index);
        }
    }

    // Виводить усі завдання у списку
    public void PrintTasks()
    {
        if (tasks.Count == 0)
        {
            Console.WriteLine("No tasks in the list.");
        }
        else
        {
            Console.WriteLine("Current Tasks:");
            for (int i = 0; i < tasks.Count; i++)
            {
                Console.WriteLine($"{i}: {tasks[i]}");
            }
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        ToDoList myToDoList = new ToDoList();

        myToDoList.AddTask("Task 1");
        myToDoList.AddTask("Task 2");
        myToDoList.PrintTasks();

        myToDoList.ChangeTask(1, "Updated Task 2");
        myToDoList.PrintTasks();

        myToDoList.DeleteTask(0);
        myToDoList.PrintTasks();
    }
}
