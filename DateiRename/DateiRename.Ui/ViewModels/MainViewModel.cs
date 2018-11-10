using DateiRename;
using DateiRename.Ui.Model;
using GalaSoft.MvvmLight.CommandWpf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;

namespace DateiRename.Ui.ViewModels
{
    public class MainViewModel 
    {
        public MainViewModel()
        {
            InitCommands();
            InitModel();
        }

        public MainModel MainModel { get; set; }

        public ICommand SelectFolderCommand { get; set; }
        public ICommand RenamePhotosCommand { get; set; }

        private void InitModel()
        {
            MainModel = new MainModel();
            MainModel.Pfad = @"\\192.168.2.193\photo";
            MainModel.DateiEndung = "*.jpg";
        }

        private void InitCommands()
        {
            SelectFolderCommand = new RelayCommand(SelectFolder);
            RenamePhotosCommand = new RelayCommand(RenamePhotos);
        }

        private void RenamePhotos()
        {
            FileRenameCommandBuilder
                .Create()
                .Build()
                .Execute(MainModel.Pfad, MainModel.DateiEndung);
        }

        private void SelectFolder()
        {
            using (var fbd = new FolderBrowserDialog())
            {
                fbd.SelectedPath = MainModel.Pfad;
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    MainModel.Pfad = fbd.SelectedPath;
                }
            }
        }
    }
}
