using System.Collections.Generic;

namespace ToDoList.Objects
{
  public class Task
  {
    private string _description;
    private int _id;
    private static List<Task> _instances = new List<Task> {};

    // this instantiates a Task object, asking for a paramter which will then overwrite the _description variable.
    public Task (string description)
    {
      _description = description;
      // _id is now set to the the value of instances.count
      _id = _instances.Count;
      // the list variable _instances has method .Add() called on itself.  (this) represents the entire instance of the object and all of its values.
      _instances.Add(this);
    }
    // this is a method that passes the _description variable through to make it public
    public string GetDescription()
    {
      return _description;
    }
    // this is a method that passes the now public _description and actually changes its value
    public void SetDescription(string newDescription)
    {
      _description = newDescription;
    }

  // this is a method that passes the _id variable through to make it public
    public int GetId()
    {
      return _id;
    }
    // this is a method that passes the now public _description and actually changes its value
    public static List<Task> GetAll()
    {
      return _instances;
    }

    // this is a method that targest variable _instances and class method .ClearAll() which is part of C#;
    public static void ClearAll()
    {
      _instances.Clear();
    }
    // this instantiates object Task, then calls method Find() on it, then passes a variable integer called searchId
    public static Task Find(int searchId)
    {
      // this searches through the list and returns the instance with nummber(searchID) minus 1;
      return _instances[searchId-1];
    }
  }
}
