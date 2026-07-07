class Organism {
    public virtual void Observe() {
        Console.Write("Organism: ");
        BreathType();
    }
    public virtual void BreathType() {
        Console.WriteLine("Generic");
    }
}

class Mammal : Organism {
    public override void BreathType() {
        Console.WriteLine("Lungs");
    }
}

class Whale : Mammal {
    public override void Observe() {
        Console.Write("Whale: ");
        BreathType();
    }
    public override void BreathType() {
        Console.WriteLine("Blowhole");
    }
}

class Program {
    static void Main() {
        Organism obj1 = new Organism();
        Organism obj2 = new Mammal();
        Organism obj3 = new Whale();
        Mammal   obj4 = new Mammal();
        Mammal   obj5 = new Whale();
        Whale    obj6 = new Whale();
        // Whale    obj7 = new Organism();

        List<Mammal> myMammals = new List<Mammal>();   
        
        List<Organism> myObjects = new List<Organism>();

        myObjects.Add(obj1);
        myObjects.Add(obj2);
        myObjects.Add(obj3);
        myObjects.Add(obj4);
        myObjects.Add(obj5);
        myMammals.Add(obj6);

        obj1.Observe();
        obj2.Observe(); 
        obj3.Observe();
        obj4.Observe();
        obj5.Observe();
        obj6.Observe();
    }
}
