using exercise6;

Dog spike = new Dog("Spike", 5, true);
Cat cat = new Cat();
Frog frog = new Frog();
Kitten kitten = new Kitten();
TomCat tomcat = new TomCat();
frog.Name = "Gerrit";
cat.Name = "Tomnus";
kitten.Name = "Puss";
tomcat.Name = "Tazz";
Animal[] animals = {spike, cat, frog, kitten, tomcat};
for(int i = 0; i < animals.Length; i++)
{
    animals[i].MakeSound();
}

