   M S B A M L   `   `   `  ����C  ?XjHealth, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:XjHealth.page.jianceXjHealth.page.jiance  5   	   +clr-namespace:XjHealth.libXjHealth.lib  5   	   ^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35tOclr-namespace:System.Windows.Forms.Integration;assembly=WindowsFormsIntegration System.Windows.Forms.Integration 5   	   m iSystem.Windows.Forms.DataVisualization, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35�mclr-namespace:System.Windows.Forms.DataVisualization.Charting;assembly=System.Windows.Forms.DataVisualization/System.Windows.Forms.DataVisualization.Charting 5	   	   %    XjHealth.page.jiance.jiancemain   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   4local"clr-namespace:XjHealth.page.jiance     5   	   /locallibclr-namespace:XjHealth.lib     5   	   _wfiOclr-namespace:System.Windows.Forms.Integration;assembly=WindowsFormsIntegration     5   	   |wfmclr-namespace:System.Windows.Forms.DataVisualization.Charting;assembly=System.Windows.Forms.DataVisualization     5	   	   -   5          N� Title$  心际之芯��5   	   $
��1366��6   $	��768��6#    � 	Resources 5       �� MergedDictionaries �� Source�� 5   
    5      �� 5      $ /style/maincss.xaml?�6%   %    5       N� 
Background 5      �� 5   
    �� ImageSource$ /resource/img/monitor.png��6    j� Stretch$
 Fill=�6>   6O   .��5      �� .+�5   
   �� -   5         ��Name$ lblhr��5      
 �� Top$	 145��6   	 �� Left$
	 1045��60   
���  ��$
��Bold"�6T   $��20(�6f   .��6t   06w   �� 5   
   -   5        $ 	lblxhdesc��5      $	 114��6#   $		 973��64   
�������$
��Bold"�6Y   $��16(�6k   .��6y   信号质量6   �� 5   
   -   5        $ lblxh��5      $	 110��6   $
	 1045��60   
���  ��$
��Bold"�6T   $��20(�6f   .��6t   06w   7  1System.Windows.Forms.Integration.WindowsFormsHost  5   
   -   5        
  Name$
 chartwindow��5   C   $	 190��6   $		 248��60      Child. 5      ;  5System.Windows.Forms.DataVisualization.Charting.Chart  -   5        
chart1��[ WSystem.Windows.Forms, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089"  System.Windows.Forms.Control   Width$	 625��5   '      Height$	 325��63   5      5          XjHealth.lib.ImageButton  5!   
   -   5          Name$ btn_hr��5!   �    � Cursor$
 Hand��6   $	 535��6-   $		 250��6>   $��50��6Q   $��46��6\      ImgPath$$ /resource/img/monitor_hr_A.png��6h      MouseOverImgPath$$ /resource/img/monitor_hr_B.png��6�      ImageButtonTemplate#��[  6�   6�     5"   
   -   5        $ btn_hrv��5"   �   $
 Hand��6   $	 535��6-   $		 310��6>   $��50��6Q   $��46��6\   $% /resource/img/monitor_hrv_A.png��6h   $% /resource/img/monitor_hrv_B.png��6�   #��[  6�   6�     5#   
   -	   5        $ 
btn_stress��5#   �   $
 Hand��6   $	 535��6-   $		 370��6>   $��50��6Q   $��46��6\   $( "/resource/img/monitor_stress_A.png��6h   $( "/resource/img/monitor_stress_B.png��6�   #��[  6�   6�     5$   
   -
   5        $ btn_mood��5$   �   $
 Hand��6   $	 535��6-   $		 430��6>   $��50��6Q   $��46��6\   $&  /resource/img/monitor_mood_A.png��6h   $&  /resource/img/monitor_mood_B.png��6�   #��[  6�   6�     5'   
   -   5        $ btn_monstart��5'        XjHealth.lib.ImageButton   Click$ btn_monstart_Click��6  $
 Hand��6   $	 560��6-   $		 720��6>   $��71��6Q   $��26��6\   $+ %/resource/img/monitor_chart_start.png��6h   $+ %/resource/img/monitor_chart_start.png��6�   #��[  6�   6    5(   
   -   5        $ btn_monstop��5(   �   $ btn_monstop_Click��6  $
 Hand��6   $	 560��6-   $		 720��6>   $��71��6Q   $��26��6\   $$ /resource/img/monitor_exit.png��6h   $$ /resource/img/monitor_exit.png��6�   #��[  6�   $y�Hidden=�6	  6    5)   
   -   5        $ 
btn_monset��5)   �   $ btn_monset_Click��6  $
 Hand��6   $	 560��6-   $		 800��6>   $��71��6Q   $��26��6\   $) #/resource/img/monitor_chart_set.png��6h   $) #/resource/img/monitor_chart_set.png��6�   #��[  6�   6    5,   
   -   5        $ btn_monbreath��5,     $ btn_monbreath_Click��6  $
 Hand��6   $	 565��6-   $
	 1000��6>   $	��156��6R   $��39��6^   $* $/resource/img/monitor_breath_btn.png��6j   $* $/resource/img/monitor_breath_btn.png��6�   #��[  6�   6    5.   
   -   5        $ btn_backmain��5.   �   $ btn_backmain_Click��6�   $	 680��6   $
	 1050��60   $	��134��6D   $��39��6P   $" /resource/img/exit_index.png��6\   $" /resource/img/exit_index.png��6�   #��[  6�   $
 Hand��6  �� 50   
   -   5         ��Name$ loading��50       J� RenderTransformOrigin$ 0.5,0.5&�6"   $	 210��6B   $		 310��6S   $y�	Collapsed=�6e   $��Center=�6|   $��Center=�6�   $	��120��6�   $	��120��6�   $��187,76,241,85q�6�   .+�51      A� $��15��6   $��15��6!   $	 55��6-   $ 31��6>    �� Stretch$
 Fill=�6N   ���	#FFD1D1F7 J� Opacity$	 1.0Q�6n   A� 52      $��15��6   $��15��6!   $	 38��6-   $ 39��6>   $
 Fill=�6N   
����  �$	 0.8Q�6i   A� 53      $��15��6   $��15��6!   $	 36��6-   $ 58��6>   $
 Fill=�6N   ���	#FF0000FE$	 0.7Q�6n   A� 54      $��15��6   $��15��6!   $	 52��6-   $ 67��6>   $
 Fill=�6N   
����  �$	 0.6Q�6i   A� 55      $��15��6   $��15��6!   $	 68��6-   $ 61��6>   $
 Fill=�6N   ���	#FF2E2EFF$	 0.5Q�6n   A� 56      $��15��6   $��15��6!   $	 69��6-   $ 42��6>   $
 Fill=�6N   ���	#FF6F6FFF$	 0.4Q�6n   z�57      �� 58      -   5        SpinnerRotate�� �� Angle$ 0Q�58   9    � Triggers 5:      :� 5;       :� RoutedEvent$ ContentControl.Loaded��6   .[�5<      �� .��5=      �� .��5>      W�  �� 
TargetName$ SpinnerRotate��6.    �� TargetProperty$ (RotateTransform.Angle)�6T    W� From$ 0X�6�   	 W� To$	 360X�6�    g� Duration$ 0:0:0.8D�6�    g� RepeatBehavior$ Forever��6�   5?      5@      5A      5C      �� 5F   
   -   5          ��Name$  
heartRelax��5F   1   $��/resource/img/heart.png��6   $��96��6E   $��81��6P   $		 975��6\   $	 250��6n   �� 5G   
   -   5        $  heartEmotion��5G   1   $��/resource/img/heart.png��6   $��96��6G   $��81��6R   $		 975��6^   $	 420��6p   �� 5J   
   -   5        $ hxcon��5J   M   $		 970��6   $	 235��6#   $	��260��64   $	��374��6@   $y�Hidden=�6\   ! K� ZIndex$! 50��6p   ��5K      �� 5L      $&  /resource/img/monitor_breath.png��6   $
 Fill=�6M   6^   .+�5N      �� -   5        $  hximg��5N      $��/resource/img/breath.png��6#   $	��234��6E   $	��236��6Q   $	 13��6_   $ 43��6p   r� 5O      -   5        " r�Name$" videoMediaElement��5O      # r� LoadedBehavior$# Manual=�66   $ 43��6x   $	 13��6�   $	��234��6�   $	��236��6�   $y�Hidden=�6�   5P        5R      -   5        $ btn_qiehuan��5R   �   $ btn_qiehuan_Click��6  $	 305��6#   $		 185��64   $
 Hand��6F   $��67��6T   $��23��6_   $&  /resource/img/monitor_change.png��6k   $&  /resource/img/monitor_change.png��6�   #��[  6�   6    5S      -   5        $ 
btn_kaishi��5S   �   $ btn_kaishi_Click��6  $	 345��6#   $	 12��64   $
 Hand��6F   $��51��6T   $��21��6_   $% /resource/img/monitor_start.png��6k   $% /resource/img/monitor_start.png��6�   #��[  6�   6    5T      -   5        $ 
btn_tuichu��5T   �   $ btn_tuichu_Click��6
  $	 345��6#   $		 200��64   $
 Hand��6F   $��51��6T   $��21��6_   $$ /resource/img/monitor_exit.png��6k   $$ /resource/img/monitor_exit.png��6�   #��[  6�   6
  5U      �� 5X   
   -   5        $ 
userconfig��5X      $! 80��6%   $	 250��67   $		 910��6H   $	��232��6Z   $	��237��6f   $y�Hidden=�6s   ��5Y      �� 5Z      $$ /resource/img/chart_set_bg.png��6   $
 Fill=�6K   6\   .+�5\      �� $ 62��6   $	 20��6$   $��音乐��65   $��16(�6B   $
��Bold"�6P   6d   	� 5]      -   5        $ 	�Name$$ rbMusic��5]   Y   $��5,0,0,0q�6   $
 Hand��6,   % 	� 	GroupName$% gMusic��6:   $	��开��6M   $	��Top=�6j     RadioButtonControlTemplate2#���  6�   $ 70��6�   $	 80��6�   5^      	� 5_      -   5        $$ rbMusic2��5_   Y   $��5,0,0,0q�6   $
 Hand��6,   $% gMusic��6:   $	��关��6M   $	��Top=�6k   #���  6�   $ 70��6�   $		 140��6�   5`      �� 5a      $ 95��6   $	 20��6$   $��音量��65   $��16(�6B   $
��Bold"�6P   6d   �� 5b      -   5        & ��Name$& sliderVolume��5b   '   $��5,10,5,5q�6   $	 70��6>   $	 100��6P   $	��105��6a   $��10��6m   ' � Maximum$	' 100Q�6y   ( � Minimum$( 0Q�6�   ) � Value$) 20Q�6�   5c      �� 5d      $	 135��6   $	 20��6%   $��选择��66   $��16(�6C   $
��Bold"�6Q   6e   �� 5e      -   5        * ��Name$* txtmusicpath��5e      $	 138��6,   $	 75��6=   $	��130��6N   $��25��6Z   $	��Top=�6f   + �� TextAlignment$+ Center=�6~   .��6�   resource/mp3/background.mp36�     5f      -   5        $ btn_checkfile��5f   �   $ btn_checkfile_Click��6  $	 143��6#   $		 210��64   $��15��6G   $��15��6R   $+ %/resource/img/SPCS_SZ_DKAN_YYXZ_A.bmp��6^   $+ %/resource/img/SPCS_SZ_DKAN_YYXZ_B.bmp��6�   #��[  6�   $
 Hand��6  6    5h      -    5        $ btn_ok��5h     $ btn_ok_Click��6   $��5,15,5,5q�6#   $	 180��65   $	 60��6F   $
 Hand��6X   $��51��6f   $��21��6q   $' !/resource/img/chart_stop_btnA.png��6}   $' !/resource/img/chart_stop_btnA.png��6�   #��[  6�   6     5i      -!   5        $ 
btn_cancle��5i     $ btn_cancle_Click��6#  $��5,15,5,5q�6#   $	 180��65   $		 120��6F   $
 Hand��6X   $��51��6f   $��21��6q   $' !/resource/img/chart_stop_btnB.png��6}   $' !/resource/img/chart_stop_btnB.png��6�   #��[  6�   6#  5j      r� 5l   
   -"   5        $" media1��5l      $# Manual=�6(   , r� UnloadedBehavior$
, Stop=�6y   - r� Stretch$
- Fill=�6�   . r� Volume. 6A   �� / �� ElementName$/ sliderVolume��0 �� Path$0 Value�6�   5m      5n      