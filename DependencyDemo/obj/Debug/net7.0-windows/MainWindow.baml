   M S B A M L   `   `   `  ����I  EDependencyDemo, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:DependencyDemoDependencyDemo  5   	       DependencyDemo.MainWindow   5   	   W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   .localclr-namespace:DependencyDemo     5   	     � Title$  
MainWindow��5   	   $	��330��6   $	��200��6)   .��5	      �� .+�5
   
   �� -   5         ��Name$
 myTb��5
      $��Hello World��6"   $	��110��65   $��20(�6A   ��5      �� 5       �� 
TargetType" ��6    �� Triggers 5      P� 5       P� Property �@J�IsMouseOver P� Value$
 True��69   . �5      ��  �� Property � �� �� Value
 ��  �6J   5      5      5      �� 5   
   -   5        $��5q�5      $	��120��6   .��6=   Use Awesomeness6N      DependencyDemo.MyUC  5   
   -   5          Name$ 
MyUCinMain��5      	   Awesomeness$
	 4000��6)   ��5      �� 5      "  6    5      P� 5       �@ Awesomeness$ 10000��69   . �5      ��  � ��
 �  ��6I   5      5      5       �� 5!   
   -   5        
 ��Name$	
 lbl��5"      $��30(�5$      $��Center=�5%      ��5#      ��  �� ElementName$ 
MyUCinMain�� �� Path$ Awesomeness�5&      5'      5(      