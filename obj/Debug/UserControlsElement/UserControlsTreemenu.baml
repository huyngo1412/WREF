   M S B A M L   `   `   `  ����?  ;NCKH, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullC&clr-namespace:NCKH.UserControlsElementNCKH.UserControlsElement  5      3    -NCKH.UserControlsElement.UserControlsTreemenu   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      8local&clr-namespace:NCKH.UserControlsElement     5      
������ .��5
      � $��0,5,0,0q�6     � RowDefinitions  5   
   �� 5      $
��auto �6   6,   �� 5      $��* �6   6)   .+�5   
   �� $��0��6   $��25��6!    �� Padding$ 
100,3,00,0q�5      $��	Tree Menu��5         
DarkButton#��[  6-     DarkText#��[ 5      $��2,2,0,3q�6C   6V   �� 5   
   -   5         ��Name$ Tab_TreeMenu��5   F   $��1��6\     LightBackGround#���  5      .@�5      �� $
��Node��6     TabItemStyle#��[ 6%   .��5      �   5      �� 5      $
��auto �6(   68   �� 5      $
��auto �6)   69   �� 5      $��* �6)   66    � ColumnDefinitions 5      �� 5       $	��200 �6+   69   �� 5!      $��50 �6+   68   .+�5#      �� -   5         ��Name$ btn_DataGridNodes��5#      $��20��5$   !   $��1��5%   !   $��
10,10,15,0q�5&   !   $	��...��5'   !   61   � 5(      $��0��6   $��0��6(   .+�5*      �� -   5         ��Name$ cb_Nodes��5+      $��0��5,      $��20��5-      $��	10,10,0,0q�5.      .@�51      �� $��Create Nodes��6+   53      �� 54      $��Delete Nodes��6+   55      �� 56      $��Translate Nodes��6+   57      58      59      � 5:      $��1��6   $��0��6(   $��0,5,0,0q�5;       5<      �� 5=      61   �� 5>      61   .+�5@      �� $��10(�6$   
���   �$��10,5,45,0.2q�5B   $   $��0��5C   $   $��2��64   Start Node Numbers :6^   �� 5D      -   5         ��Name$ txb_StartNode��5D   "   $��1��5E   !   $��15��5F   !   $��50,0,0,0q�5G   !   {�.    	BlackText#��[ 5I   "   $�� ��5J   !   6+   5K      � 5L      -   5         �Name$ UcNode��5L      $��2��6+   5M      5N      5O      �� 5P      $��Element��6   #��[ 6'   .��5Q      �   5R      �� 5S      $
��auto �6(   68   �� 5T      $
��auto �6)   69   �� 5U      $
��auto �6)   69    5X      �� 5Y      $	��200 �6+   69   �� 5Z      $��50 �6+   68   .+�5]      � $��0��6   $��0��6(   .+�5_      �� -   5        $ 
cb_Element��5`      $��0��5a      $��20��5b      $��
10,10,10,0q�5c      .@�5f      �� $��Create Element��6+   5h      �� 5i      $��Delete Element��6+   5j      �� 5k      $��Translate Element��6+   5l      5m      5n      �� 5o      -   5        $ btn_DataGridElement��5o      $��20��5p   !   $��1��5q   !   $��
10,10,15,0q�5r   !   $	��...��5s   !   61   � 5u      -   5        $ 	UcElement��5u      $��2��6.   $��0,10,0,0q�5v      6/   5w      5x      5z      5{      5|      