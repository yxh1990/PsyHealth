   M S B A M L   `   `   `  ����C  ?XjHealth, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:XjHealth.page.xuexiXjHealth.page.xuexi  5   	   +clr-namespace:XjHealth.libXjHealth.lib  5   	   #    XjHealth.page.xuexi.playvideo   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   3local!clr-namespace:XjHealth.page.xuexi     5   	   /locallibclr-namespace:XjHealth.lib     5   	   -   5          N� Title$  	playvideo��5	   	   $
��1366��6   $	��768��6(    � 	Resources 5
       �� MergedDictionaries �� Source�� 5   
    5      �� 5      $ /style/maincss.xaml?�6%   %    5       N� 
Background 5      �� 5   
    �� ImageSource$# /resource/img/learn_third.png��6    j� Stretch$
 Fill=�6B   6S   .��5      �� .+�5   
      XjHealth.lib.ImageButton  -   5          Name$ 
btn_yinian��5   '     XjHealth.lib.ImageButton   Click$ btn_yinian_Click��6;  	 � Cursor$
	 Hand��6   

 �� Top$	
 170��6.    �� Left$	 110��6?   $	��136��6R   $	��136��6^      ImgPath$$ /resource/img/learn_ynsd_A.png��6k      MouseOverImgPath$$ /resource/img/learn_ynsd_B.png��6�      DisableImgPath$$ /resource/img/learn_ynsd_C.png��6�      ImageButtonTemplate#��[  6�     
ButtonText#��[ 6T    5   
   -   5        $ btn_fuxi��5   '  $ btn_fuxi_Click��69  $
	 Hand��6   $	
 330��6.   $	 110��6?   $	��136��6R   $	��136��6^   $$ /resource/img/learn_ynsd_A.png��6k   $$ /resource/img/learn_ynsd_B.png��6�   $$ /resource/img/learn_ynsd_C.png��6�   #��[  6�   #��[ 6P    5   
   -   5        $ 
btn_qingan��5   '  $ btn_qingan_Click��6;  $
	 Hand��6   $	
 495��6.   $	 110��6?   $	��136��6R   $	��136��6^   $$ /resource/img/learn_ynsd_A.png��6k   $$ /resource/img/learn_ynsd_B.png��6�   $$ /resource/img/learn_ynsd_C.png��6�   #��[  6�   #��[ 6T  �� 5   
   $$��/resource/img/learn_player.png��6   $	
 160��68   $	 268��6I   $	��560��6[   $	��489��6g   6v     5   
   -   5        $ btn_play��5   �   $ btn_play_Click��6  $
	 Hand��6   $	
 580��6.   $	 280��6?   $��58��6R   $��58��6]   $" /resource/img/learn_play.png��6i   $" /resource/img/learn_play.png��6�   #��[  6�   6  r� 5   
   -   5         r�Name$ videoScreenMediaElement��5      $	
 179��68   $	 275��6I   $	��545��6[   $	��390��6g    r� LoadedBehavior$ Manual=�6t     5   
   -   5        $ btn_backbefore��5   �   $ btn_backbefore_Click��6�   $	
 680��6   $
 1050��60   $	��134��6D   $��39��6P   $# /resource/img/exit_before.png��6\   $# /resource/img/exit_before.png��6�   #��[  6�   $
	 Hand��6  5      5      