   M S B A M L   `   `   `  ����D  @PsyHealth, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:PsyHealth	PsyHealth  5   	   -clr-namespace:PsyHealth.libPsyHealth.lib  5   	       PsyHealth.RecordWindow   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:PsyHealth     5   	   0locallibclr-namespace:PsyHealth.lib     5   	     N� Title$  JianceWindow��5	   	   $
��1024��6   $	��760��6+    � 	Resources 5
       �� MergedDictionaries �� Source�� 5   
    5      �� 5      $ /style/maincss.xaml?�6%   �� 5      $ /style/xuexi.xaml?�6%   %    5       N� 
Background 5      �� 5   
    �� ImageSource$% /resources/img/SPCS_XLJL_DT.bmp��6    j� Stretch$
 Fill=�6D   6U   .��5      �� .+�5   
   &   System.Windows.Controls.DataGrid  -   5        $��	dataGrid1��5   R   
 �� Top$	 137��6    �� Left$ 65��6$   	   AutoGenerateColumns	 .  $	��Top=�6d   
   CanUserSortColumns
 .  $	��885��5   /      
IsReadOnly .    CanUserResizeColumns .     CanUserResizeRows .     SelectionMode$ Single=�5   K      CanUserReorderColumns .   �� AlternationCount$ 2��5   1      RowHeaderWidth$ 0Q�6G      CanUserAddRows .     Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ 序号��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$ 70 61   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6=   �� *
AddrName+  5      $ 训练内容��6%   $	 125 65    6B   �� *
CityName+  5      $ 训练难度��6%   $	 125 64    6A   �� *TelNum+  5      $ 训练时间��6%   $	 125 64    6A   �� *
TotalSum+  5       $	 高��6%   $ 75 61    6=   �� *
AddrName+  5!      $	 中��6%   $ 75 61    6=   �� *
AddrName+  5"      $	 低��6%   $ 75 61    6=   �� *
AddrName+  5#      $ 评价分数��6%   $	 128 64    6A   �� *
AddrName+  5$      $ 结果��6%   $ 85 62    6>   �� *
AddrName+5&         PsyHealth.lib.ImageButton  5(   
   -   5          Name$ 	btn_xuexi��5(   �      PsyHealth.lib.ImageButton   Click$ btn_xuexi_Click��6  $	 597��6   $ 75��60   $	��105��6B   $	��138��6N      ImgPath$( "/resources/img/SPCS_AN_XDLJS_A.bmp��6[      MouseOverImgPath$( "/resources/img/SPCS_AN_XDLJS_B.bmp��6�      ImageButtonTemplate#��[  6�   6    5)   
   -   5        $ 
btn_jiance��5)   �   $ btn_jiance_Click��6  $	 597��6   $	 240��60   $	��105��6B   $	��138��6N   $( "/resources/img/SPCS_AN_XLCLS_A.bmp��6[   $( "/resources/img/SPCS_AN_XLCLS_B.bmp��6�   #��[  6�   6    5*   
   -   5        $ btn_xunlian��5*   �   $ btn_xunlian_Click��6  $	 597��6   $	 405��60   $	��105��6B   $	��138��6N   $' !/resources/img/SPCS_AN_XLZX_A.bmp��6[   $' !/resources/img/SPCS_AN_XLZX_B.bmp��6�   #��[  6�   6    5+   
   $	 597��6   $	 565��60   $	��105��6B   $	��138��6N   $' !/resources/img/SPCS_AN_CKJL_C.bmp��6[   $' !/resources/img/SPCS_AN_CKJL_C.bmp��6�   #��[  6�     5.   
   -   5        $ Btn_backIndex��5.   �   $ Btn_backIndex_Click��6  $	 690��6   $	 832��60   $	��136��6B   $��40��6N   $( "/resources/img/SPCS_AN_FHZJM_A.bmp��6Z   $( "/resources/img/SPCS_AN_FHZJM_B.bmp��6�   #��[  6�   6  5/      50      