   M S B A M L   `   `   `  ����M  INoMoreAccidentsAPP, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullW0clr-namespace:NoMoreAccidentsAPP.AdministradorUI"NoMoreAccidentsAPP.AdministradorUI  5   	   +    %NoMoreAccidentsAPP.LoginAdministrador   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   Blocal0clr-namespace:NoMoreAccidentsAPP.AdministradorUI     5   	     � Title$  	LoginView��5   	   $	��495��6   $	��445��6(    � WindowStyle$
 None=�5	   	    � 
ResizeMode$ NoResize=�5
   	    � WindowStartupLocation$ CenterScreen=�5   	   
������  � AllowsTransparency . .��5      ��  �� CornerRadius$ 12��6   ��5   
   �� 5       �� ImageSource$� �C:\Users\gcalderon\Downloads\NoMoreAccidentsAPP-20230920T133540Z-001\NoMoreAccidentsAPP\NoMoreAccidentsAPP\IMG\fondoventanas.jpeg��6    j� Stretch$
 None=�5      ._�5   
   �� $ 10��6   $��2q�5       J� Opacity$
 0.95Q�5      ��5      �� 5      	 �� 
StartPoint$		 0,0&�6&   
 �� EndPoint$	
 1,1&�67   .��5      �  � Color$ #462AD8��6#    � Offset$ 0Q�63   � 5      $ #DA34AE��6#   $
 0.75Q�63   � 5      $ #8A16C1��6#   $ 1Q�63   5      ��5!      �� 5"      $		 0,1&�6&   $	
 1,0&�67   .��5#      � $ #060531��6#   $ 0Q�63   � 5$      $ #1B1448��6#   $ 1Q�63   5%      ._�5(      �  � RowDefinitions 5)      �� 5*      $��30 �6$   �� 5+      .+�5.      � $��0��6    � ColumnDefinitions 50      �� 51      �� 52      $��25 �6+   �� 53      $��25 �6+   �� 54      $��5 �6+   .+�57      �� $��ACCESO ADMINISTRADOR��6    
�������$��10(�59       $��
Montserrat)�5:       $��0��5;       $��Center=�5<       $��10,0,0,0q�5=       �� 5?      -   5         ��Name$ btnMinimizarAdministrador��5?      $��0q�5@      $��-��5A      
�������$��16(�5C      $��
Montserrat)�5D       � Cursor$
 Hand��5E      $��1��5F      ��5I      �� 5J       �� 
TargetType" ��6$   .�5K   "   ��  �� Property � �� �� Value �#28AEED6?    �� Triggers 5L   "   P� 5M   &    P� Property �@J�IsMouseOver P� Value . . �5N   *   ��  � �� �#278BEF6G   5O   '   5Q      ��5T      �� 5U       �� 
TargetType" ��6.   .R�5V   "   �� $��18��6)   $��18��64   $ 9��5W   )   #��z��5X   )   ._�5Y   &   �� $��Center=�67   $��Center=�5Z   7   5[   #   5\      5_      �� 5e      -   5        $ btnCerrarAdministrador��5e      $��0q�5f      $��X��5g      
�������$��12(�5i      $��
Montserrat)�5j      $
 Hand��5k      $��1��5l      $��3��5n      $��25,0,4.667,0q�61   ��5p      �� 5q      " ��6$   .�5r   "   ��  � �� �#DA34AE6?    5s   "   P� 5t   &    �@J�IsMouseOver . . �5u   *   ��  � �� �#C62DAE6G   5v   '   5x      ��5{      �� 5|      " ��6.   .R�5}   "   �� $��18��6)   $��18��64   $ 9��5~   )   #��z��5   )   ._�5�   &   �� $��Center=�67   $��Center=�5�   7   5�   #   5�      5�      5�      �� 5�      $
��Auto��6   $��1��5�       �� Orientation$ Vertical=�5�      $��
28,3,43,18q�5�      .+�5�      �� $���zC:\Users\gcalderon\Downloads\NoMoreAccidentsAPP-20230920T133540Z-001\NoMoreAccidentsAPP\NoMoreAccidentsAPP\IMG\logonma.png��6   $	��145��5�      $	��100��6(   $
��Left=�65   $��	125,0,0,0q�6P    J� RenderTransformOrigin$ 
0.73,0.495&�6c   �� 5�      $��ACCESO ADMINISTRADOR��6    
�������$��25(�5�       $��Medium"�5�       $��
Montserrat)�5�       $��Center=�5�       �� 5�      $��INGRESE SUS CREDENCIALES��6    
�������$��12(�5�       $��Medium"�5�       $��
Montserrat)�5�       $
��Wrap=�5�        �� TextAlignment$ Center=�5�       $��0,5,0,0q�5�       �� 5�      $��Nombre��6    
�������$��12(�5�       $��Medium"�5�       $��
Montserrat)�5�       $��0,35,0,0q�5�       �� 5�      -   5         ��Name$ txtUsuarioAdministrador��5�      $��13(�5�      $��Medium"�5�      $��
Montserrat)�5�      
������� �� 
CaretBrush
 �����
�������$��0,0,0,2q�5�      $��28��5�      $��Center=�5�      $��0,5,0,0q�5�      $��20,0,0,0q�5�      .��61   ��5�      �� 5�      $� |C:\Users\gcalderon\Downloads\NoMoreAccidentsAPP-20230920T133540Z-001\NoMoreAccidentsAPP\NoMoreAccidentsAPP\IMG\user-icon.png��6)   $
 None=�5�   )    j� 
AlignmentX$
 Left=�5�   )   .��5�   .   5�      �� 5�      $��Contraseña��6    
�������$��12(�5�       $��Medium"�5�       $��
Montserrat)�5�       $��0,15,0,0q�5�       G� 5�      -   5         G�Name$ txtPasswordAdministrador��5�   "   $��13(�5�      $��Medium"�5�      $��
Montserrat)�5�      
������� G� 
CaretBrush
 �����
�������$��0,0,0,2q�5�      $��28��5�      $��Center=�5�      $��0,5,0,0q�5�      $��20,0,0,0q�5�      ��5�      �� 5�      $� {C:\Users\gcalderon\Downloads\NoMoreAccidentsAPP-20230920T133540Z-001\NoMoreAccidentsAPP\NoMoreAccidentsAPP\IMG\key-icon.png��6)   $
 None=�5�   )   $
 Left=�5�   )   5�      �� 5�      -   5        $ btnLoginAdministrador��5�      $��0q�5�      $��LOG IN��5�      
�������$��12(�5�      $��
Montserrat)�5�      $
 Hand��5�      $��0,50,0,0q�5�      ��5�      �� 5�      " ��6$   .�5�   "   ��  � �� �#462AD86?    5�   "   P� 5�   &    �@J�IsMouseOver . . �5�   *   ��  � �� �#28AEED6G   5�   '   5�      ��5�      �� 5�      " ��6.   .R�5�   "   �� $	��150��6)   $��40��65   $ 20��5�   )   #��z��5�   )   ._�5�   &   �� $��Center=�67   $��Center=�5�   7   5�   #   5�      5�      �� 5�      $ 
Horizontal=�6!   $��Center=�5�   !   $��0,15,0,0q�5�   !   .+�5�      �� $��Forgot Password?��6$   
�������$��12(�5�       $��Medium"�5�       $��
Montserrat)�5       $��22��68   �� 5     $��Reset��6$   
�������$��12(�5      $��Medium"�5      $��
Montserrat)�5      $
 Hand��5      $��8,0,0,0q�5      5
     5     5     5     5     5     