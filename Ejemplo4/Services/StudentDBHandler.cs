using Ejemplo4.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo4.Services
{
    public class StudentDBHandler
    {
        public static ObservableCollection<StudentModel> studentList { get; set; }
        public static ObservableCollection<StudentModel> GetStudents()
        {
            studentList = new ObservableCollection<StudentModel>();
            var random = new Random();

            for (int i = 0; i < 40; i++)
            {
                StudentModel student = new StudentModel();
                student._id = i.ToString();
                student.Nombre = "Estudiante " + i.ToString();
                student.Curso = "Primero";
                student.Fecha = DateTime.Today;

                student.Notas.DI = random.Next(1,10).ToString();
                student.Notas.PSP = random.Next(1, 10).ToString();
                student.Notas.AD = random.Next(1, 10).ToString();
                student.Notas.PMDM = random.Next(1, 10).ToString();
                student.Notas.EIE = random.Next(1, 10).ToString();
                student.Notas.SGE = random.Next(1, 10).ToString();

                studentList.Add(student);
            }

            return studentList;
        }

        public static bool EditStudent(StudentModel student)
        {
            bool okEdit = false;
            foreach(StudentModel s in studentList)
            {
                if(s._id.Equals(student._id))
                {
                    s.Nombre = student.Nombre;
                    s.Fecha = student.Fecha;
                    s.Curso = student.Curso;
                    okEdit = true;
                }
            }

            return okEdit;
        }
    }
}
