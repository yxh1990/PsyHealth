   M S B A M L   `   `   `  ����C  ?XjHealth, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:XjHealth.page.recordXjHealth.page.record  5   	   +clr-namespace:XjHealth.libXjHealth.lib  5   	   O KCustomControlLibrary, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullY@clr-namespace:CustomControlLibrary;assembly=CustomControlLibraryCustomControlLibrary 5   	   %    XjHealth.page.record.recordmain   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   4local"clr-namespace:XjHealth.page.record     5   	   /locallibclr-namespace:XjHealth.lib     5   	   Plib@clr-namespace:CustomControlLibrary;assembly=CustomControlLibrary     5   	   -   5        $
��self��5	   	     N� Title$  心际之芯��5   	   $
��1366��6   $	��768��6#    � 	Resources 5       �� MergedDictionaries �� Source�� 5   
    5      �� 5      $ /style/maincss.xaml?�6%   %    5       N� 
Background 5      �� 5   
    �� ImageSource$ /resource/img/record.png��6    j� Stretch$
 Fill=�6=   6N   .��5      �� .+�5   
   )  #CustomControlLibrary.PagingDataGrid  -   5        $��	dataGrid1��5   ]    �� Left$	 208��6   
 �� Top$	 149��60   &   System.Windows.Controls.DataGrid	   AutoGenerateColumns	 .  $	��Top=�6n   
   CanUserSortColumns
 .  $	��938��6�   $��5q�6�      
IsReadOnly .    CanUserResizeColumns .     CanUserResizeRows .     SelectionMode$ Single=�6     CanUserReorderColumns .   �� AlternationCount$ 2��66     RowHeaderWidth$ 0Q�6K     CanUserAddRows .  $y�Hidden=�6u  ��5      �� *TrainResult.Reports+ �� ElementName$
 self��   Total 5      �� *TrainResult.Total+$
 self��   Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ 训练内容��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$	 120 63   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6?   �� *	trainName+  5      $ 训练时间��6%   $	 160 63    6?   �� *	trainTime+  5      $ 训练时长��6%   $	 100 63    6?   �� *trainCostTime+  5       $ 放松指数��6%   $	 100 63    6?   �� *mood+  5"      $ 稳定指数��6%   $ 91 63    6>   �� *stress+  5#      $ 心率��6%   $ 95 61    6<   �� *	heartBeat+4  .System.Windows.Controls.DataGridTemplateColumn  5$      $ 结果详情��6)   $	 270 67      CellTemplate 5%      �� 5&      .R�5'      ]� .+�5(   "   ��  ��Name$ 
btn_replay��6t   -   5        ���#ffa200$��[回放]��5(   W    � Cursor$
 Hand��6f   $��60��6�   $��30��6�      TransparentButtonStyle#��[  6�   
 � Tag 6>   �� *
healthId+6�   �� 5)   "   $ 
btn_report��6u   -   5        ���#ffa200$��[训练报告]��5)   V   $
 Hand��6g   $	��100��6�   $��30��6�   #��[  6�    6>   �� *	trainId+6�   5*      5+      5-      5/        51   
   -   5        $��	dataGrid2��51   ]   $	 208��6   $	 149��60   	 .  $	��Top=�6n   
 .  $	��940��6�   $��5q�6�    .  .   .  $ Single=�6   .  $ 2��66  $ 0Q�6K   .  ��52      �� *Result.Reports+$
 self�� 53      �� *Result.Total+$
 self�� 55        56      $ 量表名称��6%   $	 300 63    6?   �� *scaleListName+  57      $ 测试时间��6%   $	 240 63    6?   �� *scaleTestDateTime+  58      $ 测试时长��6%   $	 100 63    6?   �� *scaleTestTime+  59      $ 结果详情��6)   $	 298 67    5:      �� 5;      .R�5<      ]� .+�5=   "   �� -   5        ���#ffa200$��[答卷]��5=   z   $
 Hand��6�   $��60��6�   $��30��6�   #��[  6�    6>   �� *
resultId+
 J� Uid 6W   �� *scaleTestDateTime+6�   �� 5>   "   $ btn_testReport��6v   -   5        ���#ffa200$��[测评报告]��5>   W   $
 Hand��6h   $	��100��6�   $��30��6�   #��[  6�    6>   �� *
resultId+6�   5?      5@      5B      5D      �� 5F   
   -   5         ��Name$ grid_testreport��5F   J   $	 130��6   $	 480��6&    K� ZIndex$ 15��68   $y�Hidden=�6c   .+�5G      �� .+�5H      �� $"��/resource/img/recordRepo.png��6   $ 15��6>   $	��420��6Q   $	��542��6]   �� 5I        
trainTitle#��[ 6   $ 15��6<   $ 30��6N   $ 40��6^   .��6o   	内容：6t   �� 5J      -	   5          ��Name$  traincon��5J   p   #��[ 6   $ 15��6<   $ 30��6N   $	 140��6^   6�   �� 5K      #��[ 6   $ 15��6<   $ 60��6N   $ 40��6^   .��6o   	难度：6t   �� 5L      -
   5        $  traindu��5L   p   #��[ 6   $ 15��6<   $ 60��6N   $	 140��6^   6�   �� 5M      #��[ 6   $ 15��6<   $ 90��6N   $ 40��6^   .��6o   开始时间：6v   �� 5N      -   5        $  trainstartTime��5N   p   #��[ 6   $ 15��6<   $ 90��6N   $	 140��6^   6�   �� 5O      #��[ 6   $ 15��6<   $	 120��6N   $ 40��6_   .��6p   结束时间：6w   �� 5P      -   5        $  trainendTime��5P   q   #��[ 6   $ 15��6<   $	 120��6N   $	 140��6_   6�      XjHealth.lib.ImageButton  5Q      -   5        !  Name$! 
btn_guanbi��5Q   �   	   XjHealth.lib.ImageButton" 	  Click$" btn_guanbi_Click��6  $ 20��6'   $	 480��69   $	 330��6J   $��71��6]   $��29��6h   #   ImgPath$!# /resource/img/user_exit.png��6t   $   MouseOverImgPath$!$ /resource/img/user_exit.png��6�     ImageButtonTemplate#��[ 6�   $
 Hand��6  6  �� 5R      $	��250��6   $	��350��6,   $
��Left=�68   $ 15��6S   $	 170��6e   $ 40��6v   $	��Top=�6�   ��5S      �� 5T      -   5        % ��Name$% txtcon��5T   H     	traindesc#��[ 6%   5U      5W      5Y      5Z        5^   
   -   5        $! 	btn_cepin��5^   �   $" btn_cepin_Click��6
  $	 628��6    $	 900��61   $	��125��6D   $��25��6P   $$# /resource/img/record_tab_A.png��6\   $$$ /resource/img/record_tab_A.png��6�   #��[ 6�   $
 Hand��6�   6
    5a   
   -   5        $! btn_xunlian��5a   �   $" btn_xunlian_Click��6  $	 628��6    $
 1030��61   $	��125��6E   $��25��6Q   $$# /resource/img/record_tab_B.png��6]   $$$ /resource/img/record_tab_B.png��6�   #��[ 6�   $
 Hand��6�   6    5c   
   -   5        $! btn_backmain��5c   �   $" btn_backmain_Click��6�   $	 680��6   $
 1050��60   $	��134��6D   $��39��6P   $"# /resource/img/exit_index.png��6\   $"$ /resource/img/exit_index.png��6�   #��[ 6�   $
 Hand��6  5d      5e      