   M S B A M L   `   `   `  ���� N  JFirstFloor.ModernUI, Version=1.0.6.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:FirstFloor.ModernUIFirstFloor.ModernUI  [2clr-namespace:FirstFloor.ModernUI.Windows.Controls$FirstFloor.ModernUI.Windows.Controls  _4clr-namespace:FirstFloor.ModernUI.Windows.Navigation&FirstFloor.ModernUI.Windows.Navigation  \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089  �� MergedDictionaries �� Source7    1FirstFloor.ModernUI.Windows.Controls.ModernWindow �� 
TargetType �� Property   WindowBackgroundContent �� Value  DefaultFontFamily  DefaultFontSize  
WindowText  WindowBorder&   System.Windows.Media.TextOptions �� 
TargetType ��Name%  System.Windows.SystemParameters$   WindowNonClientFrameThickness �� Source  WindowBackgroundColor	 �� Color
 � 	Resources  Key �� 
TargetName �� TargetProperty	 �� To g� Duration �Name � RowDefinitions    BackgroundContent � ColumnDefinitions � Title  ModernWindowTitle    IsTitleVisible � DataContext   BooleanToVisibilityConverter �� 	Converter    
TitleLinks'  !System.Windows.Shell.WindowChrome   IsHitTestVisibleInChrome �� Orientation ��Name	 �� X1	 �� Y1	 �� X2	 �� Y2 	 SeparatorBackground 
 SystemButtonLink �� ElementName  �� Triggers! �� Binding" �� RelativeSource# �� Value$ �� 
TargetName 
 Accent%    LogoData  NullToVisibilityConverter& �� ConverterParameter' �� Stretch#   FirstFloor.ModernUI.Resources(   Minimize) � ToolTip  SystemButton#  System.Windows.SystemCommands*   MinimizeWindowCommand+ �� Mode, �� AncestorType- ��Name.   Restore/   RestoreWindowCommand0 � UseLayoutRounding1   Maximize2   MaximizeWindowCommand3   Close  SystemCloseButton4   CloseWindowCommand7   1FirstFloor.ModernUI.Windows.Controls.ModernButton5   EllipseDiameter6   	IconWidth7   
IconHeight8   IconData9   Back5   /FirstFloor.ModernUI.Windows.Controls.ModernMenu:    MenuLinkGroups;   
LinkGroups<   SelectedSource= �� Mode6   0FirstFloor.ModernUI.Windows.Controls.ModernFrame>  Name?    ContentLoader@   ContentLoaderA   SourceB   ResizeGripDirectionC �� TriggersD P� PropertyE P� Value  WindowBorderActiveF ]� 
ConditionsG �� PropertyH �� ValueI   CornerRadiusJ   GlassFrameThicknessK   UseAeroCaptionButtonsL   NonClientFrameEdges�� D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    :x,http://schemas.microsoft.com/winfx/2006/xaml     .modernui!clr-namespace:FirstFloor.ModernUI  ?controls2clr-namespace:FirstFloor.ModernUI.Windows.Controls  C
navigation4clr-namespace:FirstFloor.ModernUI.Windows.Navigation    �� $7 1/FirstFloor.ModernUI;component/Assets/Button.xaml?��� $; 5/FirstFloor.ModernUI;component/Assets/Converters.xaml?��� $: 4/FirstFloor.ModernUI;component/Assets/TextBlock.xaml?�%�  '         7  7  7 
 7  7  7  7  7  �� "   .���  �@  BackgroundContent# �   ��  � ��# �  ��  � ��# �  ��  � ��# �  ��  � ��# �  ��  � ��$	 800����  � ��$	 640����  � ��$	 320����  � ��$	 320����  �@�
ResizeMode$ CanResizeWithGrip=���  �@�UseLayoutRounding . ��  �@ TextFormattingMode$ Display=���  � �� �� "   .R��� $ WindowBorder������ # Z ���� WindowBorderBackground��#	 �  
 ���� BackgroundAnimation .���� $ WindowBorderBackground��$ Color�# �  $ 0:0:.6D�._��� #��z��$��1q�._��� .u�� $ 
LayoutRoot�� �� $��36 ��� $
��Auto ��� $��* �.+��� $��5��#��z �  �� $��* ��� $
��Auto ��� $
��Auto ��� $��96 �.+��� #��z $	��8,0q�$��Center=�8��  # z y��� 8  �� $��1��#��z $��0,0,24,0q� . ���� .R��� $ 
Horizontal=����� .R��� $ 
Horizontal=�.+��� $ 	Separator��$ .5��$ 3��$ .5��$ 12��$	��5,0q�$��Center=�#��� 	 �� $*��$navigation:LinkCommands.NavigateLink��8�� ���� *DisplayName+���� *Source+���� $ ContentFrame��  �� ! �� " �� *PreviousData+# Z� .a��� $$ 	Separator�� � y�$ 	Collapsed=��� $��2��#���  $��36��$��36��$	��8,0q�# z% y��� 8  $& inverse��._�F� $
' Fill=�
�������$��24��$��24��$��Center=�$��Center=����� �� $��3��$ 
Horizontal=�$	��Top=� . .+��� #) Z( 8�� ���� # Z* ��� $��13��$��12��$z�1,0,0,1,0,1W�.+�F� ����    ��[ � z ��[ 	$��8��$��7��$��Center=�$��Center=�$��2������ *
Foreground+" �� $+ FindAncestor=�$, ButtonL�� $��1,0,1,0q�.+��� $- Restore��#) Z. 8�� $y�	Collapsed=����� # Z/ ��� $��13��$��12��0 . $z�1,0,0,1,.5,.5W�.+�F� X���Ѐ�     � z     � z ��[ �    ��- р�[ ��- �    �� р�[ �� р�[  z �     z 	$��8��$��8��$��Center=�$��Center=�$��1������ *
Foreground+" �� $+ FindAncestor=�$, ButtonL��� $- Maximize��#) Z1 8�� ���� # Z2 ��� $��13��$��12��.+�F� +����    @B �@T� @B �@T�  z �     z 	$��9��$��8��$��Center=�$��Center=�$��2������ *
Foreground+" �� $+ FindAncestor=�$, ButtonL��� #) Z3 8�� ���� # Z4 ��� $��13��$��12��$z�1,0,0,1,0,1W�.+�F� +����        � z ��j � z     �    ��j 	$��8��$��7��$��Center=�$��Center=�$	��1.5������ *
Foreground+" �� $+ FindAncestor=�$, ButtonL�� $��1�� �� $��42 ��� $��* �.+�  $��8,10,0,0q�$
��Left=�$	��Top=�$5 24Q�$6 12Q�$7 12Q�a8 ��@����O�@������p\-�������@��� �8@����ا  6n� �8��� ������� �p\-��O�@����O$#��NavigationCommands.BrowseBack��#) Z9  . ���� $ ContentFrame��  $��1��#; z: < �� *Source+$ ContentFrame��$= TwoWay=�  $> ContentFrame��$��3��$��2��$��
42,8,16,16q�#@ z? A �� *ContentSource+" �� *TemplatedParent+$= TwoWay=�� $ 
ResizeGrip��$��2��
������ $y�	Collapsed=�$��Right=�$��Bottom=�$B BottomRight=�.+�F� $��12��$��12��$��1q�#���  $��1��$
' None=������@B ��� ���- ��� �@KL ��� ���j ��� �@T� ��� ��ا ��� Ѐ� @T� р� �ا Ѐ�[ @T� р�[ �ا Ѐ�� @T� р�� �ا �@KL ��[ ���j ��[ �@T� ��[ ��ا ��[ Ѐ�[ @KL р�[ ��j Ѐ�� @KL р�� ��j �@T� �� ��ا �� Ѐ�� @B р�� ��- C P� D �@�IsActiveE . . ��� # �   � ��P� D �@�WindowState$E 	Maximized=�. ��� $$ Maximize�� � y�$ 	Collapsed=��� $$ Restore�� � y�$ Visible=��� $$ 
LayoutRoot�� � ��$ 7q�P� D �@�WindowState$E Normal=�. ��� $$ Maximize�� � y�$ Visible=��� $$ Restore�� � y�$ 	Collapsed=�]� F �� G �@�
ResizeMode$H CanResizeWithGrip=��� G �@�WindowState$H Normal=�./��� $$ 
ResizeGrip�� � y�$ Visible=���  �@ WindowChrome   $I 0��$J 1q�K .  $
L None=�