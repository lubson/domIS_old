   M S B A M L   `   `   `  ���� @  <Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null,"clr-namespace:Model;assembly=ModelModel  	 domIS   domIS.UcastnikWindow   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     4Model"clr-namespace:Model;assembly=Model     -     � Title$  Účastník��$	��618��$	��800�� � 
ResizeMode$ NoResize=� � 	Resources    ucastnikViewSource��%   &	        �� .��� .+�o� $
��Left=�$��95��$	��Top=�$	��792��.@�m� $��MenuItem����  K� ZIndex$
 -122��$��0,95,0,0q�.@��� $��Základní údaje��.��� .+��� $��Zrušit��  NormalButtonStyle#���  $��30��$	��100��$��571,424,115,10q��� -   $��Pokračovat��$��676,424,10,10q�#���  $��30��$	��100���� $��Obecné��$
��Left=�$��	10,10,0,0q�$	��Top=�$	��400��$	��380��.��� .+�� -    �Name$ grid1�� � DataContext# [  $
��Left=�$	��Top=�$ 1��$��	28,18,0,0q� � ColumnDefinitions �� $
��Auto ��� $
��Auto � � RowDefinitions �� $
��Auto �.+��� $��Jmeno:��$��0��$
��Left=�$��3q�$��0��$��Center=��� -    ��Name$ jmenoTextBox��$��1��$
��Left=�$��30��$��3q�$��0��$��Center=�$	��200������ *Jmeno+	 �� Mode$	 TwoWay=�
 �� NotifyOnValidationError
 .  �� ValidatesOnExceptions . � -   $ grid2��# [  $
��Left=�$��23,64,-211,-96q�$	��Top=� �� $
��Auto ��� $
��Auto � �� $
��Auto �.+��� $��	Prijmeni:��$��0��$
��Left=�$��3q�$��0��$��Center=��� -   $ prijmeniTextBox��$��1��$
��Left=�$��30��$��3q�$��0��$��Center=�$	��160������ *
Prijmeni+$	 TwoWay=�
 .  . � -   $ grid4��# [  $
��Left=�$��
30,134,0,0q�$	��Top=� �� �� $
��Auto � �� $
��Auto �.+��� $��Narozen:��$��0��$
��Left=�$��3q�$��0��$��Center=�(  "System.Windows.Controls.DatePicker  -     Name$ narozenDatePicker��$��1��$
��Left=�$��3q�$��0��$��Center=�   SelectedDate �� *	Narozen+$	 TwoWay=�
 .  . �� $��Kontakt��$
��Left=�$��	396,4,0,0q�$	��Top=�$	��380��$	��406���� $��Bydlení��.��� ���	#FFE5E5E5�� $��Rodina��.��� ���	#FFE5E5E5�� $��	Případy��.��� ���	#FFE5E5E5�� $��
Konzultace��.��� ���	#FFE5E5E5�� $��Historie��.��� ���	#FFE5E5E5$��0,0,-87,-47q�