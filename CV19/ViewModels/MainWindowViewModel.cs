using CV19.ViewModels.Base;

namespace CV19.ViewModels {

  internal class MainWindowViewModel : ViewModel {

    private string _Title = "Анализ статистики";

    #region Заголовок окна

    /// <summary>Заголовок окна</summary>
    public string Title {
      get => _Title;
      //if ( Equals( _Title, value ) )
      //  return;

      set => Set( ref _Title, value );
    }
    #endregion 

    #region Status : String - Статус программы

    private string _Status = "Готов!";

    public string Status { get => _Status; set => Set( ref _Status, value ); }

    #endregion

  }
}
