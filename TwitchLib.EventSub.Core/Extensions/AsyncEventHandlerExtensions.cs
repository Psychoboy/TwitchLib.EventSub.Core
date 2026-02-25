using System.Threading.Tasks;

namespace TwitchLib.EventSub.Core.Extensions;

/// <summary>
/// Provides extension methods for invoking asynchronous event handlers safely.
/// </summary>
public static class AsyncEventHandlerExtensions
{
    /// <summary>
    /// Safely invokes an asynchronous event handler with the specified sender and event arguments.
    /// </summary>
    public static Task InvokeAsync<TEventArgs>(this AsyncEventHandler<TEventArgs>? asyncEventHandler, object? sender, TEventArgs e)
    {
        return asyncEventHandler != null ? asyncEventHandler(sender, e) : Task.CompletedTask;
    }

    /// <summary>
    /// Safely invokes an asynchronous event handler with the specified sender and standard <see cref="EventArgs"/>.
    /// </summary>
    public static Task InvokeAsync(this AsyncEventHandler? asyncEventHandler, object? sender, System.EventArgs e)
    {
        return asyncEventHandler != null ? asyncEventHandler(sender, e) : Task.CompletedTask;
    }
}
