   M S B A M L   `   `   `  ����D  @PsyHealth, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:PsyHealth	PsyHealth  5   	   -clr-namespace:PsyHealth.libPsyHealth.lib  5   	       PsyHealth.XueXiWindow   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:PsyHealth     5   	   0locallibclr-namespace:PsyHealth.lib     5   	     N� Title$  XueXiWindow��5	   	   $
��1024��6   $	��760��6*    � 	Resources 5
       �� MergedDictionaries �� Source�� 5   
    5      �� 5      $ /style/maincss.xaml?�6%   �� 5      $ /style/xuexi.xaml?�6%   %    5       N� 
Background 5      �� 5   
    �� ImageSource$&  /resources/img/SPCS_XDLJS_DT.bmp��6    j� Stretch$
 Fill=�6E   6V   .��5      �� .+�5   
   �� -   5         ��Name$ 
videobgimg��5      
 �� Top$	 137��6$   	 �� Left$	 92��65   $*��$/resources/img/SPCS_XDLJS_SPTP_D.bmp��6F   $	��540��6t   $	��405��6�   r� 5   
   -   5        
 r�Name$
 videoScreenMediaElement��5      $	 137��68   $	 92��6I   $	��540��6Z   $	��405��6f    r� LoadedBehavior$ Manual=�6�   $y�Hidden=�6�    r� Volume 6t   ��  �� ElementName$ volumeSlider�� �� Path$ Value�6�      PsyHealth.lib.ImageButton  5   
   $	 597��6   $	 75��60   $	��105��6B   $	��138��6N      ImgPath$( "/resources/img/SPCS_AN_XDLJS_C.bmp��6[      MouseOverImgPath$( "/resources/img/SPCS_AN_XDLJS_C.bmp��6�      ImageButtonTemplate#��[  6�     5   
   -   5          Name$ 
btn_jiance��5   �      PsyHealth.lib.ImageButton   Click$ btn_jiance_Click��6  $	 597��6   $		 240��60   $	��105��6B   $	��138��6N   $( "/resources/img/SPCS_AN_XLCLS_A.bmp��6[   $( "/resources/img/SPCS_AN_XLCLS_B.bmp��6�   #��[  6�   6    5   
   -   5        $ btn_xunlian��5   �   $ btn_xunlian_Click��6  $	 597��6   $		 405��60   $	��105��6B   $	��138��6N   $' !/resources/img/SPCS_AN_XLZX_A.bmp��6[   $' !/resources/img/SPCS_AN_XLZX_B.bmp��6�   #��[  6�   6    5   
   -   5        $ btn_jilu��5   �   $ btn_jilu_Click��6   $	 597��6   $		 565��60   $	��105��6B   $	��138��6N   $' !/resources/img/SPCS_AN_CKJL_A.bmp��6[   $' !/resources/img/SPCS_AN_CKJL_B.bmp��6�   #��[  6�   6     5!   
   $ btn_play_Click��6�   $	 105��6   $		 670��60   $	��136��6B   $��40��6N   $0 */resources/img/SPCS_XDLJS_AN_ZZPHSBF_A.bmp��6Z   $0 */resources/img/SPCS_XDLJS_AN_ZZPHSBF_B.bmp��6�   #��[  6�   6�     5"   
   -   5        $ 
btn_yinian��5"   Q  $ btn_play_Click��6:  $	 168��6   $		 776��60   $	��110��6B   $��26��6N   $. (/resources/img/SPCS_XDLJS_AN_JZZYL_A.bmp��6Z   $. (/resources/img/SPCS_XDLJS_AN_JZZYL_B.bmp��6�      DisableImgPath$. (/resources/img/SPCS_XDLJS_AN_JZZYL_C.bmp��6�   #��[  6	  6Q    5#   
   -   5        $ btn_huxi��5#   7  $ btn_huxi_Click��6I  $	 208��6   $		 823��60   $	��110��6B   $��26��6N   $, &/resources/img/SPCS_XDLJS_AN_SHX_A.bmp��6Z   $, &/resources/img/SPCS_XDLJS_AN_SHX_B.bmp��6�   $, &/resources/img/SPCS_XDLJS_AN_SHX_C.bmp��6�   #��[  6  6I    5$   
   -   5        $ 
btn_ganqin��5$   8  $ btn_ganqin_Click��6L  $	 248��6   $		 875��60   $	��110��6B   $��26��6N   $- '/resources/img/SPCS_XDLJS_AN_QGZY_A.bmp��6Z   $- '/resources/img/SPCS_XDLJS_AN_QGZY_B.bmp��6�   $- '/resources/img/SPCS_XDLJS_AN_QGZY_C.bmp��6�   #��[  6  6L    5'   
   -	   5        $ btn_play��5'   �   $ btn_play_Click��6
  $	 543��6   $	 95��60   $��29��6A   $��29��6L   $+ %/resources/img/SPCS_XDLJS_AN_KS_A.bmp��6X   $+ %/resources/img/SPCS_XDLJS_AN_KS_B.bmp��6�   #��[  6�   6
    5(   
   -
   5        $ 	btn_pause��5(   �   $ btn_pause_Click��6  $	 543��6   $	 95��60   $��29��6A   $��29��6L   $+ %/resources/img/SPCS_XDLJS_AN_TZ_A.bmp��6X   $+ %/resources/img/SPCS_XDLJS_AN_TZ_B.bmp��6�   #��[  6�   $y�Hidden=�6#  �� 5)   
   -   5         ��Name$ volumeSlider��5)      $	 552��6'   $		 462��68     Slider_CustomStyle#��[ 6K   $	��140��6w   $��10��6�    � Value$ 20Q�6�    � Minimum$ 0Q�6�    � Maximum$	 100Q�6�     5,   
   -   5        $ Btn_backIndex��5,   �   $ Btn_backIndex_Click��6  $	 690��6   $		 832��60   $	��136��6B   $��40��6N   $( "/resources/img/SPCS_AN_FHZJM_A.bmp��6Z   $( "/resources/img/SPCS_AN_FHZJM_B.bmp��6�   #��[  6�   6  5-      5.      