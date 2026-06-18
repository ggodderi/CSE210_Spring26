
class Program
{

    public static void DisplayPersonInformation(Person person)
    {
        // if(person is Doctor doctor)
        //     Console.WriteLine(doctor.GetDoctorInformation());
        // else if (person is Police police)
        //     Console.WriteLine(police.GetPoliceManInformation());
        // else 
        Console.WriteLine(person.GetPersonInformation());
        Console.WriteLine(person.GetSalary());
        
    }


    public static void Main(string[] args)
    {
        // Person myPerson = new Person("Bob", "Roberts", 57, 198);
        // Console.WriteLine(myPerson.GetPersonInformation());

        Police myPoliceMan = new Police("Gun", "Robert", "Bob", 43, 187);

        // Console.WriteLine(myPoliceMan.GetPoliceManInformation());
        Doctor myDoctor = new Doctor("PhD", "Bob", "Payne", 43, 187);

        // Console.WriteLine(myDoctor.GetDoctorInformation());
        // myDoctor.ChangeWeight(10);
        // myPoliceMan.ChangeWeight(-11);
        // Console.WriteLine(myDoctor.GetDoctorInformation());
        // Console.WriteLine(myPoliceMan.GetPoliceManInformation());


        List<Person> myPeople = new List<Person>();
        // myPeople.Add(myPerson);
        myPeople.Add(myDoctor);
        myPeople.Add(myPoliceMan);

        foreach(Person person in myPeople)
        {
            // Console.WriteLine(person.GetPersonInformation());
            DisplayPersonInformation(person);
        }

    }
}











        // List<Person> myPeople = new List<Person>();
        // myPeople.Add(myPerson);
        // myPeople.Add(myPoliceMan);
        // myPeople.Add(myDoctor);

        // foreach (Person person in myPeople)
        // {
        //     // Console.WriteLine(person.GetPersonInformation());
        //     DisplayPersonInformation(person);
        // }

    //         public static void DisplayPersonInformation(Person person)
    // {
    //     // Console.WriteLine(person.GetPersonInformation());

    //     if(person is Doctor doctor)
    //     {
    //         Console.WriteLine(doctor.GetDoctorInformation());
    //     }
    //     else if(person is Police police)
    //     {
    //         Console.WriteLine(police.GetPoliceManInformation());
    //     }
    //     else
    //     {
    //         Console.WriteLine(person.GetPersonInformation());
    //     }
    // }