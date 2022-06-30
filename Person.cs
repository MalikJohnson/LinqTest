using System;
using System.Diagnostics;


public class Person
{


    private int Id;
    private string Name;
    private DateTime Date;
    private int Age;
    private string Job;

    public int getId()
    {
        return Id;
    }
    public void setId(int Id)
    {
        this.Id = Id;
    }

    public string getName()
    {
        return Name;
    }

    public void setName(string Name)
    {
        this.Name = Name;
    }

    public DateTime getDate()
    {
        return Date;
    }
    public void setDate(DateTime Date)
    {
        this.Date = Date;
    }
    public int getAge()
    {
        return Age;
    }
    public void setAge(int Age)
    {
        this.Age = Age;
    }

    public string getJob()
    {
        return Job;
    }
    public void setJob(string Job)
    {
        this.Job = Job;
    }

    public Person(int Id, string Name, DateTime Date, int Age, string Job)
    {
        this.Id = Id;
        this.Name = Name;
        this.Date = Date;
        this.Age = Age;
        this.Job = Job;
    }

    public Person()
    {

    }




}
