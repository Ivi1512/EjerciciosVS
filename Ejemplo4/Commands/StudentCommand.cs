using Ejemplo4.Models;
using Ejemplo4.Services;
using Ejemplo4.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Ejemplo4.Commands
{
    class StudentCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            if(parameter is string)
            {
                string accion = parameter.ToString();

                if (accion.Equals("nuevo"))
                {
                    //studentViewModel.ListaEstudiantes.Add(studentViewModel.CurrentStudent);
                    //studentViewModel.CurrentStudent = new StudentModel();
                }
                else if (accion.Equals("cargarLista"))
                {
                    studentTableViewModel.ListaEstudiantes = StudentDBHandler.GetStudents();
                }
                else if (accion.Equals("editarHabilitado"))
                {
                    //studentTableViewModel.EditarActivado = true;
                    //studentTableViewModel.CambiarEstudiante = false;
                }
                else if(accion.Equals("EditarCalificaciones"))
                {
                    //studentTableViewModel.EditarCalificaciones = false;
                }
                else if (accion.Equals("cancelarEditar"))
                {
                    //studentTableViewModel.EditarActivado = false;
                    //studentTableViewModel.CurrentStudent = (StudentModel) studentTableViewModel.SelectedStudent.Clone();
                    //studentTableViewModel.CambiarEstudiante = true;
                }
                else if(accion.Equals("guardar"))
                {
                    bool okGuardar = StudentDBHandler.EditStudent(studentTableViewModel.CurrentStudent);
                    if(okGuardar)
                    {
                        //studentTableViewModel.EditarActivado = false;
                        //studentTableViewModel.SelectedStudent = (StudentModel)studentTableViewModel.CurrentStudent.Clone();
                        //studentTableViewModel.CambiarEstudiante = true;
                    }
                }
            }
            else
            {
                StudentModel student = (StudentModel) parameter;
                studentTableViewModel.CurrentStudent = (StudentModel) student.Clone();
                studentTableViewModel.SelectedStudent = (StudentModel)student.Clone();
            }

            
        }

        private StudentTableViewModel studentTableViewModel;
        public StudentCommand(StudentTableViewModel studentTableViewModel)
        {
            this.studentTableViewModel = studentTableViewModel;
        }

        private StudentViewModel studentViewModel;
        public StudentCommand(StudentViewModel studentViewModel)
        {
            this.studentViewModel = studentViewModel;
        }
    }
}
