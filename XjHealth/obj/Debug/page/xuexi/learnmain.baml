   M S B A M L   `   `   `  ����C  ?XjHealth, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:XjHealth.page.xuexiXjHealth.page.xuexi  5   	   +clr-namespace:XjHealth.libXjHealth.lib  5   	   #    XjHealth.page.xuexi.learnmain   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   3local!clr-namespace:XjHealth.page.xuexi     5   	   /locallibclr-namespace:XjHealth.lib     5   	     N� Title$  心际之芯��5	   	   $
��1366��6   $	��768��6#    � 	Resources 5
       �� MergedDictionaries �� Source�� 5   
    5      �� 5      $ /style/maincss.xaml?�6%   %    5       N� 
Background 5      �� 5   
    �� ImageSource$$ /resource/img/learn_second.png��6    j� Stretch$
 Fill=�6C   6T   .��5      �� .+�5   
      XjHealth.lib.ImageButton  -   5          Name$ btn_fuxi��5   �      XjHealth.lib.ImageButton   Click$ btn_fuxi_Click��6	  	 � Cursor$
	 Hand��6   

 �� Top$	
 170��6.    �� Left$	 320��6?   $	��136��6R   $	��136��6^      ImgPath$$ /resource/img/learn_ynsd_A.png��6k      MouseOverImgPath$$ /resource/img/learn_ynsd_B.png��6�      ImageButtonTemplate#��[  6�   $��呼吸训练��6     
ButtonText#��[ 6/    5   
   -   5        $ btn_minxiang��5   �   $ btn_minxiang_Click��6  $
	 Hand��6   $	
 380��6.   $	 470��6?   $	��136��6R   $	��136��6^   $$ /resource/img/learn_ynsd_A.png��6k   $$ /resource/img/learn_ynsd_B.png��6�   #��[  6�   $��冥想训练��6*  #��[ 69    5   
   -   5        $ 
btn_fasong��5   �   $ btn_fasong_Click��6  $
	 Hand��6   $	
 395��6.   $	 150��6?   $	��136��6R   $	��136��6^   $$ /resource/img/learn_ynsd_A.png��6k   $$ /resource/img/learn_ynsd_B.png��6�   #��[  6�   $��放松训练��6$  #��[ 63  �� 5   
   $"��/resource/img/learn_text.png��6   $	��502��66   $	��146��6B   $	
 310��6O   $	 640��6`   6t     5   
   -   5        $ btn_backmain��5   �   $ btn_backmain_Click��6�   $	
 680��6   $
 1050��60   $	��134��6D   $��39��6P   $" /resource/img/exit_index.png��6\   $" /resource/img/exit_index.png��6�   #��[  6�   $
	 Hand��6  5      5       