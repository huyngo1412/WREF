   M S B A M L   `   `   `  ����?  ;NCKH, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullC&clr-namespace:NCKH.UserControlsElementNCKH.UserControlsElement  5      ,    &NCKH.UserControlsElement.UcConcreteMat   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      8local&clr-namespace:NCKH.UserControlsElement     5      -   5          >�Name$  
UcConcrete��5
      $	��500��5      
������    MainViewModel � DataContext# [  5      .��5      � -   5         �Name$ Grid_Data_Concreate��5       � ColumnDefinitions 5   
   �� 5      $	��275 �6   6-   �� 5      $	��175 �6   6-    � RowDefinitions 5   
   �� 5      $��35 �6   6*   �� 5      $��35 �6   6*   �� 5      $��35 �6   6*    � 	Resources 5   
     txb �� 
TargetType �� Property �� Value 
 txbPro��%�  &	       &	     �� 5      " ��6    .�5      ��  � ��$ 10(�6-   6:   �� 5       � �� 6)   �� *Unit+6B   �� 5       �@��Padding$ 5q�6,   68   �� 5       � ��$ 	90,5,20,5q�6+   6?   �� 5       � ��
 ���� 6E   5      �� 5      " ��6#   .�5       ��  � ��$ 10(�6-   6:   �� 5!       �@��Padding$ 5q�6,   68   �� 5"       � ��$ 	10,5,50,0q�6+   6?   �� 5#       � ��
 ���� 6E   5$      5%      .+�5&   
   �� $��0��6   $��0��5'      $��Modulus of Elasticity, E ��5(      #��[ 5*      6>   �� 5+   
   -   5        	 ��Name$	 txb_Modulus_Concreate��5/      $��0��5+      $��1��5,      $��0,5,90,5q�5-      
�������$��10(�50      52      �� 53   
   $��0��6   $��1��54      #��[ 55      6;   �� 57   
   $��1��6   $��0��58      $5��/Specified Concreate Compressive Strength, f'c :��59      #��[ 5:      6>   �� 5;   
   -   5        $	 txb_fc_Concreate��5@      $��1��5;      $��1��5<      $��0,5,90,5q�5=      
�������$��10(�5?      5B      �� 5C   
   $��1��6   $��1��5D      #��[ 5E      6<   �� 5G   
   $��2��6   $��0��5H      $��Poison's Ratio, U��5I      #��[ 5J      6>   �� 5K   
   $��2��6   $��1��5L      $��0,5,90,5q�5M      
�������$��10(�5O      5P      5R      5S      