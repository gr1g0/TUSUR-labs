class Programm
{
 static void Main(string[] args)
 {
 AnimalSubject cat = new Cat();
 AnimalSubject dog = new Dog();
 AnimalSubject cow = new Cow();
 AnimalSubject horse = new Horse();
 AnimalSubject[] ani = { cat, cow, horse, dog };
 foreach (var a in ani)
 {
 a.Talk();
 }
 }
}
abstract class AnimalSubject
{
 public abstract void Talk();
}
interface IAnimal
{
 void Talk();
}
class Cow : Artiodactyl, IAnimal
{
 private string animal = "Cow";
 private string talk = " goes moo moo!";
public override void Talk()
{
    Console.WriteLine(animal + talk);   
}
}
class Dog : AnimalSubject, IAnimal
{
 private string animal = "Dog";
 private string talk = " goes woof woof!";
 public override void Talk()
{
    Console.WriteLine(animal + talk);   
}
}
class Horse : AnimalSubject, IAnimal
{
 private string animal = "Horse";
 private string talk = " goes neigh!";
 public override void Talk()
{
    Console.WriteLine(animal + talk);   
}
}
class Cat : AnimalSubject, IAnimal
{
 private string animal = "Cat";
 private string talk = " goes meow meow!";
 public override void Talk()
{
    Console.WriteLine(animal + talk);   
}
}
abstract class Artiodactyl : AnimalSubject, IAnimal
{
}