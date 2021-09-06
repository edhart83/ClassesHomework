using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ClassesHomework
{
    [TestClass]
    public class ClassesHomework
    {
        // READ ME 
        // You need to solve all of the homework questions below.
        // The goal of this homework is to get practice creating classes
        // The Test Methods take you through the flow of creating a class and 
        // then enhancing it over time. Your class will be build up over the questions.
        // NOTHING WILL COMPILE BY DEFAULT. SO COMMENT OUT QUESTIONS AND SOLVE THEM ONE AT A TIME TOP
        // TO BOTTOM

        [TestMethod]
        public void BasicClassWithDefaultConstructor() 
        {
            // Goal 1: Create a dog class in the Dog Class File provided in the project.
            // The class must have at least a default constructor that takes no parameters.
            // Contraints: You are not allowed to change this code, only create the needed types.
            Dog dog = new Dog();
            Assert.IsTrue(dog is Dog); // the is keyword check the type of an object.
        }

        [TestMethod]
        public void SingleParameterConstructorAndProperty()
        {
            // Goal 1: Extend your Dog class to additionally support a constructor that takes in a dog breed.
            // Goal 2: Extend your Dog class to support a property named Breed that gets set with the value of the constructor argument.
            // Contraints: You are not allowed to change this code, only extend the type you already created..
            Dog collie = new Dog("collie");
            Assert.IsTrue(collie.Breed == "collie");
        }

        [TestMethod]
        public void DefaultAgeProperty()
        {
            // Goal 1: Extend your Dog class to additionally support a property Named Age.
            // Goal 2: Extend your Dog class to set Age of all dogs to 1 by default, simulating dog birth.
            // Goal 3: Retrofit your breed constuctor from SingleParameterConstructorAndProperty so that Age is set to 1 for dogs created with only a breed.
            // Contraints: You are not allowed to change this code, only extend the type you already created..
            Dog collie = new Dog();
            Assert.IsTrue(collie.Age == 1);
            Dog dalmation = new Dog("dalmation");
            Assert.IsTrue(dalmation.Age == 1);
        }

        [TestMethod]
        public void DualParameterConstructorThatTakesAgeAndBreed()
        {
            // Goal 1: Extend your Dog class to additionally support another constructor overload that takes both breed and age.
            // Goal 2: Your dog class must set its properties Age and Breed with these values during construction.
            // Contraints: You are not allowed to change this code, only extend the type you already created..
            Dog luna = new Dog("chihuahua", 7);
            Assert.IsTrue(luna.Breed == "chihuahua");
            Assert.IsTrue(luna.Age == 7);
        }

        [TestMethod]
        public void SpeakMethod()
        {
            // Goal 1: Extend your Dog class to support a method Named Speak(), which takes no arguments and returns "woof!" for dogs.
            // Goal 2: Extend your Dog class to support a method Named Speak() overloaded to take argument, the message you want your dog to speak, and returns that message.
            // Contraints: You are not allowed to change this code, only extend the type you already created.
            Dog airBud = new Dog("golden retriever", 2);
            Assert.IsTrue(airBud.Speak() == "woof!");
            Assert.IsTrue(airBud.Speak("hi!") == "hi!");
        }

        [TestMethod]
        public void SitMethod()
        {
            // Goal 1: Extend your Dog class to support a property named IsSitting, that relays the status of the Dog and indicates whether its sitting or not.
            // IsSitting should start out as False for dogs whos Sit Method has not been called.
            // Goal 2: Extend your Dog class to support a method Named Sit(), which takes no arguments, but internally changes the value IsSitting to True.
            // Contraints: You are not allowed to change this code, only extend the type you already created.
            Dog airBud = new Dog("golden retriever", 2);
            Assert.IsTrue(airBud.IsSitting == false);
            airBud.Sit();
            Assert.IsTrue(airBud.IsSitting == true);
        }

        [TestMethod]
        public void StandMethod()
        {
            // Goal 1: Extend your Dog class to support a method Named Stand(), which takes no arguments, but internally changes the value that
            // controls the property IsSitting. IsSitting should reflect if the dog is sitting or not, the methods Sit and Stand should control that.
            // Contraints: You are not allowed to change this code, only extend the type you already created.
            Dog airBud = new Dog("golden retriever", 2);
            Assert.IsTrue(airBud.IsSitting == false);
            airBud.Sit();
            Assert.IsTrue(airBud.IsSitting == true);
            airBud.Stand();
            Assert.IsTrue(airBud.IsSitting == false);
        }

        [TestMethod]
        public void CelebrateBirthday()
        {
            // Goal 1: Extend your Dog class to support a method Named CelebrateBirthday(), which takes no arguments, but interanally increases the age of the dog.
            // Contraints: You are not allowed to change this code, only extend the type you already created.
            Dog airBud = new Dog("golden retriever", 2);
            airBud.CelebrateBirthday();
            Assert.IsTrue(airBud.Age == 3);
            airBud.CelebrateBirthday();
            Assert.IsTrue(airBud.Age == 4);
        }


        [TestMethod]
        public void Encapsulation()
        {
            // Goal 1: Ammend your Dog class so that the property Age cannot be set externally by users of the class. Age can only be set in the constructor or increased through CelebrateBirthday.
            // Goal 2: Ammend your Dog class so that the property IsSitting cannot be set externally by users of the class. IsSitting can only be set in the constructor by calling Sit/Stand methods.
            // Goal 3: Ammend your Dog class so that the property Breed cannot be set externally by users of the class. Breed can only be set in the constructor when a dog is created.

            // Hint, you can make a property read only by removing its setter or privatizing it, depending on your design.
            // The goal of this is to remind you that controlling who can set your members is valueable.
            // Ill be grading this manually.

            Dog dog = new Dog();
            //dog.Breed = "not able to set"; // This should not compile
            //dog.IsSitting = false; // this should not compile
            //dog.Age = 123; // this should not compile
        }

        [TestMethod]
        public void InheritanceDog()
        {
            // Goal 1: Create a new class Called Animal in the file provided names Animal.cs
            // Goal 2: Add a Property to Animal named Species that tracks the animals species.
            // Goal 3: Make sure Species is set to the value of "unknown" for an animal instance in its constructor.
            // Goal 4: Ammend your dog class to inherit from Animal.
            // Goal 5: Ensure that when a dog instance is instantiated, it sets its parent class species to dog.
            // Contraints: You are not allowed to change this code, Create new types in their associated files.
            Animal unknown = new Animal();
            Assert.IsTrue(unknown.Species == "unknown");
            Dog dog = new Dog();
            Assert.IsTrue(dog is Animal);
            Animal parent = dog as Animal;
            Assert.IsTrue(parent.Species == "dog");
            Assert.IsTrue(parent != null);
        }

        [TestMethod]
        public void InheritanceCat()
        {
            // Goal 1: Create a new class Called Cat in the file provided named Cat.cs
            // Goal 2: Inherit Animal in Cat
            // Goal 3: Ensure that when a cat instance is instantiated, it sets its parent class species to cat.
            // Contraints: You are not allowed to change this code, Create new types in their associated files.
            Cat cat = new Cat();
            Assert.IsTrue(cat is Animal);
            Animal parentCat = cat as Animal;
            Assert.IsTrue(parentCat.Species == "cat");
            Assert.IsTrue(parentCat != null);
        }

        [TestMethod]
        public void PolyMorphism()
        {
            // Goal 1: Creat a virtual method names Speak in the Animal base class. It takes no parameters.
            // Goal 2: Make the base version of Animal return "What am I?"
            // Goal 3: Override the virtual speak method to create a special version for Dogs that returns "woof!", this shoudl replace the Speak method in dogs.
            // Goal 4: Override the virtual speak method to create a special version for Cats that returns "meow!"
            // Goal 5: Move all shared properties that make sense from Dog to its base class animal, so that cat can now have all the features of a dog.
            // Contraints: You are not allowed to change this code, edit types already created.
            Animal unknown = new Animal();
            Dog dog = new Dog();
            Cat cat = new Cat();

            Assert.IsTrue(dog.Speak() == "woof!");
            Assert.IsTrue(cat.Speak() == "meow!");
            Assert.IsTrue(unknown.Speak() == "What am I?");
        }

        [TestMethod]
        public void ReapingTheReward()
        {
            // Goal 1: Move Sit(), Stand(), IsSitting, Age, and CelebrateBirthday from Dog to its base class animal, so that all animals can now sit, stand and have birthday parties.
            // Contraints: You are not allowed to change this code, edit types already created.
            Cat cat = new Cat();
            Assert.IsTrue(cat.IsSitting == false);
            cat.Sit();
            Assert.IsTrue(cat.IsSitting == true);
            cat.Stand();
            Assert.IsTrue(cat.IsSitting == false);
            Assert.IsTrue(cat.Age == 1);
            cat.CelebrateBirthday();
            Assert.IsTrue(cat.Age == 2);
        }
    }
}
