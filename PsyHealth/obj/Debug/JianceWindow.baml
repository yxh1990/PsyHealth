   M S B A M L   `   `   `  ����D  @PsyHealth, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:PsyHealth	PsyHealth  5   	   -clr-namespace:PsyHealth.libPsyHealth.lib  5   	   M IWPFVisifire.Charts, Version=5.1.7.0, Culture=neutral, PublicKeyToken=nullM9clr-namespace:Visifire.Charts;assembly=WPFVisifire.ChartsVisifire.Charts 5   	       PsyHealth.JianceWindow   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:PsyHealth     5   	   0locallibclr-namespace:PsyHealth.lib     5   	   Hvc9clr-namespace:Visifire.Charts;assembly=WPFVisifire.Charts     5   	   Y UDynamicDataDisplay, Version=0.3.0.0, Culture=neutral, PublicKeyToken=5b7d744a7263923f=d34http://research.microsoft.com/DynamicDataDisplay/1.0  5
   	   -   5          N� Title$  JianceWindow��5   	   $
��1366��6   $	��768��6+    � 	Resources 5       �� MergedDictionaries �� Source�� 5   
    5      �� 5      $ /style/maincss.xaml?�6%   �� 5      $ /style/xuexi.xaml?�6%   %    5       N� 
Background 5      �� 5   
    �� ImageSource$&  /resources/img/SPCS_XLCLS_DT.bmp��6    j� Stretch$
 Fill=�6E   6V   .��5      �� -   5         ��Name$ maincontent��5      .+�5   
      PsyHealth.lib.ImageButton  -   5          Name$ btn_hrv��5   �      PsyHealth.lib.ImageButton	   Click$	 btn_hrv_Click��6  

 �� Top$	
 180��6    �� Left$	 585��60   $��50��6C   $��46��6N      ImgPath$, &/resources/img/SPCS_XLCLS_AN_HRV_C.bmp��6Z      MouseOverImgPath$, &/resources/img/SPCS_XLCLS_AN_HRV_B.bmp��6�      ImageButtonTemplate#��[  6�   6    5   
   -   5        $ 	btn_maibo��5   �   $	 btn_maibo_Click��6	  $	
 250��6   $	 585��60   $��50��6C   $��46��6N   $+ %/resources/img/SPCS_XLCLS_AN_XZ_A.bmp��6Z   $+ %/resources/img/SPCS_XLCLS_AN_XZ_B.bmp��6�   #��[  6�   6	    5   
   -   5        $ 
btn_result��5   �   $	 btn_result_Click��6
  $	
 320��6   $	 585��60   $��50��6C   $��46��6N   $+ %/resources/img/SPCS_XLCLS_AN_JT_A.bmp��6Z   $+ %/resources/img/SPCS_XLCLS_AN_JT_B.bmp��6�   #��[  6�   6
    5   
   $	
 450��6   $	 585��60   $��56��6C   $��20��6N   $+ %/resources/img/SPCS_XLCLS_AN_KS_A.bmp��6Z   $+ %/resources/img/SPCS_XLCLS_AN_KS_B.bmp��6�   #��[  6�     5   
   -   5        $ btn_set��5   �   $	 btn_set_Click��6  $	
 475��6   $	 585��60   $��56��6C   $��20��6N   $+ %/resources/img/SPCS_XLCLS_AN_SZ_A.bmp��6Z   $+ %/resources/img/SPCS_XLCLS_AN_SZ_B.bmp��6�   #��[  6�   6  �� 5!   
   -   5        $ 
userconfig��5!       K� ZIndex$ 20��6%   $	
 250��67   $	 400��6H   $	��194��6Z   $	��203��6f   $y�Hidden=�6s   ��5"      �� 5#      $# /resources/img/SPCS_SZ_DT.bmp��6   $
 Fill=�6J   6[   .+�5%      	�  	� 	GroupName$ 
radiomusic��6   $ 92��62   $
 38��6D   $��30��6T   $��30��6_     RadioButton#���  6k    d� 	IsChecked$
 TrueY�6�   .��5&      �� -   5         ��Name$ radiomusic1��5&      $��15��6.   $��15��69   $	��0,5q�6E   $%��/resources/img/SPCS_AN_YD_A.bmp��6R   5'      	� 5(      $ 
radiomusic��6   $	 149��62   $
 38��6D   $��30��6T   $��30��6_   #���  6k   .��5)      �� -	   5        $ radiomusic2��5)      $��15��6.   $��15��69   $	��0,5q�6E   $%��/resources/img/SPCS_AN_YD_B.bmp��6R   5*      	� 5+      $ radioxiaoguo��6   $ 92��64   $
 72��6F   $��30��6V   $��30��6a   #���  6m   $
 TrueY�6�   .��5,      �� -
   5        $ radioxg1��5,      $��15��6+   $��15��66   $	��0,5q�6B   $%��/resources/img/SPCS_AN_YD_A.bmp��6O   5-      	� 5.      $ radioxiaoguo��6   $	 149��64   $
 72��6F   $��30��6V   $��30��6a   #���  6m   .��5/      �� -   5        $ radioxg2��5/      $��15��6+   $��15��66   $	��0,5q�6B   $%��/resources/img/SPCS_AN_YD_B.bmp��6O   50      �� 51      -   5         ��Name$ sliderVolume��51      $ 83��6,   $	
 117��6>   $��55��6O   $��10��6Z    � Maximum$	 100Q�6f    � Minimum$ 0Q�6t   52      �� 53      -   5         ��Name$ txtmusicpath��53      $	
 148��6,   $ 76��6=   $��80��6N   $��20��6Y   $	��Top=�6e    �� TextAlignment$ Center=�6}   .��6�   /data/test.mp36�     54      -   5        $ btn_checkfile��54   �   $	 btn_checkfile_Click��6  $	
 153��6#   $	 160��64   $��15��6G   $��15��6R   $, &/resources/img/SPCS_SZ_DKAN_YYXZ_A.bmp��6^   $, &/resources/img/SPCS_SZ_DKAN_YYXZ_B.bmp��6�   #��[  6�   6    56      -   5        $ btn_ok��56   �   $	 btn_ok_Click��6�   $	
 180��6#   $ 30��64   $��56��6F   $��20��6Q   $% /resources/img/SPCS_AN_YY_A.bmp��6]   $% /resources/img/SPCS_AN_YY_B.bmp��6�   #��[  6�   6�     57      -   5        $ 
btn_cancle��57   �   $	 btn_cancle_Click��6
  $	
 180��6#   $	 100��64   $��56��6G   $��20��6R   $* $/resources/img/SPCS_HXZS_AN_TC_A.bmp��6^   $* $/resources/img/SPCS_HXZS_AN_TC_B.bmp��6�   #��[  6�   6
  58      r� 5:   
   -   5         r�Name$ media1��5:       r� LoadedBehavior$ Manual=�6(    r� UnloadedBehavior$
 Stop=�6y    r� Stretch$
 Fill=�6�    r� Volume 6A   ��  �� ElementName$ sliderVolume�� �� Path$ Value�6�   � 5<   
   -   5         �Name$ hrv_grid��5<      $	
 137��6!   $ 92��62   $	��540��6C   $	��405��6O   .+�5=      8  2Microsoft.Research.DynamicDataDisplay.ChartPlotter  -   5          Name$ plotter��5=      $��1q�6/   $	��430��6:   $	��370��6F       HorizontalAxis  5>      I  CMicrosoft.Research.DynamicDataDisplay.Charts.HorizontalDateTimeAxis  5?      -   5        $��dateAxis��5?   0   !   VerticalAxis! 5A      K  EMicrosoft.Research.DynamicDataDisplay.Charts.Axes.VerticalIntegerAxis  5B      -   5        $��	countAxis��5B   -   3  -Microsoft.Research.DynamicDataDisplay.Plotter"   Children." 5E      2  ,Microsoft.Research.DynamicDataDisplay.Header  $��Arial)�6   $��Bug Information��6/   =  7Microsoft.Research.DynamicDataDisplay.VerticalAxisTitle  5F      $��Arial)�6'   $��Count��6:   ?	  9Microsoft.Research.DynamicDataDisplay.HorizontalAxisTitle	  5G      $��Arial)�6)   $
��Date��6<   5H      5I      � 5K   
   -   5        $ 
maibo_grid��5K      $	
 137��6#   $ 92��64   $	��540��6E   $	��405��6Q   $y�Hidden=�6^   5L      � 5N   
   -   5        $ result_grid��5N      $	
 137��6$   $ 92��65   $	��540��6F   $	��405��6R   $y�Hidden=�6_   5O      �� 5R   
   -   5        $ 	Userstate��5R      $	
 195��6#   $	 790��65   $(��"/resources/img/SPCS_XLCLS_XZ_H.bmp��6H   $	��121��6t   $	��106��6�     5U   
   -   5        $ btn_zhushou��5U   �   $	 btn_zhushou_Click��6  $	
 520��6   $	 790��60   $	��136��6C   $��40��6O   $' !/resources/img/SPCS_AN_HXZS_A.bmp��6[   $' !/resources/img/SPCS_AN_HXZS_B.bmp��6�   #��[  6�   6  �� 5V   
   -   5        $ hxcon��5V   M   $	 700��6   $	
 280��6#   $	��310��64   $	��373��6@   $y�Hidden=�6\   $ 50��6p   ��5W      �� 5X      $) #/resources/img/SPCS_TCK_DT_HXZS.bmp��6   $
 Fill=�6P   6a   .+�5Z      �� -   5        $ hximg��5Z      $%��/resources/img/SPCS_HXZS_SL.bmp��6#   $	��265��6L   $	��256��6X   $ 20��6f   $
 43��6w   r� 5[      -   5        $ videoMediaElement��5[      $
 43��66   $ 20��6F   $	��268��6W   $	��256��6c   $ Manual=�6p   $y�Hidden=�6�     5]      -   5        $ btn_qiehuan��5]   �   $	 btn_qiehuan_Click��6  $	
 305��6#   $	 220��64   $��72��6G   $��20��6R   $, &/resources/img/SPCS_HXZS_AN_QHZS_A.bmp��6^   $, &/resources/img/SPCS_HXZS_AN_QHZS_B.bmp��6�   #��[  6�   6  �� 5^      $	
 330��6   $ 76��6)   频率：5s6A     5_      -   5        $ 
btn_kaishi��5_   �   $	 btn_kaishi_Click��6
  $	
 345��6#   $ 12��64   $��56��6F   $��20��6Q   $+ %/resources/img/SPCS_XLCLS_AN_KS_A.bmp��6]   $+ %/resources/img/SPCS_XLCLS_AN_KS_B.bmp��6�   #��[  6�   6
  �� 5`      -   5        $ sliderspeed��5`      $	 130��6+   $	
 342��6>   $	��100��6O   $��30��6[   $ 7Q�6g   $ 3Q�6s   6�     5a      -    5        $ 
btn_tuichu��5a   �   $	 btn_tuichu_Click��6�   $	
 345��6#   $	 240��64   $��56��6G   $��20��6R   $% /resources/img/SPCS_AN_TC_A.bmp��6^   $% /resources/img/SPCS_AN_TC_B.bmp��6�   #��[  6�   6�   5b      � 5f      -!   5        $��Simon��5f      $	
 305��6   $	 700��60   $	��300��6B   $	��200��6N   .+�5g      
  Visifire.Charts.Chart
  $	��200��6   $	��180��6$   # 
  Theme$# Theme1��61   $ 
  View3D$ . % 
  BorderThickness$% 0q�6N   & 
  
Background
& ���� ' 
  LightingEnabled' .  ( 
  Series( 5i         Visifire.Charts.DataSeries  )   RenderAs$	) Pie=�6$   *   LabelEnabled$* FalseY�63   +   Bevel$+ FalseY�6H   ,   ShowInLegend$, FalseY�6V   -   
DataPoints- 5k        Visifire.Charts.DataPoint  .   
AxisXLabel$. Yahoo��6+   /   YValue0  *Visifire.Commons.Converters+ValueConverter$
/ 16.7 6>     5l      $. Google��6+   $
/ 68.6 6?     5m      $. MSN/Live��6+   $	/ 8.7 6A     5n      $	. Ask��6+   $	/ 3.7 6<     5o      $	. AOL��6+   $	/ 1.7 6<     5p      $. Others��6+   $	/ 0.6 6?   5r      5t      5u        5x   
   -"   5        $ 	btn_xuexi��5x   �   $	 btn_xuexi_Click��6  $	
 597��6   $ 75��60   $	��105��6B   $	��138��6N   $( "/resources/img/SPCS_AN_XDLJS_A.bmp��6[   $( "/resources/img/SPCS_AN_XDLJS_B.bmp��6�   #��[  6�   6    5y   
   $	
 597��6   $	 240��60   $	��105��6B   $	��138��6N   $( "/resources/img/SPCS_AN_XLCLS_C.bmp��6[   $( "/resources/img/SPCS_AN_XLCLS_C.bmp��6�   #��[  6�     5z   
   -#   5        $ btn_xunlian��5z   �   $	 btn_xunlian_Click��6  $	
 597��6   $	 405��60   $	��105��6B   $	��138��6N   $' !/resources/img/SPCS_AN_XLZX_A.bmp��6[   $' !/resources/img/SPCS_AN_XLZX_B.bmp��6�   #��[  6�   6    5{   
   -$   5        $ btn_jilu��5{   �   $	 btn_jilu_Click��6   $	
 597��6   $	 565��60   $	��105��6B   $	��138��6N   $' !/resources/img/SPCS_AN_CKJL_A.bmp��6[   $' !/resources/img/SPCS_AN_CKJL_B.bmp��6�   #��[  6�   6     5~   
   -%   5        $ Btn_backIndex��5~   �   $	 Btn_backIndex_Click��6  $	
 690��6   $	 832��60   $	��136��6B   $��40��6N   $( "/resources/img/SPCS_AN_FHZJM_A.bmp��6Z   $( "/resources/img/SPCS_AN_FHZJM_B.bmp��6�   #��[  6�   6  5      5�      