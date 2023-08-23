using ReactiveUI;
using System.Reactive.Linq;
using System.Windows.Input;

namespace MusicStoreApp.ViewModels
{
    public class MainViewModel : ViewModelBase
    {
        public ICommand BuyMusicCommand { get; }
        public Interaction<MusicStoreViewModel, AlbumViewModel?> ShowDialog { get; }

        public MainViewModel() 
        {
            ShowDialog = new Interaction<MusicStoreViewModel, AlbumViewModel?>();
            
            BuyMusicCommand = ReactiveCommand.CreateFromTask(async() =>
            {
                var store = new MusicStoreViewModel();
                var result = await ShowDialog.Handle(store);
            });
        }
    }
}