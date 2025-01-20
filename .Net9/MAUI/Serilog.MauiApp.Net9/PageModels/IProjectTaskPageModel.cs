using CommunityToolkit.Mvvm.Input;
using Serilog.MauiApp.Net9.Models;

namespace Serilog.MauiApp.Net9.PageModels
{
    public interface IProjectTaskPageModel
    {
        IAsyncRelayCommand<ProjectTask> NavigateToTaskCommand { get; }
        bool IsBusy { get; }
    }
}