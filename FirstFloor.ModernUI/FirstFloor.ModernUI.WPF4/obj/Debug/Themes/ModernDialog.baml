   M S B A M L   `   `   `  ����N  JFirstFloor.ModernUI, Version=1.0.6.0, Culture=neutral, PublicKeyToken=null[2clr-namespace:FirstFloor.ModernUI.Windows.Controls$FirstFloor.ModernUI.Windows.Controls  5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089b ^Microsoft.Windows.Shell, Version=3.5.41019.1, Culture=neutral, PublicKeyToken=31bf3856ad364e35  �� MergedDictionaries �� Source7    1FirstFloor.ModernUI.Windows.Controls.ModernDialog �� 
TargetType �� Property   WindowBackgroundContent �� Value  DefaultFontFamily  DefaultFontSize  
WindowText&   System.Windows.Media.TextOptions �� 
TargetType  WindowBackground/  )Microsoft.Windows.Shell.SystemParameters2   Current �� Source �� Path  WindowBorder	    BackgroundContent 
 Accent

 �� Top �� Left � RowDefinitions � Title � DataContext   TextFormattingMode  ToUpperConverter �� 	ConverterF   @FirstFloor.ModernUI.Windows.Controls.TransitioningContentControl    Buttons �� Orientation  WindowBorderActive �� RelativeSource �� AncestorType  	 BooleanToVisibilityConverter*  $Microsoft.Windows.Shell.WindowChrome   CornerRadius   GlassFrameThickness   UseAeroCaptionButtons�� 5      D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    :x,http://schemas.microsoft.com/winfx/2006/xaml     5      ?controls2clr-namespace:FirstFloor.ModernUI.Windows.Controls  5      Kshell?http://schemas.microsoft.com/winfx/2006/xaml/presentation/shell  5        5      �� 5   
   $7 1/FirstFloor.ModernUI;component/Assets/Button.xaml?�6   �� 5   
   $; 5/FirstFloor.ModernUI;component/Assets/Converters.xaml?�6   %�  '         7  7 	 �� 5      "   6   .�5   
   ��  �@  BackgroundContent# �   6.   �� 5   
    � ��# �  6'   �� 5   
    � ��# �  6%   �� 5   
    � ��# �  6'   �� 5   
    � ��$	 640��6%   �� 5   
    � ��$	 640��6&   �� 5   
    � ��$	 240��6%   �� 5   
    � ��$	 240��6&   �� 5   
    �@�ShowInTaskbar .  6*   �� 5   
    �@�
ResizeMode$ NoResize=�6'   �� 5   
    �@�SizeToContent$ WidthAndHeight=�6*   �� 5   
    �@�UseLayoutRounding . 6.   �� 5   
    �@ TextFormattingMode$ Display=�6;   �� 5   
    � �� 5      �� 5      "   6"   .R�5      �� #���  6   ��6M   �� # Z $# WindowNonClientFrameThickness�._�5      � .+�5      �� #���  6%   $��1q�6R   ._�5    "   � .+�5"   &   �� #��z	 65   �� 5%   &   .+�5&   *   �� #���  64   $
 18��6T   $ 24��6d   $	��100��6u   $��6��6�   5'   '   � 5)   &   $��24q�6+    5*   *   �� 5+   .   $
��Auto �6<   �� 5,   .   $��* �6<   �� 5-   .   $
��Auto �6<   .+�51   *   �� # z 64   $��Segoe UI)�52   4   $��24(�53   4   $ Ideal=�54   4   $��CharacterEllipsis=�55   4   ��51   Z   �� 8   55   4     58   *   $��1��6O   $
��0,20q�6\   #��z��6j   �� 5;   *   $��2��67   #��z 6D   $��Right=�6l   ��5<   .   �� 5=   2   .R�5>   6   �� $ 
Horizontal=�6A   5?   3   5A   +   5C   '   5D   #   5E      �� 5F      #���  6%   $��1q�6X   y�6l   �� *
IsActive+ �� *FindAncestor+" �8  5G      5H      5I      5K      �� 5M   
    �@ WindowChrome 5N        5O      $ 0��6%   $ 1q�66    .  6N   5Q      5R      5T      