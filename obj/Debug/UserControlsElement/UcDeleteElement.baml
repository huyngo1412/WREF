   M S B A M L   `   `   `  ����?  ;NCKH, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullC&clr-namespace:NCKH.UserControlsElementNCKH.UserControlsElement  5      .    (NCKH.UserControlsElement.UcDeleteElement   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      8local&clr-namespace:NCKH.UserControlsElement     5      $	��195��5      .��5	      �   � RowDefinitions  5
   
   �� 5      $
��auto �6   6,   �� 5      $
��auto �6   6-   �� 5      $
��auto �6   6-   .+�5   
   � $��0��6   $��0��6   $��0,5,0,0q�6,   .+�5      �� $
��Type��6      
GroupStyle#��[  6%   .��5      �   5      �� 5      6*   �� 5      6*   �� 5      6*   �� 5      6*    � ColumnDefinitions 5      �� 5      $
��auto �6+   6:   �� 5      $
��auto �6+   6:   .+�5      	� -   5         	�Name$ rad_picking_node��5$      $��5q�5      $��0��5      $��0��5       $��Picking��5!      $��10(�5"      $��-1q�5#       d� 	IsChecked$ FalseY�5%      5(      �� 5)      $��Element Number :��6    $��1��5*       $��0��5+       $��10(�5,       $��9,5,0,0q�5-       63   �� 5.      $��1��5/       $��1��50      $��95��51        	BlackText#��[ 52      .��6F   ��53      �� 54       �� 
TargetType" ��6$    �� Triggers 55   "   �� 56   &    �� Binding 62   �� *	IsChecked+ �� ElementName$ rad_picking_node�� �� Value	 False6n   .a�57   *   �� 	 �� Property	 � {�
 �� Value
 .  6F   58   '   �� 59   &    62   �� *	IsChecked+$ rad_picking_node�� True6n   .a�5:   *   �� 	 � {�
 . 6F   5;   '   5=      .��5>   )   5?      	� 5@      -   5        $ rad_selection_node��5H      $��5,10,0,0q�5A      $��2��5B      $��0��5C      $��2��5D      $��	Selection��5E      $��10(�5F      $��-1q�5G      $
 TrueY�5I      5L      �� 5M      $��5,10,0,0q�5N      $��3��5O      $��0��5P      $��2��5Q      $��Only Free Node��5R      $��10(�5S      $��-1q�5T      $
 TrueY�5U      5W      5X      5Y      5[      � 5\   
   $��1��6   .+�5^      �� $��20��6   $��	90,5,60,5q�5_      $��Apply��5`      $��10(�5a      6%   �� 5b      $��20��6   $��	145,5,5,5q�5c      $��Close��5d      $��10(�5e      ��5f      �� *CloseFormNodes+6:   5g      5h      5i      