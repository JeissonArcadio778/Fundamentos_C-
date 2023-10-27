using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleGeneric
{
    internal class Program
    {
        static void Main(string[] args)
        {

            SaveObjects<string> matrizStrings = new SaveObjects<string>(3);

            matrizStrings.AgregateElements("Loquita");
            matrizStrings.AgregateElements("Eulajecutiva");
            matrizStrings.AgregateElements("Isabelove");

            string result = (string)matrizStrings.getElement(0);

            Console.WriteLine(result);


            SaveObjects<Student> matrizStudents = new SaveObjects<Student>(3);

            Student student1 = new Student(0.4);
            Student student2 = new Student(1.4);
            Student student3 = new Student(2.4);

            matrizStudents.AgregateElements(student3);
            matrizStudents.AgregateElements(student2);
            matrizStudents.AgregateElements(student1);

            Student result_student = (Student)matrizStudents.getElement(0);

            Console.WriteLine(result_student.Note);




        }

        class SaveObjects<T> //Se usará cualquier tipo de objetos, tanto valor como referencia. 
        {
            int i = 0;
            private T[] matrizElements;

            //Constructor
            public SaveObjects(int sizeMatriz)
            {
                matrizElements = new T[sizeMatriz];
            }

            //Methods

            public void AgregateElements(T elementPa)
            {

                matrizElements[i] = elementPa;
                i++;
            }

            public T getElement(int indexElement)
            {
                return matrizElements[(int)indexElement];
            }

        }

        class Student
        {

            private double note;

            public Student(double note)
            {
                this.note = note;
            }

            public double Note
            {
                get { return note; }
            }



        }
    }
}
