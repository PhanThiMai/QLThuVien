   M S B A M L   `   `   `  ����D  @QLThuVien, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:QLThuVien	QLThuVien  5          QLThuVien.uc_khoSach   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      )localclr-namespace:QLThuVien     5      V RMaterialDesignThemes.Wpf, Version=2.5.1.1345, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5         MaterialDesignBody#���   5	      $��Regular"�5
      $��13(�5      &   System.Windows.Media.TextOptions    TextFormattingMode$  Ideal=�5         TextRenderingMode$
 Auto=�5        MaterialDesignPaper#���  5        MaterialDesignFont#���  5      .��5      � 
�������.+�5   
   � y�6   ��  �� Path$ SachGrid�  	Converter �� 	Converter# [  � 	Resources 5       �� 
TargetType �� Property �� Value��%W   '�       �� 5      " �6   .�5      ��  � ��$ 5 0 0 5q�6/   5      5       � RowDefinitions 5      �� 5      $
��auto �6    60   �� 5      $
��auto �6    60   �� 5       $
��auto �6    60   �� 5"      6#   �� 5#      $��50 �6    6.   .+�5'      � $��0��6   .+�5(      �� $��THƯ VIỆN SÁCH��6   $��20(�61   $��Normal$�6?   $��Center=�6R   
����d�5*      5+      � 5-      $��1��6   	 � ColumnDefinitions	 5.      �� 5/      6)   �� 50      6)   �� 51      6)   .+�55      � $��0��6   .+�56      �� 
 �� Text$
 --- Loại Sách ---��6    �� 
IsEditable . $��0,0,93,0q�6j   ��68   �� *	LOAICBX+57      58      � 59      $��1��6   .+�5:      �� $
 --- Năm SX ---��6    . $��
19,0,125,0q�6h   ��65   �� *
NAMSXCBX+5;      5<      � 5=      $��2��6   .+�5>      �� $
 --- Tác Giả ---��6    . $��0,0,68,0q�6j   ��66   �� *	TACGIACBX+5?      5@      5C      � 5E      $��2��6   	 5F      �� 5G      6)   �� 5H      6)   .+�5J      � $��0��6   .+�5K      �� )  #MaterialDesignThemes.Wpf.HintAssist   Hint$* $Nhập thông tin muốn tìm kiếm��5L      $��238,0,-89,0q�5M   ;   ��6   �� *KSThongTinTimKiem+6;   5Q      � 5R      $��1��6   .+�5S      ��  " MaterialDesignRaisedDarkButton#��[ 5T      $	��100��5U       � ToolTip$8 2Resource name: MaterialDesignRaisedLightDarkButton��5W      ��5V      �� *	KSTimKiem+.��5W   T   _Tìm kiếm5X      5Y      5[      � 5]      $��3��6   .+�5^      �� ��6   �� *
SACHLIST+ �� View 5_      �� 5`      .P�5a      �� $��Mã Phiếu��6-    �� Width$	 100��6?   -   5        
MASACH�� �� DisplayMemberBinding 5a   [   �� *MASACH+6�   �� 5b      $��Mã Độc Giả��6-   $	 120��6A   -   5        TENSACH�� 5b   ^   �� *	TENSACH+6�   �� 5c      $��	Mã Sách��6-   -   5        
MALOAISACH�� 5c   R   �� *
MALOAISACH+6�   �� 5d      $��Ngày Mượn��6-   -   5        
TACGIA�� 5d   P   �� *TACGIA+6z   �� 5e      $��Ngày Trả dự kiến��6-   -   5        
NAMSANXUAT�� 5e   [   �� *
NAMSANXUAT+6�   5g      5i      5l      � 5m      $��4��6   .+�5n      �� #��[ 5o      $8 2Resource name: MaterialDesignRaisedLightDarkButton��5r      $��
619,6,10,7q�6T   ��5p      �� *KSThemVaoGio+.��5r   h   _Thêm vào giỏ5s      5t      5u      5y      5|      