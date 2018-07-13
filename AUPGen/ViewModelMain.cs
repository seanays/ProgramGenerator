using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using AUPGen.Annotations;

namespace AUPGen
{
    public class ViewModelMain: INotifyPropertyChanged
    {
        private string _outputString;

        public string OutputString
        {
            get => _outputString;
            set
            {
                if (value == _outputString) return;
                _outputString = value;
                OnPropertyChanged();
            }
        }

        public ViewModelMain()
        {
            OutputString = string.Empty;
        }
        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
