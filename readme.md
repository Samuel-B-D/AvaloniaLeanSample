## Command to properly build:
```bash
dotnet publish -r win-x86 --self-contained=true -p:PublishReadyToRun=true -c Release
```

# Avalonia Lean Sample
This sample is intended to be a minimal base for building an Avalonia application with 
very low resource usage, both in term of CPU utilization and memory footprint.

### Goals:
- **Minimize memory (RAM) footprint**
- Minimize VRAM footprint
- Minimize CPU usage
- Minimize startup time<br>
  <br>
- ^ All of the above while maintaining Hardware-Accelerated Rendering (GPU)

### NON-goals:
- Lowering file size
  <br>*\*as long as it is not outrageous*
  <br>*\*\* .pdb size is irrelevant, as it doesn't need to be shipped to users 
      except for debugging purposes*

### Current footprint
![AvaloniaLeanSampleResourcesUsage.png](AvaloniaLeanSampleResourcesUsage.png)

## Why?
I am growing increasingly tired that more and more desktop applications are starting
to eat up more and more system resources. This is especially an issue for softwares
which are meant to be always running, such as RGB software, peripherals software (Razer,
Corsair, etc...), Discord, Steam...

Most of these applications these days are using Electron because it is much more easier
to make the kind of fancy UI they want to make than with traditional GUI toolkits
(including powerful layouting, animations...).
Having a platform-agnostic consistant visual is also another key point driving the
adoption of Electron for such apps.

In the past years, I've tried a lot of GUI frameworks in C/C++, C#, Rust... and I believe
that Avalonia is one of the framework with the best potential to fill this usecase, 
because it easily allow to make a unified visual design which renders exactly the same
on all platforms. It also turns out that it can be relatively lean on system resource
consumptions with just a few tweaks, which this template's goal is to illustrate.

## Contribution
If you have any suggestion to reduce the resource usage, feel free to suggest a 
change with a PR!