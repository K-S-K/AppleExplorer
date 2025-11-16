using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows.Input;

namespace AppleExplorer.Desktop.ViewModeles;
public partial class NodeViewModel : INotifyPropertyChanged
{
    public string Title { get; set; } = "";
    public int Level { get; set; }
    public bool IsExpanded { get; set; }
    public bool IsVisible
    {
        get => _isVisible;
        set
        {
            _isVisible = value;
            OnPropertyChanged(nameof(IsVisible));
        }
    }
    private bool _isVisible;
    public ICommand ToggleExpandCommand { get; }
    public ObservableCollection<NodeViewModel> Children { get; set; } = [];

    public NodeViewModel()
    {
        ToggleExpandCommand = new Command(ToggleExpand);
    }

    private void ToggleExpand()
    {
        IsExpanded = !IsExpanded;
        OnPropertyChanged(nameof(IsExpanded));

        // Set visibility of children based on IsExpanded of this node
        SetDescendantsVisibility(IsExpanded);
    }

    public void SetDescendantsVisibility(bool isVisible)
    {
        foreach (var child in Children)
        {
            child.IsVisible = isVisible;
            child.SetDescendantsVisibility(isVisible && child.IsExpanded);
        }
    }

    public event PropertyChangedEventHandler? PropertyChanged;
    protected void OnPropertyChanged(string propertyName) =>
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
}
