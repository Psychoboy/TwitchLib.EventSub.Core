using System.Threading.Tasks;

namespace TwitchLib.EventSub.Core;

/// <summary>
/// Custom implementation of asynchronous event handler
/// This is useful to properly and safely handle async Tasks 
/// Reference: https://medium.com/@a.lyskawa/the-hitchhiker-guide-to-asynchronous-events-in-c-e9840109fb53
/// </summary>
public delegate Task AsyncEventHandler<in TEventArgs>(object? sender, TEventArgs e);

/// <summary>
/// Custom implementation of asynchronous event handler
/// This is useful to properly and safely handle async Tasks 
/// Reference: https://medium.com/@a.lyskawa/the-hitchhiker-guide-to-asynchronous-events-in-c-e9840109fb53
/// </summary>
public delegate Task AsyncEventHandler(object? sender, System.EventArgs e);
