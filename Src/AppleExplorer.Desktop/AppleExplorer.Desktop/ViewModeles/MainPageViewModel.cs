using System;
using System.Text;
using System.ComponentModel;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace AppleExplorer.Desktop.ViewModeles;

public partial class MainPageViewModel : INotifyPropertyChanged
{
    public ObservableCollection<NodeViewModel> VisibleNodes { get; set; } = [];

    public ObservableCollection<NodeViewModel> AllNodes
    {
        get
        {
            ObservableCollection<NodeViewModel> allNodes = [];
            foreach (var node in VisibleNodes)
            {
                allNodes.Add(node);
                MainPageViewModel.AddChildrenRecursively(node, allNodes);
            }
            return allNodes;
        }
    }

    public MainPageViewModel()
    {
        var node1 = new NodeViewModel
        {
            Title = "Node 1",
            Level = 0,
            IsExpanded = false,
            IsVisible = true
        };
        node1.Children.Add(new NodeViewModel { Title = "Node 1.1", Level = 1, IsExpanded = false });
        node1.Children.Add(new NodeViewModel { Title = "Node 1.2", Level = 1, IsExpanded = false });

        var node2 = new NodeViewModel
        {
            Title = "Node 2",
            Level = 0,
            IsExpanded = false,
            IsVisible = true
        };

        var node21 = new NodeViewModel
        {
            Title = "Node 2.1",
            Level = 1,
            IsExpanded = false
        };
        node21.Children.Add(new NodeViewModel { Title = "Node 2.1.1 with long name", Level = 2, IsExpanded = false });
        node21.Children.Add(new NodeViewModel { Title = "Node 2.1.2", Level = 2, IsExpanded = false });
        node2.Children.Add(node21);

        VisibleNodes.Add(node1);
        VisibleNodes.Add(node2);
    }

    private static void AddChildrenRecursively(NodeViewModel node, ObservableCollection<NodeViewModel> allNodes)
    {
        foreach (var child in node.Children)
        {
            allNodes.Add(child);
            MainPageViewModel.AddChildrenRecursively(child, allNodes);
        }
    }

    public event PropertyChangedEventHandler? PropertyChanged;
    protected void OnPropertyChanged(string propertyName) =>
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
}
