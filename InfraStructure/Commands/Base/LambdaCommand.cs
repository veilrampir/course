﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace course.InfraStructure.Commands.Base
{
    internal class LambdaCommand : Command
    {


        public LambdaCommand(Action<object> Execute, Func<object, bool> CanExecute = null)
        {
            _Execute = Execute ?? throw new ArgumentNullException(nameof(Execute));
            _CanExecute = CanExecute;
        }

        private readonly Action<object> _Execute;
        private readonly Func<object, bool> _CanExecute;

        public override bool CanExecute(object parameter) => _CanExecute?.Invoke(parameter) ?? true;
      

        public override void Execute(object parameter) => _Execute(parameter);
      
    }
}
