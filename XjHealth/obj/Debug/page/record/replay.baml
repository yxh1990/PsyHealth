   M S B A M L   `   `   `  ����C  ?XjHealth, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:XjHealth.page.recordXjHealth.page.record  5      +clr-namespace:XjHealth.libXjHealth.lib  5      !    XjHealth.page.record.replay   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      4local"clr-namespace:XjHealth.page.record     5      /locallibclr-namespace:XjHealth.lib     5      Y UDynamicDataDisplay, Version=0.3.0.0, Culture=neutral, PublicKeyToken=5b7d744a7263923f=d34http://research.microsoft.com/DynamicDataDisplay/1.0  5	      -   5          N� Title$  心际之芯��5
      $
��1366��6   $	��768��6!    � 	Resources 5       �� MergedDictionaries �� Source�� 5   
    5      �� 5      $ /style/maincss.xaml?�6%   %    5       N� 
Background 5      �� 5   
    �� ImageSource$  /resource/img/reportBg.png��6    j� Stretch$
 Fill=�6?   6P   .��5      �� .+�5   
   8  2Microsoft.Research.DynamicDataDisplay.ChartPlotter  -   5          Name$ plotter��5      $��5q�6+    �� Left$	 100��66   
	 �� Top$		 100��6H   $
��1200��6Y   $	��500��6f   
   VerticalAxis
 5      K  EMicrosoft.Research.DynamicDataDisplay.Charts.Axes.VerticalIntegerAxis  5         HorizontalAxis 5      M  GMicrosoft.Research.DynamicDataDisplay.Charts.Axes.HorizontalIntegerAxis  5      3  -Microsoft.Research.DynamicDataDisplay.Plotter   Children. 5      2  ,Microsoft.Research.DynamicDataDisplay.Header  $�� ��6   =  7Microsoft.Research.DynamicDataDisplay.VerticalAxisTitle  5       $�� ��6#   5!         XjHealth.lib.ImageButton  5#   
   -   5          Name$ btn_hr��5#   �      XjHealth.lib.ImageButton   Click$ btn_hr_Click��6   � Cursor$
 Hand��6   $		 635��6-   $	 100��6>   $��50��6Q   $��46��6\      ImgPath$$ /resource/img/monitor_hr_A.png��6h      MouseOverImgPath$$ /resource/img/monitor_hr_B.png��6�      ImageButtonTemplate#��[  6�   6    5$   
   -   5        $ btn_hrv��5$   �   $ btn_hrv_Click��6  $
 Hand��6   $		 635��6-   $	 165��6>   $��50��6Q   $��46��6\   $% /resource/img/monitor_hrv_A.png��6h   $% /resource/img/monitor_hrv_B.png��6�   #��[  6�   6    5%   
   -   5        $ 
btn_stress��5%   �   $ btn_stress_Click��6  $
 Hand��6   $		 635��6-   $	 230��6>   $��50��6Q   $��46��6\   $( "/resource/img/monitor_stress_A.png��6h   $( "/resource/img/monitor_stress_B.png��6�   #��[  6�   6    5&   
   -   5        $ btn_mood��5&   �   $ btn_mood_Click��6
  $
 Hand��6   $		 635��6-   $	 295��6>   $��50��6Q   $��46��6\   $&  /resource/img/monitor_mood_A.png��6h   $&  /resource/img/monitor_mood_B.png��6�   #��[  6�   6
    5(   
   -   5        $ btn_backmain��5(   �   $ btn_backmain_Click��6�   $
 1160��6   $		 680��62   $	��130��6D   $��35��6P   $# /resource/img/exit_before.png��6\   $# /resource/img/exit_before.png��6�   #��[  6�   $
 Hand��6  5)      5*      