   M S B A M L   `   `   `  ����C  ?XjHealth, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:XjHealth.libXjHealth.lib  5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089   brushMainWindow  � Offset � Color  brushMainWindowText �� Color  brushChromeReplacement  brushSettingsPanel  brushSettingsText  brushSettingsHeaderText  brushOuterBorder  brushInnerBorder  brushTargetButton 	 brushTargetButtonText 
 brushResetButton  brushResetButtonText  brushResetButtonGlow  brushToggleButton  brushToggleButtonText  brushToggleButtonGlow  TextBlockStateStyle �� 
TargetType �� Property �� Value �� Triggers P� Property P� Value	 �� 
StartPoint
 �� EndPoint  RedTextBlockStateStyle �� DataType    XjHealth.lib.Song � ToolTip � ColumnDefinitions � RowDefinitions � Orientation ��Name �� Triggers �� 
TargetName N� EnterActions	 W� To g� 	BeginTime g� Duration �� 
TargetName �� TargetProperty N� ExitActions �� 
TargetType ��Name �� Triggers	 �� To ! SettingsPanelOuterBorderStyle ! SettingsPanelInnerBorderStyle  SettingsHeaderTextStyle  DemoAreaBackgroundStyle  ScrollBarThumb �� RadiusX �� RadiusY ! HorizontalScrollBarPageButton  VerticalScrollBarPageButton  for_scrollbar  �Name! J� SnapsToDevicePixels" ]�Name# J� IsMouseOver$ ]� DecreaseRepeatButton% �� PageUpCommand& ]� IncreaseRepeatButton' �� PageDownCommand( ]� Thumb) �� PageLeftCommand* �� PageRightCommand+ � Cursor, ��Name- �� ScrollableHeight. � Maximum/ �� Orientation0 �� ViewportHeight1 �� ViewportSize2 �� VerticalOffset3 � Value*4 �� #ComputedVerticalScrollBarVisibility5 �� ScrollableWidth6 �� HorizontalOffset7 �� ViewportWidth,8 �� %ComputedHorizontalScrollBarVisibility9 :� RoutedEvent: :� 
SourceName�� 5      F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     :x,http://schemas.microsoft.com/winfx/2006/xaml     5       cclr-namespace:XjHealth.lib  5      %,6  &	        &	 �     &	 �     &	 �     &	     &	 <    &	 b    &	 �    &	 �    &		 �    &	
 �    &	 	    &	 /    &	 R    &	 u    &	 �    &	 �    &	 �    (�� �    5N      *,  +)'�� Y    '�� �    &	 _    7  7  7  &	 <    7  &	 �    7  &	 C     7  &	 j!    &	 �"    &	 -$    &	 �%    7  7  7  7  7  7  '�� +    7  7  �� 5      .��5   
   � $  0Q�6   $ 	SteelBlue��6"   � 5   
   $	  0.5Q�6   $ LightSteelBlue��6$   � 5	   
   $  1Q�6   $ 	SteelBlue��6"   5
      �� 5      $ AntiqueWhite��62   �� 5      $ White��65   �� 5      $ 	SteelBlue��61   �� 5      $ 	LightBlue��60   �� 5      $ AntiqueWhite��66   �� 5      $ 	#66FFFFFF��6/   �� 5      $ 	#66000000��6/   �� 5      $ Black��60   �� 5      $ Ivory��64   �� 5      $ 	#440000FF��6/   �� 5      $ AntiqueWhite��63   �� 5      $ 	AliceBlue��63   �� 5      $ 	#88468284��60   �� 5      $ AntiqueWhite��64   �� 5      $ 	AliceBlue��64   �� 5      " ��6(   .�5    
   ��  � ��$ Webdings)�6'   �� 5!   
    � ��$
 Bold"�6'   �� 5"   
    � ��$ 12(�6%   �� 5#   
    � �� �	#FFAAAAAA6'    5$   
   P� 5%       �@J�IsMouseOver . . �5&      ��  � �� �	#FFFFFFFF6/   �� 5'       � �� 5(      �� 5)      $	 0.5,0&�6.   $
 0.5,1&�6A   ��5+   "   � � 5,   &   $ #AAAAAA��63   $  0Q�6C   � 5-   &   $ 	#00000000��63   $  1Q�6E   5.   #   50      52      53      55      �� 56      " ��6+   .�57   
   ��  � ��$ Webdings)�6'   �� 58   
    � ��$
 Bold"�6'   �� 59   
    � ��$ 12(�6%   �� 5:   
    � �� �	#FFAAAAAA6'    5;   
   P� 5<       �@J�IsMouseOver . . �5=      ��  � �� �	#FFFFFFFF6/   �� 5>       � �� 5?      �� 5@      $	 0.5,0&�6.   $
 0.5,1&�6A   ��5B   "   � � 5C   &   $	 Red��63   $  0Q�6?   � 5D   &   $ 	#00000000��63   $  1Q�6E   5E   #   5G      5I      5J      5L      �� 5N      "   6   .R�5O      � $��Stretch=�6    5P      � 5Q       5R      �� 5S      $	��100 �6+   �� 5T      $��* �6+    5V      �� 5W      $��20 �6(   �� 5X      $��20 �6(   �� 5Y      $��20 �6(   �� 5Z      $��20 �6(   �� 5[      $��20 �6(   .+�5]      �� $��0��6   $��5��6,   $	��2,4q�6=   $	��100��6J   $	��100��6Z   ��6i   �� *Pic+� 5^      $ 
Horizontal=�6    $��1��69   $��0��6I   .+�5_      �� $��	标题：��6%   $��2q�60   �� 5`      $��2q�6%   ��60   �� *Name+5a      � 5b      $ 
Horizontal=�6    $��1��69   $��1��6I   .+�5c      �� $��2q�6$   $��	演唱：��6/   �� 5d      $��2q�6$   ��6/   �� *Author+5e      � 5f      $ 
Horizontal=�6    $��1��69   $��2��6I   .+�5g      �� $��2q�6$   $��	专辑：��6/   �� 5h      $��2q�6$   ��6/   �� *Album+5i      � 5j      $ 
Horizontal=�6    $��1��69   $��3��6I   .+�5k      �� $��2q�6$   $��	时长：��6/   �� 5l      $��2q�6$   ��6/   �� *
Duration+5m      � 5n      $ 
Horizontal=�6    $��1��69   $��4��6I   .+�5o      �� $��2q�6$   $��	大小：��6/   �� 5p      $��2q�6$   ��6/   �� *Size+5q      5r      .+�5u      �� $��24��6   $��Center=�6%   $��10,0,0,0q�6A   $	��♠��6S   �� 5v      $ title��6   $��24��6(   $��Center=�64   $��30,0,0,0q�6P   ��6b   �� *Name+�� 5w      $ duration��6   $��24��6*   $��Right=�66   $��0,0,10,0q�6S   $��Center=�6e   ��6�   �� *
Duration+5x       5z   
   P� 5{       � ��$ 68��6(   . �5|      �� $ title��6    � ��$ 24��6>   �� 5}      $ duration��6    � ��$ 24��6A    5~      �� 5      .��5�      �� .��5�      W� $ 1X�6.   $ 0:0:0.1X�65   $ 0:0:0.1D�6I   $	 pic��6\   $ Opacity�6x   W� 5�      $ 64X�6.   $ 0:0:0.1X�66   $ 0:0:0.1D�6J   $	 pic��6]   $ 	MaxHeight�6y   W� 5�      $ 64X�6.   $ 0:0:0.1X�66   $ 0:0:0.1D�6J   $	 pic��6]   $ MaxWidth�6y   W� 5�      $	 0.4X�6.   $ 0:0:0.1X�67   $ 0:0:0.1D�6K   $ title��6^   $ Opacity�6|   5�      5�       5�      �� 5�      .��5�      �� .��5�      W� $ 0:0:0.4X�6.   $ 0:0:0.1D�6B   $	 pic��6U   $ Opacity�6q   W� 5�      $ 0:0:0.3X�6.   $ 0:0:0.1D�6B   $	 pic��6U   $ 	MaxHeight�6q   W� 5�      $ 0:0:0.3X�6.   $ 0:0:0.1D�6B   $	 pic��6U   $ MaxWidth�6q   W� 5�      $ 0:0:0.4X�6.   $ 0:0:0.1D�6B   $ title��6U   $ Opacity�6s   5�      5�      5�      5�      �� 5�      " ��6   .�5�   
   ��  � �� �#4B54636(   �� 5�   
    � ��$ 1q�6,   �� 5�   
    � �� �#1111116'   �� 5�   
    � ��$ Hidden=�6G   �� 5�   
    � ��$
 Auto=�6E   �� 5�   
    � �� . 6:   �� 5�   
    � ��$ Center=�65   5�      �� 5�      " ��6   .�5�   
   ��  � �� �#B5BABF6'   �� 5�   
    �@�OverridesDefaultStyle . 62   �� 5�   
    � ��$ 28��6#   �� 5�   
    � �� 5�      �� 5�      " ��6"   .R�5�      �� $
��back��6   ���#111111$��0,0,0,1q�6?   ��5�      �� 5�      $	 0.5,0&�62   $
 0.5,1&�6E   ��5�   &   � � 5�   *   $ #222222��67   $  0Q�6G   � 5�   *   $ #222222��67   $  1Q�6G   5�   '   5�      ._�5�      �� $ content��6+   $��28��6<   $��2q�6H   $��Stretch=�6S   5�       5�      P� 5�       �@��
IsSelected .  5�      �� 5�   "   .��5�   &   �� .��5�   *   �� $ #F3C37CX�69   $ 0:0:0.2D�6F   $
 back��6Y   $2 ,(Border.BorderBrush).(SolidColorBrush.Color)�6v   �� 5�   *   $ #952B00X�69   $ 0:0:0.2D�6F   $6 0(ListBoxItem.Foreground).(SolidColorBrush.Color)�6Y   �� 5�   *   $
 #FFFX�69   $ 0:0:0.2D�6C   $
 back��6V   $U O(Border.Background).(LinearGradientBrush.GradientStops)[0].(GradientStop.Color)�6s   �� 5�   *   $ #FFEF99X�69   $ 0:0:0.2D�6F   $
 back��6Y   $U O(Border.Background).(LinearGradientBrush.GradientStops)[1].(GradientStop.Color)�6v   5�   '   5�   #    5�      �� 5�   "   .��5�   &   �� .��5�   *   �� $ 0:0:0.2D�69   $
 back��6L   $2 ,(Border.BorderBrush).(SolidColorBrush.Color)�6i   �� 5�   *   $ 0:0:0.2D�69   $6 0(ListBoxItem.Foreground).(SolidColorBrush.Color)�6L   �� 5�   *   $ 0:0:0.2D�69   $
 back��6L   $U O(Border.Background).(LinearGradientBrush.GradientStops)[0].(GradientStop.Color)�6i   �� 5�   *   $ 0:0:0.2D�69   $
 back��6L   $U O(Border.Background).(LinearGradientBrush.GradientStops)[1].(GradientStop.Color)�6i   5�   '   5�   #   5�      P� 5�       �@J�IsMouseOver .  5�      �� 5�   "   .��5�   &   �� .��5�   *   �� $ #D8E6F5X�69   $ 0:0:0.2D�6F   $
 back��6Y   $2 ,(Border.BorderBrush).(SolidColorBrush.Color)�6v   �� 5�   *   $ #617A98X�69   $ 0:0:0.2D�6F   $6 0(ListBoxItem.Foreground).(SolidColorBrush.Color)�6Y   �� 5�   *   $ #F6F9FDX�69   $ 0:0:0.2D�6F   $
 back��6Y   $U O(Border.Background).(LinearGradientBrush.GradientStops)[0].(GradientStop.Color)�6v   �� 5�   *   $ #E0EBF7X�69   $ 0:0:0.2D�6F   $
 back��6Y   $U O(Border.Background).(LinearGradientBrush.GradientStops)[1].(GradientStop.Color)�6v   5�   '   5�   #    5�      �� 5�   "   .��5�   &   �� .��5�   *   �� $ 0:0:0.2D�69   $
 back��6L   $2 ,(Border.BorderBrush).(SolidColorBrush.Color)�6i   �� 5�   *   $ 0:0:0.2D�69   $6 0(ListBoxItem.Foreground).(SolidColorBrush.Color)�6L   �� 5�   *   $ 0:0:0.2D�69   $
 back��6L   $U O(Border.Background).(LinearGradientBrush.GradientStops)[0].(GradientStop.Color)�6i   �� 5�   *   $ 0:0:0.2D�69   $
 back��6L   $U O(Border.Background).(LinearGradientBrush.GradientStops)[1].(GradientStop.Color)�6i   5�   '   5�   #   5�      5�      5�      5�      �� 5�      " ��62   .�5�   
   ��  � ��8   6'   �� 5�   
    � ��8  63   �� 5�   
    �@��CornerRadius$ 8��6)   �� 5�   
    � ��8  6(   �� 5�   
    � ��$ 0,0,2,2q�6,   5�      �� 5�      " ��62   .�5�   
   ��  �@��CornerRadius$ 8��6)   �� 5�   
    � ��8   6(   �� 5�   
    � ��$ 1,1,0,0q�6,   5�      �� 5�      " ��6,   .�5�   
   ��  � ��8   6'   �� 5�   
    � ��$
 Bold"�6'   5�      �� 5�      " ��6,   .�5�   
   ��  � ��8   6!   �� 5�   
    �@J�OpacityMask 5�      
� 5�      .��5�      � $ 	#FF000000��6#   $  0Q�65   � 5      $ 	#AA000000��6#   $  .6Q�65   � 5     $ 	#00FFFFFF��6#   $  1Q�65   5     5     5     �� 5     " n�5     .�5	  
   ��  �@�OverridesDefaultStyle . 5
     �� 5  
    � �� .  5     �� 5  
    � �� 5     �� 5     " n�6"   .R�5     � .+�5     �� ���#888$ 5��5     $ 5��5     5     5     5     5     �� 5     " ��5     .�5  
   ��  �@�OverridesDefaultStyle . 5     �� 5  
    � ��
 ���� 5     �� 5   
    � |� .  5!     �� 5"  
    � �� .  5#     �� 5$  
    �@J�Opacity$ 0Q�5%     �� 5&  
    � �� 5'     �� 5(     " ��6"   .R�5)     �� #��z��6    #��z��5*      #��z��5+      5,     5.     5/     �� 50     " ��51     .�52  
   ��  �@�OverridesDefaultStyle . 53     �� 54  
    � ��
 ���� 55     �� 56  
    � |� .  57     �� 58  
    � �� .  59     �� 5:  
    �@J�Opacity$ 1Q�5;     �� 5<  
    � �� 5=     �� 5>     " ��6"   .R�5?     �� #��z��6    #��z��5@      #��z��5A      5B     5D     5E     �� 5F     " ��5G     .�5H  
   ��  �@��IsPressAndHoldEnabled .  5I     �� 5J  
    �@��IsFlicksEnabled .  5K     �� 5L  
    � �� �#4445M     �� 5N  
    � ��$ 1q�5O     �� 5P  
    � ��$ 10��5Q     �� 5R  
    � ��$ 10��5S     �� 5T  
    �@J�Opacity$	 0.3Q�5U     �� 5V  
    � �� 5W     �� 5X     " ��6"   .R�5Y     � $  Bg��6   ! . .+�5Z     ]� $" 
PART_Track��6    #{�z# 5[      ��. $ 5]     �� 5^  "   8��  #��Z% 5`  %   & 5b     �� 5c  "   8�� #��Z' 5e  %   ( 5g     n� 5h  "   8�� 6(   5j     5k     5l     5n      5o  
   P� 5p      �@��Orientation$ 
Horizontal=�5q     . �5r     ��  � ��
 ���� 5s     �� 5t      � ��$ 1q�5u     �� 5v      � ��$ 5��5w     �� 5x      � ��$ 5��5y     �� 5z      � ��$
 Auto��5{     �� 5|      �@J�Opacity$	 0.3Q�5}     �� 5~      � �� 5     �� 5�     " ��6*   .R�5�     � $  Bg��6#   ! . .+�5�  "   ]� $" 
PART_Track��6(   #{�z# 5�  (   $ 5�  &   �� 5�  *   8�� #��Z) 5�  7   & 5�  &   �� 5�  *   8�� #��Z* 5�  7   ( 5�  &   n� 5�  *   8�� 60   5�  #   5�     5�     5�     5�     5�     �� 5�     " ��6   .�5�  
   ��  � ��
 �����5�     �� 5�  
    � ��$ 0q�5�     �� 5�  
    � ��$
 Left=�5�     �� 5�  
    � ��$
 Auto=�5�     �� 5�  
    � ��$	 Top=�5�     �� 5�  
    � ��$
 Auto=�5�     �� 5�  
    � �� 5�     �� 5�     " ��6"   .R�5�     �� #��z��6   #��z��5�     ! . ._�5�     � #��z��6   .+�5�     �� #+ z+ 5�  !   #��z��5�  !   #��z��5�  !   �� 5�     $, PART_VerticalScrollBar��6(   $��Right=�5�  (   #. z- 5�  (   $/ Vertical=�5�  (   8��  #1 z0 5�  (   #3 z2 5�  (   #y�z4 5�  (   �� 5�     $, PART_HorizontalScrollBar��6(   #. z5 5�  (   $/ 
Horizontal=�5�  (   8�� $��Bottom=�5�  (   #3 z6 5�  (   #1 z7 5�  (   #y�z8 5�  (   5�     5�      5�     :� 5�     $9 ScrollChanged��6'   .[�5�     �� .��5�  "   �� .��5�  &   W� $ PART_VerticalScrollBar��5�  )   $ Opacity�5�  )   $ 1X�5�  )   $ 0:0:1D�5�  )   W� 5�  &   $ PART_VerticalScrollBar��5�  )   $ Opacity�5�  )   $	 0.3X�5�  )   $ 0:0:1D�5�  )   $ 0:0:1X�5�  )   W� 5�  &   $ PART_HorizontalScrollBar��5�  )   $ Opacity�5�  )   $ 1X�5�  )   $ 0:0:1D�5�  )   W� 5�  &   $ PART_HorizontalScrollBar��5�  )   $ Opacity�5�  )   $ 0X�5�  )   $ 0:0:1D�5�  )   $ 0:0:1X�5�  )   5�  #   5�     5�     :� 5�     $9 
MouseEnter��6'   $: PART_VerticalScrollBar��5�  '   .[�5�     �� .��5�  "   �� .��5�  &   W� $ PART_VerticalScrollBar��5�  )   $ Opacity�5�  )   $ 1X�5�  )   $ 0:0:1D�5�  )   5�  #   5�     5�     :� 5�     $9 
MouseLeave��6'   $: PART_VerticalScrollBar��5�  '   .[�5�     �� .��5�  "   �� .��5�  &   W� $ PART_VerticalScrollBar��5�  )   $ Opacity�5�  )   $	 0.3X�5�  )   $ 0:0:1D�5�  )   5�  #   5�     5�     :� 5�     $9 
MouseEnter��6'   $: PART_HorizontalScrollBar��5�  '   .[�5�     �� .��5�  "   �� .��5�  &   W� $ PART_HorizontalScrollBar��5�  )   $ Opacity�5�  )   $ 1X�5�  )   $ 0:0:1D�5   )   5  #   5     5     :� 5     $9 
MouseLeave��6'   $: PART_HorizontalScrollBar��5  '   .[�5     �� .��5  "   �� .��5  &   W� $ PART_HorizontalScrollBar��5	  )   $ Opacity�5
  )   $ 0X�5  )   $ 0:0:1D�5  )   5  #   5     5     5     5     5     5     