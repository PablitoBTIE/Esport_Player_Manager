using System.Collections.ObjectModel;
using Avalonia.Controls;

namespace Esport_Player_Manager.ViewModels;

public partial class MainWindowViewModel 
{

    public ObservableCollection<string> Options { get; } =
    [
       "pierwszy poziom",
       "drugi poziom",
       "trzeci poziom",
    ];
    
    public ObservableCollection<string> Options2 { get; } =
    [
        "pierwszy poziom",
        "drugi poziom",
        "trzeci poziom",
    ];
    
}