   M S B A M L   `   `   `  ����C  ?XjHealth, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:XjHealth.page.relaxXjHealth.page.relax  5   	   +clr-namespace:XjHealth.libXjHealth.lib  5   	   [ WSystem.Windows.Forms, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089Y@clr-namespace:System.Windows.Forms;assembly=System.Windows.FormsSystem.Windows.Forms 5	   	   ^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35tOclr-namespace:System.Windows.Forms.Integration;assembly=WindowsFormsIntegration System.Windows.Forms.Integration 5
   	   #    XjHealth.page.relax.relaxmain   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   3local!clr-namespace:XjHealth.page.relax     5   	   /locallibclr-namespace:XjHealth.lib     5   	   Owf@clr-namespace:System.Windows.Forms;assembly=System.Windows.Forms     5	   	   _wfiOclr-namespace:System.Windows.Forms.Integration;assembly=WindowsFormsIntegration     5
   	   -   5          N� Title$  心际之芯��5   	   $
��1366��6   $	��768��6#    � 	Resources 5       �� MergedDictionaries �� Source�� 5   
    5      �� 5      $ /style/maincss.xaml?�6%   %    5       N� 
Background 5      �� 5   
    �� ImageSource$" /resource/img/relax_list.png��6    j� Stretch$
 Fill=�6A   6R   .��5      �� .+�5   
   7  1System.Windows.Forms.Integration.WindowsFormsHost   K� ZIndex$ 1��6      Child. 5      %  System.Windows.Forms.WebBrowser  -   5        webBrowser1��"  System.Windows.Forms.Control	   Width$
	 1366��5   1   
   Height$	
 768��6>      ScrollBarsEnabled .  6K   5        5   
   $ 10��6   
 �� Top$	 710��6-    �� Left$
 1050��6>   . 5      2  ,System.Windows.Forms.Integration.ElementHost     Child. 5         XjHealth.lib.ImageButton  -   5          Name$ btn_backmain��5   �      XjHealth.lib.ImageButton   Click$ btn_backmain_Click��6�   $	��130��6(   $��35��64      ImgPath$" /resource/img/exit_index.png��6@      MouseOverImgPath$" /resource/img/exit_index.png��6g      ImageButtonTemplate#��[  6�    � Cursor$
 Hand��6�   5      5      r� 5    
   -   5         r�Name$ videoplayer��5       $��0��6,   $��0��66   $	 725��6A   $ 10��6R    r� LoadedBehavior$ Manual=�6c   r� 5!   
   -   5        $ playlist��5!      $��0��6,   $��0��67   $	 725��6B   $ 20��6S   $ Manual=�6�   6�   5"      5#      