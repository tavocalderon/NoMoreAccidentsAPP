   M S B A M L   `   `   `  ����M  INoMoreAccidentsAPP, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullW0clr-namespace:NoMoreAccidentsAPP.AdministradorUI"NoMoreAccidentsAPP.AdministradorUI  5   	   (    "NoMoreAccidentsAPP.ListarAsesorias   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   Blocal0clr-namespace:NoMoreAccidentsAPP.AdministradorUI     5   	     � Title$  Menu Profesional��5   	   $	��545��6"   $	��991��6/    � WindowStyle$
 None=�5	   	    � 
ResizeMode$ NoResize=�5
   	    � WindowStartupLocation$ CenterScreen=�5   	   
������  � AllowsTransparency . .��5      ��  �� CornerRadius$ 12��6   ��5   
   �� 5       �� ImageSource$� �C:\Users\gcalderon\Downloads\NoMoreAccidentsAPP-20230920T133540Z-001\NoMoreAccidentsAPP\NoMoreAccidentsAPP\IMG\fondoventanas.jpeg��6    j� Stretch$
 Fill=�5      ._�5   
   �� -   5         ��Name$ 
LobbyAPPss��5      $ 10��6%   $��2q�5      	 J� Opacity$
	 0.95Q�5      $
��Left=�6   $	��990��67   ��5      �� 5      
 �� 
StartPoint$	
 0,0&�6&    �� EndPoint$	 1,1&�67   .��5      �  � Color$ #462AD8��6#    � Offset$ 0Q�63   � 5      $ #DA34AE��6#   $
 0.75Q�63   � 5      $ #8A16C1��6#   $ 1Q�63   5      ��5"      �� 5#      $	
 0,1&�6&   $	 1,0&�67   .��5$      � $ #060531��6#   $ 0Q�63   � 5%      $ #1B1448��6#   $ 1Q�63   5&      ._�5)      �  � RowDefinitions 5*      �� 5+      $��30 �6$   �� 5,      .+�53      � $��0��6    � ColumnDefinitions 55      �� 56      �� 57      $��25 �6+   �� 58      $��25 �6+   �� 59      $��5 �6+   .+�5<      �� $@��:NO MORE ACCIDENTS APP | LISTADO ASESORÍAS (ADMINISTRADOR)��6    
�������$��10(�5>       $��
Montserrat)�5?       $��0��5@       $��Center=�5A       $��10,0,0,0q�5B       �� 5D      -   5         ��Name$ btnMinimizarLobby��5D      $��0q�5E      $��-��5F      
�������$��16(�5H      $��
Montserrat)�5I       � Cursor$
 Hand��5J      $��1��5K      ��5N      �� 5O       �� 
TargetType" ��6$   .�5P   "   ��  �� Property � �� �� Value �#28AEED6?    �� Triggers 5Q   "   P� 5R   &    P� Property �@J�IsMouseOver P� Value . . �5S   *   ��  � �� �#278BEF6G   5T   '   5V      ��5Y      �� 5Z       �� 
TargetType" ��6.   .R�5[   "   �� $��18��6)   $��18��64   $ 9��5\   )   #��z��5]   )   ._�5^   &   �� $��Center=�67   $��Center=�5_   7   5`   #   5a      5d      �� 5f      -   5        $ btnCerrarLobby��5f      $��0q�5g      $��X��5h      
�������$��12(�5j      $��
Montserrat)�5k      $
 Hand��5l      $��2��5m      ��5p      �� 5q      " ��6$   .�5r   "   ��  � �� �#DA34AE6?    5s   "   P� 5t   &    �@J�IsMouseOver . . �5u   *   ��  � �� �#C62DAE6G   5v   '   5x      ��5{      �� 5|      " ��6.   .R�5}   "   �� $��18��6)   $��18��64   $ 9��5~   )   #��z��5   )   ._�5�   &   �� $��Center=�67   $��Center=�5�   7   5�   #   5�      5�      5�      �� 5�      $
��Auto��6    �� Orientation$ Vertical=�5�      $��8,8,8,0q�5�      $��2��6.   .+�5�      �� 
�������$��25(�5�       $��Medium"�5�       $��
Montserrat)�5�       $��Center=�5�       �� 5�      $ 
Horizontal=�6!   $��Center=�5�   !   $��0,15,0,0q�5�   !   5�      �� 5�      $��MENÚ PROFESIONAL��6   
�������$��30(�5�      $��Medium"�5�      $��
Montserrat)�5�      $��Center=�5�      $��316,23,376,448q�62   $��1��6J   $	��294��6W   �� 5�      -   5        $
��Left=�5�      $��31��65   $��
47,110,0,0q�6A   $��1��6U    �� TextWrapping$
 Wrap=�6b   $	��Top=�6v   $	��212��6�   6�   &   System.Windows.Controls.DataGrid  5�      $
��Left=�6   $	��212��66   $��
47,171,0,0q�6C   $��1��6W   $	��Top=�6d   $	��896��6|   �� 5�      $��Buscar Profesional��6   
�������$��20(�5�      $��Medium"�5�      $��
Montserrat)�5�      $��Center=�5�      $��47,83,772,406q�62   $��1��6I   $	��167��6V   �� 5�      $��Disponibilidad()��6   
�������$��20(�5�      $��Medium"�5�      $��
Montserrat)�5�      $��Center=�5�      $��556,87,264,402q�62   $��1��6J   $	��166��6W   �� 5�      
�������$��20(�5�      $��Medium"�5�      $��
Montserrat)�5�      $��Center=�5�      $��556,118,128,371q�62   $��1��6K   $	��302��6X   �� 6e   $�Fecha próxima actividad��6i   �� 6�   $�	: -------��6�   6�   5�      5�      5�      5�      