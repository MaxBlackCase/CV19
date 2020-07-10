using CV19.Infrastructure.Commands;
using CV19.ViewModels.Base;
using System.Windows;
using System.Windows.Input;

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

    #region Команды


    #region CloseApplicationCommand
    public ICommand CloseApplicationCommand { get; }

    private void OnCloseApplicationCommandExecuted( object p) {

      Application.Current.Shutdown();

    }
    private bool CanCloseApplicationCommandExecute( object p ) => true;

    #endregion

    #endregion


    /// <summary>
    /// Конструктор MainWindowViewModel
    /// </summary>
    public MainWindowViewModel() =>

    #region Команды

      CloseApplicationCommand = new LambdaCommand( OnCloseApplicationCommandExecuted, CanCloseApplicationCommandExecute );
    #endregion


  }
}
