   M S B A M L   `   `   `  ���� >  :GUI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:GUIGUI  clr-namespace:GUIGUI      GUI.CustomCalendar   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     yclr-namespace:GUI     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     !guiclr-namespace:GUI     ���	#ffefefef  � 	Resources   �� MergedDictionaries �� Source   HeaderButtonTemplate �� 
TargetType � Cursor'  !System.Windows.VisualStateManager   VisualStateGroups%  System.Windows.VisualStateGroup   States   System.Windows.VisualState   
Storyboard g� Duration  GlyphMouseOver		 �� To
 �� TargetProperty �� 
TargetName	 W� To ��Name  calItemStyle �� 
TargetType5  /System.Windows.Controls.Primitives.CalendarItem �� Property �� Value � 	Resources  Key ��Name �� BasedOn  CustomCalendarItem  NewStyle �� Color �� CornerRadius � RowDefinitions � ColumnDefinitions  PreviousButtonTemplate  NextButtonTemplate �Name ��Name J� Opacity �� Stretch �� RadiusX �� RadiusY  DisabledColor �� Triggers P� Property  P� Value! �� 
TargetName" �� Value# �� Binding$ �� Path% �� RelativeSource& �� Mode' �� AncestorType&   System.Windows.Controls.Calendar 	 DefaultCalendar( F�Name) �� Triggers* ��Name+  Name��  �� $ DataGridStyles.xaml?�%�  &	        &	 ~    &	 �    7 7   &	 V    7  7   7  7  7  &		 �
    7  '  �    7  7   7  7  7  '  r    �� " ��.R�� $
 Hand��   CommonStates��.   
Normal��  	MouseOver��. �� .���� $ 0D�#	 �  $G
 A(TextElement.Foreground).                 (SolidColorBrush.Color)�$ buttonContent��  Disabled��. �� .��W� $ 0D�$ .5X�$
 Opacity�$ buttonContent��.+��� $ buttonContent��$��1,4,1,9q�#��z��#��z��
���  ��#��z��#��z���� "  .���  � �� �� "   ���� DayTitleTemplate .R��� $
��Bold"�$��Verdana)�$	��9.5(����	#FF333333$��Center=�$��0,6,0,6q�$��Center=����� .R�]� $��	PART_Root����. .+��� $ PART_PreviousButton��$
��Left=�$��<��|�.  $y�Hidden=��� 8   "  .���  � �� �� "   ���� PART_HeaderButton .R��� $ PART_HeaderButton��8�� $��Center=�$��Center=�$
��Bold"�$
��10.5(�|�.  
���  ���� "  .���  � ��$ 0,3,0,3q���  � �� �� "   ���� DayTitleTemplate .R��� $
��Bold"�$��Verdana)�$	��9.5(����	#FF333333$��Center=�$��0,6,0,6q�$��Center=����� .R�� $��	PART_Root��  ���� DisabledColor $ Black��   CommonStates��.   
Normal��  Disabled��. �� .��W� $ PART_DisabledVisual��$
 Opacity�$ 1X�$ 0D�.+��� #��z��#��z��#��z��$ 1��._��� $ 1�����	#FFFFFFFF$��2q�._��  �� $
��Auto ��� $��* � �� $
��Auto ��� $
��Auto ��� $
��Auto �.+��� $ PART_PreviousButton��$��0��$��0��8��  $��20��$��28��$
��Left=�|�.  �� $ PART_HeaderButton��$��0��$��1��8�� $��Center=�$��Center=�$
��Bold"�$
��10.5(�|�.  �� $ PART_NextButton��$��0��$��2��$��20��$��28��$��Right=�8�� |�.  � $ PART_MonthView��$��1��$��3��$y�Visible=�$��6,-1,6,6q� �� $
��Auto ��� $
��Auto ��� $
��Auto ��� $
��Auto ��� $
��Auto ��� $
��Auto ��� $
��Auto � �� $
��Auto ��� $
��Auto ��� $
��Auto ��� $
��Auto ��� $
��Auto ��� $
��Auto ��� $
��Auto �� $ PART_YearView��$��1��$��3��$y�Hidden=�$��6,-3,7,6q� �� $
��Auto ��� $
��Auto ��� $
��Auto � �� $
��Auto ��� $
��Auto ��� $
��Auto ��� $
��Auto ��� $ PART_DisabledVisual��$ 0Q�$y�	Collapsed=�$
 Fill=�$��1��$ 2��$ 2��8�� 8��  P�  � {�  .  . ��� $! PART_DisabledVisual�� � y�$ Visible=��� $
" Year��# �� $$ DisplayMode�% �� $& FindAncestor=�"'  .a��� $! PART_MonthView�� � y�$ Hidden=��� $! PART_YearView�� � y�$ Visible=��� $" Decade��# �� $$ DisplayMode�% �� $& FindAncestor=�"'  .a��� $! PART_MonthView�� � y�$ Hidden=��� $! PART_YearView�� � y�$ Visible=��� "  .���  � �� �� "  .R��� $��	PART_Root��$��Center=�.+��� $��20��$��0,0,0,-3q�
������
�������$��Сегодня��$&�� gui:CalendarCommands.SelectToday��$	��173������ % �� $& TemplatedParent=�  $��PART_CalendarItem��#��z��#��z��$��0,0,0,0q�8��  �� "  .���  � �� �� "   ���� (��       **(CalendarItem.DayTitleTemplateResourceKey+).R��� 
���   �$��Normal"�$��12(�$��Center=�$��0,5,0,5q�$��Center=����� .R�� $ 	PART_Root��  ���� DisabledColor $ White��   CommonStates��.   
Normal��  Disabled��. �� .��W� $ 0D�$ 1X�$
 Opacity�$ PART_DisabledVisual��.+��� #��z��#��z��#��z��$ 1��._��� ���	#FFFFFFFF$��0q�$ 0��._��   ���� PreviousButtonTemplate " ��.R�� $
 Hand��   CommonStates��.   
Normal��  	MouseOver��. �� .���� $ 0D�$	 WhiteX�$�
 }(Shape.Fill).                                                                                         (SolidColorBrush.Color)�$
 path��  Disabled��. �� .��W� $ 0D�$ .5X�$|
 v(Shape.Fill).                                                                                          (Brush.Opacity)�$
 path��.+��� 
������ $ 1Q�$
 Fill=�� .+�F� $
( path��"�����5���Ѱ�5h�W��<�h�	
�������$
��Left=�$��10��$��6��$��15,0,0,4q�$
 Fill=�$��Center=��� NextButtonTemplate " ��.R�� $
 Hand��   CommonStates��.   
Normal��  Disabled��. �� .��W� $ 0D�$ .5X�$"
 (Shape.Fill).(Brush.Opacity)�$
 path��.+��� 
������ $ 1Q�$
 Fill=�� .+�F� $
( path��"����xT��!��xT���S�h4 	
�������$��Right=�$��10��$��0,0,15,4q�$
 Fill=�$��Center=�$��6���� HeaderButtonTemplate " ��.R�� $
 Hand��   CommonStates��.   
Normal��  	MouseOver��. �� .��W� $ 0D�$ .7X�$
 Opacity�$ buttonContent��.+��� $ buttonContent��#��z��#��z��
�������$��Segoe UI)�#��z��$��0,0,0,4q�#��z���� TodayButtonTemplate " ��.R�� $
 Hand��   CommonStates��.   
Normal��  	MouseOver��. �� .��W� $ 0D�$ .7X�$
 Opacity�$ buttonContent��.+��� $ buttonContent��#��z��#��z��
�������$��Segoe UI)�#��z��$��0,0,0,4q�#��z�� �� $
��Auto ��� $
��Auto ��� $
��Auto � �� $��28 ��� $��28 ��� $	��150 �.+��� $��TodayBtn��-   $��Сегодня��$��3��$��15(�$��	10,0,10,1q�$��0q����� " �����  � ��
 ������  � ��
 �������  � �� �� " ��.R��� #��z��
������ $��0q�#��z��._��� $��Center=�$��Center=�) P�  �@J�IsMouseOver  . . ���  � ��
 ������  � ��
 ��ح���  �@�Cursor$
 Hand��� $��1��$��3��
������$��Stretch=�$��	10,1,10,0q�.+��� $ PART_PreviousButton��$��0��|�.  $
��Left=�$��20��$��0��8��  $��28���� $ PART_HeaderButton��$��1��$��Normal"�|�.  $��15(�$��Center=�$��0��8�� $��Center=��� $ PART_NextButton��$��2��|�.  $��Right=�$��20��$��0��8�� $��28��� $ PART_MonthView��$��3��$��Center=�$��13,5,13.333,0q�$��2��$y�Visible=�$	��147�� �� $
��Auto ��� $
��Auto ��� $
��Auto ��� $
��Auto ��� $
��Auto ��� $
��Auto ��� $
��Auto � �� $
��Auto ��� $
��Auto ��� $
��Auto ��� $
��Auto ��� $
��Auto ��� $
��Auto ��� $
��Auto �� $ PART_YearView��$��3��$��Center=�$��6,1,7.333,6q�$��2��$y�Hidden=�$��2��$	��160�� �� $
��Auto ��� $
��Auto ��� $
��Auto ��� $
��Auto � �� $
��Auto ��� $
��Auto ��� $
��Auto ��� $ PART_DisabledVisual��8�� $ 0Q�$ 2��$ 2��$
 Fill=�8�� $��1��$y�	Collapsed=� P�  � {�  .  . ��� $! PART_DisabledVisual�� � y�$ Visible=��� $
" Year��# �� *DisplayMode+% �� *FindAncestor+"'  .a��� $! PART_MonthView�� � y�$ Hidden=��� $! PART_YearView�� � y�$ Visible=��� $" Decade��# �� *DisplayMode+% �� *FindAncestor+"'  .a��� $! PART_MonthView�� � y�$ Hidden=��� $! PART_YearView�� � y�$ Visible=��� "  .���  � ��
 ���� ��  �@J�SnapsToDevicePixels . ��  � ��
 �   ���  � ��$ 0q���  � �� �� "  .R��� $* 	PART_Root��$��Center=�.+�  $+ PART_CalendarItem��#��z��#��z��#��z��.���� ._��  �� $	��207 ��� $��0* ��� $��5* ��� $��36 ��� $
��487* �.+�(� -   $��	CalViewBx��$y�Visible=�$��0��.��  -   $	��Cal��$y�Visible=�$��
0,0, 0, -5q��� 
������$��1��$��1��$��19,-34,19,0q��� -   $��SelectedDateTxtBx��$��2��$
��Bold"�$��	0,-13,0,0q�
������ {�.  , �� TextAlignment$, Center=�$��14(�
���   ��� -   $��CalDgrvScroll��$��4��$��4,10,4,0q�  ��%�   '��       �� " ��.���  �@��IsFlicksEnabled . ) P�  �@��Orientation$  Vertical=�. ���  � ��$ 13����  � ��$ 10��.��&   System.Windows.Controls.DataGrid  -   -  Name$- CalDGRV��$��0,0,0,0q�.   AutoGenerateColumns. .  /   HeadersVisibility$
/ None=�0   SelectionMode$0 Single=�1   GridLinesVisibility$
1 None=�$��0q�
������  
 TimeCellStyle2   	CellStyle#2 [
 "3   VerticalScrollBarVisibility$3 Hidden=�$4   HorizontalScrollBarVisibility$4 Hidden=����� *id+  ��%    5   Columns5 4  .System.Windows.Controls.DataGridTemplateColumn  ,  &System.Windows.Controls.DataGridColumn6   Width5	  /System.Windows.Controls.DataGridLengthConverter$6 20	 7   CellTemplate7 �� .R��� 8 ��Name$8 toRedact��$��Center=�$��0,-2,0,0q�$
��Wrap=�$��SemiBold"�$��14(����� *hour+  $6 17	 7 �� .R��� $��0,0,0,1q�
�������._��� $��Center=�$��2,0,2,0q�$
��Wrap=�$��SemiBold"�$��10(����� *minute+  $6 1*	 7 �� .R��� $��0,0,0,1q�
�������$��0q�._��� $��1,1,1,1q�
���   �$��2,1,2,1q�._��� $, Center=�$��11(����� *id1+���� *actionOfID1+  $6 1*	 7 �� .R��� $��0,0,0,1q�
�������$��0q�._��� $��1,1,1,1q�
���   �$��2,1,2,1q�._��� $, Center=�$��11(����� *id2+���� *actionOfID2+  $6 1*	 7 �� .R��� $��0,0,0,1q�
�������$��0,0,0,0q�._��� $��1,1,1,1q�
���   �$��2,1,2,1q�._��� $, Center=�$��0,0,0,0q�$��11(����� *id3+���� *actionOfID3+� $��3��$��0,0,0,0q� �� $	��51* ��� $	��39* ��� $	��39* ��� $	��51* � �� .+��� 
������$��0��$��1��$��2��$��3,3,3,32q��� -   $��IdCallTxtBxBrdr��$��0��$��0��$��
4,-10,2,20q�
������$y�Hidden=����	#ffefefef$��3q�._��� -   $��IdCallTxtBx��9 J� 	AllowDrop9 . $, Center=�$��24453��$��13(�$��0,0,0,0q�n� -	   $��Thumb1��$��0��$��0��$y�Visible=�$
 Hand��$ 0Q�$��
4,-10,2,20q��� -
   $��IdMeetingTxtBxBrdr��$��0��$��
2,-10,4,20q�
��� ���$��3q�$y�Hidden=����	#ffefefef$��3��._��� -   $��IdMeetingTxtBx��$, Center=�$��23452��$��13(�$��0,0,0,0q�n� -   $��Thumb2��$��3��$��0��$y�Visible=�$
 Hand��$ 0Q�$��
2,-10,4,20q��� $��3,10,1,0q�
������$��3q�$��1��._��� -   $��CallsAmountTxtBx��9 . 
�������$
��Bold"�$, Center=�$��15��$��15(�$	��0,0q��� $��2��$��0��
��� ���$��3q�$��1,10,3,0q�._��� -   $��MeetingsAmountTxtBx��$, Center=�
�������$
��Bold"�$��15��$��15(�