   M S B A M L   `   `   `  ����D  @PsyHealth, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:PsyHealth	PsyHealth  5   	   -clr-namespace:PsyHealth.libPsyHealth.lib  5   	       PsyHealth.XunlianWindow   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:PsyHealth     5   	   0locallibclr-namespace:PsyHealth.lib     5   	     N� Title$  JianceWindow��5	   	   $
��1024��6   $	��760��6+    � 	Resources 5
       �� MergedDictionaries �� Source�� 5   
    5      �� 5      $ /style/maincss.xaml?�6%   �� 5      $ /style/xuexi.xaml?�6%   %    5       N� 
Background 5      �� 5   
    �� ImageSource$% /resources/img/SPCS_XLZX_DT.bmp��6    j� Stretch$
 Fill=�6D   6U   .��5      �� .+�5   
   �� -   5         ��Name$ gamepic��5      
 �� Top$	 130��6!   	 �� Left$	 62��63   $+��%/resources/img/SPCS_XLZX_YST_XLZX.bmp��6E   $	��599��6t   $	��393��6�      PsyHealth.lib.ImageButton  5   
   -   5        
  Name$
 btn_puti��5   �      PsyHealth.lib.ImageButton   
MouseEnter$ btn_puti_MouseEnter��6  $	 160��6   $		 800��60   $	��110��6C   $��26��6O      ImgPath$, &/resources/img/SPCS_HUB_YXXZ_PTS_A.bmp��6[      MouseOverImgPath$, &/resources/img/SPCS_HUB_YXXZ_PTS_B.bmp��6�      ImageButtonTemplate#��[  6�   6    5   
   -   5        $
 btn_shejian��5   �   $ btn_shejian_MouseEnter��6	  $	 200��6   $		 800��60   $	��110��6C   $��26��6O   $+ %/resources/img/SPCS_HUB_YXXZ_SJ_A.bmp��6[   $+ %/resources/img/SPCS_HUB_YXXZ_SJ_B.bmp��6�   #��[  6�   6	    5   
   -   5        $
 btn_fb��5   �   $ btn_fb_MouseEnter��6  $	 240��6   $		 800��60   $	��110��6C   $��26��6O   $- '/resources/img/SPCS_HUB_YXXZ_JYFB_A.bmp��6[   $- '/resources/img/SPCS_HUB_YXXZ_JYFB_B.bmp��6�   #��[  6�   6    5   
   -   5        $
 btn_sq��5   �   $ btn_sq_MouseEnter��6  $	 280��6   $		 800��60   $	��110��6C   $��26��6O   $, &/resources/img/SPCS_HUB_YXXZ_ZYG_A.bmp��6[   $, &/resources/img/SPCS_HUB_YXXZ_ZYG_B.bmp��6�   #��[  6�   6    5   
   -   5        $
 	btn_xuexi��5   �      Click$ btn_xuexi_Click��6  $	 597��6   $	 75��60   $	��105��6B   $	��138��6N   $( "/resources/img/SPCS_AN_XDLJS_A.bmp��6[   $( "/resources/img/SPCS_AN_XDLJS_B.bmp��6�   #��[  6�   6    5    
   -   5        $
 
btn_jiance��5    �   $ btn_jiance_Click��6  $	 597��6   $		 240��60   $	��105��6B   $	��138��6N   $( "/resources/img/SPCS_AN_XLCLS_A.bmp��6[   $( "/resources/img/SPCS_AN_XLCLS_B.bmp��6�   #��[  6�   6    5!   
   $	 597��6   $		 405��60   $	��105��6B   $	��138��6N   $' !/resources/img/SPCS_AN_XLZX_C.bmp��6[   $' !/resources/img/SPCS_AN_XLZX_C.bmp��6�   #��[  6�     5"   
   -   5        $
 btn_jilu��5"   �   $ btn_jilu_Click��6   $	 597��6   $		 565��60   $	��105��6B   $	��138��6N   $' !/resources/img/SPCS_AN_CKJL_A.bmp��6[   $' !/resources/img/SPCS_AN_CKJL_B.bmp��6�   #��[  6�   6     5%   
   -	   5        $
 Btn_backIndex��5%   �   $ Btn_backIndex_Click��6  $	 690��6   $		 832��60   $	��136��6B   $��40��6N   $( "/resources/img/SPCS_AN_FHZJM_A.bmp��6Z   $( "/resources/img/SPCS_AN_FHZJM_B.bmp��6�   #��[  6�   6  5&      5'      