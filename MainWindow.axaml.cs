namespace AvaloniaLeanSample;

using System;
using System.Linq;
using System.Threading.Tasks;
using Avalonia;
using Avalonia.Controls.Primitives;
using Avalonia.Input;
using Avalonia.Controls;
using Avalonia.VisualTree;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        this.InitializeComponent();
        
        // this.WindowState = WindowState.FullScreen;
        // this.CanResize = false;
        // this.SystemDecorations = SystemDecorations.BorderOnly;
        // this.CanResize = true;
        // this.Topmost = false;
        
        // this.Opened += this.OnOpened;
        // this.Closed += this.OnClosed;
    }

    // private void OnOpened(object? sender, EventArgs e)
    // {
    //     try
    //     {
    //         // DesktopOverlayHelper.PlaceUnderDesktopLite(this);
    //         // DesktopOverlayHelper.PlaceUnderDesktop(this);
    //         // ClickThroughHelper.EnableLayered(this);
    //         // GlobalMouseTracker.Start(this, this.OnMouseMove);
    //     }
    //     catch (Exception err)
    //     {
    //         Console.Error.WriteLine("err: {0}", err);
    //     }
    // }

    // private void OnMouseMove(Point mousePoint)
    // {
    //     var hit = this.InputHitTest(mousePoint) as Visual;
    //     
    //     Console.WriteLine("hit: {0}", hit);
    //         
    //     var interactiveAncestor = (hit as Visual)
    //         ?.GetSelfAndVisualAncestors()
    //         .OfType<Control>()
    //         .FirstOrDefault(c => c.IsEffectivelyVisible && (c as TemplatedControl)?.Background != null);
    //     
    //     Console.WriteLine("interactiveAncestor: {0}", interactiveAncestor);
    //         
    //     var overInteractive = interactiveAncestor != null;
    //         
    //     ClickThroughHelper.SetTransparentFlag(this, !overInteractive);
    //     if (overInteractive && !this.IsActive)
    //     {
    //         this.Activate();
    //     }
    // }
    //
    // private void OnClosed(object? sender, EventArgs e)
    // {
    //     GlobalMouseTracker.Stop();
    //     
    //     Console.WriteLine("Destroying Window...");
    //     var handleInfo = this.TryGetPlatformHandle();
    //     if (handleInfo?.HandleDescriptor == "HWND")
    //     {
    //         _ = DesktopOverlayHelper.DestroyWindow(handleInfo.Handle);
    //     }
    // }
    
    // private void Window_PointerMoved(object? sender, PointerEventArgs e)
    // {
    //     Console.WriteLine("Mouse move: {0}", e);
    //     try
    //     {
    //         // Get the element under the mouse
    //         var hit = this.InputHitTest(e.GetPosition(this));
    //
    //         var interactiveAncestor = (hit as Visual)
    //             ?.GetSelfAndVisualAncestors()
    //             .OfType<Control>()
    //             .FirstOrDefault(c => c.IsEffectivelyVisible && (c as TemplatedControl)?.Background != null);
    //
    //         bool overInteractive = interactiveAncestor != null;
    //
    //         // You can refine this test to your specific interactive controls:
    //         // bool overInteractive = hit is not Window && (hit is not Panel panel || panel.Background is null);
    //
    //         Console.WriteLine("over: {0}", hit);
    //
    //         // If we're _not_ over an interactive element, make the window click-through.
    //         ClickThroughHelper.SetTransparentFlag(this, !overInteractive);
    //     }
    //     catch (Exception err)
    //     {
    //         Console.Error.WriteLine("Error: {0}", err);
    //     }
    // }
}