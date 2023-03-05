using Avalonia.Media;
using MXDM.Models;
using SkiaSharp;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace MXDM.ViewModels;

public class MainWindowViewModel : ViewModelBase
{
	/// <summary>
	/// Objects wich will rander on the DataGrid
	/// </summary>
    public ObservableCollection<DownloadObj> DisplayedObjs { get; } = new();
    public ObservableCollection<CategoryItem> Items { get; } = new();
    public MainWindowViewModel()
    {
		Items.Add(new CategoryItem() { Icon= "CloudDownload", Title = "All Downloads", SubCategory = getDiffrent() });
		Items.Add(new CategoryItem() { Icon= "Alarm", Title = "UnFinshed", SubCategory = getDiffrent() });
		Items.Add(new CategoryItem() { Icon="Download", Title = "Finshed", SubCategory = getDiffrent() });
		Items.Add(new CategoryItem() { Icon="Queue", Title = "Queue", SubCategory=getDiffrentQueue()});
	}

	public List<CategoryItem> getDiffrent()
	{
		return new(){
		new(){Title = "compressed", Icon="FolderZip"},
		new(){Title = "Programs", Icon="Terminal"},
		new(){Title = "Video", Icon="Movie"},
		new(){Title = "Music", Icon="MusicNote"},
		};
	}

	public List<CategoryItem> getDiffrentQueue()
	{
		return new(){
		new(){Title = "Main Download Queue", Icon="ViewAgenda"},
		new(){Title = "Synchronization Queue", Icon="ViewList"},
		};
	}

}

public class CategoryItem
{
    public string Title { get; set; } = string.Empty;
    public string Icon { get; set; } = string.Empty;
	public Brush IconColor { get; set; } = new SolidColorBrush(Colors.Yellow);
    public string? Description { get; set; }

    public List<CategoryItem>? SubCategory { get; set; }

}

