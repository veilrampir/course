using course.ViewModels.Base;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace course.ViewModels
{
    internal class MainWindowViewModel : VeiwModel
    {
        #region Заголовок окна

        private string _Title = "Анализ статистики CV19"; 
      public string Title
        {

            get => _Title;

            set
            {
                Set(ref _Title, value);
            }
        }
        #endregion

        #region Status : string Статус программы

        private string _Status = "Готов";
        public string Status
        {
            get => _Status;
            set => Set( ref _Status, value);
        }
        #endregion
    }
}
