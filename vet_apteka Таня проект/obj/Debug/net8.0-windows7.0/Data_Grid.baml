   M S B A M L   `   `   `  ����[  Wvet_apteka Таня проект, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullS.clr-namespace:vet_apteka_Таня_проект vet_apteka_Таня_проект  5   	   0    *vet_apteka_Таня_проект.Data_Grid   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   @local.clr-namespace:vet_apteka_Таня_проект     5   	   c _MahApps.Metro.IconPacks.Core, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ag cMahApps.Metro.IconPacks.Material, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137a:Icon-http://metro.mahapps.com/winfx/xaml/iconpacks   5   	     � WindowStartupLocation$  CenterScreen=�5       � WindowStyle$
 None=�6?    � AllowsTransparency$
 True��5	   	   
������  � Title$ 	Data_Grid��5
   	   $	��650��6   $
��1080��6(   .��5      �  � ColumnDefinitions 5   
   �� 5      $��1* �6   �� 5      $��3* �6   .+�5   
   ��  �� CornerRadius$ 	10 0 0 10��6   ��5      �� 5       �� 
StartPoint$	 0,0&�6&    �� EndPoint$	 1,1&�67   .��5      �  � Color$ #3AA9AD��6#   	 � Offset$	 0Q�63   � 5      $ #3AADA1��6#   $	 1Q�63   5      5      � 5   
   .+�5      �� .+�5      � 
 � Points
 �    -1 �� ;X�����#4EB1B6$	��273��6H   $	��234��6U    �� Left$ 4��6a   
 �� Top$ 78��6q    J� RenderTransformOrigin$ 0.345,0.552&�6�   $��Center=�6�   $	��Top=�6�   z�5      V� 5       .~�5!      �� �� 5"      �� 5#       �� Angle$ -0.638Q�6.   T� 5$       T� X$ 0.157Q�61    T� Y$ -19.979Q�6;   5%      5'      � 5(      '
 �    �� �� ���� ��
�����#4EB1B6$	 -18��6N   A� 5)      $��200 490 0 0q�6   $��40��6/   $��40��6:   ���#4EB1B6$ -0.983,1.118&�6U   A� 5*      $��
50 400 0 0q�6   $��20��6.   $��20��69   ���#4EB1B66E   5+      �� 5,      .+�5-      �� $
��Left=�6   $��20, 28, 0, 35q�64      	topButton#��[  6K   .��5.      .  (MahApps.Metro.IconPacks.PackIconMaterial     Kind$
 Menu=�6,   $��30��68   $��30��6C   5/      �� 50      -   5         ��Name$
 user��50      $!��Личный кабинет��6'     button_panel#��[ 6@   �� 51      -   5        $ korzina��51      $��Корзина��6*   #��[ 6<   �� 52      -   5        $ zakaz��52      $��Заказы��6(   #��[ 69   �� 53      -   5        $
 exit��53      $��
Выход��68   #��[ 6H   54      55      �� 56   
   ���#ffffff$��1��6&   $ 	0 10 10 0��66   ._�57      �� $��Center=�6   .+�58      �� $'��!Редакция каталога��6     	titleText#��[ 65   ���#3AA9AD6X   &   System.Windows.Controls.DataGrid  59      -   5          Name$ DGrid��59         AutoGenerateColumns$ False��6*      
IsReadOnly$
 True��6F   
�������$��0,20,0,0q�6l   $��2��6~   $	��450��6�   $	��772��6�      Columns 5:      0  *System.Windows.Controls.DataGridTextColumn  5;      ,  &System.Windows.Controls.DataGridColumn   Header$ id��6-      Width5  /System.Windows.Controls.DataGridLengthConverter$ 10 6Y   1  +System.Windows.Controls.DataGridBoundColumn   Binding 69   �� *
id_product+6f     5<      $' !Название продукта��6-   $	 200 6i    6H   �� *name_product+6w     5=      $ Категория��6-   $	 150 6]    6@   �� *
category+6k     5>      $ Количество��6-   $	 100 6a    6A   �� *kolichestvo+6o     5?      $ Цена��6-   $	 100 6U    6;   �� *price+6c   4  .System.Windows.Controls.DataGridTemplateColumn  5@      $
 auto 61      CellTemplate 5A      �� 5B   "   .R�5C   &   �� $��BtnEdit��6�   -   5        $ ��Редактировать��5C   -     dgridbutton#��[ 6E   $	��160��6j   $��60��6v   6�   5D   #   5F      5H      �� 5I      -   5        $��Изменить��5I        
mainbutton#��[ 6:   $	��224��6^   5J      5K      � 5M   
   $��1��6    � RowDefinitions 5N      �� 5O      $��50 �6    �� 5P      $��* �6    .+�5R      �  5S      �� 5T      $��* �6'   �� 5U      $��50 �6'   �� 5V      $��50 �6'   �� 5W      $��50 �6'   .+�5Z      �� -   5        $ btn_min��5Z      $��1��6*   
������ 
������   imgClose#��[ 6n   .��5[      �� $��/Images/line active1.png��6   5\      �� 5^      -	   5        $ btn_max��5^      $��2��6*   
������ 
������ #��[ 6m   .��5_      �� $��/Images/stop.png��6   $��10q�66   5`      �� 5a      -
   5        $ 	btn_close��5a      $��4��6,   
������ 
������ #��[ 6o   .��5b      �� $��/Images/krestick.png��6   5c      5e      5f      5g      5h      