   M S B A M L   `   `   `  ����I  EDependencyDemo, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:DependencyDemoDependencyDemo  5   	       DependencyDemo.Window1   5   	   W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   .localclr-namespace:DependencyDemo     5   	     � Title$  Window1��5   	   $	��450��6   $	��800��6&   .��5	      �  � RowDefinitions 5
   
   �� 5      $
��20px �6   �� 5      $
��40px �6   �� 5      $
��40px �6   �� 5      $��* �6   .+�5   
   �� -   5        $��FontNameList��5       �� SelectedIndex$ 0��6'   $��0��69   .@�5      �� $��Arial��6   �� 5      $��Calibri��6   �� 5      $��Times New Roman��6   �� 5      $��Verdana��6   5      �� 5   
   -   5        $��fontSizeSlider��5       � Minimum$ 5Q�6'    � Maximum$	 100Q�63    � Value$ 10Q�6A   $��1��6L   �� 5   
   -   5        $��SizeTextBox��5      $��2��6b   ��6*   ��  �� ElementName$ fontSizeSlider�� �� Path$ Value�6b   �� 5   
   $��
Example 01��6   $��3��6�   ��6&   �� $ FontNameList��$
 Text���6a   �� $ SizeTextBox��$
 Text�6�   5      5      