using System;
using System.Collections.Generic;
using System.Text;
using System.Reflection;

namespace RegexProgram
{
    class Reflections
    {
        /// <summary>
        /// RflectionTest method to get the matadata for the methods and constructors
        /// </summary>
        public static void ReflectionsTests()
        {
            Type type = typeof(Inputs);
            Console.WriteLine("Full Name : {0}",type.FullName);
            Console.WriteLine("Class Name : {0}",type.Name);

            MethodInfo[] methods = type.GetMethods();
            foreach(MethodInfo method in methods)
            {
                Console.WriteLine(method.ReturnType.Name +"  " + method.Name);
            }

            ConstructorInfo[] constructors = type.GetConstructors();
            foreach (ConstructorInfo constructor in constructors)
            {
                Console.WriteLine(constructor.ToString());
            }
        }
    }
}
