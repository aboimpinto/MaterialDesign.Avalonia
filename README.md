# MaterialDesign.Avalonia
Convert the MaterialDesign WPF to Avalonia


# Last release 05.2022
* New icons added

# Usage

Add the nuget package to your project  
```Install-Package MaterialDesign.Avalonia.PackIcon ```

Include the Style in your code (Aspp.axaml for example)  
```<StyleInclude Source="avares://MaterialDesign.Avalonia.PackIcon/Assets/Generic.xaml" />```


In the Window/UserControl load the NameSpace  
```xmlns:material="clr-namespace:MaterialDesign.Avalonia.PackIcon;assembly=MaterialDesign.Avalonia.PackIcon"```

Use the control where you want to show a Material Icon  
```<material:PackIcon Kind="Dashboard" />```

Look here, https://fonts.google.com/icons for the list of icons available.   
If an icon is not available, please report.

