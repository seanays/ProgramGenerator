using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AUPGen
{
    public class DefaultProgram
    {
        public ObservableCollection<IDeclaration> GlobalDeclarations { get; private set; }
        public ObservableCollection<IFunctionDeclaration> FunctionDeclarationss { get; private set; }

        public string GetOutput()
        {
            return null;
        }
    }
}
