   M S B A M L   `   `   `  ����C  ?XjHealth, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:XjHealth.page.cepinXjHealth.page.cepin  5   	   +clr-namespace:XjHealth.libXjHealth.lib  5   	   "    XjHealth.page.cepin.cepinend   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   3local!clr-namespace:XjHealth.page.cepin     5   	   /locallibclr-namespace:XjHealth.lib     5   	   -   5          N� Title$  心际之芯��5	   	   $
��1366��6   $	��768��6#    � 	Resources 5
       �� MergedDictionaries �� Source�� 5   
    5      �� 5      $ /style/maincss.xaml?�6%   %    5       N� 
Background 5      �� 5   
    �� ImageSource$# /resource/img/scale_third.png��6    j� Stretch$
 Fill=�6B   6S   .��5      �� .+�5   
   �� $	��935��6   $	��425��6!    �� Left$	 190��6.   
 �� Top$	 200��6@   .+�5      ��    
ScaleTitle#��[  6   .��69   测评结果及建议6B   �� 5      -   5        	 ��Name$	 sdesc��5   �   
 �� Padding$
 	100,0,0,0q�6     	ScaleDesc#��[ 6-   $��WrapWithOverflow=�6P   $	��900��6p   $	��425��6|   $��16(�6�    �� 
LineHeight$ 30��6�   5      5         XjHealth.lib.ImageButton  5   
   -   5          Name$ 	btn_start��5   �      XjHealth.lib.ImageButton   Click$ btn_backmain_Click��6  $	 595��6   $	 650��60   $	��121��6C   $��31��6O      ImgPath$&  /resource/img/scale_test_end.png��6[      MouseOverImgPath$&  /resource/img/scale_test_end.png��6�     ImageButtonTemplate#��[ 6�    � Cursor$
 Hand��6�   6    5    
   -   5        $ btn_backmain��5    �   $ btn_backmain_Click��6�   $	 680��6   $
 1050��60   $	��134��6D   $��39��6P   $" /resource/img/exit_index.png��6\   $" /resource/img/exit_index.png��6�   #��[ 6�   $
 Hand��6  5!      5"      