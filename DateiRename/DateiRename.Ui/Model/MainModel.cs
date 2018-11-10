using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateiRename.Ui.Model
{
    public class MainModel : ObservableObject
    {
        string _pfad;

        public string Pfad
        {
            get
            {
                return _pfad;
            }

            set
            {
                Set<string>(() => Pfad, ref _pfad, value);
            }
        }
        string _dateiEndung;

        public string DateiEndung
        {
            get
            {
                return _dateiEndung;
            }

            set
            {
                Set<string>(() => DateiEndung, ref _dateiEndung, value);
            }
        }
    }
}
