   M S B A M L   `   `   `  ����[  Wvet_apteka Таня проект, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:VET_apteka
VET_apteka  5   	       VET_apteka.Catalog   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:VET_apteka     5   	   c _MahApps.Metro.IconPacks.Core, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ag cMahApps.Metro.IconPacks.Material, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137a:Icon-http://metro.mahapps.com/winfx/xaml/iconpacks   5   
     � WindowStartupLocation$  CenterScreen=�5       � WindowStyle$
 None=�6?    � AllowsTransparency$
 True��5	   	   
������  � Title$ Catalog��5
   	   $	��650��6   $
��1080��6&   .��5      �  � ColumnDefinitions 5   
   �� 5      $��1* �6   �� 5      $��3* �6   .+�5   
   ��  �� CornerRadius$ 	10 0 0 10��6   ��5      �� 5       �� 
StartPoint$	 0,0&�6&    �� EndPoint$	 1,1&�67   .��5      �  � Color$ #3AA9AD��6#   	 � Offset$	 0Q�63   � 5      $ #3AADA1��6#   $	 1Q�63   5      5      � 5   
   .+�5      �� .+�5      � 
 � Points
 �    -1 �� ;X�����#4EB1B6$	��273��6H   $	��234��6U    �� Left$ 4��6a   
 �� Top$ 78��6q    J� RenderTransformOrigin$ 0.345,0.552&�6�   $��Center=�6�   $	��Top=�6�   z�5      V� 5      .~�5      �� �� 5      �� 5        �� Angle$ -0.638Q�6.   T� 5!       T� X$ 0.157Q�61    T� Y$ -19.979Q�6;   5"      5$      � 5%      '
 �    �� �� ���� ��
�����#4EB1B6$	 -18��6N   A� 5&      $��200 490 0 0q�6   $��40��6/   $��40��6:   ���#4EB1B6$ -0.983,1.118&�6U   A� 5'      $��
50 400 0 0q�6   $��20��6.   $��20��69   ���#4EB1B66E   5(      �� 5)      .+�5*      �� $
��Left=�6   $��20, 28, 0, 35q�64      	topButton#��[  6K   .��5+      .  (MahApps.Metro.IconPacks.PackIconMaterial     Kind$
 Menu=�6,   $��30��68   $��30��6C   5,      �� 5-      -   5         ��Name$
 user��5-      $!��Личный кабинет��6'     button_panel#��[ 6@   �� 5.      -   5        $ korzina��5.      $��Корзина��6*   #��[ 6<   �� 5/      -   5        $ zakaz��5/      $��Заказы��6(   #��[ 69   �� 50      -   5        $ redact��50      $ ��Редактировать��6<   #��[ 6T   �� 51      -   5        $
 exit��51      $��
Выход��68   #��[ 6H   52      53      �� 54   
   ���#ffff$��1��6$   � 56   
   $��1��6    � RowDefinitions 57      �� 58      $��50 �6    �� 59      $��0* �6    �� 5:      .+�5=      �  5>      �� 5?      $��* �6'   �� 5@      $��50 �6'   �� 5A      $��50 �6'   �� 5B      $��50 �6'   .+�5D      �� -   5        $ btn_min��5D      $��1��6*   
������ 
������   imgClose#��[ 6n   .��5E      �� $��/Images/line active1.png��6   5F      �� 5H      -   5        $ btn_max��5H      $��2��6*   
������ 
������ #��[ 6m   .��5I      �� $��/Images/stop.png��6   $��10q�66   5J      �� 5K      -   5        $ 	btn_close��5K      $��4��6,   
������ 
������ #��[ 6o   .��5L      �� $��/Images/krestick.png��6   5M      5O      �� 5P      $��2��6   .+�5Q      � .+�5R      �� $��Фильтр:��6    $
��Left=�6/     Text#��[ 6J   $��
10,32,0,32q�6h   �� 5S      -	   5         ��Name$ Filter��5S      $
��Left=�6]   $��110, 15, 0, 15q�6x   $��35��6�   $	��200��6�   .@�5T      �� $��Антибиотики��6%     
Text_combo#��[ 68   �� 5U      $��
Корма��6%   #��[ 62   �� 5V      $��Игрушки��6$   #��[ 63   �� 5W      $��От глистов��6$   #��[ 66   5X      �� 5Z      $��1q�6   ���#acb0af$��330,20,180,20q�6G   $ 5��6^   ._�5[      � $	��7 9q�6    5\      �� 5]   "   $
��auto �63   �� 5^   "   $��* �63   .+�5`      �� $��/Images/poisk.png��6$   $��30��6?   �� 5a      -
   5         ��Name$ txtpoisk��5a   &     textBox#��[ 68   $��1��6   $��0,0,5,0q�6�   5c      5d      �� 5e      -   5        $ export��5e      $��Экспорт��6-   $��0��6?     
mainbutton#��[ 6c   $
��Left=�6�   $��16(�6�   $��660,15,0,15q�6�   $	��110��6�   5f      �� 5h      -   5         ��Name$ VET_app��5h      $	��750��6W   $
��1060��6g   $	��760��6w   $	��550��6�   ��5i      �� 5j      .R�5k      � $	��730��6$    5l   "   �� 5m   &   $	��220 �67   �� 5n   &   $	��300 �67   �� 5o   &   $	��150 �67    5q   "   �� 5r   &   $��40 �64   �� 5s   &   $	��200 �64   �� 5t   &   $
��auto �64   .+�5v   "   �� $��Center=�6J   $%��Bahnschrift Light SemiCondensed)�6e    �� TextAlignment$ Center=�6�   $	��363��6�   $
��Wrap=�6�   $
��Left=�6�   $��25,0,0,0q�6�   $��18(�6�   $��0��6  $��0��6  $��2��6!  ��6,   �� *name_product+6!  � 5w   "   $��1��6'   $��0��64    5x   &   �� 5y   *   $	��200 �6;   �� 5z   *   $	��350 �6;   .+�5|   &   �� $��0��6E   $��0��6U   ��6,   �� *image+6U   5}   #   � 5~   "   $��1��6'   $��1��67    5   &   �� 5�   *   $��1 �68   �� 5�   *   $��25 �68   �� 5�   *   $��25 �68   �� 5�   *   $��25 �68   �� 5�   *   $��25 �68   .+�5�   &   �� $��1��6J   $��0��6W   $
 Left=�6h   $	��300��6}   $	��100��6�   $
��Left=�6�   $��16(�6�   $��3��6�   $��	0,0,0,-25q�6�   ��60   �� *
category+6�   �� 5�   &   $��В наличии:��60   $��2��6B   $��0��6O   $
 Left=�6`   $	��300��6u   $
��Left=�6�   $��16(�6�   $��0,0,0,0q�6�   $��2��6�   �� 5�   &   $��2��6M   $��0��6Z   $
 Left=�6j   $	��205��6   $	��100��6�   $
��Left=�6�   $��16(�6�   $��
85,0,0,-50q�6�   $��2��6�   ��60   �� *kolichestvo+6�   �� 5�   &   $��	Цена:��60   $��2��6=   $��0��6J   $
 Left=�6[   $	��300��6p   $
��Left=�6~   $��16(�6�   $��
0,24,0,-74q�6�   $��2��6�   �� 5�   &   $��2��6G   $��0��6T   $
 Left=�6e   $	��250��6z   $
��Left=�6�   $��16(�6�   $��48,24,0,-74q�6�   $��2��6�   ��60   �� *price+6�   �� 5�   &   $ kupit��6-   $��Купить��6<   $��4��6M   $��0��6Z   #��[ 6k   $
��Left=�6�   $��16(�6�   $��10,10,0,-40q�6�   5�   #   5�      5�      5�      5�      5�      5�      5�      