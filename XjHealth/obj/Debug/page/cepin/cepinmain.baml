   M S B A M L   `   `   `  ����C  ?XjHealth, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:XjHealth.page.cepinXjHealth.page.cepin  5   	   +clr-namespace:XjHealth.libXjHealth.lib  5   	   #    XjHealth.page.cepin.cepinmain   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   3local!clr-namespace:XjHealth.page.cepin     5   	   /locallibclr-namespace:XjHealth.lib     5   	   -   5          N� Title$  心际之芯��5	   	   $
��1366��6   $	��768��6#    � 	Resources 5
       �� MergedDictionaries �� Source�� 5   
    5      �� 5      $ /style/maincss.xaml?�6%   %    5       N� 
Background 5      �� 5   
    �� ImageSource$$ /resource/img/scale_second.png��6    j� Stretch$
 Fill=�6C   6T   .��5      �� .+�5   
   �� $	��210��6   $	��220��6!    �� Left$	 210��6.   
 �� Top$	 200��6@   .+�5       �� -   5        	 ��Name$	 title0��5    8      
ScaleTitle#��[  6   .��6H   焦虑自评6N   �� 5!      -   5        
 ��Name$
 desc0��5!   i     	ScaleDesc#��[ 6   $
��Wrap=�6<   $	��190��6P   $	��220��6\   ��简便省时、易于掌握，能较为准确而迅速的反映出被试个人主观感受到的焦虑程度，用于被测试者对自身焦虑状况的了解，也用于焦虑症患者治疗前后的情况比较。6�   5"      �� 5#   
   $	��210��6   $	��220��6!   $	 460��6.   $	 200��6@   .+�5$      �� -   5        $	 title1��5$   8   #��[  6   .��6H   汉密顿焦虑6O   �� 5%      -   5        $
 desc1��5%   i   #��[ 6   $
��Wrap=�6<   $	��190��6P   $	��220��6\   ��由Hamilton于1959年编制，它是精神科临床中常用的量表之一，于评定神经症及其他病人的焦虑症状的严重程度。6�   5&      �� 5'   
   $	��210��6   $	��220��6!   $	 720��6.   $	 200��6@   .+�5(      �� -   5        $	 title2��5(   8   #��[  6   .��6H   青少年压力自评6Q   �� 5)      -   5        $
 desc2��5)   i   #��[ 6   $
��Wrap=�6<   $	��190��6P   $	��220��6\   ��主要用于发现青少年学生中存在的心理压力过大问题，对于家长和教师帮助青少年学生积极地预防和调整由压力引发的心理疾病提供参考资料。6�   5*      �� 5+   
   $	��210��6   $	��220��6!   $	 980��6.   $	 200��6@   .+�5,      �� -   5        $	 title3��5,   8   #��[  6   .��6H   压力应对方式问卷6R   �� 5-      -	   5        $
 desc3��5-   i   #��[ 6   $
��Wrap=�6<   $	��190��6P   $	��220��6\   ��以帮助个体了解自己常采用的应对方式，为被测试者改善自己的压力应对方式，从而减缓压力事件对个体产生的不良心理的影响提供依据。6�   5.         XjHealth.lib.ImageButton  50   
   -
   5          Name$ btnTest1��50   �      XjHealth.lib.ImageButton   Click$ ImageButton_Click��6	  $	 550��6   $	 220��60   $	��121��6C   $��31��6O      ImgPath$$ /resource/img/scale_test_1.png��6[      MouseOverImgPath$$ /resource/img/scale_test_1.png��6�     ImageButtonTemplate#��[ 6�    � Cursor$
 Hand��6�   6	    51   
   -   5        $ btnTest2��51   �   $ ImageButton_Click��6	  $	 550��6   $	 490��60   $	��121��6C   $��31��6O   $$ /resource/img/scale_test_1.png��6[   $$ /resource/img/scale_test_1.png��6�   #��[ 6�   $
 Hand��6�   6	    52   
   -   5        $ btnTest3��52   �   $ ImageButton_Click��6	  $	 550��6   $	 760��60   $	��121��6C   $��31��6O   $$ /resource/img/scale_test_1.png��6[   $$ /resource/img/scale_test_1.png��6�   #��[ 6�   $
 Hand��6�   6	    53   
   -   5        $ btnTest4��53   �   $ ImageButton_Click��6	  $	 550��6   $
 1020��60   $	��121��6D   $��31��6P   $$ /resource/img/scale_test_1.png��6\   $$ /resource/img/scale_test_1.png��6�   #��[ 6�   $
 Hand��6�   6	    55   
   -   5        $ btn_backmain��55   �   $ btn_backmain_Click��6�   $	 680��6   $
 1050��60   $	��134��6D   $��39��6P   $" /resource/img/exit_index.png��6\   $" /resource/img/exit_index.png��6�   #��[ 6�   $
 Hand��6  56      57      