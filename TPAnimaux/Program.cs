using TPAnimaux;

List<Animal> animals = new List<Animal>();
animals.Add(new Vache("Marguerite", 1200, "violette"));
animals.Add(new Ane("Arioul", 120, "orange"));
animals.Add(new OrangOutan("Gérard", 13, "rouge"));

foreach (Animal bete in animals)
{
    Console.WriteLine(bete);

}