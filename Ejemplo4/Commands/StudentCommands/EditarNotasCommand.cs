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
    class EditarNotasCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            StudentTableView vista = (StudentTableView)parameter;
            MessageBoxResult resultado = MessageBox.Show("¿Deseas realizar los cambios?", "Modificar notas", MessageBoxButton.YesNo);

            switch(resultado)
            {
                case MessageBoxResult.Yes:
                    bool okEditar = StudentDBHandler.EditNotas(studentTableViewModel.CurrentStudent);
                    vista.E03MostrarNotas();
                    break;

                case MessageBoxResult.No:

                    break;
            }
        }



        public StudentTableViewModel studentTableViewModel;

        public EditarNotasCommand(StudentTableViewModel studentTableViewModel)
        {
            this.studentTableViewModel = studentTableViewModel;
        }
    }
}
