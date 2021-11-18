using Ejemplo4.Services;
using Ejemplo4.ViewModels;
using Ejemplo4.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace Ejemplo4.Commands.StudentCommands
{
    class GuardarEstudianteCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            StudentTableView vista = (StudentTableView) parameter;
            //Console.WriteLine(parameter.GetType());

            vista.txtWarning.Visibility = Visibility.Visible;
            if(studentTableViewModel.CurrentStudent.Nombre is null || studentTableViewModel.CurrentStudent.Nombre.Equals(""))
            {
                studentTableViewModel.TXWarning = "Escribe un nombre";
            }
            else if(vista.datePickerFecha.Text.Equals(""))
            {
                studentTableViewModel.TXWarning = "Debes poner una fecha";
            }
            else
            {
                studentTableViewModel.TXWarning = "";
                bool okGuardar = StudentDBHandler.EditStudent(studentTableViewModel.CurrentStudent);
                if (okGuardar)
                {
                    vista.E01MostrarEstudiante();
                }
            }

            
        }

        private StudentTableViewModel studentTableViewModel;

        public GuardarEstudianteCommand(StudentTableViewModel studentTableViewModel)
        {
            this.studentTableViewModel = studentTableViewModel;
        }
    }
}
