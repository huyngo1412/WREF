   M S B A M L   `   `   `  ����?  ;NCKH, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullC&clr-namespace:NCKH.UserControlsElementNCKH.UserControlsElement  5      +    %NCKH.UserControlsElement.UcCreateNode   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      8local&clr-namespace:NCKH.UserControlsElement     5      -   5          >�Name$  UscCreateNode��5	      $	��195��5         MainViewModel � DataContext# [  5
      .��5      � -   5         �Name$ 	Grid_Node��5       � RowDefinitions 5   
   �� 5      $
��auto �6   6,   �� 5      $
��auto �6   6-   �� 5      $
��auto �6   6-   .+�5   
   �� -   5         ��Name$ Chk_Click_Create_Node��5      $��5q�5      $��Click��5      5   9   � 5   
   $��1��6   $��5,5,0,0q�6   .+�5      �� $��Coordinates(x,y)��6     
GroupStyle#��[ 5      .��5      ��  �� Orientation$ 
Horizontal=�6   .+�5      �� -   5         ��Name$ txb_Coordinates��5      $��20��5      $	��150��5      
���   �$��0,5,0,0q�5        	BlackText#��[ 5       ��5      �� *Position[0]+.��5!      ��5"      �� 5#       �� 
TargetType" ��6$    �� Triggers 5$   "   �� 5%   &   	 �� Binding	 62   �� *	IsChecked+
 �� ElementName$
 	Chk_Click�� �� Value True6g   .a�5&   *   ��  �� Property � {� �� Value .  6F   5'   '   �� 5(   &   	 62   �� *	IsChecked+$
 	Chk_Click��	 False6g   .a�5)   *   ��  � {� . 6F   5*   '   5,      .��5-   )   5.      50      51      52      � 54   
   $��2��6   .+�55      �� -   5         ��Name$ 	btn_Apply��59      $��20��55      $��	90,5,60,5q�56      $��Apply��57      $��10(�58      ��5:      �� *
CreateNode+��5;      �� $
 UscCreateNode��5<      �� 5=      $��20��6   $��	145,5,5,5q�5>      $��Close��5?      $��10(�5@      ��5A      �� *CloseFormNodes+6:   5B      5C      5D      