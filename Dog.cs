using System;
public enum Gender {Male, Female}; 
class Dog
{
    private string name;
    private string owner;
    private int age;
    private Gender gender;
    public Dog (string name, string owner, int age, Gender gender)
    {
        this.name = name;
        this.owner = owner;
        this.age = age;
        this.gender = gender;  
    }
    public void Bark (int woof)
    {
        for(int i=0; i<woof; i++)
        {
        Console.WriteLine("Woof!");
        }
    }
    public string GetTag()
    {
    string tag = "If lost, call "+owner+".";
    if (gender == 0)
    {
        tag += "His name is" +name+ "he is" + age.ToString() +"years old";
    }
    else
    {
        tag += "Her name is" +name+ "he is" + age.ToString() +"years old";
    }
    return tag;
    }





}