   M S B A M L   `   `   `  ����C  ?XjHealth, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:XjHealth.page.trainXjHealth.page.train  5   	   +clr-namespace:XjHealth.libXjHealth.lib  5   	   #    XjHealth.page.train.trainmain   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   3local!clr-namespace:XjHealth.page.train     5   	   /locallibclr-namespace:XjHealth.lib     5   	     N� Title$  心际之芯��5	   	   $
��1366��6   $	��768��6#    � 	Resources 5
       �� MergedDictionaries �� Source�� 5   
    5      �� 5      $ /style/maincss.xaml?�6%   %    5       N� 
Background 5      �� 5   
    �� ImageSource$ /resource/img/train.png��6    j� Stretch$
 Fill=�6<   6M   .��5      �� .+�5   
      XjHealth.lib.ImageButton  
 �� Top$	 200��6    �� Left$	 250��60   $	��122��6C   $	��170��6O   	   ImgPath$%	 /resource/img/train_pts_pic.png��6\   
   MouseOverImgPath$%
 /resource/img/train_pts_pic.png��6�      ImageButtonTemplate#��[  6�    � Cursor$
 Hand��6�   �� 5   
   $&�� /resource/img/train_pts_text.png��6   $	 200��6:   $	 380��6K   $	��227��6]   $	��170��6i   6y     5   
   $	 200��6   $	 800��60   $	��122��6C   $	��170��6O   $$	 /resource/img/train_sj_pic.png��6\   $$
 /resource/img/train_sj_pic.png��6�   #��[  6�   $
 Hand��6�   �� 5   
   $%��/resource/img/train_sj_text.png��6   $	 200��69   $	 930��6J   $	��227��6\   $	��170��6h   6x     5   
   $	 450��6   $	 250��60   $	��122��6C   $	��170��6O   $&	  /resource/img/train_xlsq_pic.png��6\   $&
  /resource/img/train_xlsq_pic.png��6�   #��[  6�   $
 Hand��6�   �� 5   
   $'��!/resource/img/train_xlsq_text.png��6   $	 450��6;   $	 380��6L   $	��227��6^   $	��170��6j   6z     5   
   $	 450��6   $	 800��60   $	��122��6C   $	��170��6O   $$	 /resource/img/train_sp_pic.png��6\   $$
 /resource/img/train_sp_pic.png��6�   #��[  6�   $
 Hand��6�   �� 5   
   $%��/resource/img/train_sp_text.png��6   $	 450��69   $	 930��6J   $	��227��6\   $	��170��6h   6x     5!   
   -   5          Name$ btn_backmain��5!   �      XjHealth.lib.ImageButton   Click$ btn_backmain_Click��6�   $	 680��6   $
 1050��60   $	��134��6D   $��39��6P   $"	 /resource/img/exit_index.png��6\   $"
 /resource/img/exit_index.png��6�   #��[  6�   $
 Hand��6  5"      5#      