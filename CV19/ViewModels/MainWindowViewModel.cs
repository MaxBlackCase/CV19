using CV19.Infrastructure.Commands;
using CV19.ViewModels.Base;
using OxyPlot;
using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Input;

namespace CV19.ViewModels {

  internal class MainWindowViewModel : ViewModel{

    #region _TestDataPoint : TYPE - DESRIPTION

    /// <summary> Тестовый набор данных для визуализации графиков</summary>
    private IEnumerable<DataPoint> _TestDataPoint;

    /// <summary> Тестовый набор данных для визуализации графиков</summary>
    public IEnumerable<DataPoint> TestDataPoints {
      get => _TestDataPoint;
      set => Set( ref _TestDataPoint, value );
    }

    #endregion

    #region Заголовок окна

    private string _Title = "Анализ статистики";
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

    private void OnCloseApplicationCommandExecuted( object p ) {

      Application.Current.Shutdown();

    }
    private bool CanCloseApplicationCommandExecute( object p ) => true;

    #endregion

    #endregion


    /// <summary>
    /// Конструктор MainWindowViewModel
    /// </summary>
    public MainWindowViewModel() {

      #region Команды

      CloseApplicationCommand = new LambdaCommand( OnCloseApplicationCommandExecuted, CanCloseApplicationCommandExecute );

      #endregion

      var data_points = new List<DataPoint>( (int)(360 / 0.1) );
      for ( var x = 0d; x <= 360; x++ ) {


        const double to_rad = Math.PI / 100;
        var y = Math.Sin( x * to_rad );

        data_points.Add( new DataPoint {  } );

      }

    }


  }
}
