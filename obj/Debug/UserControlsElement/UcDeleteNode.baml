   M S B A M L   `   `   `  ����?  ;NCKH, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullC&clr-namespace:NCKH.UserControlsElementNCKH.UserControlsElement  5      +    %NCKH.UserControlsElement.UcDeleteNode   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      8local&clr-namespace:NCKH.UserControlsElement     5      $	��195��5   
      MainViewModel  � DataContext#  [  5	      .��5      �  � RowDefinitions 5   
   �� 5      $
��auto �6   6,   �� 5      $
��auto �6   6-   �� 5      $
��auto �6   6-   .+�5   
   � $��0��6   $��0��6   $��5,5,0,0q�6,   .+�5      �� $
��Type��6     
GroupStyle#��[ 6%   .��5      �  5      �� 5      6*   �� 5      6*   �� 5      6*   �� 5      6*    � ColumnDefinitions 5      �� 5      $
��auto �6+   6:   �� 5      $
��auto �6+   6:   .+�5      	� -   5         	�Name$ rad_picking_node��5&      $��5q�5       $��0��5!      $��0��5"      $��Picking��5#      $��10(�5$      $��-1q�5%       d� 	IsChecked$ FalseY�5'      5*      �� 5+      $��Node Number :��6    $��1��5,       $��0��5-       $��10(�5.       $��10,5,0,0q�5/       
���   �50   5   �� 51      $��1��52       $��1��53      $��95��54        	BlackText#��[ 55      .��6F   ��56      �� 57       �� 
TargetType" ��6$    �� Triggers 58   "   �� 59   &    �� Binding 62   �� *	IsChecked+ �� ElementName$ rad_picking_node��	 �� Value		 False6n   .a�5:   *   �� 
 �� Property
 � {� �� Value .  6F   5;   '   �� 5<   &    62   �� *	IsChecked+$ rad_picking_node��	 True6n   .a�5=   *   �� 
 � {� . 6F   5>   '   5@      .��5A   )   5B      	� 5C      -   5        $ rad_selection_node��5K      $��5,10,0,0q�5D      $��2��5E      $��0��5F      $��2��5G      $��	Selection��5H      $��10(�5I      $��-1q�5J      $
 TrueY�5L      5O      �� 5P      $��5,10,0,0q�5Q      $��3��5R      $��0��5S      $��2��5T      $��Only Free Node��5U      $��10(�5V      $��-1q�5W      $
 TrueY�5X      5Z      5[      5\      5^      � 5_   
   $��1��6   .+�5a      �� $��20��6   $��	90,5,60,5q�5b      $��Apply��5c      $��10(�5d      6%   �� 5e      $��20��6   $��	145,5,5,5q�5f      $��Close��5g      $��10(�5h      ��5i      �� *CloseFormNodes+6:   5j      5k      5l      