Person person1 = new Person();
person1.Name = "ilyas";
person1.SurName = "bozdemir";
person1.Age = 26;
Console.WriteLine($"person : {person1.NameSurName} age:{person1.Age}");
class Person
{
    private string name;
    private string surName;
    private string nameSurName;
    private int age = 0;
    public int Age
    {
        get { return age; }
        set
        {
            if (value > 0)
                age = value;
            else
                Console.WriteLine("Yaş değeri negatif olamaz.");
        }
    }
    public string Name { get { return name; }set { name = value; }}
    public string SurName 
    {
        get { return surName; }
        set { surName = value; }
    }
    public string NameSurName
    {
        get { return nameSurName = name + " " + surName; }
    }
}

