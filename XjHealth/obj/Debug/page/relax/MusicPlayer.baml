   M S B A M L   `   `   `  ����C  ?XjHealth, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:XjHealth.page.relaxXjHealth.page.relax  5   	   +clr-namespace:XjHealth.libXjHealth.lib  5   	   5clr-namespace:XjHealth.ControlsXjHealth.Controls  5   	   %    XjHealth.page.relax.MusicPlayer   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   3local!clr-namespace:XjHealth.page.relax     5   	   /locallibclr-namespace:XjHealth.lib     5   	   /my1clr-namespace:XjHealth.Controls     5   	   -   5          N� Title$  心际之芯��5
   	   $
��1366��6   $	��768��6#    � 	Resources 5       �� MergedDictionaries �� Source�� 5   
    5      �� 5      $ /style/maincss.xaml?�6%   �� 5      $ /style/resStyles.xaml?�6%   %    5       N� 
Background 5      �� 5   
    �� ImageSource$" /resource/img/relax_list.png��6    j� Stretch$
 Fill=�6A   6R   .��5      �� .+�5   
   �  �� Left$	 150��6   
 �� Top$	 150��6!   $
��1000��62   $	��500��6?   	 � RowDefinitions	 5      �� 5      $��30 �6    �� 5      $��20 �6    �� 5      $��* �6    �� 5      $��20 �6    �� 5      $��85 �6    .+�5      �� -   5        
 ��Name$
 	BackFrame��5   �   $��5��6    �� CornerRadius$ 3,3,3,3��6&   $��1,1,1,1q�6=   $��19(�6W   ���	#FFFFFFFF$y�Visible=�6�   ���#DDDDDD��5       �� 5!       �� EndPoint$	 0,1&�6*    �� 
StartPoint$	 0,0&�69   .��5"      �  � Color$ #4B5463��6'    � Offset$ 0Q�67   � 5#      $ #000000��6'   $	 0.1Q�67   � 5$      $ #000000��6'   $
 0.97Q�67   � 5%      $ #4B5463��6'   $ 1Q�67   5&      5(      �� 5)      -   5        $��playListBox��5)      $��2��6)   $��Stretch=�66   $��2,2,2,2q�6T   $��Stretch=�6e    � ContextMenu 5*      �� 5+      .@�5,      m� $��增加��6#   .@�5-      m� -   5        $��
folderOpen��5-   6   $��增加文件夹��6'   5.      m� 5/      -   5        $��fileOpen��5/   5   $��增加文件��6'   50      m� 51      -   5        $��playlistOpen��51   7   $��增加播放列表��6'   52      53      m� 54      $��删除��6#   55      m� 56      $��修改��6#   57      m� 58      -   5        $��清空��58   #   59      5:      5<      #   XjHealth.Controls.PlayControl  5=      -   5          Name$ playControl1��5=   <   $��1,1,1,1q�6   $��4��6/   $��Stretch=�6R   $��Stretch=�6o   �� 5>      -	   5         ��Name$
 Menu��5>   %   $��0��6   $��6��63    �� TextAlignment$ Center=�6<      TextBlockStateStyle#��[  6S   $��0,1,65,0q�6�   $��Right=�6�   $��20��6�    � Cursor$
 Hand��6�    � ToolTip$ 	主菜单��6�   $��20��6�   $	��Top=�6�   $
��Bold"�6�   $��Webdings)�6   5?      �� 5@      -
   5        $��mainMenu��5@   "   .@�5A      m� $��打开��6#   $
��Left=�6/   .@�5B      m� -   5        $��打开文件��5B   '   $
��Left=�65   6P   m� 5C      -   5        $��打开文件夹��5C   '   $
��Left=�66   6Q   m� 5D      -   5        $��打开播放列表��5D   '   $
��Left=�67   6R   5E      m� 5F      $��播放模式��6#   $
��Left=�61   .@�5G      m� $��单曲播放��6'   m� 5H      $��顺序播放��6'    m� 	IsChecked . 65   m� 5I      $��随机播放��6'   5J      5K      5M      F� 5N      ���#ffffff$��Right=�6$   $��1��6@   7������� -1р��  -1�@KL ��� �@KL @KL �@KL @B 	6T   5O         XjHealth.lib.ImageButton  5R   
   -   5          Name$ btn_backmain��5R   �      XjHealth.lib.ImageButton   Click$ btn_backmain_Click��6�   $	��130��6    $��35��6,      ImgPath$# /resource/img/exit_before.png��68      MouseOverImgPath$# /resource/img/exit_before.png��6`     ImageButtonTemplate#��[ 6�   $
 Hand��6�   $	 690��6  $
 1020��6  5S      5T      