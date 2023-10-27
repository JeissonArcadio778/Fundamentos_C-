using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrices
{
    internal class Program
    {

        static void Main(string[] args)
        {

            //Variables de referencia. Es un objeto (instancia) de la clase Array. 

            //CREATE: tipo [] nombre = new tipo[tamaño];  
            string[] names = new string[] { "Loquita", "loquito" }; //Two elements. 

            double[] notes_ex = new double[4] { 9, 10, 2.7, 3 };

            double[] notes = new double[4];

            //Agregate in x position:
            notes[2] = 3.9;

            Console.WriteLine(notes[2]); // 3.9

            //Asignar un valor de la matriz: 
            double notesFinal;

            notesFinal = notes[2] - 1;

            Console.WriteLine(notesFinal); // 2.9


            //For with Matriz:
            double[] notes_for = new double[4];

            for (int i = 0; i < notes_ex.Length; i++)
            {
                Console.WriteLine("Give a note: ");

                double note = Convert.ToDouble(Console.ReadLine());

                notes_for[i] = note;

                Console.WriteLine("Note: {0}", notes_for[i]);

            }

            //Ejemplo: Matrices Unidimensionales.

            Console.WriteLine("Give the student number: ");

            int numberStudents = Convert.ToInt32(Console.ReadLine());

            double[] arrStudentsNotes = new double[numberStudents];


            for (int i = 0; i < arrStudentsNotes.Length; i++)
            {

                Console.Write("Give the calification to student number {0}: ", i);

                double note = Convert.ToDouble(Console.ReadLine());

                arrStudentsNotes[i] = note;

            }

            double sumNoteStudents = 0;

            for (int i = 0; i < arrStudentsNotes.Length; i++)
            {
                sumNoteStudents += arrStudentsNotes[i];
            }

            double averague = sumNoteStudents / arrStudentsNotes.Length;


            Console.WriteLine("The averague of student notes is: {0}", averague);

            Array.Sort(arrStudentsNotes);

            Console.WriteLine("The max note: {0} ", arrStudentsNotes[0]);

            Array.Reverse(arrStudentsNotes);

            Console.WriteLine("The min note: {0} ", arrStudentsNotes[0]);


            /* ESCALONADA */

            //Matriz Escalonada o Jagged. Es una matriz unidimensional con matrices unidimensionales en sus posiciones. 

            //Tipo [][] nombre = new tipo [filas][]

            //CREATE: conociendo sus valores. 
            double[][] sales = new double[][]
            {
                new double[] { 155, 100, 170 }, //0
                new double[] { 205, 120 }, //1
                new double[4] { 115, 190, 104, 130 }, //2
                new double[3] {163, 218, 125 } //2
            };

            //Declaracion matrices internas e inicialización: 
            //sales[0] = new double[] {155, 100, 170}; //size: 3
            //sales[1] = new double[] {205, 120}; //size: 2
            //sales[2] = new double[4] {115, 190, 104, 130};
            //sales[3] = new double[3] {163, 218, 125};

            Console.WriteLine(sales.Length); //4  
            Console.WriteLine(sales[0].Length); //3

            //Acceder a los elementos de la matriz escalonada. 

            Console.WriteLine(sales[1][0]); //205

            for (int i = 0; i < sales.Length; i++)
            {

                for (int j = 0; j < sales[i].Length; j++)
                {
                    Console.WriteLine(sales[i][j]);
                }


            }


  


            /* Programa calificaciones: este programa hace... */

            //Variables: 
            int numberClassrooms;
            double noteStudent;
            //double averague;
            double studentPerClassroom;

            double sumNoteStudent = 0;
            double sumStudents = 0;
            double noteMax = 0, //valor minimo
                noteMin = 10; //valor maximo

            do
            {
                Console.WriteLine("Give the number of classrooms: ");
                numberClassrooms = Convert.ToInt32(Console.ReadLine());

            } while (numberClassrooms == 0);

            double[][] arrStudentPerClassroom = new double[numberClassrooms][];

            //Save students per classroom
            for ( int i = 0; i < arrStudentPerClassroom.Length; i++ )
            {

                Console.WriteLine("Give the student number per classroom: {0}", i);

                numberStudents = Convert.ToInt32(Console.ReadLine());

                //For the average school. 
                sumStudents += numberStudents;

                arrStudentPerClassroom[i] = new double[numberStudents];

            }


            //Guardar calificaciones de cada salon y para cada estudiante:
            for ( int i = 0; i < arrStudentPerClassroom.Length; i++ )
            {

                Console.WriteLine("Salon Numero: {0}", i);

                for (int j = 0; j < arrStudentPerClassroom[i].Length; j++)
                {

                    Console.WriteLine("Calificación de estudiante {0} en el salón numero {1} ", j, i);

                    noteStudent = Convert.ToDouble(Console.ReadLine());

                    arrStudentPerClassroom[i][j] = noteStudent;

                    //Acumulacion de notas: 
                    sumNoteStudent += noteStudent;
                
                }

            }

            averague = sumNoteStudent / sumStudents;

            //Sacar máxima nota

            for (int i = 0; i < arrStudentPerClassroom.Length; i++)
            {

                for (int j = 0; j < arrStudentPerClassroom[i].Length; j++)
                {

                    if (arrStudentPerClassroom[i][j] > noteMax)
                    {
                        noteMax = arrStudentPerClassroom[i][j];
                    }

                }

            }

            for (int i = 0; i < arrStudentPerClassroom.Length; i++)
            {

                for (int j = 0; j < arrStudentPerClassroom[i].Length; j++)
                {

                    if (arrStudentPerClassroom[i][j] < noteMin)
                    {
                        noteMin = arrStudentPerClassroom[i][j];
                    }

                }

            }

            //Global
            Console.WriteLine("The averague of student notes is: {0}", averague);

            Console.WriteLine("The max note: {0} ", noteMax);

            Console.WriteLine("The min note: {0} ", noteMin);

            //Per classroom: 
            for (int i = 0; i < arrStudentPerClassroom.Length; i++)
            {

                Console.WriteLine("Classroom number {0}", i);

                sumNoteStudent = 0;
                studentPerClassroom = arrStudentPerClassroom[i].Length;

                noteMin = 10;
                noteMax = 0;

                for (int j = 0; i < arrStudentPerClassroom[i].Length; i++)
                {
                    //Notes:
                    noteStudent = arrStudentPerClassroom[i][j];
                    sumNoteStudent += noteStudent;

                    //Min
                    if (arrStudentPerClassroom[i][j] < noteMin)
                    {
                        noteMin = arrStudentPerClassroom[i][j];
                    }

                    //Max
                    if (arrStudentPerClassroom[i][j] > noteMax)
                    {
                        noteMax = arrStudentPerClassroom[i][j];
                    }

                }

                averague = sumNoteStudent / studentPerClassroom;

                Console.WriteLine("The averge in the Classroom {0} is {1}", i, averague);

                Console.WriteLine("The max note in the Classroom {0} is {1}", i, noteMax);

                Console.WriteLine("The min note in the Classroom {0} is {1}", i, noteMin);

                //Var y matriz como argumento
                var matrizAr = new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

                PrintArr(matrizAr); 

            }


        }

        static void PrintArr(int[] arrPa)
        {

            for (int i = 0; i < arrPa.Length; i++)
            {
                Console.WriteLine(arrPa[i]);

            }
        }

    }
}