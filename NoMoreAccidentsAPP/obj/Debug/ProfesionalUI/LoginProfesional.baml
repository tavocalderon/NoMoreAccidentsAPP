   M S B A M L   `   `   `  ����M  INoMoreAccidentsAPP, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullS.clr-namespace:NoMoreAccidentsAPP.ProfesionalUI NoMoreAccidentsAPP.ProfesionalUI  5   	   )    #NoMoreAccidentsAPP.LoginProfesional   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   @local.clr-namespace:NoMoreAccidentsAPP.ProfesionalUI     5   	     � Title$  LoginProfesional��5   	   $	��495��6"   $	��445��6/    � WindowStyle$
 None=�5	   	    � 
ResizeMode$ NoResize=�5
   	    � WindowStartupLocation$ CenterScreen=�5   	   
������  � AllowsTransparency . .��5      ��  �� CornerRadius$ 12��6   ��5   
   �� 5       �� ImageSource$� �C:\Users\gcalderon\Downloads\NoMoreAccidentsAPP-20230920T133540Z-001\NoMoreAccidentsAPP\NoMoreAccidentsAPP\IMG\fondoventanas.jpeg��6    j� Stretch$
 Fill=�5      ._�5   
   �� $ 10��6   $��2q�5       J� Opacity$
 0.95Q�5      ��5      �� 5      	 �� 
StartPoint$		 0,0&�6&   
 �� EndPoint$	
 1,1&�67   .��5      �  � Color$ #462AD8��6#    � Offset$ 0Q�63   � 5      $ #DA34AE��6#   $
 0.75Q�63   � 5      $ #8A16C1��6#   $ 1Q�63   5      ��5!      �� 5"      $		 0,1&�6&   $	
 1,0&�67   .��5#      � $ #060531��6#   $ 0Q�63   � 5$      $ #1B1448��6#   $ 1Q�63   5%      ._�5(      �  � RowDefinitions 5)      �� 5*      $��30 �6$   �� 5+      .+�5.      � $��0��6    � ColumnDefinitions 50      �� 51      �� 52      $��25 �6+   �� 53      $��25 �6+   �� 54      $��5 �6+   .+�57      �� 
�������$��10(�59       $��
Montserrat)�5:       $��0��5;       $��Center=�5<       $��10,0,0,0q�5=       �� 63   $�ACCESO ��67   �� 6H   $�PROFESIONAL��6L   6b   �� 5?      -   5         ��Name$ btnMinimizarProfesional��5?      $��0q�5@      $��-��5A      
�������$��16(�5C      $��
Montserrat)�5D       � Cursor$
 Hand��5E      $��1��5F      $��30��5G      $��Bottom=�5H      ��5K      �� 5L       �� 
TargetType" ��6$   .�5M   "   ��  �� Property � �� �� Value �#28AEED6?    �� Triggers 5N   "   P� 5O   &    P� Property �@J�IsMouseOver P� Value . . �5P   *   ��  � �� �#278BEF6G   5Q   '   5S      ��5V      �� 5W       �� 
TargetType" ��6.   .R�5X   "   �� $��18��6)   $��18��64   $ 9��5Y   )   #��z��5Z   )   ._�5[   &   �� $��Center=�67   $��Center=�5\   7   5]   #   5^      5a      �� 5c      -   5        $ btnCerrarProfesional��5c      $��0q�5d      $��X��5e      
�������$��12(�5g      $��
Montserrat)�5h      $
 Hand��5i      $��2��5j      ��5m      �� 5n      " ��6$   .�5o   "   ��  � �� �#DA34AE6?    5p   "   P� 5q   &    �@J�IsMouseOver . . �5r   *   ��  � �� �#C62DAE6G   5s   '   5u      ��5x      �� 5y      " ��6.   .R�5z   "   �� $��18��6)   $��18��64   $ 9��5{   )   #��z��5|   )   ._�5}   &   �� $��Center=�67   $��Center=�5~   7   5   #   5�      5�      5�      �� 5�      $
��Auto��6   $��1��5�       �� Orientation$ Vertical=�5�      $��
28,3,43,18q�5�      .+�5�      �� $���zC:\Users\gcalderon\Downloads\NoMoreAccidentsAPP-20230920T133540Z-001\NoMoreAccidentsAPP\NoMoreAccidentsAPP\IMG\logonma.png��6   $	��145��5�      $	��100��6(   $
��Left=�65   $��	125,0,0,0q�6P    J� RenderTransformOrigin$ 
0.73,0.495&�6c   �� 5�      $��ACCESO PROFESIONAL��6    
�������$��25(�5�       $��Medium"�5�       $��
Montserrat)�5�       $��Center=�5�       �� 5�      $��INGRESE SUS CREDENCIALES��6    
�������$��12(�5�       $��Medium"�5�       $��
Montserrat)�5�       $
��Wrap=�5�        �� TextAlignment$ Center=�5�       $��0,5,0,0q�5�       �� 5�      $��Username��6    
�������$��12(�5�       $��Medium"�5�       $��
Montserrat)�5�       $��0,35,0,0q�5�       �� 5�      -   5         ��Name$ txtUsuarioProfesional��5�      $��13(�5�      $��Medium"�5�      $��
Montserrat)�5�      
������� �� 
CaretBrush
 �����
�������$��0,0,0,2q�5�      $��28��5�      $��Center=�5�      $��0,5,0,0q�5�      $��20,0,0,0q�5�      .��61   ��5�      �� 5�      $� |C:\Users\gcalderon\Downloads\NoMoreAccidentsAPP-20230920T133540Z-001\NoMoreAccidentsAPP\NoMoreAccidentsAPP\IMG\user-icon.png��6)   $
 None=�5�   )    j� 
AlignmentX$
 Left=�5�   )   .��5�   .   5�      �� 5�      $��Password��6    
�������$��12(�5�       $��Medium"�5�       $��
Montserrat)�5�       $��0,15,0,0q�5�       G� 5�      -   5         G�Name$ txtPasswordProfesional��5�   "   $��13(�5�      $��Medium"�5�      $��
Montserrat)�5�      
������� G� 
CaretBrush
 �����
�������$��0,0,0,2q�5�      $��28��5�      $��Center=�5�      $��0,5,0,0q�5�      $��20,0,0,0q�5�      ��5�      �� 5�      $� {C:\Users\gcalderon\Downloads\NoMoreAccidentsAPP-20230920T133540Z-001\NoMoreAccidentsAPP\NoMoreAccidentsAPP\IMG\key-icon.png��6)   $
 None=�5�   )   $
 Left=�5�   )   5�      �� 5�      -   5        $ btnLoginProfesional��5�      $��0q�5�      $��LOG IN��5�      
�������$��12(�5�      $��
Montserrat)�5�      $
 Hand��5�      $��0,50,0,0q�5�      ��5�      �� 5�      " ��6$   .�5�   "   ��  � �� �#462AD86?    5�   "   P� 5�   &    �@J�IsMouseOver . . �5�   *   ��  � �� �#28AEED6G   5�   '   5�      ��5�      �� 5�      " ��6.   .R�5�   "   �� $	��150��6)   $��40��65   $ 20��5�   )   #��z��5�   )   ._�5�   &   �� $��Center=�67   $��Center=�5�   7   5�   #   5�      5�      �� 5�      $ 
Horizontal=�6!   $��Center=�5�   !   $��0,15,0,0q�5�   !   .+�5�      �� $��Forgot Password?��6$   
�������$��12(�5�       $��Medium"�5�       $��
Montserrat)�5�       $��22��68   �� 5�      $��Reset��6$   
�������$��12(�5      $��Medium"�5      $��
Montserrat)�5      $
 Hand��5      $��8,0,0,0q�5      5     5	     5     5     5     5     