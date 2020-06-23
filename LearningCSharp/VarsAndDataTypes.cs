using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace LearningCSharp
{
    public class VarsAndDataTypes
    {
        [Fact]
        public void SomeOfTheBuiltInTypes()
        {
            //Type Identifier;
            int age;
            age = 22;
            string name;
            name = "Shelby";
            decimal pay = 30.5M;
            bool isAwake = true;


            int x = 0;
            Assert.Equal(0, x);
            Assert.True(isAwake);
            Assert.Equal("Shelby", name);
            Assert.Equal(22, age);
        }
        string Thingy = "Chicken";
        [Fact]
        public void ImplicitTypedLocalVars() {
            //Started in C# 3.0
            //C# vars can never change data type
            Assert.Equal("Chicken", Thingy);


            var car = "Kia Soul";
        }
        [Fact]
        public void ValueTypes()
        {
            //structs
            int age = 22;
            DateTime myBday = new DateTime(1997, 9, 12);
            string myName = "Shelby";
            var DoggieOne = new Dog();
            DoggieOne.name = "Fido";
            RenameYourDog(DoggieOne);
        }

        public void RenameYourDog(Dog d) {
            d.name = "Moody";
        }
        public class Dog {
            public string name;
        }
        public void UsingRefAndOut() {
            int y = 50;
            DoubleItRef(ref y);
            Assert.Equal(100, y);

            int p;
            GimmeAValue(out p);
            Assert.Equal(5, p);
        }
        public void GimmeAValue(out int z) {
            z = 5;
        }
        public void DoubleItRef(ref int x) {
            x = x + x;
        }
        }
}
