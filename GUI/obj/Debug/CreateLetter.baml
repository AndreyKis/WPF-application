   M S B A M L   `   `   `  ����  GUI    GUI.CreateLetter   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5        N� Title$  CreateLetter��5       � 	Resources 5
       �� 
TargetType �� Property �� Value��%�   '��       '�� I     �� 5   
   " ��6   .�5      ��  � ��$	 0,1q�6(   5      �� 5   
   " ��6   .�5      ��  � ��$ DemiBold"�6+   5      5      .��5      � 
������� � RowDefinitions 5   
   �� 5      $��34 �6   .+�5   
   �� $��Компания:��6   $
��Left=�6$   $	��Top=�6?   $��6,3,0,0q�6W   $��27��6h   �� 5   
   $
��Left=�6   $��23��6-   $��85,6,0,0q�69    �� TextWrapping$
 Wrap=�6K   $��TextBox��6_   $	��Top=�6n   $	��255��6�   �� 5   
   $��Формат:��6   $
��Left=�6"   $��
7,97,0,-88q�6=   $	��Top=�6Q   $��26��6i   �� 5   
   $��Stretch=�6   $��85,101,96,-89q�61    �� Text$ TextBox��6H   �� 5%   
   $��Отрасль:��6   $
��Left=�6#   $��7,127,0,-118q�6>   $	��Top=�6T   $��26��6l   �� 5&   
   $��Stretch=�6   $��85,160,96,-148q�61   �� 5.   
   $��	Язык:��6   $��8,156,300,-147q�6    $��26��68   �� 5/   
   $��Stretch=�6   $��85,131,96,-119q�61   $ TextBox��6I   �� 53   
   $��	Кому:��6   $
��Left=�6    $��
7,30,0,-26q�6;   $	��Top=�6O   $��31��6g   �� 54   
   $��Stretch=�6   $��85,35,96,-23q�60   $
 Wrap=�6F   $��TextBox��6Z   �� 55   
   $��(Петрову И.О.)��6   $��DemiBold"�6)   $
��Left=�6?   $��252,33,0,-26q�6Z   $��28��6p   �� 57   
   
�������$��1��6#   $��14,190,14,-156q�6.   �� 58   
   
�������$��1��6#   $��14,229,14,-195q�6.   �� 59   
    �� Orientation$ 
Horizontal=�6   $��5,194,-5,-193q�6.   .+�5:      �� $��	Дата:��6   $
��Left=�6$   $��3,0,0,0q�6?   $	��Top=�6P   $��27��6h   (  "System.Windows.Controls.DatePicker  5;      $��25��6   $��	38,0,33,0q�6%   5<      �� 5=   
   $ 
Horizontal=�6   $��-1,206,1,-203q�6.   .+�5>      �� $��Подготовить��6   $��26,31,5,-20q�6+   $��78��6@   �� 5?      $��Создать��6   $��
5,31,5,-20q�6'   $��63��6;   �� 5@      $��Просмотр��6   $��
5,31,5,-20q�6(   $��63��6<   �� 5A      $��Печать��6   $��
5,31,5,-20q�6&   $��63��6:   5C      �� 5D   
   $��Проект:��6   $
��Left=�6"   $��
7,68,0,-59q�6=   $	��Top=�6Q   $��26��6i   �� 5E   
   $��Stretch=�6   $��85,71,96,-59q�61   $ TextBox��6G   �� 5F   
   
�������$��1��6#   $��14,64,14,-30q�6.   5H      5I      